using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// State for ID Stack tool queries<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiIDStackTool
	{
		public int LastActiveFrame;
		/// <summary>
		/// -1: query stack and resize Results, >= 0: individual stack level<br/>
		/// </summary>
		public int StackLevel;
		/// <summary>
		/// ID to query details for<br/>
		/// </summary>
		public uint QueryId;
		public ImVector<ImGuiStackLevelInfo> Results;
		public byte CopyToClipboardOnCtrlC;
		public float CopyToClipboardLastTime;
		public ImGuiTextBuffer ResultPathBuf;
	}
}
