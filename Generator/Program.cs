using Generator.PostProcessors;

namespace Generator;

class Program
{
    static void Main(string[] args)
    {
        // GenerateImGui();
        // GenerateImPlot();
        // GenerateImPlot3D();
        // GenerateImGuizmo();
        GenerateImNodes();
    }


    private static void GenerateImGui()
    {
        var generator = new CodeGenerator(new GeneratorSettings("ImGui", "SharpImGui", "SharpImGui")
        {
            CppParserOptions =
            {
                Defines = { "CIMGUI_DEFINE_ENUMS_AND_STRUCTS" },
            },
            FunctionsPrefix = "ig",
            MergeOverloads = true
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
    
    private static void GenerateImPlot3D()
    {
        var generatorSettings = new GeneratorSettings("ImPlot3D", "SharpImPlot3D", "SharpImPlot3D")
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
            FunctionsPrefix = "ImPlot3D"
        };
        var generator = new CodeGenerator(generatorSettings);
        
        AddAllPostProcessors(generator);
        generator.GenerateCSharp();
    }
    
    private static void GenerateImGuizmo()
    {
        var generatorSettings = new GeneratorSettings("ImGuizmo", "SharpImGuizmo", "SharpImGuizmo")
        {
            CppParserOptions =
            {
                Defines = { "CIMGUI_DEFINE_ENUMS_AND_STRUCTS" }
            },
            Usings =
            {
                "SharpImGui",
            },
            FunctionsPrefix = "ImGuizmo"
        };
        var generator = new CodeGenerator(generatorSettings);
        
        AddAllPostProcessors(generator);
        generator.GenerateCSharp();
    }
    
    private static void GenerateImNodes()
    {
        var generatorSettings = new GeneratorSettings("Imnodes", "SharpImNodes", "SharpImNodes")
        {
            CppParserOptions =
            {
                Defines = { "CIMGUI_DEFINE_ENUMS_AND_STRUCTS", "DIMNODES_NAMESPACE=imnodes" }
            },
            Usings =
            {
                "SharpImGui",
            },
            FunctionsPrefix = "imnodes",
            MergeOverloads = true,
            OverloadsKnowTypes =
            {
                "BoolPtr",
                "IntPtr",
            }
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