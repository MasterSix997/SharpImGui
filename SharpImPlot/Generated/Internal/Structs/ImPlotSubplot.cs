using SharpImGui;
using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

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
		public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);
		public ref ImPlotSubplotFlags Flags => ref Unsafe.AsRef<ImPlotSubplotFlags>(&NativePtr->Flags);
		public ref ImPlotSubplotFlags PreviousFlags => ref Unsafe.AsRef<ImPlotSubplotFlags>(&NativePtr->PreviousFlags);
		public ref ImPlotItemGroup Items => ref Unsafe.AsRef<ImPlotItemGroup>(&NativePtr->Items);
		public ref int Rows => ref Unsafe.AsRef<int>(&NativePtr->Rows);
		public ref int Cols => ref Unsafe.AsRef<int>(&NativePtr->Cols);
		public ref int CurrentIdx => ref Unsafe.AsRef<int>(&NativePtr->CurrentIdx);
		public ref ImRect FrameRect => ref Unsafe.AsRef<ImRect>(&NativePtr->FrameRect);
		public ref ImRect GridRect => ref Unsafe.AsRef<ImRect>(&NativePtr->GridRect);
		public ref Vector2 CellSize => ref Unsafe.AsRef<Vector2>(&NativePtr->CellSize);
		public ref ImVector<ImPlotAlignmentData> RowAlignmentData => ref Unsafe.AsRef<ImVector<ImPlotAlignmentData>>(&NativePtr->RowAlignmentData);
		public ref ImVector<ImPlotAlignmentData> ColAlignmentData => ref Unsafe.AsRef<ImVector<ImPlotAlignmentData>>(&NativePtr->ColAlignmentData);
		public ref ImVector<float> RowRatios => ref Unsafe.AsRef<ImVector<float>>(&NativePtr->RowRatios);
		public ref ImVector<float> ColRatios => ref Unsafe.AsRef<ImVector<float>>(&NativePtr->ColRatios);
		public ref ImVector<ImPlotRange> RowLinkData => ref Unsafe.AsRef<ImVector<ImPlotRange>>(&NativePtr->RowLinkData);
		public ref ImVector<ImPlotRange> ColLinkData => ref Unsafe.AsRef<ImVector<ImPlotRange>>(&NativePtr->ColLinkData);
		public Span<float> TempSizes => new Span<float>(&NativePtr->TempSizes_0, 2);
		public ref bool FrameHovered => ref Unsafe.AsRef<bool>(&NativePtr->FrameHovered);
		public ref bool HasTitle => ref Unsafe.AsRef<bool>(&NativePtr->HasTitle);
		public ImPlotSubplotPtr(ImPlotSubplot* nativePtr) => NativePtr = nativePtr;
		public ImPlotSubplotPtr(IntPtr nativePtr) => NativePtr = (ImPlotSubplot*)nativePtr;
		public static implicit operator ImPlotSubplotPtr(ImPlotSubplot* ptr) => new ImPlotSubplotPtr(ptr);
		public static implicit operator ImPlotSubplotPtr(IntPtr ptr) => new ImPlotSubplotPtr(ptr);
		public static implicit operator ImPlotSubplot*(ImPlotSubplotPtr nativePtr) => nativePtr.NativePtr;
		public void SubplotDestroy()
		{
			ImPlotNative.SubplotDestroy(NativePtr);
		}

		public ImPlotSubplotPtr SubplotSubplot()
		{
			return ImPlotNative.SubplotSubplot();
		}

	}
}
