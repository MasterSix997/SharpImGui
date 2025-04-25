using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Optional helper to apply multi-selection requests to existing randomly accessible storage.<br/>Convenient if you want to quickly wire multi-select API on e.g. an array of bool or items storing their own selection state.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiSelectionExternalStorage
	{
		/// <summary>
		/// <br/>    Members<br/>
		/// User data for use by adapter function                                e.g. selection.UserData = (void*)my_items;<br/>
		/// </summary>
		public unsafe void* UserData;
		/// <summary>
		/// e.g. AdapterSetItemSelected = [](ImGuiSelectionExternalStorage* self, int idx, bool selected)  ((MyItems**)self-&gt;UserData)[idx]-&gt;Selected = selected; <br/>
		/// </summary>
		public unsafe void* AdapterSetItemSelected;
	}

	/// <summary>
	/// Optional helper to apply multi-selection requests to existing randomly accessible storage.<br/>Convenient if you want to quickly wire multi-select API on e.g. an array of bool or items storing their own selection state.<br/>
	/// </summary>
	public unsafe partial struct ImGuiSelectionExternalStoragePtr
	{
		public ImGuiSelectionExternalStorage* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiSelectionExternalStorage this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImGuiSelectionExternalStoragePtr(ImGuiSelectionExternalStorage* nativePtr) => NativePtr = nativePtr;
		public ImGuiSelectionExternalStoragePtr(IntPtr nativePtr) => NativePtr = (ImGuiSelectionExternalStorage*)nativePtr;
		public static implicit operator ImGuiSelectionExternalStoragePtr(ImGuiSelectionExternalStorage* ptr) => new ImGuiSelectionExternalStoragePtr(ptr);
		public static implicit operator ImGuiSelectionExternalStoragePtr(IntPtr ptr) => new ImGuiSelectionExternalStoragePtr(ptr);
		public static implicit operator ImGuiSelectionExternalStorage*(ImGuiSelectionExternalStoragePtr nativePtr) => nativePtr.NativePtr;
	}
}
