using CppAst;
using Generator.CSharp;

namespace Generator;

public class CppToCSharp
{
    private readonly CppCompilation _cppCompilation;

    public CSharpGenerated CSharpGenerated { get; }

    public CppToCSharp(CppCompilation cppCompilation, GeneratorSettings generatorSettings)
    {
        _cppCompilation = cppCompilation;
        CSharpGenerated = new CSharpGenerated(generatorSettings);
        
        PopulateTypes();
    }

    public void Generate()
    {
        var enums = GenerateEnums();
        var structs = GenerateStructs();
        var methods = GenerateMethods();
        var typedefs = GenerateTypedefs();
        
        ResolveTypes(enums, structs, methods, typedefs);
        CleanupCImGuiTypes(enums, structs, methods);
        
        CSharpGenerated.Definitions.Enums.AddRange(enums);
        CSharpGenerated.Definitions.Classes.AddRange(structs);
        CSharpGenerated.Definitions.Methods.AddRange(methods);
    }
    
    
    public void WriteFiles()
    {
        CSharpGenerated.Output.WriteAll();
    }

    private void CleanupCImGuiTypes(List<CsEnum> enums, List<CsClass> structs, List<CsMethod> methods)
    {
        if (CSharpGenerated.Settings.OriginalLibraryName == "ImGui")
            return;
        
        for (var i = enums.Count - 1; i >= 0; i--)
        {
            var csEnum = enums[i];
            if (csEnum.Metadata is CppElement cppElement && cppElement.SourceFile.EndsWith("cimgui.h"))
            {
                enums.RemoveAt(i);
                CSharpGenerated.CImGuiTypes.Enums.Add(csEnum);
            }
        }

        for (var i = structs.Count - 1; i >= 0; i--)
        {
            var csStruct = structs[i];
            if (csStruct.Metadata is CppElement cppElement && cppElement.SourceFile.EndsWith("cimgui.h"))
            {
                structs.RemoveAt(i);
                CSharpGenerated.CImGuiTypes.Classes.Add(csStruct);
            }
        }
        
        for (var i = methods.Count - 1; i >= 0; i--)
        {
            var csMethod = methods[i];
            if (csMethod.Metadata is CppElement cppElement && cppElement.SourceFile.EndsWith("cimgui.h"))
            {
                methods.RemoveAt(i);
                CSharpGenerated.CImGuiTypes.Methods.Add(csMethod);
            }
        }

        for (int i = CSharpGenerated.Definitions.Delegates.Count - 1; i >= 0; i--)
        {
            var csDelegate = CSharpGenerated.Definitions.Delegates[i];
            if (csDelegate.Metadata is CppElement cppElement && cppElement.SourceFile.EndsWith("cimgui.h"))
            {
                CSharpGenerated.Definitions.Delegates.RemoveAt(i);
                CSharpGenerated.CImGuiTypes.Delegates.Add(csDelegate);
            }
        }
    }
    
    private void PopulateTypes()
    {
        CSharpGenerated.AddTypes(new Dictionary<string, CsType>
        {
            // Primitives
            { "void", CsPrimitiveType.Void },
            { "bool", CsPrimitiveType.Bool },
            { "char", CsPrimitiveType.Char },
            { "byte", CsPrimitiveType.Byte },
            { "sbyte", CsPrimitiveType.SignedByte },
            { "short", CsPrimitiveType.Short },
            { "ushort", CsPrimitiveType.UnsignedShort },
            { "int", CsPrimitiveType.Int },
            { "uint", CsPrimitiveType.UnsignedInt },
            { "long", CsPrimitiveType.Long },
            { "ulong", CsPrimitiveType.UnsignedLong },
            { "float", CsPrimitiveType.Float },
            { "double", CsPrimitiveType.Double },
            { "nuint", CsPrimitiveType.NativeUnsignedInt },
            
            // Other known types
            { "string", new CsUnresolvedType("string", CsTypeKind.Primitive) },
            { "IntPtr", new CsUnresolvedType("IntPtr", CsTypeKind.StructOrClass) },
            { "Vector2", new CsUnresolvedType("Vector2", CsTypeKind.StructOrClass) },
            { "Vector3", new CsUnresolvedType("Vector3", CsTypeKind.StructOrClass) },
            { "Vector4", new CsUnresolvedType("Vector4", CsTypeKind.StructOrClass) },
            { "Quaternion", new CsUnresolvedType("Quaternion", CsTypeKind.StructOrClass) },
            { "Matrix4x4", new CsUnresolvedType("Matrix4x4", CsTypeKind.StructOrClass) },
            { "Color", new CsUnresolvedType("Color", CsTypeKind.StructOrClass) },
            { "Rect", new CsUnresolvedType("Rect", CsTypeKind.StructOrClass) },
            
            // Needs be generated?
            // { "ImBitArrayPtr", new CsUnresolvedType("ImBitArrayPtr", CsTypeKind.StructOrClass) },
            { "EmptyStruct", new CsUnresolvedType("EmptyStruct", CsTypeKind.StructOrClass) },
            { "ImVectorPtrIntPtr", new CsUnresolvedType("ImVector<IntPtr>*", CsTypeKind.StructOrClass) },
        });
        
        CSharpGenerated.AddTypeMaps(new Dictionary<string, string>
        {
            { "bool", "byte" },
            { "unsigned char", "byte" },
            { "signed char", "sbyte" },
            { "char", "byte" },
            { "ImWchar", "ushort" },
            { "ImFileHandle", "void*" },
            { "ImU8", "byte" },
            { "ImS8", "sbyte" },
            { "ImU16", "ushort" },
            { "ImS16", "short" },
            { "ImU32", "uint" },
            { "ImS32", "int" },
            { "ImU64", "ulong" },
            { "ImS64", "long" },
            { "unsigned short", "ushort" },
            { "unsigned int", "uint" },
            { "ImVec2", "Vector2" },
            { "ImVec2_Simple", "Vector2" },
            { "ImVec3", "Vector3" },
            { "ImVec4", "Vector4" },
            { "ImWchar16", "ushort" },
            { "ImVec4_Simple", "Vector4" },
            { "ImColor_Simple", "ImColor" },
            { "size_t", "uint" },
            { "float[2]", "Vector2*" },
            { "float[3]", "Vector3*" },
            { "float[4]", "Vector4*" },
            { "int[2]", "int*" },
            { "int[3]", "int*" },
            { "int[4]", "int*" },
            { "float&", "float*" },
            { "ImVec2[2]", "Vector2*" },
            { "char* []", "byte**" },
            { "unsigned char[256]", "byte*" },
            
            {"unsigned_int", "uint"},
            {"unsigned_char", "byte"},
            {"long long", "long"},
            {"long_long", "long"},
            {"unsigned long long", "ulong"},
            {"signed short", "short"},
            {"unsigned_short", "ushort"},
            {"signed int", "int"},
            {"signed long long", "long"},
            
            {"ImBitArrayForNamedKeys", "nuint"},
            {"ImGuiDockRequest", "EmptyStruct"},
            {"ImGuiDockNodeSettings", "EmptyStruct"},
            {"ImBitArrayPtr", "void*"},
            {"ImStbTexteditState*", "void*"},
            {"ImVector_const_charPtr*", "ImVectorPtrIntPtr"},
        });
    }

    private List<CsEnum> GenerateEnums()
    {
        var enums = new List<CsEnum>();
        
        foreach (var cppEnum in _cppCompilation.Enums)
        {
            var csEnum = new CsEnum(cppEnum.Name);
            enums.Add(csEnum);

            csEnum.Metadata = cppEnum;
            csEnum.Visibility = CsVisibility.Public;
            if (cppEnum.Name.Contains("Flag"))
                csEnum.Attributes.Add(new CsAttribute("Flags"));

            if (cppEnum.IntegerType != null && cppEnum.IntegerType is not CppPrimitiveType { Kind: CppPrimitiveKind.Int })
                csEnum.UnderlyingType = new CsUnresolvedType(cppEnum.IntegerType.FullName);

            foreach (var nativeItem in cppEnum.Items)
            {
                var csItem = new CsEnumItem(nativeItem.Name, nativeItem.Value);
                
                csItem.Metadata = nativeItem;
                csEnum.Items.Add(csItem);
            }
        }
        
        return enums;
    }
    
    private List<CsClass> GenerateStructs()
    {
        var structs = new List<CsClass>();
        var templatedTypes = new List<(CppField, CsField)>();
        
        foreach (var cppStruct in _cppCompilation.Classes)
        {
            var availableTemplateTypes = new List<string> { "ImVector_", "ImPool_", "ImSpan_", "ImChunkStream_", "ImBitArray_" };
            if (availableTemplateTypes.Any(t => cppStruct.Name.StartsWith(t)))
                continue;
            
            var csStruct = new CsClass(cppStruct.Name, CsClassKind.Struct);
            structs.Add(csStruct);

            csStruct.Metadata = cppStruct;
            csStruct.Visibility = CsVisibility.Public;
            csStruct.IsPartial = true;
            csStruct.Attributes.Add(new CsAttribute("StructLayout") { Arguments = "LayoutKind.Sequential" });

            foreach (var cppField in cppStruct.Fields)
            {
                var fieldType = new CsUnresolvedType(cppField.Type.FullName);
                
                var indexOfBracket = cppField.Type.FullName.IndexOf('[');
                if (indexOfBracket is not -1)
                {
                    var indexOfClosingBracket = cppField.Type.FullName.IndexOf(']');
                    var fieldSize = int.Parse(cppField.Type.FullName[(indexOfBracket + 1)..indexOfClosingBracket]);
                    var typenameWithoutArray = fieldType.TypeName[..indexOfBracket];
                    fieldType = new CsUnresolvedType(typenameWithoutArray);
                    for (int i = 0; i < fieldSize; i++)
                    {
                        var csField = new CsField(fieldType, string.Concat(cppField.Name, '_', i));
                        csStruct.Fields.Add(csField);
                        csField.Visibility = CsVisibility.Public;
                        csField.Metadata = cppField;
                    }
                }
                else
                {
                    var csField = new CsField(fieldType, cppField.Name)
                    {
                        Visibility = CsVisibility.Public,
                        Metadata = cppField
                    };
                    csStruct.Fields.Add(csField);

                    if (!availableTemplateTypes.Any(t => cppField.Type.FullName.StartsWith(t)))
                        continue;
                        
                    templatedTypes.Add((cppField, csField));
                }
            }
        }

        foreach (var (cppField, csField) in templatedTypes)
        {
            var index = cppField.Type.FullName.IndexOf('_');
            var templateType = cppField.Type.FullName[..index];
            var typeName = cppField.Type.FullName[(index + 1)..];
            if (typeName.EndsWith("Ptr"))
            {
                var originalType = new CsUnresolvedType(typeName[..^3]);
                
                var csClass = (csField.Parent as CsClass)!;
                var pointerStruct = new CsClass(string.Concat(originalType.TypeName, "Ptr"), CsClassKind.Struct)
                {
                    Visibility = CsVisibility.Public,
                    IsUnsafe = true,
                    Metadata = csClass.Metadata
                };
                structs.Add(pointerStruct);
                var field = new CsField(new CsPointerType(originalType), "NativePtr")
                {
                    Visibility = CsVisibility.Public
                };
                
                pointerStruct.Fields.Add(field);
            }
        }
        
        return structs;
    }

    private readonly string[] _cSharpIdentifiers = ["in", "out", "ref", "base"];
    
    private List<CsMethod> GenerateMethods()
    {
        var methods = new List<CsMethod>();

        foreach (var cppFunction in _cppCompilation.Functions)
        {
            var returnType = new CsUnresolvedType(cppFunction.ReturnType.FullName ?? "void");
            var csMethod = new CsMethod(cppFunction.Name ?? "Unknown");
            methods.Add(csMethod);

            csMethod.Metadata = cppFunction;
            csMethod.ReturnType = returnType;
            csMethod.Visibility = CsVisibility.Public;
            csMethod.IsStatic = true;
            csMethod.IsExtern = true;
            csMethod.Attributes.Add(new CsAttribute("DllImport") { Arguments = "LibraryName, CallingConvention = CallingConvention.Cdecl" });

            foreach (var cppParameter in cppFunction.Parameters)
            {
                if (cppParameter.Type.FullName == "va_list")
                {
                    methods.Remove(csMethod);
                    break;
                }

                var argName = cppParameter.Name;
                if (_cSharpIdentifiers.Contains(argName))
                    argName = string.Concat("@", argName);
                
                var argumentType = new CsUnresolvedType(cppParameter.Type.FullName);
                var csParam = new CsParameter(argumentType, argName)
                {
                    Metadata = cppParameter
                };
                csMethod.Parameters.Add(csParam);

                // if (cppParameter.InitExpression != null)
                // {
                //     csParam.InitExpression = CppExpressionToCsExpression(cppParameter.InitExpression);
                // }
            }
        }

        return methods;
    }

    public CsExpression CppExpressionToCsExpression(CppExpression cppExpression)
    {
        switch (cppExpression)
        {
            case CppLiteralExpression cppLiteralExpression:
                return new CsLiteralExpression(CppExpressionKindToCsExpressionKind(cppLiteralExpression.Kind), cppLiteralExpression.Value)
                {
                    Arguments = CppExpressionsToCsExpressions(cppLiteralExpression.Arguments),
                    Metadata = cppLiteralExpression
                };
            case CppUnaryExpression cppUnaryExpression:
                return new CsUnaryExpression(CppExpressionKindToCsExpressionKind(cppUnaryExpression.Kind))
                {
                    Arguments = CppExpressionsToCsExpressions(cppUnaryExpression.Arguments),
                    Operator = cppUnaryExpression.Operator,
                    Metadata = cppUnaryExpression
                };
            case CppBinaryExpression cppBinaryExpression:
                return new CsBinaryExpression(CppExpressionKindToCsExpressionKind(cppBinaryExpression.Kind))
                {
                    Arguments = CppExpressionsToCsExpressions(cppBinaryExpression.Arguments),
                    Operator = cppBinaryExpression.Operator,
                    Metadata = cppBinaryExpression
                };
            case CppParenExpression cppParenExpression:
                return new CsParenExpression
                {
                    Arguments = CppExpressionsToCsExpressions(cppParenExpression.Arguments),
                    Metadata = cppParenExpression
                };
            case CppInitListExpression cppInitListExpression:
                return new CsInitListExpression
                {
                    Arguments = CppExpressionsToCsExpressions(cppInitListExpression.Arguments),
                    Metadata = cppInitListExpression
                };
            default:
                throw new NotImplementedException();
        }
    }

    public List<CsExpression>? CppExpressionsToCsExpressions(IEnumerable<CppExpression>? cppExpressions)
    {
        return cppExpressions?.Select(CppExpressionToCsExpression).ToList();
    }

    public CsExpressionKind CppExpressionKindToCsExpressionKind(CppExpressionKind cppExpressionKind)
    {
        return (CsExpressionKind)(int)cppExpressionKind;
    }

    private Dictionary<string, (string, CppTypedef)> GenerateTypedefs()
    {
        var typedefs = new Dictionary<string, (string, CppTypedef)>();
        
        foreach (var cppTypedef in _cppCompilation.Typedefs)
        {
            typedefs.Add(cppTypedef.Name, (cppTypedef.ElementType.FullName, cppTypedef));
        }
        
        return typedefs;
    }

    private void ResolveTypes(List<CsEnum> enums, List<CsClass> structs, List<CsMethod> methods, Dictionary<string, (string, CppTypedef)> typedefs)
    {
        if (CSharpGenerated.Settings.MergeOverloads)
            RenameMethodsOverloads(methods, structs);
        
        CSharpGenerated.AddTypes(enums);
        for (var i = enums.Count - 1; i >= 0; i--)
        {
            CSharpGenerated.AddType(enums[i].Name.TrimEnd('_'), enums[i]);
        }
        
        for (var i = structs.Count - 1; i >= 0; i--)
        {
            if (!CSharpGenerated.AddType(structs[i]))
                structs.RemoveAt(i);
        }

        var typesDict = new Dictionary<string, string>();
        for (var i = 0; i < typedefs.Count; i++)
        {
            var (name, (type, cppTypedef)) = typedefs.ElementAt(i);
            if (type.Contains("(*)"))
            {
                var @delegate = ExtractDelegate(name, type.Replace("typedef ", ""));
                @delegate.Metadata = cppTypedef;
                CSharpGenerated.AddType(@delegate);
                CSharpGenerated.AddTypeMap(name, @delegate.Name);
                CSharpGenerated.Definitions.Delegates.Add(@delegate);
                continue;
            }
            if (structs.Exists(s => s.Name == name) ||
                enums.Exists(e => e.Name.StartsWith(name)) )
            {
                continue;
            }
            typesDict.Add(name, type);
        }
        CSharpGenerated.AddTypeMaps(typesDict);

        foreach (var csEnum in enums)
            ResolveEnumType(csEnum);
        
        ResolveStructTypes(structs);
        ResolveDelegateTypes();
        ResolveMethodsTypes(methods);
    }
    
    private void RenameMethodsOverloads(List<CsMethod> methods, List<CsClass> structs)
    {
        var commonSuffixes = new List<string> { "Nil", "Str", "StrStr", "Int", "IntInt", "Float", "FloatFloat", 
            "Bool", "Ptr", "ContextPtr", "Vec2", "Vec4", "ImVec2", "ImVec4", "FontPtr",};
        commonSuffixes.AddRange(CSharpGenerated.Settings.OverloadsKnowTypes);
    
        // Agrupe e filtre os métodos em uma única passagem
        var methodGroups = methods
            .Where(m => m.Name.Contains('_'))
            .Select(m => new 
            { 
                Method = m, 
                BaseName = m.Name[..m.Name.LastIndexOf('_')],
                Suffix = m.Name[(m.Name.LastIndexOf('_') + 1)..]
            })
            .Where(x => 
                // Verifica se o nome base não é um struct
                !structs.Any(s => s.Name.Equals(x.BaseName, StringComparison.Ordinal)) &&
                // Verifica se é provavelmente um overload
                (commonSuffixes.Contains(x.Suffix) || x.Method.Name.Count(c => c == '_') == 1)
            )
            .GroupBy(x => x.BaseName)
            .Where(g => g.Count() > 1)
            .ToDictionary(g => g.Key, g => g.Select(x => x.Method).ToList());
    
        // Renomear overloads confirmados
        foreach (var group in methodGroups)
        {
            // Verificar se todos os métodos no grupo têm o mesmo tipo de retorno
            var returnType = group.Value[0].ReturnType?.TypeName;
            if (group.Value.Any(m => m.ReturnType?.TypeName != returnType))
                continue;
        
            // Verificar se todos têm diferentes assinaturas (sem duplicação)
            var hasUniqueSignatures = !group.Value
                .GroupBy(m => string.Join(",", m.Parameters.Select(p => p.Type)))
                .Any(g => g.Count() > 1);

            if (!hasUniqueSignatures) continue;
            foreach (var method in group.Value)
                method.Name = group.Key;
        }
    }

    private void ResolveEnumType(CsEnum csEnum)
    {
        if (csEnum.UnderlyingType is not CsUnresolvedType unresolvedType) 
            return;
        
        var enumType = CSharpGenerated.GetCsType(unresolvedType.Name);
        if (enumType is null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Failed to resolve type: {unresolvedType.Name}");
            Console.ResetColor();
            unresolvedType.Name = string.Concat(unresolvedType, "_UNRESOLVED");
        }
        else
        {
            csEnum.UnderlyingType = enumType;
        }
    }
    
    private void ResolveStructTypes(List<CsClass> structs)
    {
        foreach (var csStruct in structs)
        {
            ResolveStructTypes(csStruct);
        }
    }

    private void ResolveStructTypes(CsClass csStruct)
    {
        foreach (var csField in csStruct.Fields)
        {
            if (csField.Type is not CsUnresolvedType unresolvedType)
                continue;

            if (unresolvedType.Name.Contains("(*)"))
            {
                var @delegate = ExtractDelegate(csField.Name, unresolvedType.Name);
                @delegate.Metadata = csField.Metadata;
                CSharpGenerated.Definitions.Delegates.Add(@delegate);
                CSharpGenerated.AddType(@delegate);
                CSharpGenerated.AddTypeMap(unresolvedType.Name, @delegate.Name);
            }
            else if (unresolvedType.Name.StartsWith("union"))
            {
                //todo this is a bug
                var unionStruct = ExtractUnion(csStruct.Name, unresolvedType.Name);
                csStruct.Classes.Add(unionStruct);
                CSharpGenerated.AddType(unionStruct);
                CSharpGenerated.AddTypeMap(unresolvedType.Name, unionStruct.TypeName);
                    
                csField.Name = "Union";
                ResolveStructTypes(unionStruct);
            }
            else if (csField.Metadata is CppField { Type: CppClass { ClassKind: CppClassKind.Union } cppUnion } cppField)
            {
                var unionName = string.Concat(csStruct.Name, "Union");

                var csUnion = new CsClass(unionName, CsClassKind.Struct)
                {
                    Visibility = CsVisibility.Public,
                    IsPartial = true,
                    Metadata = cppUnion
                };
                csUnion.Attributes.Add(new CsAttribute("StructLayout") { Arguments = "LayoutKind.Explicit" });
                csStruct.Classes.Add(csUnion);
                CSharpGenerated.AddType(csUnion);
                CSharpGenerated.AddTypeMap(csField.Type.TypeName, csUnion.TypeName);

                foreach (var cppUnionField in cppUnion.Fields)
                {
                    var resolvedType = CSharpGenerated.GetCsType(cppUnionField.Type.FullName);
                    if (resolvedType is null)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Failed to resolve type: {cppUnionField.Type.FullName}");
                        Console.ResetColor();
                        continue;
                    }
                    
                    var csUnionField = new CsField(resolvedType, cppUnionField.Name)
                    {
                        Visibility = CsVisibility.Public,
                        Attributes = { new CsAttribute("FieldOffset") { Arguments = "0" } }
                    };

                    csUnion.Fields.Add(csUnionField);
                }

                if (string.IsNullOrEmpty(csField.Name))
                {
                    csField.Name = "Union";
                }
            }
                
            var fieldType = CSharpGenerated.GetCsType(unresolvedType.Name);
            if (fieldType is null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Failed to resolve type: {unresolvedType.Name}");
                Console.ResetColor();
                unresolvedType.Name = string.Concat(unresolvedType, "_UNRESOLVED");
                continue;
            }

            if (fieldType is CsDelegate)
                fieldType = CSharpGenerated.GetCsType("void*")!;

            csField.Type = fieldType;
        }
    }

    private void ResolveDelegateTypes()
    {
        foreach (var csDelegate in CSharpGenerated.Definitions.Delegates)
        {
            ResolveDelegateType(csDelegate);
        }
    }

    private void ResolveDelegateType(CsDelegate csDelegate)
    {
        var unresolvedType = csDelegate.ReturnType as CsUnresolvedType;
        if (unresolvedType is null)
            return;
            
        var returnType = CSharpGenerated.GetCsType(unresolvedType.Name);
        if (returnType is null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Failed to resolve type: {unresolvedType.Name}");
            Console.ResetColor();
            unresolvedType.Name = string.Concat(unresolvedType, "_UNRESOLVED");
            return;
        }
        csDelegate.ReturnType = returnType;
            
        ResolveArguments(csDelegate.Parameters, csDelegate.Name);
    }

    private void ResolveMethodsTypes(List<CsMethod> methods)
    {
        foreach (var csMethod in methods)
        {
            var unresolvedType = csMethod.ReturnType as CsUnresolvedType;
            if (unresolvedType is null)
                continue;
            
            var returnType = CSharpGenerated.GetCsType(unresolvedType.Name);
            if (returnType is null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Failed to resolve type: {unresolvedType.Name}");
                Console.ResetColor();
                unresolvedType.Name = string.Concat(unresolvedType, "_UNRESOLVED");
                continue;
            }
            csMethod.ReturnType = returnType;
            
            ResolveArguments(csMethod.Parameters, csMethod.Name);
        }
    }

    private void ResolveArguments(CsContainerList<CsParameter> arguments, string baseName)
    {
        for (var i = arguments.Count - 1; i >= 0; i--)
        {
            var csArg = arguments[i];
            var unresolvedType = csArg.Type as CsUnresolvedType;
            if (unresolvedType is null)
                continue;
                
            if (unresolvedType.Name.Contains("(*)"))
            {
                var @delegate = ExtractDelegate($"{baseName}_{csArg.Name}", unresolvedType.Name);
                @delegate.Metadata = csArg.Metadata;
                ResolveDelegateType(@delegate);
                CSharpGenerated.Definitions.Delegates.Add(@delegate);
                CSharpGenerated.AddType(@delegate);
                CSharpGenerated.AddTypeMap(unresolvedType.Name, @delegate.Name);
            }
                
            ResolveArgumentType(unresolvedType, csArg);
        }
    }

    private void ResolveArgumentType(CsUnresolvedType unresolvedType, CsParameter csArg)
    {
        var argType = CSharpGenerated.GetCsType(unresolvedType.Name);
        if (argType is null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Failed to resolve type: {unresolvedType.Name}");
            Console.ResetColor();
            unresolvedType.Name = string.Concat(unresolvedType, "_UNRESOLVED");
            return;
        }
        csArg.Type = argType;
    }

    private CsDelegate ExtractDelegate(string baseName, string delegateSignature)
    {
        var delegateName = baseName;//string.Concat(baseName, "Delegate");
        int i = 0;

        SkipWhitespace();
        // Extrai o tipo de retorno: lê até encontrar o '(' que inicia o ponteiro de função
        var returnType = ReadUntil('(').Trim();

        // Pula até encontrar o primeiro ')'
        while (i < delegateSignature.Length && delegateSignature[i] != ')') i++;
        if (i < delegateSignature.Length) i++; // pula o ')'

        // Pula até encontrar o '(' que abre os parâmetros
        while (i < delegateSignature.Length && delegateSignature[i] != '(') i++;
        if (i < delegateSignature.Length) i++; // pula o '('

        var parameters = new List<CsParameter>();

        var unnamedCounter = 0; // contador para parâmetros sem nome
        while (i < delegateSignature.Length && delegateSignature[i] != ')')
        {
            SkipWhitespace();
            if (i >= delegateSignature.Length || delegateSignature[i] == ')')
                break;
    
            var paramText = ReadUntil(',', ')').Trim();
            var tokens = paramText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string paramType;
            string paramName;
            if (tokens.Length == 0)
                continue;
            else if (tokens.Length == 1)
            {
                paramType = tokens[0];
                paramName = "arg" + unnamedCounter++;
            }
            else
            {
                // Se o último token contém caracteres não típicos de nome (por exemplo, '*' ou "const"), consideramos que não há nome
                var possibleName = tokens[tokens.Length - 1];
                if (possibleName.Contains("*") || possibleName == "const")
                {
                    paramType = string.Join(" ", tokens);
                    paramName = "arg" + unnamedCounter++;
                }
                else
                {
                    paramName = possibleName;
                    paramType = string.Join(" ", tokens, 0, tokens.Length - 1);
                }
            }
    
            parameters.Add(new CsParameter(new CsUnresolvedType(paramType), paramName));
    
            SkipWhitespace();
            if (i < delegateSignature.Length && delegateSignature[i] == ',')
                i++;
        }

        // Pula o ')' de fechamento dos parâmetros, se existir
        if (i < delegateSignature.Length && delegateSignature[i] == ')')
            i++;

        var csDelegate = new CsDelegate(delegateName)
        {
            ReturnType = new CsUnresolvedType(returnType, CsTypeKind.Delegate),
            Visibility = CsVisibility.Public,
            IsUnsafe = true,
        };
        csDelegate.Parameters.AddRange(parameters);

        return csDelegate;

        string ReadUntil(params char[] stopChars) {
            int start = i;
            while (i < delegateSignature.Length && !stopChars.Contains(delegateSignature[i]))
                i++;
            return delegateSignature.Substring(start, i - start);
        }

        void SkipWhitespace() {
            while (i < delegateSignature.Length && char.IsWhiteSpace(delegateSignature[i]))
                i++;
        }
    }

    private CsClass ExtractUnion(string baseName, string unionSignature)
    {
        //union { int val_i; float val_f; void* val_p;}
        //union { int BackupInt[2]; float BackupFloat[2];}
        var unionName = string.Concat(baseName, "Union");
        int i = 0;

        var csUnion = new CsClass(unionName, CsClassKind.Struct)
        {
            Visibility = CsVisibility.Public,
            IsPartial = true
        };
        csUnion.Attributes.Add(new CsAttribute("StructLayout") { Arguments = "LayoutKind.Explicit" });

        ReadUntil('{');
        i++; // pula o '{'
        SkipWhitespace();
        
        while (i < unionSignature.Length && unionSignature[i] != '}')
        {
            SkipWhitespace();
            if (i >= unionSignature.Length || unionSignature[i] == '}')
                break;
            
            var field = ReadUntil(';').Trim().Split(' ');

            var fieldName = field[^1];
            var fieldType = string.Join(' ', field[..^1]);

            if (fieldName.EndsWith(']'))
            {
                var arraySizeStart = fieldName.IndexOf('[');
                var arraySizeStr = fieldName[(arraySizeStart + 1)..^1];
                if (!int.TryParse(arraySizeStr, out var arraySize))
                    arraySize = 0;
                fieldName = fieldName[..arraySizeStart];
                
                for (var j = 0; j < arraySize; j++)
                {
                    var csArrayField = new CsField(new CsUnresolvedType(fieldType), string.Concat(fieldName, '_', j))
                    {
                        Visibility = CsVisibility.Public,
                        Attributes = { new CsAttribute("FieldOffset") { Arguments = "0" } }
                    };
                    csUnion.Fields.Add(csArrayField);
                }
            }
            else
            {
                
                var csField = new CsField(new CsUnresolvedType(fieldType), fieldName)
                {
                    Visibility = CsVisibility.Public,
                    Attributes = { new CsAttribute("FieldOffset") { Arguments = "0" } }
                };

                csUnion.Fields.Add(csField);
            }
            
            
            SkipWhitespace();
            // Se encontrar vírgula, pula-a
            if (i < unionSignature.Length && unionSignature[i] == ';')
                i++;
        }
        return csUnion;

        string ReadUntil(params char[] stopChars)
        {
            int start = i;
            while (i < unionSignature.Length && !stopChars.Contains(unionSignature[i]))
                i++;
            return unionSignature.Substring(start, i - start);
        }

        void SkipWhitespace()
        {
            while (i < unionSignature.Length && char.IsWhiteSpace(unionSignature[i]))
                i++;
        }
    }
}