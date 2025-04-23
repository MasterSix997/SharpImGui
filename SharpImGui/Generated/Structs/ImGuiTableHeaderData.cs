using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Parameters for TableAngledHeadersRowEx()<br/>
	/// This may end up being refactored for more general purpose.<br/>
	/// sizeof() ~ 12 bytes<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTableHeaderData
	{
		/// <summary>
		/// Column index<br/>
		/// </summary>
		public short Index;
		public uint TextColor;
		public uint BgColor0;
		public uint BgColor1;
	}
}
