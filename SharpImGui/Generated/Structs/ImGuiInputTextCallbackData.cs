using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiInputTextCallbackData
	{
		public unsafe ImGuiContext* Ctx;
		public ImGuiInputTextFlags EventFlag;
		public ImGuiInputTextFlags Flags;
		public unsafe void* UserData;
		public ushort EventChar;
		public ImGuiKey EventKey;
		public unsafe byte* Buf;
		public int BufTextLen;
		public int BufSize;
		public byte BufDirty;
		public int CursorPos;
		public int SelectionStart;
		public int SelectionEnd;
	}
}
