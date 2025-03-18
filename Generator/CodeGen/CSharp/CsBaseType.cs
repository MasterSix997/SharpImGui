using System.Text;

namespace Generator.CodeGen.CSharp;

/// <summary>
/// A C++ base type used by <see cref="CsClass.BaseTypes"/>
/// </summary>
public sealed class CsBaseType : CsElement
{
    /// <summary>
    /// Creates a base type.
    /// </summary>
    /// <param name="baseType">Type of the base</param>
    public CsBaseType(CsType baseType)
    {
        Type = baseType ?? throw new ArgumentNullException(nameof(baseType));
    }

    /// <summary>
    /// Gets or sets the visibility of this type.
    /// </summary>
    public CsVisibility Visibility { get; set; }

    /// <summary>
    /// Gets or sets if this element is virtual.
    /// </summary>
    public bool IsVirtual { get; set; }

    /// <summary>
    /// Gets the C++ type associated.
    /// </summary>
    public CsType Type { get; }

    /// <inheritdoc />
    public override string ToString()
    {
        var builder = new StringBuilder();
        if (Visibility != CsVisibility.Default && Visibility != CsVisibility.Public)
        {
            builder.Append(Visibility.ToString().ToLowerInvariant()).Append(" ");
        }

        if (IsVirtual)
        {
            builder.Append("virtual ");
        }

        builder.Append(Type.GetDisplayName());
        return builder.ToString();
    }
}