namespace Generator.CSharp;

/// <summary>
/// Base interface for all Cs declaration.
/// </summary>
public interface ICsDeclaration
{
    /// <summary>
    /// Gets or sets the comment attached to this element. Might be null.
    /// </summary>
    CsComment? Comment { get; set; }
    
    public void WriteTo(CodeWriter writer);

    protected void WriteCommentsTo(CodeWriter writer);
}

/// <summary>
/// Base class for any declaration that is not a type (<see cref="CsTypeDeclaration"/>)
/// </summary>
public abstract class CsDeclaration : CsElement, ICsDeclaration
{
    /// <summary>
    /// Gets or sets the comment attached to this element. Might be null.
    /// </summary>
    public CsComment? Comment { get; set; }
    
    // public override void WriteTo(CodeWriter writer)
    // {
    //     WriteCommentsTo(writer);
    // }

    public void WriteCommentsTo(CodeWriter writer)
    {
        Comment?.WriteTo(writer);
    }
}