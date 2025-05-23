using SharpImGui;
using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImPlot3D
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlot3DRay
	{
		public ImPlot3DPoint Origin;
		public ImPlot3DPoint Direction;
	}

	public unsafe partial struct ImPlot3DRayPtr
	{
		public ImPlot3DRay* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlot3DRay this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref ImPlot3DPoint Origin => ref Unsafe.AsRef<ImPlot3DPoint>(&NativePtr->Origin);
		public ref ImPlot3DPoint Direction => ref Unsafe.AsRef<ImPlot3DPoint>(&NativePtr->Direction);
		public ImPlot3DRayPtr(ImPlot3DRay* nativePtr) => NativePtr = nativePtr;
		public ImPlot3DRayPtr(IntPtr nativePtr) => NativePtr = (ImPlot3DRay*)nativePtr;
		public static implicit operator ImPlot3DRayPtr(ImPlot3DRay* ptr) => new ImPlot3DRayPtr(ptr);
		public static implicit operator ImPlot3DRayPtr(IntPtr ptr) => new ImPlot3DRayPtr(ptr);
		public static implicit operator ImPlot3DRay*(ImPlot3DRayPtr nativePtr) => nativePtr.NativePtr;
	}
}
