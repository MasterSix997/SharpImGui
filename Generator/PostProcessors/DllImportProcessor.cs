using CppAst;
using Generator.CSharp;

namespace Generator.PostProcessors;

public class DllImportProcessor : IPostProcessor
{
    public void Process(CSharpGenerated generated)
    {
        var output = generated.Output;
        var settings = generated.Settings;
        
        var methods = output.DefinitionsWithoutFiles.Methods;
        
        for (var i = 0; i < methods.Count; i++)
        {
            ProcessMethod(methods[i]);
        }
        
        var nativeName = $"{settings.OriginalLibraryName}Native";
        var nativeClass = new CsClass(nativeName, CsClassKind.Class)
        {
            Visibility = CsVisibility.Public,
            IsPartial = true,
            IsUnsafe = true
        };
        
        // var getLibraryNameMethod = new CsMethod("GetLibraryName")
        // {
        //     Visibility = CsVisibility.Public,
        //     IsStatic = true,
        //     ReturnType = new CsUnresolvedType("string", CsTypeKind.Primitive),
        //     WriteBody = writer =>
        //     {
        //         writer.WriteLine($"return \"{settings.CLibraryName}\";");
        //     }
        // };
        // nativeClass.Methods.Add(getLibraryNameMethod);
        var libraryNameField = new CsField(generated.GetCsType("string")!, "LibraryName")
        {
            IsConst = true,
            InitValue = new CsValue($"\"{settings.CLibraryName}\""),
            Visibility = CsVisibility.Public,
        };
        nativeClass.Fields.Add(libraryNameField);
        
        methods.MoveTo(nativeClass.Methods);
        var nativeNamespace = new CsNamespace(settings.Namespace);
        nativeNamespace.Classes.Add(nativeClass);
        
        var file = output.AddFile($"{nativeName}.cs", nativeNamespace, usings: settings.Usings);
        file.Type = GeneratedFile.FileType.NativeMethods;
    }

    private void ProcessMethod(CsMethod method)
    {
        var entryPoint = (method.Metadata as CppFunction)!.Name;
        method.Attributes.Clear();
        method.Attributes.Add(new CsAttribute("DllImport")
        {
            Arguments = $"LibraryName, EntryPoint = \"{entryPoint}\", CallingConvention = CallingConvention.Cdecl"
        });
    }
}