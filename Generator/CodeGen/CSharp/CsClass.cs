using System.Text;

namespace SharpImGui.Generator.CodeGen.CSharp;

/// <summary>
/// Type of a <see cref="CsClass"/> (class, struct or union)
/// </summary>
public enum CsClassKind
{
    /// <summary>
    /// A C# `class`
    /// </summary>
    Class,
    /// <summary>
    /// A C# `struct`
    /// </summary>
    Struct,
}

/// <summary>
/// A C# class, struct or union.
/// </summary>
public sealed class CsClass : CsTypeDeclaration, ICsMemberWithVisibility, ICsDeclarationContainer, IGenericParameterContainer
{
    /// <summary>
    /// Creates a new instance.
    /// </summary>
    /// <param name="name">Name of this type.</param>
    /// <param name="classKind">Kind of the class (class, struct)</param>
    public CsClass(string name, CsClassKind classKind) : this(name)
    {
        ClassKind = classKind;
    }
    
    /// <summary>
    /// Creates a new instance.
    /// </summary>
    /// <param name="name">Name of this type.</param>
    public CsClass(string name) : base(CsTypeKind.StructOrClass)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        BaseTypes = new List<CsBaseType>();
        Fields = new CsContainerList<CsField>(this);
        Constructors = new CsContainerList<CsMethod>(this);
        Destructors = new CsContainerList<CsMethod>(this);
        Methods = new CsContainerList<CsMethod>(this);
        Enums = new CsContainerList<CsEnum>(this);
        Classes = new CsContainerList<CsClass>(this);
        GenericParameters = new List<CsType>();
        Attributes = new List<CsAttribute>();
    }

    /// <summary>
    /// Kind of the instance (`class` `struct` or `union`)
    /// </summary>
    public CsClassKind ClassKind { get; set; }

    /// <inheritdoc />
    public string Name { get; set; }

    public override string FullName
    {
        get
        {
            StringBuilder sb = new StringBuilder();
            string fullparent = FullParentName;
            if (string.IsNullOrEmpty(fullparent))
            {
                sb.Append(Name);
            }
            else
            {
                sb.Append($"{fullparent}.{Name}");
            }
            return sb.ToString();
        }
    }

    /// <inheritdoc />
    public CsVisibility Visibility { get; set; }

    /// <inheritdoc />
    public List<CsAttribute> Attributes { get; }

    /// <summary>
    /// Gets or sets a boolean indicating if this type is a definition. If <c>false</c> the type was only declared but is not defined.
    /// </summary>
    public bool IsDefinition { get; set; }

    /// <summary>
    /// Gets or sets a boolean indicating if this declaration is anonymous.
    /// </summary>
    public bool IsAnonymous { get; set; }

    /// <summary>
    /// Get the base types of this type.
    /// </summary>
    public List<CsBaseType> BaseTypes { get; }

    /// <inheritdoc />
    public CsContainerList<CsField> Fields { get; }

    /// <summary>
    /// Gets the constructors of this instance.
    /// </summary>
    public CsContainerList<CsMethod> Constructors { get; set; }

    /// <summary>
    /// Gets the destructors of this instance.
    /// </summary>
    public CsContainerList<CsMethod> Destructors { get; set; }

    /// <inheritdoc />
    public CsContainerList<CsMethod> Methods { get; }

    /// <inheritdoc />
    public CsContainerList<CsEnum> Enums { get; }

    /// <inheritdoc />
    public CsContainerList<CsClass> Classes { get; }

    public List<CsType> GenericParameters { get; }

    /// <summary>
    /// Gets the specialized class template of this instance.
    /// </summary>
    public CsClass SpecializedTemplate { get; set; }

    public bool IsEmbeded => Parent is CsClass;

    public bool IsAbstract { get; set; }
    public bool IsSealed { get; set; }
    public bool IsStatic { get; set; }
    public bool IsUnsafe { get; set; }
    public bool IsPartial { get; set; }


    /// <inheritdoc />
    public override int SizeOf { get; }

    /// <summary>
    /// Gets the alignment of this instance.
    /// </summary>
    public int AlignOf { get; set; }

    /// <inheritdoc />
    public override CsType GetCanonicalType()
    {
        return this;
    }

    /// <inheritdoc />
    public override string ToString()
    {
        var builder = new StringCodeWriter();
        WriteTo(builder);
        return builder.ToString();
    }

    public override void WriteTo(CodeWriter writer)
    {
        WriteCommentsTo(writer);
        foreach (var attribute in Attributes)
            writer.WriteLine(attribute.ToString());

        writer.StartLine();
        
        if (Visibility != CsVisibility.Default)
            writer.Write(Visibility.ToCode()).Write(' ');
        
        if (IsAbstract)
            writer.Write("abstract ");
        
        if (IsSealed)
            writer.Write("sealed ");
        
        if (IsStatic)
            writer.Write("static ");
        
        if (IsUnsafe)
            writer.Write("unsafe ");
        
        if (IsPartial)
            writer.Write("partial ");
        
        switch (ClassKind)
        {
            case CsClassKind.Class:
                writer.Write("class ");
                break;
            case CsClassKind.Struct:
                writer.Write("struct ");
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }

        writer.Write(Name);
        writer.EndLine();

        writer.PushBlock();
        foreach (var child in Children())
        {
            child.WriteTo(writer);
        }
        writer.PopBlock();
    }

    public override IEnumerable<ICsDeclaration> Children()
    {
        foreach (var item in CsContainerHelper.Children(this))
        {
            yield return item;
        }

        foreach (var item in Constructors)
        {
            yield return item;
        } 

        foreach (var item in Destructors)
        {
            yield return item;
        }
    }
}