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

		public static void BeginFrame()
		{
			ImGuizmoNative.BeginFrame();
		}

		public static void SetImGuiContext(ImGuiContextPtr ctx)
		{
			ImGuizmoNative.SetImGuiContext(ctx);
		}

		public static byte IsOverNil()
		{
			return ImGuizmoNative.IsOverNil();
		}

		public static byte IsUsing()
		{
			return ImGuizmoNative.IsUsing();
		}

		public static byte IsUsingViewManipulate()
		{
			return ImGuizmoNative.IsUsingViewManipulate();
		}

		public static byte IsViewManipulateHovered()
		{
			return ImGuizmoNative.IsViewManipulateHovered();
		}

		public static byte IsUsingAny()
		{
			return ImGuizmoNative.IsUsingAny();
		}

		public static void Enable(bool enable)
		{
			var native_enable = enable ? (byte)1 : (byte)0;
			ImGuizmoNative.Enable(native_enable);
		}

		public static void DecomposeMatrixToComponents(ref float matrix, ref float translation, ref float rotation, ref float scale)
		{
			fixed (float* native_matrix = &matrix)
			fixed (float* native_translation = &translation)
			fixed (float* native_rotation = &rotation)
			fixed (float* native_scale = &scale)
			{
				ImGuizmoNative.DecomposeMatrixToComponents(native_matrix, native_translation, native_rotation, native_scale);
			}
		}

		public static void RecomposeMatrixFromComponents(ref float translation, ref float rotation, ref float scale, ref float matrix)
		{
			fixed (float* native_translation = &translation)
			fixed (float* native_rotation = &rotation)
			fixed (float* native_scale = &scale)
			fixed (float* native_matrix = &matrix)
			{
				ImGuizmoNative.RecomposeMatrixFromComponents(native_translation, native_rotation, native_scale, native_matrix);
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

		public static void DrawCubes(ref float view, ref float projection, ref float matrices, int matrixCount)
		{
			fixed (float* native_view = &view)
			fixed (float* native_projection = &projection)
			fixed (float* native_matrices = &matrices)
			{
				ImGuizmoNative.DrawCubes(native_view, native_projection, native_matrices, matrixCount);
			}
		}

		public static void DrawGrid(ref float view, ref float projection, ref float matrix, float gridSize)
		{
			fixed (float* native_view = &view)
			fixed (float* native_projection = &projection)
			fixed (float* native_matrix = &matrix)
			{
				ImGuizmoNative.DrawGrid(native_view, native_projection, native_matrix, gridSize);
			}
		}

		public static byte Manipulate(ref float view, ref float projection, OPERATION operation, MODE mode, ref float matrix, ref float deltaMatrix, ref float snap, ref float localBounds, ref float boundsSnap)
		{
			fixed (float* native_view = &view)
			fixed (float* native_projection = &projection)
			fixed (float* native_matrix = &matrix)
			fixed (float* native_deltaMatrix = &deltaMatrix)
			fixed (float* native_snap = &snap)
			fixed (float* native_localBounds = &localBounds)
			fixed (float* native_boundsSnap = &boundsSnap)
			{
				var result = ImGuizmoNative.Manipulate(native_view, native_projection, operation, mode, native_matrix, native_deltaMatrix, native_snap, native_localBounds, native_boundsSnap);
				return result;
			}
		}

		public static void ViewManipulateFloat(ref float view, float length, Vector2 position, Vector2 size, uint backgroundColor)
		{
			fixed (float* native_view = &view)
			{
				ImGuizmoNative.ViewManipulateFloat(native_view, length, position, size, backgroundColor);
			}
		}

		public static void ViewManipulateFloatPtr(ref float view, ref float projection, OPERATION operation, MODE mode, ref float matrix, float length, Vector2 position, Vector2 size, uint backgroundColor)
		{
			fixed (float* native_view = &view)
			fixed (float* native_projection = &projection)
			fixed (float* native_matrix = &matrix)
			{
				ImGuizmoNative.ViewManipulateFloatPtr(native_view, native_projection, operation, mode, native_matrix, length, position, size, backgroundColor);
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

		public static void PushIDStr(ReadOnlySpan<char> strId)
		{
			// Marshaling strId to native string
			byte* native_strId;
			var byteCount_strId = 0;
			if (strId != null)
			{
				byteCount_strId = Encoding.UTF8.GetByteCount(strId);
				if(byteCount_strId > Utils.MaxStackallocSize)
				{
					native_strId = Utils.Alloc<byte>(byteCount_strId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_strId + 1];
					native_strId = stackallocBytes;
				}
				var strId_offset = Utils.EncodeStringUTF8(strId, native_strId, byteCount_strId);
				native_strId[strId_offset] = 0;
			}
			else native_strId = null;

			ImGuizmoNative.PushIDStr(native_strId);
			// Freeing strId native string
			if (byteCount_strId > Utils.MaxStackallocSize)
				Utils.Free(native_strId);
		}

		public static void PushIDStrStr(ReadOnlySpan<char> strIdBegin, ReadOnlySpan<char> strIdEnd)
		{
			// Marshaling strIdBegin to native string
			byte* native_strIdBegin;
			var byteCount_strIdBegin = 0;
			if (strIdBegin != null)
			{
				byteCount_strIdBegin = Encoding.UTF8.GetByteCount(strIdBegin);
				if(byteCount_strIdBegin > Utils.MaxStackallocSize)
				{
					native_strIdBegin = Utils.Alloc<byte>(byteCount_strIdBegin + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_strIdBegin + 1];
					native_strIdBegin = stackallocBytes;
				}
				var strIdBegin_offset = Utils.EncodeStringUTF8(strIdBegin, native_strIdBegin, byteCount_strIdBegin);
				native_strIdBegin[strIdBegin_offset] = 0;
			}
			else native_strIdBegin = null;

			// Marshaling strIdEnd to native string
			byte* native_strIdEnd;
			var byteCount_strIdEnd = 0;
			if (strIdEnd != null)
			{
				byteCount_strIdEnd = Encoding.UTF8.GetByteCount(strIdEnd);
				if(byteCount_strIdEnd > Utils.MaxStackallocSize)
				{
					native_strIdEnd = Utils.Alloc<byte>(byteCount_strIdEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_strIdEnd + 1];
					native_strIdEnd = stackallocBytes;
				}
				var strIdEnd_offset = Utils.EncodeStringUTF8(strIdEnd, native_strIdEnd, byteCount_strIdEnd);
				native_strIdEnd[strIdEnd_offset] = 0;
			}
			else native_strIdEnd = null;

			ImGuizmoNative.PushIDStrStr(native_strIdBegin, native_strIdEnd);
			// Freeing strIdBegin native string
			if (byteCount_strIdBegin > Utils.MaxStackallocSize)
				Utils.Free(native_strIdBegin);
			// Freeing strIdEnd native string
			if (byteCount_strIdEnd > Utils.MaxStackallocSize)
				Utils.Free(native_strIdEnd);
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

		public static uint GetIDStr(ReadOnlySpan<char> strId)
		{
			// Marshaling strId to native string
			byte* native_strId;
			var byteCount_strId = 0;
			if (strId != null)
			{
				byteCount_strId = Encoding.UTF8.GetByteCount(strId);
				if(byteCount_strId > Utils.MaxStackallocSize)
				{
					native_strId = Utils.Alloc<byte>(byteCount_strId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_strId + 1];
					native_strId = stackallocBytes;
				}
				var strId_offset = Utils.EncodeStringUTF8(strId, native_strId, byteCount_strId);
				native_strId[strId_offset] = 0;
			}
			else native_strId = null;

			return ImGuizmoNative.GetIDStr(native_strId);
			// Freeing strId native string
			if (byteCount_strId > Utils.MaxStackallocSize)
				Utils.Free(native_strId);
		}

		public static uint GetIDStrStr(ReadOnlySpan<char> strIdBegin, ReadOnlySpan<char> strIdEnd)
		{
			// Marshaling strIdBegin to native string
			byte* native_strIdBegin;
			var byteCount_strIdBegin = 0;
			if (strIdBegin != null)
			{
				byteCount_strIdBegin = Encoding.UTF8.GetByteCount(strIdBegin);
				if(byteCount_strIdBegin > Utils.MaxStackallocSize)
				{
					native_strIdBegin = Utils.Alloc<byte>(byteCount_strIdBegin + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_strIdBegin + 1];
					native_strIdBegin = stackallocBytes;
				}
				var strIdBegin_offset = Utils.EncodeStringUTF8(strIdBegin, native_strIdBegin, byteCount_strIdBegin);
				native_strIdBegin[strIdBegin_offset] = 0;
			}
			else native_strIdBegin = null;

			// Marshaling strIdEnd to native string
			byte* native_strIdEnd;
			var byteCount_strIdEnd = 0;
			if (strIdEnd != null)
			{
				byteCount_strIdEnd = Encoding.UTF8.GetByteCount(strIdEnd);
				if(byteCount_strIdEnd > Utils.MaxStackallocSize)
				{
					native_strIdEnd = Utils.Alloc<byte>(byteCount_strIdEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_strIdEnd + 1];
					native_strIdEnd = stackallocBytes;
				}
				var strIdEnd_offset = Utils.EncodeStringUTF8(strIdEnd, native_strIdEnd, byteCount_strIdEnd);
				native_strIdEnd[strIdEnd_offset] = 0;
			}
			else native_strIdEnd = null;

			return ImGuizmoNative.GetIDStrStr(native_strIdBegin, native_strIdEnd);
			// Freeing strIdBegin native string
			if (byteCount_strIdBegin > Utils.MaxStackallocSize)
				Utils.Free(native_strIdBegin);
			// Freeing strIdEnd native string
			if (byteCount_strIdEnd > Utils.MaxStackallocSize)
				Utils.Free(native_strIdEnd);
		}

		public static uint GetIDPtr(IntPtr ptrId)
		{
			return ImGuizmoNative.GetIDPtr((void*)ptrId);
		}

		public static byte IsOverOPERATION(OPERATION op)
		{
			return ImGuizmoNative.IsOverOPERATION(op);
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

		public static byte IsOverFloatPtr(ref float position, float pixelRadius)
		{
			fixed (float* native_position = &position)
			{
				var result = ImGuizmoNative.IsOverFloatPtr(native_position, pixelRadius);
				return result;
			}
		}

		public static StylePtr GetStyle()
		{
			return ImGuizmoNative.GetStyle();
		}

	}
}
