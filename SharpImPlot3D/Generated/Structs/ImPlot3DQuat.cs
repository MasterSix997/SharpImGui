using SharpImGui;
using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImPlot3D
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlot3DQuat
	{
		public float X;
		public float Y;
		public float Z;
		public float W;
	}

	public unsafe partial struct ImPlot3DQuatPtr
	{
		public ImPlot3DQuat* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlot3DQuat this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref float X => ref Unsafe.AsRef<float>(&NativePtr->X);
		public ref float Y => ref Unsafe.AsRef<float>(&NativePtr->Y);
		public ref float Z => ref Unsafe.AsRef<float>(&NativePtr->Z);
		public ref float W => ref Unsafe.AsRef<float>(&NativePtr->W);
		public ImPlot3DQuatPtr(ImPlot3DQuat* nativePtr) => NativePtr = nativePtr;
		public ImPlot3DQuatPtr(IntPtr nativePtr) => NativePtr = (ImPlot3DQuat*)nativePtr;
		public static implicit operator ImPlot3DQuatPtr(ImPlot3DQuat* ptr) => new ImPlot3DQuatPtr(ptr);
		public static implicit operator ImPlot3DQuatPtr(IntPtr ptr) => new ImPlot3DQuatPtr(ptr);
		public static implicit operator ImPlot3DQuat*(ImPlot3DQuatPtr nativePtr) => nativePtr.NativePtr;
		public float QuatDot(ImPlot3DQuat rhs)
		{
			return ImPlot3DNative.QuatDot(NativePtr, rhs);
		}

		public void QuatSlerp(ImPlot3DQuatPtr pOut, ImPlot3DQuat q1, ImPlot3DQuat q2, float t)
		{
			ImPlot3DNative.QuatSlerp(pOut, q1, q2, t);
		}

		public ImPlot3DQuatPtr QuatNormalize()
		{
			return ImPlot3DNative.QuatNormalize(NativePtr);
		}

		public void QuatInverse(ImPlot3DQuatPtr pOut)
		{
			ImPlot3DNative.QuatInverse(pOut, NativePtr);
		}

		public void QuatConjugate(ImPlot3DQuatPtr pOut)
		{
			ImPlot3DNative.QuatConjugate(pOut, NativePtr);
		}

		public void QuatNormalized(ImPlot3DQuatPtr pOut)
		{
			ImPlot3DNative.QuatNormalized(pOut, NativePtr);
		}

		public float QuatLength()
		{
			return ImPlot3DNative.QuatLength(NativePtr);
		}

		public void QuatFromElAz(ImPlot3DQuatPtr pOut, float elevation, float azimuth)
		{
			ImPlot3DNative.QuatFromElAz(pOut, elevation, azimuth);
		}

		public void QuatFromTwoVectors(ImPlot3DQuatPtr pOut, ImPlot3DPoint v0, ImPlot3DPoint v1)
		{
			ImPlot3DNative.QuatFromTwoVectors(pOut, v0, v1);
		}

		public ImPlot3DQuatPtr QuatQuatFloatPlot3DPoInt(float angle, ImPlot3DPoint axis)
		{
			return ImPlot3DNative.QuatQuatFloatPlot3DPoInt(angle, axis);
		}

		public ImPlot3DQuatPtr QuatQuatFloatFloat(float x, float y, float z, float w)
		{
			return ImPlot3DNative.QuatQuatFloatFloat(x, y, z, w);
		}

		public void QuatDestroy()
		{
			ImPlot3DNative.QuatDestroy(NativePtr);
		}

		public ImPlot3DQuatPtr QuatQuatNil()
		{
			return ImPlot3DNative.QuatQuatNil();
		}

	}
}
