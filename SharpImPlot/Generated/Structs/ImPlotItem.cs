using System;
using System.Numerics;
using System.Runtime.InteropServices;
using SharpImGui;

namespace SharpImPlot
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlotItem
	{
		public uint ID;
		public uint Color;
		public ImRect LegendHoverRect;
		public int NameOffset;
		public byte Show;
		public byte LegendHovered;
		public byte SeenThisFrame;
	}

	public unsafe partial struct ImPlotItemPtr
	{
		public ImPlotItem* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlotItem this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImPlotItemPtr(ImPlotItem* nativePtr) => NativePtr = nativePtr;
		public ImPlotItemPtr(IntPtr nativePtr) => NativePtr = (ImPlotItem*)nativePtr;
		public static implicit operator ImPlotItemPtr(ImPlotItem* ptr) => new ImPlotItemPtr(ptr);
		public static implicit operator ImPlotItemPtr(IntPtr ptr) => new ImPlotItemPtr(ptr);
		public static implicit operator ImPlotItem*(ImPlotItemPtr nativePtr) => nativePtr.NativePtr;
	}
}
