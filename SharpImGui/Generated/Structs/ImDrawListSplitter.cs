using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Split/Merge functions are used to split the draw list into different layers which can be drawn into out of order.<br/>
	/// This is used by the Columns/Tables API, so items of each column can be batched together in a same draw call.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImDrawListSplitter
	{
		/// <summary>
		/// Current channel number (0)<br/>
		/// </summary>
		public int _Current;
		/// <summary>
		/// Number of active channels (1+)<br/>
		/// </summary>
		public int _Count;
		/// <summary>
		/// Draw channels (not resized down so _Count might be < Channels.Size)<br/>
		/// </summary>
		public ImVector<ImDrawChannel> _Channels;
	}
}
