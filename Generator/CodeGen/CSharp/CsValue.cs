namespace Generator.CodeGen.CSharp;

/// <summary>
/// A C# default value used to initialize <see cref="CsParameter"/>
/// </summary>
public class CsValue : CsElement
{
    /// <summary>
    /// A default C# value.
    /// </summary>
    /// <param name="value"></param>
    public CsValue(object value)
    {
        Value = value ?? throw new ArgumentNullException(nameof(value));
    }

    /// <summary>
    /// Gets the default value.
    /// </summary>
    public object Value { get; set; }

    /// <inheritdoc />
    public override string ToString() => Value.ToString();
}