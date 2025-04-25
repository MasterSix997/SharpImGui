using System;
using System.Numerics;
using System.Runtime.InteropServices;
using SharpImGui;

namespace SharpImPlot
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlotLegend
	{
		public ImPlotLegendFlags Flags;
		public ImPlotLegendFlags PreviousFlags;
		public ImPlotLocation Location;
		public ImPlotLocation PreviousLocation;
		public Vector2 Scroll;
		public ImVector<int> Indices;
		public ImGuiTextBuffer Labels;
		public ImRect Rect;
		public ImRect RectClamped;
		public byte Hovered;
		public byte Held;
		public byte CanGoInside;
	}

	public unsafe partial struct ImPlotLegendPtr
	{
		public ImPlotLegend* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlotLegend this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImPlotLegendPtr(ImPlotLegend* nativePtr) => NativePtr = nativePtr;
		public ImPlotLegendPtr(IntPtr nativePtr) => NativePtr = (ImPlotLegend*)nativePtr;
		public static implicit operator ImPlotLegendPtr(ImPlotLegend* ptr) => new ImPlotLegendPtr(ptr);
		public static implicit operator ImPlotLegendPtr(IntPtr ptr) => new ImPlotLegendPtr(ptr);
		public static implicit operator ImPlotLegend*(ImPlotLegendPtr nativePtr) => nativePtr.NativePtr;
	}
}
