using SharpImGui;
using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImNodes
{
	public static unsafe partial class ImNodes
	{
		public static void ImNodesSetImGuiContext(ImGuiContextPtr ctx)
		{
			ImNodesNative.ImNodesSetImGuiContext(ctx);
		}

		public static ImNodesContextPtr ImNodesCreateContext()
		{
			return ImNodesNative.ImNodesCreateContext();
		}

		public static void ImNodesDestroyContext(ImNodesContextPtr ctx)
		{
			ImNodesNative.ImNodesDestroyContext(ctx);
		}

		public static void ImNodesDestroyContext()
		{
			// defining omitted parameters
			ImNodesContext* ctx = null;
			ImNodesNative.ImNodesDestroyContext(ctx);
		}

		public static ImNodesContextPtr ImNodesGetCurrentContext()
		{
			return ImNodesNative.ImNodesGetCurrentContext();
		}

		public static void ImNodesSetCurrentContext(ImNodesContextPtr ctx)
		{
			ImNodesNative.ImNodesSetCurrentContext(ctx);
		}

		public static ImNodesEditorContextPtr ImNodesEditorContextCreate()
		{
			return ImNodesNative.ImNodesEditorContextCreate();
		}

		public static void ImNodesEditorContextFree(ImNodesEditorContextPtr noname1)
		{
			ImNodesNative.ImNodesEditorContextFree(noname1);
		}

		public static void ImNodesEditorContextSet(ImNodesEditorContextPtr noname1)
		{
			ImNodesNative.ImNodesEditorContextSet(noname1);
		}

		public static void ImNodesEditorContextGetPanning(out Vector2 pOut)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImNodesNative.ImNodesEditorContextGetPanning(nativePOut);
			}
		}

		public static void ImNodesEditorContextResetPanning(Vector2 pos)
		{
			ImNodesNative.ImNodesEditorContextResetPanning(pos);
		}

		public static void ImNodesEditorContextMoveToNode(int nodeId)
		{
			ImNodesNative.ImNodesEditorContextMoveToNode(nodeId);
		}

		public static ImNodesIOPtr ImNodesGetIO()
		{
			return ImNodesNative.ImNodesGetIO();
		}

		public static ImNodesStylePtr ImNodesGetStyle()
		{
			return ImNodesNative.ImNodesGetStyle();
		}

		public static void ImNodesStyleColorsDark(ImNodesStylePtr dest)
		{
			ImNodesNative.ImNodesStyleColorsDark(dest);
		}

		public static void ImNodesStyleColorsDark()
		{
			// defining omitted parameters
			ImNodesStyle* dest = null;
			ImNodesNative.ImNodesStyleColorsDark(dest);
		}

		public static void ImNodesStyleColorsClassic(ImNodesStylePtr dest)
		{
			ImNodesNative.ImNodesStyleColorsClassic(dest);
		}

		public static void ImNodesStyleColorsClassic()
		{
			// defining omitted parameters
			ImNodesStyle* dest = null;
			ImNodesNative.ImNodesStyleColorsClassic(dest);
		}

		public static void ImNodesStyleColorsLight(ImNodesStylePtr dest)
		{
			ImNodesNative.ImNodesStyleColorsLight(dest);
		}

		public static void ImNodesStyleColorsLight()
		{
			// defining omitted parameters
			ImNodesStyle* dest = null;
			ImNodesNative.ImNodesStyleColorsLight(dest);
		}

		public static void ImNodesBeginNodeEditor()
		{
			ImNodesNative.ImNodesBeginNodeEditor();
		}

		public static void ImNodesEndNodeEditor()
		{
			ImNodesNative.ImNodesEndNodeEditor();
		}

		public static void ImNodesMiniMap(float minimapSizeFraction, ImNodesMiniMapLocation location, ImNodesMiniMapNodeHoveringCallback nodeHoveringCallback, IntPtr nodeHoveringCallbackData)
		{
			ImNodesNative.ImNodesMiniMap(minimapSizeFraction, location, nodeHoveringCallback, (void*)nodeHoveringCallbackData);
		}

		public static void ImNodesMiniMap(float minimapSizeFraction, ImNodesMiniMapLocation location, ImNodesMiniMapNodeHoveringCallback nodeHoveringCallback)
		{
			// defining omitted parameters
			void* nodeHoveringCallbackData = null;
			ImNodesNative.ImNodesMiniMap(minimapSizeFraction, location, nodeHoveringCallback, nodeHoveringCallbackData);
		}

		public static void ImNodesMiniMap(float minimapSizeFraction, ImNodesMiniMapLocation location)
		{
			// defining omitted parameters
			void* nodeHoveringCallbackData = null;
			ImNodesMiniMapNodeHoveringCallback nodeHoveringCallback = null;
			ImNodesNative.ImNodesMiniMap(minimapSizeFraction, location, nodeHoveringCallback, nodeHoveringCallbackData);
		}

		public static void ImNodesMiniMap(float minimapSizeFraction)
		{
			// defining omitted parameters
			void* nodeHoveringCallbackData = null;
			ImNodesMiniMapNodeHoveringCallback nodeHoveringCallback = null;
			ImNodesMiniMapLocation location = ImNodesMiniMapLocation.TopLeft;
			ImNodesNative.ImNodesMiniMap(minimapSizeFraction, location, nodeHoveringCallback, nodeHoveringCallbackData);
		}

		public static void ImNodesMiniMap()
		{
			// defining omitted parameters
			float minimapSizeFraction = 0.2f;
			void* nodeHoveringCallbackData = null;
			ImNodesMiniMapNodeHoveringCallback nodeHoveringCallback = null;
			ImNodesMiniMapLocation location = ImNodesMiniMapLocation.TopLeft;
			ImNodesNative.ImNodesMiniMap(minimapSizeFraction, location, nodeHoveringCallback, nodeHoveringCallbackData);
		}

		public static void ImNodesPushColorStyle(ImNodesCol item, uint color)
		{
			ImNodesNative.ImNodesPushColorStyle(item, color);
		}

		public static void ImNodesPopColorStyle()
		{
			ImNodesNative.ImNodesPopColorStyle();
		}

		public static void ImNodesPushStyleVar(ImNodesStyleVar styleItem, float value)
		{
			ImNodesNative.ImNodesPushStyleVar(styleItem, value);
		}

		public static void ImNodesPushStyleVar(ImNodesStyleVar styleItem, Vector2 value)
		{
			ImNodesNative.ImNodesPushStyleVar(styleItem, value);
		}

		public static void ImNodesPopStyleVar(int count)
		{
			ImNodesNative.ImNodesPopStyleVar(count);
		}

		public static void ImNodesPopStyleVar()
		{
			// defining omitted parameters
			int count = 1;
			ImNodesNative.ImNodesPopStyleVar(count);
		}

		public static void ImNodesBeginNode(int id)
		{
			ImNodesNative.ImNodesBeginNode(id);
		}

		public static void ImNodesEndNode()
		{
			ImNodesNative.ImNodesEndNode();
		}

		public static void ImNodesGetNodeDimensions(out Vector2 pOut, int id)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImNodesNative.ImNodesGetNodeDimensions(nativePOut, id);
			}
		}

		public static void ImNodesBeginNodeTitleBar()
		{
			ImNodesNative.ImNodesBeginNodeTitleBar();
		}

		public static void ImNodesEndNodeTitleBar()
		{
			ImNodesNative.ImNodesEndNodeTitleBar();
		}

		public static void ImNodesBeginInputAttribute(int id, ImNodesPinShape shape)
		{
			ImNodesNative.ImNodesBeginInputAttribute(id, shape);
		}

		public static void ImNodesBeginInputAttribute(int id)
		{
			// defining omitted parameters
			ImNodesPinShape shape = ImNodesPinShape.CircleFilled;
			ImNodesNative.ImNodesBeginInputAttribute(id, shape);
		}

		public static void ImNodesEndInputAttribute()
		{
			ImNodesNative.ImNodesEndInputAttribute();
		}

		public static void ImNodesBeginOutputAttribute(int id, ImNodesPinShape shape)
		{
			ImNodesNative.ImNodesBeginOutputAttribute(id, shape);
		}

		public static void ImNodesBeginOutputAttribute(int id)
		{
			// defining omitted parameters
			ImNodesPinShape shape = ImNodesPinShape.CircleFilled;
			ImNodesNative.ImNodesBeginOutputAttribute(id, shape);
		}

		public static void ImNodesEndOutputAttribute()
		{
			ImNodesNative.ImNodesEndOutputAttribute();
		}

		public static void ImNodesBeginStaticAttribute(int id)
		{
			ImNodesNative.ImNodesBeginStaticAttribute(id);
		}

		public static void ImNodesEndStaticAttribute()
		{
			ImNodesNative.ImNodesEndStaticAttribute();
		}

		public static void ImNodesPushAttributeFlag(ImNodesAttributeFlags flag)
		{
			ImNodesNative.ImNodesPushAttributeFlag(flag);
		}

		public static void ImNodesPopAttributeFlag()
		{
			ImNodesNative.ImNodesPopAttributeFlag();
		}

		public static void ImNodesLink(int id, int startAttributeId, int endAttributeId)
		{
			ImNodesNative.ImNodesLink(id, startAttributeId, endAttributeId);
		}

		public static void ImNodesSetNodeDraggable(int nodeId, bool draggable)
		{
			var native_draggable = draggable ? (byte)1 : (byte)0;
			ImNodesNative.ImNodesSetNodeDraggable(nodeId, native_draggable);
		}

		public static void ImNodesSetNodeScreenSpacePos(int nodeId, Vector2 screenSpacePos)
		{
			ImNodesNative.ImNodesSetNodeScreenSpacePos(nodeId, screenSpacePos);
		}

		public static void ImNodesSetNodeEditorSpacePos(int nodeId, Vector2 editorSpacePos)
		{
			ImNodesNative.ImNodesSetNodeEditorSpacePos(nodeId, editorSpacePos);
		}

		public static void ImNodesSetNodeGridSpacePos(int nodeId, Vector2 gridPos)
		{
			ImNodesNative.ImNodesSetNodeGridSpacePos(nodeId, gridPos);
		}

		public static void ImNodesGetNodeScreenSpacePos(out Vector2 pOut, int nodeId)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImNodesNative.ImNodesGetNodeScreenSpacePos(nativePOut, nodeId);
			}
		}

		public static void ImNodesGetNodeEditorSpacePos(out Vector2 pOut, int nodeId)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImNodesNative.ImNodesGetNodeEditorSpacePos(nativePOut, nodeId);
			}
		}

		public static void ImNodesGetNodeGridSpacePos(out Vector2 pOut, int nodeId)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImNodesNative.ImNodesGetNodeGridSpacePos(nativePOut, nodeId);
			}
		}

		public static void ImNodesSnapNodeToGrid(int nodeId)
		{
			ImNodesNative.ImNodesSnapNodeToGrid(nodeId);
		}

		public static bool ImNodesIsEditorHovered()
		{
			var result = ImNodesNative.ImNodesIsEditorHovered();
			return result != 0;
		}

		public static bool ImNodesIsNodeHovered(ref int nodeId)
		{
			fixed (int* nativeNodeId = &nodeId)
			{
				var result = ImNodesNative.ImNodesIsNodeHovered(nativeNodeId);
				return result != 0;
			}
		}

		public static bool ImNodesIsLinkHovered(ref int linkId)
		{
			fixed (int* nativeLinkId = &linkId)
			{
				var result = ImNodesNative.ImNodesIsLinkHovered(nativeLinkId);
				return result != 0;
			}
		}

		public static bool ImNodesIsPinHovered(ref int attributeId)
		{
			fixed (int* nativeAttributeId = &attributeId)
			{
				var result = ImNodesNative.ImNodesIsPinHovered(nativeAttributeId);
				return result != 0;
			}
		}

		public static int ImNodesNumSelectedNodes()
		{
			return ImNodesNative.ImNodesNumSelectedNodes();
		}

		public static int ImNodesNumSelectedLinks()
		{
			return ImNodesNative.ImNodesNumSelectedLinks();
		}

		public static void ImNodesGetSelectedNodes(ref int nodeIds)
		{
			fixed (int* nativeNodeIds = &nodeIds)
			{
				ImNodesNative.ImNodesGetSelectedNodes(nativeNodeIds);
			}
		}

		public static void ImNodesGetSelectedLinks(ref int linkIds)
		{
			fixed (int* nativeLinkIds = &linkIds)
			{
				ImNodesNative.ImNodesGetSelectedLinks(nativeLinkIds);
			}
		}

		public static void ImNodesClearNodeSelection()
		{
			ImNodesNative.ImNodesClearNodeSelection();
		}

		public static void ImNodesClearLinkSelection()
		{
			ImNodesNative.ImNodesClearLinkSelection();
		}

		public static void ImNodesSelectNode(int nodeId)
		{
			ImNodesNative.ImNodesSelectNode(nodeId);
		}

		public static void ImNodesClearNodeSelection(int nodeId)
		{
			ImNodesNative.ImNodesClearNodeSelection(nodeId);
		}

		public static bool ImNodesIsNodeSelected(int nodeId)
		{
			var result = ImNodesNative.ImNodesIsNodeSelected(nodeId);
			return result != 0;
		}

		public static void ImNodesSelectLink(int linkId)
		{
			ImNodesNative.ImNodesSelectLink(linkId);
		}

		public static void ImNodesClearLinkSelection(int linkId)
		{
			ImNodesNative.ImNodesClearLinkSelection(linkId);
		}

		public static bool ImNodesIsLinkSelected(int linkId)
		{
			var result = ImNodesNative.ImNodesIsLinkSelected(linkId);
			return result != 0;
		}

		public static bool ImNodesIsAttributeActive()
		{
			var result = ImNodesNative.ImNodesIsAttributeActive();
			return result != 0;
		}

		public static bool ImNodesIsAnyAttributeActive(ref int attributeId)
		{
			fixed (int* nativeAttributeId = &attributeId)
			{
				var result = ImNodesNative.ImNodesIsAnyAttributeActive(nativeAttributeId);
				return result != 0;
			}
		}

		public static bool ImNodesIsAnyAttributeActive()
		{
			// defining omitted parameters
			int* attributeId = null;
			var result = ImNodesNative.ImNodesIsAnyAttributeActive(attributeId);
			return result != 0;
		}

		public static bool ImNodesIsLinkStarted(ref int startedAtAttributeId)
		{
			fixed (int* nativeStartedAtAttributeId = &startedAtAttributeId)
			{
				var result = ImNodesNative.ImNodesIsLinkStarted(nativeStartedAtAttributeId);
				return result != 0;
			}
		}

		public static bool ImNodesIsLinkDropped(ref int startedAtAttributeId, bool includingDetachedLinks)
		{
			var native_includingDetachedLinks = includingDetachedLinks ? (byte)1 : (byte)0;
			fixed (int* nativeStartedAtAttributeId = &startedAtAttributeId)
			{
				var result = ImNodesNative.ImNodesIsLinkDropped(nativeStartedAtAttributeId, native_includingDetachedLinks);
				return result != 0;
			}
		}

		public static bool ImNodesIsLinkDropped(ref int startedAtAttributeId)
		{
			// defining omitted parameters
			byte includingDetachedLinks = 1;
			fixed (int* nativeStartedAtAttributeId = &startedAtAttributeId)
			{
				var result = ImNodesNative.ImNodesIsLinkDropped(nativeStartedAtAttributeId, includingDetachedLinks);
				return result != 0;
			}
		}

		public static bool ImNodesIsLinkDropped()
		{
			// defining omitted parameters
			byte includingDetachedLinks = 1;
			int* startedAtAttributeId = null;
			var result = ImNodesNative.ImNodesIsLinkDropped(startedAtAttributeId, includingDetachedLinks);
			return result != 0;
		}

		public static bool ImNodesIsLinkCreated(ref int startedAtAttributeId, ref int endedAtAttributeId, ref bool createdFromSnap)
		{
			var nativeCreatedFromSnapVal = createdFromSnap ? (byte)1 : (byte)0;
			var nativeCreatedFromSnap = &nativeCreatedFromSnapVal;
			fixed (int* nativeStartedAtAttributeId = &startedAtAttributeId)
			fixed (int* nativeEndedAtAttributeId = &endedAtAttributeId)
			{
				var result = ImNodesNative.ImNodesIsLinkCreated(nativeStartedAtAttributeId, nativeEndedAtAttributeId, nativeCreatedFromSnap);
				createdFromSnap = nativeCreatedFromSnapVal != 0;
				return result != 0;
			}
		}

		public static bool ImNodesIsLinkCreated(ref int startedAtNodeId, ref int startedAtAttributeId, ref int endedAtNodeId, ref int endedAtAttributeId, ref bool createdFromSnap)
		{
			var nativeCreatedFromSnapVal = createdFromSnap ? (byte)1 : (byte)0;
			var nativeCreatedFromSnap = &nativeCreatedFromSnapVal;
			fixed (int* nativeStartedAtNodeId = &startedAtNodeId)
			fixed (int* nativeStartedAtAttributeId = &startedAtAttributeId)
			fixed (int* nativeEndedAtNodeId = &endedAtNodeId)
			fixed (int* nativeEndedAtAttributeId = &endedAtAttributeId)
			{
				var result = ImNodesNative.ImNodesIsLinkCreated(nativeStartedAtNodeId, nativeStartedAtAttributeId, nativeEndedAtNodeId, nativeEndedAtAttributeId, nativeCreatedFromSnap);
				createdFromSnap = nativeCreatedFromSnapVal != 0;
				return result != 0;
			}
		}

		public static bool ImNodesIsLinkDestroyed(ref int linkId)
		{
			fixed (int* nativeLinkId = &linkId)
			{
				var result = ImNodesNative.ImNodesIsLinkDestroyed(nativeLinkId);
				return result != 0;
			}
		}

		public static string ImNodesSaveCurrentEditorStateToIniString(ref uint dataSize)
		{
			fixed (uint* nativeDataSize = &dataSize)
			{
				var result = ImNodesNative.ImNodesSaveCurrentEditorStateToIniString(nativeDataSize);
				return Utils.DecodeStringUTF8(result);
			}
		}

		public static string ImNodesSaveCurrentEditorStateToIniString()
		{
			// defining omitted parameters
			uint* dataSize = null;
			var result = ImNodesNative.ImNodesSaveCurrentEditorStateToIniString(dataSize);
			return Utils.DecodeStringUTF8(result);
		}

		public static string ImNodesSaveEditorStateToIniString(ImNodesEditorContextPtr editor, ref uint dataSize)
		{
			fixed (uint* nativeDataSize = &dataSize)
			{
				var result = ImNodesNative.ImNodesSaveEditorStateToIniString(editor, nativeDataSize);
				return Utils.DecodeStringUTF8(result);
			}
		}

		public static string ImNodesSaveEditorStateToIniString(ImNodesEditorContextPtr editor)
		{
			// defining omitted parameters
			uint* dataSize = null;
			var result = ImNodesNative.ImNodesSaveEditorStateToIniString(editor, dataSize);
			return Utils.DecodeStringUTF8(result);
		}

		public static void ImNodesLoadCurrentEditorStateFromIniString(ReadOnlySpan<byte> data, uint dataSize)
		{
			fixed (byte* nativeData = data)
			{
				ImNodesNative.ImNodesLoadCurrentEditorStateFromIniString(nativeData, dataSize);
			}
		}

		public static void ImNodesLoadCurrentEditorStateFromIniString(ReadOnlySpan<char> data, uint dataSize)
		{
			// Marshaling data to native string
			byte* nativeData;
			var byteCountData = 0;
			if (data != null && !data.IsEmpty)
			{
				byteCountData = Encoding.UTF8.GetByteCount(data);
				if(byteCountData > Utils.MaxStackallocSize)
				{
					nativeData = Utils.Alloc<byte>(byteCountData + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountData + 1];
					nativeData = stackallocBytes;
				}
				var offsetData = Utils.EncodeStringUTF8(data, nativeData, byteCountData);
				nativeData[offsetData] = 0;
			}
			else nativeData = null;

			ImNodesNative.ImNodesLoadCurrentEditorStateFromIniString(nativeData, dataSize);
			// Freeing data native string
			if (byteCountData > Utils.MaxStackallocSize)
				Utils.Free(nativeData);
		}

		public static void ImNodesLoadEditorStateFromIniString(ImNodesEditorContextPtr editor, ReadOnlySpan<byte> data, uint dataSize)
		{
			fixed (byte* nativeData = data)
			{
				ImNodesNative.ImNodesLoadEditorStateFromIniString(editor, nativeData, dataSize);
			}
		}

		public static void ImNodesLoadEditorStateFromIniString(ImNodesEditorContextPtr editor, ReadOnlySpan<char> data, uint dataSize)
		{
			// Marshaling data to native string
			byte* nativeData;
			var byteCountData = 0;
			if (data != null && !data.IsEmpty)
			{
				byteCountData = Encoding.UTF8.GetByteCount(data);
				if(byteCountData > Utils.MaxStackallocSize)
				{
					nativeData = Utils.Alloc<byte>(byteCountData + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountData + 1];
					nativeData = stackallocBytes;
				}
				var offsetData = Utils.EncodeStringUTF8(data, nativeData, byteCountData);
				nativeData[offsetData] = 0;
			}
			else nativeData = null;

			ImNodesNative.ImNodesLoadEditorStateFromIniString(editor, nativeData, dataSize);
			// Freeing data native string
			if (byteCountData > Utils.MaxStackallocSize)
				Utils.Free(nativeData);
		}

		public static void ImNodesSaveCurrentEditorStateToIniFile(ReadOnlySpan<byte> fileName)
		{
			fixed (byte* nativeFileName = fileName)
			{
				ImNodesNative.ImNodesSaveCurrentEditorStateToIniFile(nativeFileName);
			}
		}

		public static void ImNodesSaveCurrentEditorStateToIniFile(ReadOnlySpan<char> fileName)
		{
			// Marshaling fileName to native string
			byte* nativeFileName;
			var byteCountFileName = 0;
			if (fileName != null && !fileName.IsEmpty)
			{
				byteCountFileName = Encoding.UTF8.GetByteCount(fileName);
				if(byteCountFileName > Utils.MaxStackallocSize)
				{
					nativeFileName = Utils.Alloc<byte>(byteCountFileName + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFileName + 1];
					nativeFileName = stackallocBytes;
				}
				var offsetFileName = Utils.EncodeStringUTF8(fileName, nativeFileName, byteCountFileName);
				nativeFileName[offsetFileName] = 0;
			}
			else nativeFileName = null;

			ImNodesNative.ImNodesSaveCurrentEditorStateToIniFile(nativeFileName);
			// Freeing fileName native string
			if (byteCountFileName > Utils.MaxStackallocSize)
				Utils.Free(nativeFileName);
		}

		public static void ImNodesSaveEditorStateToIniFile(ImNodesEditorContextPtr editor, ReadOnlySpan<byte> fileName)
		{
			fixed (byte* nativeFileName = fileName)
			{
				ImNodesNative.ImNodesSaveEditorStateToIniFile(editor, nativeFileName);
			}
		}

		public static void ImNodesSaveEditorStateToIniFile(ImNodesEditorContextPtr editor, ReadOnlySpan<char> fileName)
		{
			// Marshaling fileName to native string
			byte* nativeFileName;
			var byteCountFileName = 0;
			if (fileName != null && !fileName.IsEmpty)
			{
				byteCountFileName = Encoding.UTF8.GetByteCount(fileName);
				if(byteCountFileName > Utils.MaxStackallocSize)
				{
					nativeFileName = Utils.Alloc<byte>(byteCountFileName + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFileName + 1];
					nativeFileName = stackallocBytes;
				}
				var offsetFileName = Utils.EncodeStringUTF8(fileName, nativeFileName, byteCountFileName);
				nativeFileName[offsetFileName] = 0;
			}
			else nativeFileName = null;

			ImNodesNative.ImNodesSaveEditorStateToIniFile(editor, nativeFileName);
			// Freeing fileName native string
			if (byteCountFileName > Utils.MaxStackallocSize)
				Utils.Free(nativeFileName);
		}

		public static void ImNodesLoadCurrentEditorStateFromIniFile(ReadOnlySpan<byte> fileName)
		{
			fixed (byte* nativeFileName = fileName)
			{
				ImNodesNative.ImNodesLoadCurrentEditorStateFromIniFile(nativeFileName);
			}
		}

		public static void ImNodesLoadCurrentEditorStateFromIniFile(ReadOnlySpan<char> fileName)
		{
			// Marshaling fileName to native string
			byte* nativeFileName;
			var byteCountFileName = 0;
			if (fileName != null && !fileName.IsEmpty)
			{
				byteCountFileName = Encoding.UTF8.GetByteCount(fileName);
				if(byteCountFileName > Utils.MaxStackallocSize)
				{
					nativeFileName = Utils.Alloc<byte>(byteCountFileName + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFileName + 1];
					nativeFileName = stackallocBytes;
				}
				var offsetFileName = Utils.EncodeStringUTF8(fileName, nativeFileName, byteCountFileName);
				nativeFileName[offsetFileName] = 0;
			}
			else nativeFileName = null;

			ImNodesNative.ImNodesLoadCurrentEditorStateFromIniFile(nativeFileName);
			// Freeing fileName native string
			if (byteCountFileName > Utils.MaxStackallocSize)
				Utils.Free(nativeFileName);
		}

		public static void ImNodesLoadEditorStateFromIniFile(ImNodesEditorContextPtr editor, ReadOnlySpan<byte> fileName)
		{
			fixed (byte* nativeFileName = fileName)
			{
				ImNodesNative.ImNodesLoadEditorStateFromIniFile(editor, nativeFileName);
			}
		}

		public static void ImNodesLoadEditorStateFromIniFile(ImNodesEditorContextPtr editor, ReadOnlySpan<char> fileName)
		{
			// Marshaling fileName to native string
			byte* nativeFileName;
			var byteCountFileName = 0;
			if (fileName != null && !fileName.IsEmpty)
			{
				byteCountFileName = Encoding.UTF8.GetByteCount(fileName);
				if(byteCountFileName > Utils.MaxStackallocSize)
				{
					nativeFileName = Utils.Alloc<byte>(byteCountFileName + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFileName + 1];
					nativeFileName = stackallocBytes;
				}
				var offsetFileName = Utils.EncodeStringUTF8(fileName, nativeFileName, byteCountFileName);
				nativeFileName[offsetFileName] = 0;
			}
			else nativeFileName = null;

			ImNodesNative.ImNodesLoadEditorStateFromIniFile(editor, nativeFileName);
			// Freeing fileName native string
			if (byteCountFileName > Utils.MaxStackallocSize)
				Utils.Free(nativeFileName);
		}

		public static ref byte GetIoKeyCtrlPtr()
		{
			var nativeResult = ImNodesNative.GetIoKeyCtrlPtr();
			return ref *(byte*)&nativeResult;
		}

	}
}
