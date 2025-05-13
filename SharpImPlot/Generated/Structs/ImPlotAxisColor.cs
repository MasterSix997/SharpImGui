using SharpImGui;
using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImPlot
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlotAxisColor
	{
	}

	public unsafe partial struct ImPlotAxisColorPtr
	{
		public ImPlotAxisColor* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlotAxisColor this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImPlotAxisColorPtr(ImPlotAxisColor* nativePtr) => NativePtr = nativePtr;
		public ImPlotAxisColorPtr(IntPtr nativePtr) => NativePtr = (ImPlotAxisColor*)nativePtr;
		public static implicit operator ImPlotAxisColorPtr(ImPlotAxisColor* ptr) => new ImPlotAxisColorPtr(ptr);
		public static implicit operator ImPlotAxisColorPtr(IntPtr ptr) => new ImPlotAxisColorPtr(ptr);
		public static implicit operator ImPlotAxisColor*(ImPlotAxisColorPtr nativePtr) => nativePtr.NativePtr;
	}
}
