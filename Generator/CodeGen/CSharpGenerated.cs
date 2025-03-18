using SharpImGui.Generator.CodeGen.CSharp;

namespace SharpImGui.Generator.CodeGen;

public class CSharpGenerated
{
    public readonly Dictionary<string, CsType> AvailableTypes = new();
    public readonly Dictionary<string, string> TypeMap = new();

    public CsNamespace Generated { get; set; } = new("Generated");

    public void AddType(string name, CsType type)
    {
        if (!AvailableTypes.TryAdd(name, type))
        {
            AvailableTypes[name] = type;
        }
    }
    
    public void AddTypes(Dictionary<string, CsType> types)
    {
        foreach (var type in types)
        {
            AddType(type.Key, type.Value);
        }
    }
    
    public void AddTypeMap(string originalType, string convertedType)
    {
        if (!TypeMap.TryAdd(originalType, convertedType))
        {
            TypeMap[originalType] = convertedType;
        }
    }
    
    public void AddTypeMaps(Dictionary<string, string> typeMaps)
    {
        foreach (var typeMap in typeMaps)
        {
            AddTypeMap(typeMap.Key, typeMap.Value);
        }
    }
    
    public string GetConvertedType(string originalType)
    {
        return TypeMap.GetValueOrDefault(originalType, originalType);
    }
    
    public CsType? GetCsType(string nativeType)
    {
        var convertedType = GetConvertedType(nativeType);

        return null;
    }
}