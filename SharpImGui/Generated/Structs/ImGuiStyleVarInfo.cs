using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiStyleVarInfo
	{
		public uint Count;
		public ImGuiDataType DataType;
		public uint Offset;
	}
}
