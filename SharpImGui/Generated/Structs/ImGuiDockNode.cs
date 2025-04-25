using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// sizeof() 156~192<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiDockNode
	{
		public uint ID;
		/// <summary>
		/// (Write) Flags shared by all nodes of a same dockspace hierarchy (inherited from the root node)<br/>
		/// </summary>
		public ImGuiDockNodeFlags SharedFlags;
		/// <summary>
		/// (Write) Flags specific to this node<br/>
		/// </summary>
		public ImGuiDockNodeFlags LocalFlags;
		/// <summary>
		/// (Write) Flags specific to this node, applied from windows<br/>
		/// </summary>
		public ImGuiDockNodeFlags LocalFlagsInWindows;
		/// <summary>
		/// (Read)  Effective flags (== SharedFlags | LocalFlagsInNode | LocalFlagsInWindows)<br/>
		/// </summary>
		public ImGuiDockNodeFlags MergedFlags;
		public ImGuiDockNodeState State;
		public unsafe ImGuiDockNode* ParentNode;
		/// <summary>
		/// [Split node only] Child nodes (left/right or top/bottom). Consider switching to an array.<br/>
		/// </summary>
		public unsafe ImGuiDockNode* ChildNodes_0;
		public unsafe ImGuiDockNode* ChildNodes_1;
		/// <summary>
		/// Note: unordered list! Iterate TabBar-&gt;Tabs for user-order.<br/>
		/// </summary>
		public ImVector<ImGuiWindowPtr> Windows;
		public unsafe ImGuiTabBar* TabBar;
		/// <summary>
		/// Current position<br/>
		/// </summary>
		public Vector2 Pos;
		/// <summary>
		/// Current size<br/>
		/// </summary>
		public Vector2 Size;
		/// <summary>
		/// [Split node only] Last explicitly written-to size (overridden when using a splitter affecting the node), used to calculate Size.<br/>
		/// </summary>
		public Vector2 SizeRef;
		/// <summary>
		/// [Split node only] Split axis (X or Y)<br/>
		/// </summary>
		public ImGuiAxis SplitAxis;
		/// <summary>
		/// [Root node only]<br/>
		/// </summary>
		public ImGuiWindowClass WindowClass;
		public uint LastBgColor;
		public unsafe ImGuiWindow* HostWindow;
		/// <summary>
		/// Generally point to window which is ID is == SelectedTabID, but when CTRL+Tabbing this can be a different window.<br/>
		/// </summary>
		public unsafe ImGuiWindow* VisibleWindow;
		/// <summary>
		/// [Root node only] Pointer to central node.<br/>
		/// </summary>
		public unsafe ImGuiDockNode* CentralNode;
		/// <summary>
		/// [Root node only] Set when there is a single visible node within the hierarchy.<br/>
		/// </summary>
		public unsafe ImGuiDockNode* OnlyNodeWithWindows;
		/// <summary>
		/// [Root node only]<br/>
		/// </summary>
		public int CountNodeWithWindows;
		/// <summary>
		/// Last frame number the node was updated or kept alive explicitly with DockSpace() + ImGuiDockNodeFlags_KeepAliveOnly<br/>
		/// </summary>
		public int LastFrameAlive;
		/// <summary>
		/// Last frame number the node was updated.<br/>
		/// </summary>
		public int LastFrameActive;
		/// <summary>
		/// Last frame number the node was focused.<br/>
		/// </summary>
		public int LastFrameFocused;
		/// <summary>
		/// [Root node only] Which of our child docking node (any ancestor in the hierarchy) was last focused.<br/>
		/// </summary>
		public uint LastFocusedNodeId;
		/// <summary>
		/// [Leaf node only] Which of our tab/window is selected.<br/>
		/// </summary>
		public uint SelectedTabId;
		/// <summary>
		/// [Leaf node only] Set when closing a specific tab/window.<br/>
		/// </summary>
		public uint WantCloseTabId;
		/// <summary>
		/// Reference viewport ID from visible window when HostWindow == NULL.<br/>
		/// </summary>
		public uint RefViewportId;
		public ImGuiDataAuthority AuthorityForPos;
		public ImGuiDataAuthority AuthorityForSize;
		public ImGuiDataAuthority AuthorityForViewport;
		/// <summary>
		/// Set to false when the node is hidden (usually disabled as it has no active window)<br/>
		/// </summary>
		public byte IsVisible;
		public byte IsFocused;
		public byte IsBgDrawnThisFrame;
		/// <summary>
		/// Provide space for a close button (if any of the docked window has one). Note that button may be hidden on window without one.<br/>
		/// </summary>
		public byte HasCloseButton;
		public byte HasWindowMenuButton;
		public byte HasCentralNodeChild;
		/// <summary>
		/// Set when closing all tabs at once.<br/>
		/// </summary>
		public byte WantCloseAll;
		public byte WantLockSizeOnce;
		/// <summary>
		/// After a node extraction we need to transition toward moving the newly created host window<br/>
		/// </summary>
		public byte WantMouseMove;
		public byte WantHiddenTabBarUpdate;
		public byte WantHiddenTabBarToggle;
	}

	/// <summary>
	/// sizeof() 156~192<br/>
	/// </summary>
	public unsafe partial struct ImGuiDockNodePtr
	{
		public ImGuiDockNode* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiDockNode this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImGuiDockNodePtr(ImGuiDockNode* nativePtr) => NativePtr = nativePtr;
		public ImGuiDockNodePtr(IntPtr nativePtr) => NativePtr = (ImGuiDockNode*)nativePtr;
		public static implicit operator ImGuiDockNodePtr(ImGuiDockNode* ptr) => new ImGuiDockNodePtr(ptr);
		public static implicit operator ImGuiDockNodePtr(IntPtr ptr) => new ImGuiDockNodePtr(ptr);
		public static implicit operator ImGuiDockNode*(ImGuiDockNodePtr nativePtr) => nativePtr.NativePtr;
	}
}
