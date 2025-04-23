using System.Text.Json;

namespace Generator;

public interface INativeDefinitionProvider
{
    NativeDefinitions NativeDefinitions { get; }
    NativeDefinitions Parse(string folder);
}

public record NativeDefinitions(NativeFunctionsOverloads[] Functions, NativeTypes Types);

public record NativeFunctionsOverloads(NativeFunction[] Functions);

public record NativeFunction(
    string? Name,
    string StructName,
    Dictionary<string, string> DefaultValues,
    bool Constructor,
    bool Destructor,
    string? Comment,
    bool IsInternal = false);

// =============================
public record NativeTypes(NativeEnum[] Enums, NativeStruct[] Structs);

public record NativeEnum(string Name, NativeEnumItem[] Items, string? Comment, bool IsFlags = false, bool IsInternal = false);

public record NativeEnumItem(string Name, string? Comment);

public record NativeStruct(string Name, NativeField[] Fields, string? Comment, bool IsInternal = false);

public record NativeField(string Name, string? SameLineComment, string? AboveComment);