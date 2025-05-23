using SharpImGui;
using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImNodes
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImNodesIO
	{
		public EmulateThreeButtonMouse EmulateThreeButtonMouse;
		public LinkDetachWithModifierClick LinkDetachWithModifierClick;
		public MultipleSelectModifier MultipleSelectModifier;
		public int AltMouseButton;
		public float AutoPanningSpeed;
	}

	public unsafe partial struct ImNodesIOPtr
	{
		public ImNodesIO* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImNodesIO this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref EmulateThreeButtonMouse EmulateThreeButtonMouse => ref Unsafe.AsRef<EmulateThreeButtonMouse>(&NativePtr->EmulateThreeButtonMouse);
		public ref LinkDetachWithModifierClick LinkDetachWithModifierClick => ref Unsafe.AsRef<LinkDetachWithModifierClick>(&NativePtr->LinkDetachWithModifierClick);
		public ref MultipleSelectModifier MultipleSelectModifier => ref Unsafe.AsRef<MultipleSelectModifier>(&NativePtr->MultipleSelectModifier);
		public ref int AltMouseButton => ref Unsafe.AsRef<int>(&NativePtr->AltMouseButton);
		public ref float AutoPanningSpeed => ref Unsafe.AsRef<float>(&NativePtr->AutoPanningSpeed);
		public ImNodesIOPtr(ImNodesIO* nativePtr) => NativePtr = nativePtr;
		public ImNodesIOPtr(IntPtr nativePtr) => NativePtr = (ImNodesIO*)nativePtr;
		public static implicit operator ImNodesIOPtr(ImNodesIO* ptr) => new ImNodesIOPtr(ptr);
		public static implicit operator ImNodesIOPtr(IntPtr ptr) => new ImNodesIOPtr(ptr);
		public static implicit operator ImNodesIO*(ImNodesIOPtr nativePtr) => nativePtr.NativePtr;
		public void Destroy()
		{
			ImNodesNative.ImNodesIODestroy(NativePtr);
		}

		public ImNodesIOPtr ImNodesIO()
		{
			return ImNodesNative.ImNodesIOImNodesIO();
		}

	}
}
