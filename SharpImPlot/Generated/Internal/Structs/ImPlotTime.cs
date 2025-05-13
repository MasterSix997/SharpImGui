using SharpImGui;
using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

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
		public ref long S => ref Unsafe.AsRef<long>(&NativePtr->S);
		public ref int Us => ref Unsafe.AsRef<int>(&NativePtr->Us);
		public ImPlotTimePtr(ImPlotTime* nativePtr) => NativePtr = nativePtr;
		public ImPlotTimePtr(IntPtr nativePtr) => NativePtr = (ImPlotTime*)nativePtr;
		public static implicit operator ImPlotTimePtr(ImPlotTime* ptr) => new ImPlotTimePtr(ptr);
		public static implicit operator ImPlotTimePtr(IntPtr ptr) => new ImPlotTimePtr(ptr);
		public static implicit operator ImPlotTime*(ImPlotTimePtr nativePtr) => nativePtr.NativePtr;
		public void TimeFromDouble(ImPlotTimePtr pOut, double t)
		{
			ImPlotNative.TimeFromDouble(pOut, t);
		}

		public double TimeToDouble()
		{
			return ImPlotNative.TimeToDouble(NativePtr);
		}

		public void TimeRollOver()
		{
			ImPlotNative.TimeRollOver(NativePtr);
		}

		public ImPlotTimePtr TimeTimeTimeT(long s, int us)
		{
			return ImPlotNative.TimeTimeTimeT(s, us);
		}

		public void TimeDestroy()
		{
			ImPlotNative.TimeDestroy(NativePtr);
		}

		public ImPlotTimePtr TimeTimeNil()
		{
			return ImPlotNative.TimeTimeNil();
		}

	}
}
