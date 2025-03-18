using System.Text;

namespace SharpImGui.Generator.CodeGen.CSharp;

/// <summary>
/// An attached C# attribute
/// </summary>
public class CsAttribute : CsElement
{
    public CsAttribute(string name)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
    }

    /// <summary>
    /// Gets the attribute name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets the attribute arguments
    /// </summary>
    public string? Arguments { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        var builder = new StringCodeWriter();
        WriteTo(builder);
        return builder.ToString();
    }

    public override void WriteTo(CodeWriter writer)
    {
        writer.StartLine().Write("[");
        writer.Write(Name);
        if (Arguments != null)
        {
            writer.Write('(').Write(Arguments).Write(')');
        }
        writer.Write("]");
        writer.EndLine();
    }
}