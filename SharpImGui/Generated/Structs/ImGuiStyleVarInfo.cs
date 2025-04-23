using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiStyleVarInfo
	{
		/// <summary>
		/// 1+<br/>
		/// </summary>
		public uint Count;
		public ImGuiDataType DataType;
		/// <summary>
		/// Offset in parent structure<br/>
		/// </summary>
		public uint Offset;
	}
}
