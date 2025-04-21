using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImDrawChannel
	{
		public ImVector<ImDrawCmd> _CmdBuffer;
		public ImVector<ushort> _IdxBuffer;
	}
}
