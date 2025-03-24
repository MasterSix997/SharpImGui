using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiDataVarInfo
	{
		public ImGuiDataType Type;
		/// <summary>
		/// // 1+
		/// </summary>
		public uint Count;
		/// <summary>
		/// // Offset in parent structure
		/// </summary>
		public uint Offset;
	}
}
