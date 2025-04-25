using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Stacked storage data for BeginGroup()/EndGroup()<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiGroupData
	{
		public uint WindowID;
		public Vector2 BackupCursorPos;
		public Vector2 BackupCursorMaxPos;
		public Vector2 BackupCursorPosPrevLine;
		public ImVec1 BackupIndent;
		public ImVec1 BackupGroupOffset;
		public Vector2 BackupCurrLineSize;
		public float BackupCurrLineTextBaseOffset;
		public uint BackupActiveIdIsAlive;
		public byte BackupDeactivatedIdIsAlive;
		public byte BackupHoveredIdIsAlive;
		public byte BackupIsSameLine;
		public byte EmitItem;
	}

	/// <summary>
	/// Stacked storage data for BeginGroup()/EndGroup()<br/>
	/// </summary>
	public unsafe partial struct ImGuiGroupDataPtr
	{
		public ImGuiGroupData* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiGroupData this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImGuiGroupDataPtr(ImGuiGroupData* nativePtr) => NativePtr = nativePtr;
		public ImGuiGroupDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiGroupData*)nativePtr;
		public static implicit operator ImGuiGroupDataPtr(ImGuiGroupData* ptr) => new ImGuiGroupDataPtr(ptr);
		public static implicit operator ImGuiGroupDataPtr(IntPtr ptr) => new ImGuiGroupDataPtr(ptr);
		public static implicit operator ImGuiGroupData*(ImGuiGroupDataPtr nativePtr) => nativePtr.NativePtr;
	}
}
