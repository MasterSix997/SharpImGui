using System;
using System.Numerics;
using System.Runtime.InteropServices;
using SharpImGui;

namespace SharpImPlot
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlotInputMap
	{
		public ImGuiMouseButton Pan;
		public int PanMod;
		public ImGuiMouseButton Fit;
		public ImGuiMouseButton Select;
		public ImGuiMouseButton SelectCancel;
		public int SelectMod;
		public int SelectHorzMod;
		public int SelectVertMod;
		public ImGuiMouseButton Menu;
		public int OverrideMod;
		public int ZoomMod;
		public float ZoomRate;
	}

	public unsafe partial struct ImPlotInputMapPtr
	{
		public ImPlotInputMap* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlotInputMap this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImPlotInputMapPtr(ImPlotInputMap* nativePtr) => NativePtr = nativePtr;
		public ImPlotInputMapPtr(IntPtr nativePtr) => NativePtr = (ImPlotInputMap*)nativePtr;
		public static implicit operator ImPlotInputMapPtr(ImPlotInputMap* ptr) => new ImPlotInputMapPtr(ptr);
		public static implicit operator ImPlotInputMapPtr(IntPtr ptr) => new ImPlotInputMapPtr(ptr);
		public static implicit operator ImPlotInputMap*(ImPlotInputMapPtr nativePtr) => nativePtr.NativePtr;
	}
}
