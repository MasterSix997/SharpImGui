using System;
using System.Numerics;
using System.Runtime.InteropServices;
using SharpImGui;

namespace SharpImPlot
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlotTime
	{
		public long S;
		public int Us;
	}

	public unsafe partial struct ImPlotTimePtr
	{
		public ImPlotTime* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlotTime this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImPlotTimePtr(ImPlotTime* nativePtr) => NativePtr = nativePtr;
		public ImPlotTimePtr(IntPtr nativePtr) => NativePtr = (ImPlotTime*)nativePtr;
		public static implicit operator ImPlotTimePtr(ImPlotTime* ptr) => new ImPlotTimePtr(ptr);
		public static implicit operator ImPlotTimePtr(IntPtr ptr) => new ImPlotTimePtr(ptr);
		public static implicit operator ImPlotTime*(ImPlotTimePtr nativePtr) => nativePtr.NativePtr;
	}
}
