using System.Text.Json;

namespace Generator;

public class CImGuiJsonProvider : INativeDefinitionProvider
{
    private const string DefinitionsFile = "definitions.json";
    private const string TypedefsFile = "typedefs_dict.json";
    private const string StructsAndEnumsFile = "structs_and_enums.json";

    public NativeDefinitions NativeDefinitions { get; private set; }

    public NativeDefinitions Parse(string folder)
    {
        NativeDefinitions = ParseToNativeDefinitions(folder);
        return NativeDefinitions;
    }
    
    private NativeDefinitions ParseToNativeDefinitions(string folder)
    {
        var definitionsPath = Path.GetFullPath(Path.Combine(folder, DefinitionsFile));
        var typedefsPath = Path.GetFullPath(Path.Combine(folder, TypedefsFile));
        var structsAndEnumsPath = Path.GetFullPath(Path.Combine(folder, StructsAndEnumsFile));

        if (!File.Exists(definitionsPath))
            throw new FileNotFoundException("Definitions file not found", definitionsPath);
        if (!File.Exists(typedefsPath))
            throw new FileNotFoundException("Typedefs file not found", typedefsPath);
        if  (!File.Exists(structsAndEnumsPath))
            throw new FileNotFoundException("Structs and enums file not found", structsAndEnumsPath);
        
        var definitionsJson = ReadJson(definitionsPath);
        var typedefsJson = ReadJson(typedefsPath);
        var structsAndEnumsJson = ReadJson(structsAndEnumsPath);

        return ExtractDefinitionsFromJson(definitionsJson, structsAndEnumsJson, typedefsJson);
    }
    
    private static JsonDocument ReadJson(string path)
    {
        var fileContent = File.ReadAllText(path);
        return JsonDocument.Parse(fileContent);
    }
    
    private static NativeDefinitions ExtractDefinitionsFromJson(JsonDocument definitionsJson, JsonDocument structsAndEnumsJson, JsonDocument typedefsJson)
    {
        var functionOverloads = new List<NativeFunctionsOverloads>();
        foreach (var jsonProperty in definitionsJson.RootElement.EnumerateObject())
        {
            functionOverloads.Add(ExtractOverloadsFromElement(jsonProperty.Value));
        }
     
        var nativeTypes = ExtractTypesFromElement(structsAndEnumsJson.RootElement);
     
        return new NativeDefinitions(
            functionOverloads.ToArray(),
            nativeTypes
        );
    }
    
    private static NativeFunctionsOverloads ExtractOverloadsFromElement(JsonElement element)
    {
        var nativeFunctions = new List<NativeFunction>();
        foreach (var jsonFunction in element.EnumerateArray())
        {
            var nativeFunction = ExtractFunctionFromElement(jsonFunction);
            nativeFunctions.Add(nativeFunction);
        }
        return new NativeFunctionsOverloads(nativeFunctions.ToArray());
    }
    
    private static NativeFunction ExtractFunctionFromElement(JsonElement element)
    {
        const string nameKey = "funcname";
        const string structNameKey = "stname";
        const string returnTypeKey = "ret";
        const string argumentsKey = "argsT";
        const string cImGuiNameKey = "cimguiname";
        const string constructorKey = "constructor";
        const string destructorKey = "destructor";
        const string commentKey = "comment";
        const string defaultValuesKey = "defaults";
        const string locationKey = "location";
        
        var defaultValues = new Dictionary<string, string>();
        foreach (var defaultValue in element.GetProperty(defaultValuesKey).EnumerateObject())
        {
            defaultValues.Add(defaultValue.Name, defaultValue.Value.GetString()!);
        }
        
        var location = element.GetProperty(locationKey).GetString();
        var isInternal = location?.StartsWith("imgui_internal");
        
        return new NativeFunction(
            element.TryGetProperty(cImGuiNameKey, out var name) ? name.GetString() : null,
            element.GetProperty(structNameKey).GetString()!,
            defaultValues,
            element.TryGetProperty(constructorKey, out var constructor) && constructor.GetBoolean(),
            element.TryGetProperty(destructorKey, out var destructor) && destructor.GetBoolean(),
            element.TryGetProperty(commentKey, out var comment) && comment.GetString() is not null? comment.GetString() : null,
            isInternal ?? false
        );
    }
    
    
    public static NativeTypes ExtractTypesFromElement(JsonElement element)
    {
        const string enumsKey = "enums";
        const string enumCommentsKey = "enum_comments";
        const string enumTypesKey = "enumtypes";
        const string structsKey = "structs";
        const string structCommentsKey = "struct_comments";
        const string locationsKey = "locations";
         
        var enumElements = element.GetProperty(enumsKey);
        var enumsHasComments = element.TryGetProperty(enumCommentsKey, out var enumCommentsProperty);
        var enumTypesElement = element.GetProperty(enumTypesKey);
        var structElements = element.GetProperty(structsKey);
        var structsHasComments = element.TryGetProperty(structCommentsKey, out var structCommentsProperty);
        var locationElements = element.GetProperty(locationsKey);
        
        var enums = new List<NativeEnum>();
        foreach (var enumProperty in enumElements.EnumerateObject())
        {
            JsonElement enumCommentElement = new();
            JsonElement enumTypeElement = new();
            var hasComment = enumsHasComments && enumCommentsProperty.TryGetProperty(enumProperty.Name, out enumCommentElement);
            var hasType = enumTypesElement.ValueKind == JsonValueKind.Object && enumTypesElement.TryGetProperty(enumProperty.Name[..^1], out enumTypeElement);
            var location = locationElements.GetProperty(enumProperty.Name).GetString();
            enums.Add(ExtractEnumFromJson(enumProperty, hasComment ? enumCommentElement : null, hasType ? enumTypeElement : null, location));
        }
        
        var structs = new List<NativeStruct>();
        foreach (var structProperty in structElements.EnumerateObject())
        {
            JsonElement structCommentProperty = new();
            var hasComment = structsHasComments && structCommentsProperty.TryGetProperty(structProperty.Name, out structCommentProperty);
            var location = locationElements.GetProperty(structProperty.Name).GetString();
            structs.Add(ExtractStructFromJson(structProperty, hasComment ? structCommentProperty : null, location));
        }

        return new NativeTypes(enums.ToArray(), structs.ToArray());
    }
    
    public static NativeEnum ExtractEnumFromJson(JsonProperty enumProperty, JsonElement? enumCommentElement, JsonElement? enumTypeElement, string? location)
    {
        const string aboveCommentKey = "above";
        
        var nativeEnumItems = new List<NativeEnumItem>();
        foreach (var enumItemElement in enumProperty.Value.EnumerateArray())
        {
            nativeEnumItems.Add(ExtractEnumItemFromElement(enumItemElement));
        }

        var comment = enumCommentElement?.GetProperty(aboveCommentKey).ToString();
        var type = enumTypeElement?.ToString();
        var isFlags = enumProperty.Name.Contains("Flags");
        var isInternal = location?.StartsWith("imgui_internal") ?? false;

        return new NativeEnum(enumProperty.Name, nativeEnumItems.ToArray(), comment, isFlags, isInternal);

    }
    
    public static NativeEnumItem ExtractEnumItemFromElement(JsonElement element)
    {
        const string nameKey = "name";
        const string valueKey = "calc_value";
        const string commentKey = "comment";
         
        var name = element.GetProperty(nameKey).GetString()!;
        var value = element.GetProperty(valueKey).GetInt32();
        var comment = element.TryGetProperty(commentKey, out var commentProperty) ? commentProperty.GetString() : null;
        return new NativeEnumItem(name, comment);
    }
    
    public static NativeStruct ExtractStructFromJson(JsonProperty structProperty, JsonElement? structCommentElement, string? location)
    {
        const string aboveCommentKey = "above";
        
        var nativeFields = new List<NativeField>();
        foreach (var fieldElement in structProperty.Value.EnumerateArray())
        {
            nativeFields.Add(ExtractFieldFromElement(fieldElement));
        }
        
        var comment = structCommentElement?.GetProperty(aboveCommentKey).ToString();
        var isInternal = location?.StartsWith("imgui_internal") ?? false;
        
        return new NativeStruct(structProperty.Name, nativeFields.ToArray(), comment, isInternal);
    }
    
    public static NativeField ExtractFieldFromElement(JsonElement element)
    {
        const string nameKey = "name";
        const string templateTypeKey = "template_type";
        const string typeKey = "type";
        const string sizeKey = "size";
        const string commentKey = "comment";
        const string sameLineCommentKey = "sameline";
        const string aboveCommentKey = "above";
        
        var name = element.GetProperty(nameKey).GetString()!;
        var templateType = element.TryGetProperty(templateTypeKey, out var templateTypeProperty) ? templateTypeProperty.GetString() : null;
        var type = element.GetProperty(typeKey).GetString()!;
        var size = element.TryGetProperty(sizeKey, out var sizeProperty) ? sizeProperty.GetInt32() : (int?)null;
        string? sameLineComment = null;
        string? aboveComment = null;
        if (element.TryGetProperty(commentKey, out var commentProperty))
        {
            if (commentProperty.TryGetProperty(sameLineCommentKey, out var sameLineCommentProperty))
                sameLineComment = sameLineCommentProperty.GetString();
            if (commentProperty.TryGetProperty(aboveCommentKey, out var aboveCommentProperty))
                aboveComment = aboveCommentProperty.GetString();
        }
        
        return new NativeField(name, sameLineComment, aboveComment);
    }
}