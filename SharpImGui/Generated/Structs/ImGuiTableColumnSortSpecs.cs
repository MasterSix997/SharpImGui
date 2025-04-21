using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTableColumnSortSpecs
	{
		public uint ColumnUserID;
		public short ColumnIndex;
		public short SortOrder;
		public ImGuiSortDirection SortDirection;
	}
}
