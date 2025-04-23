using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Internal temporary state for deactivating InputText() instances.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiInputTextDeactivatedState
	{
		/// <summary>
		/// widget id owning the text state (which just got deactivated)<br/>
		/// </summary>
		public uint ID;
		/// <summary>
		/// text buffer<br/>
		/// </summary>
		public ImVector<byte> TextA;
	}
}
