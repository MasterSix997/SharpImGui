using SharpImGui;
using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

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
		public ref double X => ref Unsafe.AsRef<double>(&NativePtr->X);
		public ref double Y => ref Unsafe.AsRef<double>(&NativePtr->Y);
		public ImPlotPointPtr(ImPlotPoint* nativePtr) => NativePtr = nativePtr;
		public ImPlotPointPtr(IntPtr nativePtr) => NativePtr = (ImPlotPoint*)nativePtr;
		public static implicit operator ImPlotPointPtr(ImPlotPoint* ptr) => new ImPlotPointPtr(ptr);
		public static implicit operator ImPlotPointPtr(IntPtr ptr) => new ImPlotPointPtr(ptr);
		public static implicit operator ImPlotPoint*(ImPlotPointPtr nativePtr) => nativePtr.NativePtr;
		public ImPlotPointPtr PointPointVec2(Vector2 p)
		{
			return ImPlotNative.PointPointVec2(p);
		}

		public ImPlotPointPtr PointPointDouble(double x, double y)
		{
			return ImPlotNative.PointPointDouble(x, y);
		}

		public void PointDestroy()
		{
			ImPlotNative.PointDestroy(NativePtr);
		}

		public ImPlotPointPtr PointPointNil()
		{
			return ImPlotNative.PointPointNil();
		}

	}
}
