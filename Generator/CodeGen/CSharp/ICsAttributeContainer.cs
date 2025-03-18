namespace Generator.CodeGen.CSharp;

/// <summary>
/// Base interface for all with attribute element.
/// </summary>
public interface ICsAttributeContainer
{
    /// <summary>
    /// Gets the attributes from element.
    /// </summary>
    List<CsAttribute> Attributes { get; }
}