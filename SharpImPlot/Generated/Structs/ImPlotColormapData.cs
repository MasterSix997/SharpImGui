using System;
using System.Numerics;
using System.Runtime.InteropServices;
using SharpImGui;

namespace SharpImPlot
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlotColormapData
	{
		public ImVector<uint> Keys;
		public ImVector<int> KeyCounts;
		public ImVector<int> KeyOffsets;
		public ImVector<uint> Tables;
		public ImVector<int> TableSizes;
		public ImVector<int> TableOffsets;
		public ImGuiTextBuffer Text;
		public ImVector<int> TextOffsets;
		public ImVector<byte> Quals;
		public ImGuiStorage Map;
		public int Count;
	}

	public unsafe partial struct ImPlotColormapDataPtr
	{
		public ImPlotColormapData* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlotColormapData this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImPlotColormapDataPtr(ImPlotColormapData* nativePtr) => NativePtr = nativePtr;
		public ImPlotColormapDataPtr(IntPtr nativePtr) => NativePtr = (ImPlotColormapData*)nativePtr;
		public static implicit operator ImPlotColormapDataPtr(ImPlotColormapData* ptr) => new ImPlotColormapDataPtr(ptr);
		public static implicit operator ImPlotColormapDataPtr(IntPtr ptr) => new ImPlotColormapDataPtr(ptr);
		public static implicit operator ImPlotColormapData*(ImPlotColormapDataPtr nativePtr) => nativePtr.NativePtr;
	}
}
