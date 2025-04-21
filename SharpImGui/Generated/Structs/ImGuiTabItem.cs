using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTabItem
	{
		public uint ID;
		public ImGuiTabItemFlags Flags;
		public unsafe ImGuiWindow* Window;
		public int LastFrameVisible;
		public int LastFrameSelected;
		public float Offset;
		public float Width;
		public float ContentWidth;
		public float RequestedWidth;
		public int NameOffset;
		public short BeginOrder;
		public short IndexDuringLayout;
		public byte WantClose;
	}
}
