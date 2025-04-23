using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Data used by IsItemDeactivated()/IsItemDeactivatedAfterEdit() functions<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiDeactivatedItemData
	{
		public uint ID;
		public int ElapseFrame;
		public byte HasBeenEditedBefore;
		public byte IsAlive;
	}
}
