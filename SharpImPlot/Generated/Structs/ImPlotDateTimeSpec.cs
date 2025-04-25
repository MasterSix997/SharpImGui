using System;
using System.Numerics;
using System.Runtime.InteropServices;
using SharpImGui;

namespace SharpImPlot
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlotDateTimeSpec
	{
		public ImPlotDateFmt Date;
		public ImPlotTimeFmt Time;
		public byte UseIso8601;
		public byte Use24HourClock;
	}

	public unsafe partial struct ImPlotDateTimeSpecPtr
	{
		public ImPlotDateTimeSpec* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlotDateTimeSpec this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImPlotDateTimeSpecPtr(ImPlotDateTimeSpec* nativePtr) => NativePtr = nativePtr;
		public ImPlotDateTimeSpecPtr(IntPtr nativePtr) => NativePtr = (ImPlotDateTimeSpec*)nativePtr;
		public static implicit operator ImPlotDateTimeSpecPtr(ImPlotDateTimeSpec* ptr) => new ImPlotDateTimeSpecPtr(ptr);
		public static implicit operator ImPlotDateTimeSpecPtr(IntPtr ptr) => new ImPlotDateTimeSpecPtr(ptr);
		public static implicit operator ImPlotDateTimeSpec*(ImPlotDateTimeSpecPtr nativePtr) => nativePtr.NativePtr;
	}
}
