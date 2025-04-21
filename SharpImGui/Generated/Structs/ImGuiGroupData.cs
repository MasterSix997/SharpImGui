using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiGroupData
	{
		public uint WindowID;
		public Vector2 BackupCursorPos;
		public Vector2 BackupCursorMaxPos;
		public Vector2 BackupCursorPosPrevLine;
		public ImVec1 BackupIndent;
		public ImVec1 BackupGroupOffset;
		public Vector2 BackupCurrLineSize;
		public float BackupCurrLineTextBaseOffset;
		public uint BackupActiveIdIsAlive;
		public byte BackupDeactivatedIdIsAlive;
		public byte BackupHoveredIdIsAlive;
		public byte BackupIsSameLine;
		public byte EmitItem;
	}
}
