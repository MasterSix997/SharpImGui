using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// We don't store style.Alpha: dock_node->LastBgColor embeds it and otherwise it would only affect the docking tab, which intuitively I would say we don't want to.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiWindowDockStyle
	{
		public uint Colors_0;
		public uint Colors_1;
		public uint Colors_2;
		public uint Colors_3;
		public uint Colors_4;
		public uint Colors_5;
		public uint Colors_6;
		public uint Colors_7;
	}
}
