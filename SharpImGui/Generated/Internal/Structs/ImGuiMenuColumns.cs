using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Simple column measurement, currently used for MenuItem() only.. This is very short-sighted/throw-away code and NOT a generic helper.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiMenuColumns
	{
		public uint TotalWidth;
		public uint NextTotalWidth;
		public ushort Spacing;
		/// <summary>
		/// Always zero for now<br/>
		/// </summary>
		public ushort OffsetIcon;
		/// <summary>
		/// Offsets are locked in Update()<br/>
		/// </summary>
		public ushort OffsetLabel;
		public ushort OffsetShortcut;
		public ushort OffsetMark;
		/// <summary>
		/// Width of:   Icon, Label, Shortcut, Mark  (accumulators for current frame)<br/>
		/// </summary>
		public ushort Widths_0;
		public ushort Widths_1;
		public ushort Widths_2;
		public ushort Widths_3;
	}
}
