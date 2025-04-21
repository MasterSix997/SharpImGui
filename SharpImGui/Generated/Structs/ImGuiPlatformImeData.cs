using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiPlatformImeData
	{
		public byte WantVisible;
		public Vector2 InputPos;
		public float InputLineHeight;
	}
}
