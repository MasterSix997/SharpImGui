using SharpImGui;
using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImPlot3D
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlot3DContext
	{
	}

	public unsafe partial struct ImPlot3DContextPtr
	{
		public ImPlot3DContext* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlot3DContext this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImPlot3DContextPtr(ImPlot3DContext* nativePtr) => NativePtr = nativePtr;
		public ImPlot3DContextPtr(IntPtr nativePtr) => NativePtr = (ImPlot3DContext*)nativePtr;
		public static implicit operator ImPlot3DContextPtr(ImPlot3DContext* ptr) => new ImPlot3DContextPtr(ptr);
		public static implicit operator ImPlot3DContextPtr(IntPtr ptr) => new ImPlot3DContextPtr(ptr);
		public static implicit operator ImPlot3DContext*(ImPlot3DContextPtr nativePtr) => nativePtr.NativePtr;
	}
}
