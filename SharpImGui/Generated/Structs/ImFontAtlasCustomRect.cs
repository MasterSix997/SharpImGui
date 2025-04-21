using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImFontAtlasCustomRect
	{
		public ushort X;
		public ushort Y;
		public ushort Width;
		public ushort Height;
		public uint GlyphID;
		public uint GlyphColored;
		public float GlyphAdvanceX;
		public Vector2 GlyphOffset;
		public unsafe ImFont* Font;
	}
}
