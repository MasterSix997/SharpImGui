using SharpImGui;
using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

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
		public ref float Min => ref Unsafe.AsRef<float>(&NativePtr->Min);
		public ref float Max => ref Unsafe.AsRef<float>(&NativePtr->Max);
		public ImPlot3DRangePtr(ImPlot3DRange* nativePtr) => NativePtr = nativePtr;
		public ImPlot3DRangePtr(IntPtr nativePtr) => NativePtr = (ImPlot3DRange*)nativePtr;
		public static implicit operator ImPlot3DRangePtr(ImPlot3DRange* ptr) => new ImPlot3DRangePtr(ptr);
		public static implicit operator ImPlot3DRangePtr(IntPtr ptr) => new ImPlot3DRangePtr(ptr);
		public static implicit operator ImPlot3DRange*(ImPlot3DRangePtr nativePtr) => nativePtr.NativePtr;
		public float RangeSize()
		{
			return ImPlot3DNative.RangeSize(NativePtr);
		}

		public byte RangeContains(float value)
		{
			return ImPlot3DNative.RangeContains(NativePtr, value);
		}

		public void RangeExpand(float value)
		{
			ImPlot3DNative.RangeExpand(NativePtr, value);
		}

		public ImPlot3DRangePtr RangeRangeFloat(float min, float max)
		{
			return ImPlot3DNative.RangeRangeFloat(min, max);
		}

		public void RangeDestroy()
		{
			ImPlot3DNative.RangeDestroy(NativePtr);
		}

		public ImPlot3DRangePtr RangeRangeNil()
		{
			return ImPlot3DNative.RangeRangeNil();
		}

	}
}
