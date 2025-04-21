using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImRect
	{
		public Vector2 Min;
		public Vector2 Max;
	}
}
