using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// ImVec4: 4D vector used to store clipping rectangles, colors etc. [Compile-time configurable type]<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImVec4
	{
		public float x;
		public float y;
		public float z;
		public float w;
	}
}
