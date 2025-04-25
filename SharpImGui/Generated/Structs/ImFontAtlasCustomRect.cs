using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// See ImFontAtlas::AddCustomRectXXX functions.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImFontAtlasCustomRect
	{
		/// <summary>
		/// Output   Packed position in Atlas<br/>
		/// </summary>
		public ushort X;
		/// <summary>
		/// Output   Packed position in Atlas<br/>
		/// </summary>
		public ushort Y;
		/// <summary>
		///     [Internal]<br/>
		/// Input    Desired rectangle dimension<br/>
		/// </summary>
		public ushort Width;
		/// <summary>
		///     [Internal]<br/>
		/// Input    Desired rectangle dimension<br/>
		/// </summary>
		public ushort Height;
		/// <summary>
		/// Input    For custom font glyphs only (ID &lt; 0x110000)<br/>
		/// </summary>
		public uint GlyphID;
		/// <summary>
		/// Input  For custom font glyphs only: glyph is colored, removed tinting.<br/>
		/// </summary>
		public uint GlyphColored;
		/// <summary>
		/// Input    For custom font glyphs only: glyph xadvance<br/>
		/// </summary>
		public float GlyphAdvanceX;
		/// <summary>
		/// Input    For custom font glyphs only: glyph display offset<br/>
		/// </summary>
		public Vector2 GlyphOffset;
		/// <summary>
		/// Input    For custom font glyphs only: target font<br/>
		/// </summary>
		public unsafe ImFont* Font;
	}

	/// <summary>
	/// See ImFontAtlas::AddCustomRectXXX functions.<br/>
	/// </summary>
	public unsafe partial struct ImFontAtlasCustomRectPtr
	{
		public ImFontAtlasCustomRect* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImFontAtlasCustomRect this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImFontAtlasCustomRectPtr(ImFontAtlasCustomRect* nativePtr) => NativePtr = nativePtr;
		public ImFontAtlasCustomRectPtr(IntPtr nativePtr) => NativePtr = (ImFontAtlasCustomRect*)nativePtr;
		public static implicit operator ImFontAtlasCustomRectPtr(ImFontAtlasCustomRect* ptr) => new ImFontAtlasCustomRectPtr(ptr);
		public static implicit operator ImFontAtlasCustomRectPtr(IntPtr ptr) => new ImFontAtlasCustomRectPtr(ptr);
		public static implicit operator ImFontAtlasCustomRect*(ImFontAtlasCustomRectPtr nativePtr) => nativePtr.NativePtr;
	}
}
