using System;
using System.Numerics;
using System.Runtime.InteropServices;
using SharpImGui;

namespace SharpImPlot
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlotPoint
	{
		public double X;
		public double Y;
	}

	public unsafe partial struct ImPlotPointPtr
	{
		public ImPlotPoint* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlotPoint this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImPlotPointPtr(ImPlotPoint* nativePtr) => NativePtr = nativePtr;
		public ImPlotPointPtr(IntPtr nativePtr) => NativePtr = (ImPlotPoint*)nativePtr;
		public static implicit operator ImPlotPointPtr(ImPlotPoint* ptr) => new ImPlotPointPtr(ptr);
		public static implicit operator ImPlotPointPtr(IntPtr ptr) => new ImPlotPointPtr(ptr);
		public static implicit operator ImPlotPoint*(ImPlotPointPtr nativePtr) => nativePtr.NativePtr;
	}
}
