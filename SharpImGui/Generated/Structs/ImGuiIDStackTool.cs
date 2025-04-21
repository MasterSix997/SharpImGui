using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiIDStackTool
	{
		public int LastActiveFrame;
		public int StackLevel;
		public uint QueryId;
		public ImVector<ImGuiStackLevelInfo> Results;
		public byte CopyToClipboardOnCtrlC;
		public float CopyToClipboardLastTime;
		public ImGuiTextBuffer ResultPathBuf;
	}
}
