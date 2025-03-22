using Generator.CodeGen.CSharp;

namespace Generator.CodeGen.PostProcessors;

public struct FileSeparatorProcessor : IPostProcessor
{
    public void Process(CSharpGenerated generated)
    {
        var output = generated.Output;

        var enumsNamespace = new CsNamespace("SharpImGui");
        output.DefinitionsWithoutFiles.Enums.MoveTo(enumsNamespace.Enums);
        output.AddFile("Enums.cs", enumsNamespace, usings: ["System"]);

        var structsNamespace = new CsNamespace("SharpImGui");
        output.DefinitionsWithoutFiles.Classes.MoveTo(structsNamespace.Classes);
        output.AddFile("Structs.cs", structsNamespace);

        var nativeStruct = new CsClass("ImGuiNative", CsClassKind.Struct);
        output.DefinitionsWithoutFiles.Methods.MoveTo(nativeStruct.Methods);
        var nativeNamespace = new CsNamespace("SharpImGui");
        nativeNamespace.Classes.Add(nativeStruct);
        output.AddFile("ImGuiNative.cs", nativeNamespace);
        
        // Internals
        var internalEnumsNamespace = new CsNamespace("SharpImGui");
        for (var i = enumsNamespace.Enums.Count - 1; i > 0 ; i--)
        {
            var @enum = enumsNamespace.Enums[i];
            if (@enum.Metadata is true)
            {
                enumsNamespace.Enums.RemoveAt(i);
                internalEnumsNamespace.Enums.Add(@enum);
            }
        }
        output.AddFile("InternalEnums.cs", internalEnumsNamespace, "Internal", ["System"]);
        
        var internalStructsNamespace = new CsNamespace("SharpImGui");
        for (var i = structsNamespace.Classes.Count - 1; i > 0 ; i--)
        {
            var @struct = structsNamespace.Classes[i];
            if (@struct.Metadata is true)
            {
                structsNamespace.Classes.RemoveAt(i);
                internalStructsNamespace.Classes.Add(@struct);
            }
        }
        output.AddFile("InternalStructs.cs", internalStructsNamespace, "Internal");
        
        var internalNativeStruct = new CsClass("InternalImGuiNative", CsClassKind.Struct)
        {
            Visibility = CsVisibility.Public,
            IsUnsafe = true
        };
        for (var i = nativeStruct.Methods.Count - 1; i > 0 ; i--)
        {
            var method = nativeStruct.Methods[i];
            if (method.Metadata is true)
            {
                nativeStruct.Methods.RemoveAt(i);
                internalNativeStruct.Methods.Add(method);
            }
        }
        var internalNativeNamespace = new CsNamespace("SharpImGui");
        internalNativeNamespace.Classes.Add(internalNativeStruct);
        output.AddFile("InternalImGuiNative.cs", internalNativeNamespace, "Internal");
    }
}

public struct EnumsProcessor : IPostProcessor
{
    public void Process(CSharpGenerated generated)
    {
        CleanupEnums(generated.Definitions);
    }

    private static void CleanupEnums(ICsDeclarationContainer container)
    {
        foreach (var csEnum in container.Enums)
        {
            foreach (var item in csEnum.Items)
            {
                var lenght = csEnum.Name.Length;
                if (csEnum.Name.EndsWith("Private_"))
                    lenght -= 7;
                
                item.Name = item.Name[lenght..];

                if (!char.IsNumber(item.Name[1]))
                    item.Name = item.Name.Trim('_');
            }

            csEnum.Name = csEnum.Name.TrimEnd('_');
        }
    }
}

public struct CommentsProcessor : IPostProcessor
{
    public void Process(CSharpGenerated generated)
    {
        RecursiveCleanupComments(generated.Definitions);
    }

    private void RecursiveCleanupComments(ICsDeclarationContainer container)
    {
        foreach (var child in container.Children())
        {
            if (child.Comment is not CsDocComment docComment) continue;

            if (docComment.Above is not null)
            {
                CleanupSlashes(ref docComment.Above);
                AddBreakLineTagXML(ref docComment.Above);
            }

            if (docComment.SameLine is not null)
            {
                CleanupSlashes(ref docComment.SameLine);
                AddBreakLineTagXML(ref docComment.SameLine);
            }

            if (child is ICsDeclarationContainer childContainer)
            {
                RecursiveCleanupComments(childContainer);
            }
        }
    }

    private void CleanupSlashes(ref string comment)
    {
        var splits = comment.Split('\n');
        for (var i = 0; i < splits.Length; i++)
        {
            var split = splits[i];
            if (split.StartsWith("// "))
                splits[i] = split[3..];
        }
        comment = string.Join('\n', splits);
    }
    
    private void AddBreakLineTagXML(ref string comment)
    {
        var splits = comment.Split('\n');
        for (var i = 0; i < splits.Length; i++)
        {
            splits[i] = string.Concat(splits[i], "<br/>");
        }
        comment = string.Join('\n', splits);
    }
}