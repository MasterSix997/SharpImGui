using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTableSettings
	{
		public uint ID;
		public ImGuiTableFlags SaveFlags;
		public float RefScale;
		public short ColumnsCount;
		public short ColumnsCountMax;
		public byte WantApply;
	}
}
