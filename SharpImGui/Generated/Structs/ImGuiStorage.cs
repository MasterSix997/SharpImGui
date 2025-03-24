using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Helper: Key->Value storage<br/>
	/// Typically you don't have to worry about this since a storage is held within each Window.<br/>
	/// We use it to e.g. store collapse state for a tree (Int 0/1)<br/>
	/// This is optimized for efficient lookup (dichotomy into a contiguous buffer) and rare insertion (typically tied to user interactions aka max once a frame)<br/>
	/// You can use it as custom user storage for temporary values. Declare your own storage if, for example:<br/>
	/// - You want to manipulate the open/close state of a particular sub-tree in your interface (tree node uses Int 0/1 to store their state).<br/>
	/// - You want to store custom debug data easily without adding or editing structures in your code (probably not efficient, but convenient)<br/>
	/// Types are NOT stored, so it is up to you to make sure your Key don't collide with different types.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiStorage
	{
		/// <summary>
		/// <br/>
		///     // [Internal]<br/>
		/// </summary>
		public ImVector<ImGuiStoragePair> Data;
	}
}
