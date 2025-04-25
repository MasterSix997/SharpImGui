using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// ImVec4: 4D vector used to store clipping rectangles, colors etc. [Compile-time configurable type]<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImVec4
	{
		public float X;
		public float Y;
		public float Z;
		public float W;
	}

	/// <summary>
	/// ImVec4: 4D vector used to store clipping rectangles, colors etc. [Compile-time configurable type]<br/>
	/// </summary>
	public unsafe partial struct ImVec4Ptr
	{
		public ImVec4* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImVec4 this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImVec4Ptr(ImVec4* nativePtr) => NativePtr = nativePtr;
		public ImVec4Ptr(IntPtr nativePtr) => NativePtr = (ImVec4*)nativePtr;
		public static implicit operator ImVec4Ptr(ImVec4* ptr) => new ImVec4Ptr(ptr);
		public static implicit operator ImVec4Ptr(IntPtr ptr) => new ImVec4Ptr(ptr);
		public static implicit operator ImVec4*(ImVec4Ptr nativePtr) => nativePtr.NativePtr;
	}
}
