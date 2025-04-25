using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Data used by IsItemDeactivated()/IsItemDeactivatedAfterEdit() functions<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiDeactivatedItemData
	{
		public uint ID;
		public int ElapseFrame;
		public byte HasBeenEditedBefore;
		public byte IsAlive;
	}

	/// <summary>
	/// Data used by IsItemDeactivated()/IsItemDeactivatedAfterEdit() functions<br/>
	/// </summary>
	public unsafe partial struct ImGuiDeactivatedItemDataPtr
	{
		public ImGuiDeactivatedItemData* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiDeactivatedItemData this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImGuiDeactivatedItemDataPtr(ImGuiDeactivatedItemData* nativePtr) => NativePtr = nativePtr;
		public ImGuiDeactivatedItemDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiDeactivatedItemData*)nativePtr;
		public static implicit operator ImGuiDeactivatedItemDataPtr(ImGuiDeactivatedItemData* ptr) => new ImGuiDeactivatedItemDataPtr(ptr);
		public static implicit operator ImGuiDeactivatedItemDataPtr(IntPtr ptr) => new ImGuiDeactivatedItemDataPtr(ptr);
		public static implicit operator ImGuiDeactivatedItemData*(ImGuiDeactivatedItemDataPtr nativePtr) => nativePtr.NativePtr;
	}
}
