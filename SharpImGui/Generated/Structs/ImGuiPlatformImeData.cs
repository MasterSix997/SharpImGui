using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// (Optional) Support for IME (Input Method Editor) via the platform_io.Platform_SetImeDataFn() function.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiPlatformImeData
	{
		/// <summary>
		/// A widget wants the IME to be visible<br/>
		/// </summary>
		public byte WantVisible;
		/// <summary>
		/// Position of the input cursor<br/>
		/// </summary>
		public Vector2 InputPos;
		/// <summary>
		/// Line height<br/>
		/// </summary>
		public float InputLineHeight;
	}
}
