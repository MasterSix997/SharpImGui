using SharpImGui;
using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImPlot
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlotTicker
	{
		public ImVector<ImPlotTick> Ticks;
		public ImGuiTextBuffer TextBuffer;
		public Vector2 MaxSize;
		public Vector2 LateSize;
		public int Levels;
	}

	public unsafe partial struct ImPlotTickerPtr
	{
		public ImPlotTicker* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlotTicker this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref ImVector<ImPlotTick> Ticks => ref Unsafe.AsRef<ImVector<ImPlotTick>>(&NativePtr->Ticks);
		public ref ImGuiTextBuffer TextBuffer => ref Unsafe.AsRef<ImGuiTextBuffer>(&NativePtr->TextBuffer);
		public ref Vector2 MaxSize => ref Unsafe.AsRef<Vector2>(&NativePtr->MaxSize);
		public ref Vector2 LateSize => ref Unsafe.AsRef<Vector2>(&NativePtr->LateSize);
		public ref int Levels => ref Unsafe.AsRef<int>(&NativePtr->Levels);
		public ImPlotTickerPtr(ImPlotTicker* nativePtr) => NativePtr = nativePtr;
		public ImPlotTickerPtr(IntPtr nativePtr) => NativePtr = (ImPlotTicker*)nativePtr;
		public static implicit operator ImPlotTickerPtr(ImPlotTicker* ptr) => new ImPlotTickerPtr(ptr);
		public static implicit operator ImPlotTickerPtr(IntPtr ptr) => new ImPlotTickerPtr(ptr);
		public static implicit operator ImPlotTicker*(ImPlotTickerPtr nativePtr) => nativePtr.NativePtr;
		public int TickerTickCount()
		{
			return ImPlotNative.TickerTickCount(NativePtr);
		}

		public void TickerReset()
		{
			ImPlotNative.TickerReset(NativePtr);
		}

		public void TickerOverrideSizeLate(Vector2 size)
		{
			ImPlotNative.TickerOverrideSizeLate(NativePtr, size);
		}

		public ref byte TickerGetTextPlotTick(ImPlotTick tick)
		{
			var nativeResult = ImPlotNative.TickerGetTextPlotTick(NativePtr, tick);
			return ref *(byte*)&nativeResult;
		}

		public ref byte TickerGetTextInt(int idx)
		{
			var nativeResult = ImPlotNative.TickerGetTextInt(NativePtr, idx);
			return ref *(byte*)&nativeResult;
		}

		public ImPlotTickPtr TickerAddTickPlotTick(ImPlotTick tick)
		{
			return ImPlotNative.TickerAddTickPlotTick(NativePtr, tick);
		}

		public ImPlotTickPtr TickerAddTickDoublePlotFormatter(double value, bool major, int level, bool showLabel, ImPlotFormatter formatter, IntPtr data)
		{
			var native_major = major ? (byte)1 : (byte)0;
			var native_showLabel = showLabel ? (byte)1 : (byte)0;
			return ImPlotNative.TickerAddTickDoublePlotFormatter(NativePtr, value, native_major, level, native_showLabel, formatter, (void*)data);
		}

		public ImPlotTickPtr TickerAddTickDoubleStr(double value, bool major, int level, bool showLabel, ReadOnlySpan<char> label)
		{
			var native_major = major ? (byte)1 : (byte)0;
			var native_showLabel = showLabel ? (byte)1 : (byte)0;
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			return ImPlotNative.TickerAddTickDoubleStr(NativePtr, value, native_major, level, native_showLabel, native_label);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
		}

		public void TickerDestroy()
		{
			ImPlotNative.TickerDestroy(NativePtr);
		}

		public ImPlotTickerPtr TickerTicker()
		{
			return ImPlotNative.TickerTicker();
		}

	}
}
