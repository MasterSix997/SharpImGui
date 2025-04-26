using System.Collections.Immutable;
using CppAst;
using Generator.CSharp;
using Generator.PostProcessors.Marshalling;

namespace Generator.PostProcessors;

public sealed class StructPtrProcessor : IPostProcessor
{
    public readonly List<ICSharpMarshalling> TypeMarshallings = CSharpMarshalHelper.DefaultMarshallers.ToList();
    private CSharpGenerated _generated;
    private List<CsMethod> _notUsedNativeMethods;
    
    public void Process(CSharpGenerated generated)
    {
        _generated = generated;
        var nativeMethodsContainer = generated.Output.Files.First(f => f.Type == GeneratedFile.FileType.NativeMethods).Container.Classes.First();
        _notUsedNativeMethods = new List<CsMethod>(nativeMethodsContainer.Methods);
        
        foreach (var file in generated.Output.Files)
        {
            if (file.Type != GeneratedFile.FileType.Struct)
                continue;
            
            var ptrStruct = GeneratePtrStruct(file.Container.Classes.First());
            if (file.Container.Classes.Any(c => c.Name == ptrStruct.Name))
            {
                var existing = file.Container.Classes.First(c => c.Name == ptrStruct.Name);
                file.Container.Classes.Remove(existing);
            }
            file.Container.Classes.Add(ptrStruct);
        }
        
        var mainStruct = GenerateMainStruct(nativeMethodsContainer);
        var mainNamespace = new CsNamespace(_generated.Settings.Namespace);
        mainNamespace.Classes.Add(mainStruct);
        _generated.Output.AddFile($"{_generated.Settings.OriginalLibraryName}.cs", mainNamespace, usings: _generated.Settings.Usings);
    }

    private CsClass GenerateMainStruct(CsClass nativeLibrary)
    {
        var managedStruct = new CsClass(_generated.Settings.OriginalLibraryName)
        {
            Visibility = CsVisibility.Public,
            IsPartial = true,
            IsUnsafe = true,
            IsStatic = true,
        };
        foreach (var csMethod in _notUsedNativeMethods)
        {
            if (csMethod.Name is "" or "GetLibraryName")
            {
                continue;
            }
            
            var managedMethod = GenerateManagedMethod(csMethod, managedStruct);
            managedMethod.IsStatic = true;
            managedStruct.Methods.Add(managedMethod);
        }
        return managedStruct;
    }

    private CsClass GeneratePtrStruct(CsClass csStruct)
    {
        var ptrStruct = new CsClass(csStruct.Name + "Ptr")
        {
            ClassKind = CsClassKind.Struct,
            Visibility = CsVisibility.Public,
            IsPartial = true,
            IsUnsafe = true,
            Comment = csStruct.Comment
        };
        var structPointerType = new CsPointerType(csStruct);
        var boolType = new CsUnresolvedType("bool");

        ptrStruct.Fields.Add(new CsField(structPointerType, "NativePtr")
        {
            Visibility = CsVisibility.Public,
            PropertyType = PropertyType.Get,
        });
        ptrStruct.Fields.Add(new CsField(boolType, "IsNull")
        {
            Visibility = CsVisibility.Public,
            PropertyType = PropertyType.GetInline,
            InlinePropertyGet = "NativePtr == null",
        });
        ptrStruct.Fields.Add(new CsField(csStruct, "this[int index]")
        {
            Visibility = CsVisibility.Public,
            PropertyType = PropertyType.GetSet,
            InlinePropertyGet = "NativePtr[index]",
            InlinePropertySet = "NativePtr[index] = value",
        });
        
        ptrStruct.Methods.Add(new CsMethod("")
        {
            Visibility = CsVisibility.Public,
            ReturnType = ptrStruct,
            Parameters = { new CsParameter(structPointerType, "nativePtr") },
            InlinedCode = "NativePtr = nativePtr",
        });
        ptrStruct.Methods.Add(new CsMethod("")
        {
            Visibility = CsVisibility.Public,
            ReturnType = ptrStruct,
            Parameters = { new CsParameter(_generated.GetCsType("IntPtr"), "nativePtr") },
            InlinedCode = $"NativePtr = ({csStruct.TypeName}*)nativePtr",
        });

        ptrStruct.Methods.Add(new CsMethod("")
        {
            Visibility = CsVisibility.Public,
            ReturnType = ptrStruct,
            IsStatic = true,
            IsImplicit = true,
            IsOperator = true,
            Parameters = { new CsParameter(structPointerType, "ptr") },
            InlinedCode = $"new {ptrStruct.Name}(ptr)"
        });
        ptrStruct.Methods.Add(new CsMethod("")
        {
            Visibility = CsVisibility.Public,
            ReturnType = ptrStruct,
            IsStatic = true,
            IsImplicit = true,
            IsOperator = true,
            Parameters = { new CsParameter(_generated.GetCsType("IntPtr"), "ptr") },
            InlinedCode = $"new {ptrStruct.Name}(ptr)"
        });
        ptrStruct.Methods.Add(new CsMethod("")
        {
            Visibility = CsVisibility.Public,
            ReturnType = structPointerType,
            IsStatic = true,
            IsImplicit = true,
            IsOperator = true,
            Parameters = { new CsParameter(ptrStruct, "nativePtr") },
            InlinedCode = $"nativePtr.NativePtr"
        });
        
        // ptrStruct.Methods.Add(new CsMethod("==")
        // {
        //     Visibility = CsVisibility.Public,
        //     ReturnType = boolType,
        //     IsStatic = true,
        //     IsOperator = true,
        //     Parameters = { new CsParameter(ptrStruct, "left"), new CsParameter(ptrStruct, "right") },
        //     InlinedCode = $"left.NativePtr == right.NativePtr"
        // });


        for (var i = 0; i < csStruct.Fields.Count; i++)
        {
            var field = csStruct.Fields[i];
            if (field.Metadata is CppField cppField)
            {
                var arraySize = GetArraySize(cppField);
                if (arraySize > 0)
                {
                    var arrayField = GenerateManagedArrayField(field, arraySize);
                    ptrStruct.Fields.Add(arrayField);
                    i += arraySize - 1;
                    continue;
                }
            }

            var managedField = GenerateManagedField(field);
            ptrStruct.Fields.Add(managedField);
        }

        var nativeMethods = _notUsedNativeMethods.Where(m => m.Metadata is CppFunction cppFunction && cppFunction.Name.StartsWith(csStruct.Name + "_")).ToList();
        
        for (int i = nativeMethods.Count - 1; i >= 0; i--)
        {
            _notUsedNativeMethods.Remove(nativeMethods[i]);
            
            var nativeMethod = nativeMethods[i];
            var managedMethod = GenerateManagedMethod(nativeMethod, csStruct);
            
            if (managedMethod.Name.StartsWith(csStruct.Name))
                managedMethod.Name = managedMethod.Name[csStruct.Name.Length..];
            
            ptrStruct.Methods.Add(managedMethod);
        }

        return ptrStruct;
    }

    private int GetArraySize(CppField cppField)
    {
        var indexOfBracket = cppField.Type.FullName.IndexOf('[');
        if (indexOfBracket is -1) return -1;
        var indexOfClosingBracket = cppField.Type.FullName.IndexOf(']');
        var fieldSize = int.Parse(cppField.Type.FullName[(indexOfBracket + 1)..indexOfClosingBracket]);
        return fieldSize;

    }
    
    private string? _marshallingErrors;

    private CsField GenerateManagedField(CsField csField)
    {
        var managedField = new CsField(csField.Type, csField.Name)
        {
            Visibility = CsVisibility.Public,
            Comment = csField.Comment,
        };
        MarshallField(managedField);
        if (_marshallingErrors != null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"==== Errors on marshalling field '{csField.Name}' in struct '{(csField.Parent as CsClass)!.Name}' ====");
            Console.WriteLine(_marshallingErrors);
            Console.ResetColor();

            managedField.Comment = new CsDocComment(_marshallingErrors);
            _marshallingErrors = null;
        }
        return managedField;
    }

    private CsField GenerateManagedArrayField(CsField firstField, int arraySize)
    {
        var type = firstField.Type;
        if (type is CsPointerType)
        {
            type = new CsGenericType($"ImPointer", [type.GetCanonicalType()]);
        }
        var arrayType = new CsUnresolvedType($"Span<{type.TypeName}>");
        var csArrayField = new CsField(arrayType, string.Join("_", firstField.Name.Split('_')[..^1]))
        {
            Visibility = CsVisibility.Public,
            Comment = firstField.Comment,
            PropertyType = PropertyType.GetInline,
            InlinePropertyGet = $"new Span<{type.TypeName}>(&NativePtr->{firstField.Name}, {arraySize})"
        };
        return csArrayField;
    }

    private CsMethod GenerateManagedMethod(CsMethod csMethod, CsClass csStruct)
    {
        var managedMethod = new CsMethod(csMethod.Name)
        {
            Visibility = CsVisibility.Public,
            ReturnType = csMethod.ReturnType,
            IsUnsafe = csMethod.IsUnsafe,
            Comment = csMethod.Comment,
        };
        managedMethod.Parameters.AddRange(csMethod.Parameters.Select(p => new CsParameter(p.Type, p.Name)));
        
        MarshallMethod(managedMethod, csMethod, csStruct);
        if (_marshallingErrors != null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"==== Errors on marshalling method '{csMethod.Name}' in struct '{csStruct.Name}' ====");
            Console.WriteLine(_marshallingErrors);
            Console.ResetColor();

            managedMethod.Comment = new CsDocComment(_marshallingErrors);
            _marshallingErrors = null;
        }
        return managedMethod;
    }

    private void MarshallField(CsField csField)
    {
        foreach (var marshalling in TypeMarshallings)
        {
            if (marshalling.TryMarshalField(csField, _generated))
                return;
        }
        _marshallingErrors = $"No marshalling found for field '{csField.Name}' type '{csField.Type.TypeName}'";
    }

    private void MarshallMethod(CsMethod csMethod, CsMethod originalMethod, CsClass csStruct)
    {
        var returnMarshalledInfo = new ReturnMarshalledInfo();
        var hasReturnInfo = TypeMarshallings.Any(typeMarshalling => typeMarshalling.TryMarshalReturnValue(csMethod, csStruct, _generated, out returnMarshalledInfo));
        if (!hasReturnInfo)
            _marshallingErrors = $"No return value marshalling found for method '{csMethod.Name}'";
        
        var parametersMarshalledInfo = new List<ParameterMarshalledInfo>();
        foreach (var parameter in csMethod.Parameters)
        {
            var parameterMarshalledInfo = MarshallParameter(parameter, csStruct);
            parametersMarshalledInfo.Add(parameterMarshalledInfo);
        }

        csMethod.WriteBody = writer =>
        {
            foreach (var parameterInfo in parametersMarshalledInfo)
                parameterInfo.BeforeCallWriter?.Invoke(writer);
            
            var fixedParameters = parametersMarshalledInfo.Where(p => p.fixedCode != null).ToImmutableArray();
            foreach (var parameterInfo in fixedParameters)
                writer.WriteLine($"fixed ({parameterInfo.fixedCode})");
            if (fixedParameters.Length > 0)
                writer.PushBlock();
            
            writer.StartLine();
            
            var hasReturnVariable = returnMarshalledInfo.UseReturnVariable;
            if (csMethod.ReturnType is not CsPrimitiveType { Kind: CsPrimitiveKind.Void})
            {
                if (!hasReturnVariable && fixedParameters.Length == 0)
                {
                    writer.Write("return ");
                }
                else
                {
                    hasReturnVariable = true;
                    writer.Write($"var {returnMarshalledInfo.OverrideReturnVariable ?? "result"} = ");
                }
                
                if (returnMarshalledInfo.BeforeCall != null)
                    writer.Write(returnMarshalledInfo.BeforeCall);
            }
            
            writer.Write($"{_generated.Settings.OriginalLibraryName}Native.")
                // .Write($"{csStruct.Name}{csMethod.Name}")
                .Write(originalMethod.Name)
                .Write("(");
            
            for (var i = 0; i < parametersMarshalledInfo.Count; i++)
            {
                var parameterInfo = parametersMarshalledInfo[i];
                if (i != 0) writer.Write(", ");
                
                if (parameterInfo.BeforeParameter != null)
                    writer.Write(parameterInfo.BeforeParameter!);
                
                writer.Write(parameterInfo.Name);
                
                if (parameterInfo.AfterParameter != null)
                    writer.Write(parameterInfo.AfterParameter!);
            }
            
            writer.Write(");").EndLine();
            
            if (returnMarshalledInfo.AfterCall != null)
                writer.WriteLine(returnMarshalledInfo.AfterCall);
            
            foreach (var parameterInfo in parametersMarshalledInfo)
                parameterInfo.AfterCallWriter?.Invoke(writer);

            if (hasReturnVariable)
            {
                writer.WriteLine(returnMarshalledInfo.CustomReturn == null
                    ? $"return {returnMarshalledInfo.OverrideReturnVariable ?? "result"};"
                    : $"return {returnMarshalledInfo.CustomReturn};");
            }
            if (fixedParameters.Length > 0)
                writer.PopBlock();
        };

        for (var i = csMethod.Parameters.Count - 1; i >= 0; i--)
        {
            if (parametersMarshalledInfo[i].RemoveOriginalParameter)
                csMethod.Parameters.RemoveAt(i);
        }
    }
    
    private ParameterMarshalledInfo MarshallParameter(CsParameter csParameter, CsClass csStruct)
    {
        // var overloadsGenerators = new HashSet<ICSharpMarshalling>();
        foreach (var marshalling in TypeMarshallings)
        {
            // if (marshalling.OverloadsCount > 0)
            // {
            //     if (!overloadsGenerators.Contains(marshalling))
            //     {
            //         overloadsGenerators.Add(marshalling);
            //         var csMethod = csParameter.Parent as CsMethod;
            //         for (int i = 0; i < marshalling.OverloadsCount; i++)
            //         {
            //             var overloadMethod = new CsMethod(csMethod.Name)
            //             {
            //                 Visibility = csMethod.Visibility,
            //                 ReturnType = csMethod.ReturnType,
            //                 Comment = csMethod.Comment,
            //             };
            //             overloadMethod.Parameters.AddRange(csMethod.Parameters.Select(p => new CsParameter(p.Type, p.Name)));
            //             overloadMethod.Metadata = csMethod.Metadata;
            //             
            //         }
            //     }
            // }
            
            if (marshalling.TryMarshalParameter(csParameter, csStruct, _generated, out var parameterMarshalledInfo))
            {
                parameterMarshalledInfo.OriginalParameter = csParameter;
                return parameterMarshalledInfo;
            }
        }
        _marshallingErrors += $"\nNo marshalling found for parameter '{csParameter.Name}' type '{csParameter.Type.TypeName}'";
        return new ParameterMarshalledInfo() {OriginalParameter = csParameter};
    }
    
}