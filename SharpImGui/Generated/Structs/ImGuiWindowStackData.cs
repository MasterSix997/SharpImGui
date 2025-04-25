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

	/// <summary>
	/// Data saved for each window pushed into the stack<br/>
	/// </summary>
	public unsafe partial struct ImGuiWindowStackDataPtr
	{
		public ImGuiWindowStackData* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiWindowStackData this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImGuiWindowStackDataPtr(ImGuiWindowStackData* nativePtr) => NativePtr = nativePtr;
		public ImGuiWindowStackDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiWindowStackData*)nativePtr;
		public static implicit operator ImGuiWindowStackDataPtr(ImGuiWindowStackData* ptr) => new ImGuiWindowStackDataPtr(ptr);
		public static implicit operator ImGuiWindowStackDataPtr(IntPtr ptr) => new ImGuiWindowStackDataPtr(ptr);
		public static implicit operator ImGuiWindowStackData*(ImGuiWindowStackDataPtr nativePtr) => nativePtr.NativePtr;
	}
}
