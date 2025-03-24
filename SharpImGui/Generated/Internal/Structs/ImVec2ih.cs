using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Helper: ImVec2ih (2D vector, half-size integer, for long-term packed storage)<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImVec2ih
	{
		public short x;
		public short y;
	}
}
