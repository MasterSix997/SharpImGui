using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiMultiSelectIO
	{
		public ImVector<ImGuiSelectionRequest> Requests;
		public long RangeSrcItem;
		public long NavIdItem;
		public byte NavIdSelected;
		public byte RangeSrcReset;
		public int ItemsCount;
	}
}
