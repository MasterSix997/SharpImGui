using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Data saved for each window pushed into the stack<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiWindowStackData
	{
		public unsafe ImGuiWindow* Window;
		public ImGuiLastItemData ParentLastItemDataBackup;
		/// <summary>
		/// Store size of various stacks for asserting<br/>
		/// </summary>
		public ImGuiErrorRecoveryState StackSizesInBegin;
		/// <summary>
		/// Non-child window override disabled flag<br/>
		/// </summary>
		public byte DisabledOverrideReenable;
		public float DisabledOverrideReenableAlphaBackup;
	}
}
