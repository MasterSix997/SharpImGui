using SharpImGui;
using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImNodes
{
	public unsafe partial class ImnodesNative
	{
		static ImnodesNative()
		{
			InitApi(new NativeLibraryContext(LibraryLoader.LoadLibrary(GetLibraryName, null)));
		}

		public static string GetLibraryName()
		{
			return "cimnodes";
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static EmulateThreeButtonMouse* EmulateThreeButtonMouseEmulateThreeButtonMouse()
		{
			return (EmulateThreeButtonMouse*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[0])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void EmulateThreeButtonMouseDestroy(EmulateThreeButtonMouse* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static LinkDetachWithModifierClick* LinkDetachWithModifierClickLinkDetachWithModifierClick()
		{
			return (LinkDetachWithModifierClick*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[2])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LinkDetachWithModifierClickDestroy(LinkDetachWithModifierClick* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[3])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static MultipleSelectModifier* MultipleSelectModifierMultipleSelectModifier()
		{
			return (MultipleSelectModifier*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[4])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void MultipleSelectModifierDestroy(MultipleSelectModifier* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[5])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImNodesIO* ImNodesIOImNodesIO()
		{
			return (ImNodesIO*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[6])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesIODestroy(ImNodesIO* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[7])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImNodesStyle* ImNodesStyleImNodesStyle()
		{
			return (ImNodesStyle*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[8])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesStyleDestroy(ImNodesStyle* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[9])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetImGuiContext(ImGuiContext* ctx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[10])((IntPtr)ctx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImNodesContext* CreateContext()
		{
			return (ImNodesContext*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[11])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DestroyContext(ImNodesContext* ctx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[12])((IntPtr)ctx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImNodesContext* GetCurrentContext()
		{
			return (ImNodesContext*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[13])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCurrentContext(ImNodesContext* ctx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[14])((IntPtr)ctx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImNodesEditorContext* EditorContextCreate()
		{
			return (ImNodesEditorContext*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[15])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void EditorContextFree(ImNodesEditorContext* noname1)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[16])((IntPtr)noname1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void EditorContextSet(ImNodesEditorContext* noname1)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[17])((IntPtr)noname1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void EditorContextGetPanning(Vector2* pOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[18])((IntPtr)pOut);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void EditorContextResetPanning(Vector2 pos)
		{
			((delegate* unmanaged[Cdecl]<Vector2, void>)FuncTable[19])(pos);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void EditorContextMoveToNode(int nodeId)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[20])(nodeId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImNodesIO* GetIO()
		{
			return (ImNodesIO*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[21])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImNodesStyle* GetStyle()
		{
			return (ImNodesStyle*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[22])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void StyleColorsDark(ImNodesStyle* dest)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[23])((IntPtr)dest);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void StyleColorsClassic(ImNodesStyle* dest)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[24])((IntPtr)dest);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void StyleColorsLight(ImNodesStyle* dest)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[25])((IntPtr)dest);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void BeginNodeEditor()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[26])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void EndNodeEditor()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[27])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void MiniMap(float minimapSizeFraction, ImNodesMiniMapLocation location, ImNodesMiniMapNodeHoveringCallback nodeHoveringCallback, void* nodeHoveringCallbackData)
		{
			((delegate* unmanaged[Cdecl]<float, ImNodesMiniMapLocation, ImNodesMiniMapNodeHoveringCallback, IntPtr, void>)FuncTable[28])(minimapSizeFraction, location, nodeHoveringCallback, (IntPtr)nodeHoveringCallbackData);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PushColorStyle(ImNodesCol item, uint color)
		{
			((delegate* unmanaged[Cdecl]<ImNodesCol, uint, void>)FuncTable[29])(item, color);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PopColorStyle()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[30])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PushStyleVar(ImNodesStyleVar styleItem, float value)
		{
			((delegate* unmanaged[Cdecl]<ImNodesStyleVar, float, void>)FuncTable[31])(styleItem, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PushStyleVar(ImNodesStyleVar styleItem, Vector2 value)
		{
			((delegate* unmanaged[Cdecl]<ImNodesStyleVar, Vector2, void>)FuncTable[32])(styleItem, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PopStyleVar(int count)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[33])(count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void BeginNode(int id)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[34])(id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void EndNode()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[35])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GetNodeDimensions(Vector2* pOut, int id)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[36])((IntPtr)pOut, id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void BeginNodeTitleBar()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[37])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void EndNodeTitleBar()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[38])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void BeginInputAttribute(int id, ImNodesPinShape shape)
		{
			((delegate* unmanaged[Cdecl]<int, ImNodesPinShape, void>)FuncTable[39])(id, shape);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void EndInputAttribute()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[40])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void BeginOutputAttribute(int id, ImNodesPinShape shape)
		{
			((delegate* unmanaged[Cdecl]<int, ImNodesPinShape, void>)FuncTable[41])(id, shape);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void EndOutputAttribute()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[42])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void BeginStaticAttribute(int id)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[43])(id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void EndStaticAttribute()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[44])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PushAttributeFlag(ImNodesAttributeFlags flag)
		{
			((delegate* unmanaged[Cdecl]<ImNodesAttributeFlags, void>)FuncTable[45])(flag);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PopAttributeFlag()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[46])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Link(int id, int startAttributeId, int endAttributeId)
		{
			((delegate* unmanaged[Cdecl]<int, int, int, void>)FuncTable[47])(id, startAttributeId, endAttributeId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetNodeDraggable(int nodeId, byte draggable)
		{
			((delegate* unmanaged[Cdecl]<int, byte, void>)FuncTable[48])(nodeId, draggable);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetNodeScreenSpacePos(int nodeId, Vector2 screenSpacePos)
		{
			((delegate* unmanaged[Cdecl]<int, Vector2, void>)FuncTable[49])(nodeId, screenSpacePos);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetNodeEditorSpacePos(int nodeId, Vector2 editorSpacePos)
		{
			((delegate* unmanaged[Cdecl]<int, Vector2, void>)FuncTable[50])(nodeId, editorSpacePos);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetNodeGridSpacePos(int nodeId, Vector2 gridPos)
		{
			((delegate* unmanaged[Cdecl]<int, Vector2, void>)FuncTable[51])(nodeId, gridPos);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GetNodeScreenSpacePos(Vector2* pOut, int nodeId)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[52])((IntPtr)pOut, nodeId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GetNodeEditorSpacePos(Vector2* pOut, int nodeId)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[53])((IntPtr)pOut, nodeId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GetNodeGridSpacePos(Vector2* pOut, int nodeId)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[54])((IntPtr)pOut, nodeId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SnapNodeToGrid(int nodeId)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[55])(nodeId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsEditorHovered()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[56])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsNodeHovered(int* nodeId)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[57])((IntPtr)nodeId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsLinkHovered(int* linkId)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[58])((IntPtr)linkId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsPinHovered(int* attributeId)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[59])((IntPtr)attributeId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int NumSelectedNodes()
		{
			return ((delegate* unmanaged[Cdecl]<int>)FuncTable[60])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int NumSelectedLinks()
		{
			return ((delegate* unmanaged[Cdecl]<int>)FuncTable[61])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GetSelectedNodes(int* nodeIds)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[62])((IntPtr)nodeIds);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GetSelectedLinks(int* linkIds)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[63])((IntPtr)linkIds);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ClearNodeSelection()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[64])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ClearLinkSelection()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[65])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SelectNode(int nodeId)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[66])(nodeId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ClearNodeSelection(int nodeId)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[67])(nodeId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsNodeSelected(int nodeId)
		{
			return ((delegate* unmanaged[Cdecl]<int, byte>)FuncTable[68])(nodeId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SelectLink(int linkId)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[69])(linkId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ClearLinkSelection(int linkId)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[70])(linkId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsLinkSelected(int linkId)
		{
			return ((delegate* unmanaged[Cdecl]<int, byte>)FuncTable[71])(linkId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsAttributeActive()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[72])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsAnyAttributeActive(int* attributeId)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[73])((IntPtr)attributeId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsLinkStarted(int* startedAtAttributeId)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[74])((IntPtr)startedAtAttributeId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsLinkDropped(int* startedAtAttributeId, byte includingDetachedLinks)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte, byte>)FuncTable[75])((IntPtr)startedAtAttributeId, includingDetachedLinks);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsLinkCreated(int* startedAtAttributeId, int* endedAtAttributeId, byte* createdFromSnap)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, byte>)FuncTable[76])((IntPtr)startedAtAttributeId, (IntPtr)endedAtAttributeId, (IntPtr)createdFromSnap);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsLinkCreated(int* startedAtNodeId, int* startedAtAttributeId, int* endedAtNodeId, int* endedAtAttributeId, byte* createdFromSnap)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, byte>)FuncTable[77])((IntPtr)startedAtNodeId, (IntPtr)startedAtAttributeId, (IntPtr)endedAtNodeId, (IntPtr)endedAtAttributeId, (IntPtr)createdFromSnap);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsLinkDestroyed(int* linkId)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[78])((IntPtr)linkId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* SaveCurrentEditorStateToIniString(uint* dataSize)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[79])((IntPtr)dataSize);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* SaveEditorStateToIniString(ImNodesEditorContext* editor, uint* dataSize)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr>)FuncTable[80])((IntPtr)editor, (IntPtr)dataSize);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LoadCurrentEditorStateFromIniString(byte* data, uint dataSize)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, void>)FuncTable[81])((IntPtr)data, dataSize);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LoadEditorStateFromIniString(ImNodesEditorContext* editor, byte* data, uint dataSize)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, uint, void>)FuncTable[82])((IntPtr)editor, (IntPtr)data, dataSize);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SaveCurrentEditorStateToIniFile(byte* fileName)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[83])((IntPtr)fileName);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SaveEditorStateToIniFile(ImNodesEditorContext* editor, byte* fileName)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[84])((IntPtr)editor, (IntPtr)fileName);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LoadCurrentEditorStateFromIniFile(byte* fileName)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[85])((IntPtr)fileName);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LoadEditorStateFromIniFile(ImNodesEditorContext* editor, byte* fileName)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[86])((IntPtr)editor, (IntPtr)fileName);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* GetIoKeyCtrlPtr()
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[87])();
		}

	}
}
