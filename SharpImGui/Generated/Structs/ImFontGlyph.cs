using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImFontGlyph
	{
		public uint Colored;
		public uint Visible;
		public uint Codepoint;
		public float AdvanceX;
		public float X0;
		public float Y0;
		public float X1;
		public float Y1;
		public float U0;
		public float V0;
		public float U1;
		public float V1;
	}
}
