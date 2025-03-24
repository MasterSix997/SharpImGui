using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Helper: ImRect (2D axis aligned bounding-box)<br/>
	/// NB: we can't rely on ImVec2 math operators being available here!<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImRect
	{
		/// <summary>
		/// Upper-left<br/>
		/// </summary>
		public Vector2 Min;
		/// <summary>
		/// Lower-right<br/>
		/// </summary>
		public Vector2 Max;
	}
}
