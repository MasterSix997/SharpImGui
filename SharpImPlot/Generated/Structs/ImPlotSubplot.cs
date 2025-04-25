using System;
using System.Numerics;
using System.Runtime.InteropServices;
using SharpImGui;

namespace SharpImPlot
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlotSubplot
	{
		public uint ID;
		public ImPlotSubplotFlags Flags;
		public ImPlotSubplotFlags PreviousFlags;
		public ImPlotItemGroup Items;
		public int Rows;
		public int Cols;
		public int CurrentIdx;
		public ImRect FrameRect;
		public ImRect GridRect;
		public Vector2 CellSize;
		public ImVector<ImPlotAlignmentData> RowAlignmentData;
		public ImVector<ImPlotAlignmentData> ColAlignmentData;
		public ImVector<float> RowRatios;
		public ImVector<float> ColRatios;
		public ImVector<ImPlotRange> RowLinkData;
		public ImVector<ImPlotRange> ColLinkData;
		public float TempSizes_0;
		public float TempSizes_1;
		public byte FrameHovered;
		public byte HasTitle;
	}

	public unsafe partial struct ImPlotSubplotPtr
	{
		public ImPlotSubplot* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlotSubplot this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImPlotSubplotPtr(ImPlotSubplot* nativePtr) => NativePtr = nativePtr;
		public ImPlotSubplotPtr(IntPtr nativePtr) => NativePtr = (ImPlotSubplot*)nativePtr;
		public static implicit operator ImPlotSubplotPtr(ImPlotSubplot* ptr) => new ImPlotSubplotPtr(ptr);
		public static implicit operator ImPlotSubplotPtr(IntPtr ptr) => new ImPlotSubplotPtr(ptr);
		public static implicit operator ImPlotSubplot*(ImPlotSubplotPtr nativePtr) => nativePtr.NativePtr;
	}
}
