using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Helper: ImGuiTextIndex<br/>
	/// Maintain a line index for a text buffer. This is a strong candidate to be moved into the public API.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTextIndex
	{
		public ImVector<int> LineOffsets;
		/// <summary>
		/// Because we don't own text buffer we need to maintain EndOffset (may bake in LineOffsets?)<br/>
		/// </summary>
		public int EndOffset;
	}
}
