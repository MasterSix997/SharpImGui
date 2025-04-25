using System;
using System.Numerics;
using System.Runtime.InteropServices;
using SharpImGui;

namespace SharpImPlot3D
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlot3DBox
	{
		public ImPlot3DPoint Min;
		public ImPlot3DPoint Max;
	}

	public unsafe partial struct ImPlot3DBoxPtr
	{
		public ImPlot3DBox* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlot3DBox this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImPlot3DBoxPtr(ImPlot3DBox* nativePtr) => NativePtr = nativePtr;
		public ImPlot3DBoxPtr(IntPtr nativePtr) => NativePtr = (ImPlot3DBox*)nativePtr;
		public static implicit operator ImPlot3DBoxPtr(ImPlot3DBox* ptr) => new ImPlot3DBoxPtr(ptr);
		public static implicit operator ImPlot3DBoxPtr(IntPtr ptr) => new ImPlot3DBoxPtr(ptr);
		public static implicit operator ImPlot3DBox*(ImPlot3DBoxPtr nativePtr) => nativePtr.NativePtr;
	}
}
