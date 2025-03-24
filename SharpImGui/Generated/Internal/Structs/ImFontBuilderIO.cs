using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// This structure is likely to evolve as we add support for incremental atlas updates.<br/>
	/// Conceptually this could be in ImGuiPlatformIO, but we are far from ready to make this public.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImFontBuilderIO
	{
		public unsafe void* FontBuilder_Build;
	}
}
