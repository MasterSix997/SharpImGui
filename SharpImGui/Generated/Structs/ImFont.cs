using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImFont
	{
		public ImVector<float> IndexAdvanceX;
		public float FallbackAdvanceX;
		public float FontSize;
		public ImVector<ushort> IndexLookup;
		public ImVector<ImFontGlyph> Glyphs;
		public unsafe ImFontGlyph* FallbackGlyph;
		public unsafe ImFontAtlas* ContainerAtlas;
		public unsafe ImFontConfig* Sources;
		public short SourcesCount;
		public short EllipsisCharCount;
		public ushort EllipsisChar;
		public ushort FallbackChar;
		public float EllipsisWidth;
		public float EllipsisCharStep;
		public float Scale;
		public float Ascent;
		public float Descent;
		public int MetricsTotalSurface;
		public byte DirtyLookupTables;
		public byte Used8kPagesMap_0;
	}

	public unsafe struct ImFontPtr
	{
		public ImFont* NativePtr;
	}
}
