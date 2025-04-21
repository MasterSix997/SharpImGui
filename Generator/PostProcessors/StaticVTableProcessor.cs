using CppAst;
using Generator.CSharp;

namespace Generator.PostProcessors;

public struct StaticVTableProcessor : IPostProcessor
{
    public void Process(CSharpGenerated generated)
    {
        var file = CreateImGuiNativeClass(generated);
        var methods = file.Container.Classes[0].Methods.Where(m => m.Metadata is CppFunction).ToArray();
        CreateFunctionTableClass(methods, generated);
    }

    private static GeneratedFile CreateImGuiNativeClass(CSharpGenerated generated)
    {
        var methods = generated.Output.DefinitionsWithoutFiles.Methods;
        
        for (var i = 0; i < methods.Count; i++)
        {
            ProcessMethod(methods, i);
        }
        var imGuiNativeClass = new CsClass("ImGuiNative", CsClassKind.Class)
        {
            Visibility = CsVisibility.Public,
            IsPartial = true,
            IsUnsafe = true
        };
        
        var imGuiConstructor = new CsMethod("ImGuiNative")
        {
            IsStatic = true,
            ReturnType = null,
            WriteBody = writer =>
            {
                writer.WriteLine("InitApi(new NativeLibraryContext(LibraryLoader.LoadLibrary(GetLibraryName, null)));");
            }
        };
        imGuiNativeClass.Constructors.Add(imGuiConstructor);
        
        var getLibraryNameMethod = new CsMethod("GetLibraryName")
        {
            Visibility = CsVisibility.Public,
            IsStatic = true,
            ReturnType = new CsUnresolvedType("string", CsTypeKind.Primitive),
            WriteBody = writer =>
            {
                writer.WriteLine("return \"cimgui\";");
            }
        };
        imGuiNativeClass.Methods.Add(getLibraryNameMethod);
        methods.MoveTo(imGuiNativeClass.Methods);
        methods = imGuiNativeClass.Methods;
        var imGuiNamespace = new CsNamespace("SharpImGui");
        imGuiNamespace.Classes.Add(imGuiNativeClass);
        
        return generated.Output.AddFile("ImGuiNative.cs", imGuiNamespace, usings: ["System", "System.Numerics", "System.Runtime.InteropServices", "System.Runtime.CompilerServices"]);
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
        var vTableClass = new CsClass("ImGuiNative", CsClassKind.Class)
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
                    writer.WriteLine($"FuncTable.Load({i}, \"{methods[i].Name}\");");
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
        var vTableNamespace = new CsNamespace("SharpImGui");
        vTableNamespace.Classes.Add(vTableClass);
        generated.Output.AddFile("FunctionTable.cs", vTableNamespace, usings: ["System", "System.Numerics", "System.Runtime.InteropServices"]);
    }
}