using System;
using System.Numerics;
using System.Runtime.InteropServices;
using SharpImGui;

namespace SharpImPlot
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlotPointError
	{
		public double X;
		public double Y;
		public double Neg;
		public double Pos;
	}

	public unsafe partial struct ImPlotPointErrorPtr
	{
		public ImPlotPointError* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlotPointError this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImPlotPointErrorPtr(ImPlotPointError* nativePtr) => NativePtr = nativePtr;
		public ImPlotPointErrorPtr(IntPtr nativePtr) => NativePtr = (ImPlotPointError*)nativePtr;
		public static implicit operator ImPlotPointErrorPtr(ImPlotPointError* ptr) => new ImPlotPointErrorPtr(ptr);
		public static implicit operator ImPlotPointErrorPtr(IntPtr ptr) => new ImPlotPointErrorPtr(ptr);
		public static implicit operator ImPlotPointError*(ImPlotPointErrorPtr nativePtr) => nativePtr.NativePtr;
	}
}
