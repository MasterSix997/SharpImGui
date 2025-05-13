using SharpImGui;
using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImPlot
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlotTag
	{
		public ImAxis Axis;
		public double Value;
		public uint ColorBg;
		public uint ColorFg;
		public int TextOffset;
	}

	public unsafe partial struct ImPlotTagPtr
	{
		public ImPlotTag* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlotTag this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref ImAxis Axis => ref Unsafe.AsRef<ImAxis>(&NativePtr->Axis);
		public ref double Value => ref Unsafe.AsRef<double>(&NativePtr->Value);
		public ref uint ColorBg => ref Unsafe.AsRef<uint>(&NativePtr->ColorBg);
		public ref uint ColorFg => ref Unsafe.AsRef<uint>(&NativePtr->ColorFg);
		public ref int TextOffset => ref Unsafe.AsRef<int>(&NativePtr->TextOffset);
		public ImPlotTagPtr(ImPlotTag* nativePtr) => NativePtr = nativePtr;
		public ImPlotTagPtr(IntPtr nativePtr) => NativePtr = (ImPlotTag*)nativePtr;
		public static implicit operator ImPlotTagPtr(ImPlotTag* ptr) => new ImPlotTagPtr(ptr);
		public static implicit operator ImPlotTagPtr(IntPtr ptr) => new ImPlotTagPtr(ptr);
		public static implicit operator ImPlotTag*(ImPlotTagPtr nativePtr) => nativePtr.NativePtr;
	}
}
