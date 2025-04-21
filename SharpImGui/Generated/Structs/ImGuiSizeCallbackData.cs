using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiSizeCallbackData
	{
		public unsafe void* UserData;
		public Vector2 Pos;
		public Vector2 CurrentSize;
		public Vector2 DesiredSize;
	}
}
