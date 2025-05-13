using SharpImGui;
using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImPlot
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlotColormapData
	{
		public ImVector<uint> Keys;
		public ImVector<int> KeyCounts;
		public ImVector<int> KeyOffsets;
		public ImVector<uint> Tables;
		public ImVector<int> TableSizes;
		public ImVector<int> TableOffsets;
		public ImGuiTextBuffer Text;
		public ImVector<int> TextOffsets;
		public ImVector<byte> Quals;
		public ImGuiStorage Map;
		public int Count;
	}

	public unsafe partial struct ImPlotColormapDataPtr
	{
		public ImPlotColormapData* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlotColormapData this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref ImVector<uint> Keys => ref Unsafe.AsRef<ImVector<uint>>(&NativePtr->Keys);
		public ref ImVector<int> KeyCounts => ref Unsafe.AsRef<ImVector<int>>(&NativePtr->KeyCounts);
		public ref ImVector<int> KeyOffsets => ref Unsafe.AsRef<ImVector<int>>(&NativePtr->KeyOffsets);
		public ref ImVector<uint> Tables => ref Unsafe.AsRef<ImVector<uint>>(&NativePtr->Tables);
		public ref ImVector<int> TableSizes => ref Unsafe.AsRef<ImVector<int>>(&NativePtr->TableSizes);
		public ref ImVector<int> TableOffsets => ref Unsafe.AsRef<ImVector<int>>(&NativePtr->TableOffsets);
		public ref ImGuiTextBuffer Text => ref Unsafe.AsRef<ImGuiTextBuffer>(&NativePtr->Text);
		public ref ImVector<int> TextOffsets => ref Unsafe.AsRef<ImVector<int>>(&NativePtr->TextOffsets);
		public ref ImVector<byte> Quals => ref Unsafe.AsRef<ImVector<byte>>(&NativePtr->Quals);
		public ref ImGuiStorage Map => ref Unsafe.AsRef<ImGuiStorage>(&NativePtr->Map);
		public ref int Count => ref Unsafe.AsRef<int>(&NativePtr->Count);
		public ImPlotColormapDataPtr(ImPlotColormapData* nativePtr) => NativePtr = nativePtr;
		public ImPlotColormapDataPtr(IntPtr nativePtr) => NativePtr = (ImPlotColormapData*)nativePtr;
		public static implicit operator ImPlotColormapDataPtr(ImPlotColormapData* ptr) => new ImPlotColormapDataPtr(ptr);
		public static implicit operator ImPlotColormapDataPtr(IntPtr ptr) => new ImPlotColormapDataPtr(ptr);
		public static implicit operator ImPlotColormapData*(ImPlotColormapDataPtr nativePtr) => nativePtr.NativePtr;
		public uint ColormapDataLerpTable(ImPlotColormap cmap, float t)
		{
			return ImPlotNative.ColormapDataLerpTable(NativePtr, cmap, t);
		}

		public uint ColormapDataGetTableColor(ImPlotColormap cmap, int idx)
		{
			return ImPlotNative.ColormapDataGetTableColor(NativePtr, cmap, idx);
		}

		public int ColormapDataGetTableSize(ImPlotColormap cmap)
		{
			return ImPlotNative.ColormapDataGetTableSize(NativePtr, cmap);
		}

		public ref uint ColormapDataGetTable(ImPlotColormap cmap)
		{
			var nativeResult = ImPlotNative.ColormapDataGetTable(NativePtr, cmap);
			return ref *(uint*)&nativeResult;
		}

		public void ColormapDataSetKeyColor(ImPlotColormap cmap, int idx, uint value)
		{
			ImPlotNative.ColormapDataSetKeyColor(NativePtr, cmap, idx, value);
		}

		public uint ColormapDataGetKeyColor(ImPlotColormap cmap, int idx)
		{
			return ImPlotNative.ColormapDataGetKeyColor(NativePtr, cmap, idx);
		}

		public int ColormapDataGetKeyCount(ImPlotColormap cmap)
		{
			return ImPlotNative.ColormapDataGetKeyCount(NativePtr, cmap);
		}

		public ref uint ColormapDataGetKeys(ImPlotColormap cmap)
		{
			var nativeResult = ImPlotNative.ColormapDataGetKeys(NativePtr, cmap);
			return ref *(uint*)&nativeResult;
		}

		public ImPlotColormap ColormapDataGetIndex(ReadOnlySpan<byte> name)
		{
			fixed (byte* nativeName = name)
			{
				return ImPlotNative.ColormapDataGetIndex(NativePtr, nativeName);
			}
		}

		public ImPlotColormap ColormapDataGetIndex(ReadOnlySpan<char> name)
		{
			// Marshaling name to native string
			byte* nativeName;
			var byteCountName = 0;
			if (name != null && !name.IsEmpty)
			{
				byteCountName = Encoding.UTF8.GetByteCount(name);
				if(byteCountName > Utils.MaxStackallocSize)
				{
					nativeName = Utils.Alloc<byte>(byteCountName + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountName + 1];
					nativeName = stackallocBytes;
				}
				var offsetName = Utils.EncodeStringUTF8(name, nativeName, byteCountName);
				nativeName[offsetName] = 0;
			}
			else nativeName = null;

			var result = ImPlotNative.ColormapDataGetIndex(NativePtr, nativeName);
			// Freeing name native string
			if (byteCountName > Utils.MaxStackallocSize)
				Utils.Free(nativeName);
			return result;
		}

		public string ColormapDataGetName(ImPlotColormap cmap)
		{
			var result = ImPlotNative.ColormapDataGetName(NativePtr, cmap);
			return Utils.DecodeStringUTF8(result);
		}

		public bool ColormapDataIsQual(ImPlotColormap cmap)
		{
			var result = ImPlotNative.ColormapDataIsQual(NativePtr, cmap);
			return result != 0;
		}

		public void ColormapDataRebuildTables()
		{
			ImPlotNative.ColormapDataRebuildTables(NativePtr);
		}

		public void ColormapDataAppendTable(ImPlotColormap cmap)
		{
			ImPlotNative.ColormapDataAppendTable(NativePtr, cmap);
		}

		public int ColormapDataAppend(ReadOnlySpan<byte> name, uint[] keys, int count, bool qual)
		{
			var native_qual = qual ? (byte)1 : (byte)0;
			fixed (byte* nativeName = name)
			fixed (uint* nativeKeys = keys)
			{
				return ImPlotNative.ColormapDataAppend(NativePtr, nativeName, nativeKeys, count, native_qual);
			}
		}

		public int ColormapDataAppend(ReadOnlySpan<char> name, uint[] keys, int count, bool qual)
		{
			// Marshaling name to native string
			byte* nativeName;
			var byteCountName = 0;
			if (name != null && !name.IsEmpty)
			{
				byteCountName = Encoding.UTF8.GetByteCount(name);
				if(byteCountName > Utils.MaxStackallocSize)
				{
					nativeName = Utils.Alloc<byte>(byteCountName + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountName + 1];
					nativeName = stackallocBytes;
				}
				var offsetName = Utils.EncodeStringUTF8(name, nativeName, byteCountName);
				nativeName[offsetName] = 0;
			}
			else nativeName = null;

			var native_qual = qual ? (byte)1 : (byte)0;
			fixed (uint* nativeKeys = keys)
			{
				var result = ImPlotNative.ColormapDataAppend(NativePtr, nativeName, nativeKeys, count, native_qual);
				// Freeing name native string
				if (byteCountName > Utils.MaxStackallocSize)
					Utils.Free(nativeName);
				return result;
			}
		}

		public void ColormapDataDestroy()
		{
			ImPlotNative.ColormapDataDestroy(NativePtr);
		}

		public ImPlotColormapDataPtr ColormapDataColormapData()
		{
			return ImPlotNative.ColormapDataColormapData();
		}

	}
}
