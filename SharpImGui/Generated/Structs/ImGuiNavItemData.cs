using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiNavItemData
	{
		public unsafe ImGuiWindow* Window;
		public uint ID;
		public uint FocusScopeId;
		public ImRect RectRel;
		public ImGuiItemFlags ItemFlags;
		public float DistBox;
		public float DistCenter;
		public float DistAxial;
		public long SelectionUserData;
	}
}
