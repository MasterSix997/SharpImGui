using SharpImGui;
using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImPlot
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlotTagCollection
	{
		public ImVector<ImPlotTag> Tags;
		public ImGuiTextBuffer TextBuffer;
		public int Size;
	}

	public unsafe partial struct ImPlotTagCollectionPtr
	{
		public ImPlotTagCollection* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlotTagCollection this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref ImVector<ImPlotTag> Tags => ref Unsafe.AsRef<ImVector<ImPlotTag>>(&NativePtr->Tags);
		public ref ImGuiTextBuffer TextBuffer => ref Unsafe.AsRef<ImGuiTextBuffer>(&NativePtr->TextBuffer);
		public ref int Size => ref Unsafe.AsRef<int>(&NativePtr->Size);
		public ImPlotTagCollectionPtr(ImPlotTagCollection* nativePtr) => NativePtr = nativePtr;
		public ImPlotTagCollectionPtr(IntPtr nativePtr) => NativePtr = (ImPlotTagCollection*)nativePtr;
		public static implicit operator ImPlotTagCollectionPtr(ImPlotTagCollection* ptr) => new ImPlotTagCollectionPtr(ptr);
		public static implicit operator ImPlotTagCollectionPtr(IntPtr ptr) => new ImPlotTagCollectionPtr(ptr);
		public static implicit operator ImPlotTagCollection*(ImPlotTagCollectionPtr nativePtr) => nativePtr.NativePtr;
		public void TagCollectionReset()
		{
			ImPlotNative.TagCollectionReset(NativePtr);
		}

		public ref byte TagCollectionGetText(int idx)
		{
			var nativeResult = ImPlotNative.TagCollectionGetText(NativePtr, idx);
			return ref *(byte*)&nativeResult;
		}

		public void TagCollectionAppend(ImAxis axis, double value, uint bg, uint fg, ReadOnlySpan<char> fmt)
		{
			// Marshaling fmt to native string
			byte* native_fmt;
			var byteCount_fmt = 0;
			if (fmt != null)
			{
				byteCount_fmt = Encoding.UTF8.GetByteCount(fmt);
				if(byteCount_fmt > Utils.MaxStackallocSize)
				{
					native_fmt = Utils.Alloc<byte>(byteCount_fmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_fmt + 1];
					native_fmt = stackallocBytes;
				}
				var fmt_offset = Utils.EncodeStringUTF8(fmt, native_fmt, byteCount_fmt);
				native_fmt[fmt_offset] = 0;
			}
			else native_fmt = null;

			ImPlotNative.TagCollectionAppend(NativePtr, axis, value, bg, fg, native_fmt);
			// Freeing fmt native string
			if (byteCount_fmt > Utils.MaxStackallocSize)
				Utils.Free(native_fmt);
		}

		public void TagCollectionDestroy()
		{
			ImPlotNative.TagCollectionDestroy(NativePtr);
		}

		public ImPlotTagCollectionPtr TagCollectionTagCollection()
		{
			return ImPlotNative.TagCollectionTagCollection();
		}

	}
}
