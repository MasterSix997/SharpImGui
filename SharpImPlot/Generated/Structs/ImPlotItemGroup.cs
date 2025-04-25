using System;
using System.Numerics;
using System.Runtime.InteropServices;
using SharpImGui;

namespace SharpImPlot
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlotItemGroup
	{
		public uint ID;
		public ImPlotLegend Legend;
		public ImPool<ImPlotItem> ItemPool;
		public int ColormapIdx;
	}

	public unsafe partial struct ImPlotItemGroupPtr
	{
		public ImPlotItemGroup* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlotItemGroup this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImPlotItemGroupPtr(ImPlotItemGroup* nativePtr) => NativePtr = nativePtr;
		public ImPlotItemGroupPtr(IntPtr nativePtr) => NativePtr = (ImPlotItemGroup*)nativePtr;
		public static implicit operator ImPlotItemGroupPtr(ImPlotItemGroup* ptr) => new ImPlotItemGroupPtr(ptr);
		public static implicit operator ImPlotItemGroupPtr(IntPtr ptr) => new ImPlotItemGroupPtr(ptr);
		public static implicit operator ImPlotItemGroup*(ImPlotItemGroupPtr nativePtr) => nativePtr.NativePtr;
	}
}
