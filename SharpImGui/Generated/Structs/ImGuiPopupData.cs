using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiPopupData
	{
		public uint PopupId;
		public unsafe ImGuiWindow* Window;
		public unsafe ImGuiWindow* RestoreNavWindow;
		public int ParentNavLayer;
		public int OpenFrameCount;
		public uint OpenParentId;
		public Vector2 OpenPopupPos;
		public Vector2 OpenMousePos;
	}
}
