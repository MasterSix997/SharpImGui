using System.Text.Json;

namespace Generator.CodeGen;

public record NativeDefinitions(NativeFunctionsOverloads[] Functions, NativeTypes Types, NativeTypedef[] Typedefs)
{
    public static NativeDefinitions FromJson(JsonDocument definitionsJson, JsonDocument structsAndEnumsJson, JsonDocument typedefsJson)
    {
        var functionOverloads = new List<NativeFunctionsOverloads>();
        foreach (var jsonProperty in definitionsJson.RootElement.EnumerateObject())
        {
            functionOverloads.Add(NativeFunctionsOverloads.FromJson(jsonProperty.Value));
        }
        
        var nativeTypes = NativeTypes.FromJson(structsAndEnumsJson.RootElement);
        
        var nativeTypedefs = new List<NativeTypedef>();
        foreach (var jsonProperty in typedefsJson.RootElement.EnumerateObject())
        {
            nativeTypedefs.Add(NativeTypedef.FromJson(jsonProperty));
        }
        
        return new NativeDefinitions(
            functionOverloads.ToArray(),
            nativeTypes,
            nativeTypedefs.ToArray()
        );
    }
}

public record NativeFunctionsOverloads(NativeFunction[] Functions)
{
    public static NativeFunctionsOverloads FromJson(JsonElement element)
    {
        var nativeFunctions = new List<NativeFunction>();
        foreach (var jsonFunction in element.EnumerateArray())
        {
            var nativeFunction = NativeFunction.FromJson(jsonFunction);
            nativeFunctions.Add(nativeFunction);
        }
        return new NativeFunctionsOverloads(nativeFunctions.ToArray());
    }
}

public record NativeFunction(
    string? Name,
    string StructName,
    string CImGuiName,
    string? ReturnType,
    NativeArgument[] Arguments,
    Dictionary<string, string> DefaultValues,
    bool Constructor,
    bool Destructor,
    string? Comment,
    bool IsInternal = false)
{
    private const string NameKey = "funcname";
    private const string StructNameKey = "stname";
    private const string ReturnTypeKey = "ret";
    private const string ArgumentsKey = "argsT";
    private const string CImGuiNameKey = "cimguiname";
    private const string ConstructorKey = "constructor";
    private const string DestructorKey = "destructor";
    private const string CommentKey = "comment";
    private const string DefaultValuesKey = "defaults";
    private const string LocationKey = "location";
    
    public static NativeFunction FromJson(JsonElement element)
    {
        var nativeArguments = new List<NativeArgument>();
        foreach (var jsonArgument in element.GetProperty(ArgumentsKey).EnumerateArray())
        {
            var nativeArgument = NativeArgument.FromJson(jsonArgument);
            nativeArguments.Add(nativeArgument);
        }
        
        var defaultValues = new Dictionary<string, string>();
        foreach (var defaultValue in element.GetProperty(DefaultValuesKey).EnumerateObject())
        {
            defaultValues.Add(defaultValue.Name, defaultValue.Value.GetString()!);
        }
        
        var location = element.GetProperty(LocationKey).GetString();
        var isInternal = location?.StartsWith("imgui_internal");
        
        return new NativeFunction(
            element.TryGetProperty(NameKey, out var name) ? name.GetString() : null,
            element.GetProperty(StructNameKey).GetString()!,
            element.GetProperty(CImGuiNameKey).GetString()!,
            element.TryGetProperty(ReturnTypeKey, out var returnType) ? returnType.GetString() : null,
            nativeArguments.ToArray(),
            defaultValues,
            element.TryGetProperty(ConstructorKey, out var constructor) && constructor.GetBoolean(),
            element.TryGetProperty(DestructorKey, out var destructor) && destructor.GetBoolean(),
            element.TryGetProperty(CommentKey, out var comment) && comment.GetString() is not null? comment.GetString() : null,
            isInternal ?? false
        );
    }
}

public record NativeArgument(string Name, string Type)
{
    private const string NameKey = "name";
    private const string TypeKey = "type";
    public static NativeArgument FromJson(JsonElement element)
    {
        return new NativeArgument(
            element.GetProperty(NameKey).GetString()!,
            element.GetProperty(TypeKey).GetString()!
        );
    }
}

// =============================
public record NativeTypes(NativeEnum[] Enums, NativeStruct[] Structs)
{
    private const string EnumsKey = "enums";
    private const string EnumCommentsKey = "enum_comments";
    private const string EnumTypesKey = "enumtypes";
    private const string StructsKey = "structs";
    private const string StructCommentsKey = "struct_comments";
    private const string LocationsKey = "locations";
    
    public static NativeTypes FromJson(JsonElement element)
    {
        var enumsProperty = element.GetProperty(EnumsKey);
        var enumCommentsProperty = element.GetProperty(EnumCommentsKey);
        var enumTypesProperty = element.GetProperty(EnumTypesKey);
        var structsProperty = element.GetProperty(StructsKey);
        var structCommentsProperty = element.GetProperty(StructCommentsKey);
        var locationsProperty = element.GetProperty(LocationsKey);
        
        var enums = new List<NativeEnum>();
        foreach (var enumProperty in enumsProperty.EnumerateObject())
        {
            var hasComment = enumCommentsProperty.TryGetProperty(enumProperty.Name, out var enumCommentProperty);
            var hasType = enumTypesProperty.TryGetProperty(enumProperty.Name[..^1], out var enumTypeProperty);
            var location = locationsProperty.GetProperty(enumProperty.Name).GetString();
            enums.Add(NativeEnum.FromJson(enumProperty, hasComment ? enumCommentProperty : null, hasType ? enumTypeProperty : null, location));
        }
        
        var structs = new List<NativeStruct>();
        foreach (var structProperty in structsProperty.EnumerateObject())
        {
            var hasComment = structCommentsProperty.TryGetProperty(structProperty.Name, out var structCommentProperty);
            var location = locationsProperty.GetProperty(structProperty.Name).GetString();
            structs.Add(NativeStruct.FromJson(structProperty, hasComment ? structCommentProperty : null, location));
        }

        return new NativeTypes(enums.ToArray(), structs.ToArray());
    }
}

public record NativeEnum(string Name, NativeEnumItem[] Items, string? Comment, string? Type, bool IsFlags = false, bool IsInternal = false)
{
    private const string AboveCommentKey = "above";
    
    public static NativeEnum FromJson(JsonProperty enumProperty, JsonElement? enumCommentElement, JsonElement? enumTypeElement, string? location)
    {
        var nativeEnumItems = new List<NativeEnumItem>();
        foreach (var enumItemElement in enumProperty.Value.EnumerateArray())
        {
            nativeEnumItems.Add(NativeEnumItem.FromJson(enumItemElement));
        }

        var comment = enumCommentElement?.GetProperty(AboveCommentKey).ToString();
        var type = enumTypeElement?.ToString();
        var isFlags = enumProperty.Name.Contains("Flags");
        var isInternal = location?.StartsWith("imgui_internal") ?? false;

        return new NativeEnum(enumProperty.Name, nativeEnumItems.ToArray(), comment, type, isFlags, isInternal);

    }
}

public record NativeEnumItem(string Name, int Value, string? Comment)
{
    private const string NameKey = "name";
    private const string ValueKey = "calc_value";
    private const string CommentKey = "comment";
    
    public static NativeEnumItem FromJson(JsonElement element)
    {
        var name = element.GetProperty(NameKey).GetString()!;
        var value = element.GetProperty(ValueKey).GetInt32();
        var comment = element.TryGetProperty(CommentKey, out var commentProperty) ? commentProperty.GetString() : null;
        return new NativeEnumItem(name, value, comment);
    }
}

public record NativeStruct(string Name, NativeField[] Fields, string? Comment, bool IsInternal = false)
{
    private const string AboveCommentKey = "above";
    
    public static NativeStruct FromJson(JsonProperty structProperty, JsonElement? structCommentElement, string? location)
    {
        var nativeFields = new List<NativeField>();
        foreach (var fieldElement in structProperty.Value.EnumerateArray())
        {
            nativeFields.Add(NativeField.FromJson(fieldElement));
        }
        
        var comment = structCommentElement?.GetProperty(AboveCommentKey).ToString();
        var isInternal = location?.StartsWith("imgui_internal") ?? false;
        
        return new NativeStruct(structProperty.Name, nativeFields.ToArray(), comment, isInternal);
    }
}

public record NativeField(string Name, string? TemplateType, string Type, string? SameLineComment, string? AboveComment)
{
    private const string NameKey = "name";
    private const string TemplateTypeKey = "template_type";
    private const string TypeKey = "type";
    private const string CommentKey = "comment";
    private const string SameLineCommentKey = "sameline";
    private const string AboveCommentKey = "above";
    
    public static NativeField FromJson(JsonElement element)
    {
        var name = element.GetProperty(NameKey).GetString()!;
        var templateType = element.TryGetProperty(TemplateTypeKey, out var templateTypeProperty) ? templateTypeProperty.GetString() : null;
        var type = element.GetProperty(TypeKey).GetString()!;
        string? sameLineComment = null;
        string? aboveComment = null;
        if (element.TryGetProperty(CommentKey, out var commentProperty))
        {
            if (commentProperty.TryGetProperty(SameLineCommentKey, out var sameLineCommentProperty))
                sameLineComment = sameLineCommentProperty.GetString();
            if (commentProperty.TryGetProperty(AboveCommentKey, out var aboveCommentProperty))
                aboveComment = aboveCommentProperty.GetString();
        }
        
        return new NativeField(name, templateType, type, sameLineComment, aboveComment);
    }
}

public record NativeTypedef(string Name, string Type)
{
    public static NativeTypedef FromJson(JsonProperty property)
    {
        return new NativeTypedef(property.Name, property.Value.GetString()!);
    }
}