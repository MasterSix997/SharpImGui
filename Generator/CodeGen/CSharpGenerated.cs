using Generator.CodeGen.CSharp;

namespace Generator.CodeGen;

public class CSharpGenerated
{
    public readonly Dictionary<string, CsType> AvailableTypes = new();
    public readonly Dictionary<string, string> TypeMap = new();

    public ICsDeclarationContainer Definitions { get; } = new CsGlobalDeclarationContainer();
    
    public CsOutput Output { get; set; } = new();

    public CSharpGenerated()
    {
        Output.DefinitionsWithoutFiles = Definitions;
    }

    public bool AddType(CsType type)
    {
        return AddType(type.TypeName, type);
    }
    
    public bool AddType(string name, CsType type)
    {
        return AvailableTypes.TryAdd(name, type);
    }
    
    public void AddTypes(IEnumerable<CsType> types)
    {
        foreach (var type in types)
        {
            AddType(type);
        }
    }
    
    public void AddTypes(Dictionary<string, CsType> types)
    {
        foreach (var type in types)
        {
            AddType(type.Key, type.Value);
        }
    }
    
    public bool AddTypeMap(string originalType, string convertedType)
    {
        if (TypeMap.TryGetValue(convertedType, out var value))
            convertedType = value;

        if (AvailableTypes.ContainsKey(originalType))
        {
            
        }
        
        return TypeMap.TryAdd(originalType, convertedType);
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
        nativeType = nativeType.Trim();
        
        nativeType = GetConvertedType(nativeType);
        var availableType = AvailableTypes.GetValueOrDefault(nativeType);
        if (availableType is not null)
            return availableType;
        
        if (nativeType.EndsWith('*'))
        {
            var originalType = GetCsType(nativeType[..^1]);
            if (originalType is null)
                return null;
    
            return new CsPointerType(originalType);
        }

        if (nativeType.EndsWith('_'))
        {
            var originalType = GetCsType(nativeType[..^1]);
            if (originalType is not null)
                return originalType;
        }

        if (nativeType.StartsWith("ImVector_"))
        {
            var originalType = GetCsType(nativeType[9..]);
            if (originalType is not null)
                return new CsGenericType("ImVector", originalType);
        }
        else if (nativeType.StartsWith("ImPool_"))
        {
            var originalType = GetCsType(nativeType[7..]);
            if (originalType is not null)
                return new CsGenericType("ImPool", originalType);
        }
        else if (nativeType.StartsWith("ImSpan_"))
        {
            var originalType = GetCsType(nativeType[7..]);
            if (originalType is not null)
                return new CsGenericType("ImSpan", originalType);
        }
        else if (nativeType.StartsWith("ImChunkStream_"))
        {
            var originalType = GetCsType(nativeType[14..]);
            if (originalType is not null)
                return new CsUnresolvedType("ImChunkStream", CsTypeKind.Struct);
        }

        if (nativeType.StartsWith("const "))
        {
            var originalType = GetCsType(nativeType[6..]);
            if (originalType is not null)
                return originalType;
        }
        
        if (nativeType.EndsWith(" const"))
        {
            var originalType = GetCsType(nativeType[..^6]);
            if (originalType is not null)
                return originalType;
        }
        
        if (nativeType.EndsWith(" const[]"))
        {
            var originalType = GetCsType(nativeType[..^7]);
            if (originalType is not null)
                return new CsPointerType(originalType);
        }
        
        if (nativeType.EndsWith(']') && nativeType.Contains('['))
        {
            var originalType = GetCsType(nativeType[..^3]);
            if (originalType is not null)
                return new CsPointerType(originalType);
        }
        
        if (nativeType.StartsWith("union"))
        {
            return new CsUnresolvedType(nativeType, CsTypeKind.Primitive);
        }

        return null;
    }
    
    // public enum UnresolvedTypeKind
    // {
    //     Normal,
    //     Delegate,
    //     Union,
    // }
    // public UnresolvedTypeKind GetUnresolvedTypeKind(string typeName, string typeDefinition)
    // {
    //     
    // }
}