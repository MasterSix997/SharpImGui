using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Windows data saved in imgui.ini file<br/>
	/// Because we never destroy or rename ImGuiWindowSettings, we can store the names in a separate buffer easily.<br/>
	/// (this is designed to be stored in a ImChunkStream buffer, with the variable-length Name following our structure)<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiWindowSettings
	{
		public uint ID;
		/// <summary>
		/// NB: Settings position are stored RELATIVE to the viewport! Whereas runtime ones are absolute positions.<br/>
		/// </summary>
		public ImVec2ih Pos;
		public ImVec2ih Size;
		public ImVec2ih ViewportPos;
		public uint ViewportId;
		/// <summary>
		/// ID of last known DockNode (even if the DockNode is invisible because it has only 1 active window), or 0 if none.<br/>
		/// </summary>
		public uint DockId;
		/// <summary>
		/// ID of window class if specified<br/>
		/// </summary>
		public uint ClassId;
		/// <summary>
		/// Order of the last time the window was visible within its DockNode. This is used to reorder windows that are reappearing on the same frame. Same value between windows that were active and windows that were none are possible.<br/>
		/// </summary>
		public short DockOrder;
		public byte Collapsed;
		public byte IsChild;
		/// <summary>
		/// Set when loaded from .ini data (to enable merging/loading .ini data into an already running context)<br/>
		/// </summary>
		public byte WantApply;
		/// <summary>
		/// Set to invalidate/delete the settings entry<br/>
		/// </summary>
		public byte WantDelete;
	}
}
