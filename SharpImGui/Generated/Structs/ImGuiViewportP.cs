using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiViewportP
	{
		public ImGuiViewport _ImGuiViewport;
		public unsafe ImGuiWindow* Window;
		public int Idx;
		public int LastFrameActive;
		public int LastFocusedStampCount;
		public uint LastNameHash;
		public Vector2 LastPos;
		public Vector2 LastSize;
		public float Alpha;
		public float LastAlpha;
		public byte LastFocusedHadNavWindow;
		public short PlatformMonitor;
		public int BgFgDrawListsLastFrame_0;
		public int BgFgDrawListsLastFrame_1;
		public unsafe ImDrawList* BgFgDrawLists_0;
		public unsafe ImDrawList* BgFgDrawLists_1;
		public ImDrawData DrawDataP;
		public ImDrawDataBuilder DrawDataBuilder;
		public Vector2 LastPlatformPos;
		public Vector2 LastPlatformSize;
		public Vector2 LastRendererSize;
		public Vector2 WorkInsetMin;
		public Vector2 WorkInsetMax;
		public Vector2 BuildWorkInsetMin;
		public Vector2 BuildWorkInsetMax;
	}

	public unsafe struct ImGuiViewportPPtr
	{
		public ImGuiViewportP* NativePtr;
	}
}
