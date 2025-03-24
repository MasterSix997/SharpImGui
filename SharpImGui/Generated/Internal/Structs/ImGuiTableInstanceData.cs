using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Per-instance data that needs preserving across frames (seemingly most others do not need to be preserved aside from debug needs. Does that means they could be moved to ImGuiTableTempData?)<br/>
	/// sizeof() ~ 24 bytes<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTableInstanceData
	{
		public uint TableInstanceID;
		/// <summary>
		/// Outer height from last frame<br/>
		/// </summary>
		public float LastOuterHeight;
		/// <summary>
		/// Height of first consecutive header rows from last frame (FIXME: this is used assuming consecutive headers are in same frozen set)<br/>
		/// </summary>
		public float LastTopHeadersRowHeight;
		/// <summary>
		/// Height of frozen section from last frame<br/>
		/// </summary>
		public float LastFrozenHeight;
		/// <summary>
		/// Index of row which was hovered last frame.<br/>
		/// </summary>
		public int HoveredRowLast;
		/// <summary>
		/// Index of row hovered this frame, set after encountering it.<br/>
		/// </summary>
		public int HoveredRowNext;
	}
}
