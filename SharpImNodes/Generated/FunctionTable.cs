using SharpImGui;
using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImNodes
{
	public unsafe partial class ImNodesNative
	{
		internal static FunctionTable FuncTable;
		public static void InitApi(NativeLibraryContext context)
		{
			FuncTable = new FunctionTable(context, 88);
			FuncTable.Load(0, "EmulateThreeButtonMouse_EmulateThreeButtonMouse");
			FuncTable.Load(1, "EmulateThreeButtonMouse_destroy");
			FuncTable.Load(2, "LinkDetachWithModifierClick_LinkDetachWithModifierClick");
			FuncTable.Load(3, "LinkDetachWithModifierClick_destroy");
			FuncTable.Load(4, "MultipleSelectModifier_MultipleSelectModifier");
			FuncTable.Load(5, "MultipleSelectModifier_destroy");
			FuncTable.Load(6, "ImNodesIO_ImNodesIO");
			FuncTable.Load(7, "ImNodesIO_destroy");
			FuncTable.Load(8, "ImNodesStyle_ImNodesStyle");
			FuncTable.Load(9, "ImNodesStyle_destroy");
			FuncTable.Load(10, "ImNodes_SetImGuiContext");
			FuncTable.Load(11, "ImNodes_CreateContext");
			FuncTable.Load(12, "ImNodes_DestroyContext");
			FuncTable.Load(13, "ImNodes_GetCurrentContext");
			FuncTable.Load(14, "ImNodes_SetCurrentContext");
			FuncTable.Load(15, "ImNodes_EditorContextCreate");
			FuncTable.Load(16, "ImNodes_EditorContextFree");
			FuncTable.Load(17, "ImNodes_EditorContextSet");
			FuncTable.Load(18, "ImNodes_EditorContextGetPanning");
			FuncTable.Load(19, "ImNodes_EditorContextResetPanning");
			FuncTable.Load(20, "ImNodes_EditorContextMoveToNode");
			FuncTable.Load(21, "ImNodes_GetIO");
			FuncTable.Load(22, "ImNodes_GetStyle");
			FuncTable.Load(23, "ImNodes_StyleColorsDark");
			FuncTable.Load(24, "ImNodes_StyleColorsClassic");
			FuncTable.Load(25, "ImNodes_StyleColorsLight");
			FuncTable.Load(26, "ImNodes_BeginNodeEditor");
			FuncTable.Load(27, "ImNodes_EndNodeEditor");
			FuncTable.Load(28, "ImNodes_MiniMap");
			FuncTable.Load(29, "ImNodes_PushColorStyle");
			FuncTable.Load(30, "ImNodes_PopColorStyle");
			FuncTable.Load(31, "ImNodes_PushStyleVar_Float");
			FuncTable.Load(32, "ImNodes_PushStyleVar_Vec2");
			FuncTable.Load(33, "ImNodes_PopStyleVar");
			FuncTable.Load(34, "ImNodes_BeginNode");
			FuncTable.Load(35, "ImNodes_EndNode");
			FuncTable.Load(36, "ImNodes_GetNodeDimensions");
			FuncTable.Load(37, "ImNodes_BeginNodeTitleBar");
			FuncTable.Load(38, "ImNodes_EndNodeTitleBar");
			FuncTable.Load(39, "ImNodes_BeginInputAttribute");
			FuncTable.Load(40, "ImNodes_EndInputAttribute");
			FuncTable.Load(41, "ImNodes_BeginOutputAttribute");
			FuncTable.Load(42, "ImNodes_EndOutputAttribute");
			FuncTable.Load(43, "ImNodes_BeginStaticAttribute");
			FuncTable.Load(44, "ImNodes_EndStaticAttribute");
			FuncTable.Load(45, "ImNodes_PushAttributeFlag");
			FuncTable.Load(46, "ImNodes_PopAttributeFlag");
			FuncTable.Load(47, "ImNodes_Link");
			FuncTable.Load(48, "ImNodes_SetNodeDraggable");
			FuncTable.Load(49, "ImNodes_SetNodeScreenSpacePos");
			FuncTable.Load(50, "ImNodes_SetNodeEditorSpacePos");
			FuncTable.Load(51, "ImNodes_SetNodeGridSpacePos");
			FuncTable.Load(52, "ImNodes_GetNodeScreenSpacePos");
			FuncTable.Load(53, "ImNodes_GetNodeEditorSpacePos");
			FuncTable.Load(54, "ImNodes_GetNodeGridSpacePos");
			FuncTable.Load(55, "ImNodes_SnapNodeToGrid");
			FuncTable.Load(56, "ImNodes_IsEditorHovered");
			FuncTable.Load(57, "ImNodes_IsNodeHovered");
			FuncTable.Load(58, "ImNodes_IsLinkHovered");
			FuncTable.Load(59, "ImNodes_IsPinHovered");
			FuncTable.Load(60, "ImNodes_NumSelectedNodes");
			FuncTable.Load(61, "ImNodes_NumSelectedLinks");
			FuncTable.Load(62, "ImNodes_GetSelectedNodes");
			FuncTable.Load(63, "ImNodes_GetSelectedLinks");
			FuncTable.Load(64, "ImNodes_ClearNodeSelection_Nil");
			FuncTable.Load(65, "ImNodes_ClearLinkSelection_Nil");
			FuncTable.Load(66, "ImNodes_SelectNode");
			FuncTable.Load(67, "ImNodes_ClearNodeSelection_Int");
			FuncTable.Load(68, "ImNodes_IsNodeSelected");
			FuncTable.Load(69, "ImNodes_SelectLink");
			FuncTable.Load(70, "ImNodes_ClearLinkSelection_Int");
			FuncTable.Load(71, "ImNodes_IsLinkSelected");
			FuncTable.Load(72, "ImNodes_IsAttributeActive");
			FuncTable.Load(73, "ImNodes_IsAnyAttributeActive");
			FuncTable.Load(74, "ImNodes_IsLinkStarted");
			FuncTable.Load(75, "ImNodes_IsLinkDropped");
			FuncTable.Load(76, "ImNodes_IsLinkCreated_BoolPtr");
			FuncTable.Load(77, "ImNodes_IsLinkCreated_IntPtr");
			FuncTable.Load(78, "ImNodes_IsLinkDestroyed");
			FuncTable.Load(79, "ImNodes_SaveCurrentEditorStateToIniString");
			FuncTable.Load(80, "ImNodes_SaveEditorStateToIniString");
			FuncTable.Load(81, "ImNodes_LoadCurrentEditorStateFromIniString");
			FuncTable.Load(82, "ImNodes_LoadEditorStateFromIniString");
			FuncTable.Load(83, "ImNodes_SaveCurrentEditorStateToIniFile");
			FuncTable.Load(84, "ImNodes_SaveEditorStateToIniFile");
			FuncTable.Load(85, "ImNodes_LoadCurrentEditorStateFromIniFile");
			FuncTable.Load(86, "ImNodes_LoadEditorStateFromIniFile");
			FuncTable.Load(87, "getIOKeyCtrlPtr");
		}

		public static void FreeApi()
		{
			FuncTable.Free();
		}

	}
}
