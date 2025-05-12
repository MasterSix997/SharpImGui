using SharpImGui;
using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImPlot
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlotTick
	{
		public double PlotPos;
		public float PixelPos;
		public Vector2 LabelSize;
		public int TextOffset;
		public byte Major;
		public byte ShowLabel;
		public int Level;
		public int Idx;
	}

	public unsafe partial struct ImPlotTickPtr
	{
		public ImPlotTick* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlotTick this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref double PlotPos => ref Unsafe.AsRef<double>(&NativePtr->PlotPos);
		public ref float PixelPos => ref Unsafe.AsRef<float>(&NativePtr->PixelPos);
		public ref Vector2 LabelSize => ref Unsafe.AsRef<Vector2>(&NativePtr->LabelSize);
		public ref int TextOffset => ref Unsafe.AsRef<int>(&NativePtr->TextOffset);
		public ref bool Major => ref Unsafe.AsRef<bool>(&NativePtr->Major);
		public ref bool ShowLabel => ref Unsafe.AsRef<bool>(&NativePtr->ShowLabel);
		public ref int Level => ref Unsafe.AsRef<int>(&NativePtr->Level);
		public ref int Idx => ref Unsafe.AsRef<int>(&NativePtr->Idx);
		public ImPlotTickPtr(ImPlotTick* nativePtr) => NativePtr = nativePtr;
		public ImPlotTickPtr(IntPtr nativePtr) => NativePtr = (ImPlotTick*)nativePtr;
		public static implicit operator ImPlotTickPtr(ImPlotTick* ptr) => new ImPlotTickPtr(ptr);
		public static implicit operator ImPlotTickPtr(IntPtr ptr) => new ImPlotTickPtr(ptr);
		public static implicit operator ImPlotTick*(ImPlotTickPtr nativePtr) => nativePtr.NativePtr;
		public void TickDestroy()
		{
			ImPlotNative.TickDestroy(NativePtr);
		}

		public ImPlotTickPtr TickTick(double value, bool major, int level, bool showLabel)
		{
			var native_major = major ? (byte)1 : (byte)0;
			var native_showLabel = showLabel ? (byte)1 : (byte)0;
			return ImPlotNative.TickTick(value, native_major, level, native_showLabel);
		}

	}
}
