using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImDrawCmd
	{
		public Vector4 ClipRect;
		public IntPtr TextureId;
		public uint VtxOffset;
		public uint IdxOffset;
		public uint ElemCount;
		public IntPtr UserCallback;
		public unsafe void* UserCallbackData;
		public int UserCallbackDataSize;
		public int UserCallbackDataOffset;
	}
}
