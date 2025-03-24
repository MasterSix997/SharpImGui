using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Storage for PushFocusScope(), g.FocusScopeStack[], g.NavFocusRoute[]<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiFocusScopeData
	{
		public uint ID;
		public uint WindowID;
	}
}
