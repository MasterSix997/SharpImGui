using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiDebugAllocInfo
	{
		public int TotalAllocCount;
		public int TotalFreeCount;
		public short LastEntriesIdx;
		public ImGuiDebugAllocEntry LastEntriesBuf_0;
		public ImGuiDebugAllocEntry LastEntriesBuf_1;
		public ImGuiDebugAllocEntry LastEntriesBuf_2;
		public ImGuiDebugAllocEntry LastEntriesBuf_3;
		public ImGuiDebugAllocEntry LastEntriesBuf_4;
		public ImGuiDebugAllocEntry LastEntriesBuf_5;
	}
}
