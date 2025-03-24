using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Helper: Growable text buffer for logging/accumulating text<br/>
	/// (this could be called 'ImGuiTextBuilder' / 'ImGuiStringBuilder')<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTextBuffer
	{
		public ImVector<byte> Buf;
	}
}
