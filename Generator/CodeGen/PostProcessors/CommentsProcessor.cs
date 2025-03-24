using Generator.CodeGen.CSharp;

namespace Generator.CodeGen.PostProcessors;

public struct CommentsProcessor : IPostProcessor
{
    public void Process(CSharpGenerated generated)
    {
        RecursiveCleanupComments(generated.Definitions);
    }

    private void RecursiveCleanupComments(ICsDeclarationContainer container)
    {
        foreach (var child in container.Children())
        {
            if (child.Comment is not CsDocComment docComment) continue;

            if (docComment.Above is not null)
            {
                CleanupSlashes(ref docComment.Above);
                AddBreakLineTagXML(ref docComment.Above);
            }

            if (docComment.SameLine is not null)
            {
                CleanupSlashes(ref docComment.SameLine);
                AddBreakLineTagXML(ref docComment.SameLine);
            }

            if (child is ICsDeclarationContainer childContainer)
            {
                RecursiveCleanupComments(childContainer);
            }
        }
    }

    private void CleanupSlashes(ref string comment)
    {
        var splits = comment.Split('\n');
        for (var i = 0; i < splits.Length; i++)
        {
            var split = splits[i];
            if (split.StartsWith("// "))
                splits[i] = split[3..];
        }
        comment = string.Join('\n', splits);
    }
    
    private void AddBreakLineTagXML(ref string comment)
    {
        var splits = comment.Split('\n');
        for (var i = 0; i < splits.Length; i++)
        {
            splits[i] = string.Concat(splits[i], "<br/>");
        }
        comment = string.Join('\n', splits);
    }
}