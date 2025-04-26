using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	///     [Internal]<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTextRange
	{
		public unsafe byte* B;
		public unsafe byte* E;
	}

	/// <summary>
	///     [Internal]<br/>
	/// </summary>
	public unsafe partial struct ImGuiTextRangePtr
	{
		public ImGuiTextRange* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiTextRange this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public IntPtr B { get => (IntPtr)NativePtr->B; set => NativePtr->B = (byte*)value; }
		public IntPtr E { get => (IntPtr)NativePtr->E; set => NativePtr->E = (byte*)value; }
		public ImGuiTextRangePtr(ImGuiTextRange* nativePtr) => NativePtr = nativePtr;
		public ImGuiTextRangePtr(IntPtr nativePtr) => NativePtr = (ImGuiTextRange*)nativePtr;
		public static implicit operator ImGuiTextRangePtr(ImGuiTextRange* ptr) => new ImGuiTextRangePtr(ptr);
		public static implicit operator ImGuiTextRangePtr(IntPtr ptr) => new ImGuiTextRangePtr(ptr);
		public static implicit operator ImGuiTextRange*(ImGuiTextRangePtr nativePtr) => nativePtr.NativePtr;
		public void Split(bool separator, ref ImVector<ImGuiTextRange> _out)
		{
			var native_separator = separator ? (byte)1 : (byte)0;
			fixed (ImVector<ImGuiTextRange>* native__out = &_out)
			{
				ImGuiNative.ImGuiTextRangeSplit(NativePtr, native_separator, native__out);
			}
		}

		public byte Empty()
		{
			return ImGuiNative.ImGuiTextRangeEmpty(NativePtr);
		}

		public void ImGuiTextRangeStrConstruct(ReadOnlySpan<char> b, ReadOnlySpan<char> e)
		{
			// Marshaling b to native string
			byte* native_b;
			var byteCount_b = 0;
			if (b != null)
			{
				byteCount_b = Encoding.UTF8.GetByteCount(b);
				if(byteCount_b > Utils.MaxStackallocSize)
				{
					native_b = Utils.Alloc<byte>(byteCount_b + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_b + 1];
					native_b = stackallocBytes;
				}
				var b_offset = Utils.EncodeStringUTF8(b, native_b, byteCount_b);
				native_b[b_offset] = 0;
			}
			else native_b = null;

			// Marshaling e to native string
			byte* native_e;
			var byteCount_e = 0;
			if (e != null)
			{
				byteCount_e = Encoding.UTF8.GetByteCount(e);
				if(byteCount_e > Utils.MaxStackallocSize)
				{
					native_e = Utils.Alloc<byte>(byteCount_e + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_e + 1];
					native_e = stackallocBytes;
				}
				var e_offset = Utils.EncodeStringUTF8(e, native_e, byteCount_e);
				native_e[e_offset] = 0;
			}
			else native_e = null;

			ImGuiNative.ImGuiTextRangeImGuiTextRangeStrConstruct(NativePtr, native_b, native_e);
			// Freeing b native string
			if (byteCount_b > Utils.MaxStackallocSize)
				Utils.Free(native_b);
			// Freeing e native string
			if (byteCount_e > Utils.MaxStackallocSize)
				Utils.Free(native_e);
		}

		public ImGuiTextRangePtr ImGuiTextRange(ReadOnlySpan<char> b, ReadOnlySpan<char> e)
		{
			// Marshaling b to native string
			byte* native_b;
			var byteCount_b = 0;
			if (b != null)
			{
				byteCount_b = Encoding.UTF8.GetByteCount(b);
				if(byteCount_b > Utils.MaxStackallocSize)
				{
					native_b = Utils.Alloc<byte>(byteCount_b + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_b + 1];
					native_b = stackallocBytes;
				}
				var b_offset = Utils.EncodeStringUTF8(b, native_b, byteCount_b);
				native_b[b_offset] = 0;
			}
			else native_b = null;

			// Marshaling e to native string
			byte* native_e;
			var byteCount_e = 0;
			if (e != null)
			{
				byteCount_e = Encoding.UTF8.GetByteCount(e);
				if(byteCount_e > Utils.MaxStackallocSize)
				{
					native_e = Utils.Alloc<byte>(byteCount_e + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_e + 1];
					native_e = stackallocBytes;
				}
				var e_offset = Utils.EncodeStringUTF8(e, native_e, byteCount_e);
				native_e[e_offset] = 0;
			}
			else native_e = null;

			return ImGuiNative.ImGuiTextRangeImGuiTextRange(native_b, native_e);
			// Freeing b native string
			if (byteCount_b > Utils.MaxStackallocSize)
				Utils.Free(native_b);
			// Freeing e native string
			if (byteCount_e > Utils.MaxStackallocSize)
				Utils.Free(native_e);
		}

		public void Destroy()
		{
			ImGuiNative.ImGuiTextRangeDestroy(NativePtr);
		}

		public void ImGuiTextRangeNilConstruct()
		{
			ImGuiNative.ImGuiTextRangeImGuiTextRangeNilConstruct(NativePtr);
		}

		public ImGuiTextRangePtr ImGuiTextRange()
		{
			return ImGuiNative.ImGuiTextRangeImGuiTextRange();
		}

	}
}
