using System;
using System.Numerics;
using System.Runtime.InteropServices;
using SharpImGui;

namespace SharpImPlot
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlotRect
	{
		public ImPlotRange X;
		public ImPlotRange Y;
	}

	public unsafe partial struct ImPlotRectPtr
	{
		public ImPlotRect* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlotRect this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImPlotRectPtr(ImPlotRect* nativePtr) => NativePtr = nativePtr;
		public ImPlotRectPtr(IntPtr nativePtr) => NativePtr = (ImPlotRect*)nativePtr;
		public static implicit operator ImPlotRectPtr(ImPlotRect* ptr) => new ImPlotRectPtr(ptr);
		public static implicit operator ImPlotRectPtr(IntPtr ptr) => new ImPlotRectPtr(ptr);
		public static implicit operator ImPlotRect*(ImPlotRectPtr nativePtr) => nativePtr.NativePtr;
	}
}
