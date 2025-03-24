using Generator.CodeGen.CSharp;

namespace Generator.CodeGen.PostProcessors;

public struct FileSeparatorProcessor : IPostProcessor
{
    private static CsNamespace DefaultNamespace => new("SharpImGui");
    
    public void Process(CSharpGenerated generated)
    {
        var output = generated.Output;

        var enumsNamespace = new CsNamespace("SharpImGui");
        output.DefinitionsWithoutFiles.Enums.MoveTo(enumsNamespace.Enums);
        output.AddFile("Enums.cs", enumsNamespace, usings: ["System"]);

        GenerateStructFiles(output, output.DefinitionsWithoutFiles);
        // var structsNamespace = new CsNamespace("SharpImGui");
        // output.DefinitionsWithoutFiles.Classes.MoveTo(structsNamespace.Classes);
        // output.AddFile("Structs.cs", structsNamespace, usings: ["System", "System.Numerics", "System.Runtime.InteropServices"]);

        var nativeStruct = new CsClass("ImGuiNative", CsClassKind.Struct);
        output.DefinitionsWithoutFiles.Methods.MoveTo(nativeStruct.Methods);
        var nativeNamespace = new CsNamespace("SharpImGui");
        nativeNamespace.Classes.Add(nativeStruct);
        output.AddFile("ImGuiNative.cs", nativeNamespace, usings: ["System", "System.Numerics", "System.Runtime.InteropServices"]);
        
        var delegatesNamespace = new CsNamespace("SharpImGui");
        output.DefinitionsWithoutFiles.Delegates.MoveTo(delegatesNamespace.Delegates);
        output.AddFile("Delegates.cs", delegatesNamespace, usings: ["System", "System.Numerics", "System.Runtime.InteropServices"]);
        
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
        
        // var internalStructsNamespace = new CsNamespace("SharpImGui");
        // for (var i = structsNamespace.Classes.Count - 1; i > 0 ; i--)
        // {
        //     var @struct = structsNamespace.Classes[i];
        //     if (@struct.Metadata is true)
        //     {
        //         structsNamespace.Classes.RemoveAt(i);
        //         internalStructsNamespace.Classes.Add(@struct);
        //     }
        // }
        // output.AddFile("InternalStructs.cs", internalStructsNamespace, "Internal", ["System", "System.Numerics", "System.Runtime.InteropServices"]);
        
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
        output.AddFile("InternalImGuiNative.cs", internalNativeNamespace, "Internal", ["System", "System.Numerics", "System.Runtime.InteropServices"]);
    }

    private void GenerateStructFiles(CsOutput output, ICsDeclarationContainer container)
    {
        var ptrStructs = new Dictionary<string, CsClass>();
        
        for (var i = container.Classes.Count - 1; i >= 0; i--)
        {
            var csStruct = container.Classes[i];
            container.Classes.RemoveAt(i);
            
            if (csStruct.Name.EndsWith("Ptr"))
            {
                ptrStructs.Add(csStruct.Name[..^3], csStruct);
                continue;
            }

            var structNamespace = DefaultNamespace;
            structNamespace.Classes.Add(csStruct);
            if (ptrStructs.TryGetValue(csStruct.Name, out var ptrStruct))
            {
                structNamespace.Classes.Add(ptrStruct);
                ptrStructs.Remove(csStruct.Name);
            }
            var subDir = csStruct.Metadata is true ? "Internal/Structs" : "Structs";
            output.AddFile($"{csStruct.Name}.cs", structNamespace, subDir, ["System", "System.Numerics", "System.Runtime.InteropServices"]);
        }
    }
}