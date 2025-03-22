using Generator.CodeGen;
using Generator.CodeGen.PostProcessors;

namespace Generator;

class Program
{
    static void Main(string[] args)
    {
        var generator = new CodeGenerator();
        generator.AddPostProcessor(new CommentsProcessor());
        generator.AddPostProcessor(new EnumsProcessor());
        generator.AddPostProcessor(new FileSeparatorProcessor());
        
        generator.GenerateCSharp();
    }
}