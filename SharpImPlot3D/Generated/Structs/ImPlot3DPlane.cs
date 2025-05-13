using SharpImGui;
using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImPlot3D
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlot3DPlane
	{
		public ImPlot3DPoint Point;
		public ImPlot3DPoint Normal;
	}

	public unsafe partial struct ImPlot3DPlanePtr
	{
		public ImPlot3DPlane* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlot3DPlane this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref ImPlot3DPoint Point => ref Unsafe.AsRef<ImPlot3DPoint>(&NativePtr->Point);
		public ref ImPlot3DPoint Normal => ref Unsafe.AsRef<ImPlot3DPoint>(&NativePtr->Normal);
		public ImPlot3DPlanePtr(ImPlot3DPlane* nativePtr) => NativePtr = nativePtr;
		public ImPlot3DPlanePtr(IntPtr nativePtr) => NativePtr = (ImPlot3DPlane*)nativePtr;
		public static implicit operator ImPlot3DPlanePtr(ImPlot3DPlane* ptr) => new ImPlot3DPlanePtr(ptr);
		public static implicit operator ImPlot3DPlanePtr(IntPtr ptr) => new ImPlot3DPlanePtr(ptr);
		public static implicit operator ImPlot3DPlane*(ImPlot3DPlanePtr nativePtr) => nativePtr.NativePtr;
	}
}
