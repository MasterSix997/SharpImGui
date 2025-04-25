using System;
using System.Numerics;
using System.Runtime.InteropServices;
using SharpImGui;

namespace SharpImPlot
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlotTagCollection
	{
		public ImVector<ImPlotTag> Tags;
		public ImGuiTextBuffer TextBuffer;
		public int Size;
	}

	public unsafe partial struct ImPlotTagCollectionPtr
	{
		public ImPlotTagCollection* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlotTagCollection this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImPlotTagCollectionPtr(ImPlotTagCollection* nativePtr) => NativePtr = nativePtr;
		public ImPlotTagCollectionPtr(IntPtr nativePtr) => NativePtr = (ImPlotTagCollection*)nativePtr;
		public static implicit operator ImPlotTagCollectionPtr(ImPlotTagCollection* ptr) => new ImPlotTagCollectionPtr(ptr);
		public static implicit operator ImPlotTagCollectionPtr(IntPtr ptr) => new ImPlotTagCollectionPtr(ptr);
		public static implicit operator ImPlotTagCollection*(ImPlotTagCollectionPtr nativePtr) => nativePtr.NativePtr;
	}
}
