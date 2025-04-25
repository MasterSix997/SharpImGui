using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiContextHook
	{
		/// <summary>
		/// A unique ID assigned by AddContextHook()<br/>
		/// </summary>
		public uint HookId;
		public ImGuiContextHookType Type;
		public uint Owner;
		public unsafe void* Callback;
		public unsafe void* UserData;
	}

	public unsafe partial struct ImGuiContextHookPtr
	{
		public ImGuiContextHook* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiContextHook this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImGuiContextHookPtr(ImGuiContextHook* nativePtr) => NativePtr = nativePtr;
		public ImGuiContextHookPtr(IntPtr nativePtr) => NativePtr = (ImGuiContextHook*)nativePtr;
		public static implicit operator ImGuiContextHookPtr(ImGuiContextHook* ptr) => new ImGuiContextHookPtr(ptr);
		public static implicit operator ImGuiContextHookPtr(IntPtr ptr) => new ImGuiContextHookPtr(ptr);
		public static implicit operator ImGuiContextHook*(ImGuiContextHookPtr nativePtr) => nativePtr.NativePtr;
	}
}
