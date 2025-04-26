using SharpImGui;
using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImPlot
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlotItemGroup
	{
		public uint ID;
		public ImPlotLegend Legend;
		public ImPool<ImPlotItem> ItemPool;
		public int ColormapIdx;
	}

	public unsafe partial struct ImPlotItemGroupPtr
	{
		public ImPlotItemGroup* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlotItemGroup this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);
		public ref ImPlotLegend Legend => ref Unsafe.AsRef<ImPlotLegend>(&NativePtr->Legend);
		public ref ImPool<ImPlotItem> ItemPool => ref Unsafe.AsRef<ImPool<ImPlotItem>>(&NativePtr->ItemPool);
		public ref int ColormapIdx => ref Unsafe.AsRef<int>(&NativePtr->ColormapIdx);
		public ImPlotItemGroupPtr(ImPlotItemGroup* nativePtr) => NativePtr = nativePtr;
		public ImPlotItemGroupPtr(IntPtr nativePtr) => NativePtr = (ImPlotItemGroup*)nativePtr;
		public static implicit operator ImPlotItemGroupPtr(ImPlotItemGroup* ptr) => new ImPlotItemGroupPtr(ptr);
		public static implicit operator ImPlotItemGroupPtr(IntPtr ptr) => new ImPlotItemGroupPtr(ptr);
		public static implicit operator ImPlotItemGroup*(ImPlotItemGroupPtr nativePtr) => nativePtr.NativePtr;
		public void ItemGroupReset()
		{
			ImPlotNative.ItemGroupReset(NativePtr);
		}

		public ref byte ItemGroupGetLegendLabel(int i)
		{
			var nativeResult = ImPlotNative.ItemGroupGetLegendLabel(NativePtr, i);
			return ref *(byte*)&nativeResult;
		}

		public ImPlotItemPtr ItemGroupGetLegendItem(int i)
		{
			return ImPlotNative.ItemGroupGetLegendItem(NativePtr, i);
		}

		public int ItemGroupGetLegendCount()
		{
			return ImPlotNative.ItemGroupGetLegendCount(NativePtr);
		}

		public int ItemGroupGetItemIndex(ImPlotItemPtr item)
		{
			return ImPlotNative.ItemGroupGetItemIndex(NativePtr, item);
		}

		public ImPlotItemPtr ItemGroupGetItemByIndex(int i)
		{
			return ImPlotNative.ItemGroupGetItemByIndex(NativePtr, i);
		}

		public ImPlotItemPtr ItemGroupGetOrAddItem(uint id)
		{
			return ImPlotNative.ItemGroupGetOrAddItem(NativePtr, id);
		}

		public ImPlotItemPtr ItemGroupGetItemStr(ReadOnlySpan<char> labelId)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			return ImPlotNative.ItemGroupGetItemStr(NativePtr, native_labelId);
			// Freeing labelId native string
			if (byteCount_labelId > Utils.MaxStackallocSize)
				Utils.Free(native_labelId);
		}

		public ImPlotItemPtr ItemGroupGetItemID(uint id)
		{
			return ImPlotNative.ItemGroupGetItemID(NativePtr, id);
		}

		public uint ItemGroupGetItemID(ReadOnlySpan<char> labelId)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			return ImPlotNative.ItemGroupGetItemID(NativePtr, native_labelId);
			// Freeing labelId native string
			if (byteCount_labelId > Utils.MaxStackallocSize)
				Utils.Free(native_labelId);
		}

		public int ItemGroupGetItemCount()
		{
			return ImPlotNative.ItemGroupGetItemCount(NativePtr);
		}

		public void ItemGroupDestroy()
		{
			ImPlotNative.ItemGroupDestroy(NativePtr);
		}

		public ImPlotItemGroupPtr ItemGroupItemGroup()
		{
			return ImPlotNative.ItemGroupItemGroup();
		}

	}
}
