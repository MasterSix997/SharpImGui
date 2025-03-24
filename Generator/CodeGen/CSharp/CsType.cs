namespace Generator.CodeGen.CSharp;

public enum CsTypeKind
{
    /// <summary>
    /// A primitive type (e.g `int`, `short`, `double`...)
    /// </summary>
    Primitive,
    /// <summary>
    /// A Pointer type (e.g `int*`)
    /// </summary>
    Pointer,
    /// <summary>
    /// A reference type (e.g `int&`)
    /// </summary>
    Reference,
    /// <summary>
    /// An array type (e.g int[5])
    /// </summary>
    Array,
    /// <summary>
    /// A qualified type (e.g const int)
    /// </summary>
    Qualified,
    /// <summary>
    /// A function type
    /// </summary>
    Function,
    /// <summary>
    /// A delegate type
    /// </summary>
    Delegate,
    /// <summary>
    /// A typedef
    /// </summary>
    Typedef,
    /// <summary>
    /// A struct or class type
    /// </summary>
    StructOrClass,
    /// <summary>
    /// An standard or scoped enum
    /// </summary>
    Enum,
    /// <summary>
    /// A template parameter type.
    /// </summary>
    TemplateParameterType,
    /// <summary>
    /// A none type template parameter type.
    /// </summary>
    TemplateParameterNonType,
    /// <summary>
    /// A template specialized argument type.
    /// </summary>
    TemplateArgumentType,
    /// <summary>
    /// An unexposed type.
    /// </summary>
    Unexposed,
    Unknown
}

public abstract class CsType : CsElement
{
    public CsTypeKind Kind { get; }
    
    public abstract int SizeOf { get; }
    
    public virtual string TypeName => ToString();

    protected CsType(CsTypeKind kind)
    {
        Kind = kind;
    }
    
    /// <summary>
    /// Gets the canonical type of this type instance.
    /// </summary>
    /// <returns>A canonical type of this type instance</returns>
    public abstract CsType GetCanonicalType();
}

public class CsPointerType : CsType
{
    public CsType OriginalType { get; }
    
    public override int SizeOf => OriginalType.SizeOf;

    public override string TypeName => string.Concat(OriginalType.TypeName, '*');

    public CsPointerType(CsType originalType) : base(CsTypeKind.Pointer)
    {
        OriginalType = originalType;
    }

    public override CsType GetCanonicalType()
    {
        return OriginalType;
    }

    public override void WriteTo(CodeWriter writer)
    {
        writer.Write(OriginalType.TypeName).Write('*');
    }

    public override string ToString()
    {
        return TypeName;
    }
}

public class CsUnresolvedType : CsType
{
    public string Name;
    public int SizeOfType;
    
    public override int SizeOf => SizeOfType;
    
    public CsUnresolvedType(string name, CsTypeKind kind, int sizeOf = 0) : base(kind)
    {
        Name = name;
        SizeOfType = sizeOf;
    }

    public override CsType GetCanonicalType()
    {
        return this;
    }

    public override void WriteTo(CodeWriter writer)
    {
        writer.Write(Name);
    }
    
    public override string ToString()
    {
        return Name;
    }
}