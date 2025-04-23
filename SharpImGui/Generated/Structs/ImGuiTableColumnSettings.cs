using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// sizeof() ~ 16<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTableColumnSettings
	{
		public float WidthOrWeight;
		public uint UserID;
		public short Index;
		public short DisplayOrder;
		public short SortOrder;
		public byte SortDirection;
		/// <summary>
		/// "Visible" in ini file<br/>
		/// </summary>
		public sbyte IsEnabled;
		public byte IsStretch;
	}
}
