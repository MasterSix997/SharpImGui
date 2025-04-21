using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiMultiSelectTempData
	{
		public ImGuiMultiSelectIO IO;
		public unsafe ImGuiMultiSelectState* Storage;
		public uint FocusScopeId;
		public ImGuiMultiSelectFlags Flags;
		public Vector2 ScopeRectMin;
		public Vector2 BackupCursorMaxPos;
		public long LastSubmittedItem;
		public uint BoxSelectId;
		public ImGuiKey KeyMods;
		public sbyte LoopRequestSetAll;
		public byte IsEndIO;
		public byte IsFocused;
		public byte IsKeyboardSetRange;
		public byte NavIdPassedBy;
		public byte RangeSrcPassedBy;
		public byte RangeDstPassedBy;
	}
}
