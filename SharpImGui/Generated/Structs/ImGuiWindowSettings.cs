using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiWindowSettings
	{
		public uint ID;
		public ImVec2ih Pos;
		public ImVec2ih Size;
		public ImVec2ih ViewportPos;
		public uint ViewportId;
		public uint DockId;
		public uint ClassId;
		public short DockOrder;
		public byte Collapsed;
		public byte IsChild;
		public byte WantApply;
		public byte WantDelete;
	}
}
