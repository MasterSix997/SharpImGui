using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Helper: ImRect (2D axis aligned bounding-box)<br/>NB: we can't rely on ImVec2 math operators being available here!<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImRect
	{
		/// <summary>
		/// Upper-left<br/>
		/// </summary>
		public Vector2 Min;
		/// <summary>
		/// Lower-right<br/>
		/// </summary>
		public Vector2 Max;
	}

	/// <summary>
	/// Helper: ImRect (2D axis aligned bounding-box)<br/>NB: we can't rely on ImVec2 math operators being available here!<br/>
	/// </summary>
	public unsafe partial struct ImRectPtr
	{
		public ImRect* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImRect this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// Upper-left<br/>
		/// </summary>
		public ref Vector2 Min => ref Unsafe.AsRef<Vector2>(&NativePtr->Min);
		/// <summary>
		/// Lower-right<br/>
		/// </summary>
		public ref Vector2 Max => ref Unsafe.AsRef<Vector2>(&NativePtr->Max);
		public ImRectPtr(ImRect* nativePtr) => NativePtr = nativePtr;
		public ImRectPtr(IntPtr nativePtr) => NativePtr = (ImRect*)nativePtr;
		public static implicit operator ImRectPtr(ImRect* ptr) => new ImRectPtr(ptr);
		public static implicit operator ImRectPtr(IntPtr ptr) => new ImRectPtr(ptr);
		public static implicit operator ImRect*(ImRectPtr nativePtr) => nativePtr.NativePtr;
		public void ToVec4(ref Vector4 pOut)
		{
			fixed (Vector4* native_pOut = &pOut)
			{
				ImGuiNative.ImRectToVec4(native_pOut, NativePtr);
			}
		}

		public byte IsInverted()
		{
			return ImGuiNative.ImRectIsInverted(NativePtr);
		}

		public void Floor()
		{
			ImGuiNative.ImRectFloor(NativePtr);
		}

		/// <summary>
		/// Full version, ensure both points are fully clipped.<br/>
		/// </summary>
		public void ClipWithFull(ImRect r)
		{
			ImGuiNative.ImRectClipWithFull(NativePtr, r);
		}

		/// <summary>
		/// Simple version, may lead to an inverted rectangle, which is fine for Contains/Overlaps test but not for display.<br/>
		/// </summary>
		public void ClipWith(ImRect r)
		{
			ImGuiNative.ImRectClipWith(NativePtr, r);
		}

		public void TranslateY(float dy)
		{
			ImGuiNative.ImRectTranslateY(NativePtr, dy);
		}

		public void TranslateX(float dx)
		{
			ImGuiNative.ImRectTranslateX(NativePtr, dx);
		}

		public void Translate(Vector2 d)
		{
			ImGuiNative.ImRectTranslate(NativePtr, d);
		}

		public void Expand(Vector2 amount)
		{
			ImGuiNative.ImRectExpand(NativePtr, amount);
		}

		public void Expand(float amount)
		{
			ImGuiNative.ImRectExpand(NativePtr, amount);
		}

		public void AddRect(ImRect r)
		{
			ImGuiNative.ImRectAddRect(NativePtr, r);
		}

		public void AddVec2(Vector2 p)
		{
			ImGuiNative.ImRectAddVec2(NativePtr, p);
		}

		public byte Overlaps(ImRect r)
		{
			return ImGuiNative.ImRectOverlaps(NativePtr, r);
		}

		public byte ContainsWithPad(Vector2 p, Vector2 pad)
		{
			return ImGuiNative.ImRectContainsWithPad(NativePtr, p, pad);
		}

		public byte ContainsRect(ImRect r)
		{
			return ImGuiNative.ImRectContainsRect(NativePtr, r);
		}

		public byte ContainsVec2(Vector2 p)
		{
			return ImGuiNative.ImRectContainsVec2(NativePtr, p);
		}

		/// <summary>
		/// Bottom-right<br/>
		/// </summary>
		public void GetBR(ref Vector2 pOut)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.ImRectGetBR(native_pOut, NativePtr);
			}
		}

		/// <summary>
		/// Bottom-left<br/>
		/// </summary>
		public void GetBL(ref Vector2 pOut)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.ImRectGetBL(native_pOut, NativePtr);
			}
		}

		/// <summary>
		/// Top-right<br/>
		/// </summary>
		public void GetTR(ref Vector2 pOut)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.ImRectGetTR(native_pOut, NativePtr);
			}
		}

		/// <summary>
		/// Top-left<br/>
		/// </summary>
		public void GetTL(ref Vector2 pOut)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.ImRectGetTL(native_pOut, NativePtr);
			}
		}

		public float GetArea()
		{
			return ImGuiNative.ImRectGetArea(NativePtr);
		}

		public float GetHeht()
		{
			return ImGuiNative.ImRectGetHeht(NativePtr);
		}

		public float GetWidth()
		{
			return ImGuiNative.ImRectGetWidth(NativePtr);
		}

		public void GetSize(ref Vector2 pOut)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.ImRectGetSize(native_pOut, NativePtr);
			}
		}

		public void GetCenter(ref Vector2 pOut)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.ImRectGetCenter(native_pOut, NativePtr);
			}
		}

		public void ImRectFloatConstruct(float x1, float y1, float x2, float y2)
		{
			ImGuiNative.ImRectImRectFloatConstruct(NativePtr, x1, y1, x2, y2);
		}

		public ImRectPtr ImRect(float x1, float y1, float x2, float y2)
		{
			return ImGuiNative.ImRectImRect(x1, y1, x2, y2);
		}

		public void ImRectVec4Construct(Vector4 v)
		{
			ImGuiNative.ImRectImRectVec4Construct(NativePtr, v);
		}

		public ImRectPtr ImRect(Vector4 v)
		{
			return ImGuiNative.ImRectImRect(v);
		}

		public void ImRectVec2Construct(Vector2 min, Vector2 max)
		{
			ImGuiNative.ImRectImRectVec2Construct(NativePtr, min, max);
		}

		public ImRectPtr ImRect(Vector2 min, Vector2 max)
		{
			return ImGuiNative.ImRectImRect(min, max);
		}

		public void Destroy()
		{
			ImGuiNative.ImRectDestroy(NativePtr);
		}

		public void ImRectNilConstruct()
		{
			ImGuiNative.ImRectImRectNilConstruct(NativePtr);
		}

		public ImRectPtr ImRect()
		{
			return ImGuiNative.ImRectImRect();
		}

	}
}
