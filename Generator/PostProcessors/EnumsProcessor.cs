using Generator.CSharp;

namespace Generator.PostProcessors;

public struct EnumsProcessor : IPostProcessor
{
    public void Process(CSharpGenerated generated)
    {
        CleanupEnums(generated.Definitions);
    }

    private static void CleanupEnums(ICsDeclarationContainer container)
    {
        foreach (var csEnum in container.Enums)
        {
            foreach (var item in csEnum.Items)
            {
                var toReplace = csEnum.Name;
                toReplace = toReplace.Replace("Private", "");
                item.Name = item.Name.Replace(toReplace, "");
                if (!char.IsNumber(item.Name[1]))
                    item.Name = item.Name.Trim('_');
            }

            csEnum.Name = csEnum.Name.TrimEnd('_');
        }
    }
}