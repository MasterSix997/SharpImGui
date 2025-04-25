using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// [ALPHA] Rarely used / very advanced uses only. Use with SetNextWindowClass() and DockSpace() functions.<br/>Important: the content of this class is still highly WIP and likely to change and be refactored<br/>before we stabilize Docking features. Please be mindful if using this.<br/>Provide hints:<br/>- To the platform backend via altered viewport flags (enable/disable OS decoration, OS task bar icons, etc.)<br/>- To the platform backend for OS level parent/child relationships of viewport.<br/>- To the docking system for various options and filtering.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiWindowClass
	{
		/// <summary>
		/// User data. 0 = Default class (unclassed). Windows of different classes cannot be docked with each others.<br/>
		/// </summary>
		public uint ClassId;
		/// <summary>
		/// Hint for the platform backend. -1: use default. 0: request platform backend to not parent the platform. != 0: request platform backend to create a parent&lt;&gt;child relationship between the platform windows. Not conforming backends are free to e.g. parent every viewport to the main viewport or not.<br/>
		/// </summary>
		public uint ParentViewportId;
		/// <summary>
		/// ID of parent window for shortcut focus route evaluation, e.g. Shortcut() call from Parent Window will succeed when this window is focused.<br/>
		/// </summary>
		public uint FocusRouteParentWindowId;
		/// <summary>
		/// Viewport flags to set when a window of this class owns a viewport. This allows you to enforce OS decoration or task bar icon, override the defaults on a per-window basis.<br/>
		/// </summary>
		public ImGuiViewportFlags ViewportFlagsOverrideSet;
		/// <summary>
		/// Viewport flags to clear when a window of this class owns a viewport. This allows you to enforce OS decoration or task bar icon, override the defaults on a per-window basis.<br/>
		/// </summary>
		public ImGuiViewportFlags ViewportFlagsOverrideClear;
		/// <summary>
		/// [EXPERIMENTAL] TabItem flags to set when a window of this class gets submitted into a dock node tab bar. May use with ImGuiTabItemFlags_Leading or ImGuiTabItemFlags_Trailing.<br/>
		/// </summary>
		public ImGuiTabItemFlags TabItemFlagsOverrideSet;
		/// <summary>
		/// [EXPERIMENTAL] Dock node flags to set when a window of this class is hosted by a dock node (it doesn't have to be selected!)<br/>
		/// </summary>
		public ImGuiDockNodeFlags DockNodeFlagsOverrideSet;
		/// <summary>
		/// Set to true to enforce single floating windows of this class always having their own docking node (equivalent of setting the global io.ConfigDockingAlwaysTabBar)<br/>
		/// </summary>
		public byte DockingAlwaysTabBar;
		/// <summary>
		/// Set to true to allow windows of this class to be docked/merged with an unclassed window. FIXME-DOCK: Move to DockNodeFlags override?<br/>
		/// </summary>
		public byte DockingAllowUnclassed;
	}

	/// <summary>
	/// [ALPHA] Rarely used / very advanced uses only. Use with SetNextWindowClass() and DockSpace() functions.<br/>Important: the content of this class is still highly WIP and likely to change and be refactored<br/>before we stabilize Docking features. Please be mindful if using this.<br/>Provide hints:<br/>- To the platform backend via altered viewport flags (enable/disable OS decoration, OS task bar icons, etc.)<br/>- To the platform backend for OS level parent/child relationships of viewport.<br/>- To the docking system for various options and filtering.<br/>
	/// </summary>
	public unsafe partial struct ImGuiWindowClassPtr
	{
		public ImGuiWindowClass* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiWindowClass this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImGuiWindowClassPtr(ImGuiWindowClass* nativePtr) => NativePtr = nativePtr;
		public ImGuiWindowClassPtr(IntPtr nativePtr) => NativePtr = (ImGuiWindowClass*)nativePtr;
		public static implicit operator ImGuiWindowClassPtr(ImGuiWindowClass* ptr) => new ImGuiWindowClassPtr(ptr);
		public static implicit operator ImGuiWindowClassPtr(IntPtr ptr) => new ImGuiWindowClassPtr(ptr);
		public static implicit operator ImGuiWindowClass*(ImGuiWindowClassPtr nativePtr) => nativePtr.NativePtr;
	}
}
