using SharpImGui;
using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

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
		public ref double Min => ref Unsafe.AsRef<double>(&NativePtr->Min);
		public ref double Max => ref Unsafe.AsRef<double>(&NativePtr->Max);
		public ImPlotRangePtr(ImPlotRange* nativePtr) => NativePtr = nativePtr;
		public ImPlotRangePtr(IntPtr nativePtr) => NativePtr = (ImPlotRange*)nativePtr;
		public static implicit operator ImPlotRangePtr(ImPlotRange* ptr) => new ImPlotRangePtr(ptr);
		public static implicit operator ImPlotRangePtr(IntPtr ptr) => new ImPlotRangePtr(ptr);
		public static implicit operator ImPlotRange*(ImPlotRangePtr nativePtr) => nativePtr.NativePtr;
		public double RangeClamp(double value)
		{
			return ImPlotNative.RangeClamp(NativePtr, value);
		}

		public double RangeSize()
		{
			return ImPlotNative.RangeSize(NativePtr);
		}

		public byte RangeContains(double value)
		{
			return ImPlotNative.RangeContains(NativePtr, value);
		}

		public ImPlotRangePtr RangeRangeDouble(double min, double max)
		{
			return ImPlotNative.RangeRangeDouble(min, max);
		}

		public void RangeDestroy()
		{
			ImPlotNative.RangeDestroy(NativePtr);
		}

		public ImPlotRangePtr RangeRangeNil()
		{
			return ImPlotNative.RangeRangeNil();
		}

	}
}
