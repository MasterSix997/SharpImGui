using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiStorage
	{
		public ImVector<ImGuiStoragePair> Data;
	}
}
