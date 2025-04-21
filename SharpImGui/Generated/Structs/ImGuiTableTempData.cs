using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTableTempData
	{
		public int TableIndex;
		public float LastTimeActive;
		public float AngledHeadersExtraWidth;
		public ImVector<ImGuiTableHeaderData> AngledHeadersRequests;
		public Vector2 UserOuterSize;
		public ImDrawListSplitter DrawSplitter;
		public ImRect HostBackupWorkRect;
		public ImRect HostBackupParentWorkRect;
		public Vector2 HostBackupPrevLineSize;
		public Vector2 HostBackupCurrLineSize;
		public Vector2 HostBackupCursorMaxPos;
		public ImVec1 HostBackupColumnsOffset;
		public float HostBackupItemWidth;
		public int HostBackupItemWidthStackSize;
	}
}
