namespace Generator.CodeGen;

public interface IPostProcessor
{
    void Process(CSharpGenerated generated);
}