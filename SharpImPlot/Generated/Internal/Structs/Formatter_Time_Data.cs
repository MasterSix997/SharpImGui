using SharpImGui;
using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImPlot
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct FormatterTimeData
	{
		public ImPlotTime Time;
		public ImPlotDateTimeSpec Spec;
		public unsafe void* UserFormatter;
		public unsafe void* UserFormatterData;
	}

	public unsafe partial struct FormatterTimeDataPtr
	{
		public FormatterTimeData* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public FormatterTimeData this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref ImPlotTime Time => ref Unsafe.AsRef<ImPlotTime>(&NativePtr->Time);
		public ref ImPlotDateTimeSpec Spec => ref Unsafe.AsRef<ImPlotDateTimeSpec>(&NativePtr->Spec);
		public IntPtr UserFormatter { get => (IntPtr)NativePtr->UserFormatter; set => NativePtr->UserFormatter = (void*)value; }
		public IntPtr UserFormatterData { get => (IntPtr)NativePtr->UserFormatterData; set => NativePtr->UserFormatterData = (void*)value; }
		public FormatterTimeDataPtr(FormatterTimeData* nativePtr) => NativePtr = nativePtr;
		public FormatterTimeDataPtr(IntPtr nativePtr) => NativePtr = (FormatterTimeData*)nativePtr;
		public static implicit operator FormatterTimeDataPtr(FormatterTimeData* ptr) => new FormatterTimeDataPtr(ptr);
		public static implicit operator FormatterTimeDataPtr(IntPtr ptr) => new FormatterTimeDataPtr(ptr);
		public static implicit operator FormatterTimeData*(FormatterTimeDataPtr nativePtr) => nativePtr.NativePtr;
	}
}
