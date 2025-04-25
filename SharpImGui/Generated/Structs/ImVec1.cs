using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImVec1
	{
		public float X;
	}

	public unsafe partial struct ImVec1Ptr
	{
		public ImVec1* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImVec1 this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImVec1Ptr(ImVec1* nativePtr) => NativePtr = nativePtr;
		public ImVec1Ptr(IntPtr nativePtr) => NativePtr = (ImVec1*)nativePtr;
		public static implicit operator ImVec1Ptr(ImVec1* ptr) => new ImVec1Ptr(ptr);
		public static implicit operator ImVec1Ptr(IntPtr ptr) => new ImVec1Ptr(ptr);
		public static implicit operator ImVec1*(ImVec1Ptr nativePtr) => nativePtr.NativePtr;
	}
}
