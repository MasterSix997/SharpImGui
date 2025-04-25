using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Access via ImGui::GetPlatformIO()<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiPlatformIO
	{
		/// <summary>
		///     Optional: Access OS clipboard<br/>    (default to use native Win32 clipboard on Windows, otherwise uses a private clipboard. Override to access OS clipboard on other architectures)<br/>
		/// </summary>
		public unsafe void* PlatformGetClipboardTextFn;
		public unsafe void* PlatformSetClipboardTextFn;
		public unsafe void* PlatformClipboardUserData;
		/// <summary>
		///     Optional: Open link/folder/file in OS Shell<br/>    (default to use ShellExecuteW() on Windows, system() on Linux/Mac)<br/>
		/// </summary>
		public unsafe void* PlatformOpenInShellFn;
		public unsafe void* PlatformOpenInShellUserData;
		/// <summary>
		///     Optional: Notify OS Input Method Editor of the screen position of your cursor for text input position (e.g. when using Japanese/Chinese IME on Windows)<br/>    (default to use native imm32 api on Windows)<br/>
		/// </summary>
		public unsafe void* PlatformSetImeDataFn;
		public unsafe void* PlatformImeUserData;
		/// <summary>
		///     Optional: Platform locale<br/>    [Experimental] Configure decimal point e.g. '.' or ',' useful for some languages (e.g. German), generally pulled from *localeconv()-&gt;decimal_point<br/>
		/// '.'<br/>
		/// </summary>
		public ushort PlatformLocaleDecimalPoint;
		/// <summary>
		///     Written by some backends during ImGui_ImplXXXX_RenderDrawData() call to point backend_specific ImGui_ImplXXXX_RenderState* structure.<br/>
		/// </summary>
		public unsafe void* RendererRenderState;
		/// <summary>
		///     Platform Backend functions (e.g. Win32, GLFW, SDL) ------------------- Called by -----<br/>
		/// . . U . .  Create a new platform window for the given viewport<br/>
		/// </summary>
		public unsafe void* PlatformCreateWindow;
		/// <summary>
		/// N . U . D  //<br/>
		/// </summary>
		public unsafe void* PlatformDestroyWindow;
		/// <summary>
		/// . . U . .  Newly created windows are initially hidden so SetWindowPos/Size/Title can be called on them before showing the window<br/>
		/// </summary>
		public unsafe void* PlatformShowWindow;
		/// <summary>
		/// . . U . .  Set platform window position (given the upper-left corner of client area)<br/>
		/// </summary>
		public unsafe void* PlatformSetWindowPos;
		/// <summary>
		/// N . . . .  //<br/>
		/// </summary>
		public unsafe void* PlatformGetWindowPos;
		/// <summary>
		/// . . U . .  Set platform window client area size (ignoring OS decorations such as OS title bar etc.)<br/>
		/// </summary>
		public unsafe void* PlatformSetWindowSize;
		/// <summary>
		/// N . . . .  Get platform window client area size<br/>
		/// </summary>
		public unsafe void* PlatformGetWindowSize;
		/// <summary>
		/// N . . . .  Move window to front and set input focus<br/>
		/// </summary>
		public unsafe void* PlatformSetWindowFocus;
		/// <summary>
		/// . . U . .  //<br/>
		/// </summary>
		public unsafe void* PlatformGetWindowFocus;
		/// <summary>
		/// N . . . .  Get platform window minimized state. When minimized, we generally won't attempt to get/set size and contents will be culled more easily<br/>
		/// </summary>
		public unsafe void* PlatformGetWindowMinimized;
		/// <summary>
		/// . . U . .  Set platform window title (given an UTF-8 string)<br/>
		/// </summary>
		public unsafe void* PlatformSetWindowTitle;
		/// <summary>
		/// . . U . .  (Optional) Setup global transparency (not per-pixel transparency)<br/>
		/// </summary>
		public unsafe void* PlatformSetWindowAlpha;
		/// <summary>
		/// . . U . .  (Optional) Called by UpdatePlatformWindows(). Optional hook to allow the platform backend from doing general book-keeping every frame.<br/>
		/// </summary>
		public unsafe void* PlatformUpdateWindow;
		/// <summary>
		/// . . . R .  (Optional) Main rendering (platform side! This is often unused, or just setting a "current" context for OpenGL bindings). 'render_arg' is the value passed to RenderPlatformWindowsDefault().<br/>
		/// </summary>
		public unsafe void* PlatformRenderWindow;
		/// <summary>
		/// . . . R .  (Optional) Call Present/SwapBuffers (platform side! This is often unused!). 'render_arg' is the value passed to RenderPlatformWindowsDefault().<br/>
		/// </summary>
		public unsafe void* PlatformSwapBuffers;
		/// <summary>
		/// N . . . .  (Optional) [BETA] FIXME-DPI: DPI handling: Return DPI scale for this viewport. 1.0f = 96 DPI.<br/>
		/// </summary>
		public unsafe void* PlatformGetWindowDpiScale;
		/// <summary>
		/// . F . . .  (Optional) [BETA] FIXME-DPI: DPI handling: Called during Begin() every time the viewport we are outputting into changes, so backend has a chance to swap fonts to adjust style.<br/>
		/// </summary>
		public unsafe void* PlatformOnChangedViewport;
		/// <summary>
		/// N . . . .  (Optional) [BETA] Get initial work area inset for the viewport (won't be covered by main menu bar, dockspace over viewport etc.). Default to (0,0),(0,0). 'safeAreaInsets' in iOS land, 'DisplayCutout' in Android land.<br/>
		/// </summary>
		public unsafe void* PlatformGetWindowWorkAreaInsets;
		/// <summary>
		/// (Optional) For a Vulkan Renderer to call into Platform code (since the surface creation needs to tie them both).<br/>
		/// </summary>
		public unsafe void* PlatformCreateVkSurface;
		/// <summary>
		///     Renderer Backend functions (e.g. DirectX, OpenGL, Vulkan) ------------ Called by -----<br/>
		/// . . U . .  Create swap chain, frame buffers etc. (called after Platform_CreateWindow)<br/>
		/// </summary>
		public unsafe void* RendererCreateWindow;
		/// <summary>
		/// N . U . D  Destroy swap chain, frame buffers etc. (called before Platform_DestroyWindow)<br/>
		/// </summary>
		public unsafe void* RendererDestroyWindow;
		/// <summary>
		/// . . U . .  Resize swap chain, frame buffers etc. (called after Platform_SetWindowSize)<br/>
		/// </summary>
		public unsafe void* RendererSetWindowSize;
		/// <summary>
		/// . . . R .  (Optional) Clear framebuffer, setup render target, then render the viewport-&gt;DrawData. 'render_arg' is the value passed to RenderPlatformWindowsDefault().<br/>
		/// </summary>
		public unsafe void* RendererRenderWindow;
		/// <summary>
		/// . . . R .  (Optional) Call Present/SwapBuffers. 'render_arg' is the value passed to RenderPlatformWindowsDefault().<br/>
		/// </summary>
		public unsafe void* RendererSwapBuffers;
		/// <summary>
		///     (Optional) Monitor list<br/>    - Updated by: app/backend. Update every frame to dynamically support changing monitor or DPI configuration.<br/>    - Used by: dear imgui to query DPI info, clamp popups/tooltips within same monitor and not have them straddle monitors.<br/>
		/// </summary>
		public ImVector<ImGuiPlatformMonitor> Monitors;
		/// <summary>
		///     Viewports list (the list is updated by calling ImGui::EndFrame or ImGui::Render)<br/>    (in the future we will attempt to organize this feature to remove the need for a "main viewport")<br/>
		/// Main viewports, followed by all secondary viewports.<br/>
		/// </summary>
		public ImVector<ImGuiViewportPtr> Viewports;
	}

	/// <summary>
	/// Access via ImGui::GetPlatformIO()<br/>
	/// </summary>
	public unsafe partial struct ImGuiPlatformIOPtr
	{
		public ImGuiPlatformIO* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiPlatformIO this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImGuiPlatformIOPtr(ImGuiPlatformIO* nativePtr) => NativePtr = nativePtr;
		public ImGuiPlatformIOPtr(IntPtr nativePtr) => NativePtr = (ImGuiPlatformIO*)nativePtr;
		public static implicit operator ImGuiPlatformIOPtr(ImGuiPlatformIO* ptr) => new ImGuiPlatformIOPtr(ptr);
		public static implicit operator ImGuiPlatformIOPtr(IntPtr ptr) => new ImGuiPlatformIOPtr(ptr);
		public static implicit operator ImGuiPlatformIO*(ImGuiPlatformIOPtr nativePtr) => nativePtr.NativePtr;
	}
}
