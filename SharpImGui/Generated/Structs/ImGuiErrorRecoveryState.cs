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
		public short SizeOfIdStack;
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

	/// <summary>
	/// sizeof() = 20<br/>
	/// </summary>
	public unsafe partial struct ImGuiErrorRecoveryStatePtr
	{
		public ImGuiErrorRecoveryState* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiErrorRecoveryState this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImGuiErrorRecoveryStatePtr(ImGuiErrorRecoveryState* nativePtr) => NativePtr = nativePtr;
		public ImGuiErrorRecoveryStatePtr(IntPtr nativePtr) => NativePtr = (ImGuiErrorRecoveryState*)nativePtr;
		public static implicit operator ImGuiErrorRecoveryStatePtr(ImGuiErrorRecoveryState* ptr) => new ImGuiErrorRecoveryStatePtr(ptr);
		public static implicit operator ImGuiErrorRecoveryStatePtr(IntPtr ptr) => new ImGuiErrorRecoveryStatePtr(ptr);
		public static implicit operator ImGuiErrorRecoveryState*(ImGuiErrorRecoveryStatePtr nativePtr) => nativePtr.NativePtr;
	}
}
