using SharpImGui;
using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImPlot3D
{
	/// <summary>
	/// ImPlot3DPoint: 3D vector to store points in 3D<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlot3DPoint
	{
		public float X;
		public float Y;
		public float Z;
	}

	/// <summary>
	/// ImPlot3DPoint: 3D vector to store points in 3D<br/>
	/// </summary>
	public unsafe partial struct ImPlot3DPointPtr
	{
		public ImPlot3DPoint* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlot3DPoint this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref float X => ref Unsafe.AsRef<float>(&NativePtr->X);
		public ref float Y => ref Unsafe.AsRef<float>(&NativePtr->Y);
		public ref float Z => ref Unsafe.AsRef<float>(&NativePtr->Z);
		public ImPlot3DPointPtr(ImPlot3DPoint* nativePtr) => NativePtr = nativePtr;
		public ImPlot3DPointPtr(IntPtr nativePtr) => NativePtr = (ImPlot3DPoint*)nativePtr;
		public static implicit operator ImPlot3DPointPtr(ImPlot3DPoint* ptr) => new ImPlot3DPointPtr(ptr);
		public static implicit operator ImPlot3DPointPtr(IntPtr ptr) => new ImPlot3DPointPtr(ptr);
		public static implicit operator ImPlot3DPoint*(ImPlot3DPointPtr nativePtr) => nativePtr.NativePtr;
		public byte PointIsNaN()
		{
			return ImPlot3DNative.PointIsNaN(NativePtr);
		}

		public void PointNormalized(ImPlot3DPointPtr pOut)
		{
			ImPlot3DNative.PointNormalized(pOut, NativePtr);
		}

		public void PointNormalize()
		{
			ImPlot3DNative.PointNormalize(NativePtr);
		}

		public float PointLengthSquared()
		{
			return ImPlot3DNative.PointLengthSquared(NativePtr);
		}

		public float PointLength()
		{
			return ImPlot3DNative.PointLength(NativePtr);
		}

		public void PointCross(ImPlot3DPointPtr pOut, ImPlot3DPoint rhs)
		{
			ImPlot3DNative.PointCross(pOut, NativePtr, rhs);
		}

		public float PointDot(ImPlot3DPoint rhs)
		{
			return ImPlot3DNative.PointDot(NativePtr, rhs);
		}

		public ImPlot3DPointPtr PointPointFloat(float x, float y, float z)
		{
			return ImPlot3DNative.PointPointFloat(x, y, z);
		}

		public void PointDestroy()
		{
			ImPlot3DNative.PointDestroy(NativePtr);
		}

		public ImPlot3DPointPtr PointPointNil()
		{
			return ImPlot3DNative.PointPointNil();
		}

	}
}
