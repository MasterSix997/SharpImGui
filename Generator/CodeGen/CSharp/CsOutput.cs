using System.Reflection.Metadata.Ecma335;

namespace Generator.CodeGen.CSharp;

public class GeneratedFile
{
    public string FileName { get; set; }
    public string Directory { get; set; }
    public CsNamespace Container { get; set; }
    public List<string>? Usings { get; set; }

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
            writer.Write("using ").Write(@using).Write(';').WriteLine();
            writer.EndLine();
        }
    }
}

public class CsOutput
{
    public string RootDirectory { get; set; } = "SharpImGui/Generated";
    public List<GeneratedFile> Files { get; set; } = [];
    
    public ICsDeclarationContainer DefinitionsWithoutFiles { get; set; } = new CsGlobalDeclarationContainer();

    public void WriteAll()
    {
        if (DefinitionsWithoutFiles.Children().Any())
        {
            Console.WriteLine("Saving global definitions without files...");
            var globalNamespace = new CsNamespace("SharpImGui.Generated");
            DefinitionsWithoutFiles.MoveDeclarationsTo(globalNamespace);
            var globalFile = new GeneratedFile("Global.cs", RootDirectory, globalNamespace);
            globalFile.SaveToFile();
        }

        foreach (var file in Files)
        {
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
}