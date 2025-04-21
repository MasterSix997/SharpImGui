using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiPlatformMonitor
	{
		public Vector2 MainPos;
		public Vector2 MainSize;
		public Vector2 WorkPos;
		public Vector2 WorkSize;
		public float DpiScale;
		public unsafe void* PlatformHandle;
	}
}
