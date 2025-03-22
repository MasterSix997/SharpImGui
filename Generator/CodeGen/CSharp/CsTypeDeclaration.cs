namespace Generator.CodeGen.CSharp;

/// <summary>
/// Base class for a type declaration (<see cref="CsClass"/>, <see cref="CsEnum"/>, <see cref="CsFunctionType"/> or <see cref="CsTypedef"/>)
/// </summary>
public abstract class CsTypeDeclaration : CsType, ICsDeclaration, ICsContainer
{
    protected CsTypeDeclaration(CsTypeKind typeKind) : base(typeKind)
    {
    }

    /// <inheritdoc />
    public CsComment Comment { get; set; }
    
    public virtual void WriteTo(CodeWriter writer)
    {
        writer.WriteLine(ToString());
    }

    /// <inheritdoc />
    public virtual IEnumerable<ICsDeclaration> Children()
    {
        return Enumerable.Empty<ICsDeclaration>();
    }
    
    public void WriteCommentsTo(CodeWriter writer)
    {
        Comment?.WriteTo(writer);
    }
}