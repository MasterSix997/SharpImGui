using System;
using System.Numerics;
using System.Runtime.InteropServices;
using SharpImGui;

namespace SharpImPlot
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlotAxis
	{
		public uint ID;
		public ImPlotAxisFlags Flags;
		public ImPlotAxisFlags PreviousFlags;
		public ImPlotRange Range;
		public ImPlotCond RangeCond;
		public ImPlotScale Scale;
		public ImPlotRange FitExtents;
		public unsafe ImPlotAxis* OrthoAxis;
		public ImPlotRange ConstraintRange;
		public ImPlotRange ConstraintZoom;
		public ImPlotTicker Ticker;
		public IntPtr Formatter;
		public unsafe void* FormatterData;
		public byte FormatSpec_0;
		public byte FormatSpec_1;
		public byte FormatSpec_2;
		public byte FormatSpec_3;
		public byte FormatSpec_4;
		public byte FormatSpec_5;
		public byte FormatSpec_6;
		public byte FormatSpec_7;
		public byte FormatSpec_8;
		public byte FormatSpec_9;
		public byte FormatSpec_10;
		public byte FormatSpec_11;
		public byte FormatSpec_12;
		public byte FormatSpec_13;
		public byte FormatSpec_14;
		public byte FormatSpec_15;
		public unsafe void* Locator;
		public unsafe double* LinkedMin;
		public unsafe double* LinkedMax;
		public int PickerLevel;
		public ImPlotTime PickerTimeMin;
		public ImPlotTime PickerTimeMax;
		public IntPtr TransformForward;
		public IntPtr TransformInverse;
		public unsafe void* TransformData;
		public float PixelMin;
		public float PixelMax;
		public double ScaleMin;
		public double ScaleMax;
		public double ScaleToPixel;
		public float Datum1;
		public float Datum2;
		public ImRect HoverRect;
		public int LabelOffset;
		public uint ColorMaj;
		public uint ColorMin;
		public uint ColorTick;
		public uint ColorTxt;
		public uint ColorBg;
		public uint ColorHov;
		public uint ColorAct;
		public uint ColorHiLi;
		public byte Enabled;
		public byte Vertical;
		public byte FitThisFrame;
		public byte HasRange;
		public byte HasFormatSpec;
		public byte ShowDefaultTicks;
		public byte Hovered;
		public byte Held;
	}

	public unsafe partial struct ImPlotAxisPtr
	{
		public ImPlotAxis* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlotAxis this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImPlotAxisPtr(ImPlotAxis* nativePtr) => NativePtr = nativePtr;
		public ImPlotAxisPtr(IntPtr nativePtr) => NativePtr = (ImPlotAxis*)nativePtr;
		public static implicit operator ImPlotAxisPtr(ImPlotAxis* ptr) => new ImPlotAxisPtr(ptr);
		public static implicit operator ImPlotAxisPtr(IntPtr ptr) => new ImPlotAxisPtr(ptr);
		public static implicit operator ImPlotAxis*(ImPlotAxisPtr nativePtr) => nativePtr.NativePtr;
	}
}
