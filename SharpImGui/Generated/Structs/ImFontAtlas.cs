using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImFontAtlas
	{
		public ImFontAtlasFlags Flags;
		public IntPtr TexID;
		public int TexDesiredWidth;
		public int TexGlyphPadding;
		public unsafe void* UserData;
		public byte Locked;
		public byte TexReady;
		public byte TexPixelsUseColors;
		public unsafe byte* TexPixelsAlpha8;
		public unsafe uint* TexPixelsRGBA32;
		public int TexWidth;
		public int TexHeight;
		public Vector2 TexUvScale;
		public Vector2 TexUvWhitePixel;
		public ImVector<ImFontPtr> Fonts;
		public ImVector<ImFontAtlasCustomRect> CustomRects;
		public ImVector<ImFontConfig> Sources;
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
		public unsafe IntPtr* FontBuilderIO;
		public uint FontBuilderFlags;
		public int PackIdMouseCursors;
		public int PackIdLines;
	}
}
