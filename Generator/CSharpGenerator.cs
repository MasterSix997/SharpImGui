using Generator.CSharp;

namespace Generator;

public class CSharpGenerator
{
    private readonly NativeDefinitions _nativeDefinitions;

    public CSharpGenerated CSharpGenerated { get; } = new();

    public CSharpGenerator(NativeDefinitions nativeDefinitions, string outputDir)
    {
        CSharpGenerated.Output.RootDirectory = outputDir;
        
        _nativeDefinitions = nativeDefinitions;
        
        PopulateTypes();
    }

    public void Generate()
    {
        var enums = GenerateEnums();
        var structs = GenerateStructs();
        var methods = GenerateMethods();
        var typedefs = GenerateTypedefs();
        
        ResolveTypes(enums, structs, methods.methods, typedefs);
        
        CSharpGenerated.Definitions.Enums.AddRange(enums);
        CSharpGenerated.Definitions.Classes.AddRange(structs);
        CSharpGenerated.Definitions.Methods.AddRange(methods.methods);
    }
    
    public void WriteFiles()
    {
        CSharpGenerated.Output.WriteAll();
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
            { "ImFileHandle", "IntPtr" },
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
            { "ImTextureID", "IntPtr" },
            { "ImGuiID", "uint" },
            { "ImDrawIdx", "ushort" },
            { "ImDrawCallback", "IntPtr" },
            { "size_t", "uint" },
            { "ImGuiContext*", "IntPtr" },
            { "ImPlotContext*", "IntPtr" },
            { "EditorContext*", "IntPtr" },
            { "ImGuiMemAllocFunc", "IntPtr" },
            { "ImGuiMemFreeFunc", "IntPtr" },
            { "ImFontBuilderIO", "IntPtr" },
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
            { "ImPlotFormatter", "IntPtr" },
            { "ImPlotGetter", "IntPtr" },
            { "ImPlotTransform", "IntPtr" },
            { "ImGuiKeyChord", "ImGuiKey" },
            { "ImGuiSelectionUserData", "long" },
            
            {"unsigned_int", "uint"},
            {"unsigned_char", "byte"},
            {"long long", "long"},
            {"long_long", "long"},
            {"unsigned long long", "ulong"},
            {"signed short", "short"},
            {"unsigned_short", "ushort"},
            {"signed int", "int"},
            {"signed long long", "long"},
            
            {"ImBitArrayForNamedKeys", "uint"}, //Pode não ser o tipo correto (c# 9.0: nuint)
            {"ImGuiDockRequest", "EmptyStruct"},
            {"ImGuiDockNodeSettings", "EmptyStruct"},
            {"ImBitArrayPtr", "IntPtr"},
            {"ImStbTexteditState*", "void*"},
            {"ImVector_const_charPtr*", "ImVectorPtrIntPtr"},
        });
    }

    private List<CsEnum> GenerateEnums()
    {
        var enums = new List<CsEnum>();
        
        foreach (var nativeEnum in _nativeDefinitions.Types.Enums)
        {
            // TODO: some enums has different types, need to handle that
            
            var csEnum = new CsEnum(nativeEnum.Name);
            enums.Add(csEnum);

            csEnum.Metadata = nativeEnum;
            csEnum.Visibility = CsVisibility.Public;
            if (nativeEnum.IsFlags)
                csEnum.Attributes.Add(new CsAttribute("Flags"));
            
            if (nativeEnum.Comment is not null)
                csEnum.Comment = new CsDocComment(nativeEnum.Comment);

            foreach (var nativeItem in nativeEnum.Items)
            {
                var csItem = new CsEnumItem(nativeItem.Name, nativeItem.Value);
                if (nativeItem.Comment is not null)
                    csItem.Comment = new CsDocComment(nativeItem.Comment);
                
                csItem.Metadata = nativeItem;
                csEnum.Items.Add(csItem);
            }
        }
        
        return enums;
    }
    
    private List<CsClass> GenerateStructs()
    {
        var structs = new List<CsClass>();
        var templatedTypes = new List<(NativeField, CsField)>();
        
        foreach (var nativeStruct in _nativeDefinitions.Types.Structs)
        {
            var csStruct = new CsClass(nativeStruct.Name, CsClassKind.Struct);
            structs.Add(csStruct);

            csStruct.Metadata = nativeStruct;
            csStruct.Visibility = CsVisibility.Public;
            csStruct.IsPartial = true;
            csStruct.Attributes.Add(new CsAttribute("StructLayout") { Arguments = "LayoutKind.Sequential" });
            
            if (nativeStruct.Comment is not null)
                csStruct.Comment = new CsDocComment(nativeStruct.Comment);

            foreach (var nativeField in nativeStruct.Fields)
            {
                var fieldType = new CsUnresolvedType(nativeField.Type, CsTypeKind.Unknown);
                var fieldSize = nativeField.Size;
                if (fieldSize is not null)
                {
                    var nameWithoutArray = nativeField.Name.Split('[')[0];
                    for (int i = 0; i < fieldSize; i++)
                    {
                        var csField = new CsField(fieldType, string.Concat(nameWithoutArray, '_', i));
                        csStruct.Fields.Add(csField);
                        csField.Visibility = CsVisibility.Public;
                        if (i == 0)
                            csField.Comment = new CsDocComment(nativeField.AboveComment, nativeField.SameLineComment);
                    }
                }
                else
                {
                    var csField = new CsField(fieldType, nativeField.Name);
                    csStruct.Fields.Add(csField);
                    
                    csField.Visibility = CsVisibility.Public;
                    csField.Comment = new CsDocComment(nativeField.AboveComment, nativeField.SameLineComment);
                    csField.Metadata = nativeField;

                    if (nativeField.TemplateType is null || templatedTypes.Exists(tuple => tuple.Item1.TemplateType == nativeField.TemplateType))
                        continue;
                        
                    templatedTypes.Add((nativeField, csField));
                }
            }
        }

        foreach (var (nativeField, csField) in templatedTypes)
        {
            if (nativeField.TemplateType!.EndsWith('*'))
            {
                var originalType = new CsUnresolvedType(nativeField.TemplateType[..^1], CsTypeKind.Unknown);
                
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
    
    private (List<CsMethod> methods, List<NativeFunction> nativeFunctions) GenerateMethods()
    {
        var methods = new List<CsMethod>();
        var nativeFunctions = new List<NativeFunction>();

        foreach (var nativeFunctionOverloads in _nativeDefinitions.Functions)
        {
            foreach (var nativeFunction in nativeFunctionOverloads.Functions)
            {
                if (nativeFunction.CImGuiName.StartsWith("ImVector") || 
                    nativeFunction.CImGuiName.StartsWith("ImPool") ||
                    nativeFunction.CImGuiName.StartsWith("ImSpan") ||
                    nativeFunction.CImGuiName.StartsWith("ImChunkStream") ||
                    nativeFunction.CImGuiName.StartsWith("ImBitArray"))
                    continue;
                
                nativeFunctions.Add(nativeFunction);
                
                var returnType = new CsUnresolvedType(nativeFunction.ReturnType ?? "void", CsTypeKind.Unknown);
                var csMethod = new CsMethod(nativeFunction.CImGuiName ?? "Unknown");
                methods.Add(csMethod);

                csMethod.Metadata = nativeFunction;
                csMethod.ReturnType = returnType;
                csMethod.Visibility = CsVisibility.Public;
                csMethod.IsStatic = true;
                csMethod.IsExtern = true;
                csMethod.Attributes.Add(new CsAttribute("DllImport") { Arguments = "LibraryName, CallingConvention = CallingConvention.Cdecl" });
                
                if (nativeFunction.Comment is not null)
                    csMethod.Comment = new CsDocComment(nativeFunction.Comment);

                foreach (var nativeArgument in nativeFunction.Arguments)
                {
                    if (nativeArgument.Type == "...")
                        continue;

                    if (nativeArgument.Type == "va_list")
                    {
                        nativeFunctions.Remove(nativeFunction);
                        methods.Remove(csMethod);
                        break;
                    }

                    var argName = nativeArgument.Name;
                    if (_cSharpIdentifiers.Contains(argName))
                        argName = string.Concat("@", argName);
                    
                    var argumentType = new CsUnresolvedType(nativeArgument.Type, CsTypeKind.Unknown);
                    var csParam = new CsParameter(argumentType, argName);
                    csMethod.Parameters.Add(csParam);
                }
            }
        }

        return (methods, nativeFunctions);
    }
    
    private Dictionary<string, string> GenerateTypedefs()
    {
        var typedefs = new Dictionary<string, string>();
        
        foreach (var nativeTypedef in _nativeDefinitions.Typedefs)
        {
            typedefs.Add(nativeTypedef.Name, nativeTypedef.Type);
        }
        
        return typedefs;
    }

    private void ResolveTypes(List<CsEnum> enums, List<CsClass> structs, List<CsMethod> methods, Dictionary<string, string> typedefs)
    {
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
            var (name, type) = typedefs.ElementAt(i);
            if (type.Contains("(*)"))
            {
                var @delegate = ExtractDelegate(name, type.Replace("typedef ", ""));
                CSharpGenerated.AddType(@delegate);
                CSharpGenerated.AddTypeMap(name, "void*");
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
            var unresolvedType = csField.Type as CsUnresolvedType;
            if (unresolvedType is null)
                continue;

            if (unresolvedType.Name.Contains("(*)"))
            {
                var @delegate = ExtractDelegate(csField.Name, unresolvedType.Name);
                CSharpGenerated.Definitions.Delegates.Add(@delegate);
                CSharpGenerated.AddType(@delegate);
                CSharpGenerated.AddTypeMap(unresolvedType.Name, "void*");
            }
            else if (unresolvedType.Name.StartsWith("union"))
            {
                var unionStruct = ExtractUnion(csStruct.Name, unresolvedType.Name);
                csStruct.Classes.Add(unionStruct);
                CSharpGenerated.AddType(unionStruct);
                CSharpGenerated.AddTypeMap(unresolvedType.Name, unionStruct.TypeName);
                    
                csField.Name = "Union";
                ResolveStructTypes(unionStruct);
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
                ResolveDelegateType(@delegate);
                CSharpGenerated.Definitions.Delegates.Add(@delegate);
                CSharpGenerated.AddType(@delegate);
                CSharpGenerated.AddTypeMap(unresolvedType.Name, "void*");
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
        var delegateName = string.Concat(baseName, "Delegate");
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
    
            parameters.Add(new CsParameter(new CsUnresolvedType(paramType, CsTypeKind.Unknown), paramName));
    
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
                    var csArrayField = new CsField(new CsUnresolvedType(fieldType, CsTypeKind.Unknown), string.Concat(fieldName, '_', j))
                    {
                        Visibility = CsVisibility.Public,
                        Attributes = { new CsAttribute("FieldOffset") { Arguments = "0" } }
                    };
                    csUnion.Fields.Add(csArrayField);
                }
            }
            else
            {
                
                var csField = new CsField(new CsUnresolvedType(fieldType, CsTypeKind.Unknown), fieldName)
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