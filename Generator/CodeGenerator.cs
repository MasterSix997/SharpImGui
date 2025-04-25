using System.Text.Json;
using CppAst;

namespace Generator;

public class CodeGenerator(GeneratorSettings settings)
{
    // private const string OutputFolder = "../../../../../SharpImGui/Generated";
    // private const string DockerFolder = "../../../../Docker";
    // private const string CImGuiFolder = $"{DockerFolder}/cimgui";
    //
    // private const string CImGuiHeaderFile = "cimgui.h";
    
    private readonly List<IPostProcessor> _postProcessors = [];

    public void GenerateCSharp()
    {
        settings.CppParserOptions.IncludeFolders.Add(Path.GetFullPath($"{settings.MetadataDirectory}/../cimgui/include"));
        var cppCompilation = CppParser.ParseFile(settings.CHeaderFilePath, settings.CppParserOptions);
        
        if (cppCompilation.HasErrors)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (var error in cppCompilation.Diagnostics.Messages)
            {
                Console.WriteLine(error);
            }
            Console.ResetColor();
        }

        var cppToCSharp = new CppToCSharp(cppCompilation, settings);
        cppToCSharp.Generate();

        var definitionProvider = new CImGuiJsonProvider();
        definitionProvider.Parse(settings.DefinitionsDirectory);
        cppToCSharp.CSharpGenerated.NativeDefinitionProvider = definitionProvider;
        
        foreach (var postProcessor in _postProcessors)
        {
            postProcessor.Process(cppToCSharp.CSharpGenerated);
        }
        
        DeleteFolderRecursively(settings.OutputDirectory);
        
        cppToCSharp.WriteFiles();
    }

    private static void DeleteFolderRecursively(string folder)
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
}
