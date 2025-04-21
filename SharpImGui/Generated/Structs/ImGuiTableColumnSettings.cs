using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTableColumnSettings
	{
		public float WidthOrWeight;
		public uint UserID;
		public short Index;
		public short DisplayOrder;
		public short SortOrder;
		public byte SortDirection;
		public sbyte IsEnabled;
		public byte IsStretch;
	}
}
