using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImDrawListSplitter
	{
		public int _Current;
		public int _Count;
		public ImVector<ImDrawChannel> _Channels;
	}
}
