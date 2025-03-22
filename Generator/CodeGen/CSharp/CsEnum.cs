namespace Generator.CodeGen.CSharp;

/// <summary>
/// Represents a C# enum.
/// </summary>
public sealed class CsEnum : CsTypeDeclaration, ICsMemberWithVisibility, ICsAttributeContainer
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CsEnum"/> class.
    /// </summary>
    /// <param name="name">The name of the enum.</param>
    public CsEnum(string name) : base(CsTypeKind.Enum)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Items = new List<CsEnumItem>();
        Attributes = new List<CsAttribute>();
    }

    /// <inheritdoc />
    public CsVisibility Visibility { get; set; }

    /// <inheritdoc />
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the underlying type of the enum.
    /// Defaults to `int` if not specified.
    /// </summary>
    public CsType UnderlyingType { get; set; } = CsPrimitiveType.Int;

    /// <summary>
    /// Gets the list of items in this enum.
    /// </summary>
    public List<CsEnumItem> Items { get; }

    /// <inheritdoc />
    public List<CsAttribute> Attributes { get; }
    
    public void AddItem(CsEnumItem item)
    {
        Items.Add(item);
    }
    
    public override string ToString()
    {
        var builder = new StringCodeWriter();
        WriteTo(builder);
        return builder.ToString();
    }

    public override void WriteTo(CodeWriter writer)
    {
        WriteCommentsTo(writer);
        this.WriteAttributesTo(writer);
        
        writer.StartLine();
        if (Visibility != CsVisibility.Default)
            writer.Write(Visibility.ToString().ToLowerInvariant()).Write(' ');
        
        writer.Write("enum ").Write(Name);

        if (!Equals(UnderlyingType, CsPrimitiveType.Int))
        {
            writer.Write(" : ");
            UnderlyingType.WriteTo(writer);
        }
        
        writer.EndLine();
        writer.PushBlock();
        
        foreach (var item in Items)
            item.WriteTo(writer);
        
        writer.PopBlock();
    }

    public override int SizeOf => UnderlyingType.SizeOf;
    public override CsType GetCanonicalType() => UnderlyingType;
}

/// <summary>
/// Represents an item in a <see cref="CsEnum"/>.
/// </summary>
public sealed class CsEnumItem : CsDeclaration, ICsAttributeContainer
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CsEnumItem"/> class.
    /// </summary>
    /// <param name="name">The name of the enum item.</param>
    /// <param name="value">The value of the enum item.</param>
    public CsEnumItem(string name, long value)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Value = value;
        Attributes = new List<CsAttribute>();
    }

    /// <inheritdoc />
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the value of the enum item.
    /// </summary>
    public long Value { get; set; }

    /// <inheritdoc />
    public List<CsAttribute> Attributes { get; }

    /// <inheritdoc />
    public override string ToString()
    {
        return $"{Name} = {Value},";
    }

    public override void WriteTo(CodeWriter writer)
    {
        WriteCommentsTo(writer);
        writer.WriteLine($"{Name} = {Value},");
    }
}