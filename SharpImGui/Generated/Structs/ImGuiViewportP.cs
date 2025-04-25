using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// ImGuiViewport Private/Internals fields (cardinal sin: we are using inheritance!)<br/>Every instance of ImGuiViewport is in fact a ImGuiViewportP.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiViewportP
	{
		public ImGuiViewport ImGuiViewport;
		/// <summary>
		/// Set when the viewport is owned by a window (and ImGuiViewportFlags_CanHostOtherWindows is NOT set)<br/>
		/// </summary>
		public unsafe ImGuiWindow* Window;
		public int Idx;
		/// <summary>
		/// Last frame number this viewport was activated by a window<br/>
		/// </summary>
		public int LastFrameActive;
		/// <summary>
		/// Last stamp number from when a window hosted by this viewport was focused (by comparing this value between two viewport we have an implicit viewport z-order we use as fallback)<br/>
		/// </summary>
		public int LastFocusedStampCount;
		public uint LastNameHash;
		public Vector2 LastPos;
		public Vector2 LastSize;
		/// <summary>
		/// Window opacity (when dragging dockable windows/viewports we make them transparent)<br/>
		/// </summary>
		public float Alpha;
		public float LastAlpha;
		/// <summary>
		/// Instead of maintaining a LastFocusedWindow (which may harder to correctly maintain), we merely store weither NavWindow != NULL last time the viewport was focused.<br/>
		/// </summary>
		public byte LastFocusedHadNavWindow;
		public short PlatformMonitor;
		/// <summary>
		/// Last frame number the background (0) and foreground (1) draw lists were used<br/>
		/// </summary>
		public int BgFgDrawListsLastFrame_0;
		public int BgFgDrawListsLastFrame_1;
		/// <summary>
		/// Convenience background (0) and foreground (1) draw lists. We use them to draw software mouser cursor when io.MouseDrawCursor is set and to draw most debug overlays.<br/>
		/// </summary>
		public unsafe ImDrawList* BgFgDrawLists_0;
		public unsafe ImDrawList* BgFgDrawLists_1;
		public ImDrawData DrawDataP;
		/// <summary>
		/// Temporary data while building final ImDrawData<br/>
		/// </summary>
		public ImDrawDataBuilder DrawDataBuilder;
		public Vector2 LastPlatformPos;
		public Vector2 LastPlatformSize;
		public Vector2 LastRendererSize;
		/// <summary>
		///     Per-viewport work area<br/>    - Insets are &gt;= 0.0f values, distance from viewport corners to work area.<br/>    - BeginMainMenuBar() and DockspaceOverViewport() tend to use work area to avoid stepping over existing contents.<br/>    - Generally 'safeAreaInsets' in iOS land, 'DisplayCutout' in Android land.<br/>
		/// Work Area inset locked for the frame. GetWorkRect() always fits within GetMainRect().<br/>
		/// </summary>
		public Vector2 WorkInsetMin;
		/// <summary>
		/// "<br/>
		/// </summary>
		public Vector2 WorkInsetMax;
		/// <summary>
		/// Work Area inset accumulator for current frame, to become next frame's WorkInset<br/>
		/// </summary>
		public Vector2 BuildWorkInsetMin;
		/// <summary>
		/// "<br/>
		/// </summary>
		public Vector2 BuildWorkInsetMax;
	}

	/// <summary>
	/// ImGuiViewport Private/Internals fields (cardinal sin: we are using inheritance!)<br/>Every instance of ImGuiViewport is in fact a ImGuiViewportP.<br/>
	/// </summary>
	public unsafe partial struct ImGuiViewportPPtr
	{
		public ImGuiViewportP* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiViewportP this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImGuiViewportPPtr(ImGuiViewportP* nativePtr) => NativePtr = nativePtr;
		public ImGuiViewportPPtr(IntPtr nativePtr) => NativePtr = (ImGuiViewportP*)nativePtr;
		public static implicit operator ImGuiViewportPPtr(ImGuiViewportP* ptr) => new ImGuiViewportPPtr(ptr);
		public static implicit operator ImGuiViewportPPtr(IntPtr ptr) => new ImGuiViewportPPtr(ptr);
		public static implicit operator ImGuiViewportP*(ImGuiViewportPPtr nativePtr) => nativePtr.NativePtr;
	}
}
