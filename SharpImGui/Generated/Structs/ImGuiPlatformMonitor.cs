using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// (Optional) This is required when enabling multi-viewport. Represent the bounds of each connected monitor/display and their DPI.<br/>We use this information for multiple DPI support + clamping the position of popups and tooltips so they don't straddle multiple monitors.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiPlatformMonitor
	{
		/// <summary>
		/// Coordinates of the area displayed on this monitor (Min = upper left, Max = bottom right)<br/>
		/// </summary>
		public Vector2 MainPos;
		/// <summary>
		/// Coordinates of the area displayed on this monitor (Min = upper left, Max = bottom right)<br/>
		/// </summary>
		public Vector2 MainSize;
		/// <summary>
		/// Coordinates without task bars / side bars / menu bars. Used to avoid positioning popups/tooltips inside this region. If you don't have this info, please copy the value for MainPos/MainSize.<br/>
		/// </summary>
		public Vector2 WorkPos;
		/// <summary>
		/// Coordinates without task bars / side bars / menu bars. Used to avoid positioning popups/tooltips inside this region. If you don't have this info, please copy the value for MainPos/MainSize.<br/>
		/// </summary>
		public Vector2 WorkSize;
		/// <summary>
		/// 1.0f = 96 DPI<br/>
		/// </summary>
		public float DpiScale;
		/// <summary>
		/// Backend dependant data (e.g. HMONITOR, GLFWmonitor*, SDL Display Index, NSScreen*)<br/>
		/// </summary>
		public unsafe void* PlatformHandle;
	}

	/// <summary>
	/// (Optional) This is required when enabling multi-viewport. Represent the bounds of each connected monitor/display and their DPI.<br/>We use this information for multiple DPI support + clamping the position of popups and tooltips so they don't straddle multiple monitors.<br/>
	/// </summary>
	public unsafe partial struct ImGuiPlatformMonitorPtr
	{
		public ImGuiPlatformMonitor* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiPlatformMonitor this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImGuiPlatformMonitorPtr(ImGuiPlatformMonitor* nativePtr) => NativePtr = nativePtr;
		public ImGuiPlatformMonitorPtr(IntPtr nativePtr) => NativePtr = (ImGuiPlatformMonitor*)nativePtr;
		public static implicit operator ImGuiPlatformMonitorPtr(ImGuiPlatformMonitor* ptr) => new ImGuiPlatformMonitorPtr(ptr);
		public static implicit operator ImGuiPlatformMonitorPtr(IntPtr ptr) => new ImGuiPlatformMonitorPtr(ptr);
		public static implicit operator ImGuiPlatformMonitor*(ImGuiPlatformMonitorPtr nativePtr) => nativePtr.NativePtr;
	}
}
