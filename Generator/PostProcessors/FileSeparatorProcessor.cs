using CppAst;
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

        GenerateStructFiles(output, output.DefinitionsWithoutFiles, generated);
        
        var delegatesNamespace = new CsNamespace(generated.Settings.Namespace);
        output.DefinitionsWithoutFiles.Delegates.MoveTo(delegatesNamespace.Delegates);
        output.AddFile("Delegates.cs", delegatesNamespace, usings: generated.Settings.Usings)
            .Type = GeneratedFile.FileType.Delegate;
        
        // Internals
        var internalEnumsNamespace = new CsNamespace(generated.Settings.Namespace);
        var nativeEnums = generated.NativeDefinitionProvider?.NativeDefinitions.Types.Enums;
        if (nativeEnums is null)
            return;
        
        for (var i = enumsNamespace.Enums.Count - 1; i > 0 ; i--)
        {
            var @enum = enumsNamespace.Enums[i];
            if (@enum.Metadata is not CppEnum cppEnum) 
                continue;
            
            var nativeEnum = nativeEnums.FirstOrDefault(n => n.Name == cppEnum.Name);
            if (nativeEnum is { IsInternal: true })
            {
                enumsNamespace.Enums.RemoveAt(i);
                internalEnumsNamespace.Enums.Add(@enum);
            }
        }

        if (internalEnumsNamespace.Enums.Count > 0)
            output.AddFile("InternalEnums.cs", internalEnumsNamespace, "Internal", ["System"]);
    }

    private void GenerateStructFiles(CsOutput output, ICsDeclarationContainer container, CSharpGenerated generated)
    {
        var ptrStructs = new Dictionary<string, CsClass>();
        var nativeStructs = generated.NativeDefinitionProvider?.NativeDefinitions.Types.Structs;
        
        for (var i = container.Classes.Count - 1; i >= 0; i--)
        {
            var csStruct = container.Classes[i];
            container.Classes.RemoveAt(i);
            
            if (csStruct.Name.EndsWith("Ptr"))
            {
                ptrStructs.Add(csStruct.Name[..^3], csStruct);
                continue;
            }

            var structNamespace = new CsNamespace(generated.Settings.Namespace);
            structNamespace.Classes.Add(csStruct);
            if (ptrStructs.TryGetValue(csStruct.Name, out var ptrStruct))
            {
                structNamespace.Classes.Add(ptrStruct);
                ptrStructs.Remove(csStruct.Name);
            }

            var cppStruct = csStruct.Metadata as CppClass;
            var nativeStruct = nativeStructs?.FirstOrDefault(n => n.Name == cppStruct?.Name);
            var subDir = nativeStruct is { IsInternal: true } ? "Internal/Structs" : "Structs";
            output.AddFile($"{csStruct.Name}.cs", structNamespace, subDir, generated.Settings.Usings)
                .Type = GeneratedFile.FileType.Struct;
        }
    }
}