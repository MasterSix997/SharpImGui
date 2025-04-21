using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiInputTextState
	{
		public unsafe ImGuiContext* Ctx;
		public unsafe STB_TexteditState* Stb;
		public ImGuiInputTextFlags Flags;
		public uint ID;
		public int TextLen;
		public unsafe byte* TextSrc;
		public ImVector<byte> TextA;
		public ImVector<byte> TextToRevertTo;
		public ImVector<byte> CallbackTextBackup;
		public int BufCapacity;
		public Vector2 Scroll;
		public float CursorAnim;
		public byte CursorFollow;
		public byte SelectedAllMouseLock;
		public byte Edited;
		public byte WantReloadUserBuf;
		public int ReloadSelectionStart;
		public int ReloadSelectionEnd;
	}
}
