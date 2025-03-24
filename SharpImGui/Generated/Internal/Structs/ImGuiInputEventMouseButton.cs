using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiInputEventMouseButton
	{
		public int Button;
		public byte Down;
		public ImGuiMouseSource MouseSource;
	}
}
