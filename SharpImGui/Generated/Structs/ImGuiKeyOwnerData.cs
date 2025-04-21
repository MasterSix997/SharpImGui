using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiKeyOwnerData
	{
		public uint OwnerCurr;
		public uint OwnerNext;
		public byte LockThisFrame;
		public byte LockUntilRelease;
	}
}
