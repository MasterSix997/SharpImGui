namespace Generator.CodeGen.CSharp
{
    /// <summary>
    /// Defines a C# namespace. This represents only one level of namespace (e.g., `A` in `A.B.C`).
    /// </summary>
    public class CsNamespace : CsDeclaration, ICsMember, ICsDeclarationContainer
    {
        /// <summary>
        /// Creates a namespace with the specified name.
        /// </summary>
        /// <param name="name">The name of the namespace.</param>
        public CsNamespace(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Fields = new CsContainerList<CsField>(this);
            Methods = new CsContainerList<CsMethod>(this);
            Delegates = new CsContainerList<CsDelegate>(this);
            Enums = new CsContainerList<CsEnum>(this);
            Classes = new CsContainerList<CsClass>(this);
            Attributes = new List<CsAttribute>();
        }

        /// <summary>
        /// The name of the namespace.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The list of fields defined within the namespace.
        /// </summary>
        public CsContainerList<CsField> Fields { get; }

        /// <summary>
        /// The list of methods defined within the namespace.
        /// </summary>
        public CsContainerList<CsMethod> Methods { get; }
        
        public CsContainerList<CsDelegate> Delegates { get; }

        /// <summary>
        /// The list of enums defined within the namespace.
        /// </summary>
        public CsContainerList<CsEnum> Enums { get; }

        /// <summary>
        /// The list of classes defined within the namespace.
        /// </summary>
        public CsContainerList<CsClass> Classes { get; }

        /// <summary>
        /// The list of attributes associated with the namespace.
        /// </summary>
        public List<CsAttribute> Attributes { get; }

        public override string ToString()
        {
            var builder = new StringCodeWriter();
            WriteTo(builder);
            return builder.ToString();
        }
        
        public override void WriteTo(CodeWriter writer)
        {
            writer.WriteLine($"namespace {Name}");
            writer.PushBlock();
            var childrenList = Children().ToArray();
            foreach (var child in childrenList)
            {
                child.WriteTo(writer);
                
                // Add a blank line after each child element except for the last one.
                if (child != childrenList[^1])
                    writer.WriteLine();
            }
            writer.PopBlock();
        }

        /// <summary>
        /// Returns all child elements contained within this namespace.
        /// </summary>
        /// <returns>An enumeration of declarations.</returns>
        public IEnumerable<ICsDeclaration> Children()
        {
            return CsContainerHelper.Children(this);
        }
    }
}