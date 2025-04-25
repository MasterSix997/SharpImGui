using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiOldColumns
	{
		public uint ID;
		public ImGuiOldColumnFlags Flags;
		public byte IsFirstFrame;
		public byte IsBeingResized;
		public int Current;
		public int Count;
		/// <summary>
		/// Offsets from HostWorkRect.Min.x<br/>
		/// </summary>
		public float OffMinX;
		/// <summary>
		/// Offsets from HostWorkRect.Min.x<br/>
		/// </summary>
		public float OffMaxX;
		public float LineMinY;
		public float LineMaxY;
		/// <summary>
		/// Backup of CursorPos at the time of BeginColumns()<br/>
		/// </summary>
		public float HostCursorPosY;
		/// <summary>
		/// Backup of CursorMaxPos at the time of BeginColumns()<br/>
		/// </summary>
		public float HostCursorMaxPosX;
		/// <summary>
		/// Backup of ClipRect at the time of BeginColumns()<br/>
		/// </summary>
		public ImRect HostInitialClipRect;
		/// <summary>
		/// Backup of ClipRect during PushColumnsBackground()/PopColumnsBackground()<br/>
		/// </summary>
		public ImRect HostBackupClipRect;
		/// <summary>
		/// //Backup of WorkRect at the time of BeginColumns()<br/>
		/// </summary>
		public ImRect HostBackupParentWorkRect;
		public ImVector<ImGuiOldColumnData> Columns;
		public ImDrawListSplitter Splitter;
	}

	public unsafe partial struct ImGuiOldColumnsPtr
	{
		public ImGuiOldColumns* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiOldColumns this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImGuiOldColumnsPtr(ImGuiOldColumns* nativePtr) => NativePtr = nativePtr;
		public ImGuiOldColumnsPtr(IntPtr nativePtr) => NativePtr = (ImGuiOldColumns*)nativePtr;
		public static implicit operator ImGuiOldColumnsPtr(ImGuiOldColumns* ptr) => new ImGuiOldColumnsPtr(ptr);
		public static implicit operator ImGuiOldColumnsPtr(IntPtr ptr) => new ImGuiOldColumnsPtr(ptr);
		public static implicit operator ImGuiOldColumns*(ImGuiOldColumnsPtr nativePtr) => nativePtr.NativePtr;
	}
}
