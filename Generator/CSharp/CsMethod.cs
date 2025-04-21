namespace Generator.CSharp
{
    /// <summary>
    /// Represents a type or method with generic parameters.
    /// </summary>
    public interface IGenericParameterContainer
    {
        /// <summary>
        /// List of generic parameters for this type or method.
        /// </summary>
        List<CsType> GenericParameters { get; }
    }

    /// <summary>
    /// Flags associated with a <see cref="CsMethod"/>.
    /// </summary>
    [Flags]
    public enum CsMethodFlags
    {
        /// <summary>
        /// No flags.
        /// </summary>
        None = 0,

        /// <summary>
        /// Indicates that the method is virtual.
        /// </summary>
        Virtual = 1 << 0,

        /// <summary>
        /// Indicates that the method is an inline method.
        /// </summary>
        Inline = 1 << 1,

        /// <summary>
        /// Indicates that the method is a constructor.
        /// </summary>
        Constructor = 1 << 2,

        /// <summary>
        /// Indicates that the method is defined with generic parameters.
        /// </summary>
        Generic = 1 << 3,
    }

    /// <summary>
    /// Represents a method declaration in C#.
    /// </summary>
    public sealed class CsMethod : CsDeclaration, ICsMemberWithVisibility, IGenericParameterContainer, ICsContainer, ICsAttributeContainer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CsMethod"/> class.
        /// </summary>
        /// <param name="name">The name of the method.</param>
        public CsMethod(string name)
        {
            Name = name;
            Parameters = new CsContainerList<CsParameter>(this);
            GenericParameters = new List<CsType>();
            Attributes = new List<CsAttribute>();
        }

        /// <summary>
        /// Gets or sets the visibility of the method.
        /// </summary>
        public CsVisibility Visibility { get; set; }

        /// <summary>
        /// Gets the attributes associated with this method.
        /// </summary>
        public List<CsAttribute> Attributes { get; }

        /// <summary>
        /// Gets or sets the storage qualifier of the method.
        /// </summary>
        public CsStorageQualifier StorageQualifier { get; set; }

        /// <summary>
        /// Gets or sets the return type of the method.
        /// </summary>
        public CsType? ReturnType { get; set; } = CsPrimitiveType.Void;

        /// <summary>
        /// Gets or sets a value indicating whether this method is a constructor.
        /// </summary>
        public bool IsConstructor => (Flags & CsMethodFlags.Constructor) != 0;

        /// <summary>
        /// Gets or sets the name of the method.
        /// </summary>
        public string Name { get; set; }
        
        public string? InlinedCode { get; set; }
        
        public Action<CodeWriter>? WriteBody { get; set; }

        /// <summary>
        /// Gets the list of parameters for the method.
        /// </summary>
        public CsContainerList<CsParameter> Parameters { get; }

        /// <summary>
        /// Gets the count of parameters with default values.
        /// </summary>
        public int DefaultParameterCount => Parameters.Count(p => p.InitExpression != null);

        /// <summary>
        /// Gets or sets the flags associated with this method.
        /// </summary>
        public CsMethodFlags Flags { get; set; }

        /// <summary>
        /// Gets or sets the generic parameters for this method.
        /// </summary>
        public List<CsType> GenericParameters { get; }

        /// <summary>
        /// Determines if the method is virtual.
        /// </summary>
        public bool IsVirtual;

        /// <summary>
        /// Determines if the method is static.
        /// </summary>
        public bool IsStatic;
        
        /// <summary>
        /// Determines if the method is unsafe.
        /// </summary>
        public bool IsUnsafe;
        
        /// <summary>
        /// Determines if the method is an inline method.
        /// </summary>
        public bool IsInline;
        
        /// <summary>
        /// Determines if the method is an external method.
        /// </summary>
        public bool IsExtern;

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
            this.WriteAttributesTo(writer);

            writer.StartLine();
            if (Visibility != CsVisibility.Default)
                writer.Write(Visibility.ToString().ToLowerInvariant()).Write(' ');
            
            if (IsVirtual)
                writer.Write("virtual ");

            if (IsStatic)
                writer.Write("static ");

            if (IsExtern)
                writer.Write("extern ");
            
            if (IsUnsafe)
                writer.Write("unsafe ");

            if (ReturnType is not null)
                writer.Write(ReturnType.TypeName).Write(' ');
            
            writer.Write(Name);
            writer.Write('(');
            if (Parameters.Count > 0)
                writer.Write(string.Join(", ", Parameters));

            if (!string.IsNullOrEmpty(InlinedCode))
            {
                writer.Write(") => ");
                writer.Write(InlinedCode);
                writer.Write(";");
            }
            else if (WriteBody != null)
            {
                writer.Write(")").EndLine();
                writer.PushBlock();
                WriteBody(writer);
                writer.PopBlock();
            }
            else
                writer.Write(");");
            
            writer.EndLine();
        }

        /// <inheritdoc />
        public IEnumerable<ICsDeclaration> Children() => Parameters;
    }
}
