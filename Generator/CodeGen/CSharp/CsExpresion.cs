using System.Text;

namespace SharpImGui.Generator.CodeGen.CSharp;

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

    protected void ArgumentsSeparatedByCommaToString(StringBuilder builder)
    {
        if (Arguments != null)
        {
            for (var i = 0; i < Arguments.Count; i++)
            {
                var expression = Arguments[i];
                if (i > 0) builder.Append(", ");
                builder.Append(expression);
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
        var builder = new StringBuilder();
        builder.Append("{");
        ArgumentsSeparatedByCommaToString(builder);
        builder.Append("}");
        return builder.ToString();
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
        var builder = new StringBuilder();
        if (Arguments != null && Arguments.Count > 0)
        {
            builder.Append(Arguments[0]);
        }

        builder.Append(" ");
        builder.Append(Operator);
        builder.Append(" ");

        if (Arguments != null && Arguments.Count > 1)
        {
            builder.Append(Arguments[1]);
        }
        return builder.ToString();
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
        var builder = new StringBuilder();
        builder.Append(Operator);
        if (Arguments != null && Arguments.Count > 0)
        {
            builder.Append(Arguments[0]);
        }
        return builder.ToString();
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
        var builder = new StringBuilder();
        builder.Append("(");
        ArgumentsSeparatedByCommaToString(builder);
        builder.Append(")");
        return builder.ToString();
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
}