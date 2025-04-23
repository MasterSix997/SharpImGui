using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Shared state of InputText(), passed as an argument to your callback when a ImGuiInputTextFlags_Callback* flag is used.<br/>
	/// The callback function should return 0 by default.<br/>
	/// Callbacks (follow a flag name and see comments in ImGuiInputTextFlags_ declarations for more details)<br/>
	/// - ImGuiInputTextFlags_CallbackEdit:        Callback on buffer edit. Note that InputText() already returns true on edit + you can always use IsItemEdited(). The callback is useful to manipulate the underlying buffer while focus is active.<br/>
	/// - ImGuiInputTextFlags_CallbackAlways:      Callback on each iteration<br/>
	/// - ImGuiInputTextFlags_CallbackCompletion:  Callback on pressing TAB<br/>
	/// - ImGuiInputTextFlags_CallbackHistory:     Callback on pressing Up/Down arrows<br/>
	/// - ImGuiInputTextFlags_CallbackCharFilter:  Callback on character inputs to replace or discard them. Modify 'EventChar' to replace or discard, or return 1 in callback to discard.<br/>
	/// - ImGuiInputTextFlags_CallbackResize:      Callback on buffer capacity changes request (beyond 'buf_size' parameter value), allowing the string to grow.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiInputTextCallbackData
	{
		/// <summary>
		/// Parent UI context<br/>
		/// </summary>
		public unsafe ImGuiContext* Ctx;
		/// <summary>
		/// One ImGuiInputTextFlags_Callback*    Read-only<br/>
		/// </summary>
		public ImGuiInputTextFlags EventFlag;
		/// <summary>
		/// What user passed to InputText()      Read-only<br/>
		/// </summary>
		public ImGuiInputTextFlags Flags;
		/// <summary>
		/// What user passed to InputText()      Read-only<br/>
		/// </summary>
		public unsafe void* UserData;
		/// <summary>
		///     Arguments for the different callback events<br/>
		///     - During Resize callback, Buf will be same as your input buffer.<br/>
		///     - However, during Completion/History/Always callback, Buf always points to our own internal data (it is not the same as your buffer)! Changes to it will be reflected into your own buffer shortly after the callback.<br/>
		///     - To modify the text buffer in a callback, prefer using the InsertChars() / DeleteChars() function. InsertChars() will take care of calling the resize callback if necessary.<br/>
		///     - If you know your edits are not going to resize the underlying buffer allocation, you may modify the contents of 'Buf[]' directly. You need to update 'BufTextLen' accordingly (0 <= BufTextLen < BufSize) and set 'BufDirty'' to true so InputText can update its internal state.<br/>
		/// Character input                      Read-write   [CharFilter] Replace character with another one, or set to zero to drop. return 1 is equivalent to setting EventChar=0;<br/>
		/// </summary>
		public ushort EventChar;
		/// <summary>
		/// Key pressed (Up/Down/TAB)            Read-only    [Completion,History]<br/>
		/// </summary>
		public ImGuiKey EventKey;
		/// <summary>
		/// Text buffer                          Read-write   [Resize] Can replace pointer / [Completion,History,Always] Only write to pointed data, don't replace the actual pointer!<br/>
		/// </summary>
		public unsafe byte* Buf;
		/// <summary>
		/// Text length (in bytes)               Read-write   [Resize,Completion,History,Always] Exclude zero-terminator storage. In C land: == strlen(some_text), in C++ land: string.length()<br/>
		/// </summary>
		public int BufTextLen;
		/// <summary>
		/// Buffer size (in bytes) = capacity+1  Read-only    [Resize,Completion,History,Always] Include zero-terminator storage. In C land == ARRAYSIZE(my_char_array), in C++ land: string.capacity()+1<br/>
		/// </summary>
		public int BufSize;
		/// <summary>
		/// Set if you modify Buf/BufTextLen!    Write        [Completion,History,Always]<br/>
		/// </summary>
		public byte BufDirty;
		/// <summary>
		///                                      Read-write   [Completion,History,Always]<br/>
		/// </summary>
		public int CursorPos;
		/// <summary>
		///                                      Read-write   [Completion,History,Always] == to SelectionEnd when no selection)<br/>
		/// </summary>
		public int SelectionStart;
		/// <summary>
		///                                      Read-write   [Completion,History,Always]<br/>
		/// </summary>
		public int SelectionEnd;
	}
}
