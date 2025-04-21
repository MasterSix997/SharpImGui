using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiWindowClass
	{
		public uint ClassId;
		public uint ParentViewportId;
		public uint FocusRouteParentWindowId;
		public ImGuiViewportFlags ViewportFlagsOverrideSet;
		public ImGuiViewportFlags ViewportFlagsOverrideClear;
		public ImGuiTabItemFlags TabItemFlagsOverrideSet;
		public ImGuiDockNodeFlags DockNodeFlagsOverrideSet;
		public byte DockingAlwaysTabBar;
		public byte DockingAllowUnclassed;
	}
}
