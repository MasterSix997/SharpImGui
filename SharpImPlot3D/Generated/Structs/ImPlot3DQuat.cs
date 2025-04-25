using System;
using System.Numerics;
using System.Runtime.InteropServices;
using SharpImGui;

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
		public ImPlot3DQuatPtr(ImPlot3DQuat* nativePtr) => NativePtr = nativePtr;
		public ImPlot3DQuatPtr(IntPtr nativePtr) => NativePtr = (ImPlot3DQuat*)nativePtr;
		public static implicit operator ImPlot3DQuatPtr(ImPlot3DQuat* ptr) => new ImPlot3DQuatPtr(ptr);
		public static implicit operator ImPlot3DQuatPtr(IntPtr ptr) => new ImPlot3DQuatPtr(ptr);
		public static implicit operator ImPlot3DQuat*(ImPlot3DQuatPtr nativePtr) => nativePtr.NativePtr;
	}
}
