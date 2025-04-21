using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTextIndex
	{
		public ImVector<int> LineOffsets;
		public int EndOffset;
	}
}
