namespace SharpImGui.Generator.CodeGen.CSharp;

/// <summary>
/// Gets the visibility of a C# element.
/// </summary>
public enum CsVisibility
{
    /// <summary>
    /// Default visibility is undefined or not relevant.
    /// </summary>
    Default,

    /// <summary>
    /// `public` visibility
    /// </summary>
    Public,
    
    /// <summary>
    /// `internal` visibility
    /// </summary>
    Internal,

    /// <summary>
    /// `protected` visibility
    /// </summary>
    Protected,

    /// <summary>
    /// `private` visibility
    /// </summary>
    Private,
}

public static class CsVisibilityExtensions
{
    public static string ToCode(this CsVisibility visibility)
    {
        switch (visibility)
        {
            case CsVisibility.Default:
                return "";
            case CsVisibility.Public:
                return "public";
            case CsVisibility.Internal:
                return "internal";
            case CsVisibility.Protected:
                return "protected";
            case CsVisibility.Private:
                return "private";
            default:
                throw new ArgumentOutOfRangeException(nameof(visibility), visibility, null);
        }
    }
}

/// <summary>
/// Interface of a <see cref="ICsMember"/> with a <see cref="CsVisibility"/>.
/// </summary>
public interface ICsMemberWithVisibility : ICsMember
{
    /// <summary>
    /// Gets or sets the visibility of this element.
    /// </summary>
    CsVisibility Visibility { get; set; }
}