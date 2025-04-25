using System;
using System.Numerics;
using System.Runtime.InteropServices;
using SharpImGui;

namespace SharpImPlot
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlotContext
	{
		public ImPool<ImPlotPlot> Plots;
		public ImPool<ImPlotSubplot> Subplots;
		public unsafe ImPlotPlot* CurrentPlot;
		public unsafe ImPlotSubplot* CurrentSubplot;
		public unsafe ImPlotItemGroup* CurrentItems;
		public unsafe ImPlotItem* CurrentItem;
		public unsafe ImPlotItem* PreviousItem;
		public ImPlotTicker CTicker;
		public ImPlotAnnotationCollection Annotations;
		public ImPlotTagCollection Tags;
		public ImPlotStyle Style;
		public ImVector<ImGuiColorMod> ColorModifiers;
		public ImVector<ImGuiStyleMod> StyleModifiers;
		public ImPlotColormapData ColormapData;
		public ImVector<ImPlotColormap> ColormapModifiers;
		public Tm Tm;
		public ImVector<double> TempDouble1;
		public ImVector<double> TempDouble2;
		public ImVector<int> TempInt1;
		public int DigitalPlotItemCnt;
		public int DigitalPlotOffset;
		public ImPlotNextPlotData NextPlotData;
		public ImPlotNextItemData NextItemData;
		public ImPlotInputMap InputMap;
		public byte OpenContextThisFrame;
		public ImGuiTextBuffer MousePosStringBuilder;
		public unsafe ImPlotItemGroup* SortItems;
		public ImPool<ImPlotAlignmentData> AlignmentData;
		public unsafe ImPlotAlignmentData* CurrentAlignmentH;
		public unsafe ImPlotAlignmentData* CurrentAlignmentV;
	}

	public unsafe partial struct ImPlotContextPtr
	{
		public ImPlotContext* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlotContext this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImPlotContextPtr(ImPlotContext* nativePtr) => NativePtr = nativePtr;
		public ImPlotContextPtr(IntPtr nativePtr) => NativePtr = (ImPlotContext*)nativePtr;
		public static implicit operator ImPlotContextPtr(ImPlotContext* ptr) => new ImPlotContextPtr(ptr);
		public static implicit operator ImPlotContextPtr(IntPtr ptr) => new ImPlotContextPtr(ptr);
		public static implicit operator ImPlotContext*(ImPlotContextPtr nativePtr) => nativePtr.NativePtr;
	}
}
