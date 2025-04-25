using System;
using System.Numerics;
using System.Runtime.InteropServices;
using SharpImGui;

namespace SharpImGuizmo
{
	public unsafe partial class ImGuizmoNative
	{
		internal static FunctionTable FuncTable;
		public static void InitApi(NativeLibraryContext context)
		{
			FuncTable = new FunctionTable(context, 38);
			FuncTable.Load(0, "ImGuizmo_SetDrawlist");
			FuncTable.Load(1, "ImGuizmo_BeginFrame");
			FuncTable.Load(2, "ImGuizmo_SetImGuiContext");
			FuncTable.Load(3, "ImGuizmo_IsOver_Nil");
			FuncTable.Load(4, "ImGuizmo_IsUsing");
			FuncTable.Load(5, "ImGuizmo_IsUsingViewManipulate");
			FuncTable.Load(6, "ImGuizmo_IsViewManipulateHovered");
			FuncTable.Load(7, "ImGuizmo_IsUsingAny");
			FuncTable.Load(8, "ImGuizmo_Enable");
			FuncTable.Load(9, "ImGuizmo_DecomposeMatrixToComponents");
			FuncTable.Load(10, "ImGuizmo_RecomposeMatrixFromComponents");
			FuncTable.Load(11, "ImGuizmo_SetRect");
			FuncTable.Load(12, "ImGuizmo_SetOrthographic");
			FuncTable.Load(13, "ImGuizmo_DrawCubes");
			FuncTable.Load(14, "ImGuizmo_DrawGrid");
			FuncTable.Load(15, "ImGuizmo_Manipulate");
			FuncTable.Load(16, "ImGuizmo_ViewManipulate_Float");
			FuncTable.Load(17, "ImGuizmo_ViewManipulate_FloatPtr");
			FuncTable.Load(18, "ImGuizmo_SetAlternativeWindow");
			FuncTable.Load(19, "ImGuizmo_SetID");
			FuncTable.Load(20, "ImGuizmo_PushID_Str");
			FuncTable.Load(21, "ImGuizmo_PushID_StrStr");
			FuncTable.Load(22, "ImGuizmo_PushID_Ptr");
			FuncTable.Load(23, "ImGuizmo_PushID_Int");
			FuncTable.Load(24, "ImGuizmo_PopID");
			FuncTable.Load(25, "ImGuizmo_GetID_Str");
			FuncTable.Load(26, "ImGuizmo_GetID_StrStr");
			FuncTable.Load(27, "ImGuizmo_GetID_Ptr");
			FuncTable.Load(28, "ImGuizmo_IsOver_OPERATION");
			FuncTable.Load(29, "ImGuizmo_SetGizmoSizeClipSpace");
			FuncTable.Load(30, "ImGuizmo_AllowAxisFlip");
			FuncTable.Load(31, "ImGuizmo_SetAxisLimit");
			FuncTable.Load(32, "ImGuizmo_SetAxisMask");
			FuncTable.Load(33, "ImGuizmo_SetPlaneLimit");
			FuncTable.Load(34, "ImGuizmo_IsOver_FloatPtr");
			FuncTable.Load(35, "Style_Style");
			FuncTable.Load(36, "Style_destroy");
			FuncTable.Load(37, "ImGuizmo_GetStyle");
		}

		public static void FreeApi()
		{
			FuncTable.Free();
		}

	}
}
