using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Routing table entry (sizeof() == 16 bytes)<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiKeyRoutingData
	{
		public short NextEntryIndex;
		/// <summary>
		/// Technically we'd only need 4-bits but for simplify we store ImGuiMod_ values which need 16-bits.<br/>
		/// </summary>
		public ushort Mods;
		/// <summary>
		/// [DEBUG] For debug display<br/>
		/// </summary>
		public byte RoutingCurrScore;
		/// <summary>
		/// Lower is better (0: perfect score)<br/>
		/// </summary>
		public byte RoutingNextScore;
		public uint RoutingCurr;
		public uint RoutingNext;
	}
}
