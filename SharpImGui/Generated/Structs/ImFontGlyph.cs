using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Hold rendering data for one glyph.<br/>(Note: some language parsers may fail to convert the 31+1 bitfield members, in this case maybe drop store a single u32 or we can rework this)<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImFontGlyph
	{
		/// <summary>
		/// Flag to indicate glyph is colored and should generally ignore tinting (make it usable with no shift on little-endian as this is used in loops)<br/>
		/// </summary>
		public uint Colored;
		/// <summary>
		/// Flag to indicate glyph has no visible pixels (e.g. space). Allow early out when rendering.<br/>
		/// </summary>
		public uint Visible;
		/// <summary>
		/// 0x0000..0x10FFFF<br/>
		/// </summary>
		public uint Codepoint;
		/// <summary>
		/// Horizontal distance to advance layout with<br/>
		/// </summary>
		public float AdvanceX;
		/// <summary>
		/// Glyph corners<br/>
		/// </summary>
		public float X0;
		/// <summary>
		/// Glyph corners<br/>
		/// </summary>
		public float Y0;
		/// <summary>
		/// Glyph corners<br/>
		/// </summary>
		public float X1;
		/// <summary>
		/// Glyph corners<br/>
		/// </summary>
		public float Y1;
		/// <summary>
		/// Texture coordinates<br/>
		/// </summary>
		public float U0;
		/// <summary>
		/// Texture coordinates<br/>
		/// </summary>
		public float V0;
		/// <summary>
		/// Texture coordinates<br/>
		/// </summary>
		public float U1;
		/// <summary>
		/// Texture coordinates<br/>
		/// </summary>
		public float V1;
	}

	/// <summary>
	/// Hold rendering data for one glyph.<br/>(Note: some language parsers may fail to convert the 31+1 bitfield members, in this case maybe drop store a single u32 or we can rework this)<br/>
	/// </summary>
	public unsafe partial struct ImFontGlyphPtr
	{
		public ImFontGlyph* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImFontGlyph this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImFontGlyphPtr(ImFontGlyph* nativePtr) => NativePtr = nativePtr;
		public ImFontGlyphPtr(IntPtr nativePtr) => NativePtr = (ImFontGlyph*)nativePtr;
		public static implicit operator ImFontGlyphPtr(ImFontGlyph* ptr) => new ImFontGlyphPtr(ptr);
		public static implicit operator ImFontGlyphPtr(IntPtr ptr) => new ImFontGlyphPtr(ptr);
		public static implicit operator ImFontGlyph*(ImFontGlyphPtr nativePtr) => nativePtr.NativePtr;
	}
}
