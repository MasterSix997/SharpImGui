using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTableSortSpecs
	{
		public unsafe ImGuiTableColumnSortSpecs* Specs;
		public int SpecsCount;
		public byte SpecsDirty;
	}
}
