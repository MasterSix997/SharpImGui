using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiListClipper
	{
		public unsafe ImGuiContext* Ctx;
		public int DisplayStart;
		public int DisplayEnd;
		public int ItemsCount;
		public float ItemsHeight;
		public float StartPosY;
		public double StartSeekOffsetY;
		public unsafe void* TempData;
	}
}
