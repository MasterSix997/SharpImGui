using System;
using System.Numerics;
using System.Runtime.InteropServices;
using SharpImGui;

namespace SharpImPlot
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlotAnnotation
	{
		public Vector2 Pos;
		public Vector2 Offset;
		public uint ColorBg;
		public uint ColorFg;
		public int TextOffset;
		public byte Clamp;
	}

	public unsafe partial struct ImPlotAnnotationPtr
	{
		public ImPlotAnnotation* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlotAnnotation this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImPlotAnnotationPtr(ImPlotAnnotation* nativePtr) => NativePtr = nativePtr;
		public ImPlotAnnotationPtr(IntPtr nativePtr) => NativePtr = (ImPlotAnnotation*)nativePtr;
		public static implicit operator ImPlotAnnotationPtr(ImPlotAnnotation* ptr) => new ImPlotAnnotationPtr(ptr);
		public static implicit operator ImPlotAnnotationPtr(IntPtr ptr) => new ImPlotAnnotationPtr(ptr);
		public static implicit operator ImPlotAnnotation*(ImPlotAnnotationPtr nativePtr) => nativePtr.NativePtr;
	}
}
