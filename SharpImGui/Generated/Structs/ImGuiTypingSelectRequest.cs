using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Returned by GetTypingSelectRequest(), designed to eventually be public.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTypingSelectRequest
	{
		/// <summary>
		/// Flags passed to GetTypingSelectRequest()<br/>
		/// </summary>
		public ImGuiTypingSelectFlags Flags;
		public int SearchBufferLen;
		/// <summary>
		/// Search buffer contents (use full string. unless SingleCharMode is set, in which case use SingleCharSize).<br/>
		/// </summary>
		public unsafe byte* SearchBuffer;
		/// <summary>
		/// Set when buffer was modified this frame, requesting a selection.<br/>
		/// </summary>
		public byte SelectRequest;
		/// <summary>
		/// Notify when buffer contains same character repeated, to implement special mode. In this situation it preferred to not display any on-screen search indication.<br/>
		/// </summary>
		public byte SingleCharMode;
		/// <summary>
		/// Length in bytes of first letter codepoint (1 for ascii, 2-4 for UTF-8). If (SearchBufferLen==RepeatCharSize) only 1 letter has been input.<br/>
		/// </summary>
		public sbyte SingleCharSize;
	}
}
