using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiDeactivatedItemData
	{
		public uint ID;
		public int ElapseFrame;
		public byte HasBeenEditedBefore;
		public byte IsAlive;
	}
}
