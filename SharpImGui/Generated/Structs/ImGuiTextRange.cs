using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTextRange
	{
		public unsafe byte* b;
		public unsafe byte* e;
	}
}
