using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiWindowStackData
	{
		public unsafe ImGuiWindow* Window;
		public ImGuiLastItemData ParentLastItemDataBackup;
		public ImGuiErrorRecoveryState StackSizesInBegin;
		public byte DisabledOverrideReenable;
		public float DisabledOverrideReenableAlphaBackup;
	}
}
