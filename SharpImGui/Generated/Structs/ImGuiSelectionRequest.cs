using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiSelectionRequest
	{
		public ImGuiSelectionRequestType Type;
		public byte Selected;
		public sbyte RangeDirection;
		public long RangeFirstItem;
		public long RangeLastItem;
	}
}
