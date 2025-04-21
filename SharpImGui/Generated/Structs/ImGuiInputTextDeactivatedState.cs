using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiInputTextDeactivatedState
	{
		public uint ID;
		public ImVector<byte> TextA;
	}
}
