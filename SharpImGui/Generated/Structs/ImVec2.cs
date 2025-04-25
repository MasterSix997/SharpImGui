using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImVec2
	{
		public float X;
		public float Y;
	}

	public unsafe partial struct ImVec2Ptr
	{
		public ImVec2* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImVec2 this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImVec2Ptr(ImVec2* nativePtr) => NativePtr = nativePtr;
		public ImVec2Ptr(IntPtr nativePtr) => NativePtr = (ImVec2*)nativePtr;
		public static implicit operator ImVec2Ptr(ImVec2* ptr) => new ImVec2Ptr(ptr);
		public static implicit operator ImVec2Ptr(IntPtr ptr) => new ImVec2Ptr(ptr);
		public static implicit operator ImVec2*(ImVec2Ptr nativePtr) => nativePtr.NativePtr;
	}
}
