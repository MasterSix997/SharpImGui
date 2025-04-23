using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Load and rasterize multiple TTF/OTF fonts into a same texture. The font atlas will build a single texture holding:<br/>
	///  - One or more fonts.<br/>
	///  - Custom graphics data needed to render the shapes needed by Dear ImGui.<br/>
	///  - Mouse cursor shapes for software cursor rendering (unless setting 'Flags |= ImFontAtlasFlags_NoMouseCursors' in the font atlas).<br/>
	/// It is the user-code responsibility to setup/build the atlas, then upload the pixel data into a texture accessible by your graphics api.<br/>
	///  - Optionally, call any of the AddFont*** functions. If you don't call any, the default font embedded in the code will be loaded for you.<br/>
	///  - Call GetTexDataAsAlpha8() or GetTexDataAsRGBA32() to build and retrieve pixels data.<br/>
	///  - Upload the pixels data into a texture within your graphics system (see imgui_impl_xxxx.cpp examples)<br/>
	///  - Call SetTexID(my_tex_id); and pass the pointer/identifier to your texture in a format natural to your graphics API.<br/>
	///    This value will be passed back to you during rendering to identify the texture. Read FAQ entry about ImTextureID for more details.<br/>
	/// Common pitfalls:<br/>
	/// - If you pass a 'glyph_ranges' array to AddFont*** functions, you need to make sure that your array persist up until the<br/>
	///   atlas is build (when calling GetTexData*** or Build()). We only copy the pointer, not the data.<br/>
	/// - Important: By default, AddFontFromMemoryTTF() takes ownership of the data. Even though we are not writing to it, we will free the pointer on destruction.<br/>
	///   You can set font_cfg->FontDataOwnedByAtlas=false to keep ownership of your data and it won't be freed,<br/>
	/// - Even though many functions are suffixed with "TTF", OTF data is supported just as well.<br/>
	/// - This is an old API and it is currently awkward for those and various other reasons! We will address them in the future!<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImFontAtlas
	{
		/// <summary>
		///     Input<br/>
		/// Build flags (see ImFontAtlasFlags_)<br/>
		/// </summary>
		public ImFontAtlasFlags Flags;
		/// <summary>
		/// User data to refer to the texture once it has been uploaded to user's graphic systems. It is passed back to you during rendering via the ImDrawCmd structure.<br/>
		/// </summary>
		public IntPtr TexID;
		/// <summary>
		/// Texture width desired by user before Build(). Must be a power-of-two. If have many glyphs your graphics API have texture size restrictions you may want to increase texture width to decrease height.<br/>
		/// </summary>
		public int TexDesiredWidth;
		/// <summary>
		/// FIXME: Should be called "TexPackPadding". Padding between glyphs within texture in pixels. Defaults to 1. If your rendering method doesn't rely on bilinear filtering you may set this to 0 (will also need to set AntiAliasedLinesUseTex = false).<br/>
		/// </summary>
		public int TexGlyphPadding;
		/// <summary>
		/// Store your own atlas related user-data (if e.g. you have multiple font atlas).<br/>
		/// </summary>
		public unsafe void* UserData;
		/// <summary>
		///     [Internal]<br/>
		///     NB: Access texture data via GetTexData*() calls! Which will setup a default font for you.<br/>
		/// Marked as Locked by ImGui::NewFrame() so attempt to modify the atlas will assert.<br/>
		/// </summary>
		public byte Locked;
		/// <summary>
		/// Set when texture was built matching current font input<br/>
		/// </summary>
		public byte TexReady;
		/// <summary>
		/// Tell whether our texture data is known to use colors (rather than just alpha channel), in order to help backend select a format.<br/>
		/// </summary>
		public byte TexPixelsUseColors;
		/// <summary>
		/// 1 component per pixel, each component is unsigned 8-bit. Total size = TexWidth * TexHeight<br/>
		/// </summary>
		public unsafe byte* TexPixelsAlpha8;
		/// <summary>
		/// 4 component per pixel, each component is unsigned 8-bit. Total size = TexWidth * TexHeight * 4<br/>
		/// </summary>
		public unsafe uint* TexPixelsRGBA32;
		/// <summary>
		/// Texture width calculated during Build().<br/>
		/// </summary>
		public int TexWidth;
		/// <summary>
		/// Texture height calculated during Build().<br/>
		/// </summary>
		public int TexHeight;
		/// <summary>
		/// = (1.0f/TexWidth, 1.0f/TexHeight)<br/>
		/// </summary>
		public Vector2 TexUvScale;
		/// <summary>
		/// Texture coordinates to a white pixel<br/>
		/// </summary>
		public Vector2 TexUvWhitePixel;
		/// <summary>
		/// Hold all the fonts returned by AddFont*. Fonts[0] is the default font upon calling ImGui::NewFrame(), use ImGui::PushFont()/PopFont() to change the current font.<br/>
		/// </summary>
		public ImVector<ImFontPtr> Fonts;
		/// <summary>
		/// Rectangles for packing custom texture data into the atlas.<br/>
		/// </summary>
		public ImVector<ImFontAtlasCustomRect> CustomRects;
		/// <summary>
		/// Source/configuration data<br/>
		/// </summary>
		public ImVector<ImFontConfig> Sources;
		/// <summary>
		/// UVs for baked anti-aliased lines<br/>
		/// </summary>
		public Vector4 TexUvLines_0;
		public Vector4 TexUvLines_1;
		public Vector4 TexUvLines_2;
		public Vector4 TexUvLines_3;
		public Vector4 TexUvLines_4;
		public Vector4 TexUvLines_5;
		public Vector4 TexUvLines_6;
		public Vector4 TexUvLines_7;
		public Vector4 TexUvLines_8;
		public Vector4 TexUvLines_9;
		public Vector4 TexUvLines_10;
		public Vector4 TexUvLines_11;
		public Vector4 TexUvLines_12;
		public Vector4 TexUvLines_13;
		public Vector4 TexUvLines_14;
		public Vector4 TexUvLines_15;
		public Vector4 TexUvLines_16;
		public Vector4 TexUvLines_17;
		public Vector4 TexUvLines_18;
		public Vector4 TexUvLines_19;
		public Vector4 TexUvLines_20;
		public Vector4 TexUvLines_21;
		public Vector4 TexUvLines_22;
		public Vector4 TexUvLines_23;
		public Vector4 TexUvLines_24;
		public Vector4 TexUvLines_25;
		public Vector4 TexUvLines_26;
		public Vector4 TexUvLines_27;
		public Vector4 TexUvLines_28;
		public Vector4 TexUvLines_29;
		public Vector4 TexUvLines_30;
		public Vector4 TexUvLines_31;
		public Vector4 TexUvLines_32;
		/// <summary>
		///     [Internal] Font builder<br/>
		/// Opaque interface to a font builder (default to stb_truetype, can be changed to use FreeType by defining IMGUI_ENABLE_FREETYPE).<br/>
		/// </summary>
		public unsafe IntPtr* FontBuilderIO;
		/// <summary>
		/// Shared flags (for all fonts) for custom font builder. THIS IS BUILD IMPLEMENTATION DEPENDENT. Per-font override is also available in ImFontConfig.<br/>
		/// </summary>
		public uint FontBuilderFlags;
		/// <summary>
		///     [Internal] Packing data<br/>
		/// Custom texture rectangle ID for white pixel and mouse cursors<br/>
		/// </summary>
		public int PackIdMouseCursors;
		/// <summary>
		/// Custom texture rectangle ID for baked anti-aliased lines<br/>
		/// </summary>
		public int PackIdLines;
	}
}
