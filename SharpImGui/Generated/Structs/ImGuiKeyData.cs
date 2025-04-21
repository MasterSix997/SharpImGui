using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiKeyData
	{
		public byte Down;
		public float DownDuration;
		public float DownDurationPrev;
		public float AnalogValue;
	}
}
