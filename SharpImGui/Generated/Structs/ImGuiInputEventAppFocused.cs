using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiInputEventAppFocused
	{
		public byte Focused;
	}

	public unsafe partial struct ImGuiInputEventAppFocusedPtr
	{
		public ImGuiInputEventAppFocused* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiInputEventAppFocused this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImGuiInputEventAppFocusedPtr(ImGuiInputEventAppFocused* nativePtr) => NativePtr = nativePtr;
		public ImGuiInputEventAppFocusedPtr(IntPtr nativePtr) => NativePtr = (ImGuiInputEventAppFocused*)nativePtr;
		public static implicit operator ImGuiInputEventAppFocusedPtr(ImGuiInputEventAppFocused* ptr) => new ImGuiInputEventAppFocusedPtr(ptr);
		public static implicit operator ImGuiInputEventAppFocusedPtr(IntPtr ptr) => new ImGuiInputEventAppFocusedPtr(ptr);
		public static implicit operator ImGuiInputEventAppFocused*(ImGuiInputEventAppFocusedPtr nativePtr) => nativePtr.NativePtr;
	}
}
