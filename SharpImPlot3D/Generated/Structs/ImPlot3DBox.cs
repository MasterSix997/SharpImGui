using SharpImGui;
using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImPlot3D
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlot3DBox
	{
		public ImPlot3DPoint Min;
		public ImPlot3DPoint Max;
	}

	public unsafe partial struct ImPlot3DBoxPtr
	{
		public ImPlot3DBox* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlot3DBox this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref ImPlot3DPoint Min => ref Unsafe.AsRef<ImPlot3DPoint>(&NativePtr->Min);
		public ref ImPlot3DPoint Max => ref Unsafe.AsRef<ImPlot3DPoint>(&NativePtr->Max);
		public ImPlot3DBoxPtr(ImPlot3DBox* nativePtr) => NativePtr = nativePtr;
		public ImPlot3DBoxPtr(IntPtr nativePtr) => NativePtr = (ImPlot3DBox*)nativePtr;
		public static implicit operator ImPlot3DBoxPtr(ImPlot3DBox* ptr) => new ImPlot3DBoxPtr(ptr);
		public static implicit operator ImPlot3DBoxPtr(IntPtr ptr) => new ImPlot3DBoxPtr(ptr);
		public static implicit operator ImPlot3DBox*(ImPlot3DBoxPtr nativePtr) => nativePtr.NativePtr;
		public bool BoxClipLineSegment(ImPlot3DPoint p0, ImPlot3DPoint p1, ImPlot3DPointPtr p0Clipped, ImPlot3DPointPtr p1Clipped)
		{
			var result = ImPlot3DNative.BoxClipLineSegment(NativePtr, p0, p1, p0Clipped, p1Clipped);
			return result != 0;
		}

		public bool BoxContains(ImPlot3DPoint point)
		{
			var result = ImPlot3DNative.BoxContains(NativePtr, point);
			return result != 0;
		}

		public void BoxExpand(ImPlot3DPoint point)
		{
			ImPlot3DNative.BoxExpand(NativePtr, point);
		}

		public ImPlot3DBoxPtr BoxBoxPlot3DPoInt(ImPlot3DPoint min, ImPlot3DPoint max)
		{
			return ImPlot3DNative.BoxBoxPlot3DPoInt(min, max);
		}

		public void BoxDestroy()
		{
			ImPlot3DNative.BoxDestroy(NativePtr);
		}

		public ImPlot3DBoxPtr BoxBoxNil()
		{
			return ImPlot3DNative.BoxBoxNil();
		}

	}
}
