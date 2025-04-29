using System.Diagnostics.CodeAnalysis;

namespace Generator.CSharp;

public class GeneratedFile
{
    public enum FileType
    {
        Unknown,
        NativeMethods,
        ManagedFunction,
        Enum,
        Struct,
        Constant,
        Delegate,
        Internal
    }
    
    public string FileName { get; set; }
    public string Directory { get; set; }
    public CsNamespace Container { get; set; }
    public List<string>? Usings { get; set; }
    public FileType Type { get; set; } = FileType.Unknown;

    public GeneratedFile(string fileName, string directory, CsNamespace container)
    {
        FileName = fileName;
        Directory = directory;
        Container = container;
    }

    public void SaveToFile()
    {
        if (!System.IO.Directory.Exists(Directory))
            System.IO.Directory.CreateDirectory(Directory);
        
        var outputPath = Path.Combine(Directory, FileName);
        var codeWriter = new StreamCodeWriter(outputPath);
        WriteTo(codeWriter);
        Container.WriteTo(codeWriter);
        codeWriter.Flush();
    }

    public void WriteTo(CodeWriter writer)
    {
        if (Usings == null)
            return;
        
        foreach (var @using in Usings)
        {
            writer.StartLine().Write("using ").Write(@using).Write(';').EndLine();
        }

        writer.WriteLine();
    }
}

public class CsOutput(GeneratorSettings settings)
{
    public string RootDirectory { get; set; } = settings.OutputDirectory;
    public List<GeneratedFile> Files { get; set; } = [];
    
    public ICsDeclarationContainer DefinitionsWithoutFiles { get; set; } = new CsGlobalDeclarationContainer();

    public void WriteAll()
    {
        if (DefinitionsWithoutFiles.Children().Any())
        {
            Console.WriteLine("Saving global definitions without files...");
            var globalNamespace = new CsNamespace(settings.Namespace);
            DefinitionsWithoutFiles.MoveDeclarationsTo(globalNamespace);
            var globalFile = new GeneratedFile("Global.cs", RootDirectory, globalNamespace)
            {
                Usings = settings.Usings
            };
            globalFile.SaveToFile();
        }

        foreach (var file in Files)
        {
            if (!file.Container.Children().Any())
            {
                Console.WriteLine($"The file '{file.FileName}' has no definitions inside! skipping.");
                continue;
            }
            file.SaveToFile();
        }
    }

    public GeneratedFile AddFile(string fileName, CsNamespace container, string subDirectory = "", List<string>? usings = null)
    {
        var file = new GeneratedFile(fileName, Path.Combine(RootDirectory, subDirectory), container)
        {
            Usings = usings
        };
        Files.Add(file);
        return file;
    }
    
    public bool TryGetFile(string fileName, [NotNullWhen(true)] out GeneratedFile? file)
    {
        file = Files.FirstOrDefault(f => f.FileName == fileName);
        return file != null;
    }
}