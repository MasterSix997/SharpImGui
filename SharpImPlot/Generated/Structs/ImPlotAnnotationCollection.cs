using System;
using System.Numerics;
using System.Runtime.InteropServices;
using SharpImGui;

namespace SharpImPlot
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlotAnnotationCollection
	{
		public ImVector<ImPlotAnnotation> Annotations;
		public ImGuiTextBuffer TextBuffer;
		public int Size;
	}

	public unsafe partial struct ImPlotAnnotationCollectionPtr
	{
		public ImPlotAnnotationCollection* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlotAnnotationCollection this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImPlotAnnotationCollectionPtr(ImPlotAnnotationCollection* nativePtr) => NativePtr = nativePtr;
		public ImPlotAnnotationCollectionPtr(IntPtr nativePtr) => NativePtr = (ImPlotAnnotationCollection*)nativePtr;
		public static implicit operator ImPlotAnnotationCollectionPtr(ImPlotAnnotationCollection* ptr) => new ImPlotAnnotationCollectionPtr(ptr);
		public static implicit operator ImPlotAnnotationCollectionPtr(IntPtr ptr) => new ImPlotAnnotationCollectionPtr(ptr);
		public static implicit operator ImPlotAnnotationCollection*(ImPlotAnnotationCollectionPtr nativePtr) => nativePtr.NativePtr;
	}
}
