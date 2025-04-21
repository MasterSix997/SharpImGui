using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiDockNode
	{
		public uint ID;
		public ImGuiDockNodeFlags SharedFlags;
		public ImGuiDockNodeFlags LocalFlags;
		public ImGuiDockNodeFlags LocalFlagsInWindows;
		public ImGuiDockNodeFlags MergedFlags;
		public ImGuiDockNodeState State;
		public unsafe ImGuiDockNode* ParentNode;
		public unsafe ImGuiDockNode* ChildNodes_0;
		public unsafe ImGuiDockNode* ChildNodes_1;
		public ImVector<ImGuiWindowPtr> Windows;
		public unsafe ImGuiTabBar* TabBar;
		public Vector2 Pos;
		public Vector2 Size;
		public Vector2 SizeRef;
		public ImGuiAxis SplitAxis;
		public ImGuiWindowClass WindowClass;
		public uint LastBgColor;
		public unsafe ImGuiWindow* HostWindow;
		public unsafe ImGuiWindow* VisibleWindow;
		public unsafe ImGuiDockNode* CentralNode;
		public unsafe ImGuiDockNode* OnlyNodeWithWindows;
		public int CountNodeWithWindows;
		public int LastFrameAlive;
		public int LastFrameActive;
		public int LastFrameFocused;
		public uint LastFocusedNodeId;
		public uint SelectedTabId;
		public uint WantCloseTabId;
		public uint RefViewportId;
		public ImGuiDataAuthority AuthorityForPos;
		public ImGuiDataAuthority AuthorityForSize;
		public ImGuiDataAuthority AuthorityForViewport;
		public byte IsVisible;
		public byte IsFocused;
		public byte IsBgDrawnThisFrame;
		public byte HasCloseButton;
		public byte HasWindowMenuButton;
		public byte HasCentralNodeChild;
		public byte WantCloseAll;
		public byte WantLockSizeOnce;
		public byte WantMouseMove;
		public byte WantHiddenTabBarUpdate;
		public byte WantHiddenTabBarToggle;
	}
}
