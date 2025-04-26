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

    public bool TryMarshalParameter(CsParameter parameter, CsClass csStruct, CSharpGenerated generated, out ParameterMarshalledInfo info)
    {
        info = default;
        return false;
    }

    public bool TryMarshalReturnValue(CsMethod method, CsClass csStruct, CSharpGenerated generated, out ReturnMarshalledInfo info)
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

    public bool TryMarshalReturnValue(CsMethod method, CsClass csStruct, CSharpGenerated generated, out ReturnMarshalledInfo info)
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

    public bool TryMarshalParameter(CsParameter parameter, CsClass csStruct, CSharpGenerated generated, out ParameterMarshalledInfo info)
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
}

public struct VoidPtrMarshal : ICSharpMarshalling
{
    public bool TryMarshalField(CsField field, CSharpGenerated generated)
    {
        if (field.Type.TypeName != "void*")
            return false;

        field.Type = generated.GetCsType("IntPtr")!;
        field.PropertyType = PropertyType.GetSet;
        field.InlinePropertyGet = $"(IntPtr)NativePtr->{field.Name}";
        field.InlinePropertySet = $"NativePtr->{field.Name} = (void*)value";
        return true;
    }

    public bool TryMarshalReturnValue(CsMethod method, CsClass csStruct, CSharpGenerated generated, out ReturnMarshalledInfo info)
    {
        info = default;
        if (method.ReturnType is not CsPointerType { OriginalType: CsPrimitiveType { Kind: CsPrimitiveKind.Void } })
            return false;
        
        method.ReturnType = generated.GetCsType("IntPtr")!;
        info.BeforeCall = "(IntPtr)";
        return true;
    }
    
    public bool TryMarshalParameter(CsParameter parameter, CsClass csStruct, CSharpGenerated generated, out ParameterMarshalledInfo info)
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

    public bool TryMarshalReturnValue(CsMethod method, CsClass csStruct, CSharpGenerated generated, out ReturnMarshalledInfo info)
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
    
    public bool TryMarshalParameter(CsParameter parameter, CsClass csStruct, CSharpGenerated generated, out ParameterMarshalledInfo info)
    {
        info = default;
        if (parameter.Type is not CsPointerType pointerType)
            return false;

        parameter.Type = new CsKeywordType(pointerType.OriginalType, CsKeywordType.CsKeyword.Ref);
        info.OverrideCallName = $"native_{parameter.Name}";
        info.fixedCode = $"{pointerType.TypeName} native_{parameter.Name} = &{parameter.Name}";
        
        return true;
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

    public bool TryMarshalReturnValue(CsMethod method, CsClass csStruct, CSharpGenerated generated, out ReturnMarshalledInfo info)
    {
        info = default;
        if (method.ReturnType is not CsPointerType { OriginalType: CsClass returnStruct })
            return false;
        
        var ptrStructName = returnStruct.Name + "Ptr";
        method.ReturnType = new CsUnresolvedType(ptrStructName);
        return true;
    }
    
    public bool TryMarshalParameter(CsParameter parameter, CsClass csStruct, CSharpGenerated generated, out ParameterMarshalledInfo info)
    {
        info = default;
        if (parameter.Type is not CsPointerType { OriginalType: CsClass parameterStruct })
            return false;
    
        if (parameterStruct.TypeName == csStruct.TypeName && parameter.Name == "self")
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
    
    public bool TryMarshalParameter(CsParameter parameter, CsClass csStruct, CSharpGenerated generated, out ParameterMarshalledInfo info)
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
}

public struct StringMarshal : ICSharpMarshalling
{
    public int OverloadsCount => 2;

    public bool TryMarshalParameter(CsParameter parameter, CsClass csStruct, CSharpGenerated generated, out ParameterMarshalledInfo info)
    {
        info = default;
        if (parameter.Type is not CsPointerType { OriginalType: CsPrimitiveType { Kind: CsPrimitiveKind.Byte }})
            return false;
            
        
        // if oveload == 0 -> Marshal as ReadOnlySpan<byte>
        // if oveload == 2 -> Marshal as ReadOnlySpan<char>
        // if oveload == 1 -> Marshal as string
        info = MarshalParameterCharSpan(parameter, csStruct, generated);
        return true;
    }
    
    public ParameterMarshalledInfo MarshalParameterByteSpan(CsParameter parameter, CsClass csStruct, CSharpGenerated generated)
    {
        var info = new ParameterMarshalledInfo();
        
        parameter.Type = new CsGenericType("ReadOnlySpan", new CsUnresolvedType("byte"));
        info.fixedCode = $"byte* native_{parameter.Name} = {parameter.Name}";
        info.OverrideCallName = $"native_{parameter.Name}";
        return info;
    }
    
    public ParameterMarshalledInfo MarshalParameterCharSpan(CsParameter parameter, CsClass csStruct, CSharpGenerated generated)
    {
        var info = new ParameterMarshalledInfo();
        
        parameter.Type = new CsGenericType("ReadOnlySpan", new CsUnresolvedType("char"));
        
        var paramName = parameter.Name;
        var nativeParam = $"native_{paramName}";
        var paramByteCount = $"byteCount_{paramName}";
        
        info.BeforeCallWriter = writer =>
        {
            writer.WriteLine($"// Marshaling {paramName} to native string");
            writer.WriteLine($"byte* {nativeParam};");
            writer.WriteLine($"var {paramByteCount} = 0;");
            writer.WriteLine($"if ({paramName} != null)");
            writer.PushBlock();

            writer.WriteLine($"{paramByteCount} = Encoding.UTF8.GetByteCount({paramName});");
            writer.WriteLine($"if({paramByteCount} > Utils.MaxStackallocSize)");
            writer.PushBlock().WriteLine($"{nativeParam} = Utils.Alloc<byte>({paramByteCount} + 1);").PopBlock();
            writer.WriteLine("else");
            writer.PushBlock();
            writer.WriteLine($"var stackallocBytes = stackalloc byte[{paramByteCount} + 1];");
            writer.WriteLine($"{nativeParam} = stackallocBytes;");
            writer.PopBlock();
            writer.WriteLine($"var {paramName}_offset = Utils.EncodeStringUTF8({paramName}, {nativeParam}, {paramByteCount});");
            writer.WriteLine($"{nativeParam}[{paramName}_offset] = 0;");
            
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
    
    public ParameterMarshalledInfo MarshalParameterString(CsParameter parameter, CsClass csStruct, CSharpGenerated generated)
    {
        var info = new ParameterMarshalledInfo();
        
        parameter.Type = new CsUnresolvedType("string");
        
        var paramName = parameter.Name;
        var nativeParam = $"native_{paramName}";
        var paramByteCount = $"byteCount_{paramName}";
        
        info.BeforeCallWriter = writer =>
        {
            writer.WriteLine($"// Marshaling {paramName} to native string");
            writer.WriteLine($"byte* {nativeParam}");
            writer.WriteLine($"var {paramByteCount} = 0");
            writer.WriteLine($"if ({paramName} != null)");
            writer.PushBlock();

            writer.WriteLine($"{paramByteCount} = Encoding.UTF8.GetByteCount({paramName});");
            writer.WriteLine($"if({paramByteCount} > Utils.MaxStackallocSize)");
            writer.PushBlock().WriteLine($"{nativeParam} = Utils.Alloc<byte>({paramByteCount} + 1);").PopBlock();
            writer.WriteLine("else");
            writer.PushBlock();
            writer.WriteLine($"var stackallocBytes = stackalloc byte[{paramByteCount} + 1];");
            writer.WriteLine($"{nativeParam} = stackallocBytes;");
            writer.PopBlock();
            writer.WriteLine($"var {paramName}_offset = Utils.EncodeStringUTF8({paramName}, {nativeParam}, {paramByteCount});");
            writer.WriteLine($"{nativeParam}[{paramName}_offset] = 0;");
            
            writer.PopBlock();
            writer.WriteLine($"else {nativeParam} = null;");
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
}