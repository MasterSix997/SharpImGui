using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiDebugAllocInfo
	{
		/// <summary>
		/// // Number of call to MemAlloc().
		/// </summary>
		public int TotalAllocCount;
		public int TotalFreeCount;
		/// <summary>
		/// // Current index in buffer
		/// </summary>
		public short LastEntriesIdx;
		/// <summary>
		/// // Track last 6 frames that had allocations
		/// </summary>
		public ImGuiDebugAllocEntry LastEntriesBuf_0;
		public ImGuiDebugAllocEntry LastEntriesBuf_1;
		public ImGuiDebugAllocEntry LastEntriesBuf_2;
		public ImGuiDebugAllocEntry LastEntriesBuf_3;
		public ImGuiDebugAllocEntry LastEntriesBuf_4;
		public ImGuiDebugAllocEntry LastEntriesBuf_5;
	}
}
