using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	///     [Internal]<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTextRange
	{
		public unsafe byte* B;
		public unsafe byte* E;
	}

	/// <summary>
	///     [Internal]<br/>
	/// </summary>
	public unsafe partial struct ImGuiTextRangePtr
	{
		public ImGuiTextRange* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiTextRange this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImGuiTextRangePtr(ImGuiTextRange* nativePtr) => NativePtr = nativePtr;
		public ImGuiTextRangePtr(IntPtr nativePtr) => NativePtr = (ImGuiTextRange*)nativePtr;
		public static implicit operator ImGuiTextRangePtr(ImGuiTextRange* ptr) => new ImGuiTextRangePtr(ptr);
		public static implicit operator ImGuiTextRangePtr(IntPtr ptr) => new ImGuiTextRangePtr(ptr);
		public static implicit operator ImGuiTextRange*(ImGuiTextRangePtr nativePtr) => nativePtr.NativePtr;
	}
}
