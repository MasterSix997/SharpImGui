using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiViewport
	{
		public uint ID;
		public ImGuiViewportFlags Flags;
		public Vector2 Pos;
		public Vector2 Size;
		public Vector2 WorkPos;
		public Vector2 WorkSize;
		public float DpiScale;
		public uint ParentViewportId;
		public unsafe ImDrawData* DrawData;
		public unsafe void* RendererUserData;
		public unsafe void* PlatformUserData;
		public unsafe void* PlatformHandle;
		public unsafe void* PlatformHandleRaw;
		public byte PlatformWindowCreated;
		public byte PlatformRequestMove;
		public byte PlatformRequestResize;
		public byte PlatformRequestClose;
	}

	public unsafe struct ImGuiViewportPtr
	{
		public ImGuiViewport* NativePtr;
	}
}
