using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiDebugAllocEntry
	{
		public int FrameCount;
		public short AllocCount;
		public short FreeCount;
	}
}
