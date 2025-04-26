namespace Generator.CSharp
{
    /// <summary>
    /// Defines the type of storage.
    /// </summary>
    public enum CsStorageQualifier
    {
        /// <summary>
        /// No storage defined.
        /// </summary>
        None,
        /// <summary>
        /// Extern storage
        /// </summary>
        Extern,
        /// <summary>
        /// Static storage.
        /// </summary>
        Static,
    }
    
    public enum PropertyType
    {
        None,
        Get,
        GetInline,
        Set,
        GetSet,
    }
    
    /// <summary>
    /// Represents a field (of a struct or class) or a global variable in C#.
    /// </summary>
    public sealed class CsField : CsDeclaration, ICsMemberWithVisibility, ICsAttributeContainer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CsField"/> class.
        /// </summary>
        /// <param name="type">The type of the field.</param>
        /// <param name="name">The name of the field.</param>
        public CsField(CsType type, string name)
        {
            Type = type ?? throw new ArgumentNullException(nameof(type));
            Name = name;
            Attributes = new List<CsAttribute>();
        }

        /// <summary>
        /// Gets or sets the visibility of the field.
        /// </summary>
        public CsVisibility Visibility { get; set; }

        /// <summary>
        /// Gets or sets the storage qualifier of this field.
        /// </summary>
        public CsStorageQualifier StorageQualifier { get; set; }

        /// <summary>
        /// Gets the attributes associated with this field.
        /// </summary>
        public List<CsAttribute> Attributes { get; }

        /// <summary>
        /// Gets or sets the type of this field.
        /// </summary>
        public CsType Type { get; set; }

        /// <summary>
        /// Gets or sets the name of the field.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this field was created from an anonymous type.
        /// </summary>
        public bool IsAnonymous { get; set; }

        /// <summary>
        /// Gets or sets the initial value of the field.
        /// </summary>
        public CsValue? InitValue { get; set; }

        /// <summary>
        /// Gets or sets the initial value of the field as an expression.
        /// </summary>
        public CsExpression? InitExpression { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this field is a bit field.
        /// </summary>
        public bool IsBitField { get; set; }
        public bool IsStatic { get; set; }

        /// <summary>
        /// Gets or sets the width of the bit field in bits. Valid only if <see cref="IsBitField"/> is <c>true</c>.
        /// </summary>
        public int BitFieldWidth { get; set; }

        /// <summary>
        /// Gets or sets the offset of the field in bytes.
        /// </summary>
        public long Offset { get; set; }
        public bool IsUnsafe { get; set; }
        public bool IsRef { get; set; }

        public PropertyType PropertyType;
        public string? InlinePropertyGet;
        public string? InlinePropertySet;

        /// <inheritdoc />
        public override string ToString()
        {
            var codeWriter = new StringCodeWriter();
            WriteTo(codeWriter);
            return codeWriter.ToString();
        }

        public override void WriteTo(CodeWriter writer)
        {
            WriteCommentsTo(writer);
            this.WriteAttributesTo(writer);
            
            writer.StartLine();
            
            if (Visibility != CsVisibility.Default)
                writer.Write(Visibility.ToString().ToLowerInvariant()).Write(' ');

            if (IsStatic)
                writer.Write("static ");
            
            if (IsUnsafe || Parent is CsClass { IsUnsafe: false } && Type is CsPointerType)
                writer.Write("unsafe ");

            if (IsRef)
                writer.Write("ref ");
            
            writer.Write(Type.TypeName);
            writer.Write($" {Name}");

            if (PropertyType == PropertyType.GetInline)
            {
                writer.Write(" => ").Write(InlinePropertyGet).Write(";");
            }
            else if (PropertyType != PropertyType.None)
            {
                writer.Write(" { ");
                if (PropertyType == PropertyType.Get)
                {
                    writer.Write("get");
                    if (!string.IsNullOrEmpty(InlinePropertyGet))
                        writer.Write(" => ").Write(InlinePropertyGet);
                    writer.Write(";");
                }
                else if (PropertyType == PropertyType.Set)
                {
                    writer.Write("set");
                    if (!string.IsNullOrEmpty(InlinePropertySet))
                        writer.Write(" => ").Write(InlinePropertySet);
                    writer.Write(";");
                }
                else if (PropertyType == PropertyType.GetSet)
                {
                    writer.Write("get");
                    if (!string.IsNullOrEmpty(InlinePropertyGet))
                        writer.Write(" => ").Write(InlinePropertyGet);
                    writer.Write(";");
                    writer.Write(" ");
                    writer.Write("set");
                    if (!string.IsNullOrEmpty(InlinePropertySet))
                        writer.Write(" => ").Write(InlinePropertySet);
                    writer.Write(";");
                }
                writer.Write(" }");
            }
            else
            {
                if (InitExpression != null)
                {
                    writer.Write(" = ");
                    var initExpressionStr = InitExpression.ToString();
                    if (string.IsNullOrEmpty(initExpressionStr))
                    {
                        InitValue?.WriteTo(writer);
                    }
                    else
                    {
                        writer.Write(initExpressionStr);
                    }
                }
                else if (InitValue != null)
                {
                    writer.Write(" = ");
                    InitValue.WriteTo(writer);
                }

                writer.Write(";");
            }
            writer.EndLine();
        }
    }
}