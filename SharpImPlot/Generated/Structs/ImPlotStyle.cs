using System;
using System.Numerics;
using System.Runtime.InteropServices;
using SharpImGui;

namespace SharpImPlot
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlotStyle
	{
		public float LineWeight;
		public int Marker;
		public float MarkerSize;
		public float MarkerWeight;
		public float FillAlpha;
		public float ErrorBarSize;
		public float ErrorBarWeight;
		public float DigitalBitHeight;
		public float DigitalBitGap;
		public float PlotBorderSize;
		public float MinorAlpha;
		public Vector2 MajorTickLen;
		public Vector2 MinorTickLen;
		public Vector2 MajorTickSize;
		public Vector2 MinorTickSize;
		public Vector2 MajorGridSize;
		public Vector2 MinorGridSize;
		public Vector2 PlotPadding;
		public Vector2 LabelPadding;
		public Vector2 LegendPadding;
		public Vector2 LegendInnerPadding;
		public Vector2 LegendSpacing;
		public Vector2 MousePosPadding;
		public Vector2 AnnotationPadding;
		public Vector2 FitPadding;
		public Vector2 PlotDefaultSize;
		public Vector2 PlotMinSize;
		public Vector4 Colors_0;
		public Vector4 Colors_1;
		public Vector4 Colors_2;
		public Vector4 Colors_3;
		public Vector4 Colors_4;
		public Vector4 Colors_5;
		public Vector4 Colors_6;
		public Vector4 Colors_7;
		public Vector4 Colors_8;
		public Vector4 Colors_9;
		public Vector4 Colors_10;
		public Vector4 Colors_11;
		public Vector4 Colors_12;
		public Vector4 Colors_13;
		public Vector4 Colors_14;
		public Vector4 Colors_15;
		public Vector4 Colors_16;
		public Vector4 Colors_17;
		public Vector4 Colors_18;
		public Vector4 Colors_19;
		public Vector4 Colors_20;
		public ImPlotColormap Colormap;
		public byte UseLocalTime;
		public byte UseIso8601;
		public byte Use24HourClock;
	}

	public unsafe partial struct ImPlotStylePtr
	{
		public ImPlotStyle* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlotStyle this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImPlotStylePtr(ImPlotStyle* nativePtr) => NativePtr = nativePtr;
		public ImPlotStylePtr(IntPtr nativePtr) => NativePtr = (ImPlotStyle*)nativePtr;
		public static implicit operator ImPlotStylePtr(ImPlotStyle* ptr) => new ImPlotStylePtr(ptr);
		public static implicit operator ImPlotStylePtr(IntPtr ptr) => new ImPlotStylePtr(ptr);
		public static implicit operator ImPlotStyle*(ImPlotStylePtr nativePtr) => nativePtr.NativePtr;
	}
}
