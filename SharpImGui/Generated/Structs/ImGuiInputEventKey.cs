using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiInputEventKey
	{
		public ImGuiKey Key;
		public byte Down;
		public float AnalogValue;
	}
}
