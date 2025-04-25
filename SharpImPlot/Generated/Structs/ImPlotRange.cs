using System;
using System.Numerics;
using System.Runtime.InteropServices;
using SharpImGui;

namespace SharpImPlot
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlotRange
	{
		public double Min;
		public double Max;
	}

	public unsafe partial struct ImPlotRangePtr
	{
		public ImPlotRange* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlotRange this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImPlotRangePtr(ImPlotRange* nativePtr) => NativePtr = nativePtr;
		public ImPlotRangePtr(IntPtr nativePtr) => NativePtr = (ImPlotRange*)nativePtr;
		public static implicit operator ImPlotRangePtr(ImPlotRange* ptr) => new ImPlotRangePtr(ptr);
		public static implicit operator ImPlotRangePtr(IntPtr ptr) => new ImPlotRangePtr(ptr);
		public static implicit operator ImPlotRange*(ImPlotRangePtr nativePtr) => nativePtr.NativePtr;
	}
}
