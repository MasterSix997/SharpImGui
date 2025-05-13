using SharpImGui;
using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

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
		public ref double X => ref Unsafe.AsRef<double>(&NativePtr->X);
		public ref double Y => ref Unsafe.AsRef<double>(&NativePtr->Y);
		public ref double Neg => ref Unsafe.AsRef<double>(&NativePtr->Neg);
		public ref double Pos => ref Unsafe.AsRef<double>(&NativePtr->Pos);
		public ImPlotPointErrorPtr(ImPlotPointError* nativePtr) => NativePtr = nativePtr;
		public ImPlotPointErrorPtr(IntPtr nativePtr) => NativePtr = (ImPlotPointError*)nativePtr;
		public static implicit operator ImPlotPointErrorPtr(ImPlotPointError* ptr) => new ImPlotPointErrorPtr(ptr);
		public static implicit operator ImPlotPointErrorPtr(IntPtr ptr) => new ImPlotPointErrorPtr(ptr);
		public static implicit operator ImPlotPointError*(ImPlotPointErrorPtr nativePtr) => nativePtr.NativePtr;
		public void PointErrorDestroy()
		{
			ImPlotNative.PointErrorDestroy(NativePtr);
		}

		public ImPlotPointErrorPtr PointErrorPointError(double x, double y, double neg, double pos)
		{
			return ImPlotNative.PointErrorPointError(x, y, neg, pos);
		}

	}
}
