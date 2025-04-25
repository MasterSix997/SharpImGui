using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Helper: Execute a block of code at maximum once a frame. Convenient if you want to quickly create a UI within deep-nested code that runs multiple times every frame.<br/>Usage: static ImGuiOnceUponAFrame oaf; if (oaf) ImGui::Text("This will be called only once per frame");<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiOnceUponAFrame
	{
		public int RefFrame;
	}

	/// <summary>
	/// Helper: Execute a block of code at maximum once a frame. Convenient if you want to quickly create a UI within deep-nested code that runs multiple times every frame.<br/>Usage: static ImGuiOnceUponAFrame oaf; if (oaf) ImGui::Text("This will be called only once per frame");<br/>
	/// </summary>
	public unsafe partial struct ImGuiOnceUponAFramePtr
	{
		public ImGuiOnceUponAFrame* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiOnceUponAFrame this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImGuiOnceUponAFramePtr(ImGuiOnceUponAFrame* nativePtr) => NativePtr = nativePtr;
		public ImGuiOnceUponAFramePtr(IntPtr nativePtr) => NativePtr = (ImGuiOnceUponAFrame*)nativePtr;
		public static implicit operator ImGuiOnceUponAFramePtr(ImGuiOnceUponAFrame* ptr) => new ImGuiOnceUponAFramePtr(ptr);
		public static implicit operator ImGuiOnceUponAFramePtr(IntPtr ptr) => new ImGuiOnceUponAFramePtr(ptr);
		public static implicit operator ImGuiOnceUponAFrame*(ImGuiOnceUponAFramePtr nativePtr) => nativePtr.NativePtr;
	}
}
