using System;
using System.Numerics;
using System.Runtime.InteropServices;
using SharpImGui;

namespace SharpImPlot
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlotPlot
	{
		public uint ID;
		public ImPlotFlags Flags;
		public ImPlotFlags PreviousFlags;
		public ImPlotLocation MouseTextLocation;
		public ImPlotMouseTextFlags MouseTextFlags;
		public ImPlotAxis Axes_0;
		public ImPlotAxis Axes_1;
		public ImPlotAxis Axes_2;
		public ImPlotAxis Axes_3;
		public ImPlotAxis Axes_4;
		public ImPlotAxis Axes_5;
		public ImGuiTextBuffer TextBuffer;
		public ImPlotItemGroup Items;
		public ImAxis CurrentX;
		public ImAxis CurrentY;
		public ImRect FrameRect;
		public ImRect CanvasRect;
		public ImRect PlotRect;
		public ImRect AxesRect;
		public ImRect SelectRect;
		public Vector2 SelectStart;
		public int TitleOffset;
		public byte JustCreated;
		public byte Initialized;
		public byte SetupLocked;
		public byte FitThisFrame;
		public byte Hovered;
		public byte Held;
		public byte Selecting;
		public byte Selected;
		public byte ContextLocked;
	}

	public unsafe partial struct ImPlotPlotPtr
	{
		public ImPlotPlot* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlotPlot this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImPlotPlotPtr(ImPlotPlot* nativePtr) => NativePtr = nativePtr;
		public ImPlotPlotPtr(IntPtr nativePtr) => NativePtr = (ImPlotPlot*)nativePtr;
		public static implicit operator ImPlotPlotPtr(ImPlotPlot* ptr) => new ImPlotPlotPtr(ptr);
		public static implicit operator ImPlotPlotPtr(IntPtr ptr) => new ImPlotPlotPtr(ptr);
		public static implicit operator ImPlotPlot*(ImPlotPlotPtr nativePtr) => nativePtr.NativePtr;
	}
}
