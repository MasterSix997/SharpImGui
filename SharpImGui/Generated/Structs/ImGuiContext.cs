using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiContext
	{
		public byte Initialized;
		/// <summary>
		/// IO.Fonts-> is owned by the ImGuiContext and will be destructed along with it.<br/>
		/// </summary>
		public byte FontAtlasOwnedByContext;
		public ImGuiIO IO;
		public ImGuiPlatformIO PlatformIO;
		public ImGuiStyle Style;
		/// <summary>
		/// = g.IO.ConfigFlags at the time of NewFrame()<br/>
		/// </summary>
		public ImGuiConfigFlags ConfigFlagsCurrFrame;
		public ImGuiConfigFlags ConfigFlagsLastFrame;
		/// <summary>
		/// (Shortcut) == FontStack.empty() ? IO.Font : FontStack.back()<br/>
		/// </summary>
		public unsafe ImFont* Font;
		/// <summary>
		/// (Shortcut) == FontBaseSize * g.CurrentWindow->FontWindowScale == window->FontSize(). Text height for current window.<br/>
		/// </summary>
		public float FontSize;
		/// <summary>
		/// (Shortcut) == IO.FontGlobalScale * Font->Scale * Font->FontSize. Base text height.<br/>
		/// </summary>
		public float FontBaseSize;
		/// <summary>
		/// == FontSize / Font->FontSize<br/>
		/// </summary>
		public float FontScale;
		/// <summary>
		/// Current window/viewport DpiScale == CurrentViewport->DpiScale<br/>
		/// </summary>
		public float CurrentDpiScale;
		public ImDrawListSharedData DrawListSharedData;
		public double Time;
		public int FrameCount;
		public int FrameCountEnded;
		public int FrameCountPlatformEnded;
		public int FrameCountRendered;
		/// <summary>
		/// Set within EndChild()<br/>
		/// </summary>
		public uint WithinEndChildID;
		/// <summary>
		/// Set by NewFrame(), cleared by EndFrame()<br/>
		/// </summary>
		public byte WithinFrameScope;
		/// <summary>
		/// Set by NewFrame(), cleared by EndFrame() when the implicit debug window has been pushed<br/>
		/// </summary>
		public byte WithinFrameScopeWithImplicitWindow;
		/// <summary>
		/// Request full GC<br/>
		/// </summary>
		public byte GcCompactAll;
		/// <summary>
		/// Will call test engine hooks: ImGuiTestEngineHook_ItemAdd(), ImGuiTestEngineHook_ItemInfo(), ImGuiTestEngineHook_Log()<br/>
		/// </summary>
		public byte TestEngineHookItems;
		/// <summary>
		/// Test engine user data<br/>
		/// </summary>
		public unsafe void* TestEngine;
		/// <summary>
		/// Storage for a context name (to facilitate debugging multi-context setups)<br/>
		/// </summary>
		public byte ContextName_0;
		public byte ContextName_1;
		public byte ContextName_2;
		public byte ContextName_3;
		public byte ContextName_4;
		public byte ContextName_5;
		public byte ContextName_6;
		public byte ContextName_7;
		public byte ContextName_8;
		public byte ContextName_9;
		public byte ContextName_10;
		public byte ContextName_11;
		public byte ContextName_12;
		public byte ContextName_13;
		public byte ContextName_14;
		public byte ContextName_15;
		/// <summary>
		///     Inputs<br/>
		/// Input events which will be trickled/written into IO structure.<br/>
		/// </summary>
		public ImVector<ImGuiInputEvent> InputEventsQueue;
		/// <summary>
		/// Past input events processed in NewFrame(). This is to allow domain-specific application to access e.g mouse/pen trail.<br/>
		/// </summary>
		public ImVector<ImGuiInputEvent> InputEventsTrail;
		public ImGuiMouseSource InputEventsNextMouseSource;
		public uint InputEventsNextEventId;
		/// <summary>
		///     Windows state<br/>
		/// Windows, sorted in display order, back to front<br/>
		/// </summary>
		public ImVector<ImGuiWindowPtr> Windows;
		/// <summary>
		/// Root windows, sorted in focus order, back to front.<br/>
		/// </summary>
		public ImVector<ImGuiWindowPtr> WindowsFocusOrder;
		/// <summary>
		/// Temporary buffer used in EndFrame() to reorder windows so parents are kept before their child<br/>
		/// </summary>
		public ImVector<ImGuiWindowPtr> WindowsTempSortBuffer;
		public ImVector<ImGuiWindowStackData> CurrentWindowStack;
		/// <summary>
		/// Map window's ImGuiID to ImGuiWindow*<br/>
		/// </summary>
		public ImGuiStorage WindowsById;
		/// <summary>
		/// Number of unique windows submitted by frame<br/>
		/// </summary>
		public int WindowsActiveCount;
		/// <summary>
		/// Padding around resizable windows for which hovering on counts as hovering the window == ImMax(style.TouchExtraPadding, style.WindowBorderHoverPadding). This isn't so multi-dpi friendly.<br/>
		/// </summary>
		public float WindowsBorderHoverPadding;
		/// <summary>
		/// Set to break in Begin() call.<br/>
		/// </summary>
		public uint DebugBreakInWindow;
		/// <summary>
		/// Window being drawn into<br/>
		/// </summary>
		public unsafe ImGuiWindow* CurrentWindow;
		/// <summary>
		/// Window the mouse is hovering. Will typically catch mouse inputs.<br/>
		/// </summary>
		public unsafe ImGuiWindow* HoveredWindow;
		/// <summary>
		/// Hovered window ignoring MovingWindow. Only set if MovingWindow is set.<br/>
		/// </summary>
		public unsafe ImGuiWindow* HoveredWindowUnderMovingWindow;
		/// <summary>
		/// Window the mouse is hovering. Filled even with _NoMouse. This is currently useful for multi-context compositors.<br/>
		/// </summary>
		public unsafe ImGuiWindow* HoveredWindowBeforeClear;
		/// <summary>
		/// Track the window we clicked on (in order to preserve focus). The actual window that is moved is generally MovingWindow->RootWindowDockTree.<br/>
		/// </summary>
		public unsafe ImGuiWindow* MovingWindow;
		/// <summary>
		/// Track the window we started mouse-wheeling on. Until a timer elapse or mouse has moved, generally keep scrolling the same window even if during the course of scrolling the mouse ends up hovering a child window.<br/>
		/// </summary>
		public unsafe ImGuiWindow* WheelingWindow;
		public Vector2 WheelingWindowRefMousePos;
		/// <summary>
		/// This may be set one frame before WheelingWindow is != NULL<br/>
		/// </summary>
		public int WheelingWindowStartFrame;
		public int WheelingWindowScrolledFrame;
		public float WheelingWindowReleaseTimer;
		public Vector2 WheelingWindowWheelRemainder;
		public Vector2 WheelingAxisAvg;
		/// <summary>
		///     Item/widgets state and tracking information<br/>
		/// Set when we detect multiple items with the same identifier<br/>
		/// </summary>
		public uint DebugDrawIdConflicts;
		/// <summary>
		/// Will call core hooks: DebugHookIdInfo() from GetID functions, used by ID Stack Tool [next HoveredId/ActiveId to not pull in an extra cache-line]<br/>
		/// </summary>
		public uint DebugHookIdInfo;
		/// <summary>
		/// Hovered widget, filled during the frame<br/>
		/// </summary>
		public uint HoveredId;
		public uint HoveredIdPreviousFrame;
		/// <summary>
		/// Count numbers of items using the same ID as last frame's hovered id<br/>
		/// </summary>
		public int HoveredIdPreviousFrameItemCount;
		/// <summary>
		/// Measure contiguous hovering time<br/>
		/// </summary>
		public float HoveredIdTimer;
		/// <summary>
		/// Measure contiguous hovering time where the item has not been active<br/>
		/// </summary>
		public float HoveredIdNotActiveTimer;
		public byte HoveredIdAllowOverlap;
		/// <summary>
		/// At least one widget passed the rect test, but has been discarded by disabled flag or popup inhibit. May be true even if HoveredId == 0.<br/>
		/// </summary>
		public byte HoveredIdIsDisabled;
		/// <summary>
		/// Disable ItemAdd() clipping, essentially a memory-locality friendly copy of LogEnabled<br/>
		/// </summary>
		public byte ItemUnclipByLog;
		/// <summary>
		/// Active widget<br/>
		/// </summary>
		public uint ActiveId;
		/// <summary>
		/// Active widget has been seen this frame (we can't use a bool as the ActiveId may change within the frame)<br/>
		/// </summary>
		public uint ActiveIdIsAlive;
		public float ActiveIdTimer;
		/// <summary>
		/// Set at the time of activation for one frame<br/>
		/// </summary>
		public byte ActiveIdIsJustActivated;
		/// <summary>
		/// Active widget allows another widget to steal active id (generally for overlapping widgets, but not always)<br/>
		/// </summary>
		public byte ActiveIdAllowOverlap;
		/// <summary>
		/// Disable losing active id if the active id window gets unfocused.<br/>
		/// </summary>
		public byte ActiveIdNoClearOnFocusLoss;
		/// <summary>
		/// Track whether the active id led to a press (this is to allow changing between PressOnClick and PressOnRelease without pressing twice). Used by range_select branch.<br/>
		/// </summary>
		public byte ActiveIdHasBeenPressedBefore;
		/// <summary>
		/// Was the value associated to the widget Edited over the course of the Active state.<br/>
		/// </summary>
		public byte ActiveIdHasBeenEditedBefore;
		public byte ActiveIdHasBeenEditedThisFrame;
		public byte ActiveIdFromShortcut;
		public int ActiveIdMouseButton;
		/// <summary>
		/// Clicked offset from upper-left corner, if applicable (currently only set by ButtonBehavior)<br/>
		/// </summary>
		public Vector2 ActiveIdClickOffset;
		public unsafe ImGuiWindow* ActiveIdWindow;
		/// <summary>
		/// Activating source: ImGuiInputSource_Mouse OR ImGuiInputSource_Keyboard OR ImGuiInputSource_Gamepad<br/>
		/// </summary>
		public ImGuiInputSource ActiveIdSource;
		public uint ActiveIdPreviousFrame;
		public ImGuiDeactivatedItemData DeactivatedItemData;
		/// <summary>
		/// Backup of initial value at the time of activation. ONLY SET BY SPECIFIC WIDGETS: DragXXX and SliderXXX.<br/>
		/// </summary>
		public ImGuiDataTypeStorage ActiveIdValueOnActivation;
		/// <summary>
		/// Store the last non-zero ActiveId, useful for animation.<br/>
		/// </summary>
		public uint LastActiveId;
		/// <summary>
		/// Store the last non-zero ActiveId timer since the beginning of activation, useful for animation.<br/>
		/// </summary>
		public float LastActiveIdTimer;
		/// <summary>
		///     Key/Input Ownership + Shortcut Routing system<br/>
		///     - The idea is that instead of "eating" a given key, we can link to an owner.<br/>
		///     - Input query can then read input by specifying ImGuiKeyOwner_Any (== 0), ImGuiKeyOwner_NoOwner (== -1) or a custom ID.<br/>
		///     - Routing is requested ahead of time for a given chord (Key + Mods) and granted in NewFrame().<br/>
		/// Record the last time key mods changed (affect repeat delay when using shortcut logic)<br/>
		/// </summary>
		public double LastKeyModsChangeTime;
		/// <summary>
		/// Record the last time key mods changed away from being 0 (affect repeat delay when using shortcut logic)<br/>
		/// </summary>
		public double LastKeyModsChangeFromNoneTime;
		/// <summary>
		/// Record the last time a keyboard key (ignore mouse/gamepad ones) was pressed.<br/>
		/// </summary>
		public double LastKeyboardKeyPressTime;
		/// <summary>
		/// Lookup to tell if a key can emit char input, see IsKeyChordPotentiallyCharInput(). sizeof() = 20 bytes<br/>
		/// </summary>
		public uint KeysMayBeCharInput;
		public ImGuiKeyOwnerData KeysOwnerData_0;
		public ImGuiKeyOwnerData KeysOwnerData_1;
		public ImGuiKeyOwnerData KeysOwnerData_2;
		public ImGuiKeyOwnerData KeysOwnerData_3;
		public ImGuiKeyOwnerData KeysOwnerData_4;
		public ImGuiKeyOwnerData KeysOwnerData_5;
		public ImGuiKeyOwnerData KeysOwnerData_6;
		public ImGuiKeyOwnerData KeysOwnerData_7;
		public ImGuiKeyOwnerData KeysOwnerData_8;
		public ImGuiKeyOwnerData KeysOwnerData_9;
		public ImGuiKeyOwnerData KeysOwnerData_10;
		public ImGuiKeyOwnerData KeysOwnerData_11;
		public ImGuiKeyOwnerData KeysOwnerData_12;
		public ImGuiKeyOwnerData KeysOwnerData_13;
		public ImGuiKeyOwnerData KeysOwnerData_14;
		public ImGuiKeyOwnerData KeysOwnerData_15;
		public ImGuiKeyOwnerData KeysOwnerData_16;
		public ImGuiKeyOwnerData KeysOwnerData_17;
		public ImGuiKeyOwnerData KeysOwnerData_18;
		public ImGuiKeyOwnerData KeysOwnerData_19;
		public ImGuiKeyOwnerData KeysOwnerData_20;
		public ImGuiKeyOwnerData KeysOwnerData_21;
		public ImGuiKeyOwnerData KeysOwnerData_22;
		public ImGuiKeyOwnerData KeysOwnerData_23;
		public ImGuiKeyOwnerData KeysOwnerData_24;
		public ImGuiKeyOwnerData KeysOwnerData_25;
		public ImGuiKeyOwnerData KeysOwnerData_26;
		public ImGuiKeyOwnerData KeysOwnerData_27;
		public ImGuiKeyOwnerData KeysOwnerData_28;
		public ImGuiKeyOwnerData KeysOwnerData_29;
		public ImGuiKeyOwnerData KeysOwnerData_30;
		public ImGuiKeyOwnerData KeysOwnerData_31;
		public ImGuiKeyOwnerData KeysOwnerData_32;
		public ImGuiKeyOwnerData KeysOwnerData_33;
		public ImGuiKeyOwnerData KeysOwnerData_34;
		public ImGuiKeyOwnerData KeysOwnerData_35;
		public ImGuiKeyOwnerData KeysOwnerData_36;
		public ImGuiKeyOwnerData KeysOwnerData_37;
		public ImGuiKeyOwnerData KeysOwnerData_38;
		public ImGuiKeyOwnerData KeysOwnerData_39;
		public ImGuiKeyOwnerData KeysOwnerData_40;
		public ImGuiKeyOwnerData KeysOwnerData_41;
		public ImGuiKeyOwnerData KeysOwnerData_42;
		public ImGuiKeyOwnerData KeysOwnerData_43;
		public ImGuiKeyOwnerData KeysOwnerData_44;
		public ImGuiKeyOwnerData KeysOwnerData_45;
		public ImGuiKeyOwnerData KeysOwnerData_46;
		public ImGuiKeyOwnerData KeysOwnerData_47;
		public ImGuiKeyOwnerData KeysOwnerData_48;
		public ImGuiKeyOwnerData KeysOwnerData_49;
		public ImGuiKeyOwnerData KeysOwnerData_50;
		public ImGuiKeyOwnerData KeysOwnerData_51;
		public ImGuiKeyOwnerData KeysOwnerData_52;
		public ImGuiKeyOwnerData KeysOwnerData_53;
		public ImGuiKeyOwnerData KeysOwnerData_54;
		public ImGuiKeyOwnerData KeysOwnerData_55;
		public ImGuiKeyOwnerData KeysOwnerData_56;
		public ImGuiKeyOwnerData KeysOwnerData_57;
		public ImGuiKeyOwnerData KeysOwnerData_58;
		public ImGuiKeyOwnerData KeysOwnerData_59;
		public ImGuiKeyOwnerData KeysOwnerData_60;
		public ImGuiKeyOwnerData KeysOwnerData_61;
		public ImGuiKeyOwnerData KeysOwnerData_62;
		public ImGuiKeyOwnerData KeysOwnerData_63;
		public ImGuiKeyOwnerData KeysOwnerData_64;
		public ImGuiKeyOwnerData KeysOwnerData_65;
		public ImGuiKeyOwnerData KeysOwnerData_66;
		public ImGuiKeyOwnerData KeysOwnerData_67;
		public ImGuiKeyOwnerData KeysOwnerData_68;
		public ImGuiKeyOwnerData KeysOwnerData_69;
		public ImGuiKeyOwnerData KeysOwnerData_70;
		public ImGuiKeyOwnerData KeysOwnerData_71;
		public ImGuiKeyOwnerData KeysOwnerData_72;
		public ImGuiKeyOwnerData KeysOwnerData_73;
		public ImGuiKeyOwnerData KeysOwnerData_74;
		public ImGuiKeyOwnerData KeysOwnerData_75;
		public ImGuiKeyOwnerData KeysOwnerData_76;
		public ImGuiKeyOwnerData KeysOwnerData_77;
		public ImGuiKeyOwnerData KeysOwnerData_78;
		public ImGuiKeyOwnerData KeysOwnerData_79;
		public ImGuiKeyOwnerData KeysOwnerData_80;
		public ImGuiKeyOwnerData KeysOwnerData_81;
		public ImGuiKeyOwnerData KeysOwnerData_82;
		public ImGuiKeyOwnerData KeysOwnerData_83;
		public ImGuiKeyOwnerData KeysOwnerData_84;
		public ImGuiKeyOwnerData KeysOwnerData_85;
		public ImGuiKeyOwnerData KeysOwnerData_86;
		public ImGuiKeyOwnerData KeysOwnerData_87;
		public ImGuiKeyOwnerData KeysOwnerData_88;
		public ImGuiKeyOwnerData KeysOwnerData_89;
		public ImGuiKeyOwnerData KeysOwnerData_90;
		public ImGuiKeyOwnerData KeysOwnerData_91;
		public ImGuiKeyOwnerData KeysOwnerData_92;
		public ImGuiKeyOwnerData KeysOwnerData_93;
		public ImGuiKeyOwnerData KeysOwnerData_94;
		public ImGuiKeyOwnerData KeysOwnerData_95;
		public ImGuiKeyOwnerData KeysOwnerData_96;
		public ImGuiKeyOwnerData KeysOwnerData_97;
		public ImGuiKeyOwnerData KeysOwnerData_98;
		public ImGuiKeyOwnerData KeysOwnerData_99;
		public ImGuiKeyOwnerData KeysOwnerData_100;
		public ImGuiKeyOwnerData KeysOwnerData_101;
		public ImGuiKeyOwnerData KeysOwnerData_102;
		public ImGuiKeyOwnerData KeysOwnerData_103;
		public ImGuiKeyOwnerData KeysOwnerData_104;
		public ImGuiKeyOwnerData KeysOwnerData_105;
		public ImGuiKeyOwnerData KeysOwnerData_106;
		public ImGuiKeyOwnerData KeysOwnerData_107;
		public ImGuiKeyOwnerData KeysOwnerData_108;
		public ImGuiKeyOwnerData KeysOwnerData_109;
		public ImGuiKeyOwnerData KeysOwnerData_110;
		public ImGuiKeyOwnerData KeysOwnerData_111;
		public ImGuiKeyOwnerData KeysOwnerData_112;
		public ImGuiKeyOwnerData KeysOwnerData_113;
		public ImGuiKeyOwnerData KeysOwnerData_114;
		public ImGuiKeyOwnerData KeysOwnerData_115;
		public ImGuiKeyOwnerData KeysOwnerData_116;
		public ImGuiKeyOwnerData KeysOwnerData_117;
		public ImGuiKeyOwnerData KeysOwnerData_118;
		public ImGuiKeyOwnerData KeysOwnerData_119;
		public ImGuiKeyOwnerData KeysOwnerData_120;
		public ImGuiKeyOwnerData KeysOwnerData_121;
		public ImGuiKeyOwnerData KeysOwnerData_122;
		public ImGuiKeyOwnerData KeysOwnerData_123;
		public ImGuiKeyOwnerData KeysOwnerData_124;
		public ImGuiKeyOwnerData KeysOwnerData_125;
		public ImGuiKeyOwnerData KeysOwnerData_126;
		public ImGuiKeyOwnerData KeysOwnerData_127;
		public ImGuiKeyOwnerData KeysOwnerData_128;
		public ImGuiKeyOwnerData KeysOwnerData_129;
		public ImGuiKeyOwnerData KeysOwnerData_130;
		public ImGuiKeyOwnerData KeysOwnerData_131;
		public ImGuiKeyOwnerData KeysOwnerData_132;
		public ImGuiKeyOwnerData KeysOwnerData_133;
		public ImGuiKeyOwnerData KeysOwnerData_134;
		public ImGuiKeyOwnerData KeysOwnerData_135;
		public ImGuiKeyOwnerData KeysOwnerData_136;
		public ImGuiKeyOwnerData KeysOwnerData_137;
		public ImGuiKeyOwnerData KeysOwnerData_138;
		public ImGuiKeyOwnerData KeysOwnerData_139;
		public ImGuiKeyOwnerData KeysOwnerData_140;
		public ImGuiKeyOwnerData KeysOwnerData_141;
		public ImGuiKeyOwnerData KeysOwnerData_142;
		public ImGuiKeyOwnerData KeysOwnerData_143;
		public ImGuiKeyOwnerData KeysOwnerData_144;
		public ImGuiKeyOwnerData KeysOwnerData_145;
		public ImGuiKeyOwnerData KeysOwnerData_146;
		public ImGuiKeyOwnerData KeysOwnerData_147;
		public ImGuiKeyOwnerData KeysOwnerData_148;
		public ImGuiKeyOwnerData KeysOwnerData_149;
		public ImGuiKeyOwnerData KeysOwnerData_150;
		public ImGuiKeyOwnerData KeysOwnerData_151;
		public ImGuiKeyOwnerData KeysOwnerData_152;
		public ImGuiKeyOwnerData KeysOwnerData_153;
		public ImGuiKeyOwnerData KeysOwnerData_154;
		public ImGuiKeyRoutingTable KeysRoutingTable;
		/// <summary>
		/// Active widget will want to read those nav move requests (e.g. can activate a button and move away from it)<br/>
		/// </summary>
		public uint ActiveIdUsingNavDirMask;
		/// <summary>
		/// Active widget will want to read all keyboard keys inputs. (this is a shortcut for not taking ownership of 100+ keys, frequently used by drag operations)<br/>
		/// </summary>
		public byte ActiveIdUsingAllKeyboardKeys;
		/// <summary>
		/// Set to break in SetShortcutRouting()/Shortcut() calls.<br/>
		/// </summary>
		public ImGuiKey DebugBreakInShortcutRouting;
		/// <summary>
		///     Next window/item data<br/>
		/// Value for currently appending items == g.FocusScopeStack.back(). Not to be mistaken with g.NavFocusScopeId.<br/>
		/// </summary>
		public uint CurrentFocusScopeId;
		/// <summary>
		/// Value for currently appending items == g.ItemFlagsStack.back()<br/>
		/// </summary>
		public ImGuiItemFlags CurrentItemFlags;
		/// <summary>
		/// Storage for DebugLocateItemOnHover() feature: this is read by ItemAdd() so we keep it in a hot/cached location<br/>
		/// </summary>
		public uint DebugLocateId;
		/// <summary>
		/// Storage for SetNextItem** functions<br/>
		/// </summary>
		public ImGuiNextItemData NextItemData;
		/// <summary>
		/// Storage for last submitted item (setup by ItemAdd)<br/>
		/// </summary>
		public ImGuiLastItemData LastItemData;
		/// <summary>
		/// Storage for SetNextWindow** functions<br/>
		/// </summary>
		public ImGuiNextWindowData NextWindowData;
		public byte DebugShowGroupRects;
		/// <summary>
		///     Shared stacks<br/>
		/// (Keep close to ColorStack to share cache line)<br/>
		/// </summary>
		public ImGuiCol DebugFlashStyleColorIdx;
		/// <summary>
		/// Stack for PushStyleColor()/PopStyleColor() - inherited by Begin()<br/>
		/// </summary>
		public ImVector<ImGuiColorMod> ColorStack;
		/// <summary>
		/// Stack for PushStyleVar()/PopStyleVar() - inherited by Begin()<br/>
		/// </summary>
		public ImVector<ImGuiStyleMod> StyleVarStack;
		/// <summary>
		/// Stack for PushFont()/PopFont() - inherited by Begin()<br/>
		/// </summary>
		public ImVector<ImFontPtr> FontStack;
		/// <summary>
		/// Stack for PushFocusScope()/PopFocusScope() - inherited by BeginChild(), pushed into by Begin()<br/>
		/// </summary>
		public ImVector<ImGuiFocusScopeData> FocusScopeStack;
		/// <summary>
		/// Stack for PushItemFlag()/PopItemFlag() - inherited by Begin()<br/>
		/// </summary>
		public ImVector<ImGuiItemFlags> ItemFlagsStack;
		/// <summary>
		/// Stack for BeginGroup()/EndGroup() - not inherited by Begin()<br/>
		/// </summary>
		public ImVector<ImGuiGroupData> GroupStack;
		/// <summary>
		/// Which popups are open (persistent)<br/>
		/// </summary>
		public ImVector<ImGuiPopupData> OpenPopupStack;
		/// <summary>
		/// Which level of BeginPopup() we are in (reset every frame)<br/>
		/// </summary>
		public ImVector<ImGuiPopupData> BeginPopupStack;
		/// <summary>
		/// Stack for TreeNode()<br/>
		/// </summary>
		public ImVector<ImGuiTreeNodeStackData> TreeNodeStack;
		/// <summary>
		///     Viewports<br/>
		/// Active viewports (always 1+, and generally 1 unless multi-viewports are enabled). Each viewports hold their copy of ImDrawData.<br/>
		/// </summary>
		public ImVector<ImGuiViewportPPtr> Viewports;
		/// <summary>
		/// We track changes of viewport (happening in Begin) so we can call Platform_OnChangedViewport()<br/>
		/// </summary>
		public unsafe ImGuiViewportP* CurrentViewport;
		public unsafe ImGuiViewportP* MouseViewport;
		/// <summary>
		/// Last known viewport that was hovered by mouse (even if we are not hovering any viewport any more) + honoring the _NoInputs flag.<br/>
		/// </summary>
		public unsafe ImGuiViewportP* MouseLastHoveredViewport;
		public uint PlatformLastFocusedViewportId;
		/// <summary>
		/// Virtual monitor used as fallback if backend doesn't provide monitor information.<br/>
		/// </summary>
		public ImGuiPlatformMonitor FallbackMonitor;
		/// <summary>
		/// Bounding box of all platform monitors<br/>
		/// </summary>
		public ImRect PlatformMonitorsFullWorkRect;
		/// <summary>
		/// Unique sequential creation counter (mostly for testing/debugging)<br/>
		/// </summary>
		public int ViewportCreatedCount;
		/// <summary>
		/// Unique sequential creation counter (mostly for testing/debugging)<br/>
		/// </summary>
		public int PlatformWindowsCreatedCount;
		/// <summary>
		/// Every time the front-most window changes, we stamp its viewport with an incrementing counter<br/>
		/// </summary>
		public int ViewportFocusedStampCount;
		/// <summary>
		///     Keyboard/Gamepad Navigation<br/>
		/// Nav focus cursor/rectangle is visible? We hide it after a mouse click. We show it after a nav move.<br/>
		/// </summary>
		public byte NavCursorVisible;
		/// <summary>
		/// Disable mouse hovering highlight. Highlight navigation focused item instead of mouse hovered item.<br/>
		/// </summary>
		public byte NavHighlightItemUnderNav;
		/// <summary>
		/// <br/>
		///     //bool                  NavDisableHighlight;                Old name for !g.NavCursorVisible before 1.91.4 (2024/10/18). OPPOSITE VALUE (g.NavDisableHighlight == !g.NavCursorVisible)<br/>
		///     //bool                  NavDisableMouseHover;               Old name for g.NavHighlightItemUnderNav before 1.91.1 (2024/10/18) this was called When user starts using keyboard/gamepad, we hide mouse hovering highlight until mouse is touched again.<br/>
		/// When set we will update mouse position if io.ConfigNavMoveSetMousePos is set (not enabled by default)<br/>
		/// </summary>
		public byte NavMousePosDirty;
		/// <summary>
		/// Nav widget has been seen this frame ~~ NavRectRel is valid<br/>
		/// </summary>
		public byte NavIdIsAlive;
		/// <summary>
		/// Focused item for navigation<br/>
		/// </summary>
		public uint NavId;
		/// <summary>
		/// Focused window for navigation. Could be called 'FocusedWindow'<br/>
		/// </summary>
		public unsafe ImGuiWindow* NavWindow;
		/// <summary>
		/// Focused focus scope (e.g. selection code often wants to "clear other items" when landing on an item of the same scope)<br/>
		/// </summary>
		public uint NavFocusScopeId;
		/// <summary>
		/// Focused layer (main scrolling layer, or menu/title bar layer)<br/>
		/// </summary>
		public ImGuiNavLayer NavLayer;
		/// <summary>
		/// ~~ (g.ActiveId == 0) && (IsKeyPressed(ImGuiKey_Space) || IsKeyDown(ImGuiKey_Enter) || IsKeyPressed(ImGuiKey_NavGamepadActivate)) ? NavId : 0, also set when calling ActivateItem()<br/>
		/// </summary>
		public uint NavActivateId;
		/// <summary>
		/// ~~ IsKeyDown(ImGuiKey_Space) || IsKeyDown(ImGuiKey_Enter) || IsKeyDown(ImGuiKey_NavGamepadActivate) ? NavId : 0<br/>
		/// </summary>
		public uint NavActivateDownId;
		/// <summary>
		/// ~~ IsKeyPressed(ImGuiKey_Space) || IsKeyPressed(ImGuiKey_Enter) || IsKeyPressed(ImGuiKey_NavGamepadActivate) ? NavId : 0 (no repeat)<br/>
		/// </summary>
		public uint NavActivatePressedId;
		public ImGuiActivateFlags NavActivateFlags;
		/// <summary>
		/// Reversed copy focus scope stack for NavId (should contains NavFocusScopeId). This essentially follow the window->ParentWindowForFocusRoute chain.<br/>
		/// </summary>
		public ImVector<ImGuiFocusScopeData> NavFocusRoute;
		public uint NavHighlightActivatedId;
		public float NavHighlightActivatedTimer;
		/// <summary>
		/// Set by ActivateItem(), queued until next frame.<br/>
		/// </summary>
		public uint NavNextActivateId;
		public ImGuiActivateFlags NavNextActivateFlags;
		/// <summary>
		/// Keyboard or Gamepad mode? THIS CAN ONLY BE ImGuiInputSource_Keyboard or ImGuiInputSource_Mouse<br/>
		/// </summary>
		public ImGuiInputSource NavInputSource;
		/// <summary>
		/// Last valid data passed to SetNextItemSelectionUser(), or -1. For current window. Not reset when focusing an item that doesn't have selection data.<br/>
		/// </summary>
		public long NavLastValidSelectionUserData;
		public sbyte NavCursorHideFrames;
		/// <summary>
		///     Navigation: Init & Move Requests<br/>
		/// ~~ NavMoveRequest || NavInitRequest this is to perform early out in ItemAdd()<br/>
		/// </summary>
		public byte NavAnyRequest;
		/// <summary>
		/// Init request for appearing window to select first item<br/>
		/// </summary>
		public byte NavInitRequest;
		public byte NavInitRequestFromMove;
		/// <summary>
		/// Init request result (first item of the window, or one for which SetItemDefaultFocus() was called)<br/>
		/// </summary>
		public ImGuiNavItemData NavInitResult;
		/// <summary>
		/// Move request submitted, will process result on next NewFrame()<br/>
		/// </summary>
		public byte NavMoveSubmitted;
		/// <summary>
		/// Move request submitted, still scoring incoming items<br/>
		/// </summary>
		public byte NavMoveScoringItems;
		public byte NavMoveForwardToNextFrame;
		public ImGuiNavMoveFlags NavMoveFlags;
		public ImGuiScrollFlags NavMoveScrollFlags;
		public ImGuiKey NavMoveKeyMods;
		/// <summary>
		/// Direction of the move request (left/right/up/down)<br/>
		/// </summary>
		public ImGuiDir NavMoveDir;
		public ImGuiDir NavMoveDirForDebug;
		/// <summary>
		/// FIXME-NAV: Describe the purpose of this better. Might want to rename?<br/>
		/// </summary>
		public ImGuiDir NavMoveClipDir;
		/// <summary>
		/// Rectangle used for scoring, in screen space. Based of window->NavRectRel[], modified for directional navigation scoring.<br/>
		/// </summary>
		public ImRect NavScoringRect;
		/// <summary>
		/// Some nav operations (such as PageUp/PageDown) enforce a region which clipper will attempt to always keep submitted<br/>
		/// </summary>
		public ImRect NavScoringNoClipRect;
		/// <summary>
		/// Metrics for debugging<br/>
		/// </summary>
		public int NavScoringDebugCount;
		/// <summary>
		/// Generally -1 or +1, 0 when tabbing without a nav id<br/>
		/// </summary>
		public int NavTabbingDir;
		/// <summary>
		/// >0 when counting items for tabbing<br/>
		/// </summary>
		public int NavTabbingCounter;
		/// <summary>
		/// Best move request candidate within NavWindow<br/>
		/// </summary>
		public ImGuiNavItemData NavMoveResultLocal;
		/// <summary>
		/// Best move request candidate within NavWindow that are mostly visible (when using ImGuiNavMoveFlags_AlsoScoreVisibleSet flag)<br/>
		/// </summary>
		public ImGuiNavItemData NavMoveResultLocalVisible;
		/// <summary>
		/// Best move request candidate within NavWindow's flattened hierarchy (when using ImGuiWindowFlags_NavFlattened flag)<br/>
		/// </summary>
		public ImGuiNavItemData NavMoveResultOther;
		/// <summary>
		/// First tabbing request candidate within NavWindow and flattened hierarchy<br/>
		/// </summary>
		public ImGuiNavItemData NavTabbingResultFirst;
		/// <summary>
		///     Navigation: record of last move request<br/>
		/// Just navigated from this focus scope id (result of a successfully MoveRequest).<br/>
		/// </summary>
		public uint NavJustMovedFromFocusScopeId;
		/// <summary>
		/// Just navigated to this id (result of a successfully MoveRequest).<br/>
		/// </summary>
		public uint NavJustMovedToId;
		/// <summary>
		/// Just navigated to this focus scope id (result of a successfully MoveRequest).<br/>
		/// </summary>
		public uint NavJustMovedToFocusScopeId;
		public ImGuiKey NavJustMovedToKeyMods;
		/// <summary>
		/// Copy of ImGuiNavMoveFlags_IsTabbing. Maybe we should store whole flags.<br/>
		/// </summary>
		public byte NavJustMovedToIsTabbing;
		/// <summary>
		/// Copy of move result's ItemFlags & ImGuiItemFlags_HasSelectionUserData). Maybe we should just store ImGuiNavItemData.<br/>
		/// </summary>
		public byte NavJustMovedToHasSelectionData;
		/// <summary>
		///     Navigation: Windowing (CTRL+TAB for list, or Menu button + keys or directional pads to move/resize)<br/>
		/// = ImGuiMod_Ctrl | ImGuiKey_Tab (or ImGuiMod_Super | ImGuiKey_Tab on OS X). For reconfiguration (see #4828)<br/>
		/// </summary>
		public ImGuiKey ConfigNavWindowingKeyNext;
		/// <summary>
		/// = ImGuiMod_Ctrl | ImGuiMod_Shift | ImGuiKey_Tab (or ImGuiMod_Super | ImGuiMod_Shift | ImGuiKey_Tab on OS X)<br/>
		/// </summary>
		public ImGuiKey ConfigNavWindowingKeyPrev;
		/// <summary>
		/// Target window when doing CTRL+Tab (or Pad Menu + FocusPrev/Next), this window is temporarily displayed top-most!<br/>
		/// </summary>
		public unsafe ImGuiWindow* NavWindowingTarget;
		/// <summary>
		/// Record of last valid NavWindowingTarget until DimBgRatio and NavWindowingHighlightAlpha becomes 0.0f, so the fade-out can stay on it.<br/>
		/// </summary>
		public unsafe ImGuiWindow* NavWindowingTargetAnim;
		/// <summary>
		/// Internal window actually listing the CTRL+Tab contents<br/>
		/// </summary>
		public unsafe ImGuiWindow* NavWindowingListWindow;
		public float NavWindowingTimer;
		public float NavWindowingHighlightAlpha;
		public byte NavWindowingToggleLayer;
		public ImGuiKey NavWindowingToggleKey;
		public Vector2 NavWindowingAccumDeltaPos;
		public Vector2 NavWindowingAccumDeltaSize;
		/// <summary>
		///     Render<br/>
		/// 0.0..1.0 animation when fading in a dimming background (for modal window and CTRL+TAB list)<br/>
		/// </summary>
		public float DimBgRatio;
		/// <summary>
		///     Drag and Drop<br/>
		/// </summary>
		public byte DragDropActive;
		/// <summary>
		/// Set when within a BeginDragDropXXX/EndDragDropXXX block for a drag source.<br/>
		/// </summary>
		public byte DragDropWithinSource;
		/// <summary>
		/// Set when within a BeginDragDropXXX/EndDragDropXXX block for a drag target.<br/>
		/// </summary>
		public byte DragDropWithinTarget;
		public ImGuiDragDropFlags DragDropSourceFlags;
		public int DragDropSourceFrameCount;
		public int DragDropMouseButton;
		public ImGuiPayload DragDropPayload;
		/// <summary>
		/// Store rectangle of current target candidate (we favor small targets when overlapping)<br/>
		/// </summary>
		public ImRect DragDropTargetRect;
		/// <summary>
		/// Store ClipRect at the time of item's drawing<br/>
		/// </summary>
		public ImRect DragDropTargetClipRect;
		public uint DragDropTargetId;
		public ImGuiDragDropFlags DragDropAcceptFlags;
		/// <summary>
		/// Target item surface (we resolve overlapping targets by prioritizing the smaller surface)<br/>
		/// </summary>
		public float DragDropAcceptIdCurrRectSurface;
		/// <summary>
		/// Target item id (set at the time of accepting the payload)<br/>
		/// </summary>
		public uint DragDropAcceptIdCurr;
		/// <summary>
		/// Target item id from previous frame (we need to store this to allow for overlapping drag and drop targets)<br/>
		/// </summary>
		public uint DragDropAcceptIdPrev;
		/// <summary>
		/// Last time a target expressed a desire to accept the source<br/>
		/// </summary>
		public int DragDropAcceptFrameCount;
		/// <summary>
		/// Set when holding a payload just made ButtonBehavior() return a press.<br/>
		/// </summary>
		public uint DragDropHoldJustPressedId;
		/// <summary>
		/// We don't expose the ImVector<> directly, ImGuiPayload only holds pointer+size<br/>
		/// </summary>
		public ImVector<byte> DragDropPayloadBufHeap;
		/// <summary>
		/// Local buffer for small payloads<br/>
		/// </summary>
		public byte DragDropPayloadBufLocal_0;
		public byte DragDropPayloadBufLocal_1;
		public byte DragDropPayloadBufLocal_2;
		public byte DragDropPayloadBufLocal_3;
		public byte DragDropPayloadBufLocal_4;
		public byte DragDropPayloadBufLocal_5;
		public byte DragDropPayloadBufLocal_6;
		public byte DragDropPayloadBufLocal_7;
		public byte DragDropPayloadBufLocal_8;
		public byte DragDropPayloadBufLocal_9;
		public byte DragDropPayloadBufLocal_10;
		public byte DragDropPayloadBufLocal_11;
		public byte DragDropPayloadBufLocal_12;
		public byte DragDropPayloadBufLocal_13;
		public byte DragDropPayloadBufLocal_14;
		public byte DragDropPayloadBufLocal_15;
		/// <summary>
		///     Clipper<br/>
		/// </summary>
		public int ClipperTempDataStacked;
		public ImVector<ImGuiListClipperData> ClipperTempData;
		/// <summary>
		///     Tables<br/>
		/// </summary>
		public unsafe ImGuiTable* CurrentTable;
		/// <summary>
		/// Set to break in BeginTable() call.<br/>
		/// </summary>
		public uint DebugBreakInTable;
		/// <summary>
		/// Temporary table data size (because we leave previous instances undestructed, we generally don't use TablesTempData.Size)<br/>
		/// </summary>
		public int TablesTempDataStacked;
		/// <summary>
		/// Temporary table data (buffers reused/shared across instances, support nesting)<br/>
		/// </summary>
		public ImVector<ImGuiTableTempData> TablesTempData;
		/// <summary>
		/// Persistent table data<br/>
		/// </summary>
		public ImPool<ImGuiTable> Tables;
		/// <summary>
		/// Last used timestamp of each tables (SOA, for efficient GC)<br/>
		/// </summary>
		public ImVector<float> TablesLastTimeActive;
		public ImVector<ImDrawChannel> DrawChannelsTempMergeBuffer;
		/// <summary>
		///     Tab bars<br/>
		/// </summary>
		public unsafe ImGuiTabBar* CurrentTabBar;
		public ImPool<ImGuiTabBar> TabBars;
		public ImVector<ImGuiPtrOrIndex> CurrentTabBarStack;
		public ImVector<ImGuiShrinkWidthItem> ShrinkWidthBuffer;
		/// <summary>
		///     Multi-Select state<br/>
		/// </summary>
		public ImGuiBoxSelectState BoxSelectState;
		public unsafe ImGuiMultiSelectTempData* CurrentMultiSelect;
		/// <summary>
		/// Temporary multi-select data size (because we leave previous instances undestructed, we generally don't use MultiSelectTempData.Size)<br/>
		/// </summary>
		public int MultiSelectTempDataStacked;
		public ImVector<ImGuiMultiSelectTempData> MultiSelectTempData;
		public ImPool<ImGuiMultiSelectState> MultiSelectStorage;
		/// <summary>
		///     Hover Delay system<br/>
		/// </summary>
		public uint HoverItemDelayId;
		public uint HoverItemDelayIdPreviousFrame;
		/// <summary>
		/// Currently used by IsItemHovered()<br/>
		/// </summary>
		public float HoverItemDelayTimer;
		/// <summary>
		/// Currently used by IsItemHovered(): grace time before g.TooltipHoverTimer gets cleared.<br/>
		/// </summary>
		public float HoverItemDelayClearTimer;
		/// <summary>
		/// Mouse has once been stationary on this item. Only reset after departing the item.<br/>
		/// </summary>
		public uint HoverItemUnlockedStationaryId;
		/// <summary>
		/// Mouse has once been stationary on this window. Only reset after departing the window.<br/>
		/// </summary>
		public uint HoverWindowUnlockedStationaryId;
		/// <summary>
		///     Mouse state<br/>
		/// </summary>
		public ImGuiMouseCursor MouseCursor;
		/// <summary>
		/// Time the mouse has been stationary (with some loose heuristic)<br/>
		/// </summary>
		public float MouseStationaryTimer;
		public Vector2 MouseLastValidPos;
		/// <summary>
		///     Widget state<br/>
		/// </summary>
		public ImGuiInputTextState InputTextState;
		public ImGuiInputTextDeactivatedState InputTextDeactivatedState;
		public ImFont InputTextPasswordFont;
		/// <summary>
		/// Temporary text input when CTRL+clicking on a slider, etc.<br/>
		/// </summary>
		public uint TempInputId;
		/// <summary>
		/// 0 for all data types<br/>
		/// </summary>
		public ImGuiDataTypeStorage DataTypeZeroValue;
		public int BeginMenuDepth;
		public int BeginComboDepth;
		/// <summary>
		/// Store user options for color edit widgets<br/>
		/// </summary>
		public ImGuiColorEditFlags ColorEditOptions;
		/// <summary>
		/// Set temporarily while inside of the parent-most ColorEdit4/ColorPicker4 (because they call each others).<br/>
		/// </summary>
		public uint ColorEditCurrentID;
		/// <summary>
		/// ID we are saving/restoring HS for<br/>
		/// </summary>
		public uint ColorEditSavedID;
		/// <summary>
		/// Backup of last Hue associated to LastColor, so we can restore Hue in lossy RGB<>HSV round trips<br/>
		/// </summary>
		public float ColorEditSavedHue;
		/// <summary>
		/// Backup of last Saturation associated to LastColor, so we can restore Saturation in lossy RGB<>HSV round trips<br/>
		/// </summary>
		public float ColorEditSavedSat;
		/// <summary>
		/// RGB value with alpha set to 0.<br/>
		/// </summary>
		public uint ColorEditSavedColor;
		/// <summary>
		/// Initial/reference color at the time of opening the color picker.<br/>
		/// </summary>
		public Vector4 ColorPickerRef;
		public ImGuiComboPreviewData ComboPreviewData;
		/// <summary>
		/// Expected border rect, switch to relative edit if moving<br/>
		/// </summary>
		public ImRect WindowResizeBorderExpectedRect;
		public byte WindowResizeRelativeMode;
		/// <summary>
		/// 0: scroll to clicked location, -1/+1: prev/next page.<br/>
		/// </summary>
		public short ScrollbarSeekMode;
		/// <summary>
		/// When scrolling to mouse location: distance between mouse and center of grab box, normalized in parent space.<br/>
		/// </summary>
		public float ScrollbarClickDeltaToGrabCenter;
		public float SliderGrabClickOffset;
		/// <summary>
		/// Accumulated slider delta when using navigation controls.<br/>
		/// </summary>
		public float SliderCurrentAccum;
		/// <summary>
		/// Has the accumulated slider delta changed since last time we tried to apply it?<br/>
		/// </summary>
		public byte SliderCurrentAccumDirty;
		public byte DragCurrentAccumDirty;
		/// <summary>
		/// Accumulator for dragging modification. Always high-precision, not rounded by end-user precision settings<br/>
		/// </summary>
		public float DragCurrentAccum;
		/// <summary>
		/// If speed == 0.0f, uses (max-min) * DragSpeedDefaultRatio<br/>
		/// </summary>
		public float DragSpeedDefaultRatio;
		/// <summary>
		/// Backup for style.Alpha for BeginDisabled()<br/>
		/// </summary>
		public float DisabledAlphaBackup;
		public short DisabledStackSize;
		public short TooltipOverrideCount;
		/// <summary>
		/// Window of last tooltip submitted during the frame<br/>
		/// </summary>
		public unsafe ImGuiWindow* TooltipPreviousWindow;
		/// <summary>
		/// If no custom clipboard handler is defined<br/>
		/// </summary>
		public ImVector<byte> ClipboardHandlerData;
		/// <summary>
		/// A list of menu IDs that were rendered at least once<br/>
		/// </summary>
		public ImVector<uint> MenusIdSubmittedThisFrame;
		/// <summary>
		/// State for GetTypingSelectRequest()<br/>
		/// </summary>
		public ImGuiTypingSelectState TypingSelectState;
		/// <summary>
		///     Platform support<br/>
		/// Data updated by current frame<br/>
		/// </summary>
		public ImGuiPlatformImeData PlatformImeData;
		/// <summary>
		/// Previous frame data. When changed we call the platform_io.Platform_SetImeDataFn() handler.<br/>
		/// </summary>
		public ImGuiPlatformImeData PlatformImeDataPrev;
		public uint PlatformImeViewport;
		/// <summary>
		///     Extensions<br/>
		///     FIXME: We could provide an API to register one slot in an array held in ImGuiContext?<br/>
		/// </summary>
		public ImGuiDockContext DockContext;
		public unsafe void* DockNodeWindowMenuHandler;
		/// <summary>
		///     Settings<br/>
		/// </summary>
		public byte SettingsLoaded;
		/// <summary>
		/// Save .ini Settings to memory when time reaches zero<br/>
		/// </summary>
		public float SettingsDirtyTimer;
		/// <summary>
		/// In memory .ini settings<br/>
		/// </summary>
		public ImGuiTextBuffer SettingsIniData;
		/// <summary>
		/// List of .ini settings handlers<br/>
		/// </summary>
		public ImVector<ImGuiSettingsHandler> SettingsHandlers;
		/// <summary>
		/// ImGuiWindow .ini settings entries<br/>
		/// </summary>
		public ImChunkStream SettingsWindows;
		/// <summary>
		/// ImGuiTable .ini settings entries<br/>
		/// </summary>
		public ImChunkStream SettingsTables;
		/// <summary>
		/// Hooks for extensions (e.g. test engine)<br/>
		/// </summary>
		public ImVector<ImGuiContextHook> Hooks;
		/// <summary>
		/// Next available HookId<br/>
		/// </summary>
		public uint HookIdNext;
		/// <summary>
		///     Localization<br/>
		/// </summary>
		public unsafe byte* LocalizationTable_0;
		public unsafe byte* LocalizationTable_1;
		public unsafe byte* LocalizationTable_2;
		public unsafe byte* LocalizationTable_3;
		public unsafe byte* LocalizationTable_4;
		public unsafe byte* LocalizationTable_5;
		public unsafe byte* LocalizationTable_6;
		public unsafe byte* LocalizationTable_7;
		public unsafe byte* LocalizationTable_8;
		public unsafe byte* LocalizationTable_9;
		public unsafe byte* LocalizationTable_10;
		public unsafe byte* LocalizationTable_11;
		public unsafe byte* LocalizationTable_12;
		/// <summary>
		///     Capture/Logging<br/>
		/// Currently capturing<br/>
		/// </summary>
		public byte LogEnabled;
		/// <summary>
		/// Capture flags/type<br/>
		/// </summary>
		public ImGuiLogFlags LogFlags;
		public unsafe ImGuiWindow* LogWindow;
		/// <summary>
		/// If != NULL log to stdout/ file<br/>
		/// </summary>
		public IntPtr LogFile;
		/// <summary>
		/// Accumulation buffer when log to clipboard. This is pointer so our GImGui static constructor doesn't call heap allocators.<br/>
		/// </summary>
		public ImGuiTextBuffer LogBuffer;
		public unsafe byte* LogNextPrefix;
		public unsafe byte* LogNextSuffix;
		public float LogLinePosY;
		public byte LogLineFirstItem;
		public int LogDepthRef;
		public int LogDepthToExpand;
		/// <summary>
		/// Default/stored value for LogDepthMaxExpand if not specified in the LogXXX function call.<br/>
		/// </summary>
		public int LogDepthToExpandDefault;
		/// <summary>
		///     Error Handling<br/>
		/// = NULL. May be exposed in public API eventually.<br/>
		/// </summary>
		public unsafe void* ErrorCallback;
		/// <summary>
		/// = NULL<br/>
		/// </summary>
		public unsafe void* ErrorCallbackUserData;
		public Vector2 ErrorTooltipLockedPos;
		public byte ErrorFirst;
		/// <summary>
		/// [Internal] Number of errors submitted this frame.<br/>
		/// </summary>
		public int ErrorCountCurrentFrame;
		/// <summary>
		/// [Internal]<br/>
		/// </summary>
		public ImGuiErrorRecoveryState StackSizesInNewFrame;
		/// <summary>
		/// [Internal]<br/>
		/// </summary>
		public unsafe ImGuiErrorRecoveryState* StackSizesInBeginForCurrentWindow;
		/// <summary>
		///     Debug Tools<br/>
		///     (some of the highly frequently used data are interleaved in other structures above: DebugBreakXXX fields, DebugHookIdInfo, DebugLocateId etc.)<br/>
		/// Locked count (preserved when holding CTRL)<br/>
		/// </summary>
		public int DebugDrawIdConflictsCount;
		public ImGuiDebugLogFlags DebugLogFlags;
		public ImGuiTextBuffer DebugLogBuf;
		public ImGuiTextIndex DebugLogIndex;
		public int DebugLogSkippedErrors;
		public ImGuiDebugLogFlags DebugLogAutoDisableFlags;
		public byte DebugLogAutoDisableFrames;
		/// <summary>
		/// For DebugLocateItemOnHover(). This is used together with DebugLocateId which is in a hot/cached spot above.<br/>
		/// </summary>
		public byte DebugLocateFrames;
		/// <summary>
		/// Debug break in ItemAdd() call for g.DebugLocateId.<br/>
		/// </summary>
		public byte DebugBreakInLocateId;
		/// <summary>
		/// = ImGuiKey_Pause<br/>
		/// </summary>
		public ImGuiKey DebugBreakKeyChord;
		/// <summary>
		/// Cycle between 0..9 then wrap around.<br/>
		/// </summary>
		public sbyte DebugBeginReturnValueCullDepth;
		/// <summary>
		/// Item picker is active (started with DebugStartItemPicker())<br/>
		/// </summary>
		public byte DebugItemPickerActive;
		public byte DebugItemPickerMouseButton;
		/// <summary>
		/// Will call IM_DEBUG_BREAK() when encountering this ID<br/>
		/// </summary>
		public uint DebugItemPickerBreakId;
		public float DebugFlashStyleColorTime;
		public Vector4 DebugFlashStyleColorBackup;
		public ImGuiMetricsConfig DebugMetricsConfig;
		public ImGuiIDStackTool DebugIDStackTool;
		public ImGuiDebugAllocInfo DebugAllocInfo;
		/// <summary>
		/// Hovered dock node.<br/>
		/// </summary>
		public unsafe ImGuiDockNode* DebugHoveredDockNode;
		/// <summary>
		///     Misc<br/>
		/// Calculate estimate of framerate for user over the last 60 frames..<br/>
		/// </summary>
		public float FramerateSecPerFrame_0;
		public float FramerateSecPerFrame_1;
		public float FramerateSecPerFrame_2;
		public float FramerateSecPerFrame_3;
		public float FramerateSecPerFrame_4;
		public float FramerateSecPerFrame_5;
		public float FramerateSecPerFrame_6;
		public float FramerateSecPerFrame_7;
		public float FramerateSecPerFrame_8;
		public float FramerateSecPerFrame_9;
		public float FramerateSecPerFrame_10;
		public float FramerateSecPerFrame_11;
		public float FramerateSecPerFrame_12;
		public float FramerateSecPerFrame_13;
		public float FramerateSecPerFrame_14;
		public float FramerateSecPerFrame_15;
		public float FramerateSecPerFrame_16;
		public float FramerateSecPerFrame_17;
		public float FramerateSecPerFrame_18;
		public float FramerateSecPerFrame_19;
		public float FramerateSecPerFrame_20;
		public float FramerateSecPerFrame_21;
		public float FramerateSecPerFrame_22;
		public float FramerateSecPerFrame_23;
		public float FramerateSecPerFrame_24;
		public float FramerateSecPerFrame_25;
		public float FramerateSecPerFrame_26;
		public float FramerateSecPerFrame_27;
		public float FramerateSecPerFrame_28;
		public float FramerateSecPerFrame_29;
		public float FramerateSecPerFrame_30;
		public float FramerateSecPerFrame_31;
		public float FramerateSecPerFrame_32;
		public float FramerateSecPerFrame_33;
		public float FramerateSecPerFrame_34;
		public float FramerateSecPerFrame_35;
		public float FramerateSecPerFrame_36;
		public float FramerateSecPerFrame_37;
		public float FramerateSecPerFrame_38;
		public float FramerateSecPerFrame_39;
		public float FramerateSecPerFrame_40;
		public float FramerateSecPerFrame_41;
		public float FramerateSecPerFrame_42;
		public float FramerateSecPerFrame_43;
		public float FramerateSecPerFrame_44;
		public float FramerateSecPerFrame_45;
		public float FramerateSecPerFrame_46;
		public float FramerateSecPerFrame_47;
		public float FramerateSecPerFrame_48;
		public float FramerateSecPerFrame_49;
		public float FramerateSecPerFrame_50;
		public float FramerateSecPerFrame_51;
		public float FramerateSecPerFrame_52;
		public float FramerateSecPerFrame_53;
		public float FramerateSecPerFrame_54;
		public float FramerateSecPerFrame_55;
		public float FramerateSecPerFrame_56;
		public float FramerateSecPerFrame_57;
		public float FramerateSecPerFrame_58;
		public float FramerateSecPerFrame_59;
		public int FramerateSecPerFrameIdx;
		public int FramerateSecPerFrameCount;
		public float FramerateSecPerFrameAccum;
		/// <summary>
		/// Explicit capture override via SetNextFrameWantCaptureMouse()/SetNextFrameWantCaptureKeyboard(). Default to -1.<br/>
		/// </summary>
		public int WantCaptureMouseNextFrame;
		/// <summary>
		/// "<br/>
		/// </summary>
		public int WantCaptureKeyboardNextFrame;
		public int WantTextInputNextFrame;
		/// <summary>
		/// Temporary text buffer<br/>
		/// </summary>
		public ImVector<byte> TempBuffer;
		public byte TempKeychordName_0;
		public byte TempKeychordName_1;
		public byte TempKeychordName_2;
		public byte TempKeychordName_3;
		public byte TempKeychordName_4;
		public byte TempKeychordName_5;
		public byte TempKeychordName_6;
		public byte TempKeychordName_7;
		public byte TempKeychordName_8;
		public byte TempKeychordName_9;
		public byte TempKeychordName_10;
		public byte TempKeychordName_11;
		public byte TempKeychordName_12;
		public byte TempKeychordName_13;
		public byte TempKeychordName_14;
		public byte TempKeychordName_15;
		public byte TempKeychordName_16;
		public byte TempKeychordName_17;
		public byte TempKeychordName_18;
		public byte TempKeychordName_19;
		public byte TempKeychordName_20;
		public byte TempKeychordName_21;
		public byte TempKeychordName_22;
		public byte TempKeychordName_23;
		public byte TempKeychordName_24;
		public byte TempKeychordName_25;
		public byte TempKeychordName_26;
		public byte TempKeychordName_27;
		public byte TempKeychordName_28;
		public byte TempKeychordName_29;
		public byte TempKeychordName_30;
		public byte TempKeychordName_31;
		public byte TempKeychordName_32;
		public byte TempKeychordName_33;
		public byte TempKeychordName_34;
		public byte TempKeychordName_35;
		public byte TempKeychordName_36;
		public byte TempKeychordName_37;
		public byte TempKeychordName_38;
		public byte TempKeychordName_39;
		public byte TempKeychordName_40;
		public byte TempKeychordName_41;
		public byte TempKeychordName_42;
		public byte TempKeychordName_43;
		public byte TempKeychordName_44;
		public byte TempKeychordName_45;
		public byte TempKeychordName_46;
		public byte TempKeychordName_47;
		public byte TempKeychordName_48;
		public byte TempKeychordName_49;
		public byte TempKeychordName_50;
		public byte TempKeychordName_51;
		public byte TempKeychordName_52;
		public byte TempKeychordName_53;
		public byte TempKeychordName_54;
		public byte TempKeychordName_55;
		public byte TempKeychordName_56;
		public byte TempKeychordName_57;
		public byte TempKeychordName_58;
		public byte TempKeychordName_59;
		public byte TempKeychordName_60;
		public byte TempKeychordName_61;
		public byte TempKeychordName_62;
		public byte TempKeychordName_63;
	}
}
