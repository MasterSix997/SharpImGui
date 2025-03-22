namespace Generator.CodeGen.CSharp;

/// <summary>
/// Base interface of a <see cref="ICsContainer"/> containing fields, functions, enums, classes.
/// </summary>
/// <seealso cref="CsClass"/>
public interface ICsDeclarationContainer : ICsContainer, ICsAttributeContainer
{
    /// <summary>
    /// Gets the fields/variables.
    /// </summary>
    CsContainerList<CsField> Fields { get; }

    /// <summary>
    /// Gets the functions/methods.
    /// </summary>
    CsContainerList<CsMethod> Methods { get; }

    /// <summary>
    /// Gets the enums.
    /// </summary>
    CsContainerList<CsEnum> Enums { get; }

    /// <summary>
    /// Gets the classes, structs.
    /// </summary>
    CsContainerList<CsClass> Classes { get; }

    void MoveDeclarationsTo(ICsDeclarationContainer target)
    {
        Fields.MoveTo(target.Fields);
        Methods.MoveTo(target.Methods);
        Enums.MoveTo(target.Enums);
        Classes.MoveTo(target.Classes);
        target.Attributes.AddRange(Attributes);
        Attributes.Clear();
    }
}

/// <summary>
/// A <see cref="ICsContainer"/> that can contain also namespaces.
/// </summary>
/// <seealso cref="CsNamespace"/>
/// <seealso cref="CsCompilation"/>
/// <seealso cref="CsGlobalDeclarationContainer"/>
public interface ICsGlobalDeclarationContainer : ICsDeclarationContainer
{
    /// <summary>
    /// Gets the declared namespaces
    /// </summary>
    CsContainerList<CsNamespace> Namespaces { get; }

    void MoveDeclarationsTo(ICsGlobalDeclarationContainer target)
    {
        Fields.MoveTo(target.Fields);
        Methods.MoveTo(target.Methods);
        Enums.MoveTo(target.Enums);
        Classes.MoveTo(target.Classes);
        Namespaces.MoveTo(target.Namespaces);
        target.Attributes.AddRange(Attributes);
        Attributes.Clear();
    }
}

/// <summary>
/// Internal helper class for visiting children
/// </summary>
internal static class CsContainerHelper
{
    public static IEnumerable<ICsDeclaration> Children(ICsGlobalDeclarationContainer container)
    {
        foreach (var item in container.Enums)
        {
            yield return item;
        }

        foreach (var item in container.Classes)
        {
            yield return item;
        }

        foreach (var item in container.Fields)
        {
            yield return item;
        }

        foreach (var item in container.Methods)
        {
            yield return item;
        }

        foreach (var item in container.Namespaces)
        {
            yield return item;
        }
    }

    public static IEnumerable<ICsDeclaration> Children(ICsDeclarationContainer container)
    {
        foreach (var item in container.Enums)
        {
            yield return item;
        }

        foreach (var item in container.Classes)
        {
            yield return item;
        }

        foreach (var item in container.Fields)
        {
            yield return item;
        }

        foreach (var item in container.Methods)
        {
            yield return item;
        }
    }
    
    public static void MoveDeclarationsTo(this ICsDeclarationContainer source, ICsDeclarationContainer target)
    {
        source.Enums.MoveTo(target.Enums);
        source.Classes.MoveTo(target.Classes);
        source.Fields.MoveTo(target.Fields);
        source.Methods.MoveTo(target.Methods);
    }
}