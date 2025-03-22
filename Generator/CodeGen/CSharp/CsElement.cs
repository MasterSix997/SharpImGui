namespace Generator.CodeGen.CSharp;

public interface ICsElement
{
}

/// <summary>
/// Base class for all Cs elements of the AST nodes.
/// </summary>
public abstract class CsElement : ICsElement
{
    /// <summary>
    /// Gets or sets the parent container of this element. Might be null.
    /// </summary>
    public ICsContainer? Parent { get; internal set; }

    public object Metadata;

    /// <summary>
    /// Computes the fully qualified name of the parent container.
    /// </summary>
    public string FullParentName
    {
        get
        {
            var parentNames = new List<string>();
            var currentParent = Parent;

            while (currentParent != null)
            {
                switch (currentParent)
                {
                    case CsClass csClass:
                        parentNames.Insert(0, csClass.Name);
                        currentParent = csClass.Parent;
                        break;

                    case CsNamespace csNamespace:
                        parentNames.Insert(0, csNamespace.Name);
                        currentParent = csNamespace.Parent;
                        break;

                    case CsGlobalDeclarationContainer:
                        currentParent = null; // Root namespace; stop processing.
                        break;

                    default:
                        throw new NotImplementedException($"Unsupported parent type: {currentParent.GetType()}");
                }
            }

            return string.Join(".", parentNames);
        }
    }

    /// <summary>
    /// Ensures equality is determined by reference.
    /// </summary>
    public sealed override bool Equals(object? obj) => ReferenceEquals(this, obj);

    /// <summary>
    /// Overrides `GetHashCode` to ensure consistency with `Equals`.
    /// </summary>
    public sealed override int GetHashCode() => base.GetHashCode();

    public virtual void WriteTo(CodeWriter writer)
    {
        writer.Write(ToString());
    }
}