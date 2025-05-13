using SharpImGui;
using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

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
		public ref Vector2 Pos => ref Unsafe.AsRef<Vector2>(&NativePtr->Pos);
		public ref Vector2 Offset => ref Unsafe.AsRef<Vector2>(&NativePtr->Offset);
		public ref uint ColorBg => ref Unsafe.AsRef<uint>(&NativePtr->ColorBg);
		public ref uint ColorFg => ref Unsafe.AsRef<uint>(&NativePtr->ColorFg);
		public ref int TextOffset => ref Unsafe.AsRef<int>(&NativePtr->TextOffset);
		public ref bool Clamp => ref Unsafe.AsRef<bool>(&NativePtr->Clamp);
		public ImPlotAnnotationPtr(ImPlotAnnotation* nativePtr) => NativePtr = nativePtr;
		public ImPlotAnnotationPtr(IntPtr nativePtr) => NativePtr = (ImPlotAnnotation*)nativePtr;
		public static implicit operator ImPlotAnnotationPtr(ImPlotAnnotation* ptr) => new ImPlotAnnotationPtr(ptr);
		public static implicit operator ImPlotAnnotationPtr(IntPtr ptr) => new ImPlotAnnotationPtr(ptr);
		public static implicit operator ImPlotAnnotation*(ImPlotAnnotationPtr nativePtr) => nativePtr.NativePtr;
		public void AnnotationDestroy()
		{
			ImPlotNative.AnnotationDestroy(NativePtr);
		}

		public ImPlotAnnotationPtr AnnotationAnnotation()
		{
			return ImPlotNative.AnnotationAnnotation();
		}

	}
}
