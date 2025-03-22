using System.Text.Json;

namespace Generator.CodeGen;

public class CodeGenerator
{
    private const string OutputFolder = "../../../../SharpImGui/Generated";
    private const string DockerFolder = "../../../Docker";
    private const string CImGuiFolder = $"{DockerFolder}/cimgui";
    
    private const string DefinitionsFile = "definitions.json";
    private const string TypedefsFile = "typedefs_dict.json";
    private const string StructsAndEnumsFile = "structs_and_enums.json";
    
    private readonly List<IPostProcessor> _postProcessors = [];

    public void GenerateCSharp()
    {
        var nativeDefinitions = ParseToNativeDefinitions(CImGuiFolder);
        
        var csharpGenerator = new CSharpGenerator(nativeDefinitions, OutputFolder);
        csharpGenerator.Generate();
        
        foreach (var postProcessor in _postProcessors)
        {
            postProcessor.Process(csharpGenerator.CSharpGenerated);
        }
        
        DeleteFolderRecursively(OutputFolder);
        
        csharpGenerator.WriteFiles();
    }
    
    public void DeleteFolderRecursively(string folder)
    {
        if (!Directory.Exists(folder))
            return;
        
        var files = Directory.GetFiles(folder);
        foreach (var file in files)
        {
            File.Delete(file);
        }
        
        var directories = Directory.GetDirectories(folder);
        foreach (var directory in directories)
        {
            DeleteFolderRecursively(directory);
        }
        
        Directory.Delete(folder);
    }
    
    public void AddPostProcessor(in IPostProcessor postProcessor)
    {
        _postProcessors.Add(postProcessor);
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
}
