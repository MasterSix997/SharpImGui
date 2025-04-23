using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Transient cell data stored per row.<br/>
	/// sizeof() ~ 6 bytes<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTableCellData
	{
		/// <summary>
		/// Actual color<br/>
		/// </summary>
		public uint BgColor;
		/// <summary>
		/// Column number<br/>
		/// </summary>
		public short Column;
	}
}
