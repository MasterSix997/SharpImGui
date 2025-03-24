namespace Generator.CodeGen.CSharp;

/// <summary>
/// A C# function parameter.
/// </summary>
public sealed class CsParameter : CsDeclaration, ICsMember, ICsAttributeContainer
{
    /// <summary>
    /// Creates a new instance of a C# function parameter.
    /// </summary>
    /// <param name="type">Type of the parameter.</param>
    /// <param name="name">Name of the parameter</param>
    public CsParameter(CsType type, string name)
    {
        Type = type ?? throw new ArgumentNullException(nameof(type));
        Name = name ?? throw new ArgumentNullException(nameof(name));
    }
    
    public List<CsAttribute> Attributes { get; }

    /// <summary>
    /// Gets the type of this parameter.
    /// </summary>
    public CsType Type { get; set; }

    /// <summary>
    /// Gets the name of this parameter.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the default value.
    /// </summary>
    public CsValue? InitValue { get; set; }

    /// <summary>
    /// Gets or sets the default value as an expression.
    /// </summary>
    public CsExpression? InitExpression { get; set; }

    public override string ToString()
    {
        var writer = new StringCodeWriter();
        WriteTo(writer);
        return writer.ToString();
    }

    public override void WriteTo(CodeWriter writer)
    {
        // this.WriteAttributesTo(writer);
        writer.Write(Type.TypeName);
        writer.Write($" {Name}");
        if (InitExpression != null)
            writer.Write($" = {InitExpression}");
        else if (InitValue != null)
            writer.Write($" = {InitValue}");
    }
}