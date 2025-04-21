using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTreeNodeStackData
	{
		public uint ID;
		public ImGuiTreeNodeFlags TreeFlags;
		public ImGuiItemFlags ItemFlags;
		public ImRect NavRect;
	}
}
