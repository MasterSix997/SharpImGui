using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiDataTypeInfo
	{
		public uint Size;
		public unsafe byte* Name;
		public unsafe byte* PrintFmt;
		public unsafe byte* ScanFmt;
	}
}
