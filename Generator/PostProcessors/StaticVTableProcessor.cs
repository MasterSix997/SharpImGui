using CppAst;
using Generator.CSharp;

namespace Generator.PostProcessors;

public struct StaticVTableProcessor : IPostProcessor
{
    public void Process(CSharpGenerated generated)
    {
        var file = CreateLibraryNativeClass(generated);
        file.Type = GeneratedFile.FileType.NativeMethods;
        var methods = file.Container.Classes[0].Methods.Where(m => m.Metadata is CppFunction).ToArray();
        CreateFunctionTableClass(methods, generated);
    }

    private static GeneratedFile CreateLibraryNativeClass(CSharpGenerated generated)
    {
        var methods = generated.Output.DefinitionsWithoutFiles.Methods;
        
        for (var i = 0; i < methods.Count; i++)
        {
            ProcessMethod(methods, i);
        }

        var nativeName = $"{generated.Settings.OriginalLibraryName}Native";
        var nativeClass = new CsClass(nativeName, CsClassKind.Class)
        {
            Visibility = CsVisibility.Public,
            IsPartial = true,
            IsUnsafe = true
        };
        
        var constructor = new CsMethod("")
        {
            IsStatic = true,
            ReturnType = nativeClass,
            WriteBody = writer =>
            {
                writer.WriteLine("InitApi(new NativeLibraryContext(LibraryLoader.LoadLibrary(GetLibraryName, null)));");
            }
        };
        nativeClass.Constructors.Add(constructor);
        
        var getLibraryNameMethod = new CsMethod("GetLibraryName")
        {
            Visibility = CsVisibility.Public,
            IsStatic = true,
            ReturnType = new CsUnresolvedType("string", CsTypeKind.Primitive),
            WriteBody = writer =>
            {
                writer.WriteLine($"return \"{generated.Settings.CLibraryName}\";");
            }
        };
        nativeClass.Methods.Add(getLibraryNameMethod);
        
        methods.MoveTo(nativeClass.Methods);
        var nativeNamespace = new CsNamespace(generated.Settings.Namespace);
        nativeNamespace.Classes.Add(nativeClass);
        
        return generated.Output.AddFile($"{nativeName}.cs", nativeNamespace, usings: generated.Settings.Usings);
    }

    private static void ProcessMethod(CsContainerList<CsMethod> methods, int i)
    {
        var csMethod = methods[i];
        csMethod.Attributes.Clear();
        csMethod.Attributes.Add(new CsAttribute("MethodImpl") {Arguments = "MethodImplOptions.AggressiveInlining"});
        csMethod.IsExtern = false;
        csMethod.WriteBody = writer =>
        {
            writer.StartLine();
            if (csMethod.ReturnType is not CsPrimitiveType { Kind: CsPrimitiveKind.Void })
                writer.Write("return ");

            if (csMethod.ReturnType is CsPointerType)
            {
                writer.Write($"({csMethod.ReturnType.TypeName})");
            }
            writer.Write("((delegate* unmanaged[Cdecl]<");

            foreach (var csParameter in csMethod.Parameters)
            {
                if (csParameter.Type is CsPointerType)
                    writer.Write("IntPtr");
                else
                    writer.Write(csParameter.Type.TypeName);

                writer.Write(", ");
            }

            if (csMethod.ReturnType is CsPointerType)
                writer.Write("IntPtr");
            else
                writer.Write(csMethod.ReturnType.TypeName);

            writer.Write($">)FuncTable[{i}])(");

            for (var j = 0; j < csMethod.Parameters.Count; j++)
            {
                var csParameter = csMethod.Parameters[j];
                if (csParameter.Type is CsPointerType)
                    writer.Write("(IntPtr)");

                writer.Write(csParameter.Name);
                if (j < csMethod.Parameters.Count - 1)
                    writer.Write(", ");
            }

            writer.Write(");").EndLine();
        };
    }

    private static void CreateFunctionTableClass(CsMethod[] methods, CSharpGenerated generated)
    {
        var nativeName = $"{generated.Settings.OriginalLibraryName}Native";
        var vTableClass = new CsClass(nativeName, CsClassKind.Class)
        {
            Visibility = CsVisibility.Public,
            IsPartial = true,
            IsUnsafe = true
        };
        var funcTableField = new CsField(new CsUnresolvedType("FunctionTable", CsTypeKind.StructOrClass), "FuncTable")
        {
            Visibility = CsVisibility.Internal,
            IsStatic = true,
        };
        vTableClass.Fields.Add(funcTableField);

        var methodsOriginalNames = methods.Select(m => m.Name).ToArray();
        var initApiMethod = new CsMethod("InitApi")
        {
            Visibility = CsVisibility.Public,
            IsStatic = true,
            Parameters = { new CsParameter(new CsUnresolvedType("NativeLibraryContext", CsTypeKind.StructOrClass), "context") },
            WriteBody = writer =>
            {
                writer.WriteLine($"FuncTable = new FunctionTable(context, {methods.Length});");
                for (var i = 0; i < methods.Length; i++)
                {
                    writer.WriteLine($"FuncTable.Load({i}, \"{methodsOriginalNames[i]}\");");
                }
            }
        };
        vTableClass.Methods.Add(initApiMethod);
        var freeApiMethod = new CsMethod("FreeApi")
        {
            Visibility = CsVisibility.Public,
            IsStatic = true,
            WriteBody = writer =>
            {
                writer.WriteLine("FuncTable.Free();");
            }
        };
        vTableClass.Methods.Add(freeApiMethod);
        var vTableNamespace = new CsNamespace(generated.Settings.Namespace);
        vTableNamespace.Classes.Add(vTableClass);
        generated.Output.AddFile("FunctionTable.cs", vTableNamespace, usings: generated.Settings.Usings)
            .Type = GeneratedFile.FileType.Internal;
    }
}