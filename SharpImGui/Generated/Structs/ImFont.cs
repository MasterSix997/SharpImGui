using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Font runtime data and rendering<br/>
	/// ImFontAtlas automatically loads a default embedded font for you when you call GetTexDataAsAlpha8() or GetTexDataAsRGBA32().<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImFont
	{
		/// <summary>
		/// <br/>
		///     [Internal] Members: Hot ~20/24 bytes (for CalcTextSize)<br/>
		/// 12-16 out Sparse. Glyphs->AdvanceX in a directly indexable way (cache-friendly for CalcTextSize functions which only this info, and are often bottleneck in large UI).<br/>
		/// </summary>
		public ImVector<float> IndexAdvanceX;
		/// <summary>
		/// 4     out = FallbackGlyph->AdvanceX<br/>
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
		///     [Internal] Members: Cold ~32/40 bytes<br/>
		///     Conceptually Sources[] is the list of font sources merged to create this font.<br/>
		/// 4-8   out What we has been loaded into<br/>
		/// </summary>
		public unsafe ImFontAtlas* ContainerAtlas;
		/// <summary>
		/// 4-8   in  Pointer within ContainerAtlas->Sources[], to SourcesCount instances<br/>
		/// </summary>
		public unsafe ImFontConfig* Sources;
		/// <summary>
		/// 2     in  Number of ImFontConfig involved in creating this font. Usually 1, or >1 when merging multiple font sources into one ImFont.<br/>
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
		/// 4     out Step between characters when EllipsisCount > 0<br/>
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
		public byte Used8kPagesMap_0;
	}

	public unsafe struct ImFontPtr
	{
		public ImFont* NativePtr;
	}
}
