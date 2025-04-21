using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiInputEventMousePos
	{
		public float PosX;
		public float PosY;
		public ImGuiMouseSource MouseSource;
	}
}
