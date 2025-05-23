using Generator.CSharp;

namespace Generator.PostProcessors;

public struct CommentsProcessor : IPostProcessor
{
    public void Process(CSharpGenerated generated)
    {
        RecursiveCleanupComments(generated.Definitions);
    }

    private static void RecursiveCleanupComments(ICsContainer container)
    {
        foreach (var child in container.Children())
        {
            if (child.Comment is not CsDocComment docComment) continue;

            if (docComment.Above is not null)
            {
                CleanupXml(ref docComment.Above);
                CleanupSlashes(ref docComment.Above);
                AddBreakLineTagXml(ref docComment.Above);
            }

            if (docComment.SameLine is not null)
            {
                CleanupXml(ref docComment.SameLine);
                CleanupSlashes(ref docComment.SameLine);
                AddBreakLineTagXml(ref docComment.SameLine);
            }

            if (child is ICsContainer childContainer)
            {
                RecursiveCleanupComments(childContainer);
            }
        }
    }

    private static void CleanupSlashes(ref string comment)
    {
        comment = comment.Replace("// ", "");
    }
    
    private static void AddBreakLineTagXml(ref string comment)
    {
        var splits = comment.Split('\n');
        for (var i = 0; i < splits.Length; i++)
        {
            splits[i] = string.Concat(splits[i], "<br/>");
        }
        comment = string.Join('\n', splits);
    }
    
    private static void CleanupXml(ref string comment)
    {
        comment = comment.Replace("<", "&lt;").Replace(">", "&gt;").Replace("\n", "<br/>");
    }
}