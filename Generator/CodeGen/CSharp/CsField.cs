using System.Text;

namespace SharpImGui.Generator.CodeGen.CSharp
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

        /// <summary>
        /// Gets or sets the width of the bit field in bits. Valid only if <see cref="IsBitField"/> is <c>true</c>.
        /// </summary>
        public int BitFieldWidth { get; set; }

        /// <summary>
        /// Gets or sets the offset of the field in bytes.
        /// </summary>
        public long Offset { get; set; }

        /// <inheritdoc />
        public override string ToString()
        {
            var builder = new StringBuilder();

            if (Visibility != CsVisibility.Default)
            {
                builder.Append(Visibility.ToString().ToLowerInvariant());
                builder.Append(' ');
            }

            if (StorageQualifier != CsStorageQualifier.None)
            {
                builder.Append(StorageQualifier.ToString().ToLowerInvariant());
                builder.Append(' ');
            }

            builder.Append(Type);
            builder.Append(' ');
            builder.Append(Name);

            if (InitExpression != null)
            {
                builder.Append(" = ");
                var initExpressionStr = InitExpression.ToString();
                if (string.IsNullOrEmpty(initExpressionStr))
                {
                    builder.Append(InitValue);
                }
                else
                {
                    builder.Append(initExpressionStr);
                }
            }
            else if (InitValue != null)
            {
                builder.Append(" = ");
                builder.Append(InitValue);
            }

            return builder.ToString();
        }

        public override void WriteTo(CodeWriter writer)
        {
            writer.StartLine();
            
            if (Visibility != CsVisibility.Default)
                writer.Write(Visibility.ToString().ToLowerInvariant()).Write(' ');
            
            Type.WriteTo(writer);
            writer.Write($" {Name}");
            
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
            writer.EndLine();
        }
    }
}