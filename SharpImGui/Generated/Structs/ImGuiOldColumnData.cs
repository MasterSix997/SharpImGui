using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiOldColumnData
	{
		public float OffsetNorm;
		public float OffsetNormBeforeResize;
		public ImGuiOldColumnFlags Flags;
		public ImRect ClipRect;
	}
}
