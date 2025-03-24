using Generator.CodeGen.CSharp;

namespace Generator.CodeGen.PostProcessors;

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
                var lenght = csEnum.Name.Length;
                if (csEnum.Name.EndsWith("Private_"))
                    lenght -= 7;
                
                item.Name = item.Name[lenght..];

                if (!char.IsNumber(item.Name[1]))
                    item.Name = item.Name.Trim('_');
            }

            csEnum.Name = csEnum.Name.TrimEnd('_');
        }
    }
}