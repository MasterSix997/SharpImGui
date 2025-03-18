namespace SharpImGui.Generator.CodeGen.CSharp;

/// <summary>
/// A C# declaration that has a name
/// </summary>
public interface ICsMember : ICsElement
{
    /// <summary>
    /// Name of this C# declaration.
    /// </summary>
    string Name { get; set; }
}