using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiComboPreviewData
	{
		public ImRect PreviewRect;
		public Vector2 BackupCursorPos;
		public Vector2 BackupCursorMaxPos;
		public Vector2 BackupCursorPosPrevLine;
		public float BackupPrevLineTextBaseOffset;
		public ImGuiLayoutType BackupLayout;
	}
}
