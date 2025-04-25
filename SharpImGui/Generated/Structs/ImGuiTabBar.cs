using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Storage for a tab bar (sizeof() 160 bytes)<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTabBar
	{
		public unsafe ImGuiWindow* Window;
		public ImVector<ImGuiTabItem> Tabs;
		public ImGuiTabBarFlags Flags;
		/// <summary>
		/// Zero for tab-bars used by docking<br/>
		/// </summary>
		public uint ID;
		/// <summary>
		/// Selected tab/window<br/>
		/// </summary>
		public uint SelectedTabId;
		/// <summary>
		/// Next selected tab/window. Will also trigger a scrolling animation<br/>
		/// </summary>
		public uint NextSelectedTabId;
		/// <summary>
		/// Can occasionally be != SelectedTabId (e.g. when previewing contents for CTRL+TAB preview)<br/>
		/// </summary>
		public uint VisibleTabId;
		public int CurrFrameVisible;
		public int PrevFrameVisible;
		public ImRect BarRect;
		public float CurrTabsContentsHeight;
		/// <summary>
		/// Record the height of contents submitted below the tab bar<br/>
		/// </summary>
		public float PrevTabsContentsHeight;
		/// <summary>
		/// Actual width of all tabs (locked during layout)<br/>
		/// </summary>
		public float WidthAllTabs;
		/// <summary>
		/// Ideal width if all tabs were visible and not clipped<br/>
		/// </summary>
		public float WidthAllTabsIdeal;
		public float ScrollingAnim;
		public float ScrollingTarget;
		public float ScrollingTargetDistToVisibility;
		public float ScrollingSpeed;
		public float ScrollingRectMinX;
		public float ScrollingRectMaxX;
		public float SeparatorMinX;
		public float SeparatorMaxX;
		public uint ReorderRequestTabId;
		public short ReorderRequestOffset;
		public sbyte BeginCount;
		public byte WantLayout;
		public byte VisibleTabWasSubmitted;
		/// <summary>
		/// Set to true when a new tab item or button has been added to the tab bar during last frame<br/>
		/// </summary>
		public byte TabsAddedNew;
		/// <summary>
		/// Number of tabs submitted this frame.<br/>
		/// </summary>
		public short TabsActiveCount;
		/// <summary>
		/// Index of last BeginTabItem() tab for use by EndTabItem()<br/>
		/// </summary>
		public short LastTabItemIdx;
		public float ItemSpacingY;
		/// <summary>
		/// style.FramePadding locked at the time of BeginTabBar()<br/>
		/// </summary>
		public Vector2 FramePadding;
		public Vector2 BackupCursorPos;
		/// <summary>
		/// For non-docking tab bar we re-append names in a contiguous buffer.<br/>
		/// </summary>
		public ImGuiTextBuffer TabsNames;
	}

	/// <summary>
	/// Storage for a tab bar (sizeof() 160 bytes)<br/>
	/// </summary>
	public unsafe partial struct ImGuiTabBarPtr
	{
		public ImGuiTabBar* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiTabBar this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImGuiTabBarPtr(ImGuiTabBar* nativePtr) => NativePtr = nativePtr;
		public ImGuiTabBarPtr(IntPtr nativePtr) => NativePtr = (ImGuiTabBar*)nativePtr;
		public static implicit operator ImGuiTabBarPtr(ImGuiTabBar* ptr) => new ImGuiTabBarPtr(ptr);
		public static implicit operator ImGuiTabBarPtr(IntPtr ptr) => new ImGuiTabBarPtr(ptr);
		public static implicit operator ImGuiTabBar*(ImGuiTabBarPtr nativePtr) => nativePtr.NativePtr;
	}
}
