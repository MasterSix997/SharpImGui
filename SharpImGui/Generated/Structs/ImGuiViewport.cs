using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// - Currently represents the Platform Window created by the application which is hosting our Dear ImGui windows.<br/>
	/// - With multi-viewport enabled, we extend this concept to have multiple active viewports.<br/>
	/// - In the future we will extend this concept further to also represent Platform Monitor and support a "no main platform window" operation mode.<br/>
	/// - About Main Area vs Work Area:<br/>
	///   - Main Area = entire viewport.<br/>
	///   - Work Area = entire viewport minus sections used by main menu bars (for platform windows), or by task bar (for platform monitor).<br/>
	///   - Windows are generally trying to stay within the Work Area of their host viewport.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiViewport
	{
		/// <summary>
		/// Unique identifier for the viewport<br/>
		/// </summary>
		public uint ID;
		/// <summary>
		/// See ImGuiViewportFlags_<br/>
		/// </summary>
		public ImGuiViewportFlags Flags;
		/// <summary>
		/// Main Area: Position of the viewport (Dear ImGui coordinates are the same as OS desktop/native coordinates)<br/>
		/// </summary>
		public Vector2 Pos;
		/// <summary>
		/// Main Area: Size of the viewport.<br/>
		/// </summary>
		public Vector2 Size;
		/// <summary>
		/// Work Area: Position of the viewport minus task bars, menus bars, status bars (>= Pos)<br/>
		/// </summary>
		public Vector2 WorkPos;
		/// <summary>
		/// Work Area: Size of the viewport minus task bars, menu bars, status bars (<= Size)<br/>
		/// </summary>
		public Vector2 WorkSize;
		/// <summary>
		/// 1.0f = 96 DPI = No extra scale.<br/>
		/// </summary>
		public float DpiScale;
		/// <summary>
		/// (Advanced) 0: no parent. Instruct the platform backend to setup a parent/child relationship between platform windows.<br/>
		/// </summary>
		public uint ParentViewportId;
		/// <summary>
		/// The ImDrawData corresponding to this viewport. Valid after Render() and until the next call to NewFrame().<br/>
		/// </summary>
		public unsafe ImDrawData* DrawData;
		/// <summary>
		///     // Platform/Backend Dependent Data<br/>
		///     // Our design separate the Renderer and Platform backends to facilitate combining default backends with each others.<br/>
		///     // When our create your own backend for a custom engine, it is possible that both Renderer and Platform will be handled<br/>
		///     // by the same system and you may not need to use all the UserData/Handle fields.<br/>
		///     // The library never uses those fields, they are merely storage to facilitate backend implementation.<br/>
		/// void* to hold custom data structure for the renderer (e.g. swap chain, framebuffers etc.). generally set by your Renderer_CreateWindow function.<br/>
		/// </summary>
		public unsafe void* RendererUserData;
		/// <summary>
		/// void* to hold custom data structure for the OS / platform (e.g. windowing info, render context). generally set by your Platform_CreateWindow function.<br/>
		/// </summary>
		public unsafe void* PlatformUserData;
		/// <summary>
		/// void* to hold higher-level, platform window handle (e.g. HWND, GLFWWindow*, SDL_Window*), for FindViewportByPlatformHandle().<br/>
		/// </summary>
		public unsafe void* PlatformHandle;
		/// <summary>
		/// void* to hold lower-level, platform-native window handle (under Win32 this is expected to be a HWND, unused for other platforms), when using an abstraction layer like GLFW or SDL (where PlatformHandle would be a SDL_Window*)<br/>
		/// </summary>
		public unsafe void* PlatformHandleRaw;
		/// <summary>
		/// Platform window has been created (Platform_CreateWindow() has been called). This is false during the first frame where a viewport is being created.<br/>
		/// </summary>
		public byte PlatformWindowCreated;
		/// <summary>
		/// Platform window requested move (e.g. window was moved by the OS / host window manager, authoritative position will be OS window position)<br/>
		/// </summary>
		public byte PlatformRequestMove;
		/// <summary>
		/// Platform window requested resize (e.g. window was resized by the OS / host window manager, authoritative size will be OS window size)<br/>
		/// </summary>
		public byte PlatformRequestResize;
		/// <summary>
		/// Platform window requested closure (e.g. window was moved by the OS / host window manager, e.g. pressing ALT-F4)<br/>
		/// </summary>
		public byte PlatformRequestClose;
	}

	public unsafe struct ImGuiViewportPtr
	{
		public ImGuiViewport* NativePtr;
	}
}
