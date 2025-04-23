using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// FIXME: Structures in the union below need to be declared as anonymous unions appears to be an extension?<br/>
	/// Using ImVec2() would fail on Clang 'union member 'MousePos' has a non-trivial default constructor'<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiInputEventMousePos
	{
		public float PosX;
		public float PosY;
		public ImGuiMouseSource MouseSource;
	}
}
