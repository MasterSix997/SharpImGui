using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiLocEntry
	{
		public ImGuiLocKey Key;
		public unsafe byte* Text;
	}
}
