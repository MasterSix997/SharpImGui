using System.Text;

namespace Generator.CSharp;

public enum CsExpressionKind
{
    Unexposed,
    DeclRef,
    MemberRef,
    Call,
    ObjCMessage,
    Block,
    IntegerLiteral,
    FloatingLiteral,
    ImaginaryLiteral,
    StringLiteral,
    CharacterLiteral,
    Paren,
    UnaryOperator,
    ArraySubscript,
    BinaryOperator,
    CompoundAssignOperator,
    ConditionalOperator,
    CStyleCast,
    CompoundLiteral,
    InitList,
    AddrLabel,
    Stmt,
    GenericSelection,
    GNUNull,
    CXXStaticCast,
    CXXDynamicCast,
    CXXReinterpretCast,
    CXXConstCast,
    CXXFunctionalCast,
    CXXTypeid,
    CXXBoolLiteral,
    CXXNullPtrLiteral,
    CXXThis,
    CXXThrow,
    CXXNew,
    CXXDelete,
    Unary,
    ObjCStringLiteral,
    ObjCEncode,
    ObjCSelector,
    ObjCProtocol,
    ObjCBridgedCast,
    PackExpansion,
    SizeOfPack,
    Lambda,
    ObjCBoolLiteral,
    ObjCSelf,
    OMPArraySection,
    ObjCAvailabilityCheck,
    FixedPointLiteral,
}

/// <summary>
/// Base class for expressions used in <see cref="CsField.InitExpression"/> and <see cref="CsParameter.InitExpression"/>
/// </summary>
public abstract class CsExpression : CsElement
{
    protected CsExpression(CsExpressionKind kind)
    {
        Kind = kind;
    }

    /// <summary>
    /// Gets the kind of this expression.
    /// </summary>
    public CsExpressionKind Kind { get; }

    /// <summary>
    /// Gets the arguments of this expression. Might be null.
    /// </summary>
    public List<CsExpression>? Arguments { get; set; }

    /// <summary>
    /// Adds an argument to this expression.
    /// </summary>
    /// <param name="arg">An argument</param>
    public void AddArgument(CsExpression arg)
    {
        if (arg == null) throw new ArgumentNullException(nameof(arg));
        if (Arguments == null) Arguments = new List<CsExpression>();
        Arguments.Add(arg);
    }

    protected void WriteArgumentsSeparatedByComma(CodeWriter writer)
    {
        if (Arguments != null)
        {
            for (var i = 0; i < Arguments.Count; i++)
            {
                var expression = Arguments[i];
                if (i > 0) writer.Write(", ");
                expression.WriteTo(writer);
            }
        }
    }
}

/// <summary>
/// A C# Init list expression `{ a, b, c }`
/// </summary>
public class CsInitListExpression : CsExpression
{
    public CsInitListExpression() : base(CsExpressionKind.InitList)
    {
    }

    public override string ToString()
    {
        var writer = new StringCodeWriter();
        WriteTo(writer);
        return writer.ToString();
    }
    
    public override void WriteTo(CodeWriter writer)
    {
        writer.Write("{");
        WriteArgumentsSeparatedByComma(writer);
        writer.Write("}");
    }
}

/// <summary>
/// A binary expression
/// </summary>
public class CsBinaryExpression : CsExpression
{
    public CsBinaryExpression(CsExpressionKind kind) : base(kind)
    {
    }

    /// <summary>
    /// The binary operator as a string.
    /// </summary>
    public string Operator { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        var writer = new StringCodeWriter();
        WriteTo(writer);
        return writer.ToString();
    }
    
    public override void WriteTo(CodeWriter writer)
    {
        if (Arguments != null && Arguments.Count > 0)
        {
            Arguments[0].WriteTo(writer);
        }

        writer.Write(" ");
        writer.Write(Operator);
        writer.Write(" ");

        if (Arguments != null && Arguments.Count > 1)
        {
            Arguments[1].WriteTo(writer);
        }
    }
}

/// <summary>
/// A unary expression.
/// </summary>
public class CsUnaryExpression : CsExpression
{
    public CsUnaryExpression(CsExpressionKind kind) : base(kind)
    {
    }

    /// <summary>
    /// The unary operator as a string.
    /// </summary>
    public string Operator { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        var writer = new StringCodeWriter();
        WriteTo(writer);
        return writer.ToString();
    }
    
    public override void WriteTo(CodeWriter writer)
    {
        writer.Write(Operator);
        if (Arguments != null && Arguments.Count > 0)
        {
            writer.Write(" ");
            Arguments[0].WriteTo(writer);
        }
    }
}

/// <summary>
/// An expression surrounding another expression by parenthesis.
/// </summary>
public class CsParenExpression : CsExpression
{
    public CsParenExpression() : base(CsExpressionKind.Paren)
    {
    }

    /// <inheritdoc />
    public override string ToString()
    {
        var writer = new StringCodeWriter();
        WriteTo(writer);
        return writer.ToString();
    }

    public override void WriteTo(CodeWriter writer)
    {
        writer.Write("(");
        WriteArgumentsSeparatedByComma(writer);
        writer.Write(")");
    }
}

/// <summary>
/// A literal expression.
/// </summary>
public class CsLiteralExpression : CsExpression
{
    public CsLiteralExpression(CsExpressionKind kind, string value) : base(kind)
    {
        Value = value;
    }

    /// <summary>
    /// A textual representation of the literal value.
    /// </summary>
    public string Value { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return Value;
    }

    public override void WriteTo(CodeWriter writer)
    {
        writer.Write(Value);
    }
}