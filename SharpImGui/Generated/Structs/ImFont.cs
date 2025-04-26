using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Font runtime data and rendering<br/>ImFontAtlas automatically loads a default embedded font for you when you call GetTexDataAsAlpha8() or GetTexDataAsRGBA32().<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImFont
	{
		/// <summary>
		/// <br/>    [Internal] Members: Hot ~20/24 bytes (for CalcTextSize)<br/>
		/// 12-16 out Sparse. Glyphs-&gt;AdvanceX in a directly indexable way (cache-friendly for CalcTextSize functions which only this info, and are often bottleneck in large UI).<br/>
		/// </summary>
		public ImVector<float> IndexAdvanceX;
		/// <summary>
		/// 4     out = FallbackGlyph-&gt;AdvanceX<br/>
		/// </summary>
		public float FallbackAdvanceX;
		/// <summary>
		/// 4     in  Height of characters/line, set during loading (don't change after loading)<br/>
		/// </summary>
		public float FontSize;
		/// <summary>
		///     [Internal] Members: Hot ~28/40 bytes (for RenderText loop)<br/>
		/// 12-16 out Sparse. Index glyphs by Unicode code-point.<br/>
		/// </summary>
		public ImVector<ushort> IndexLookup;
		/// <summary>
		/// 12-16 out All glyphs.<br/>
		/// </summary>
		public ImVector<ImFontGlyph> Glyphs;
		/// <summary>
		/// 4-8   out = FindGlyph(FontFallbackChar)<br/>
		/// </summary>
		public unsafe ImFontGlyph* FallbackGlyph;
		/// <summary>
		///     [Internal] Members: Cold ~32/40 bytes<br/>    Conceptually Sources[] is the list of font sources merged to create this font.<br/>
		/// 4-8   out What we has been loaded into<br/>
		/// </summary>
		public unsafe ImFontAtlas* ContainerAtlas;
		/// <summary>
		/// 4-8   in  Pointer within ContainerAtlas-&gt;Sources[], to SourcesCount instances<br/>
		/// </summary>
		public unsafe ImFontConfig* Sources;
		/// <summary>
		/// 2     in  Number of ImFontConfig involved in creating this font. Usually 1, or &gt;1 when merging multiple font sources into one ImFont.<br/>
		/// </summary>
		public short SourcesCount;
		/// <summary>
		/// 1     out 1 or 3<br/>
		/// </summary>
		public short EllipsisCharCount;
		/// <summary>
		/// 2-4   out Character used for ellipsis rendering ('...').<br/>
		/// </summary>
		public ushort EllipsisChar;
		/// <summary>
		/// 2-4   out Character used if a glyph isn't found (U+FFFD, '?')<br/>
		/// </summary>
		public ushort FallbackChar;
		/// <summary>
		/// 4     out Total ellipsis Width<br/>
		/// </summary>
		public float EllipsisWidth;
		/// <summary>
		/// 4     out Step between characters when EllipsisCount &gt; 0<br/>
		/// </summary>
		public float EllipsisCharStep;
		/// <summary>
		/// 4     in  Base font scale (1.0f), multiplied by the per-window font scale which you can adjust with SetWindowFontScale()<br/>
		/// </summary>
		public float Scale;
		/// <summary>
		/// 4+4   out Ascent: distance from top to bottom of e.g. 'A' [0..FontSize] (unscaled)<br/>
		/// </summary>
		public float Ascent;
		/// <summary>
		/// 4+4   out Ascent: distance from top to bottom of e.g. 'A' [0..FontSize] (unscaled)<br/>
		/// </summary>
		public float Descent;
		/// <summary>
		/// 4     out Total surface in pixels to get an idea of the font rasterization/texture cost (not exact, we approximate the cost of padding between glyphs)<br/>
		/// </summary>
		public int MetricsTotalSurface;
		/// <summary>
		/// 1     out //<br/>
		/// </summary>
		public byte DirtyLookupTables;
		/// <summary>
		/// 1 bytes if ImWchar=ImWchar16, 16 bytes if ImWchar==ImWchar32. Store 1-bit for each block of 4K codepoints that has one active glyph. This is mainly used to facilitate iterations across all used codepoints.<br/>
		/// </summary>
		public byte Used8KPagesMap_0;
	}

	/// <summary>
	/// Font runtime data and rendering<br/>ImFontAtlas automatically loads a default embedded font for you when you call GetTexDataAsAlpha8() or GetTexDataAsRGBA32().<br/>
	/// </summary>
	public unsafe partial struct ImFontPtr
	{
		public ImFont* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImFont this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// <br/>    [Internal] Members: Hot ~20/24 bytes (for CalcTextSize)<br/>
		/// 12-16 out Sparse. Glyphs-&gt;AdvanceX in a directly indexable way (cache-friendly for CalcTextSize functions which only this info, and are often bottleneck in large UI).<br/>
		/// </summary>
		public ref ImVector<float> IndexAdvanceX => ref Unsafe.AsRef<ImVector<float>>(&NativePtr->IndexAdvanceX);
		/// <summary>
		/// 4     out = FallbackGlyph-&gt;AdvanceX<br/>
		/// </summary>
		public ref float FallbackAdvanceX => ref Unsafe.AsRef<float>(&NativePtr->FallbackAdvanceX);
		/// <summary>
		/// 4     in  Height of characters/line, set during loading (don't change after loading)<br/>
		/// </summary>
		public ref float FontSize => ref Unsafe.AsRef<float>(&NativePtr->FontSize);
		/// <summary>
		///     [Internal] Members: Hot ~28/40 bytes (for RenderText loop)<br/>
		/// 12-16 out Sparse. Index glyphs by Unicode code-point.<br/>
		/// </summary>
		public ref ImVector<ushort> IndexLookup => ref Unsafe.AsRef<ImVector<ushort>>(&NativePtr->IndexLookup);
		/// <summary>
		/// 12-16 out All glyphs.<br/>
		/// </summary>
		public ref ImVector<ImFontGlyph> Glyphs => ref Unsafe.AsRef<ImVector<ImFontGlyph>>(&NativePtr->Glyphs);
		/// <summary>
		/// 4-8   out = FindGlyph(FontFallbackChar)<br/>
		/// </summary>
		public ref ImFontGlyphPtr FallbackGlyph => ref Unsafe.AsRef<ImFontGlyphPtr>(&NativePtr->FallbackGlyph);
		/// <summary>
		///     [Internal] Members: Cold ~32/40 bytes<br/>    Conceptually Sources[] is the list of font sources merged to create this font.<br/>
		/// 4-8   out What we has been loaded into<br/>
		/// </summary>
		public ref ImFontAtlasPtr ContainerAtlas => ref Unsafe.AsRef<ImFontAtlasPtr>(&NativePtr->ContainerAtlas);
		/// <summary>
		/// 4-8   in  Pointer within ContainerAtlas-&gt;Sources[], to SourcesCount instances<br/>
		/// </summary>
		public ref ImFontConfigPtr Sources => ref Unsafe.AsRef<ImFontConfigPtr>(&NativePtr->Sources);
		/// <summary>
		/// 2     in  Number of ImFontConfig involved in creating this font. Usually 1, or &gt;1 when merging multiple font sources into one ImFont.<br/>
		/// </summary>
		public ref short SourcesCount => ref Unsafe.AsRef<short>(&NativePtr->SourcesCount);
		/// <summary>
		/// 1     out 1 or 3<br/>
		/// </summary>
		public ref short EllipsisCharCount => ref Unsafe.AsRef<short>(&NativePtr->EllipsisCharCount);
		/// <summary>
		/// 2-4   out Character used for ellipsis rendering ('...').<br/>
		/// </summary>
		public ref ushort EllipsisChar => ref Unsafe.AsRef<ushort>(&NativePtr->EllipsisChar);
		/// <summary>
		/// 2-4   out Character used if a glyph isn't found (U+FFFD, '?')<br/>
		/// </summary>
		public ref ushort FallbackChar => ref Unsafe.AsRef<ushort>(&NativePtr->FallbackChar);
		/// <summary>
		/// 4     out Total ellipsis Width<br/>
		/// </summary>
		public ref float EllipsisWidth => ref Unsafe.AsRef<float>(&NativePtr->EllipsisWidth);
		/// <summary>
		/// 4     out Step between characters when EllipsisCount &gt; 0<br/>
		/// </summary>
		public ref float EllipsisCharStep => ref Unsafe.AsRef<float>(&NativePtr->EllipsisCharStep);
		/// <summary>
		/// 4     in  Base font scale (1.0f), multiplied by the per-window font scale which you can adjust with SetWindowFontScale()<br/>
		/// </summary>
		public ref float Scale => ref Unsafe.AsRef<float>(&NativePtr->Scale);
		/// <summary>
		/// 4+4   out Ascent: distance from top to bottom of e.g. 'A' [0..FontSize] (unscaled)<br/>
		/// </summary>
		public ref float Ascent => ref Unsafe.AsRef<float>(&NativePtr->Ascent);
		/// <summary>
		/// 4+4   out Ascent: distance from top to bottom of e.g. 'A' [0..FontSize] (unscaled)<br/>
		/// </summary>
		public ref float Descent => ref Unsafe.AsRef<float>(&NativePtr->Descent);
		/// <summary>
		/// 4     out Total surface in pixels to get an idea of the font rasterization/texture cost (not exact, we approximate the cost of padding between glyphs)<br/>
		/// </summary>
		public ref int MetricsTotalSurface => ref Unsafe.AsRef<int>(&NativePtr->MetricsTotalSurface);
		/// <summary>
		/// 1     out //<br/>
		/// </summary>
		public ref bool DirtyLookupTables => ref Unsafe.AsRef<bool>(&NativePtr->DirtyLookupTables);
		/// <summary>
		/// 1 bytes if ImWchar=ImWchar16, 16 bytes if ImWchar==ImWchar32. Store 1-bit for each block of 4K codepoints that has one active glyph. This is mainly used to facilitate iterations across all used codepoints.<br/>
		/// </summary>
		public Span<byte> Used8KPagesMap => new Span<byte>(&NativePtr->Used8KPagesMap_0, 1);
		public ImFontPtr(ImFont* nativePtr) => NativePtr = nativePtr;
		public ImFontPtr(IntPtr nativePtr) => NativePtr = (ImFont*)nativePtr;
		public static implicit operator ImFontPtr(ImFont* ptr) => new ImFontPtr(ptr);
		public static implicit operator ImFontPtr(IntPtr ptr) => new ImFontPtr(ptr);
		public static implicit operator ImFont*(ImFontPtr nativePtr) => nativePtr.NativePtr;
		public byte IsGlyphRangeUnused(uint cBegin, uint cLast)
		{
			return ImGuiNative.ImFontIsGlyphRangeUnused(NativePtr, cBegin, cLast);
		}

		/// <summary>
		/// Makes 'dst' character/glyph points to 'src' character/glyph. Currently needs to be called AFTER fonts have been built.<br/>
		/// </summary>
		public void AddRemapChar(ushort dst, ushort src, bool overwriteDst)
		{
			var native_overwriteDst = overwriteDst ? (byte)1 : (byte)0;
			ImGuiNative.ImFontAddRemapChar(NativePtr, dst, src, native_overwriteDst);
		}

		public void AddGlyph(ImFontConfigPtr srcCfg, ushort c, float x0, float y0, float x1, float y1, float u0, float v0, float u1, float v1, float advanceX)
		{
			ImGuiNative.ImFontAddGlyph(NativePtr, srcCfg, c, x0, y0, x1, y1, u0, v0, u1, v1, advanceX);
		}

		public void GrowIndex(int newSize)
		{
			ImGuiNative.ImFontGrowIndex(NativePtr, newSize);
		}

		public void ClearOutputData()
		{
			ImGuiNative.ImFontClearOutputData(NativePtr);
		}

		public void BuildLookupTable()
		{
			ImGuiNative.ImFontBuildLookupTable(NativePtr);
		}

		public void RenderText(ImDrawListPtr drawList, float size, Vector2 pos, uint col, Vector4 clipRect, ReadOnlySpan<char> textBegin, ReadOnlySpan<char> textEnd, float wrapWidth, bool cpuFineClip)
		{
			// Marshaling textBegin to native string
			byte* native_textBegin;
			var byteCount_textBegin = 0;
			if (textBegin != null)
			{
				byteCount_textBegin = Encoding.UTF8.GetByteCount(textBegin);
				if(byteCount_textBegin > Utils.MaxStackallocSize)
				{
					native_textBegin = Utils.Alloc<byte>(byteCount_textBegin + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_textBegin + 1];
					native_textBegin = stackallocBytes;
				}
				var textBegin_offset = Utils.EncodeStringUTF8(textBegin, native_textBegin, byteCount_textBegin);
				native_textBegin[textBegin_offset] = 0;
			}
			else native_textBegin = null;

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

			var native_cpuFineClip = cpuFineClip ? (byte)1 : (byte)0;
			ImGuiNative.ImFontRenderText(NativePtr, drawList, size, pos, col, clipRect, native_textBegin, native_textEnd, wrapWidth, native_cpuFineClip);
			// Freeing textBegin native string
			if (byteCount_textBegin > Utils.MaxStackallocSize)
				Utils.Free(native_textBegin);
			// Freeing textEnd native string
			if (byteCount_textEnd > Utils.MaxStackallocSize)
				Utils.Free(native_textEnd);
		}

		public void RenderChar(ImDrawListPtr drawList, float size, Vector2 pos, uint col, ushort c)
		{
			ImGuiNative.ImFontRenderChar(NativePtr, drawList, size, pos, col, c);
		}

		public ref byte CalcWordWrapPositionA(float scale, ReadOnlySpan<char> text, ReadOnlySpan<char> textEnd, float wrapWidth)
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

			var nativeResult = ImGuiNative.ImFontCalcWordWrapPositionA(NativePtr, scale, native_text, native_textEnd, wrapWidth);
			// Freeing text native string
			if (byteCount_text > Utils.MaxStackallocSize)
				Utils.Free(native_text);
			// Freeing textEnd native string
			if (byteCount_textEnd > Utils.MaxStackallocSize)
				Utils.Free(native_textEnd);
			return ref *(byte*)&nativeResult;
		}

		/// <summary>
		/// utf8<br/>
		/// </summary>
		public void CalcTextSizeA(ref Vector2 pOut, float size, float maxWidth, float wrapWidth, ReadOnlySpan<char> textBegin, ReadOnlySpan<char> textEnd, ref byte* remaining)
		{
			// Marshaling textBegin to native string
			byte* native_textBegin;
			var byteCount_textBegin = 0;
			if (textBegin != null)
			{
				byteCount_textBegin = Encoding.UTF8.GetByteCount(textBegin);
				if(byteCount_textBegin > Utils.MaxStackallocSize)
				{
					native_textBegin = Utils.Alloc<byte>(byteCount_textBegin + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_textBegin + 1];
					native_textBegin = stackallocBytes;
				}
				var textBegin_offset = Utils.EncodeStringUTF8(textBegin, native_textBegin, byteCount_textBegin);
				native_textBegin[textBegin_offset] = 0;
			}
			else native_textBegin = null;

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

			fixed (Vector2* native_pOut = &pOut)
			fixed (byte** native_remaining = &remaining)
			{
				ImGuiNative.ImFontCalcTextSizeA(native_pOut, NativePtr, size, maxWidth, wrapWidth, native_textBegin, native_textEnd, native_remaining);
				// Freeing textBegin native string
				if (byteCount_textBegin > Utils.MaxStackallocSize)
					Utils.Free(native_textBegin);
				// Freeing textEnd native string
				if (byteCount_textEnd > Utils.MaxStackallocSize)
					Utils.Free(native_textEnd);
			}
		}

		public ref byte GetDebugName()
		{
			var nativeResult = ImGuiNative.ImFontGetDebugName(NativePtr);
			return ref *(byte*)&nativeResult;
		}

		public byte IsLoaded()
		{
			return ImGuiNative.ImFontIsLoaded(NativePtr);
		}

		public float GetCharAdvance(ushort c)
		{
			return ImGuiNative.ImFontGetCharAdvance(NativePtr, c);
		}

		public ImFontGlyphPtr FindGlyphNoFallback(ushort c)
		{
			return ImGuiNative.ImFontFindGlyphNoFallback(NativePtr, c);
		}

		public ImFontGlyphPtr FindGlyph(ushort c)
		{
			return ImGuiNative.ImFontFindGlyph(NativePtr, c);
		}

		public void Destroy()
		{
			ImGuiNative.ImFontDestroy(NativePtr);
		}

		public void ImFontConstruct()
		{
			ImGuiNative.ImFontImFontConstruct(NativePtr);
		}

		public ImFontPtr ImFont()
		{
			return ImGuiNative.ImFontImFont();
		}

	}
}
