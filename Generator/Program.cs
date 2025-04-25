using Generator.PostProcessors;

namespace Generator;

class Program
{
    static void Main(string[] args)
    {
        GenerateImGui();
        GenerateImPlot();
    }


    private static void GenerateImGui()
    {
        var generator = new CodeGenerator(new GeneratorSettings("ImGui", "SharpImGui", "SharpImGui")
        {
            CppParserOptions =
            {
                Defines = { "CIMGUI_DEFINE_ENUMS_AND_STRUCTS" },
            },
            FunctionsPrefix = "ig"
        });
        AddAllPostProcessors(generator);
        
        generator.GenerateCSharp();
    }
    
    private static void GenerateImPlot()
    {
        var generatorSettings = new GeneratorSettings("ImPlot", "SharpImPlot", "SharpImPlot")
        {
            CppParserOptions =
            {
                Defines = { "CIMGUI_DEFINE_ENUMS_AND_STRUCTS" }
            },
            TypeMappings =
            {
                ["time_t"] = "long",
                ["va_list"] = "nuint",
                ["tm"] = "Tm",
            },
            Types =
            {
                "Tm"
            },
            Usings =
            {
                "SharpImGui",
            },
            FunctionsPrefix = "ImPlot"
        };
        var generator = new CodeGenerator(generatorSettings);
        
        AddAllPostProcessors(generator);
        generator.GenerateCSharp();
    }
    
    public static void AddAllPostProcessors(CodeGenerator generator)
    {
        foreach (var postProcessor in GetAllPostProcessors())
            generator.AddPostProcessor(postProcessor);
    }

    private static IEnumerable<IPostProcessor> GetAllPostProcessors()
    {
        yield return new NativeDefinitionsProcessor();
        yield return new CommentsProcessor();
        yield return new EnumsProcessor();
        yield return new StaticVTableProcessor();
        yield return new FileSeparatorProcessor();
        yield return new CleanupNamesProcessor();
        yield return new StructPtrProcessor();
    }
}