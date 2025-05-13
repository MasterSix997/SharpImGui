using SharpImGui;
using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImPlot
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlotItem
	{
		public uint ID;
		public uint Color;
		public ImRect LegendHoverRect;
		public int NameOffset;
		public byte Show;
		public byte LegendHovered;
		public byte SeenThisFrame;
	}

	public unsafe partial struct ImPlotItemPtr
	{
		public ImPlotItem* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlotItem this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);
		public ref uint Color => ref Unsafe.AsRef<uint>(&NativePtr->Color);
		public ref ImRect LegendHoverRect => ref Unsafe.AsRef<ImRect>(&NativePtr->LegendHoverRect);
		public ref int NameOffset => ref Unsafe.AsRef<int>(&NativePtr->NameOffset);
		public ref bool Show => ref Unsafe.AsRef<bool>(&NativePtr->Show);
		public ref bool LegendHovered => ref Unsafe.AsRef<bool>(&NativePtr->LegendHovered);
		public ref bool SeenThisFrame => ref Unsafe.AsRef<bool>(&NativePtr->SeenThisFrame);
		public ImPlotItemPtr(ImPlotItem* nativePtr) => NativePtr = nativePtr;
		public ImPlotItemPtr(IntPtr nativePtr) => NativePtr = (ImPlotItem*)nativePtr;
		public static implicit operator ImPlotItemPtr(ImPlotItem* ptr) => new ImPlotItemPtr(ptr);
		public static implicit operator ImPlotItemPtr(IntPtr ptr) => new ImPlotItemPtr(ptr);
		public static implicit operator ImPlotItem*(ImPlotItemPtr nativePtr) => nativePtr.NativePtr;
		public void ItemDestroy()
		{
			ImPlotNative.ItemDestroy(NativePtr);
		}

		public ImPlotItemPtr ItemItem()
		{
			return ImPlotNative.ItemItem();
		}

	}
}
