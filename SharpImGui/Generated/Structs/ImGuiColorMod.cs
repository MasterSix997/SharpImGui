using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiColorMod
	{
		public ImGuiCol Col;
		public Vector4 BackupValue;
	}
}
