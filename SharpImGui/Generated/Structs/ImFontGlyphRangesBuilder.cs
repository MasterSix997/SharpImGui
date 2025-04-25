using System;
using System.Numerics;
using System.Runtime.InteropServices;

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
		public ImFontGlyphRangesBuilderPtr(ImFontGlyphRangesBuilder* nativePtr) => NativePtr = nativePtr;
		public ImFontGlyphRangesBuilderPtr(IntPtr nativePtr) => NativePtr = (ImFontGlyphRangesBuilder*)nativePtr;
		public static implicit operator ImFontGlyphRangesBuilderPtr(ImFontGlyphRangesBuilder* ptr) => new ImFontGlyphRangesBuilderPtr(ptr);
		public static implicit operator ImFontGlyphRangesBuilderPtr(IntPtr ptr) => new ImFontGlyphRangesBuilderPtr(ptr);
		public static implicit operator ImFontGlyphRangesBuilder*(ImFontGlyphRangesBuilderPtr nativePtr) => nativePtr.NativePtr;
	}
}
