using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiListClipperData
	{
		public unsafe ImGuiListClipper* ListClipper;
		public float LossynessOffset;
		public int StepNo;
		public int ItemsFrozen;
		public ImVector<ImGuiListClipperRange> Ranges;
	}
}
