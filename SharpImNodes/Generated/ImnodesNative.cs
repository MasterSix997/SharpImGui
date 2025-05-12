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
		static ImNodesNative()
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
		public static void ImNodesSetImGuiContext(ImGuiContext* ctx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[10])((IntPtr)ctx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImNodesContext* ImNodesCreateContext()
		{
			return (ImNodesContext*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[11])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesDestroyContext(ImNodesContext* ctx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[12])((IntPtr)ctx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImNodesContext* ImNodesGetCurrentContext()
		{
			return (ImNodesContext*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[13])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesSetCurrentContext(ImNodesContext* ctx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[14])((IntPtr)ctx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImNodesEditorContext* ImNodesEditorContextCreate()
		{
			return (ImNodesEditorContext*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[15])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesEditorContextFree(ImNodesEditorContext* noname1)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[16])((IntPtr)noname1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesEditorContextSet(ImNodesEditorContext* noname1)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[17])((IntPtr)noname1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesEditorContextGetPanning(Vector2* pOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[18])((IntPtr)pOut);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesEditorContextResetPanning(Vector2 pos)
		{
			((delegate* unmanaged[Cdecl]<Vector2, void>)FuncTable[19])(pos);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesEditorContextMoveToNode(int nodeId)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[20])(nodeId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImNodesIO* ImNodesGetIO()
		{
			return (ImNodesIO*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[21])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImNodesStyle* ImNodesGetStyle()
		{
			return (ImNodesStyle*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[22])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesStyleColorsDark(ImNodesStyle* dest)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[23])((IntPtr)dest);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesStyleColorsClassic(ImNodesStyle* dest)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[24])((IntPtr)dest);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesStyleColorsLight(ImNodesStyle* dest)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[25])((IntPtr)dest);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesBeginNodeEditor()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[26])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesEndNodeEditor()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[27])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesMiniMap(float minimapSizeFraction, ImNodesMiniMapLocation location, ImNodesMiniMapNodeHoveringCallback nodeHoveringCallback, void* nodeHoveringCallbackData)
		{
			((delegate* unmanaged[Cdecl]<float, ImNodesMiniMapLocation, ImNodesMiniMapNodeHoveringCallback, IntPtr, void>)FuncTable[28])(minimapSizeFraction, location, nodeHoveringCallback, (IntPtr)nodeHoveringCallbackData);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesPushColorStyle(ImNodesCol item, uint color)
		{
			((delegate* unmanaged[Cdecl]<ImNodesCol, uint, void>)FuncTable[29])(item, color);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesPopColorStyle()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[30])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesPushStyleVar(ImNodesStyleVar styleItem, float value)
		{
			((delegate* unmanaged[Cdecl]<ImNodesStyleVar, float, void>)FuncTable[31])(styleItem, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesPushStyleVar(ImNodesStyleVar styleItem, Vector2 value)
		{
			((delegate* unmanaged[Cdecl]<ImNodesStyleVar, Vector2, void>)FuncTable[32])(styleItem, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesPopStyleVar(int count)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[33])(count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesBeginNode(int id)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[34])(id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesEndNode()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[35])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesGetNodeDimensions(Vector2* pOut, int id)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[36])((IntPtr)pOut, id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesBeginNodeTitleBar()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[37])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesEndNodeTitleBar()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[38])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesBeginInputAttribute(int id, ImNodesPinShape shape)
		{
			((delegate* unmanaged[Cdecl]<int, ImNodesPinShape, void>)FuncTable[39])(id, shape);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesEndInputAttribute()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[40])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesBeginOutputAttribute(int id, ImNodesPinShape shape)
		{
			((delegate* unmanaged[Cdecl]<int, ImNodesPinShape, void>)FuncTable[41])(id, shape);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesEndOutputAttribute()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[42])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesBeginStaticAttribute(int id)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[43])(id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesEndStaticAttribute()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[44])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesPushAttributeFlag(ImNodesAttributeFlags flag)
		{
			((delegate* unmanaged[Cdecl]<ImNodesAttributeFlags, void>)FuncTable[45])(flag);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesPopAttributeFlag()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[46])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesLink(int id, int startAttributeId, int endAttributeId)
		{
			((delegate* unmanaged[Cdecl]<int, int, int, void>)FuncTable[47])(id, startAttributeId, endAttributeId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesSetNodeDraggable(int nodeId, byte draggable)
		{
			((delegate* unmanaged[Cdecl]<int, byte, void>)FuncTable[48])(nodeId, draggable);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesSetNodeScreenSpacePos(int nodeId, Vector2 screenSpacePos)
		{
			((delegate* unmanaged[Cdecl]<int, Vector2, void>)FuncTable[49])(nodeId, screenSpacePos);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesSetNodeEditorSpacePos(int nodeId, Vector2 editorSpacePos)
		{
			((delegate* unmanaged[Cdecl]<int, Vector2, void>)FuncTable[50])(nodeId, editorSpacePos);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesSetNodeGridSpacePos(int nodeId, Vector2 gridPos)
		{
			((delegate* unmanaged[Cdecl]<int, Vector2, void>)FuncTable[51])(nodeId, gridPos);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesGetNodeScreenSpacePos(Vector2* pOut, int nodeId)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[52])((IntPtr)pOut, nodeId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesGetNodeEditorSpacePos(Vector2* pOut, int nodeId)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[53])((IntPtr)pOut, nodeId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesGetNodeGridSpacePos(Vector2* pOut, int nodeId)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[54])((IntPtr)pOut, nodeId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesSnapNodeToGrid(int nodeId)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[55])(nodeId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImNodesIsEditorHovered()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[56])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImNodesIsNodeHovered(int* nodeId)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[57])((IntPtr)nodeId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImNodesIsLinkHovered(int* linkId)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[58])((IntPtr)linkId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImNodesIsPinHovered(int* attributeId)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[59])((IntPtr)attributeId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ImNodesNumSelectedNodes()
		{
			return ((delegate* unmanaged[Cdecl]<int>)FuncTable[60])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ImNodesNumSelectedLinks()
		{
			return ((delegate* unmanaged[Cdecl]<int>)FuncTable[61])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesGetSelectedNodes(int* nodeIds)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[62])((IntPtr)nodeIds);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesGetSelectedLinks(int* linkIds)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[63])((IntPtr)linkIds);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesClearNodeSelection()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[64])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesClearLinkSelection()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[65])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesSelectNode(int nodeId)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[66])(nodeId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesClearNodeSelection(int nodeId)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[67])(nodeId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImNodesIsNodeSelected(int nodeId)
		{
			return ((delegate* unmanaged[Cdecl]<int, byte>)FuncTable[68])(nodeId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesSelectLink(int linkId)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[69])(linkId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesClearLinkSelection(int linkId)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[70])(linkId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImNodesIsLinkSelected(int linkId)
		{
			return ((delegate* unmanaged[Cdecl]<int, byte>)FuncTable[71])(linkId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImNodesIsAttributeActive()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[72])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImNodesIsAnyAttributeActive(int* attributeId)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[73])((IntPtr)attributeId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImNodesIsLinkStarted(int* startedAtAttributeId)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[74])((IntPtr)startedAtAttributeId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImNodesIsLinkDropped(int* startedAtAttributeId, byte includingDetachedLinks)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte, byte>)FuncTable[75])((IntPtr)startedAtAttributeId, includingDetachedLinks);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImNodesIsLinkCreated(int* startedAtAttributeId, int* endedAtAttributeId, byte* createdFromSnap)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, byte>)FuncTable[76])((IntPtr)startedAtAttributeId, (IntPtr)endedAtAttributeId, (IntPtr)createdFromSnap);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImNodesIsLinkCreated(int* startedAtNodeId, int* startedAtAttributeId, int* endedAtNodeId, int* endedAtAttributeId, byte* createdFromSnap)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, byte>)FuncTable[77])((IntPtr)startedAtNodeId, (IntPtr)startedAtAttributeId, (IntPtr)endedAtNodeId, (IntPtr)endedAtAttributeId, (IntPtr)createdFromSnap);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImNodesIsLinkDestroyed(int* linkId)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[78])((IntPtr)linkId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* ImNodesSaveCurrentEditorStateToIniString(uint* dataSize)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[79])((IntPtr)dataSize);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* ImNodesSaveEditorStateToIniString(ImNodesEditorContext* editor, uint* dataSize)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr>)FuncTable[80])((IntPtr)editor, (IntPtr)dataSize);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesLoadCurrentEditorStateFromIniString(byte* data, uint dataSize)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, void>)FuncTable[81])((IntPtr)data, dataSize);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesLoadEditorStateFromIniString(ImNodesEditorContext* editor, byte* data, uint dataSize)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, uint, void>)FuncTable[82])((IntPtr)editor, (IntPtr)data, dataSize);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesSaveCurrentEditorStateToIniFile(byte* fileName)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[83])((IntPtr)fileName);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesSaveEditorStateToIniFile(ImNodesEditorContext* editor, byte* fileName)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[84])((IntPtr)editor, (IntPtr)fileName);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesLoadCurrentEditorStateFromIniFile(byte* fileName)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[85])((IntPtr)fileName);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImNodesLoadEditorStateFromIniFile(ImNodesEditorContext* editor, byte* fileName)
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
