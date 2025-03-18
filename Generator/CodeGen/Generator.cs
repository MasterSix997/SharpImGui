using System.Text.Json;
using SharpImGui.Generator.CodeGen.CSharp;

namespace SharpImGui.Generator.CodeGen;

public class Generator
{
    private const string DockerFolder = "../../../Docker";
    private const string CImGuiFolder = $"{DockerFolder}/cimgui";
    
    private const string DefinitionsFile = "definitions.json";
    private const string TypedefsFile = "typedefs_dict.json";
    private const string StructsAndEnumsFile = "structs_and_enums.json";

    public void GenerateCImGui()
    {
        var nativeDefinitions = ParseToNativeDefinitions(CImGuiFolder);
        var csharpDefinitions = NativeToCSharp(nativeDefinitions);
    }

    private NativeDefinitions ParseToNativeDefinitions(string folder)
    {
        var definitionsPath = Path.GetFullPath(Path.Combine(folder, DefinitionsFile));
        var typedefsPath = Path.GetFullPath(Path.Combine(folder, TypedefsFile));
        var structsAndEnumsPath = Path.GetFullPath(Path.Combine(folder, StructsAndEnumsFile));

        if (!File.Exists(definitionsPath))
            throw new FileNotFoundException("Definitions file not found", definitionsPath);
        if (!File.Exists(typedefsPath))
            throw new FileNotFoundException("Typedefs file not found", typedefsPath);
        if  (!File.Exists(structsAndEnumsPath))
            throw new FileNotFoundException("Structs and enums file not found", structsAndEnumsPath);
        
        var definitionsJson = ReadJson(definitionsPath);
        var typedefsJson = ReadJson(typedefsPath);
        var structsAndEnumsJson = ReadJson(structsAndEnumsPath);

        return NativeDefinitions.FromJson(definitionsJson, structsAndEnumsJson, typedefsJson);
    }

    private JsonDocument ReadJson(string path)
    {
        var fileContent = File.ReadAllText(path);
        return JsonDocument.Parse(fileContent);
    }

    private CsGlobalDeclarationContainer NativeToCSharp(NativeDefinitions definitions)
    {
        var globalContainer = new CsGlobalDeclarationContainer();
        
        var csharpGenerator = new CSharpGenerator(definitions);
        csharpGenerator.Generate();
        
        return globalContainer;
    }
}