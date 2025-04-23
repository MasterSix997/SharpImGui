using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Helper to build glyph ranges from text/string data. Feed your application strings/characters to it then call BuildRanges().<br/>
	/// This is essentially a tightly packed of vector of 64k booleans = 8KB storage.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImFontGlyphRangesBuilder
	{
		/// <summary>
		/// Store 1-bit per Unicode code point (0=unused, 1=used)<br/>
		/// </summary>
		public ImVector<uint> UsedChars;
	}
}
