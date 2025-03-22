using Generator.CodeGen.CSharp;

namespace Generator.CodeGen;

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
        
        CSharpGenerated.Definitions.Enums.AddRange(enums);
        CSharpGenerated.Definitions.Classes.AddRange(structs);
        CSharpGenerated.Definitions.Methods.AddRange(methods.methods);
        
        //todo: loop typedefs and add them to CSharpGenerated
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
            { "Quaternion", new CsUnresolvedType("Quaternion", CsTypeKind.StructOrClass) },
            { "Matrix4x4", new CsUnresolvedType("Matrix4x4", CsTypeKind.StructOrClass) },
            { "Color", new CsUnresolvedType("Color", CsTypeKind.StructOrClass) },
            { "Rect", new CsUnresolvedType("Rect", CsTypeKind.StructOrClass) },
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
        });
    }

    private List<CsEnum> GenerateEnums()
    {
        var enums = new List<CsEnum>();
        
        foreach (var nativeEnum in _nativeDefinitions.Types.Enums)
        {
            // TODO: some enums has different types, need to handle that
            // TODO: some enums are flags
            
            var csEnum = new CsEnum(nativeEnum.Name);
            enums.Add(csEnum);

            csEnum.Metadata = nativeEnum.IsInternal;
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
                csEnum.Items.Add(csItem);
            }
        }
        
        return enums;
    }
    
    private List<CsClass> GenerateStructs()
    {
        var structs = new List<CsClass>();
        
        foreach (var nativeStruct in _nativeDefinitions.Types.Structs)
        {
            var csStruct = new CsClass(nativeStruct.Name, CsClassKind.Struct);
            structs.Add(csStruct);

            csStruct.Metadata = nativeStruct.IsInternal;
            csStruct.Visibility = CsVisibility.Public;
            csStruct.IsUnsafe = true;
            if (nativeStruct.Comment is not null)
                csStruct.Comment = new CsDocComment(nativeStruct.Comment);

            foreach (var nativeField in nativeStruct.Fields)
            {
                var fieldType = new CsUnresolvedType(nativeField.Type, CsTypeKind.Unknown);

                var csField = new CsField(fieldType, nativeField.Name);
                csStruct.Fields.Add(csField);
                
                csField.Visibility = CsVisibility.Public;
                csField.Comment = new CsDocComment(nativeField.AboveComment, nativeField.SameLineComment);
            }
        }
        
        return structs;
    }
    
    private (List<CsMethod> methods, List<NativeFunction> nativeFunctions) GenerateMethods()
    {
        var methods = new List<CsMethod>();
        var nativeFunctions = new List<NativeFunction>();

        foreach (var nativeFunctionOverloads in _nativeDefinitions.Functions)
        {
            foreach (var nativeFunction in nativeFunctionOverloads.Functions)
            {
                nativeFunctions.Add(nativeFunction);
                
                var returnType = new CsUnresolvedType(nativeFunction.ReturnType ?? "void", CsTypeKind.Unknown);
                var csMethod = new CsMethod(nativeFunction.Name ?? "Unknown");
                methods.Add(csMethod);

                csMethod.Metadata = nativeFunction.IsInternal;
                csMethod.ReturnType = returnType;
                csMethod.Visibility = CsVisibility.Public;
                if (nativeFunction.Comment is not null)
                    csMethod.Comment = new CsDocComment(nativeFunction.Comment);

                foreach (var nativeArgument in nativeFunction.Arguments)
                {
                    var argumentType = new CsUnresolvedType(nativeArgument.Type, CsTypeKind.Unknown);
                    var csParam = new CsParameter(argumentType, nativeArgument.Name);
                    csMethod.Parameters.Add(csParam);
                }
            }
        }

        return (methods, nativeFunctions);
    }
}