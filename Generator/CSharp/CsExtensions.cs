namespace Generator.CSharp;

public static class CsExtensions
{
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
    
    public static void WriteAttributesTo(this ICsAttributeContainer attributeContainer, CodeWriter writer)
    {
        attributeContainer.WriteAttributesTo(writer);
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