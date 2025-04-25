using System;
using System.Numerics;
using System.Runtime.InteropServices;
using SharpImGui;

namespace SharpImPlot
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlotTick
	{
		public double PlotPos;
		public float PixelPos;
		public Vector2 LabelSize;
		public int TextOffset;
		public byte Major;
		public byte ShowLabel;
		public int Level;
		public int Idx;
	}

	public unsafe partial struct ImPlotTickPtr
	{
		public ImPlotTick* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlotTick this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImPlotTickPtr(ImPlotTick* nativePtr) => NativePtr = nativePtr;
		public ImPlotTickPtr(IntPtr nativePtr) => NativePtr = (ImPlotTick*)nativePtr;
		public static implicit operator ImPlotTickPtr(ImPlotTick* ptr) => new ImPlotTickPtr(ptr);
		public static implicit operator ImPlotTickPtr(IntPtr ptr) => new ImPlotTickPtr(ptr);
		public static implicit operator ImPlotTick*(ImPlotTickPtr nativePtr) => nativePtr.NativePtr;
	}
}
