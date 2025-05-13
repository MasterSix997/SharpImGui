using SharpImGui;
using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImPlot
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlotLegend
	{
		public ImPlotLegendFlags Flags;
		public ImPlotLegendFlags PreviousFlags;
		public ImPlotLocation Location;
		public ImPlotLocation PreviousLocation;
		public Vector2 Scroll;
		public ImVector<int> Indices;
		public ImGuiTextBuffer Labels;
		public ImRect Rect;
		public ImRect RectClamped;
		public byte Hovered;
		public byte Held;
		public byte CanGoInside;
	}

	public unsafe partial struct ImPlotLegendPtr
	{
		public ImPlotLegend* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlotLegend this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref ImPlotLegendFlags Flags => ref Unsafe.AsRef<ImPlotLegendFlags>(&NativePtr->Flags);
		public ref ImPlotLegendFlags PreviousFlags => ref Unsafe.AsRef<ImPlotLegendFlags>(&NativePtr->PreviousFlags);
		public ref ImPlotLocation Location => ref Unsafe.AsRef<ImPlotLocation>(&NativePtr->Location);
		public ref ImPlotLocation PreviousLocation => ref Unsafe.AsRef<ImPlotLocation>(&NativePtr->PreviousLocation);
		public ref Vector2 Scroll => ref Unsafe.AsRef<Vector2>(&NativePtr->Scroll);
		public ref ImVector<int> Indices => ref Unsafe.AsRef<ImVector<int>>(&NativePtr->Indices);
		public ref ImGuiTextBuffer Labels => ref Unsafe.AsRef<ImGuiTextBuffer>(&NativePtr->Labels);
		public ref ImRect Rect => ref Unsafe.AsRef<ImRect>(&NativePtr->Rect);
		public ref ImRect RectClamped => ref Unsafe.AsRef<ImRect>(&NativePtr->RectClamped);
		public ref bool Hovered => ref Unsafe.AsRef<bool>(&NativePtr->Hovered);
		public ref bool Held => ref Unsafe.AsRef<bool>(&NativePtr->Held);
		public ref bool CanGoInside => ref Unsafe.AsRef<bool>(&NativePtr->CanGoInside);
		public ImPlotLegendPtr(ImPlotLegend* nativePtr) => NativePtr = nativePtr;
		public ImPlotLegendPtr(IntPtr nativePtr) => NativePtr = (ImPlotLegend*)nativePtr;
		public static implicit operator ImPlotLegendPtr(ImPlotLegend* ptr) => new ImPlotLegendPtr(ptr);
		public static implicit operator ImPlotLegendPtr(IntPtr ptr) => new ImPlotLegendPtr(ptr);
		public static implicit operator ImPlotLegend*(ImPlotLegendPtr nativePtr) => nativePtr.NativePtr;
		public void LegendReset()
		{
			ImPlotNative.LegendReset(NativePtr);
		}

		public void LegendDestroy()
		{
			ImPlotNative.LegendDestroy(NativePtr);
		}

		public ImPlotLegendPtr LegendLegend()
		{
			return ImPlotNative.LegendLegend();
		}

	}
}
