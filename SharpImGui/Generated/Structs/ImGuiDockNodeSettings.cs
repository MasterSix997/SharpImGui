using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiDockNodeSettings
	{
	}

	public unsafe partial struct ImGuiDockNodeSettingsPtr
	{
		public ImGuiDockNodeSettings* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiDockNodeSettings this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImGuiDockNodeSettingsPtr(ImGuiDockNodeSettings* nativePtr) => NativePtr = nativePtr;
		public ImGuiDockNodeSettingsPtr(IntPtr nativePtr) => NativePtr = (ImGuiDockNodeSettings*)nativePtr;
		public static implicit operator ImGuiDockNodeSettingsPtr(ImGuiDockNodeSettings* ptr) => new ImGuiDockNodeSettingsPtr(ptr);
		public static implicit operator ImGuiDockNodeSettingsPtr(IntPtr ptr) => new ImGuiDockNodeSettingsPtr(ptr);
		public static implicit operator ImGuiDockNodeSettings*(ImGuiDockNodeSettingsPtr nativePtr) => nativePtr.NativePtr;
	}
}
