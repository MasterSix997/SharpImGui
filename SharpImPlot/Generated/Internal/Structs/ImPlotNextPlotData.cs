using SharpImGui;
using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImPlot
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlotNextPlotData
	{
		public ImPlotCond RangeCond_0;
		public ImPlotCond RangeCond_1;
		public ImPlotCond RangeCond_2;
		public ImPlotCond RangeCond_3;
		public ImPlotCond RangeCond_4;
		public ImPlotCond RangeCond_5;
		public ImPlotRange Range_0;
		public ImPlotRange Range_1;
		public ImPlotRange Range_2;
		public ImPlotRange Range_3;
		public ImPlotRange Range_4;
		public ImPlotRange Range_5;
		public byte HasRange_0;
		public byte HasRange_1;
		public byte HasRange_2;
		public byte HasRange_3;
		public byte HasRange_4;
		public byte HasRange_5;
		public byte Fit_0;
		public byte Fit_1;
		public byte Fit_2;
		public byte Fit_3;
		public byte Fit_4;
		public byte Fit_5;
		public unsafe double* LinkedMin_0;
		public unsafe double* LinkedMin_1;
		public unsafe double* LinkedMin_2;
		public unsafe double* LinkedMin_3;
		public unsafe double* LinkedMin_4;
		public unsafe double* LinkedMin_5;
		public unsafe double* LinkedMax_0;
		public unsafe double* LinkedMax_1;
		public unsafe double* LinkedMax_2;
		public unsafe double* LinkedMax_3;
		public unsafe double* LinkedMax_4;
		public unsafe double* LinkedMax_5;
	}

	public unsafe partial struct ImPlotNextPlotDataPtr
	{
		public ImPlotNextPlotData* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlotNextPlotData this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public Span<ImPlotCond> RangeCond => new Span<ImPlotCond>(&NativePtr->RangeCond_0, 6);
		public Span<ImPlotRange> Range => new Span<ImPlotRange>(&NativePtr->Range_0, 6);
		public Span<byte> HasRange => new Span<byte>(&NativePtr->HasRange_0, 6);
		public Span<byte> Fit => new Span<byte>(&NativePtr->Fit_0, 6);
		public Span<ImPointer<double>> LinkedMin => new Span<ImPointer<double>>(&NativePtr->LinkedMin_0, 6);
		public Span<ImPointer<double>> LinkedMax => new Span<ImPointer<double>>(&NativePtr->LinkedMax_0, 6);
		public ImPlotNextPlotDataPtr(ImPlotNextPlotData* nativePtr) => NativePtr = nativePtr;
		public ImPlotNextPlotDataPtr(IntPtr nativePtr) => NativePtr = (ImPlotNextPlotData*)nativePtr;
		public static implicit operator ImPlotNextPlotDataPtr(ImPlotNextPlotData* ptr) => new ImPlotNextPlotDataPtr(ptr);
		public static implicit operator ImPlotNextPlotDataPtr(IntPtr ptr) => new ImPlotNextPlotDataPtr(ptr);
		public static implicit operator ImPlotNextPlotData*(ImPlotNextPlotDataPtr nativePtr) => nativePtr.NativePtr;
		public void NextPlotDataReset()
		{
			ImPlotNative.NextPlotDataReset(NativePtr);
		}

		public void NextPlotDataDestroy()
		{
			ImPlotNative.NextPlotDataDestroy(NativePtr);
		}

		public ImPlotNextPlotDataPtr NextPlotDataNextPlotData()
		{
			return ImPlotNative.NextPlotDataNextPlotData();
		}

	}
}
