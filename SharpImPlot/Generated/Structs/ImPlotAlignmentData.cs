using System;
using System.Numerics;
using System.Runtime.InteropServices;
using SharpImGui;

namespace SharpImPlot
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlotAlignmentData
	{
		public byte Vertical;
		public float PadA;
		public float PadB;
		public float PadAMax;
		public float PadBMax;
	}

	public unsafe partial struct ImPlotAlignmentDataPtr
	{
		public ImPlotAlignmentData* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlotAlignmentData this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImPlotAlignmentDataPtr(ImPlotAlignmentData* nativePtr) => NativePtr = nativePtr;
		public ImPlotAlignmentDataPtr(IntPtr nativePtr) => NativePtr = (ImPlotAlignmentData*)nativePtr;
		public static implicit operator ImPlotAlignmentDataPtr(ImPlotAlignmentData* ptr) => new ImPlotAlignmentDataPtr(ptr);
		public static implicit operator ImPlotAlignmentDataPtr(IntPtr ptr) => new ImPlotAlignmentDataPtr(ptr);
		public static implicit operator ImPlotAlignmentData*(ImPlotAlignmentDataPtr nativePtr) => nativePtr.NativePtr;
	}
}
