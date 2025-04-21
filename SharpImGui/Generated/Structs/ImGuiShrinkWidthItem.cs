using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiShrinkWidthItem
	{
		public int Index;
		public float Width;
		public float InitialWidth;
	}
}
