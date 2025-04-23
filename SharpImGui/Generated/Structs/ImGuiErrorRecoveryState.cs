using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// sizeof() = 20<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiErrorRecoveryState
	{
		public short SizeOfWindowStack;
		public short SizeOfIDStack;
		public short SizeOfTreeStack;
		public short SizeOfColorStack;
		public short SizeOfStyleVarStack;
		public short SizeOfFontStack;
		public short SizeOfFocusScopeStack;
		public short SizeOfGroupStack;
		public short SizeOfItemFlagsStack;
		public short SizeOfBeginPopupStack;
		public short SizeOfDisabledStack;
	}
}
