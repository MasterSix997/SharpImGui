using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiFocusScopeData
	{
		public uint ID;
		public uint WindowID;
	}
}
