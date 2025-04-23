using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiPtrOrIndex
	{
		/// <summary>
		/// Either field can be set, not both. e.g. Dock node tab bars are loose while BeginTabBar() ones are in a pool.<br/>
		/// </summary>
		public unsafe void* Ptr;
		/// <summary>
		/// Usually index in a main pool.<br/>
		/// </summary>
		public int Index;
	}
}
