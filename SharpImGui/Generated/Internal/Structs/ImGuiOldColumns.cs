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
		/// // Offsets from HostWorkRect.Min.x
		/// </summary>
		public float OffMinX;
		/// <summary>
		/// // Offsets from HostWorkRect.Min.x
		/// </summary>
		public float OffMaxX;
		public float LineMinY;
		public float LineMaxY;
		/// <summary>
		/// // Backup of CursorPos at the time of BeginColumns()
		/// </summary>
		public float HostCursorPosY;
		/// <summary>
		/// // Backup of CursorMaxPos at the time of BeginColumns()
		/// </summary>
		public float HostCursorMaxPosX;
		/// <summary>
		/// // Backup of ClipRect at the time of BeginColumns()
		/// </summary>
		public ImRect HostInitialClipRect;
		/// <summary>
		/// // Backup of ClipRect during PushColumnsBackground()/PopColumnsBackground()
		/// </summary>
		public ImRect HostBackupClipRect;
		/// <summary>
		/// //Backup of WorkRect at the time of BeginColumns()
		/// </summary>
		public ImRect HostBackupParentWorkRect;
		public ImVector<ImGuiOldColumnData> Columns;
		public ImDrawListSplitter Splitter;
	}
}
