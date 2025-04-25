using Generator.CSharp;

namespace Generator.PostProcessors;

public struct FileSeparatorProcessor : IPostProcessor
{
    public void Process(CSharpGenerated generated)
    {
        var output = generated.Output;

        var enumsNamespace = new CsNamespace(generated.Settings.Namespace);
        output.DefinitionsWithoutFiles.Enums.MoveTo(enumsNamespace.Enums);
        output.AddFile("Enums.cs", enumsNamespace, usings: ["System"])
            .Type = GeneratedFile.FileType.Enum;

        GenerateStructFiles(output, output.DefinitionsWithoutFiles, generated.Settings);
        
        var delegatesNamespace = new CsNamespace(generated.Settings.Namespace);
        output.DefinitionsWithoutFiles.Delegates.MoveTo(delegatesNamespace.Delegates);
        output.AddFile("Delegates.cs", delegatesNamespace, usings: ["System", "System.Numerics", "System.Runtime.InteropServices", ..generated.Settings.Usings])
            .Type = GeneratedFile.FileType.Delegate;
        
        // Internals
        // var internalEnumsNamespace = new CsNamespace(generated.Settings.Namespace);
        // for (var i = enumsNamespace.Enums.Count - 1; i > 0 ; i--)
        // {
        //     var @enum = enumsNamespace.Enums[i];
        //     if (@enum.Metadata is NativeEnum { IsInternal: true })
        //     {
        //         enumsNamespace.Enums.RemoveAt(i);
        //         internalEnumsNamespace.Enums.Add(@enum);
        //     }
        // }
        // output.AddFile("InternalEnums.cs", internalEnumsNamespace, "Internal", ["System"]);
    }

    private void GenerateStructFiles(CsOutput output, ICsDeclarationContainer container, GeneratorSettings settings)
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

            var structNamespace = new CsNamespace(settings.Namespace);
            structNamespace.Classes.Add(csStruct);
            if (ptrStructs.TryGetValue(csStruct.Name, out var ptrStruct))
            {
                structNamespace.Classes.Add(ptrStruct);
                ptrStructs.Remove(csStruct.Name);
            }
            var subDir = csStruct.Metadata is NativeEnum { IsInternal: true } ? "Internal/Structs" : "Structs";
            output.AddFile($"{csStruct.Name}.cs", structNamespace, subDir, ["System", "System.Numerics", "System.Runtime.InteropServices", ..settings.Usings])
                .Type = GeneratedFile.FileType.Struct;
        }
    }
}