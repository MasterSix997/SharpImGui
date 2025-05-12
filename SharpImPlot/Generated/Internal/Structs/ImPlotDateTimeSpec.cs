using SharpImGui;
using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

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
		public ref ImPlotDateFmt Date => ref Unsafe.AsRef<ImPlotDateFmt>(&NativePtr->Date);
		public ref ImPlotTimeFmt Time => ref Unsafe.AsRef<ImPlotTimeFmt>(&NativePtr->Time);
		public ref bool UseIso8601 => ref Unsafe.AsRef<bool>(&NativePtr->UseIso8601);
		public ref bool Use24HourClock => ref Unsafe.AsRef<bool>(&NativePtr->Use24HourClock);
		public ImPlotDateTimeSpecPtr(ImPlotDateTimeSpec* nativePtr) => NativePtr = nativePtr;
		public ImPlotDateTimeSpecPtr(IntPtr nativePtr) => NativePtr = (ImPlotDateTimeSpec*)nativePtr;
		public static implicit operator ImPlotDateTimeSpecPtr(ImPlotDateTimeSpec* ptr) => new ImPlotDateTimeSpecPtr(ptr);
		public static implicit operator ImPlotDateTimeSpecPtr(IntPtr ptr) => new ImPlotDateTimeSpecPtr(ptr);
		public static implicit operator ImPlotDateTimeSpec*(ImPlotDateTimeSpecPtr nativePtr) => nativePtr.NativePtr;
		public ImPlotDateTimeSpecPtr DateTimeSpecDateTimeSpecPlotDateFmt(ImPlotDateFmt dateFmt, ImPlotTimeFmt timeFmt, bool use_24HrClk, bool useIso_8601)
		{
			var native_use_24HrClk = use_24HrClk ? (byte)1 : (byte)0;
			var native_useIso_8601 = useIso_8601 ? (byte)1 : (byte)0;
			return ImPlotNative.DateTimeSpecDateTimeSpecPlotDateFmt(dateFmt, timeFmt, native_use_24HrClk, native_useIso_8601);
		}

		public void DateTimeSpecDestroy()
		{
			ImPlotNative.DateTimeSpecDestroy(NativePtr);
		}

		public ImPlotDateTimeSpecPtr DateTimeSpecDateTimeSpecNil()
		{
			return ImPlotNative.DateTimeSpecDateTimeSpecNil();
		}

	}
}
