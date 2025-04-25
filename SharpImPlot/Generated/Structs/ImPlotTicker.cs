using System;
using System.Numerics;
using System.Runtime.InteropServices;
using SharpImGui;

namespace SharpImPlot
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlotTicker
	{
		public ImVector<ImPlotTick> Ticks;
		public ImGuiTextBuffer TextBuffer;
		public Vector2 MaxSize;
		public Vector2 LateSize;
		public int Levels;
	}

	public unsafe partial struct ImPlotTickerPtr
	{
		public ImPlotTicker* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlotTicker this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImPlotTickerPtr(ImPlotTicker* nativePtr) => NativePtr = nativePtr;
		public ImPlotTickerPtr(IntPtr nativePtr) => NativePtr = (ImPlotTicker*)nativePtr;
		public static implicit operator ImPlotTickerPtr(ImPlotTicker* ptr) => new ImPlotTickerPtr(ptr);
		public static implicit operator ImPlotTickerPtr(IntPtr ptr) => new ImPlotTickerPtr(ptr);
		public static implicit operator ImPlotTicker*(ImPlotTickerPtr nativePtr) => nativePtr.NativePtr;
	}
}
