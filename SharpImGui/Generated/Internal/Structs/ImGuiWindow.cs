using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Storage for one window<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiWindow
	{
		/// <summary>
		/// Parent UI context (needs to be set explicitly by parent).<br/>
		/// </summary>
		public IntPtr Ctx;
		/// <summary>
		/// Window name, owned by the window.<br/>
		/// </summary>
		public unsafe byte* Name;
		/// <summary>
		/// == ImHashStr(Name)<br/>
		/// </summary>
		public uint ID;
		/// <summary>
		/// See enum ImGuiWindowFlags_<br/>
		/// </summary>
		public ImGuiWindowFlags Flags;
		/// <summary>
		/// See enum ImGuiWindowFlags_<br/>
		/// </summary>
		public ImGuiWindowFlags FlagsPreviousFrame;
		/// <summary>
		/// Set when window is a child window. See enum ImGuiChildFlags_<br/>
		/// </summary>
		public ImGuiChildFlags ChildFlags;
		/// <summary>
		/// Advanced users only. Set with SetNextWindowClass()<br/>
		/// </summary>
		public ImGuiWindowClass WindowClass;
		/// <summary>
		/// Always set in Begin(). Inactive windows may have a NULL value here if their viewport was discarded.<br/>
		/// </summary>
		public unsafe ImGuiViewportP* Viewport;
		/// <summary>
		/// We backup the viewport id (since the viewport may disappear or never be created if the window is inactive)<br/>
		/// </summary>
		public uint ViewportId;
		/// <summary>
		/// We backup the viewport position (since the viewport may disappear or never be created if the window is inactive)<br/>
		/// </summary>
		public Vector2 ViewportPos;
		/// <summary>
		/// Reset to -1 every frame (index is guaranteed to be valid between NewFrame..EndFrame), only used in the Appearing frame of a tooltip/popup to enforce clamping to a given monitor<br/>
		/// </summary>
		public int ViewportAllowPlatformMonitorExtend;
		/// <summary>
		/// Position (always rounded-up to nearest pixel)<br/>
		/// </summary>
		public Vector2 Pos;
		/// <summary>
		/// Current size (==SizeFull or collapsed title bar size)<br/>
		/// </summary>
		public Vector2 Size;
		/// <summary>
		/// Size when non collapsed<br/>
		/// </summary>
		public Vector2 SizeFull;
		/// <summary>
		/// Size of contents/scrollable client area (calculated from the extents reach of the cursor) from previous frame. Does not include window decoration or window padding.<br/>
		/// </summary>
		public Vector2 ContentSize;
		public Vector2 ContentSizeIdeal;
		/// <summary>
		/// Size of contents/scrollable client area explicitly request by the user via SetNextWindowContentSize().<br/>
		/// </summary>
		public Vector2 ContentSizeExplicit;
		/// <summary>
		/// Window padding at the time of Begin().<br/>
		/// </summary>
		public Vector2 WindowPadding;
		/// <summary>
		/// Window rounding at the time of Begin(). May be clamped lower to avoid rendering artifacts with title bar, menu bar etc.<br/>
		/// </summary>
		public float WindowRounding;
		/// <summary>
		/// Window border size at the time of Begin().<br/>
		/// </summary>
		public float WindowBorderSize;
		/// <summary>
		/// Note that those used to be function before 2024/05/28. If you have old code calling TitleBarHeight() you can change it to TitleBarHeight.<br/>
		/// </summary>
		public float TitleBarHeight;
		/// <summary>
		/// Note that those used to be function before 2024/05/28. If you have old code calling TitleBarHeight() you can change it to TitleBarHeight.<br/>
		/// </summary>
		public float MenuBarHeight;
		/// <summary>
		/// Left/Up offsets. Sum of non-scrolling outer decorations (X1 generally == 0.0f. Y1 generally = TitleBarHeight + MenuBarHeight). Locked during Begin().<br/>
		/// </summary>
		public float DecoOuterSizeX1;
		/// <summary>
		/// Left/Up offsets. Sum of non-scrolling outer decorations (X1 generally == 0.0f. Y1 generally = TitleBarHeight + MenuBarHeight). Locked during Begin().<br/>
		/// </summary>
		public float DecoOuterSizeY1;
		/// <summary>
		/// Right/Down offsets (X2 generally == ScrollbarSize.x, Y2 == ScrollbarSizes.y).<br/>
		/// </summary>
		public float DecoOuterSizeX2;
		/// <summary>
		/// Right/Down offsets (X2 generally == ScrollbarSize.x, Y2 == ScrollbarSizes.y).<br/>
		/// </summary>
		public float DecoOuterSizeY2;
		/// <summary>
		/// Applied AFTER/OVER InnerRect. Specialized for Tables as they use specialized form of clipping and frozen rows/columns are inside InnerRect (and not part of regular decoration sizes).<br/>
		/// </summary>
		public float DecoInnerSizeX1;
		/// <summary>
		/// Applied AFTER/OVER InnerRect. Specialized for Tables as they use specialized form of clipping and frozen rows/columns are inside InnerRect (and not part of regular decoration sizes).<br/>
		/// </summary>
		public float DecoInnerSizeY1;
		/// <summary>
		/// Size of buffer storing Name. May be larger than strlen(Name)!<br/>
		/// </summary>
		public int NameBufLen;
		/// <summary>
		/// == window->GetID("#MOVE")<br/>
		/// </summary>
		public uint MoveId;
		/// <summary>
		/// == window->GetID("#TAB")<br/>
		/// </summary>
		public uint TabId;
		/// <summary>
		/// ID of corresponding item in parent window (for navigation to return from child window to parent window)<br/>
		/// </summary>
		public uint ChildId;
		/// <summary>
		/// ID in the popup stack when this window is used as a popup/menu (because we use generic Name/ID for recycling)<br/>
		/// </summary>
		public uint PopupId;
		public Vector2 Scroll;
		public Vector2 ScrollMax;
		/// <summary>
		/// target scroll position. stored as cursor position with scrolling canceled out, so the highest point is always 0.0f. (FLT_MAX for no change)<br/>
		/// </summary>
		public Vector2 ScrollTarget;
		/// <summary>
		/// 0.0f = scroll so that target position is at top, 0.5f = scroll so that target position is centered<br/>
		/// </summary>
		public Vector2 ScrollTargetCenterRatio;
		/// <summary>
		/// 0.0f = no snapping, >0.0f snapping threshold<br/>
		/// </summary>
		public Vector2 ScrollTargetEdgeSnapDist;
		/// <summary>
		/// Size taken by each scrollbars on their smaller axis. Pay attention! ScrollbarSizes.x == width of the vertical scrollbar, ScrollbarSizes.y = height of the horizontal scrollbar.<br/>
		/// </summary>
		public Vector2 ScrollbarSizes;
		/// <summary>
		/// Are scrollbars visible?<br/>
		/// </summary>
		public byte ScrollbarX;
		/// <summary>
		/// Are scrollbars visible?<br/>
		/// </summary>
		public byte ScrollbarY;
		public byte ViewportOwned;
		/// <summary>
		/// Set to true on Begin(), unless Collapsed<br/>
		/// </summary>
		public byte Active;
		public byte WasActive;
		/// <summary>
		/// Set to true when any widget access the current window<br/>
		/// </summary>
		public byte WriteAccessed;
		/// <summary>
		/// Set when collapsing window to become only title-bar<br/>
		/// </summary>
		public byte Collapsed;
		public byte WantCollapseToggle;
		/// <summary>
		/// Set when items can safely be all clipped (e.g. window not visible or collapsed)<br/>
		/// </summary>
		public byte SkipItems;
		/// <summary>
		/// [EXPERIMENTAL] Reuse previous frame drawn contents, Begin() returns false.<br/>
		/// </summary>
		public byte SkipRefresh;
		/// <summary>
		/// Set during the frame where the window is appearing (or re-appearing)<br/>
		/// </summary>
		public byte Appearing;
		/// <summary>
		/// Do not display (== HiddenFrames*** > 0)<br/>
		/// </summary>
		public byte Hidden;
		/// <summary>
		/// Set on the "Debug##Default" window.<br/>
		/// </summary>
		public byte IsFallbackWindow;
		/// <summary>
		/// Set when passed _ChildWindow, left to false by BeginDocked()<br/>
		/// </summary>
		public byte IsExplicitChild;
		/// <summary>
		/// Set when the window has a close button (p_open != NULL)<br/>
		/// </summary>
		public byte HasCloseButton;
		/// <summary>
		/// Current border being hovered for resize (-1: none, otherwise 0-3)<br/>
		/// </summary>
		public sbyte ResizeBorderHovered;
		/// <summary>
		/// Current border being held for resize (-1: none, otherwise 0-3)<br/>
		/// </summary>
		public sbyte ResizeBorderHeld;
		/// <summary>
		/// Number of Begin() during the current frame (generally 0 or 1, 1+ if appending via multiple Begin/End pairs)<br/>
		/// </summary>
		public short BeginCount;
		/// <summary>
		/// Number of Begin() during the previous frame<br/>
		/// </summary>
		public short BeginCountPreviousFrame;
		/// <summary>
		/// Begin() order within immediate parent window, if we are a child window. Otherwise 0.<br/>
		/// </summary>
		public short BeginOrderWithinParent;
		/// <summary>
		/// Begin() order within entire imgui context. This is mostly used for debugging submission order related issues.<br/>
		/// </summary>
		public short BeginOrderWithinContext;
		/// <summary>
		/// Order within WindowsFocusOrder[], altered when windows are focused.<br/>
		/// </summary>
		public short FocusOrder;
		public sbyte AutoFitFramesX;
		public sbyte AutoFitFramesY;
		public byte AutoFitOnlyGrows;
		public ImGuiDir AutoPosLastDirection;
		/// <summary>
		/// Hide the window for N frames<br/>
		/// </summary>
		public sbyte HiddenFramesCanSkipItems;
		/// <summary>
		/// Hide the window for N frames while allowing items to be submitted so we can measure their size<br/>
		/// </summary>
		public sbyte HiddenFramesCannotSkipItems;
		/// <summary>
		/// Hide the window until frame N at Render() time only<br/>
		/// </summary>
		public sbyte HiddenFramesForRenderOnly;
		/// <summary>
		/// Disable window interactions for N frames<br/>
		/// </summary>
		public sbyte DisableInputsFrames;
		/// <summary>
		/// store acceptable condition flags for SetNextWindowPos() use.<br/>
		/// </summary>
		public ImGuiCond SetWindowPosAllowFlags;
		/// <summary>
		/// store acceptable condition flags for SetNextWindowSize() use.<br/>
		/// </summary>
		public ImGuiCond SetWindowSizeAllowFlags;
		/// <summary>
		/// store acceptable condition flags for SetNextWindowCollapsed() use.<br/>
		/// </summary>
		public ImGuiCond SetWindowCollapsedAllowFlags;
		/// <summary>
		/// store acceptable condition flags for SetNextWindowDock() use.<br/>
		/// </summary>
		public ImGuiCond SetWindowDockAllowFlags;
		/// <summary>
		/// store window position when using a non-zero Pivot (position set needs to be processed when we know the window size)<br/>
		/// </summary>
		public Vector2 SetWindowPosVal;
		/// <summary>
		/// store window pivot for positioning. ImVec2(0, 0) when positioning from top-left corner; ImVec2(0.5f, 0.5f) for centering; ImVec2(1, 1) for bottom right.<br/>
		/// </summary>
		public Vector2 SetWindowPosPivot;
		/// <summary>
		/// ID stack. ID are hashes seeded with the value at the top of the stack. (In theory this should be in the TempData structure)<br/>
		/// </summary>
		public ImVector<uint> IDStack;
		/// <summary>
		/// Temporary per-window data, reset at the beginning of the frame. This used to be called ImGuiDrawContext, hence the "DC" variable name.<br/>
		/// </summary>
		public ImGuiWindowTempData DC;
		/// <summary>
		///     // The best way to understand what those rectangles are is to use the 'Metrics->Tools->Show Windows Rectangles' viewer.<br/>
		///     // The main 'OuterRect', omitted as a field, is window->Rect().<br/>
		/// == Window->Rect() just after setup in Begin(). == window->Rect() for root window.<br/>
		/// </summary>
		public ImRect OuterRectClipped;
		/// <summary>
		/// Inner rectangle (omit title bar, menu bar, scroll bar)<br/>
		/// </summary>
		public ImRect InnerRect;
		/// <summary>
		/// == InnerRect shrunk by WindowPadding*0.5f on each side, clipped within viewport or parent clip rect.<br/>
		/// </summary>
		public ImRect InnerClipRect;
		/// <summary>
		/// Initially covers the whole scrolling region. Reduced by containers e.g columns/tables when active. Shrunk by WindowPadding*1.0f on each side. This is meant to replace ContentRegionRect over time (from 1.71+ onward).<br/>
		/// </summary>
		public ImRect WorkRect;
		/// <summary>
		/// Backup of WorkRect before entering a container such as columns/tables. Used by e.g. SpanAllColumns functions to easily access. Stacked containers are responsible for maintaining this. // FIXME-WORKRECT: Could be a stack?<br/>
		/// </summary>
		public ImRect ParentWorkRect;
		/// <summary>
		/// Current clipping/scissoring rectangle, evolve as we are using PushClipRect(), etc. == DrawList->clip_rect_stack.back().<br/>
		/// </summary>
		public ImRect ClipRect;
		/// <summary>
		/// FIXME: This is currently confusing/misleading. It is essentially WorkRect but not handling of scrolling. We currently rely on it as right/bottom aligned sizing operation need some size to rely on.<br/>
		/// </summary>
		public ImRect ContentRegionRect;
		/// <summary>
		/// Define an optional rectangular hole where mouse will pass-through the window.<br/>
		/// </summary>
		public ImVec2ih HitTestHoleSize;
		public ImVec2ih HitTestHoleOffset;
		/// <summary>
		/// Last frame number the window was Active.<br/>
		/// </summary>
		public int LastFrameActive;
		/// <summary>
		/// Last frame number the window was made Focused.<br/>
		/// </summary>
		public int LastFrameJustFocused;
		/// <summary>
		/// Last timestamp the window was Active (using float as we don't need high precision there)<br/>
		/// </summary>
		public float LastTimeActive;
		public float ItemWidthDefault;
		public ImGuiStorage StateStorage;
		public ImVector<ImGuiOldColumns> ColumnsStorage;
		/// <summary>
		/// User scale multiplier per-window, via SetWindowFontScale()<br/>
		/// </summary>
		public float FontWindowScale;
		public float FontWindowScaleParents;
		public float FontDpiScale;
		/// <summary>
		/// This is a copy of window->CalcFontSize() at the time of Begin(), trying to phase out CalcFontSize() especially as it may be called on non-current window.<br/>
		/// </summary>
		public float FontRefSize;
		/// <summary>
		/// Offset into SettingsWindows[] (offsets are always valid as we only grow the array from the back)<br/>
		/// </summary>
		public int SettingsOffset;
		/// <summary>
		/// == &DrawListInst (for backward compatibility reason with code using imgui_internal.h we keep this a pointer)<br/>
		/// </summary>
		public unsafe ImDrawList* DrawList;
		public ImDrawList DrawListInst;
		/// <summary>
		/// If we are a child _or_ popup _or_ docked window, this is pointing to our parent. Otherwise NULL.<br/>
		/// </summary>
		public unsafe ImGuiWindow* ParentWindow;
		public unsafe ImGuiWindow* ParentWindowInBeginStack;
		/// <summary>
		/// Point to ourself or first ancestor that is not a child window. Doesn't cross through popups/dock nodes.<br/>
		/// </summary>
		public unsafe ImGuiWindow* RootWindow;
		/// <summary>
		/// Point to ourself or first ancestor that is not a child window. Cross through popups parent<>child.<br/>
		/// </summary>
		public unsafe ImGuiWindow* RootWindowPopupTree;
		/// <summary>
		/// Point to ourself or first ancestor that is not a child window. Cross through dock nodes.<br/>
		/// </summary>
		public unsafe ImGuiWindow* RootWindowDockTree;
		/// <summary>
		/// Point to ourself or first ancestor which will display TitleBgActive color when this window is active.<br/>
		/// </summary>
		public unsafe ImGuiWindow* RootWindowForTitleBarHighlight;
		/// <summary>
		/// Point to ourself or first ancestor which doesn't have the NavFlattened flag.<br/>
		/// </summary>
		public unsafe ImGuiWindow* RootWindowForNav;
		/// <summary>
		/// Set to manual link a window to its logical parent so that Shortcut() chain are honoerd (e.g. Tool linked to Document)<br/>
		/// </summary>
		public unsafe ImGuiWindow* ParentWindowForFocusRoute;
		/// <summary>
		/// When going to the menu bar, we remember the child window we came from. (This could probably be made implicit if we kept g.Windows sorted by last focused including child window.)<br/>
		/// </summary>
		public unsafe ImGuiWindow* NavLastChildNavWindow;
		/// <summary>
		/// Last known NavId for this window, per layer (0/1)<br/>
		/// </summary>
		public uint NavLastIds_0;
		public uint NavLastIds_1;
		/// <summary>
		/// Reference rectangle, in window relative space<br/>
		/// </summary>
		public ImRect NavRectRel_0;
		public ImRect NavRectRel_1;
		/// <summary>
		/// Preferred X/Y position updated when moving on a given axis, reset to FLT_MAX.<br/>
		/// </summary>
		public Vector2 NavPreferredScoringPosRel_0;
		public Vector2 NavPreferredScoringPosRel_1;
		/// <summary>
		/// Focus Scope ID at the time of Begin()<br/>
		/// </summary>
		public uint NavRootFocusScopeId;
		/// <summary>
		/// Backup of last idx/vtx count, so when waking up the window we can preallocate and avoid iterative alloc/copy<br/>
		/// </summary>
		public int MemoryDrawListIdxCapacity;
		public int MemoryDrawListVtxCapacity;
		/// <summary>
		/// Set when window extraneous data have been garbage collected<br/>
		/// </summary>
		public byte MemoryCompacted;
		/// <summary>
		///     // Docking<br/>
		/// When docking artifacts are actually visible. When this is set, DockNode is guaranteed to be != NULL. ~~ (DockNode != NULL) && (DockNode->Windows.Size > 1).<br/>
		/// </summary>
		public byte DockIsActive;
		public byte DockNodeIsVisible;
		/// <summary>
		/// Is our window visible this frame? ~~ is the corresponding tab selected?<br/>
		/// </summary>
		public byte DockTabIsVisible;
		public byte DockTabWantClose;
		/// <summary>
		/// Order of the last time the window was visible within its DockNode. This is used to reorder windows that are reappearing on the same frame. Same value between windows that were active and windows that were none are possible.<br/>
		/// </summary>
		public short DockOrder;
		public ImGuiWindowDockStyle DockStyle;
		/// <summary>
		/// Which node are we docked into. Important: Prefer testing DockIsActive in many cases as this will still be set when the dock node is hidden.<br/>
		/// </summary>
		public unsafe ImGuiDockNode* DockNode;
		/// <summary>
		/// Which node are we owning (for parent windows)<br/>
		/// </summary>
		public unsafe ImGuiDockNode* DockNodeAsHost;
		/// <summary>
		/// Backup of last valid DockNode->ID, so single window remember their dock node id even when they are not bound any more<br/>
		/// </summary>
		public uint DockId;
	}

	public unsafe struct ImGuiWindowPtr
	{
		public ImGuiWindow* NativePtr;
	}
}
