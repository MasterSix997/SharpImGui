using System.Text.Json;
using CppAst;

namespace Generator;

public class CodeGenerator
{
    private const string OutputFolder = "../../../../../SharpImGui/Generated";
    private const string DockerFolder = "../../../../Docker";
    private const string CImGuiFolder = $"{DockerFolder}/cimgui";
    private const string ImGuiFolder = $"{CImGuiFolder}/imgui";
    
    private const string DefinitionsFile = "definitions.json";
    private const string TypedefsFile = "typedefs_dict.json";
    private const string StructsAndEnumsFile = "structs_and_enums.json";
    private const string CImGuiHeaderFile = "cimgui.h";
    
    private readonly List<IPostProcessor> _postProcessors = [];

    public void GenerateCSharp()
    {
        var cppCompilation = CppParser.ParseFile(Path.GetFullPath(Path.Combine(CImGuiFolder, "include", CImGuiHeaderFile)), new CppParserOptions
        {
            // IncludeFolders = { Path.GetFullPath(ImGuiFolder) },
            Defines = { "CIMGUI_DEFINE_ENUMS_AND_STRUCTS" }
        });
        if (cppCompilation.HasErrors)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (var error in cppCompilation.Diagnostics.Messages)
            {
                Console.WriteLine(error);
            }
            Console.ResetColor();
        }

        var cppToCSharp = new CppToCSharp(cppCompilation, OutputFolder);
        cppToCSharp.Generate();
        
        foreach (var postProcessor in _postProcessors)
        {
            postProcessor.Process(cppToCSharp.CSharpGenerated);
        }
        
        DeleteFolderRecursively(OutputFolder);
        
        cppToCSharp.WriteFiles();
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
