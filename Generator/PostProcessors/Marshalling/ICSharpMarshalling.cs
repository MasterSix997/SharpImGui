using CppAst;
using Generator.CSharp;

namespace Generator.PostProcessors.Marshalling;

// public struct FieldMarshalledInfo
// {
//     public CsType FieldType;
//     public string InlineCode;
// }

public struct ParameterMarshalledInfo
{
    // public CsType ParameterType;
    public string? OverrideCallName;
    public string? BeforeParameter;
    public string? AfterParameter;
    public Action<CodeWriter>? BeforeCallWriter;
    public Action<CodeWriter>? AfterCallWriter;
    public string? fixedCode;
    public bool RemoveOriginalParameter;
    // public Action<CodeWriter> Writer;
    
    // Automatic Assigned Properties
    public CsParameter OriginalParameter { get; set; }
    public string Name => OverrideCallName ?? OriginalParameter.Name;
}

public struct ReturnMarshalledInfo
{
    public string? BeforeCall;
    public string? AfterCall;
    public string? OverrideReturnVariable;
    public string? CustomReturn { get; set; }
    public bool UseReturnVariable;
    // public Action<CodeWriter> Writer;
}

public interface ICSharpMarshalling
{
    public int OverloadsCount => 0;
    
    public bool TryMarshalField(CsField field, CSharpGenerated generated)
    {
        return false;
    }

    public bool TryMarshalParameter(CsParameter parameter, in StructPtrProcessor.MethodOverloadInfo methodInfo, CSharpGenerated generated, out ParameterMarshalledInfo info)
    {
        info = default;
        return false;
    }

    public bool TryMarshalReturnValue(CsMethod method, in StructPtrProcessor.MethodOverloadInfo methodInfo, CSharpGenerated generated, out ReturnMarshalledInfo info)
    {
        info = default;
        return false;
    }

    bool CanMarshalOverload(CsParameter methodParameter)
    {
        return false;
    }

    public bool TryProcessDefaultValue(CsParameter omittedParam, string omittedParamValue, out ParameterMarshalledInfo info)
    {
        info = default;
        return false;
    }
}

public static class CSharpMarshalHelper
{
    public static IEnumerable<ICSharpMarshalling> DefaultMarshallers =>
    [
        new BoolMarshal(),
        new StringMarshal(),
        new UnmanagedTypeMarshal(),
        new StructPtrMarshal(),
        new VoidPtrMarshal(),
        new AnyPtrMarshal(),
    ];
}

public sealed class UnmanagedTypeMarshal : ICSharpMarshalling
{
    private readonly HashSet<string> _unmanagedTypes = [
        "void", "char", "short", "ushort", "int", "uint", 
        "nuint", "long", "ulong", "float", "double", "bool", 
        "byte", "sbyte", "Vector2", "Vector3", "Vector4", "Quaternion", 
        "Matrix4x4", "Rect", "ImRect", "IntPtr"];
    
    private readonly Dictionary<string, string> _defaultValuesMap = new()
    {
        { "NULL", "null" }, { "nullptr", "null" }, { "true", "1" }, { "false", "0" },
        // { "ImVec2(0,0)", "new Vector2(0, 0)" }, { "ImVec3(0,0,0)", "new Vector3(0, 0, 0)" },
        // { "ImVec4(0,0,0,0)", "new Vector4(0, 0, 0, 0)" },
    };

    public readonly Dictionary<string, string> _defaultStructValuesMap = new()
    {
        { "ImVec2", "Vector2" },
        { "ImVec3", "Vector3" },
        { "ImVec4", "Vector4" },
        { "ImColor", "Color" },
    };
    
    public bool TryMarshalField(CsField field, CSharpGenerated generated)
    {
        var type = field.Type;
        
        if (!_unmanagedTypes.Contains(type.TypeName) 
            && type is not CsGenericType
            && type is not CsEnum
            && type is not CsClass
            && type is not CsDelegate)
            return false;

        if (type is CsClass { Metadata: CppClass { ClassKind: CppClassKind.Union }})
        {
            var nameWithoutUnion = type.TypeName[..^5];
            type = new CsUnresolvedType($"{nameWithoutUnion}.{type.TypeName}");
        }

        field.Type = new CsKeywordType(type, CsKeywordType.CsKeyword.Ref);
        field.PropertyType = PropertyType.GetInline;
        field.InlinePropertyGet = $"ref Unsafe.AsRef<{type.TypeName}>(&NativePtr->{field.Name})";
        return true;
    }

    public bool TryMarshalReturnValue(CsMethod method, in StructPtrProcessor.MethodOverloadInfo methodInfo, CSharpGenerated generated, out ReturnMarshalledInfo info)
    {
        info = default;
        var type = method.ReturnType;
        if (type == null)
            return false;

        if (!_unmanagedTypes.Contains(type.TypeName)
            && type is not CsClass
            && type is not CsEnum)
            return false;
        
        return true;
    }

    public bool TryMarshalParameter(CsParameter parameter, in StructPtrProcessor.MethodOverloadInfo methodInfo, CSharpGenerated generated, out ParameterMarshalledInfo info)
    {
        info = default;
        var type = parameter.Type;

        if (!_unmanagedTypes.Contains(type.TypeName)
            && type is not CsClass
            && type is not CsEnum
            && type is not CsDelegate)
            return false;

        return true;
    }

    public bool TryProcessDefaultValue(CsParameter omittedParam, string omittedParamValue, out ParameterMarshalledInfo info)
    {
        info = default;

        if (_defaultValuesMap.TryGetValue(omittedParamValue, out var defaultValue))
        {
            info.BeforeCallWriter = writer => writer.WriteLine($"{omittedParam.Type.TypeName} {omittedParam.Name} = {defaultValue};");
            return true;
        }
        
        var parenIndex = omittedParamValue.IndexOf('(');
        if (parenIndex >= 0)
        {
            string structName = omittedParamValue[..parenIndex];
            if (_defaultStructValuesMap.TryGetValue(structName, out structName))
            {
                var defaultStructValues = omittedParamValue[parenIndex..].Replace("FLT_MIN", "float.MinValue");
                info.BeforeCallWriter = writer =>
                {
                    writer.StartLine();
                    writer.Write($"{omittedParam.Type.TypeName} {omittedParam.Name} = new {structName}");
                    writer.Write(defaultStructValues);
                    writer.Write(";");
                    writer.EndLine();
                };
                return true;
            }
        }

        if (omittedParam.Type is CsEnum csEnum)
        {
            var enumItem = "";
            if (int.TryParse(omittedParamValue, out var enumValue))
            {
                enumItem = csEnum.Items.FirstOrDefault(i => i.Value == enumValue)?.Name;
                // info.BeforeCallWriter = writer => writer.WriteLine($"{omittedParam.Type.TypeName} {omittedParam.Name} = {csEnum.TypeName}.{enumValue};");
            }
            else if(omittedParamValue.StartsWith(csEnum.Name))
            {
                enumItem = omittedParamValue.Replace(csEnum.Name + "_", "");
            }

            var callMode = string.IsNullOrEmpty(enumItem) ? $"({csEnum.Name})0" : $"{csEnum.TypeName}.{enumItem}";
            info.BeforeCallWriter = writer => writer.WriteLine($"{omittedParam.Type.TypeName} {omittedParam.Name} = {callMode};");
            return true;
        }
        
        return false;
    }
}

public struct VoidPtrMarshal : ICSharpMarshalling
{
    public bool TryMarshalField(CsField field, CSharpGenerated generated)
    {
        if (field.Type.TypeName != "void*")
            return false;

        if (field.Metadata is CppField { Type: CppPointerType { ElementType: CppFunctionType }})
        {
            field.Type = new CsUnresolvedType(field.Name);
            field.PropertyType = PropertyType.GetSet;
            field.InlinePropertyGet = $"({field.Name}) Marshal.GetDelegateForFunctionPointer((IntPtr)NativePtr->{field.Name}, typeof({field.Name}))";
            field.InlinePropertySet = $"NativePtr->{field.Name} = (void*)Marshal.GetFunctionPointerForDelegate(value)";
        }
        else
        {
            field.Type = generated.GetCsType("IntPtr")!;
            field.PropertyType = PropertyType.GetSet;
            field.InlinePropertyGet = $"(IntPtr)NativePtr->{field.Name}";
            field.InlinePropertySet = $"NativePtr->{field.Name} = (void*)value";
        }

        return true;
    }

    public bool TryMarshalReturnValue(CsMethod method, in StructPtrProcessor.MethodOverloadInfo methodInfo, CSharpGenerated generated, out ReturnMarshalledInfo info)
    {
        info = default;
        if (method.ReturnType is not CsPointerType { OriginalType: CsPrimitiveType { Kind: CsPrimitiveKind.Void } })
            return false;
        
        method.ReturnType = generated.GetCsType("IntPtr")!;
        info.BeforeCall = "(IntPtr)";
        return true;
    }
    
    public bool TryMarshalParameter(CsParameter parameter, in StructPtrProcessor.MethodOverloadInfo methodInfo, CSharpGenerated generated, out ParameterMarshalledInfo info)
    {
        info = default;
        if (parameter.Type is not CsPointerType { OriginalType: CsPrimitiveType { Kind: CsPrimitiveKind.Void } })
            return false;
        
        parameter.Type = generated.GetCsType("IntPtr")!;
        info.BeforeParameter = "(void*)";
        return true;
    }
}

public struct AnyPtrMarshal : ICSharpMarshalling
{
    public bool TryMarshalField(CsField field, CSharpGenerated generated)
    {
        if (field.Type is not CsPointerType pointerType)
            return false;

        field.Type = generated.GetCsType("IntPtr")!;
        field.PropertyType = PropertyType.GetSet;
        field.InlinePropertyGet = $"(IntPtr)NativePtr->{field.Name}";
        field.InlinePropertySet = $"NativePtr->{field.Name} = ({pointerType.TypeName})value";
        return true;
    }

    public bool TryMarshalReturnValue(CsMethod method, in StructPtrProcessor.MethodOverloadInfo methodInfo, CSharpGenerated generated, out ReturnMarshalledInfo info)
    {
        info = default;
        if (method.ReturnType is not CsPointerType pointerType)
            return false;

        method.ReturnType = new CsKeywordType(pointerType.OriginalType, CsKeywordType.CsKeyword.Ref);
        info.OverrideReturnVariable = "nativeResult";
        info.UseReturnVariable = true;
        info.CustomReturn = $"ref *({pointerType.OriginalType.TypeName}*)&nativeResult";
        return true;
    }
    
    public bool TryMarshalParameter(CsParameter parameter, in StructPtrProcessor.MethodOverloadInfo methodInfo, CSharpGenerated generated, out ParameterMarshalledInfo info)
    {
        info = default;
        if (parameter.Type is not CsPointerType pointerType)
            return false;

        switch (pointerType.OriginalType)
        {
            case CsPrimitiveType { Kind: CsPrimitiveKind.Byte } 
                when parameter.Metadata is CppParameter { Type: CppPointerType { ElementType: CppPrimitiveType { Kind: CppPrimitiveKind.Bool } } }:
                MarshalRefBool(parameter, ref info, pointerType);
                break;
            case CsPrimitiveType { Kind: CsPrimitiveKind.Byte } 
                when parameter.Metadata is CppParameter { Type: CppPointerType { ElementType: CppPrimitiveType { Kind: CppPrimitiveKind.Char } } }:
                MarshalByteArray(parameter, ref info, pointerType);
                break;
            default:
                if (parameter.Metadata is CppParameter { Type: CppPointerType { ElementType: CppQualifiedType { Qualifier: CppTypeQualifier.Const }}})
                {
                    MarshalArray(parameter, ref info, pointerType);
                    break;
                }
                MarshalDefault(parameter, ref info, pointerType);
                break;
        }
        return true;
    }

    private void MarshalByteArray(CsParameter parameter, ref ParameterMarshalledInfo info, CsPointerType pointerType)
    {
        parameter.Type = new CsUnresolvedType("byte[]");
        info.OverrideCallName = CleanupNamesProcessor.ToCamelCase($"native_{parameter.Name}");
        info.fixedCode = $"{pointerType.TypeName} {info.OverrideCallName} = {parameter.Name}";
    }

    private static void MarshalDefault(CsParameter parameter, ref ParameterMarshalledInfo info, CsPointerType pointerType)
    {
        var isOut = parameter.Name.ToLower().Contains("out"); 
        parameter.Type = new CsKeywordType(pointerType.OriginalType, isOut? CsKeywordType.CsKeyword.Out : CsKeywordType.CsKeyword.Ref);
        info.OverrideCallName = CleanupNamesProcessor.ToCamelCase($"native_{parameter.Name}");
        info.fixedCode = $"{pointerType.TypeName} {info.OverrideCallName} = &{parameter.Name}";
    }
    
    private static void MarshalArray(CsParameter parameter, ref ParameterMarshalledInfo info, CsPointerType pointerType)
    {
        parameter.Type = new CsUnresolvedType($"{pointerType.OriginalType}[]");
        info.OverrideCallName = CleanupNamesProcessor.ToCamelCase($"native_{parameter.Name}");
        info.fixedCode = $"{pointerType.OriginalType}* {info.OverrideCallName} = {parameter.Name}";
    }

    private static void MarshalRefBool(CsParameter parameter, ref ParameterMarshalledInfo info, CsPointerType pointerType)
    {
        parameter.Type = new CsKeywordType(CsPrimitiveType.Bool, CsKeywordType.CsKeyword.Ref);
        var nativeParam = CleanupNamesProcessor.ToCamelCase($"native_{parameter.Name}");
        var nativeParamVal = CleanupNamesProcessor.ToCamelCase($"native_{parameter.Name}_val");
        info.BeforeCallWriter = writer =>
        {
            writer.WriteLine($"var {nativeParamVal} = {parameter.Name} ? (byte)1 : (byte)0;");
            writer.WriteLine($"var {nativeParam} = &{nativeParamVal};");
        };
        info.AfterCallWriter = writer =>
        {
            writer.WriteLine($"{parameter.Name} = {nativeParamVal} != 0;");
        };
        
        info.OverrideCallName = nativeParam;
    }
}

public struct StructPtrMarshal : ICSharpMarshalling
{
    public bool TryMarshalField(CsField field, CSharpGenerated generated)
    {
        if (field.Type is not CsPointerType { OriginalType: CsClass csStruct })
            return false;

        var ptrStructName = csStruct.Name + "Ptr";
        field.Type = new CsKeywordType(new CsUnresolvedType(ptrStructName), CsKeywordType.CsKeyword.Ref);
        field.PropertyType = PropertyType.GetInline;
        field.InlinePropertyGet = $"ref Unsafe.AsRef<{ptrStructName}>(&NativePtr->{field.Name})";
        return true;
    }

    public bool TryMarshalReturnValue(CsMethod method, in StructPtrProcessor.MethodOverloadInfo methodInfo, CSharpGenerated generated, out ReturnMarshalledInfo info)
    {
        info = default;
        if (method.ReturnType is not CsPointerType { OriginalType: CsClass returnStruct })
            return false;
        
        var ptrStructName = returnStruct.Name + "Ptr";
        method.ReturnType = new CsUnresolvedType(ptrStructName);
        return true;
    }
    
    public bool TryMarshalParameter(CsParameter parameter, in StructPtrProcessor.MethodOverloadInfo methodInfo, CSharpGenerated generated, out ParameterMarshalledInfo info)
    {
        info = default;
        if (parameter.Type is not CsPointerType { OriginalType: CsClass parameterStruct })
            return false;
    
        if (parameterStruct.TypeName == methodInfo.OriginalStruct.TypeName && parameter.Name == "self")
        {
            info.OverrideCallName = "NativePtr";
            info.RemoveOriginalParameter = true;
            return true;
        }
    
        var ptrStructName = parameterStruct.Name + "Ptr";
        parameter.Type = new CsUnresolvedType(ptrStructName);
        
        return true;
    }
}

public struct BoolMarshal : ICSharpMarshalling
{
    public bool TryMarshalField(CsField field, CSharpGenerated generated)
    {
        if (field.Type is not CsPrimitiveType { Kind: CsPrimitiveKind.Byte }
            && field.Metadata is not CppField { Type: CppPrimitiveType { Kind: CppPrimitiveKind.Bool} })
            return false;
        
        field.Type = new CsKeywordType(CsPrimitiveType.Bool, CsKeywordType.CsKeyword.Ref);
        field.PropertyType = PropertyType.GetInline;
        field.InlinePropertyGet = $"ref Unsafe.AsRef<bool>(&NativePtr->{field.Name})";
        return true;
    }
    
    public bool TryMarshalParameter(CsParameter parameter, in StructPtrProcessor.MethodOverloadInfo methodInfo, CSharpGenerated generated, out ParameterMarshalledInfo info)
    {
        info = default;
        if (parameter.Type is not CsPrimitiveType { Kind: CsPrimitiveKind.Byte }
            && parameter.Metadata is not CppParameter { Type: CppPrimitiveType { Kind: CppPrimitiveKind.Bool} })
            return false;
        
        parameter.Type = CsPrimitiveType.Bool;
        info.BeforeCallWriter = writer => writer.WriteLine($"var native_{parameter.Name} = {parameter.Name} ? (byte)1 : (byte)0;");
        info.OverrideCallName = $"native_{parameter.Name}";
        return true;
    }

    public bool TryMarshalReturnValue(CsMethod method, in StructPtrProcessor.MethodOverloadInfo methodInfo, CSharpGenerated generated, out ReturnMarshalledInfo info)
    {
        info = default;
        if (method.ReturnType is not CsPrimitiveType { Kind: CsPrimitiveKind.Byte }
            && method.Metadata is not CppFunction { ReturnType: CppPrimitiveType { Kind: CppPrimitiveKind.Bool } })
            return false;

        method.ReturnType = CsPrimitiveType.Bool;
        info.CustomReturn = "result != 0";
        info.UseReturnVariable = true;
        return true;
    }
}

public struct StringMarshal : ICSharpMarshalling
{
    public int OverloadsCount => 2;

    public bool CanMarshalOverload(CsParameter methodParameter)
    {
        return methodParameter is { 
            Type: CsPointerType { OriginalType: CsPrimitiveType { Kind: CsPrimitiveKind.Byte } }, 
            Metadata: CppParameter { Type: CppPointerType 
            {
                ElementType: CppQualifiedType
                {
                    Qualifier: CppTypeQualifier.Const, 
                    ElementType: CppPrimitiveType { Kind: CppPrimitiveKind.Char }
                }
            }}};
    }

    public bool TryMarshalParameter(CsParameter parameter, in StructPtrProcessor.MethodOverloadInfo methodInfo, CSharpGenerated generated, out ParameterMarshalledInfo info)
    {
        info = default;
        if (!CanMarshalOverload(parameter))
            return false;

        if (methodInfo.OverloadMarshalling is StringMarshal)
        {
            switch (methodInfo.OverloadIndex)
            {
                case 0:
                    info = MarshalParameterByteSpan(parameter);
                    break;
                case 1:
                    info = MarshalParameterCharSpan(parameter);
                    break;
                // case 2:
                //     info = MarshalParameterString(parameter);
                    // break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(methodInfo.OverloadIndex), $"Invalid overload index '{methodInfo.OverloadIndex}', max is '{OverloadsCount - 1}'");
            }

            return true;
        }
        // if oveload == 0 -> Marshal as ReadOnlySpan<byte>
        // if oveload == 2 -> Marshal as ReadOnlySpan<char>
        // if oveload == 1 -> Marshal as string
        // info = MarshalParameterCharSpan(parameter, csStruct, generated);
        // return true;
        return false;
    }
    
    public ParameterMarshalledInfo MarshalParameterByteSpan(CsParameter parameter)
    {
        var info = new ParameterMarshalledInfo();
        
        parameter.Type = new CsGenericType("ReadOnlySpan", new CsUnresolvedType("byte"));
        var nativeName = CleanupNamesProcessor.ToCamelCase("native_" + parameter.Name);
        info.fixedCode = $"byte* {nativeName} = {parameter.Name}";
        info.OverrideCallName = $"{nativeName}";
        return info;
    }
    
    public ParameterMarshalledInfo MarshalParameterCharSpan(CsParameter parameter)
    {
        var info = new ParameterMarshalledInfo();
        
        parameter.Type = new CsGenericType("ReadOnlySpan", new CsUnresolvedType("char"));
        
        var paramName = parameter.Name;
        var nativeParam = CleanupNamesProcessor.ToCamelCase($"native_{paramName}");
        var paramByteCount = CleanupNamesProcessor.ToCamelCase($"byteCount_{paramName}");
        
        info.BeforeCallWriter = writer =>
        {
            writer.WriteLine($"// Marshaling {paramName} to native string");
            writer.WriteLine($"byte* {nativeParam};");
            writer.WriteLine($"var {paramByteCount} = 0;");
            writer.WriteLine($"if ({paramName} != null && !{paramName}.IsEmpty)");
            writer.PushBlock();

            writer.WriteLine($"{paramByteCount} = Encoding.UTF8.GetByteCount({paramName});");
            writer.WriteLine($"if({paramByteCount} > Utils.MaxStackallocSize)");
            writer.PushBlock().WriteLine($"{nativeParam} = Utils.Alloc<byte>({paramByteCount} + 1);").PopBlock();
            writer.WriteLine("else");
            writer.PushBlock();
            writer.WriteLine($"var stackallocBytes = stackalloc byte[{paramByteCount} + 1];");
            writer.WriteLine($"{nativeParam} = stackallocBytes;");
            writer.PopBlock();
            var paramOffset = CleanupNamesProcessor.ToCamelCase($"offset_{paramName}");
            writer.WriteLine($"var {paramOffset} = Utils.EncodeStringUTF8({paramName}, {nativeParam}, {paramByteCount});");
            writer.WriteLine($"{nativeParam}[{paramOffset}] = 0;");
            
            writer.PopBlock();
            writer.WriteLine($"else {nativeParam} = null;");
            writer.WriteLine();
        };
        info.AfterCallWriter = writer =>
        {
            writer.WriteLine($"// Freeing {paramName} native string");
            writer.WriteLine($"if ({paramByteCount} > Utils.MaxStackallocSize)");
            writer.AddIndent().WriteLine($"Utils.Free({nativeParam});").RemoveIndent();
        };
        
        info.OverrideCallName = nativeParam;
        return info;
    }

    public bool TryProcessDefaultValue(CsParameter omittedParam, string omittedParamValue, out ParameterMarshalledInfo info)
    {
        info = default;
        if (!CanMarshalOverload(omittedParam) || !omittedParamValue.Contains('"'))
            return false;
        
        var nativeParam = CleanupNamesProcessor.ToCamelCase($"native_{omittedParam.Name}");
        var paramByteCount = CleanupNamesProcessor.ToCamelCase($"byteCount_{omittedParam.Name}");
        info.BeforeCallWriter = writer =>
        {
            writer.WriteLine($"byte* {nativeParam} = null;");
            writer.WriteLine($"var {paramByteCount} = Encoding.UTF8.GetByteCount({omittedParamValue});");
            writer.WriteLine($"if({paramByteCount} > Utils.MaxStackallocSize)");
            writer.PushBlock().WriteLine($"{nativeParam} = Utils.Alloc<byte>({paramByteCount} + 1);").PopBlock();
            writer.WriteLine("else");
            writer.PushBlock();
            writer.WriteLine($"var stackallocBytes = stackalloc byte[{paramByteCount} + 1];");
            writer.WriteLine($"{nativeParam} = stackallocBytes;");
            writer.PopBlock();
            var paramOffset = CleanupNamesProcessor.ToCamelCase($"offset_{omittedParam.Name}");
            writer.WriteLine($"var {paramOffset} = Utils.EncodeStringUTF8({omittedParamValue}, {nativeParam}, {paramByteCount});");
            writer.WriteLine($"{nativeParam}[{paramOffset}] = 0;");
        };
        
        info.AfterCallWriter = writer =>
        {
            writer.WriteLine($"if ({paramByteCount} > Utils.MaxStackallocSize)");
            writer.AddIndent().WriteLine($"Utils.Free({nativeParam});").RemoveIndent();
        };

        omittedParam.Name = nativeParam;
        return true;
    }
    
    public bool TryMarshalReturnValue(CsMethod method, in StructPtrProcessor.MethodOverloadInfo methodInfo, CSharpGenerated generated, out ReturnMarshalledInfo info)
    {
        info = default;
        if (methodInfo.OriginalMethod.Metadata is not CppFunction
            {
                ReturnType: CppPointerType
                {
                    ElementType: CppQualifiedType
                    {
                        Qualifier: CppTypeQualifier.Const, 
                        ElementType: CppPrimitiveType
                        {
                            Kind: CppPrimitiveKind.Char
                        }
                    }
                }
            })
            return false;

        method.ReturnType = new CsUnresolvedType("string");
        info.UseReturnVariable = true;
        info.CustomReturn = "Utils.DecodeStringUTF8(result)";
        return true;
    }

    // public ParameterMarshalledInfo MarshalParameterString(CsParameter parameter)
    // {
    //     var info = new ParameterMarshalledInfo();
    //     
    //     parameter.Type = new CsUnresolvedType("string");
    //     
    //     var paramName = parameter.Name;
    //     var nativeParam = $"native_{paramName}";
    //     var paramByteCount = $"byteCount_{paramName}";
    //     
    //     info.BeforeCallWriter = writer =>
    //     {
    //         writer.WriteLine($"// Marshaling {paramName} to native string");
    //         writer.WriteLine($"byte* {nativeParam};");
    //         writer.WriteLine($"var {paramByteCount} = 0;");
    //         writer.WriteLine($"if ({paramName} != null)");
    //         writer.PushBlock();
    //
    //         writer.WriteLine($"{paramByteCount} = Encoding.UTF8.GetByteCount({paramName});");
    //         writer.WriteLine($"if({paramByteCount} > Utils.MaxStackallocSize)");
    //         writer.PushBlock().WriteLine($"{nativeParam} = Utils.Alloc<byte>({paramByteCount} + 1);").PopBlock();
    //         writer.WriteLine("else");
    //         writer.PushBlock();
    //         writer.WriteLine($"var stackallocBytes = stackalloc byte[{paramByteCount} + 1];");
    //         writer.WriteLine($"{nativeParam} = stackallocBytes;");
    //         writer.PopBlock();
    //         writer.WriteLine($"var {paramName}_offset = Utils.EncodeStringUTF8({paramName}, {nativeParam}, {paramByteCount});");
    //         writer.WriteLine($"{nativeParam}[{paramName}_offset] = 0;");
    //         
    //         writer.PopBlock();
    //         writer.WriteLine($"else {nativeParam} = null;");
    //         writer.WriteLine();
    //     };
    //     info.AfterCallWriter = writer =>
    //     {
    //         writer.WriteLine($"// Freeing {paramName} native string");
    //         writer.WriteLine($"if ({paramByteCount} > Utils.MaxStackallocSize)");
    //         writer.AddIndent().WriteLine($"Utils.Free({nativeParam});").RemoveIndent();
    //     };
    //     
    //     info.OverrideCallName = nativeParam;
    //     return info;
    // }
}