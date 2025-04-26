using CppAst;
using Generator.CSharp;

namespace Generator;

public class GeneratorSettings
{
    private const string RootProjectDirectory = "../../../../../";
    private const string DockerDirectory = "../../../../Docker";
    private const string HeadersFolder = "include";
    private const string DefinitionsFolder = "definitions";
    
    public string OutputDirectory;
    public string MetadataDirectory;
    
    public string Namespace;
    public readonly CppParserOptions CppParserOptions = new();
    public readonly List<CsType> Types = new();
    public readonly Dictionary<string, string> TypeMappings = new();
    public readonly List<string> Usings = [];
    public string FunctionsPrefix = ""; 
    public bool MergeOverloads;
    public readonly List<string> OverloadsKnowTypes = [];
    
    public string OriginalLibraryName { get; set; }
    public string GeneratedLibraryName { get; set; }
    public string CLibraryName { get; set; }
    public string CLibraryHeaderFile { get; set; }

    public string CHeaderFilePath => Path.GetFullPath($"{MetadataDirectory}/{HeadersFolder}/{CLibraryHeaderFile}");
    public string DefinitionsDirectory => Path.GetFullPath($"{MetadataDirectory}/{DefinitionsFolder}");

    public GeneratorSettings(string originalLibraryName, string generatedLibraryName, string @namespace)
    {
        OriginalLibraryName = originalLibraryName;
        GeneratedLibraryName = generatedLibraryName;
        Namespace = @namespace;
        
        CLibraryName = $"c{originalLibraryName.ToLower()}";
        
        OutputDirectory = $"{RootProjectDirectory}/{GeneratedLibraryName}/Generated";
        MetadataDirectory = $"{DockerDirectory}/{CLibraryName}";
        CLibraryHeaderFile = $"{CLibraryName}.h";
    }
}