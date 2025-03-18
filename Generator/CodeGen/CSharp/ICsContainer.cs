namespace Generator.CodeGen.CSharp;

/// <summary>
/// Base tag interface used to describe a container of <see cref="CsElement"/>
/// </summary>
public interface ICsContainer
{
    /// <summary>
    /// Gets of declaration from this container.
    /// </summary>
    /// <returns>A list of Cs declaration</returns>
    IEnumerable<ICsDeclaration> Children();
}