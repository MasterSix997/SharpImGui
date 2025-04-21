using Generator.CSharp;

namespace Generator.PostProcessors;

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
        
        var delegatesNamespace = new CsNamespace("SharpImGui");
        output.DefinitionsWithoutFiles.Delegates.MoveTo(delegatesNamespace.Delegates);
        output.AddFile("Delegates.cs", delegatesNamespace, usings: ["System", "System.Numerics", "System.Runtime.InteropServices"]);
        
        // Internals
        // var internalEnumsNamespace = new CsNamespace("SharpImGui");
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
            var subDir = csStruct.Metadata is NativeEnum { IsInternal: true } ? "Internal/Structs" : "Structs";
            output.AddFile($"{csStruct.Name}.cs", structNamespace, subDir, ["System", "System.Numerics", "System.Runtime.InteropServices"]);
        }
    }
}