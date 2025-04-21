using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiMenuColumns
	{
		public uint TotalWidth;
		public uint NextTotalWidth;
		public ushort Spacing;
		public ushort OffsetIcon;
		public ushort OffsetLabel;
		public ushort OffsetShortcut;
		public ushort OffsetMark;
		public ushort Widths_0;
		public ushort Widths_1;
		public ushort Widths_2;
		public ushort Widths_3;
	}
}
