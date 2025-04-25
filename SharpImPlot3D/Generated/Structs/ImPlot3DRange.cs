using System;
using System.Numerics;
using System.Runtime.InteropServices;
using SharpImGui;

namespace SharpImPlot3D
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlot3DRange
	{
		public float Min;
		public float Max;
	}

	public unsafe partial struct ImPlot3DRangePtr
	{
		public ImPlot3DRange* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlot3DRange this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImPlot3DRangePtr(ImPlot3DRange* nativePtr) => NativePtr = nativePtr;
		public ImPlot3DRangePtr(IntPtr nativePtr) => NativePtr = (ImPlot3DRange*)nativePtr;
		public static implicit operator ImPlot3DRangePtr(ImPlot3DRange* ptr) => new ImPlot3DRangePtr(ptr);
		public static implicit operator ImPlot3DRangePtr(IntPtr ptr) => new ImPlot3DRangePtr(ptr);
		public static implicit operator ImPlot3DRange*(ImPlot3DRangePtr nativePtr) => nativePtr.NativePtr;
	}
}
