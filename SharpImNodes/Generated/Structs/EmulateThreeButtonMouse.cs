using System;
using System.Numerics;
using System.Runtime.InteropServices;
using SharpImGui;

namespace SharpImNodes
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct EmulateThreeButtonMouse
	{
		public unsafe byte* Modifier;
	}

	public unsafe partial struct EmulateThreeButtonMousePtr
	{
		public EmulateThreeButtonMouse* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public EmulateThreeButtonMouse this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public EmulateThreeButtonMousePtr(EmulateThreeButtonMouse* nativePtr) => NativePtr = nativePtr;
		public EmulateThreeButtonMousePtr(IntPtr nativePtr) => NativePtr = (EmulateThreeButtonMouse*)nativePtr;
		public static implicit operator EmulateThreeButtonMousePtr(EmulateThreeButtonMouse* ptr) => new EmulateThreeButtonMousePtr(ptr);
		public static implicit operator EmulateThreeButtonMousePtr(IntPtr ptr) => new EmulateThreeButtonMousePtr(ptr);
		public static implicit operator EmulateThreeButtonMouse*(EmulateThreeButtonMousePtr nativePtr) => nativePtr.NativePtr;
	}
}
