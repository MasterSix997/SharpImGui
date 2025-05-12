using SharpImGui;
using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImNodes
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct MultipleSelectModifier
	{
		public unsafe byte* Modifier;
	}

	public unsafe partial struct MultipleSelectModifierPtr
	{
		public MultipleSelectModifier* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public MultipleSelectModifier this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public IntPtr Modifier { get => (IntPtr)NativePtr->Modifier; set => NativePtr->Modifier = (byte*)value; }
		public MultipleSelectModifierPtr(MultipleSelectModifier* nativePtr) => NativePtr = nativePtr;
		public MultipleSelectModifierPtr(IntPtr nativePtr) => NativePtr = (MultipleSelectModifier*)nativePtr;
		public static implicit operator MultipleSelectModifierPtr(MultipleSelectModifier* ptr) => new MultipleSelectModifierPtr(ptr);
		public static implicit operator MultipleSelectModifierPtr(IntPtr ptr) => new MultipleSelectModifierPtr(ptr);
		public static implicit operator MultipleSelectModifier*(MultipleSelectModifierPtr nativePtr) => nativePtr.NativePtr;
		public void Destroy()
		{
			ImNodesNative.MultipleSelectModifierDestroy(NativePtr);
		}

		public MultipleSelectModifierPtr MultipleSelectModifier()
		{
			return ImNodesNative.MultipleSelectModifierMultipleSelectModifier();
		}

	}
}
