using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiPlatformIO
	{
		public unsafe void* Platform_GetClipboardTextFn;
		public unsafe void* Platform_SetClipboardTextFn;
		public unsafe void* Platform_ClipboardUserData;
		public unsafe void* Platform_OpenInShellFn;
		public unsafe void* Platform_OpenInShellUserData;
		public unsafe void* Platform_SetImeDataFn;
		public unsafe void* Platform_ImeUserData;
		public ushort Platform_LocaleDecimalPoint;
		public unsafe void* Renderer_RenderState;
		public unsafe void* Platform_CreateWindow;
		public unsafe void* Platform_DestroyWindow;
		public unsafe void* Platform_ShowWindow;
		public unsafe void* Platform_SetWindowPos;
		public unsafe void* Platform_GetWindowPos;
		public unsafe void* Platform_SetWindowSize;
		public unsafe void* Platform_GetWindowSize;
		public unsafe void* Platform_SetWindowFocus;
		public unsafe void* Platform_GetWindowFocus;
		public unsafe void* Platform_GetWindowMinimized;
		public unsafe void* Platform_SetWindowTitle;
		public unsafe void* Platform_SetWindowAlpha;
		public unsafe void* Platform_UpdateWindow;
		public unsafe void* Platform_RenderWindow;
		public unsafe void* Platform_SwapBuffers;
		public unsafe void* Platform_GetWindowDpiScale;
		public unsafe void* Platform_OnChangedViewport;
		public unsafe void* Platform_GetWindowWorkAreaInsets;
		public unsafe void* Platform_CreateVkSurface;
		public unsafe void* Renderer_CreateWindow;
		public unsafe void* Renderer_DestroyWindow;
		public unsafe void* Renderer_SetWindowSize;
		public unsafe void* Renderer_RenderWindow;
		public unsafe void* Renderer_SwapBuffers;
		public ImVector<ImGuiPlatformMonitor> Monitors;
		public ImVector<ImGuiViewportPtr> Viewports;
	}
}
