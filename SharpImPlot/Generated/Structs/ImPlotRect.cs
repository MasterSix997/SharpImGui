using SharpImGui;
using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImPlot
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlotRect
	{
		public ImPlotRange X;
		public ImPlotRange Y;
	}

	public unsafe partial struct ImPlotRectPtr
	{
		public ImPlotRect* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlotRect this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref ImPlotRange X => ref Unsafe.AsRef<ImPlotRange>(&NativePtr->X);
		public ref ImPlotRange Y => ref Unsafe.AsRef<ImPlotRange>(&NativePtr->Y);
		public ImPlotRectPtr(ImPlotRect* nativePtr) => NativePtr = nativePtr;
		public ImPlotRectPtr(IntPtr nativePtr) => NativePtr = (ImPlotRect*)nativePtr;
		public static implicit operator ImPlotRectPtr(ImPlotRect* ptr) => new ImPlotRectPtr(ptr);
		public static implicit operator ImPlotRectPtr(IntPtr ptr) => new ImPlotRectPtr(ptr);
		public static implicit operator ImPlotRect*(ImPlotRectPtr nativePtr) => nativePtr.NativePtr;
		public void RectMax(ImPlotPointPtr pOut)
		{
			ImPlotNative.RectMax(pOut, NativePtr);
		}

		public void RectMin(ImPlotPointPtr pOut)
		{
			ImPlotNative.RectMin(pOut, NativePtr);
		}

		public void RectClampDouble(ImPlotPointPtr pOut, double x, double y)
		{
			ImPlotNative.RectClampDouble(pOut, NativePtr, x, y);
		}

		public void RectClampPlotPoInt(ImPlotPointPtr pOut, ImPlotPoint p)
		{
			ImPlotNative.RectClampPlotPoInt(pOut, NativePtr, p);
		}

		public void RectSize(ImPlotPointPtr pOut)
		{
			ImPlotNative.RectSize(pOut, NativePtr);
		}

		public bool RectContainsDouble(double x, double y)
		{
			var result = ImPlotNative.RectContainsDouble(NativePtr, x, y);
			return result != 0;
		}

		public bool RectContainsPlotPoInt(ImPlotPoint p)
		{
			var result = ImPlotNative.RectContainsPlotPoInt(NativePtr, p);
			return result != 0;
		}

		public ImPlotRectPtr RectRectDouble(double xMin, double xMax, double yMin, double yMax)
		{
			return ImPlotNative.RectRectDouble(xMin, xMax, yMin, yMax);
		}

		public void RectDestroy()
		{
			ImPlotNative.RectDestroy(NativePtr);
		}

		public ImPlotRectPtr RectRectNil()
		{
			return ImPlotNative.RectRectNil();
		}

	}
}
