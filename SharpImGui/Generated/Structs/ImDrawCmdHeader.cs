using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// <br/>
	/// [Internal] For use by ImDrawList<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImDrawCmdHeader
	{
		public Vector4 ClipRect;
		public IntPtr TextureId;
		public uint VtxOffset;
	}
}
