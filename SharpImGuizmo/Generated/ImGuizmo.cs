using SharpImGui;
using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGuizmo
{
	public static unsafe partial class ImGuizmo
	{
		public static void SetDrawlist(ImDrawListPtr drawlist)
		{
			ImGuizmoNative.SetDrawlist(drawlist);
		}

		public static void SetDrawlist()
		{
			// defining omitted parameters
			ImDrawList* drawlist = null;
			ImGuizmoNative.SetDrawlist(drawlist);
		}

		public static void BeginFrame()
		{
			ImGuizmoNative.BeginFrame();
		}

		public static void SetImGuiContext(ImGuiContextPtr ctx)
		{
			ImGuizmoNative.SetImGuiContext(ctx);
		}

		public static bool IsOverNil()
		{
			var result = ImGuizmoNative.IsOverNil();
			return result != 0;
		}

		public static bool IsUsing()
		{
			var result = ImGuizmoNative.IsUsing();
			return result != 0;
		}

		public static bool IsUsingViewManipulate()
		{
			var result = ImGuizmoNative.IsUsingViewManipulate();
			return result != 0;
		}

		public static bool IsViewManipulateHovered()
		{
			var result = ImGuizmoNative.IsViewManipulateHovered();
			return result != 0;
		}

		public static bool IsUsingAny()
		{
			var result = ImGuizmoNative.IsUsingAny();
			return result != 0;
		}

		public static void Enable(bool enable)
		{
			var native_enable = enable ? (byte)1 : (byte)0;
			ImGuizmoNative.Enable(native_enable);
		}

		public static void DecomposeMatrixToComponents(float[] matrix, ref float translation, ref float rotation, ref float scale)
		{
			fixed (float* nativeMatrix = matrix)
			fixed (float* nativeTranslation = &translation)
			fixed (float* nativeRotation = &rotation)
			fixed (float* nativeScale = &scale)
			{
				ImGuizmoNative.DecomposeMatrixToComponents(nativeMatrix, nativeTranslation, nativeRotation, nativeScale);
			}
		}

		public static void RecomposeMatrixFromComponents(float[] translation, float[] rotation, float[] scale, ref float matrix)
		{
			fixed (float* nativeTranslation = translation)
			fixed (float* nativeRotation = rotation)
			fixed (float* nativeScale = scale)
			fixed (float* nativeMatrix = &matrix)
			{
				ImGuizmoNative.RecomposeMatrixFromComponents(nativeTranslation, nativeRotation, nativeScale, nativeMatrix);
			}
		}

		public static void SetRect(float x, float y, float width, float height)
		{
			ImGuizmoNative.SetRect(x, y, width, height);
		}

		public static void SetOrthographic(bool isOrthographic)
		{
			var native_isOrthographic = isOrthographic ? (byte)1 : (byte)0;
			ImGuizmoNative.SetOrthographic(native_isOrthographic);
		}

		public static void DrawCubes(float[] view, float[] projection, float[] matrices, int matrixCount)
		{
			fixed (float* nativeView = view)
			fixed (float* nativeProjection = projection)
			fixed (float* nativeMatrices = matrices)
			{
				ImGuizmoNative.DrawCubes(nativeView, nativeProjection, nativeMatrices, matrixCount);
			}
		}

		public static void DrawGrid(float[] view, float[] projection, float[] matrix, float gridSize)
		{
			fixed (float* nativeView = view)
			fixed (float* nativeProjection = projection)
			fixed (float* nativeMatrix = matrix)
			{
				ImGuizmoNative.DrawGrid(nativeView, nativeProjection, nativeMatrix, gridSize);
			}
		}

		public static bool Manipulate(float[] view, float[] projection, OPERATION operation, MODE mode, ref float matrix, ref float deltaMatrix, float[] snap, float[] localBounds, float[] boundsSnap)
		{
			fixed (float* nativeView = view)
			fixed (float* nativeProjection = projection)
			fixed (float* nativeMatrix = &matrix)
			fixed (float* nativeDeltaMatrix = &deltaMatrix)
			fixed (float* nativeSnap = snap)
			fixed (float* nativeLocalBounds = localBounds)
			fixed (float* nativeBoundsSnap = boundsSnap)
			{
				var result = ImGuizmoNative.Manipulate(nativeView, nativeProjection, operation, mode, nativeMatrix, nativeDeltaMatrix, nativeSnap, nativeLocalBounds, nativeBoundsSnap);
				return result != 0;
			}
		}

		public static bool Manipulate(float[] view, float[] projection, OPERATION operation, MODE mode, ref float matrix, ref float deltaMatrix, float[] snap, float[] localBounds)
		{
			// defining omitted parameters
			float* boundsSnap = null;
			fixed (float* nativeView = view)
			fixed (float* nativeProjection = projection)
			fixed (float* nativeMatrix = &matrix)
			fixed (float* nativeDeltaMatrix = &deltaMatrix)
			fixed (float* nativeSnap = snap)
			fixed (float* nativeLocalBounds = localBounds)
			{
				var result = ImGuizmoNative.Manipulate(nativeView, nativeProjection, operation, mode, nativeMatrix, nativeDeltaMatrix, nativeSnap, nativeLocalBounds, boundsSnap);
				return result != 0;
			}
		}

		public static bool Manipulate(float[] view, float[] projection, OPERATION operation, MODE mode, ref float matrix, ref float deltaMatrix, float[] snap)
		{
			// defining omitted parameters
			float* boundsSnap = null;
			float* localBounds = null;
			fixed (float* nativeView = view)
			fixed (float* nativeProjection = projection)
			fixed (float* nativeMatrix = &matrix)
			fixed (float* nativeDeltaMatrix = &deltaMatrix)
			fixed (float* nativeSnap = snap)
			{
				var result = ImGuizmoNative.Manipulate(nativeView, nativeProjection, operation, mode, nativeMatrix, nativeDeltaMatrix, nativeSnap, localBounds, boundsSnap);
				return result != 0;
			}
		}

		public static bool Manipulate(float[] view, float[] projection, OPERATION operation, MODE mode, ref float matrix, ref float deltaMatrix)
		{
			// defining omitted parameters
			float* boundsSnap = null;
			float* localBounds = null;
			float* snap = null;
			fixed (float* nativeView = view)
			fixed (float* nativeProjection = projection)
			fixed (float* nativeMatrix = &matrix)
			fixed (float* nativeDeltaMatrix = &deltaMatrix)
			{
				var result = ImGuizmoNative.Manipulate(nativeView, nativeProjection, operation, mode, nativeMatrix, nativeDeltaMatrix, snap, localBounds, boundsSnap);
				return result != 0;
			}
		}

		public static bool Manipulate(float[] view, float[] projection, OPERATION operation, MODE mode, ref float matrix)
		{
			// defining omitted parameters
			float* boundsSnap = null;
			float* localBounds = null;
			float* snap = null;
			float* deltaMatrix = null;
			fixed (float* nativeView = view)
			fixed (float* nativeProjection = projection)
			fixed (float* nativeMatrix = &matrix)
			{
				var result = ImGuizmoNative.Manipulate(nativeView, nativeProjection, operation, mode, nativeMatrix, deltaMatrix, snap, localBounds, boundsSnap);
				return result != 0;
			}
		}

		public static void ViewManipulateFloat(ref float view, float length, Vector2 position, Vector2 size, uint backgroundColor)
		{
			fixed (float* nativeView = &view)
			{
				ImGuizmoNative.ViewManipulateFloat(nativeView, length, position, size, backgroundColor);
			}
		}

		public static void ViewManipulateFloatPtr(ref float view, float[] projection, OPERATION operation, MODE mode, ref float matrix, float length, Vector2 position, Vector2 size, uint backgroundColor)
		{
			fixed (float* nativeView = &view)
			fixed (float* nativeProjection = projection)
			fixed (float* nativeMatrix = &matrix)
			{
				ImGuizmoNative.ViewManipulateFloatPtr(nativeView, nativeProjection, operation, mode, nativeMatrix, length, position, size, backgroundColor);
			}
		}

		public static void SetAlternativeWindow(ImGuiWindowPtr window)
		{
			ImGuizmoNative.SetAlternativeWindow(window);
		}

		public static void SetID(int id)
		{
			ImGuizmoNative.SetID(id);
		}

		public static void PushIDStr(ReadOnlySpan<byte> strId)
		{
			fixed (byte* nativeStrId = strId)
			{
				ImGuizmoNative.PushIDStr(nativeStrId);
			}
		}

		public static void PushIDStr(ReadOnlySpan<char> strId)
		{
			// Marshaling strId to native string
			byte* nativeStrId;
			var byteCountStrId = 0;
			if (strId != null && !strId.IsEmpty)
			{
				byteCountStrId = Encoding.UTF8.GetByteCount(strId);
				if(byteCountStrId > Utils.MaxStackallocSize)
				{
					nativeStrId = Utils.Alloc<byte>(byteCountStrId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrId + 1];
					nativeStrId = stackallocBytes;
				}
				var offsetStrId = Utils.EncodeStringUTF8(strId, nativeStrId, byteCountStrId);
				nativeStrId[offsetStrId] = 0;
			}
			else nativeStrId = null;

			ImGuizmoNative.PushIDStr(nativeStrId);
			// Freeing strId native string
			if (byteCountStrId > Utils.MaxStackallocSize)
				Utils.Free(nativeStrId);
		}

		public static void PushIDStrStr(ReadOnlySpan<byte> strIdBegin, ReadOnlySpan<byte> strIdEnd)
		{
			fixed (byte* nativeStrIdBegin = strIdBegin)
			fixed (byte* nativeStrIdEnd = strIdEnd)
			{
				ImGuizmoNative.PushIDStrStr(nativeStrIdBegin, nativeStrIdEnd);
			}
		}

		public static void PushIDStrStr(ReadOnlySpan<char> strIdBegin, ReadOnlySpan<char> strIdEnd)
		{
			// Marshaling strIdBegin to native string
			byte* nativeStrIdBegin;
			var byteCountStrIdBegin = 0;
			if (strIdBegin != null && !strIdBegin.IsEmpty)
			{
				byteCountStrIdBegin = Encoding.UTF8.GetByteCount(strIdBegin);
				if(byteCountStrIdBegin > Utils.MaxStackallocSize)
				{
					nativeStrIdBegin = Utils.Alloc<byte>(byteCountStrIdBegin + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrIdBegin + 1];
					nativeStrIdBegin = stackallocBytes;
				}
				var offsetStrIdBegin = Utils.EncodeStringUTF8(strIdBegin, nativeStrIdBegin, byteCountStrIdBegin);
				nativeStrIdBegin[offsetStrIdBegin] = 0;
			}
			else nativeStrIdBegin = null;

			// Marshaling strIdEnd to native string
			byte* nativeStrIdEnd;
			var byteCountStrIdEnd = 0;
			if (strIdEnd != null && !strIdEnd.IsEmpty)
			{
				byteCountStrIdEnd = Encoding.UTF8.GetByteCount(strIdEnd);
				if(byteCountStrIdEnd > Utils.MaxStackallocSize)
				{
					nativeStrIdEnd = Utils.Alloc<byte>(byteCountStrIdEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrIdEnd + 1];
					nativeStrIdEnd = stackallocBytes;
				}
				var offsetStrIdEnd = Utils.EncodeStringUTF8(strIdEnd, nativeStrIdEnd, byteCountStrIdEnd);
				nativeStrIdEnd[offsetStrIdEnd] = 0;
			}
			else nativeStrIdEnd = null;

			ImGuizmoNative.PushIDStrStr(nativeStrIdBegin, nativeStrIdEnd);
			// Freeing strIdBegin native string
			if (byteCountStrIdBegin > Utils.MaxStackallocSize)
				Utils.Free(nativeStrIdBegin);
			// Freeing strIdEnd native string
			if (byteCountStrIdEnd > Utils.MaxStackallocSize)
				Utils.Free(nativeStrIdEnd);
		}

		public static void PushIDPtr(IntPtr ptrId)
		{
			ImGuizmoNative.PushIDPtr((void*)ptrId);
		}

		public static void PushIDInt(int intId)
		{
			ImGuizmoNative.PushIDInt(intId);
		}

		/// <summary>
		/// pop from the ID stack.<br/>
		/// </summary>
		public static void PopID()
		{
			ImGuizmoNative.PopID();
		}

		public static uint GetIDStr(ReadOnlySpan<byte> strId)
		{
			fixed (byte* nativeStrId = strId)
			{
				return ImGuizmoNative.GetIDStr(nativeStrId);
			}
		}

		public static uint GetIDStr(ReadOnlySpan<char> strId)
		{
			// Marshaling strId to native string
			byte* nativeStrId;
			var byteCountStrId = 0;
			if (strId != null && !strId.IsEmpty)
			{
				byteCountStrId = Encoding.UTF8.GetByteCount(strId);
				if(byteCountStrId > Utils.MaxStackallocSize)
				{
					nativeStrId = Utils.Alloc<byte>(byteCountStrId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrId + 1];
					nativeStrId = stackallocBytes;
				}
				var offsetStrId = Utils.EncodeStringUTF8(strId, nativeStrId, byteCountStrId);
				nativeStrId[offsetStrId] = 0;
			}
			else nativeStrId = null;

			var result = ImGuizmoNative.GetIDStr(nativeStrId);
			// Freeing strId native string
			if (byteCountStrId > Utils.MaxStackallocSize)
				Utils.Free(nativeStrId);
			return result;
		}

		public static uint GetIDStrStr(ReadOnlySpan<byte> strIdBegin, ReadOnlySpan<byte> strIdEnd)
		{
			fixed (byte* nativeStrIdBegin = strIdBegin)
			fixed (byte* nativeStrIdEnd = strIdEnd)
			{
				return ImGuizmoNative.GetIDStrStr(nativeStrIdBegin, nativeStrIdEnd);
			}
		}

		public static uint GetIDStrStr(ReadOnlySpan<char> strIdBegin, ReadOnlySpan<char> strIdEnd)
		{
			// Marshaling strIdBegin to native string
			byte* nativeStrIdBegin;
			var byteCountStrIdBegin = 0;
			if (strIdBegin != null && !strIdBegin.IsEmpty)
			{
				byteCountStrIdBegin = Encoding.UTF8.GetByteCount(strIdBegin);
				if(byteCountStrIdBegin > Utils.MaxStackallocSize)
				{
					nativeStrIdBegin = Utils.Alloc<byte>(byteCountStrIdBegin + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrIdBegin + 1];
					nativeStrIdBegin = stackallocBytes;
				}
				var offsetStrIdBegin = Utils.EncodeStringUTF8(strIdBegin, nativeStrIdBegin, byteCountStrIdBegin);
				nativeStrIdBegin[offsetStrIdBegin] = 0;
			}
			else nativeStrIdBegin = null;

			// Marshaling strIdEnd to native string
			byte* nativeStrIdEnd;
			var byteCountStrIdEnd = 0;
			if (strIdEnd != null && !strIdEnd.IsEmpty)
			{
				byteCountStrIdEnd = Encoding.UTF8.GetByteCount(strIdEnd);
				if(byteCountStrIdEnd > Utils.MaxStackallocSize)
				{
					nativeStrIdEnd = Utils.Alloc<byte>(byteCountStrIdEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrIdEnd + 1];
					nativeStrIdEnd = stackallocBytes;
				}
				var offsetStrIdEnd = Utils.EncodeStringUTF8(strIdEnd, nativeStrIdEnd, byteCountStrIdEnd);
				nativeStrIdEnd[offsetStrIdEnd] = 0;
			}
			else nativeStrIdEnd = null;

			var result = ImGuizmoNative.GetIDStrStr(nativeStrIdBegin, nativeStrIdEnd);
			// Freeing strIdBegin native string
			if (byteCountStrIdBegin > Utils.MaxStackallocSize)
				Utils.Free(nativeStrIdBegin);
			// Freeing strIdEnd native string
			if (byteCountStrIdEnd > Utils.MaxStackallocSize)
				Utils.Free(nativeStrIdEnd);
			return result;
		}

		public static uint GetIDPtr(IntPtr ptrId)
		{
			return ImGuizmoNative.GetIDPtr((void*)ptrId);
		}

		public static bool IsOverOPERATION(OPERATION op)
		{
			var result = ImGuizmoNative.IsOverOPERATION(op);
			return result != 0;
		}

		public static void SetGizmoSizeClipSpace(float value)
		{
			ImGuizmoNative.SetGizmoSizeClipSpace(value);
		}

		public static void AllowAxisFlip(bool value)
		{
			var native_value = value ? (byte)1 : (byte)0;
			ImGuizmoNative.AllowAxisFlip(native_value);
		}

		public static void SetAxisLimit(float value)
		{
			ImGuizmoNative.SetAxisLimit(value);
		}

		public static void SetAxisMask(bool x, bool y, bool z)
		{
			var native_x = x ? (byte)1 : (byte)0;
			var native_y = y ? (byte)1 : (byte)0;
			var native_z = z ? (byte)1 : (byte)0;
			ImGuizmoNative.SetAxisMask(native_x, native_y, native_z);
		}

		public static void SetPlaneLimit(float value)
		{
			ImGuizmoNative.SetPlaneLimit(value);
		}

		public static bool IsOverFloatPtr(ref float position, float pixelRadius)
		{
			fixed (float* nativePosition = &position)
			{
				var result = ImGuizmoNative.IsOverFloatPtr(nativePosition, pixelRadius);
				return result != 0;
			}
		}

		public static StylePtr GetStyle()
		{
			return ImGuizmoNative.GetStyle();
		}

	}
}
