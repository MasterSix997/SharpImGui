using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTypingSelectRequest
	{
		public ImGuiTypingSelectFlags Flags;
		public int SearchBufferLen;
		public unsafe byte* SearchBuffer;
		public byte SelectRequest;
		public byte SingleCharMode;
		public sbyte SingleCharSize;
	}
}
