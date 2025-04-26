using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Helper to build glyph ranges from text/string data. Feed your application strings/characters to it then call BuildRanges().<br/>This is essentially a tightly packed of vector of 64k booleans = 8KB storage.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImFontGlyphRangesBuilder
	{
		/// <summary>
		/// Store 1-bit per Unicode code point (0=unused, 1=used)<br/>
		/// </summary>
		public ImVector<uint> UsedChars;
	}

	/// <summary>
	/// Helper to build glyph ranges from text/string data. Feed your application strings/characters to it then call BuildRanges().<br/>This is essentially a tightly packed of vector of 64k booleans = 8KB storage.<br/>
	/// </summary>
	public unsafe partial struct ImFontGlyphRangesBuilderPtr
	{
		public ImFontGlyphRangesBuilder* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImFontGlyphRangesBuilder this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// Store 1-bit per Unicode code point (0=unused, 1=used)<br/>
		/// </summary>
		public ref ImVector<uint> UsedChars => ref Unsafe.AsRef<ImVector<uint>>(&NativePtr->UsedChars);
		public ImFontGlyphRangesBuilderPtr(ImFontGlyphRangesBuilder* nativePtr) => NativePtr = nativePtr;
		public ImFontGlyphRangesBuilderPtr(IntPtr nativePtr) => NativePtr = (ImFontGlyphRangesBuilder*)nativePtr;
		public static implicit operator ImFontGlyphRangesBuilderPtr(ImFontGlyphRangesBuilder* ptr) => new ImFontGlyphRangesBuilderPtr(ptr);
		public static implicit operator ImFontGlyphRangesBuilderPtr(IntPtr ptr) => new ImFontGlyphRangesBuilderPtr(ptr);
		public static implicit operator ImFontGlyphRangesBuilder*(ImFontGlyphRangesBuilderPtr nativePtr) => nativePtr.NativePtr;
		/// <summary>
		/// Output new ranges<br/>
		/// </summary>
		public void BuildRanges(ref ImVector<ushort> outRanges)
		{
			fixed (ImVector<ushort>* native_outRanges = &outRanges)
			{
				ImGuiNative.ImFontGlyphRangesBuilderBuildRanges(NativePtr, native_outRanges);
			}
		}

		/// <summary>
		/// Add ranges, e.g. builder.AddRanges(ImFontAtlas::GetGlyphRangesDefault()) to force add all of ASCII/Latin+Ext<br/>
		/// </summary>
		public void AddRanges(ref ushort ranges)
		{
			fixed (ushort* native_ranges = &ranges)
			{
				ImGuiNative.ImFontGlyphRangesBuilderAddRanges(NativePtr, native_ranges);
			}
		}

		/// <summary>
		/// Add string (each character of the UTF-8 string are added)<br/>
		/// </summary>
		public void AddText(ReadOnlySpan<char> text, ReadOnlySpan<char> textEnd)
		{
			// Marshaling text to native string
			byte* native_text;
			var byteCount_text = 0;
			if (text != null)
			{
				byteCount_text = Encoding.UTF8.GetByteCount(text);
				if(byteCount_text > Utils.MaxStackallocSize)
				{
					native_text = Utils.Alloc<byte>(byteCount_text + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_text + 1];
					native_text = stackallocBytes;
				}
				var text_offset = Utils.EncodeStringUTF8(text, native_text, byteCount_text);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			// Marshaling textEnd to native string
			byte* native_textEnd;
			var byteCount_textEnd = 0;
			if (textEnd != null)
			{
				byteCount_textEnd = Encoding.UTF8.GetByteCount(textEnd);
				if(byteCount_textEnd > Utils.MaxStackallocSize)
				{
					native_textEnd = Utils.Alloc<byte>(byteCount_textEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_textEnd + 1];
					native_textEnd = stackallocBytes;
				}
				var textEnd_offset = Utils.EncodeStringUTF8(textEnd, native_textEnd, byteCount_textEnd);
				native_textEnd[textEnd_offset] = 0;
			}
			else native_textEnd = null;

			ImGuiNative.ImFontGlyphRangesBuilderAddText(NativePtr, native_text, native_textEnd);
			// Freeing text native string
			if (byteCount_text > Utils.MaxStackallocSize)
				Utils.Free(native_text);
			// Freeing textEnd native string
			if (byteCount_textEnd > Utils.MaxStackallocSize)
				Utils.Free(native_textEnd);
		}

		/// <summary>
		/// Add character<br/>
		/// </summary>
		public void AddChar(ushort c)
		{
			ImGuiNative.ImFontGlyphRangesBuilderAddChar(NativePtr, c);
		}

		/// <summary>
		/// Set bit n in the array<br/>
		/// </summary>
		public void SetBit(uint n)
		{
			ImGuiNative.ImFontGlyphRangesBuilderSetBit(NativePtr, n);
		}

		/// <summary>
		/// Get bit n in the array<br/>
		/// </summary>
		public byte GetBit(uint n)
		{
			return ImGuiNative.ImFontGlyphRangesBuilderGetBit(NativePtr, n);
		}

		public void Clear()
		{
			ImGuiNative.ImFontGlyphRangesBuilderClear(NativePtr);
		}

		public void Destroy()
		{
			ImGuiNative.ImFontGlyphRangesBuilderDestroy(NativePtr);
		}

		public void ImFontGlyphRangesBuilderConstruct()
		{
			ImGuiNative.ImFontGlyphRangesBuilderImFontGlyphRangesBuilderConstruct(NativePtr);
		}

		public ImFontGlyphRangesBuilderPtr ImFontGlyphRangesBuilder()
		{
			return ImGuiNative.ImFontGlyphRangesBuilderImFontGlyphRangesBuilder();
		}

	}
}
