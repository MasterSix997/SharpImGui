using SharpImGui;
using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImPlot
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlotAlignmentData
	{
		public byte Vertical;
		public float PadA;
		public float PadB;
		public float PadAMax;
		public float PadBMax;
	}

	public unsafe partial struct ImPlotAlignmentDataPtr
	{
		public ImPlotAlignmentData* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlotAlignmentData this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref bool Vertical => ref Unsafe.AsRef<bool>(&NativePtr->Vertical);
		public ref float PadA => ref Unsafe.AsRef<float>(&NativePtr->PadA);
		public ref float PadB => ref Unsafe.AsRef<float>(&NativePtr->PadB);
		public ref float PadAMax => ref Unsafe.AsRef<float>(&NativePtr->PadAMax);
		public ref float PadBMax => ref Unsafe.AsRef<float>(&NativePtr->PadBMax);
		public ImPlotAlignmentDataPtr(ImPlotAlignmentData* nativePtr) => NativePtr = nativePtr;
		public ImPlotAlignmentDataPtr(IntPtr nativePtr) => NativePtr = (ImPlotAlignmentData*)nativePtr;
		public static implicit operator ImPlotAlignmentDataPtr(ImPlotAlignmentData* ptr) => new ImPlotAlignmentDataPtr(ptr);
		public static implicit operator ImPlotAlignmentDataPtr(IntPtr ptr) => new ImPlotAlignmentDataPtr(ptr);
		public static implicit operator ImPlotAlignmentData*(ImPlotAlignmentDataPtr nativePtr) => nativePtr.NativePtr;
		public void AlignmentDataReset()
		{
			ImPlotNative.AlignmentDataReset(NativePtr);
		}

		public void AlignmentDataEnd()
		{
			ImPlotNative.AlignmentDataEnd(NativePtr);
		}

		public void AlignmentDataUpdate(ref float padA, ref float padB, ref float deltaA, ref float deltaB)
		{
			fixed (float* nativePadA = &padA)
			fixed (float* nativePadB = &padB)
			fixed (float* nativeDeltaA = &deltaA)
			fixed (float* nativeDeltaB = &deltaB)
			{
				ImPlotNative.AlignmentDataUpdate(NativePtr, nativePadA, nativePadB, nativeDeltaA, nativeDeltaB);
			}
		}

		public void AlignmentDataBegin()
		{
			ImPlotNative.AlignmentDataBegin(NativePtr);
		}

		public void AlignmentDataDestroy()
		{
			ImPlotNative.AlignmentDataDestroy(NativePtr);
		}

		public ImPlotAlignmentDataPtr AlignmentDataAlignmentData()
		{
			return ImPlotNative.AlignmentDataAlignmentData();
		}

	}
}
