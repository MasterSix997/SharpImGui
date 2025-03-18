namespace Generator.CodeGen.CSharp;

public static class CsExtensions
{
    // /// <summary>
    // /// Gets a boolean indicating whether this token kind is an identifier or keyword
    // /// </summary>
    // /// <param name="kind">The token kind</param>
    // /// <returns><c>true</c> if the token is an identifier or keyword, <c>false</c> otherwise</returns>
    // public static bool IsIdentifierOrKeyword(this CsTokenKind kind)
    // {
    //     return kind == CsTokenKind.Identifier || kind == CsTokenKind.Keyword;
    // }

    /// <summary>
    /// Gets the display name of the specified type. If the type is <see cref="ICsMember"/> it will
    /// only use the name provided by <see cref="ICsMember.Name"/>
    /// </summary>
    /// <param name="type">The type</param>
    /// <returns>The display name</returns>
    public static string GetDisplayName(this CsType type)
    {
        if (type is ICsMember member) return member.Name;
        return type.ToString();
    }

    /// <summary>
    /// Gets a boolean indicating whether the attribute is a dllexport or visibility("default")
    /// </summary>
    /// <param name="attribute">The attribute to check against</param>
    /// <returns><c>true</c> if the attribute is a dllexport or visibility("default")</returns>
    public static bool IsPublicExport(this CsAttribute attribute)
    {
        return attribute.Name == "dllexport" || (attribute.Name == "visibility" && attribute.Arguments == "\"default\"");
    }
    
    /// <summary>
    /// Gets a boolean indicating whether the function is a dllexport or visibility("default")
    /// </summary>
    /// <param name="CsClass">The class to check against</param>
    /// <returns><c>true</c> if the class is a dllexport or visibility("default")</returns>
    public static bool IsPublicExport(this CsClass CsClass)
    {
        if(CsClass.Attributes != null)
        {
            foreach (var attr in CsClass.Attributes)
            {
                if (attr.IsPublicExport()) return true;
            }
        }
        return false;
    }
    
    // /// <summary>
    // /// Gets a boolean indicating whether the function is a dllexport or visibility("default")
    // /// </summary>
    // /// <param name="function">The function to check against</param>
    // /// <returns><c>true</c> if the function is a dllexport or visibility("default")</returns>
    // public static bool IsPublicExport(this CsMethod function)
    // {
    //     if (function.Attributes != null)
    //     {
    //         foreach (var attr in function.Attributes)
    //         {
    //             if (attr.IsPublicExport()) return true;
    //         }
    //     }
    //
    //     return function.LinkageKind == CsLinkageKind.External || function.LinkageKind == CsLinkageKind.UniqueExternal;
    // }
}