using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiMultiSelectState
	{
		public unsafe ImGuiWindow* Window;
		public uint ID;
		public int LastFrameActive;
		public int LastSelectionSize;
		public sbyte RangeSelected;
		public sbyte NavIdSelected;
		public long RangeSrcItem;
		public long NavIdItem;
	}
}
