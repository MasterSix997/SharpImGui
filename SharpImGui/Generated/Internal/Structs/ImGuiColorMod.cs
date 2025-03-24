using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Stacked color modifier, backup of modified data so we can restore it<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiColorMod
	{
		public ImGuiCol Col;
		public Vector4 BackupValue;
	}
}
