using System;
using System.Numerics;
using System.Runtime.InteropServices;
using SharpImGui;

namespace SharpImPlot
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct FormatterTimeData
	{
		public ImPlotTime Time;
		public ImPlotDateTimeSpec Spec;
		public IntPtr UserFormatter;
		public unsafe void* UserFormatterData;
	}

	public unsafe partial struct FormatterTimeDataPtr
	{
		public FormatterTimeData* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public FormatterTimeData this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public FormatterTimeDataPtr(FormatterTimeData* nativePtr) => NativePtr = nativePtr;
		public FormatterTimeDataPtr(IntPtr nativePtr) => NativePtr = (FormatterTimeData*)nativePtr;
		public static implicit operator FormatterTimeDataPtr(FormatterTimeData* ptr) => new FormatterTimeDataPtr(ptr);
		public static implicit operator FormatterTimeDataPtr(IntPtr ptr) => new FormatterTimeDataPtr(ptr);
		public static implicit operator FormatterTimeData*(FormatterTimeDataPtr nativePtr) => nativePtr.NativePtr;
	}
}
