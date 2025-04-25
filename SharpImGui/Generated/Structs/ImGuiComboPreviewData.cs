using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Storage data for BeginComboPreview()/EndComboPreview()<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiComboPreviewData
	{
		public ImRect PreviewRect;
		public Vector2 BackupCursorPos;
		public Vector2 BackupCursorMaxPos;
		public Vector2 BackupCursorPosPrevLine;
		public float BackupPrevLineTextBaseOffset;
		public ImGuiLayoutType BackupLayout;
	}

	/// <summary>
	/// Storage data for BeginComboPreview()/EndComboPreview()<br/>
	/// </summary>
	public unsafe partial struct ImGuiComboPreviewDataPtr
	{
		public ImGuiComboPreviewData* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiComboPreviewData this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImGuiComboPreviewDataPtr(ImGuiComboPreviewData* nativePtr) => NativePtr = nativePtr;
		public ImGuiComboPreviewDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiComboPreviewData*)nativePtr;
		public static implicit operator ImGuiComboPreviewDataPtr(ImGuiComboPreviewData* ptr) => new ImGuiComboPreviewDataPtr(ptr);
		public static implicit operator ImGuiComboPreviewDataPtr(IntPtr ptr) => new ImGuiComboPreviewDataPtr(ptr);
		public static implicit operator ImGuiComboPreviewData*(ImGuiComboPreviewDataPtr nativePtr) => nativePtr.NativePtr;
	}
}
