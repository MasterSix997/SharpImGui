using Generator.PostProcessors;

namespace Generator;

class Program
{
    static void Main(string[] args)
    {
        var generator = new CodeGenerator();
        generator.AddPostProcessor(new NativeDefinitionsProcessor());
        generator.AddPostProcessor(new CommentsProcessor());
        generator.AddPostProcessor(new EnumsProcessor());
        generator.AddPostProcessor(new StaticVTableProcessor());
        generator.AddPostProcessor(new FileSeparatorProcessor());
        generator.AddPostProcessor(new CleanupNamesProcessor());
        GenerateImGui();
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
}