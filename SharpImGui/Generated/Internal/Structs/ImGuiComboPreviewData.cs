using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Storage data for BeginComboPreview()/EndComboPreview()<br/>
	/// </summary>
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
