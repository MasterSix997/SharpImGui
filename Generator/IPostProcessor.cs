namespace Generator;

public interface IPostProcessor
{
    void Process(CSharpGenerated generated);
}