using Generator.CSharp;

namespace Generator;

public class CSharpGenerated
{
    public readonly Dictionary<string, CsType> AvailableTypes = new();
    public readonly Dictionary<string, string> TypeMap = new();
    
    public ICsDeclarationContainer CImGuiTypes { get; } = new CsGlobalDeclarationContainer();
    public ICsDeclarationContainer Definitions { get; } = new CsGlobalDeclarationContainer();
    public INativeDefinitionProvider? NativeDefinitionProvider { get; set; }
    public CsOutput Output { get; set; }
    public GeneratorSettings Settings { get; set; }

    public CSharpGenerated(GeneratorSettings settings)
    {
        Settings = settings;
        Output = new CsOutput(settings)
        {
            RootDirectory = settings.OutputDirectory,
            DefinitionsWithoutFiles = Definitions
        };

        AddTypeMaps(Settings.TypeMappings);

        AddTypes(settings.Types);
        // foreach (var type in settings.Types)
        // {
        //     AddType(new CsUnresolvedType(type));
        // }
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

            if (originalType is CsPointerType pointerType)
            {
                //C# doesn't support pointers type as generic type arguments ex: ImVector<int*>
                if (pointerType.GetCanonicalType().TypeName == "void")
                    originalType = GetCsType("IntPtr");
                else
                    originalType = new CsGenericType("ImPointer", pointerType.GetCanonicalType());
            }
            if (originalType is not null)
                return new CsGenericType("ImVector", originalType);
        }
        else if (nativeType.StartsWith("ImPool_"))
        {
            var originalType = GetCsType(nativeType[7..]);
            if (originalType is CsPointerType pointerType)
            {
                //C# doesn't support pointers type as generic type arguments ex: ImVector<int*>
                originalType = new CsGenericType("ImPointer", pointerType.GetCanonicalType());
            }
            if (originalType is not null)
                return new CsGenericType("ImPool", originalType);
        }
        else if (nativeType.StartsWith("ImSpan_"))
        {
            var originalType = GetCsType(nativeType[7..]);
            if (originalType is CsPointerType pointerType)
            {
                //C# doesn't support pointers type as generic type arguments ex: ImVector<int*>
                originalType = new CsGenericType("ImPointer", pointerType.GetCanonicalType());
            }
            if (originalType is not null)
                return new CsGenericType("ImSpan", originalType);
        }
        else if (nativeType.StartsWith("ImChunkStream_"))
        {
            var originalType = GetCsType(nativeType[14..]);
            if (originalType is not null)
                return new CsClass("ImChunkStream", CsClassKind.Struct);
        }

        if (nativeType.StartsWith("const ") || nativeType.StartsWith("const_"))
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
            var indexOfBracket = nativeType.IndexOf('[');
            var originalType = GetCsType(nativeType[..indexOfBracket]);
            if (originalType is not null)
                return new CsPointerType(originalType);
        }
        
        if (nativeType.StartsWith("union"))
        {
            return new CsUnresolvedType(nativeType, CsTypeKind.Primitive);
        }

        if (nativeType.EndsWith("Ptr"))
        {
            var originalType = GetCsType(nativeType[..^3]);
            if (originalType is not null)
                return new CsPointerType(originalType);
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