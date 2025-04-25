using System;
using System.Numerics;
using System.Runtime.InteropServices;
using SharpImGui;

namespace SharpImPlot3D
{
	/// <summary>
	/// ImPlot3DPoint: 3D vector to store points in 3D<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlot3DPoint
	{
		public float X;
		public float Y;
		public float Z;
	}

	/// <summary>
	/// ImPlot3DPoint: 3D vector to store points in 3D<br/>
	/// </summary>
	public unsafe partial struct ImPlot3DPointPtr
	{
		public ImPlot3DPoint* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlot3DPoint this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImPlot3DPointPtr(ImPlot3DPoint* nativePtr) => NativePtr = nativePtr;
		public ImPlot3DPointPtr(IntPtr nativePtr) => NativePtr = (ImPlot3DPoint*)nativePtr;
		public static implicit operator ImPlot3DPointPtr(ImPlot3DPoint* ptr) => new ImPlot3DPointPtr(ptr);
		public static implicit operator ImPlot3DPointPtr(IntPtr ptr) => new ImPlot3DPointPtr(ptr);
		public static implicit operator ImPlot3DPoint*(ImPlot3DPointPtr nativePtr) => nativePtr.NativePtr;
	}
}
