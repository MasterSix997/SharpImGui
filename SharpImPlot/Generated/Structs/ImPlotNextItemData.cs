using System;
using System.Numerics;
using System.Runtime.InteropServices;
using SharpImGui;

namespace SharpImPlot
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlotNextItemData
	{
		public Vector4 Colors_0;
		public Vector4 Colors_1;
		public Vector4 Colors_2;
		public Vector4 Colors_3;
		public Vector4 Colors_4;
		public float LineWeight;
		public ImPlotMarker Marker;
		public float MarkerSize;
		public float MarkerWeight;
		public float FillAlpha;
		public float ErrorBarSize;
		public float ErrorBarWeight;
		public float DigitalBitHeight;
		public float DigitalBitGap;
		public byte RenderLine;
		public byte RenderFill;
		public byte RenderMarkerLine;
		public byte RenderMarkerFill;
		public byte HasHidden;
		public byte Hidden;
		public ImPlotCond HiddenCond;
	}

	public unsafe partial struct ImPlotNextItemDataPtr
	{
		public ImPlotNextItemData* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlotNextItemData this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImPlotNextItemDataPtr(ImPlotNextItemData* nativePtr) => NativePtr = nativePtr;
		public ImPlotNextItemDataPtr(IntPtr nativePtr) => NativePtr = (ImPlotNextItemData*)nativePtr;
		public static implicit operator ImPlotNextItemDataPtr(ImPlotNextItemData* ptr) => new ImPlotNextItemDataPtr(ptr);
		public static implicit operator ImPlotNextItemDataPtr(IntPtr ptr) => new ImPlotNextItemDataPtr(ptr);
		public static implicit operator ImPlotNextItemData*(ImPlotNextItemDataPtr nativePtr) => nativePtr.NativePtr;
	}
}
