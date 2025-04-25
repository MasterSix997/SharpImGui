using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiInputEventKey
	{
		public ImGuiKey Key;
		public byte Down;
		public float AnalogValue;
	}

	public unsafe partial struct ImGuiInputEventKeyPtr
	{
		public ImGuiInputEventKey* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiInputEventKey this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImGuiInputEventKeyPtr(ImGuiInputEventKey* nativePtr) => NativePtr = nativePtr;
		public ImGuiInputEventKeyPtr(IntPtr nativePtr) => NativePtr = (ImGuiInputEventKey*)nativePtr;
		public static implicit operator ImGuiInputEventKeyPtr(ImGuiInputEventKey* ptr) => new ImGuiInputEventKeyPtr(ptr);
		public static implicit operator ImGuiInputEventKeyPtr(IntPtr ptr) => new ImGuiInputEventKeyPtr(ptr);
		public static implicit operator ImGuiInputEventKey*(ImGuiInputEventKeyPtr nativePtr) => nativePtr.NativePtr;
	}
}
