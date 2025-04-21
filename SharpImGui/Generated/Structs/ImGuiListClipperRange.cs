using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiListClipperRange
	{
		public int Min;
		public int Max;
		public byte PosToIndexConvert;
		public sbyte PosToIndexOffsetMin;
		public sbyte PosToIndexOffsetMax;
	}
}
