using System.Text.RegularExpressions;
using Generator.CSharp;

namespace Generator.PostProcessors;

public struct CleanupNamesProcessor : IPostProcessor
{
    public void Process(CSharpGenerated generated)
    {
        foreach (var file in generated.Output.Files)
        {
            ProcessEnums(file.Container);
            ProcessStructs(file.Container, generated.Settings);
            ProcessMethods(file.Container, generated.Settings);
        }
    }

    private static void ProcessEnums(CsNamespace container)
    {
        foreach (var csEnum in container.Enums)
        {
            csEnum.Name = ToPascalCase(csEnum.Name);
            foreach (var csEnumItem in csEnum.Items)
            {
                csEnumItem.Name = ToPascalCase(csEnumItem.Name);
            }
        }
    }
    
    private static void ProcessStructs(CsNamespace container, GeneratorSettings settings)
    {
        foreach (var csStruct in container.Classes)
        {
            csStruct.Name = ToPascalCase(csStruct.Name);
            foreach (var csField in csStruct.Fields)
            {
                csField.Name = ToPascalCase(csField.Name);
            }
            
            ProcessMethods(csStruct, settings);
        }
    }

    private static void ProcessMethods(ICsDeclarationContainer container, GeneratorSettings settings)
    {
        foreach (var csMethod in container.Methods)
        {
            if (!string.IsNullOrEmpty(settings.FunctionsPrefix))
                csMethod.Name = csMethod.Name.Replace(settings.FunctionsPrefix, "");
            csMethod.Name = ToPascalCase(csMethod.Name);
            foreach (var csParameter in csMethod.Parameters)
            {
                csParameter.Name = ToCamelCase(csParameter.Name);
            }
        }
    }

    private static string ToPascalCase(string original)
    {
        var invalidCharsRgx = new Regex("[^_@a-zA-Z0-9]");
        var whiteSpace = new Regex(@"(?<=\s)");
        var startsWithLowerCaseChar = new Regex("^[a-z]");
        var firstCharFollowedByUpperCasesOnly = new Regex("(?<=[A-Z])[A-Z0-9]+$");
        var lowerCaseNextToNumber = new Regex("(?<=[0-9])[a-z]");
        var upperCaseInside = new Regex("(?<=[A-Z])[A-Z]+?((?=[A-Z][a-z])|(?=[0-9]))");

        // replace white spaces with undescore, then replace all invalid chars with empty string
        var pascalCase = invalidCharsRgx.Replace(whiteSpace.Replace(original, "_"), string.Empty)
            // split by underscores
            .Split(['_'], StringSplitOptions.RemoveEmptyEntries)
            // set first letter to uppercase
            .Select(w => startsWithLowerCaseChar.Replace(w, m => m.Value.ToUpper()))
            // replace second and all following upper case letters to lower if there is no next lower (ABC -> Abc)
            // .Select(w => firstCharFollowedByUpperCasesOnly.Replace(w, m => m.Value.ToLower()))
            // set upper case the first lower case following a number (Ab9cd -> Ab9Cd)
            .Select(w => lowerCaseNextToNumber.Replace(w, m => m.Value.ToUpper()))
            // lower second and next upper case letters except the last if it follows by any lower (ABcDEf -> AbcDef)
            .Select(w => upperCaseInside.Replace(w, m => m.Value.ToLower()))
            // if the first letter is a number, add an underscore before it (9abc -> _9abc)
            .Select(w => w.StartsWith('_') || !char.IsDigit(w[0]) ? w : "_" + w);

        return string.Concat(pascalCase);
    }
    
    private static string ToCamelCase(string original)
    {
        var pascalCase = ToPascalCase(original);
        return char.ToLower(pascalCase[0]) + pascalCase[1..];
    }
}