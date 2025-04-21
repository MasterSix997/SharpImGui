using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImDrawData
	{
		public byte Valid;
		public int CmdListsCount;
		public int TotalIdxCount;
		public int TotalVtxCount;
		public ImVector<ImDrawListPtr> CmdLists;
		public Vector2 DisplayPos;
		public Vector2 DisplaySize;
		public Vector2 FramebufferScale;
		public unsafe ImGuiViewport* OwnerViewport;
	}
}
