using SharpImGui;
using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImPlot
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlotNextItemData
	{
		public Vector4 Colors_0;
		public Vector4 Colors_1;
		public Vector4 Colors_2;
		public Vector4 Colors_3;
		public Vector4 Colors_4;
		public float LineWeight;
		public ImPlotMarker Marker;
		public float MarkerSize;
		public float MarkerWeight;
		public float FillAlpha;
		public float ErrorBarSize;
		public float ErrorBarWeight;
		public float DigitalBitHeight;
		public float DigitalBitGap;
		public byte RenderLine;
		public byte RenderFill;
		public byte RenderMarkerLine;
		public byte RenderMarkerFill;
		public byte HasHidden;
		public byte Hidden;
		public ImPlotCond HiddenCond;
	}

	public unsafe partial struct ImPlotNextItemDataPtr
	{
		public ImPlotNextItemData* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlotNextItemData this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public Span<Vector4> Colors => new Span<Vector4>(&NativePtr->Colors_0, 5);
		public ref float LineWeight => ref Unsafe.AsRef<float>(&NativePtr->LineWeight);
		public ref ImPlotMarker Marker => ref Unsafe.AsRef<ImPlotMarker>(&NativePtr->Marker);
		public ref float MarkerSize => ref Unsafe.AsRef<float>(&NativePtr->MarkerSize);
		public ref float MarkerWeight => ref Unsafe.AsRef<float>(&NativePtr->MarkerWeight);
		public ref float FillAlpha => ref Unsafe.AsRef<float>(&NativePtr->FillAlpha);
		public ref float ErrorBarSize => ref Unsafe.AsRef<float>(&NativePtr->ErrorBarSize);
		public ref float ErrorBarWeight => ref Unsafe.AsRef<float>(&NativePtr->ErrorBarWeight);
		public ref float DigitalBitHeight => ref Unsafe.AsRef<float>(&NativePtr->DigitalBitHeight);
		public ref float DigitalBitGap => ref Unsafe.AsRef<float>(&NativePtr->DigitalBitGap);
		public ref bool RenderLine => ref Unsafe.AsRef<bool>(&NativePtr->RenderLine);
		public ref bool RenderFill => ref Unsafe.AsRef<bool>(&NativePtr->RenderFill);
		public ref bool RenderMarkerLine => ref Unsafe.AsRef<bool>(&NativePtr->RenderMarkerLine);
		public ref bool RenderMarkerFill => ref Unsafe.AsRef<bool>(&NativePtr->RenderMarkerFill);
		public ref bool HasHidden => ref Unsafe.AsRef<bool>(&NativePtr->HasHidden);
		public ref bool Hidden => ref Unsafe.AsRef<bool>(&NativePtr->Hidden);
		public ref ImPlotCond HiddenCond => ref Unsafe.AsRef<ImPlotCond>(&NativePtr->HiddenCond);
		public ImPlotNextItemDataPtr(ImPlotNextItemData* nativePtr) => NativePtr = nativePtr;
		public ImPlotNextItemDataPtr(IntPtr nativePtr) => NativePtr = (ImPlotNextItemData*)nativePtr;
		public static implicit operator ImPlotNextItemDataPtr(ImPlotNextItemData* ptr) => new ImPlotNextItemDataPtr(ptr);
		public static implicit operator ImPlotNextItemDataPtr(IntPtr ptr) => new ImPlotNextItemDataPtr(ptr);
		public static implicit operator ImPlotNextItemData*(ImPlotNextItemDataPtr nativePtr) => nativePtr.NativePtr;
		public void NextItemDataReset()
		{
			ImPlotNative.NextItemDataReset(NativePtr);
		}

		public void NextItemDataDestroy()
		{
			ImPlotNative.NextItemDataDestroy(NativePtr);
		}

		public ImPlotNextItemDataPtr NextItemDataNextItemData()
		{
			return ImPlotNative.NextItemDataNextItemData();
		}

	}
}
