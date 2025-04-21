using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiKeyRoutingData
	{
		public short NextEntryIndex;
		public ushort Mods;
		public byte RoutingCurrScore;
		public byte RoutingNextScore;
		public uint RoutingCurr;
		public uint RoutingNext;
	}
}
