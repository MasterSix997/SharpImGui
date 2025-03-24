namespace Generator.CodeGen.CSharp;

public class CsDelegate : CsTypeDeclaration, IGenericParameterContainer, ICsContainer, ICsAttributeContainer
{
    public CsDelegate(string name) : base(CsTypeKind.Delegate)
    {
        Name = name;
        Parameters = new CsContainerList<CsParameter>(this);
        GenericParameters = new List<CsType>();
        Attributes = new List<CsAttribute>();
    }

    public List<CsAttribute> Attributes { get; }

    public CsVisibility Visibility { get; set; }

    public string Name { get; set; }

    public List<CsType> GenericParameters { get; }

    public CsContainerList<CsParameter> Parameters { get; }

    public CsType? ReturnType { get; set; }

    public override string TypeName => Name;
    public override int SizeOf => 0;
    
    public override CsType GetCanonicalType() => this;
    
    public bool IsUnsafe = false;

    public override string ToString()
    {
        var writer = new StringCodeWriter();
        WriteTo(writer);
        return writer.ToString();
    }

    public override void WriteTo(CodeWriter writer)
    {
        WriteCommentsTo(writer);
        this.WriteAttributesTo(writer);

        writer.StartLine();
        if (Visibility != CsVisibility.Default)
            writer.Write(Visibility.ToString().ToLowerInvariant()).Write(' ');
        
        if (IsUnsafe)
            writer.Write("unsafe ");
        
        writer.Write("delegate ");

        if (ReturnType is not null)
            ReturnType.WriteTo(writer);
        else
            writer.Write("void");
            
        writer.Write(' ');
        writer.Write(Name);
        writer.Write('(');
        if (Parameters.Count > 0)
            writer.Write(string.Join(", ", Parameters));

        writer.Write(");");
        writer.EndLine();
    }

    public IEnumerable<ICsDeclaration> Children() => Parameters;
}