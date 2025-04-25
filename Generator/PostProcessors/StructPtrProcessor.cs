using Generator.CSharp;

namespace Generator.PostProcessors;

public struct StructPtrProcessor : IPostProcessor
{
    public void Process(CSharpGenerated generated)
    {
        foreach (var file in generated.Output.Files)
        {
            if (file.Type != GeneratedFile.FileType.Struct)
                continue;
            
            var ptrStruct = GeneratePtrStruct(file.Container.Classes.First(), generated);
            if (file.Container.Classes.Any(c => c.Name == ptrStruct.Name))
            {
                var existing = file.Container.Classes.First(c => c.Name == ptrStruct.Name);
                file.Container.Classes.Remove(existing);
            }
            file.Container.Classes.Add(ptrStruct);
        }
    }

    private static CsClass GeneratePtrStruct(CsClass csStruct, CSharpGenerated generated)
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
            GetProperty = "NativePtr == null",
        });
        ptrStruct.Fields.Add(new CsField(csStruct, "this[int index]")
        {
            Visibility = CsVisibility.Public,
            PropertyType = PropertyType.GetSet,
            GetProperty = "NativePtr[index]",
            SetProperty = "NativePtr[index] = value",
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
            Parameters = { new CsParameter(generated.GetCsType("IntPtr"), "nativePtr") },
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
            Parameters = { new CsParameter(generated.GetCsType("IntPtr"), "ptr") },
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
        
        
        // foreach (var field in csStruct.Fields)
        // {
        //     var managedField = GenerateManagedField(field);
        //     ptrStruct.Fields.Add(managedField);
        // }
         
        return ptrStruct;
    }

    private static CsField GenerateManagedField(CsField csField)
    {
        var type = csField.Type;
        var managedField = new CsField(type, csField.Name)
        {
            Visibility = CsVisibility.Public,
            Comment = csField.Comment,
            IsRef = true,
            PropertyType = PropertyType.GetInline,
            GetProperty = $"ref Unsafe.AsRef<{type.TypeName}>(&NativePtr->{csField.Name})",
        };
        
        return managedField;
    }
}