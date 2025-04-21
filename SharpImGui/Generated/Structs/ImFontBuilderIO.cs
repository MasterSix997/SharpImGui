using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImFontBuilderIO
	{
		public unsafe void* FontBuilder_Build;
	}
}
