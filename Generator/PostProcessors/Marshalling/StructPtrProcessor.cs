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

        var internalStruct = ExtractInternalMethods(mainStruct);
        if (internalStruct is not null)
        {
            var internalNamespace = new CsNamespace(_generated.Settings.Namespace);
            internalNamespace.Classes.Add(internalStruct);
            _generated.Output.AddFile($"{_generated.Settings.OriginalLibraryName}Internal.cs", internalNamespace, "Internal", usings: _generated.Settings.Usings);
        }
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

            foreach (var managedMethod in GenerateManagedMethodOverloads(managedStruct, csMethod, nativeLibrary))
            {
                managedMethod.IsStatic = true;
                managedStruct.Methods.Add(managedMethod);
            }
        }
        return managedStruct;
    }

    private CsClass? ExtractInternalMethods(CsClass csClass)
    {
        var overloads = _generated.NativeDefinitionProvider?.NativeDefinitions.Functions;
        if (overloads is null)
            return null;
        
        var internalStruct = new CsClass($"{_generated.Settings.OriginalLibraryName}Internal")
        {
            Visibility = CsVisibility.Public,
            IsPartial = true,
            IsUnsafe = true,
            IsStatic = true,
        };
        
        foreach (var overload in overloads)
        {
            foreach (var function in overload.Functions.Where(f => f.IsInternal))
            {
                var csMethod = csClass.Methods.FirstOrDefault(m => m.Metadata is CppFunction cppFunction && cppFunction.Name == function.Name);
                if (csMethod is null)
                    continue;
                
                csClass.Methods.Remove(csMethod);
                internalStruct.Methods.Add(csMethod);
            }
        }

        return internalStruct.Methods.Count > 0 ? internalStruct : null;
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
            
            var originalMethod = nativeMethods[i];
            foreach (var managedMethod in GenerateManagedMethodOverloads(ptrStruct, originalMethod, csStruct).ToImmutableArray())
            {
                if (managedMethod.Name.StartsWith(csStruct.Name))
                    managedMethod.Name = managedMethod.Name[csStruct.Name.Length..];
                
                ptrStruct.Methods.Add(managedMethod);
            }
        }
        
        // RemoveMethodsWithSameSignature(ptrStruct);

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
            Metadata = csField.Metadata
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

    private IEnumerable<CsMethod> GenerateManagedMethodOverloads(CsClass managedStruct, CsMethod originalMethod, CsClass originalStruct)
    {
        var overloadsGenerators = new HashSet<ICSharpMarshalling>();
        var overloadInfos = new List<MethodOverloadInfo>();
        
        foreach (var methodParameter in originalMethod.Parameters)
        {
            foreach (var marshalling in TypeMarshallings)
            {
                if (marshalling.OverloadsCount <= 0) continue;
                if (!marshalling.CanMarshalOverload(methodParameter))
                    continue;

                if (!overloadsGenerators.Add(marshalling)) continue;
                for (var i = 0; i < marshalling.OverloadsCount; i++)
                {
                    var overloadInfo = new MethodOverloadInfo
                    {
                        OriginalMethod = originalMethod,
                        OriginalStruct = originalStruct,
                        OverloadMarshalling = marshalling,
                        OverloadIndex = i,
                    };
                    yield return GenerateManagedMethod(overloadInfo);
                    overloadInfos.Add(overloadInfo);
                }
            }
        }
        if (overloadsGenerators.Count == 0)
        {
            var overloadInfo = new MethodOverloadInfo
            {
                OriginalMethod = originalMethod,
                OriginalStruct = originalStruct
            };
            overloadInfos.Add(overloadInfo);
            yield return GenerateManagedMethod(overloadInfo);
        }
        var defaultValuesOverloads = GenerateOverloadsByDefaultValues(originalMethod, (originalMethod.Metadata as CppFunction)!, managedStruct).ToImmutableArray();
        if (defaultValuesOverloads.Length <= 0) 
            yield break;

        var methodsWithoutParameter = new HashSet<string>();
        var defaultValueMethods = new List<CsMethod>();
        foreach (var defaultValuesOverload in defaultValuesOverloads)
        {
            var overload = defaultValuesOverload.Method;
            foreach (var overloadInfo in overloadInfos)
            {
                var copyMethod = new CsMethod(overload.Name)
                {
                    Visibility = CsVisibility.Public,
                    Comment = overload.Comment,
                    Metadata = overload.Metadata,
                    IsStatic = overload.IsStatic,
                    ReturnType = overload.ReturnType,
                };
                copyMethod.Parameters.AddRange(overload.Parameters.Select(p => new CsParameter(p.Type, p.Name) { Metadata = p.Metadata }));
                MarshallMethod(copyMethod, overloadInfo, defaultValuesOverload.OmittedParameters);
                
                if (defaultValueMethods.Any(m => HasSameSignature(copyMethod, m)))
                    continue;
                
                defaultValueMethods.Add(copyMethod);
                yield return copyMethod;
            }
        }
    }
    
    public struct MethodOverloadInfo
    {
        public CsMethod OriginalMethod;
        public CsClass OriginalStruct;
        
        public ICSharpMarshalling? OverloadMarshalling;
        public int OverloadIndex;
    }
    
    private CsMethod GenerateManagedMethod(MethodOverloadInfo overloadInfo)
    {
        var csMethod = overloadInfo.OriginalMethod;
        var managedMethod = new CsMethod(csMethod.Name)
        {
            Visibility = CsVisibility.Public,
            ReturnType = csMethod.ReturnType,
            Comment = csMethod.Comment,
        };
        managedMethod.Parameters.AddRange(csMethod.Parameters.Select(p => new CsParameter(p.Type, p.Name) { Metadata = p.Metadata }));
        
        MarshallMethod(managedMethod, overloadInfo);
        
        if (_marshallingErrors != null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"==== Errors on marshalling method '{csMethod.Name}' in struct '{overloadInfo.OriginalStruct.Name}' ====");
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

    private void MarshallMethod(CsMethod csMethod, in MethodOverloadInfo overloadInfo, Dictionary<CsParameter, string>? omittedParameters = null)
    {
        var originalMethod = overloadInfo.OriginalMethod;
        
        var returnMarshalledInfo = new ReturnMarshalledInfo();
        var hasReturnInfo = false;
        foreach (var typeMarshalling in TypeMarshallings)
        {
            if (typeMarshalling.TryMarshalReturnValue(csMethod, overloadInfo, _generated, out returnMarshalledInfo))
            {
                hasReturnInfo = true;
                break;
            }
        }

        if (!hasReturnInfo)
            _marshallingErrors = $"No return value marshalling found for method '{csMethod.Name}'";
        
        var parametersMarshalledInfo = new List<ParameterMarshalledInfo>();
        foreach (var parameter in csMethod.Parameters)
        {
            var parameterMarshalledInfo = MarshallParameter(parameter, overloadInfo);
            parametersMarshalledInfo.Add(parameterMarshalledInfo);
        }

        csMethod.WriteBody = writer =>
        {
            var omittedParamsInfo = new List<ParameterMarshalledInfo>(); 
            if (omittedParameters is { Count: > 0 })
            {
                writer.WriteLine("// defining omitted parameters");
                var omittedParams = omittedParameters.Keys.ToArray();
                var omittedParamValues = omittedParameters.Values.ToArray();
                
                for (int i = 0; i < omittedParameters.Count; i++)
                {
                    var any = false;
                    foreach (var typeMarshalling in TypeMarshallings)
                    {
                        if (!typeMarshalling.TryProcessDefaultValue(omittedParams[i], omittedParamValues[i], out var omittedMarshalledInfo)) 
                            continue;
                        
                        omittedParamsInfo.Add(omittedMarshalledInfo);
                        any = true;
                        break;
                    }

                    if (!any)
                        writer.StartLine().Write($"{omittedParams[i].Type.TypeName} ").Write(omittedParams[i].Name).Write(" = ").Write(omittedParamValues[i]).Write(';').EndLine();
                }
            }
            
            
            foreach (var omittedInfo in omittedParamsInfo)
                omittedInfo.BeforeCallWriter?.Invoke(writer);
            
            foreach (var parameterInfo in parametersMarshalledInfo)
                parameterInfo.BeforeCallWriter?.Invoke(writer);
            
            var fixedParameters = parametersMarshalledInfo.Where(p => p.fixedCode != null).ToImmutableArray();
            var hasFixedBlock = fixedParameters.Length > 0;

            foreach (var omittedInfo in omittedParamsInfo.Where(p => p.fixedCode != null))
            {
                writer.WriteLine($"fixed ({omittedInfo.fixedCode})");
                hasFixedBlock = true;
            }
            
            foreach (var parameterInfo in fixedParameters)
                writer.WriteLine($"fixed ({parameterInfo.fixedCode})");
            
            if (hasFixedBlock)
                writer.PushBlock();
            
            writer.StartLine();
            
            var hasReturnVariable = csMethod.ReturnType is not CsPrimitiveType { Kind: CsPrimitiveKind.Void } 
                && (returnMarshalledInfo.UseReturnVariable
                || omittedParamsInfo.Any(p => p.AfterCallWriter != null) 
                || parametersMarshalledInfo.Any(p => p.AfterCallWriter != null));
            
            if (csMethod.ReturnType is not CsPrimitiveType { Kind: CsPrimitiveKind.Void})
            {
                writer.Write(hasReturnVariable
                    ? $"var {returnMarshalledInfo.OverrideReturnVariable ?? "result"} = "
                    : "return ");

                if (returnMarshalledInfo.BeforeCall != null)
                    writer.Write(returnMarshalledInfo.BeforeCall);
            }
            
            writer.Write($"{_generated.Settings.OriginalLibraryName}Native.")
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

            if (omittedParameters is { Count: > 0 })
            {
                var omittedParamNames = omittedParameters.Keys.ToArray();
                
                for (int i = omittedParameters.Count - 1; i >= 0; i--)
                {
                    if (parametersMarshalledInfo.Count > 0 || i < omittedParameters.Count - 1)
                        writer.Write(", ");
                    
                    writer.Write(omittedParamNames[i].Name);
                }
            }
            
            writer.Write(");").EndLine();
            
            if (returnMarshalledInfo.AfterCall != null)
                writer.WriteLine(returnMarshalledInfo.AfterCall);

            foreach (var omittedInfo in omittedParamsInfo)
                omittedInfo.AfterCallWriter?.Invoke(writer);
            
            foreach (var parameterInfo in parametersMarshalledInfo)
                parameterInfo.AfterCallWriter?.Invoke(writer);

            if (hasReturnVariable)
            {
                writer.WriteLine(returnMarshalledInfo.CustomReturn == null
                    ? $"return {returnMarshalledInfo.OverrideReturnVariable ?? "result"};"
                    : $"return {returnMarshalledInfo.CustomReturn};");
            }
            if (hasFixedBlock)
                writer.PopBlock();
        };

        for (var i = csMethod.Parameters.Count - 1; i >= 0; i--)
        {
            if (parametersMarshalledInfo[i].RemoveOriginalParameter)
                csMethod.Parameters.RemoveAt(i);
        }
    }
    
    private ParameterMarshalledInfo MarshallParameter(CsParameter csParameter, in MethodOverloadInfo overloadInfo)
    {
        foreach (var marshalling in TypeMarshallings)
        {
            if (marshalling.TryMarshalParameter(csParameter, overloadInfo, _generated, out var parameterMarshalledInfo))
            {
                parameterMarshalledInfo.OriginalParameter = csParameter;
                return parameterMarshalledInfo;
            }
        }
        _marshallingErrors += $"\nNo marshalling found for parameter '{csParameter.Name}' type '{csParameter.Type.TypeName}'";
        return new ParameterMarshalledInfo() {OriginalParameter = csParameter};
    }

    public struct MethodOmittedOverload
    {
        public CsMethod Method { get; set; }
        public Dictionary<CsParameter, string> OmittedParameters { get; set; }
    }

    private IEnumerable<MethodOmittedOverload> GenerateOverloadsByDefaultValues(CsMethod csMethod, CppFunction cppFunction, CsClass managedStruct) 
    {
        // Encontrar função nativa correspondente
        var nativeFunction = _generated.NativeDefinitionProvider?.NativeDefinitions.Functions?
            .SelectMany(f => f.Functions)
            .FirstOrDefault(f => f.Name == cppFunction.Name);
        
        if (nativeFunction == null) yield break;
        
        // Coletar parâmetros com valores padrão e suas posições
        var defaultParams = new List<(int Index, CsParameter Parameter, string Value)>();
        
        for (int i = 0; i < csMethod.Parameters.Count; i++)
        {
            if (csMethod.Parameters[i].Metadata is CppParameter cppParam &&
                nativeFunction.DefaultValues.TryGetValue(cppParam.Name, out string defaultValue))
            {
                // string mappedValue = defaultValuesMap.GetValueOrDefault(defaultValue, defaultValue);
                defaultParams.Add((i, csMethod.Parameters[i], defaultValue));
            }
        }
        
        if (defaultParams.Count == 0) yield break;
        
        // Ordenar os parâmetros com valor padrão do último para o primeiro
        defaultParams.Sort((a, b) => b.Index.CompareTo(a.Index));
        
        var skipIndices = new HashSet<int>();
        foreach (var (index, parameter, value) in defaultParams)
        {
            skipIndices.Add(index);
            
            var overload = new CsMethod(csMethod.Name)
            {
                Visibility = csMethod.Visibility,
                ReturnType = csMethod.ReturnType,
                IsUnsafe = csMethod.IsUnsafe,
                IsInline = csMethod.IsInline,
                Comment = csMethod.Comment,
                Metadata = csMethod.Metadata
            };
            
            // Adicionar apenas parâmetros não omitidos (sem valores padrão)
            for (int i = 0; i < csMethod.Parameters.Count; i++)
            {
                if (!skipIndices.Contains(i))
                {
                    var param = csMethod.Parameters[i];
                    overload.Parameters.Add(new CsParameter(param.Type, param.Name)
                    {
                        Metadata = param.Metadata
                    });
                }
            }
            
            // Criar dicionário com os parâmetros omitidos
            var omittedParams = new Dictionary<CsParameter, string>();
            foreach (var (idx, param, paramValue) in defaultParams)
            {
                if (skipIndices.Contains(idx))
                {
                    omittedParams[new CsParameter(param.Type, param.Name) { Metadata = param.Metadata }] = paramValue;
                }
            }
            
            var methodOverload = new MethodOmittedOverload
            {
                Method = overload,
                OmittedParameters = omittedParams
            };
            yield return methodOverload;
        }
    }
    
    private void RemoveMethodsWithSameSignature(CsClass csClass)
    {
        var duplicates = csClass.Methods
            .GroupBy(m => m.Name)
            .SelectMany(g => g
                .Where((m, i) => g
                    .Take(i)
                    .Any(prev => HasSameSignature(prev, m))
                )
            )
            .ToList();

        duplicates.ForEach(m => csClass.Methods.Remove(m));
    }

    private bool HasMethodWithSameSignature(CsClass csClass, CsMethod csMethod)
    {
        for (int i = 0; i < csClass.Methods.Count; i++)
        {
            if (HasSameSignature(csMethod, csClass.Methods[i]))
                return true;
        }

        return false;
    }
    
    private bool HasSameSignature(CsMethod csMethod1, CsMethod csMethod2)
    {
        if (csMethod1.Name != csMethod2.Name)
            return false;
        if (csMethod1.Parameters.Count != csMethod2.Parameters.Count)
            return false;
        if (csMethod1.IsImplicit != csMethod2.IsImplicit)
            return false;
        
        for (int i = 0; i < csMethod1.Parameters.Count; i++)
        {
            if (csMethod1.Parameters[i].Type.TypeName != csMethod2.Parameters[i].Type.TypeName)
                return false;
        }
        return true;
    }
}