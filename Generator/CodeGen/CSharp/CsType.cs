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
}

public abstract class CsType : CsElement
{
    public CsTypeKind Kind { get; }
    
    public abstract int SizeOf { get; }
    
    public virtual string FullName => ToString();

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