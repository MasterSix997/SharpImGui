using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTableHeaderData
	{
		public short Index;
		public uint TextColor;
		public uint BgColor0;
		public uint BgColor1;
	}
}
