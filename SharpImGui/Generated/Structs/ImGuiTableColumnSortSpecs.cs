using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Sorting specification for one column of a table (sizeof == 12 bytes)<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTableColumnSortSpecs
	{
		/// <summary>
		/// User id of the column (if specified by a TableSetupColumn() call)<br/>
		/// </summary>
		public uint ColumnUserID;
		/// <summary>
		/// Index of the column<br/>
		/// </summary>
		public short ColumnIndex;
		/// <summary>
		/// Index within parent ImGuiTableSortSpecs (always stored in order starting from 0, tables sorted on a single criteria will always have a 0 here)<br/>
		/// </summary>
		public short SortOrder;
		/// <summary>
		/// ImGuiSortDirection_Ascending or ImGuiSortDirection_Descending<br/>
		/// </summary>
		public ImGuiSortDirection SortDirection;
	}
}
