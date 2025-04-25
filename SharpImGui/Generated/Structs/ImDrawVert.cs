using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImDrawVert
	{
		public Vector2 Pos;
		public Vector2 Uv;
		public uint Col;
	}

	public unsafe partial struct ImDrawVertPtr
	{
		public ImDrawVert* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImDrawVert this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImDrawVertPtr(ImDrawVert* nativePtr) => NativePtr = nativePtr;
		public ImDrawVertPtr(IntPtr nativePtr) => NativePtr = (ImDrawVert*)nativePtr;
		public static implicit operator ImDrawVertPtr(ImDrawVert* ptr) => new ImDrawVertPtr(ptr);
		public static implicit operator ImDrawVertPtr(IntPtr ptr) => new ImDrawVertPtr(ptr);
		public static implicit operator ImDrawVert*(ImDrawVertPtr nativePtr) => nativePtr.NativePtr;
	}
}
