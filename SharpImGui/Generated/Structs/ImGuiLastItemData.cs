using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiLastItemData
	{
		public uint ID;
		public ImGuiItemFlags ItemFlags;
		public ImGuiItemStatusFlags StatusFlags;
		public ImRect Rect;
		public ImRect NavRect;
		public ImRect DisplayRect;
		public ImRect ClipRect;
		public ImGuiKey Shortcut;
	}
}
