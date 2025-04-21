using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTableInstanceData
	{
		public uint TableInstanceID;
		public float LastOuterHeight;
		public float LastTopHeadersRowHeight;
		public float LastFrozenHeight;
		public int HoveredRowLast;
		public int HoveredRowNext;
	}
}
