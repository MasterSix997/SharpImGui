using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiOldColumns
	{
		public uint ID;
		public ImGuiOldColumnFlags Flags;
		public byte IsFirstFrame;
		public byte IsBeingResized;
		public int Current;
		public int Count;
		public float OffMinX;
		public float OffMaxX;
		public float LineMinY;
		public float LineMaxY;
		public float HostCursorPosY;
		public float HostCursorMaxPosX;
		public ImRect HostInitialClipRect;
		public ImRect HostBackupClipRect;
		public ImRect HostBackupParentWorkRect;
		public ImVector<ImGuiOldColumnData> Columns;
		public ImDrawListSplitter Splitter;
	}
}
