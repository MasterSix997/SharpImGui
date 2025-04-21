using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImFontConfig
	{
		public unsafe void* FontData;
		public int FontDataSize;
		public byte FontDataOwnedByAtlas;
		public byte MergeMode;
		public byte PixelSnapH;
		public int FontNo;
		public int OversampleH;
		public int OversampleV;
		public float SizePixels;
		public Vector2 GlyphOffset;
		public unsafe ushort* GlyphRanges;
		public float GlyphMinAdvanceX;
		public float GlyphMaxAdvanceX;
		public float GlyphExtraAdvanceX;
		public uint FontBuilderFlags;
		public float RasterizerMultiply;
		public float RasterizerDensity;
		public ushort EllipsisChar;
		public byte Name_0;
		public byte Name_1;
		public byte Name_2;
		public byte Name_3;
		public byte Name_4;
		public byte Name_5;
		public byte Name_6;
		public byte Name_7;
		public byte Name_8;
		public byte Name_9;
		public byte Name_10;
		public byte Name_11;
		public byte Name_12;
		public byte Name_13;
		public byte Name_14;
		public byte Name_15;
		public byte Name_16;
		public byte Name_17;
		public byte Name_18;
		public byte Name_19;
		public byte Name_20;
		public byte Name_21;
		public byte Name_22;
		public byte Name_23;
		public byte Name_24;
		public byte Name_25;
		public byte Name_26;
		public byte Name_27;
		public byte Name_28;
		public byte Name_29;
		public byte Name_30;
		public byte Name_31;
		public byte Name_32;
		public byte Name_33;
		public byte Name_34;
		public byte Name_35;
		public byte Name_36;
		public byte Name_37;
		public byte Name_38;
		public byte Name_39;
		public unsafe ImFont* DstFont;
	}
}
