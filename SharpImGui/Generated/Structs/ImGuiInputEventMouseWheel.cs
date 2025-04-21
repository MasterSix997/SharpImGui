using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiInputEventMouseWheel
	{
		public float WheelX;
		public float WheelY;
		public ImGuiMouseSource MouseSource;
	}
}
