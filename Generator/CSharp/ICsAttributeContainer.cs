namespace Generator.CSharp;

/// <summary>
/// Base interface for all with attribute element.
/// </summary>
public interface ICsAttributeContainer
{
    /// <summary>
    /// Gets the attributes from element.
    /// </summary>
    List<CsAttribute> Attributes { get; }
    
    public void WriteAttributesTo(CodeWriter writer)
    {
        foreach (var attribute in Attributes)
        {
            attribute.WriteTo(writer);
        }
    }
}