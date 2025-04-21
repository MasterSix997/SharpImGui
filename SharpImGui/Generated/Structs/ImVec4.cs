using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImVec4
	{
		public float x;
		public float y;
		public float z;
		public float w;
	}
}
