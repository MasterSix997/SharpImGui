using Generator.CSharp;

namespace Generator.PostProcessors;

public struct NativeDefinitionsProcessor : IPostProcessor
{
    public void Process(CSharpGenerated generated)
    {
        if (generated.NativeDefinitionProvider == null)
        {
            Console.WriteLine("No native definition provider found.");
            return;
        }
        
        ProcessComments(generated);
        // ProcessDefaultValues(generated);
    }

    private static void ProcessComments(CSharpGenerated generated)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Processing comments...");
        Console.ResetColor();
        
        var nativeDefinitions = generated.NativeDefinitionProvider!.NativeDefinitions;
        var container = generated.Definitions;
        foreach (var nativeOverloads in nativeDefinitions.Functions)
        {
            foreach (var nativeFunction in nativeOverloads.Functions)
            {
                var method = container.Methods.FirstOrDefault(method => method.Name == nativeFunction.Name);
                if (method == null)
                {
                    Console.WriteLine($"Could not find method '{nativeFunction.Name}' in container.");
                    continue;
                }

                method.Comment = new CsDocComment(nativeFunction.Comment);
            }
        }

        foreach (var nativeEnum in nativeDefinitions.Types.Enums)
        {
            var csEnum = container.Enums.FirstOrDefault(@enum => @enum.Name == nativeEnum.Name);
            if (csEnum == null)
            {
                Console.WriteLine($"Could not find enum '{nativeEnum.Name}' in container.");
                continue;
            }

            csEnum.Comment = new CsDocComment(nativeEnum.Comment);
            
            foreach (var nativeEnumItem in nativeEnum.Items)
            {
                var csEnumItem = csEnum.Items.FirstOrDefault(item => item.Name == nativeEnumItem.Name);
                if (csEnumItem == null)
                {
                    Console.WriteLine($"Could not find enum item '{nativeEnumItem.Name}' in container.");
                    continue;
                }

                csEnumItem.Comment = new CsDocComment(nativeEnumItem.Comment);
            }
        }

        foreach (var nativeStruct in nativeDefinitions.Types.Structs)
        {
            var csStruct = container.Classes.FirstOrDefault(s => s.Name == nativeStruct.Name);
            if (csStruct == null)
            {
                Console.WriteLine($"Could not find struct '{nativeStruct.Name}' in container.");
                continue;
            }

            csStruct.Comment = new CsDocComment(nativeStruct.Comment);

            foreach (var nativeField in nativeStruct.Fields)
            {
                var nativeFieldName = nativeField.Name;
                var arrayBracketIndex = nativeField.Name.IndexOf('[');
                if (arrayBracketIndex >= 0)
                    nativeFieldName = nativeFieldName[..arrayBracketIndex] + "_0";
                
                var csField = csStruct.Fields.FirstOrDefault(f => f.Name == nativeFieldName);
                if (csField == null)
                {
                    Console.WriteLine($"Could not find field '{nativeFieldName}' in container.");
                    continue;
                }

                csField.Comment = new CsDocComment(nativeField.AboveComment, nativeField.SameLineComment);
            }
        }
    }


    // private static void ProcessDefaultValues(CSharpGenerated generated)
    // {
    //     var defaultValuesMap = new Dictionary<string, string>
    //     {
    //         { "NULL", "null" },
    //         { "true", "1" },
    //         { "false", "0" },
    //         { "ImVec2(0,0)", "new Vector2()" },
    //         { "ImVec3(0,0,0)", "new Vector3()" },
    //         { "ImVec4(0,0,0,0)", "new Vector4()" },
    //     };
    //     
    //     Console.ForegroundColor = ConsoleColor.Cyan;
    //     Console.WriteLine("Processing default values...");
    //     Console.ResetColor();
    //     
    //     var nativeDefinitions = generated.NativeDefinitionProvider!.NativeDefinitions;
    //     var container = generated.Definitions;
    //     foreach (var nativeOverloads in nativeDefinitions.Functions)
    //     {
    //         foreach (var nativeFunction in nativeOverloads.Functions)
    //         {
    //             var csMethod = container.Methods.FirstOrDefault(method => method.Name == nativeFunction.Name);
    //             if (csMethod == null)
    //             {
    //                 Console.WriteLine($"Could not find method '{nativeFunction.Name}' in container.");
    //                 continue;
    //             }
    //
    //             foreach (var (parameterName, defaultValue) in nativeFunction.DefaultValues)
    //             {
    //                 var csParameter = csMethod.Parameters.FirstOrDefault(param => param.Name == parameterName);
    //                 if (csParameter == null)
    //                 {
    //                     Console.WriteLine($"Could not find parameter '{parameterName}' in method {csMethod.Name}.");
    //                     continue;
    //                 }
    //                 
    //                 var defaultValueMapped = defaultValuesMap.GetValueOrDefault(defaultValue, defaultValue);
    //                 if (defaultValueMapped == defaultValue)
    //                 {
    //                     if (defaultValueMapped.Contains('(') || defaultValueMapped.Contains(')') || defaultValueMapped.Contains('"'))
    //                     {
    //                         Console.WriteLine($"Could not map default value '{defaultValue}' for parameter '{parameterName}' in method {csMethod.Name}.");
    //                         
    //                         // ensure that the before parameters do not have standard values
    //                         foreach (var innerCsParam in csMethod.Parameters)
    //                         {
    //                             if (innerCsParam.Name == csParameter.Name) break;
    //
    //                             innerCsParam.InitExpression = null;
    //                         }
    //                         break;
    //                     }
    //                 }
    //
    //                 csParameter.InitExpression = new CsLiteralExpression(CsExpressionKind.Unary, defaultValueMapped);
    //             }
    //         }
    //     }
    // }
}