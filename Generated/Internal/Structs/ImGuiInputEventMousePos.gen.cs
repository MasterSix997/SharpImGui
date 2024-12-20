using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>FIXME: Structures in the union below need to be declared as anonymous unions appears to be an extension?</para>
	/// <para>Using ImVec2() would fail on Clang 'union member 'MousePos' has a non-trivial default constructor'</para>
	/// </summary>
	public unsafe partial struct ImGuiInputEventMousePos
	{
		public float PosX;
		public float PosY;
		public ImGuiMouseSource MouseSource;
	}

	/// <summary>
	/// <para>FIXME: Structures in the union below need to be declared as anonymous unions appears to be an extension?</para>
	/// <para>Using ImVec2() would fail on Clang 'union member 'MousePos' has a non-trivial default constructor'</para>
	/// </summary>
	public unsafe partial struct ImGuiInputEventMousePosPtr
	{
		public ImGuiInputEventMousePos* NativePtr { get; }
		public ImGuiInputEventMousePosPtr(ImGuiInputEventMousePos* nativePtr) => NativePtr = nativePtr;
		public ImGuiInputEventMousePosPtr(IntPtr nativePtr) => NativePtr = (ImGuiInputEventMousePos*)nativePtr;
		public static implicit operator ImGuiInputEventMousePosPtr(ImGuiInputEventMousePos* nativePtr) => new ImGuiInputEventMousePosPtr(nativePtr);
		public static implicit operator ImGuiInputEventMousePos* (ImGuiInputEventMousePosPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiInputEventMousePosPtr(IntPtr nativePtr) => new ImGuiInputEventMousePosPtr(nativePtr);

		public ref float PosX => ref Unsafe.AsRef<float>(&NativePtr->PosX);

		public ref float PosY => ref Unsafe.AsRef<float>(&NativePtr->PosY);

		public ref ImGuiMouseSource MouseSource => ref Unsafe.AsRef<ImGuiMouseSource>(&NativePtr->MouseSource);
	}
}
