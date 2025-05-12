using SharpImGui;
using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

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
		public ref ImPool<ImPlotPlot> Plots => ref Unsafe.AsRef<ImPool<ImPlotPlot>>(&NativePtr->Plots);
		public ref ImPool<ImPlotSubplot> Subplots => ref Unsafe.AsRef<ImPool<ImPlotSubplot>>(&NativePtr->Subplots);
		public ref ImPlotPlotPtr CurrentPlot => ref Unsafe.AsRef<ImPlotPlotPtr>(&NativePtr->CurrentPlot);
		public ref ImPlotSubplotPtr CurrentSubplot => ref Unsafe.AsRef<ImPlotSubplotPtr>(&NativePtr->CurrentSubplot);
		public ref ImPlotItemGroupPtr CurrentItems => ref Unsafe.AsRef<ImPlotItemGroupPtr>(&NativePtr->CurrentItems);
		public ref ImPlotItemPtr CurrentItem => ref Unsafe.AsRef<ImPlotItemPtr>(&NativePtr->CurrentItem);
		public ref ImPlotItemPtr PreviousItem => ref Unsafe.AsRef<ImPlotItemPtr>(&NativePtr->PreviousItem);
		public ref ImPlotTicker CTicker => ref Unsafe.AsRef<ImPlotTicker>(&NativePtr->CTicker);
		public ref ImPlotAnnotationCollection Annotations => ref Unsafe.AsRef<ImPlotAnnotationCollection>(&NativePtr->Annotations);
		public ref ImPlotTagCollection Tags => ref Unsafe.AsRef<ImPlotTagCollection>(&NativePtr->Tags);
		public ref ImPlotStyle Style => ref Unsafe.AsRef<ImPlotStyle>(&NativePtr->Style);
		public ref ImVector<ImGuiColorMod> ColorModifiers => ref Unsafe.AsRef<ImVector<ImGuiColorMod>>(&NativePtr->ColorModifiers);
		public ref ImVector<ImGuiStyleMod> StyleModifiers => ref Unsafe.AsRef<ImVector<ImGuiStyleMod>>(&NativePtr->StyleModifiers);
		public ref ImPlotColormapData ColormapData => ref Unsafe.AsRef<ImPlotColormapData>(&NativePtr->ColormapData);
		public ref ImVector<ImPlotColormap> ColormapModifiers => ref Unsafe.AsRef<ImVector<ImPlotColormap>>(&NativePtr->ColormapModifiers);
		public ref Tm Tm => ref Unsafe.AsRef<Tm>(&NativePtr->Tm);
		public ref ImVector<double> TempDouble1 => ref Unsafe.AsRef<ImVector<double>>(&NativePtr->TempDouble1);
		public ref ImVector<double> TempDouble2 => ref Unsafe.AsRef<ImVector<double>>(&NativePtr->TempDouble2);
		public ref ImVector<int> TempInt1 => ref Unsafe.AsRef<ImVector<int>>(&NativePtr->TempInt1);
		public ref int DigitalPlotItemCnt => ref Unsafe.AsRef<int>(&NativePtr->DigitalPlotItemCnt);
		public ref int DigitalPlotOffset => ref Unsafe.AsRef<int>(&NativePtr->DigitalPlotOffset);
		public ref ImPlotNextPlotData NextPlotData => ref Unsafe.AsRef<ImPlotNextPlotData>(&NativePtr->NextPlotData);
		public ref ImPlotNextItemData NextItemData => ref Unsafe.AsRef<ImPlotNextItemData>(&NativePtr->NextItemData);
		public ref ImPlotInputMap InputMap => ref Unsafe.AsRef<ImPlotInputMap>(&NativePtr->InputMap);
		public ref bool OpenContextThisFrame => ref Unsafe.AsRef<bool>(&NativePtr->OpenContextThisFrame);
		public ref ImGuiTextBuffer MousePosStringBuilder => ref Unsafe.AsRef<ImGuiTextBuffer>(&NativePtr->MousePosStringBuilder);
		public ref ImPlotItemGroupPtr SortItems => ref Unsafe.AsRef<ImPlotItemGroupPtr>(&NativePtr->SortItems);
		public ref ImPool<ImPlotAlignmentData> AlignmentData => ref Unsafe.AsRef<ImPool<ImPlotAlignmentData>>(&NativePtr->AlignmentData);
		public ref ImPlotAlignmentDataPtr CurrentAlignmentH => ref Unsafe.AsRef<ImPlotAlignmentDataPtr>(&NativePtr->CurrentAlignmentH);
		public ref ImPlotAlignmentDataPtr CurrentAlignmentV => ref Unsafe.AsRef<ImPlotAlignmentDataPtr>(&NativePtr->CurrentAlignmentV);
		public ImPlotContextPtr(ImPlotContext* nativePtr) => NativePtr = nativePtr;
		public ImPlotContextPtr(IntPtr nativePtr) => NativePtr = (ImPlotContext*)nativePtr;
		public static implicit operator ImPlotContextPtr(ImPlotContext* ptr) => new ImPlotContextPtr(ptr);
		public static implicit operator ImPlotContextPtr(IntPtr ptr) => new ImPlotContextPtr(ptr);
		public static implicit operator ImPlotContext*(ImPlotContextPtr nativePtr) => nativePtr.NativePtr;
	}
}
