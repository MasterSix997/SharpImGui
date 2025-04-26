namespace Generator.CSharp;

/// <summary>
/// C# primitive kinds used by <see cref="CsPrimitiveType"/>
/// </summary>
public enum CsPrimitiveKind
{
    /// <summary>
    /// C# `void`
    /// </summary>
    Void,

    /// <summary>
    /// C# `bool`
    /// </summary>
    Bool,

    /// <summary>
    /// C# `char`
    /// </summary>
    Char,

    /// <summary>
    /// C# `short`
    /// </summary>
    Short,

    /// <summary>
    /// C# `int`
    /// </summary>
    Int,

    /// <summary>
    /// C# `long`
    /// </summary>
    Long,
    UnsignedLong,

    /// <summary>
    /// C# `ushort`
    /// </summary>
    UnsignedShort,

    /// <summary>
    /// C# `uint`
    /// </summary>
    UnsignedInt,

    /// <summary>
    /// C# `float`
    /// </summary>
    Float,

    /// <summary>
    /// C# `double`
    /// </summary>
    Double,
    
    Byte,
    SignedByte,
    NativeUnsignedInt
}

/// <summary>
/// A C# primitive type (e.g `int`, `void`, `bool`...)
/// </summary>
public sealed class CsPrimitiveType : CsType
{
    /// <summary>
    /// Singleton instance of the `void` type.
    /// </summary>
    public static readonly CsPrimitiveType Void = new CsPrimitiveType(CsPrimitiveKind.Void);

    /// <summary>
    /// Singleton instance of the `bool` type.
    /// </summary>
    public static readonly CsPrimitiveType Bool = new CsPrimitiveType(CsPrimitiveKind.Bool);

    /// <summary>
    /// Singleton instance of the `char` type.
    /// </summary>
    public static readonly CsPrimitiveType Char = new CsPrimitiveType(CsPrimitiveKind.Char);

    /// <summary>
    /// Singleton instance of the `short` type.
    /// </summary>
    public static readonly CsPrimitiveType Short = new CsPrimitiveType(CsPrimitiveKind.Short);

    /// <summary>
    /// Singleton instance of the `int` type.
    /// </summary>
    public static readonly CsPrimitiveType Int = new CsPrimitiveType(CsPrimitiveKind.Int);

    /// <summary>
    /// Singleton instance of the `long` type.
    /// </summary>
    public static readonly CsPrimitiveType Long = new CsPrimitiveType(CsPrimitiveKind.Long);
    public static readonly CsPrimitiveType UnsignedLong = new CsPrimitiveType(CsPrimitiveKind.UnsignedLong);

    /// <summary>
    /// Singleton instance of the `unsigned short` type.
    /// </summary>
    public static readonly CsPrimitiveType UnsignedShort = new CsPrimitiveType(CsPrimitiveKind.UnsignedShort);

    /// <summary>
    /// Singleton instance of the `unsigned int` type.
    /// </summary>
    public static readonly CsPrimitiveType UnsignedInt = new CsPrimitiveType(CsPrimitiveKind.UnsignedInt);

    /// <summary>
    /// Singleton instance of the `float` type.
    /// </summary>
    public static readonly CsPrimitiveType Float = new CsPrimitiveType(CsPrimitiveKind.Float);

    /// <summary>
    /// Singleton instance of the `float` type.
    /// </summary>
    public static readonly CsPrimitiveType Double = new CsPrimitiveType(CsPrimitiveKind.Double);
    public static readonly CsPrimitiveType Byte = new CsPrimitiveType(CsPrimitiveKind.Byte);
    public static readonly CsPrimitiveType SignedByte = new CsPrimitiveType(CsPrimitiveKind.SignedByte);
    public static readonly CsPrimitiveType NativeUnsignedInt = new CsPrimitiveType(CsPrimitiveKind.NativeUnsignedInt);

    private readonly int _sizeOf;

    /// <summary>
    /// Base constructor of a primitive
    /// </summary>
    /// <param name="kind"></param>
    private CsPrimitiveType(CsPrimitiveKind kind) : base(CsTypeKind.Primitive)
    {
        Kind = kind;
        UpdateSize(out _sizeOf);
    }

    /// <summary>
    /// The kind of primitive.
    /// </summary>
    public CsPrimitiveKind Kind { get; }

    private void UpdateSize(out int sizeOf)
    {
        switch (Kind)
        {
            case CsPrimitiveKind.Void:
                sizeOf = 0;
                break;
            case CsPrimitiveKind.Bool:
                sizeOf = 1;
                break;
            case CsPrimitiveKind.Char:
                sizeOf = 1;
                break;
            case CsPrimitiveKind.Byte:
            case CsPrimitiveKind.SignedByte:
                sizeOf = 1;
                break;
            case CsPrimitiveKind.Short:
            case CsPrimitiveKind.UnsignedShort:
                sizeOf = 2;
                break;
            case CsPrimitiveKind.Int:
                sizeOf = 4;
                break;
            case CsPrimitiveKind.UnsignedInt:
                sizeOf = 4;
                break;
            case CsPrimitiveKind.Float:
                sizeOf = 4;
                break;
            case CsPrimitiveKind.Long:
            case CsPrimitiveKind.UnsignedLong:
                sizeOf = 8;
                break;
            case CsPrimitiveKind.Double:
                sizeOf = 8;
                break;
            case CsPrimitiveKind.NativeUnsignedInt:
                sizeOf = 4;
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    /// <inheritdoc />
    public override string ToString()
    {
        switch (Kind)
        {
            case CsPrimitiveKind.Void:
                return "void";
            case CsPrimitiveKind.Char:
                return "char";
            case CsPrimitiveKind.Short:
                return "short";
            case CsPrimitiveKind.Int:
                return "int";
            case CsPrimitiveKind.Long:
                return "long";
            case CsPrimitiveKind.UnsignedLong:
                return "ulong";
            case CsPrimitiveKind.UnsignedShort:
                return "ushort";
            case CsPrimitiveKind.UnsignedInt:
                return "uint";
            case CsPrimitiveKind.Float:
                return "float";
            case CsPrimitiveKind.Double:
                return "double";
            case CsPrimitiveKind.Bool:
                return "bool";
            case CsPrimitiveKind.Byte:
                return "byte";
            case CsPrimitiveKind.SignedByte:
                return "sbyte";
            case CsPrimitiveKind.NativeUnsignedInt:
                return "nuint";
            default:
                throw new InvalidOperationException($"Unhandled PrimitiveKind: {Kind}");
        }
    }

    private bool Equals(CsPrimitiveType other)
    {
        return base.Equals(other) && Kind == other.Kind;
    }

    /// <inheritdoc />
    public override int SizeOf => _sizeOf;

    /// <inheritdoc />
    public override CsType GetCanonicalType()
    {
        return this;
    }
}