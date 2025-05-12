using SharpImGui;
using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGuizmo
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct Style
	{
		/// <summary>
		/// Thickness of lines for translation gizmo<br/>
		/// </summary>
		public float TranslationLineThickness;
		/// <summary>
		/// Size of arrow at the end of lines for translation gizmo<br/>
		/// </summary>
		public float TranslationLineArrowSize;
		/// <summary>
		/// Thickness of lines for rotation gizmo<br/>
		/// </summary>
		public float RotationLineThickness;
		/// <summary>
		/// Thickness of line surrounding the rotation gizmo<br/>
		/// </summary>
		public float RotationOuterLineThickness;
		/// <summary>
		/// Thickness of lines for scale gizmo<br/>
		/// </summary>
		public float ScaleLineThickness;
		/// <summary>
		/// Size of circle at the end of lines for scale gizmo<br/>
		/// </summary>
		public float ScaleLineCircleSize;
		/// <summary>
		/// Thickness of hatched axis lines<br/>
		/// </summary>
		public float HatchedAxisLineThickness;
		/// <summary>
		/// Size of circle at the center of the translate/scale gizmo<br/>
		/// </summary>
		public float CenterCircleSize;
		public Vector4 Colors_0;
		public Vector4 Colors_1;
		public Vector4 Colors_2;
		public Vector4 Colors_3;
		public Vector4 Colors_4;
		public Vector4 Colors_5;
		public Vector4 Colors_6;
		public Vector4 Colors_7;
		public Vector4 Colors_8;
		public Vector4 Colors_9;
		public Vector4 Colors_10;
		public Vector4 Colors_11;
		public Vector4 Colors_12;
		public Vector4 Colors_13;
		public Vector4 Colors_14;
	}

	public unsafe partial struct StylePtr
	{
		public Style* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public Style this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// Thickness of lines for translation gizmo<br/>
		/// </summary>
		public ref float TranslationLineThickness => ref Unsafe.AsRef<float>(&NativePtr->TranslationLineThickness);
		/// <summary>
		/// Size of arrow at the end of lines for translation gizmo<br/>
		/// </summary>
		public ref float TranslationLineArrowSize => ref Unsafe.AsRef<float>(&NativePtr->TranslationLineArrowSize);
		/// <summary>
		/// Thickness of lines for rotation gizmo<br/>
		/// </summary>
		public ref float RotationLineThickness => ref Unsafe.AsRef<float>(&NativePtr->RotationLineThickness);
		/// <summary>
		/// Thickness of line surrounding the rotation gizmo<br/>
		/// </summary>
		public ref float RotationOuterLineThickness => ref Unsafe.AsRef<float>(&NativePtr->RotationOuterLineThickness);
		/// <summary>
		/// Thickness of lines for scale gizmo<br/>
		/// </summary>
		public ref float ScaleLineThickness => ref Unsafe.AsRef<float>(&NativePtr->ScaleLineThickness);
		/// <summary>
		/// Size of circle at the end of lines for scale gizmo<br/>
		/// </summary>
		public ref float ScaleLineCircleSize => ref Unsafe.AsRef<float>(&NativePtr->ScaleLineCircleSize);
		/// <summary>
		/// Thickness of hatched axis lines<br/>
		/// </summary>
		public ref float HatchedAxisLineThickness => ref Unsafe.AsRef<float>(&NativePtr->HatchedAxisLineThickness);
		/// <summary>
		/// Size of circle at the center of the translate/scale gizmo<br/>
		/// </summary>
		public ref float CenterCircleSize => ref Unsafe.AsRef<float>(&NativePtr->CenterCircleSize);
		public Span<Vector4> Colors => new Span<Vector4>(&NativePtr->Colors_0, 15);
		public StylePtr(Style* nativePtr) => NativePtr = nativePtr;
		public StylePtr(IntPtr nativePtr) => NativePtr = (Style*)nativePtr;
		public static implicit operator StylePtr(Style* ptr) => new StylePtr(ptr);
		public static implicit operator StylePtr(IntPtr ptr) => new StylePtr(ptr);
		public static implicit operator Style*(StylePtr nativePtr) => nativePtr.NativePtr;
		public void Destroy()
		{
			ImGuizmoNative.StyleDestroy(NativePtr);
		}

		public StylePtr Style()
		{
			return ImGuizmoNative.StyleStyle();
		}

	}
}
