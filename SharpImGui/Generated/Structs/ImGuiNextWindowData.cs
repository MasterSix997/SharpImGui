using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiNextWindowData
	{
		public ImGuiNextWindowDataFlags HasFlags;
		public ImGuiCond PosCond;
		public ImGuiCond SizeCond;
		public ImGuiCond CollapsedCond;
		public ImGuiCond DockCond;
		public Vector2 PosVal;
		public Vector2 PosPivotVal;
		public Vector2 SizeVal;
		public Vector2 ContentSizeVal;
		public Vector2 ScrollVal;
		public ImGuiWindowFlags WindowFlags;
		public ImGuiChildFlags ChildFlags;
		public byte PosUndock;
		public byte CollapsedVal;
		public ImRect SizeConstraintRect;
		public unsafe void* SizeCallback;
		public unsafe void* SizeCallbackUserData;
		public float BgAlphaVal;
		public uint ViewportId;
		public uint DockId;
		public ImGuiWindowClass WindowClass;
		public Vector2 MenuBarOffsetMinVal;
		public ImGuiWindowRefreshFlags RefreshFlagsVal;
	}
}
