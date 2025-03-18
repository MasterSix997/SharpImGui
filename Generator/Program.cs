namespace SharpImGui.Generator;

class Program
{
    static void Main(string[] args)
    {
        var generator = new CodeGen.Generator();
        generator.GenerateCImGui();
    }
}