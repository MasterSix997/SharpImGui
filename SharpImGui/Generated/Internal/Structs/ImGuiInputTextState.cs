using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Internal state of the currently focused/edited text input box<br/>
	/// For a given item ID, access with ImGui::GetInputTextState()<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiInputTextState
	{
		/// <summary>
		/// parent UI context (needs to be set explicitly by parent).<br/>
		/// </summary>
		public IntPtr Ctx;
		/// <summary>
		/// State for stb_textedit.h<br/>
		/// </summary>
		public unsafe void* Stb;
		/// <summary>
		/// copy of InputText() flags. may be used to check if e.g. ImGuiInputTextFlags_Password is set.<br/>
		/// </summary>
		public ImGuiInputTextFlags Flags;
		/// <summary>
		/// widget id owning the text state<br/>
		/// </summary>
		public uint ID;
		/// <summary>
		/// UTF-8 length of the string in TextA (in bytes)<br/>
		/// </summary>
		public int TextLen;
		/// <summary>
		/// == TextA.Data unless read-only, in which case == buf passed to InputText(). Field only set and valid _inside_ the call InputText() call.<br/>
		/// </summary>
		public unsafe byte* TextSrc;
		/// <summary>
		/// main UTF8 buffer. TextA.Size is a buffer size! Should always be >= buf_size passed by user (and of course >= CurLenA + 1).<br/>
		/// </summary>
		public ImVector<byte> TextA;
		/// <summary>
		/// value to revert to when pressing Escape = backup of end-user buffer at the time of focus (in UTF-8, unaltered)<br/>
		/// </summary>
		public ImVector<byte> TextToRevertTo;
		/// <summary>
		/// temporary storage for callback to support automatic reconcile of undo-stack<br/>
		/// </summary>
		public ImVector<byte> CallbackTextBackup;
		/// <summary>
		/// end-user buffer capacity (include zero terminator)<br/>
		/// </summary>
		public int BufCapacity;
		/// <summary>
		/// horizontal offset (managed manually) + vertical scrolling (pulled from child window's own Scroll.y)<br/>
		/// </summary>
		public Vector2 Scroll;
		/// <summary>
		/// timer for cursor blink, reset on every user action so the cursor reappears immediately<br/>
		/// </summary>
		public float CursorAnim;
		/// <summary>
		/// set when we want scrolling to follow the current cursor position (not always!)<br/>
		/// </summary>
		public byte CursorFollow;
		/// <summary>
		/// after a double-click to select all, we ignore further mouse drags to update selection<br/>
		/// </summary>
		public byte SelectedAllMouseLock;
		/// <summary>
		/// edited this frame<br/>
		/// </summary>
		public byte Edited;
		/// <summary>
		/// force a reload of user buf so it may be modified externally. may be automatic in future version.<br/>
		/// </summary>
		public byte WantReloadUserBuf;
		public int ReloadSelectionStart;
		public int ReloadSelectionEnd;
	}
}
