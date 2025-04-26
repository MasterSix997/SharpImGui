using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Helper: Growable text buffer for logging/accumulating text<br/>(this could be called 'ImGuiTextBuilder' / 'ImGuiStringBuilder')<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTextBuffer
	{
		public ImVector<byte> Buf;
	}

	/// <summary>
	/// Helper: Growable text buffer for logging/accumulating text<br/>(this could be called 'ImGuiTextBuilder' / 'ImGuiStringBuilder')<br/>
	/// </summary>
	public unsafe partial struct ImGuiTextBufferPtr
	{
		public ImGuiTextBuffer* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiTextBuffer this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref ImVector<byte> Buf => ref Unsafe.AsRef<ImVector<byte>>(&NativePtr->Buf);
		public ImGuiTextBufferPtr(ImGuiTextBuffer* nativePtr) => NativePtr = nativePtr;
		public ImGuiTextBufferPtr(IntPtr nativePtr) => NativePtr = (ImGuiTextBuffer*)nativePtr;
		public static implicit operator ImGuiTextBufferPtr(ImGuiTextBuffer* ptr) => new ImGuiTextBufferPtr(ptr);
		public static implicit operator ImGuiTextBufferPtr(IntPtr ptr) => new ImGuiTextBufferPtr(ptr);
		public static implicit operator ImGuiTextBuffer*(ImGuiTextBufferPtr nativePtr) => nativePtr.NativePtr;
		public void Appendf(ReadOnlySpan<char> fmt)
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

			ImGuiNative.ImGuiTextBufferAppendf(NativePtr, native_fmt);
			// Freeing fmt native string
			if (byteCount_fmt > Utils.MaxStackallocSize)
				Utils.Free(native_fmt);
		}

		public void Append(ReadOnlySpan<char> str, ReadOnlySpan<char> strEnd)
		{
			// Marshaling str to native string
			byte* native_str;
			var byteCount_str = 0;
			if (str != null)
			{
				byteCount_str = Encoding.UTF8.GetByteCount(str);
				if(byteCount_str > Utils.MaxStackallocSize)
				{
					native_str = Utils.Alloc<byte>(byteCount_str + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_str + 1];
					native_str = stackallocBytes;
				}
				var str_offset = Utils.EncodeStringUTF8(str, native_str, byteCount_str);
				native_str[str_offset] = 0;
			}
			else native_str = null;

			// Marshaling strEnd to native string
			byte* native_strEnd;
			var byteCount_strEnd = 0;
			if (strEnd != null)
			{
				byteCount_strEnd = Encoding.UTF8.GetByteCount(strEnd);
				if(byteCount_strEnd > Utils.MaxStackallocSize)
				{
					native_strEnd = Utils.Alloc<byte>(byteCount_strEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_strEnd + 1];
					native_strEnd = stackallocBytes;
				}
				var strEnd_offset = Utils.EncodeStringUTF8(strEnd, native_strEnd, byteCount_strEnd);
				native_strEnd[strEnd_offset] = 0;
			}
			else native_strEnd = null;

			ImGuiNative.ImGuiTextBufferAppend(NativePtr, native_str, native_strEnd);
			// Freeing str native string
			if (byteCount_str > Utils.MaxStackallocSize)
				Utils.Free(native_str);
			// Freeing strEnd native string
			if (byteCount_strEnd > Utils.MaxStackallocSize)
				Utils.Free(native_strEnd);
		}

		public ref byte CStr()
		{
			var nativeResult = ImGuiNative.ImGuiTextBufferCStr(NativePtr);
			return ref *(byte*)&nativeResult;
		}

		public void Reserve(int capacity)
		{
			ImGuiNative.ImGuiTextBufferReserve(NativePtr, capacity);
		}

		/// <summary>
		/// Similar to resize(0) on ImVector: empty string but don't free buffer.<br/>
		/// </summary>
		public void Resize(int size)
		{
			ImGuiNative.ImGuiTextBufferResize(NativePtr, size);
		}

		public void Clear()
		{
			ImGuiNative.ImGuiTextBufferClear(NativePtr);
		}

		public byte Empty()
		{
			return ImGuiNative.ImGuiTextBufferEmpty(NativePtr);
		}

		public int Size()
		{
			return ImGuiNative.ImGuiTextBufferSize(NativePtr);
		}

		/// <summary>
		/// Buf is zero-terminated, so end() will point on the zero-terminator<br/>
		/// </summary>
		public ref byte End()
		{
			var nativeResult = ImGuiNative.ImGuiTextBufferEnd(NativePtr);
			return ref *(byte*)&nativeResult;
		}

		public ref byte Begin()
		{
			var nativeResult = ImGuiNative.ImGuiTextBufferBegin(NativePtr);
			return ref *(byte*)&nativeResult;
		}

		public void Destroy()
		{
			ImGuiNative.ImGuiTextBufferDestroy(NativePtr);
		}

		public void ImGuiTextBufferConstruct()
		{
			ImGuiNative.ImGuiTextBufferImGuiTextBufferConstruct(NativePtr);
		}

		public ImGuiTextBufferPtr ImGuiTextBuffer()
		{
			return ImGuiNative.ImGuiTextBufferImGuiTextBuffer();
		}

	}
}
