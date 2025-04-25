using System;
using System.Numerics;
using System.Runtime.InteropServices;
using SharpImGui;

namespace SharpImNodes
{
	public unsafe partial class ImnodesNative
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
			FuncTable.Load(10, "imnodes_SetImGuiContext");
			FuncTable.Load(11, "imnodes_CreateContext");
			FuncTable.Load(12, "imnodes_DestroyContext");
			FuncTable.Load(13, "imnodes_GetCurrentContext");
			FuncTable.Load(14, "imnodes_SetCurrentContext");
			FuncTable.Load(15, "imnodes_EditorContextCreate");
			FuncTable.Load(16, "imnodes_EditorContextFree");
			FuncTable.Load(17, "imnodes_EditorContextSet");
			FuncTable.Load(18, "imnodes_EditorContextGetPanning");
			FuncTable.Load(19, "imnodes_EditorContextResetPanning");
			FuncTable.Load(20, "imnodes_EditorContextMoveToNode");
			FuncTable.Load(21, "imnodes_GetIO");
			FuncTable.Load(22, "imnodes_GetStyle");
			FuncTable.Load(23, "imnodes_StyleColorsDark");
			FuncTable.Load(24, "imnodes_StyleColorsClassic");
			FuncTable.Load(25, "imnodes_StyleColorsLight");
			FuncTable.Load(26, "imnodes_BeginNodeEditor");
			FuncTable.Load(27, "imnodes_EndNodeEditor");
			FuncTable.Load(28, "imnodes_MiniMap");
			FuncTable.Load(29, "imnodes_PushColorStyle");
			FuncTable.Load(30, "imnodes_PopColorStyle");
			FuncTable.Load(31, "imnodes_PushStyleVar");
			FuncTable.Load(32, "imnodes_PushStyleVar");
			FuncTable.Load(33, "imnodes_PopStyleVar");
			FuncTable.Load(34, "imnodes_BeginNode");
			FuncTable.Load(35, "imnodes_EndNode");
			FuncTable.Load(36, "imnodes_GetNodeDimensions");
			FuncTable.Load(37, "imnodes_BeginNodeTitleBar");
			FuncTable.Load(38, "imnodes_EndNodeTitleBar");
			FuncTable.Load(39, "imnodes_BeginInputAttribute");
			FuncTable.Load(40, "imnodes_EndInputAttribute");
			FuncTable.Load(41, "imnodes_BeginOutputAttribute");
			FuncTable.Load(42, "imnodes_EndOutputAttribute");
			FuncTable.Load(43, "imnodes_BeginStaticAttribute");
			FuncTable.Load(44, "imnodes_EndStaticAttribute");
			FuncTable.Load(45, "imnodes_PushAttributeFlag");
			FuncTable.Load(46, "imnodes_PopAttributeFlag");
			FuncTable.Load(47, "imnodes_Link");
			FuncTable.Load(48, "imnodes_SetNodeDraggable");
			FuncTable.Load(49, "imnodes_SetNodeScreenSpacePos");
			FuncTable.Load(50, "imnodes_SetNodeEditorSpacePos");
			FuncTable.Load(51, "imnodes_SetNodeGridSpacePos");
			FuncTable.Load(52, "imnodes_GetNodeScreenSpacePos");
			FuncTable.Load(53, "imnodes_GetNodeEditorSpacePos");
			FuncTable.Load(54, "imnodes_GetNodeGridSpacePos");
			FuncTable.Load(55, "imnodes_SnapNodeToGrid");
			FuncTable.Load(56, "imnodes_IsEditorHovered");
			FuncTable.Load(57, "imnodes_IsNodeHovered");
			FuncTable.Load(58, "imnodes_IsLinkHovered");
			FuncTable.Load(59, "imnodes_IsPinHovered");
			FuncTable.Load(60, "imnodes_NumSelectedNodes");
			FuncTable.Load(61, "imnodes_NumSelectedLinks");
			FuncTable.Load(62, "imnodes_GetSelectedNodes");
			FuncTable.Load(63, "imnodes_GetSelectedLinks");
			FuncTable.Load(64, "imnodes_ClearNodeSelection");
			FuncTable.Load(65, "imnodes_ClearLinkSelection");
			FuncTable.Load(66, "imnodes_SelectNode");
			FuncTable.Load(67, "imnodes_ClearNodeSelection");
			FuncTable.Load(68, "imnodes_IsNodeSelected");
			FuncTable.Load(69, "imnodes_SelectLink");
			FuncTable.Load(70, "imnodes_ClearLinkSelection");
			FuncTable.Load(71, "imnodes_IsLinkSelected");
			FuncTable.Load(72, "imnodes_IsAttributeActive");
			FuncTable.Load(73, "imnodes_IsAnyAttributeActive");
			FuncTable.Load(74, "imnodes_IsLinkStarted");
			FuncTable.Load(75, "imnodes_IsLinkDropped");
			FuncTable.Load(76, "imnodes_IsLinkCreated");
			FuncTable.Load(77, "imnodes_IsLinkCreated");
			FuncTable.Load(78, "imnodes_IsLinkDestroyed");
			FuncTable.Load(79, "imnodes_SaveCurrentEditorStateToIniString");
			FuncTable.Load(80, "imnodes_SaveEditorStateToIniString");
			FuncTable.Load(81, "imnodes_LoadCurrentEditorStateFromIniString");
			FuncTable.Load(82, "imnodes_LoadEditorStateFromIniString");
			FuncTable.Load(83, "imnodes_SaveCurrentEditorStateToIniFile");
			FuncTable.Load(84, "imnodes_SaveEditorStateToIniFile");
			FuncTable.Load(85, "imnodes_LoadCurrentEditorStateFromIniFile");
			FuncTable.Load(86, "imnodes_LoadEditorStateFromIniFile");
			FuncTable.Load(87, "getIOKeyCtrlPtr");
		}

		public static void FreeApi()
		{
			FuncTable.Free();
		}

	}
}
