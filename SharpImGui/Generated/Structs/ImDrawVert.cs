using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImDrawVert
	{
		public Vector2 pos;
		public Vector2 uv;
		public uint col;
	}
}
