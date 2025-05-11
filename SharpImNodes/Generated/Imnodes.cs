using SharpImGui;
using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImNodes
{
	public static unsafe partial class Imnodes
	{
		public static void SetImGuiContext(ImGuiContextPtr ctx)
		{
			ImnodesNative.SetImGuiContext(ctx);
		}

		public static ImNodesContextPtr CreateContext()
		{
			return ImnodesNative.CreateContext();
		}

		public static void DestroyContext(ImNodesContextPtr ctx)
		{
			ImnodesNative.DestroyContext(ctx);
		}

		public static void DestroyContext()
		{
			// defining omitted parameters
			ImNodesContext* ctx = null;
			ImnodesNative.DestroyContext(ctx);
		}

		public static ImNodesContextPtr GetCurrentContext()
		{
			return ImnodesNative.GetCurrentContext();
		}

		public static void SetCurrentContext(ImNodesContextPtr ctx)
		{
			ImnodesNative.SetCurrentContext(ctx);
		}

		public static ImNodesEditorContextPtr EditorContextCreate()
		{
			return ImnodesNative.EditorContextCreate();
		}

		public static void EditorContextFree(ImNodesEditorContextPtr noname1)
		{
			ImnodesNative.EditorContextFree(noname1);
		}

		public static void EditorContextSet(ImNodesEditorContextPtr noname1)
		{
			ImnodesNative.EditorContextSet(noname1);
		}

		public static void EditorContextGetPanning(out Vector2 pOut)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImnodesNative.EditorContextGetPanning(nativePOut);
			}
		}

		public static void EditorContextResetPanning(Vector2 pos)
		{
			ImnodesNative.EditorContextResetPanning(pos);
		}

		public static void EditorContextMoveToNode(int nodeId)
		{
			ImnodesNative.EditorContextMoveToNode(nodeId);
		}

		public static ImNodesIOPtr GetIO()
		{
			return ImnodesNative.GetIO();
		}

		public static ImNodesStylePtr GetStyle()
		{
			return ImnodesNative.GetStyle();
		}

		public static void StyleColorsDark(ImNodesStylePtr dest)
		{
			ImnodesNative.StyleColorsDark(dest);
		}

		public static void StyleColorsDark()
		{
			// defining omitted parameters
			ImNodesStyle* dest = null;
			ImnodesNative.StyleColorsDark(dest);
		}

		public static void StyleColorsClassic(ImNodesStylePtr dest)
		{
			ImnodesNative.StyleColorsClassic(dest);
		}

		public static void StyleColorsClassic()
		{
			// defining omitted parameters
			ImNodesStyle* dest = null;
			ImnodesNative.StyleColorsClassic(dest);
		}

		public static void StyleColorsLight(ImNodesStylePtr dest)
		{
			ImnodesNative.StyleColorsLight(dest);
		}

		public static void StyleColorsLight()
		{
			// defining omitted parameters
			ImNodesStyle* dest = null;
			ImnodesNative.StyleColorsLight(dest);
		}

		public static void BeginNodeEditor()
		{
			ImnodesNative.BeginNodeEditor();
		}

		public static void EndNodeEditor()
		{
			ImnodesNative.EndNodeEditor();
		}

		public static void MiniMap(float minimapSizeFraction, ImNodesMiniMapLocation location, ImNodesMiniMapNodeHoveringCallback nodeHoveringCallback, IntPtr nodeHoveringCallbackData)
		{
			ImnodesNative.MiniMap(minimapSizeFraction, location, nodeHoveringCallback, (void*)nodeHoveringCallbackData);
		}

		public static void MiniMap(float minimapSizeFraction, ImNodesMiniMapLocation location, ImNodesMiniMapNodeHoveringCallback nodeHoveringCallback)
		{
			// defining omitted parameters
			void* nodeHoveringCallbackData = null;
			ImnodesNative.MiniMap(minimapSizeFraction, location, nodeHoveringCallback, nodeHoveringCallbackData);
		}

		public static void MiniMap(float minimapSizeFraction, ImNodesMiniMapLocation location)
		{
			// defining omitted parameters
			void* nodeHoveringCallbackData = null;
			ImNodesMiniMapNodeHoveringCallback nodeHoveringCallback = null;
			ImnodesNative.MiniMap(minimapSizeFraction, location, nodeHoveringCallback, nodeHoveringCallbackData);
		}

		public static void MiniMap(float minimapSizeFraction)
		{
			// defining omitted parameters
			void* nodeHoveringCallbackData = null;
			ImNodesMiniMapNodeHoveringCallback nodeHoveringCallback = null;
			ImNodesMiniMapLocation location = ImNodesMiniMapLocation.TopLeft;
			ImnodesNative.MiniMap(minimapSizeFraction, location, nodeHoveringCallback, nodeHoveringCallbackData);
		}

		public static void MiniMap()
		{
			// defining omitted parameters
			float minimapSizeFraction = 0.2f;
			void* nodeHoveringCallbackData = null;
			ImNodesMiniMapNodeHoveringCallback nodeHoveringCallback = null;
			ImNodesMiniMapLocation location = ImNodesMiniMapLocation.TopLeft;
			ImnodesNative.MiniMap(minimapSizeFraction, location, nodeHoveringCallback, nodeHoveringCallbackData);
		}

		public static void PushColorStyle(ImNodesCol item, uint color)
		{
			ImnodesNative.PushColorStyle(item, color);
		}

		public static void PopColorStyle()
		{
			ImnodesNative.PopColorStyle();
		}

		public static void PushStyleVar(ImNodesStyleVar styleItem, float value)
		{
			ImnodesNative.PushStyleVar(styleItem, value);
		}

		public static void PushStyleVar(ImNodesStyleVar styleItem, Vector2 value)
		{
			ImnodesNative.PushStyleVar(styleItem, value);
		}

		public static void PopStyleVar(int count)
		{
			ImnodesNative.PopStyleVar(count);
		}

		public static void PopStyleVar()
		{
			// defining omitted parameters
			int count = 1;
			ImnodesNative.PopStyleVar(count);
		}

		public static void BeginNode(int id)
		{
			ImnodesNative.BeginNode(id);
		}

		public static void EndNode()
		{
			ImnodesNative.EndNode();
		}

		public static void GetNodeDimensions(out Vector2 pOut, int id)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImnodesNative.GetNodeDimensions(nativePOut, id);
			}
		}

		public static void BeginNodeTitleBar()
		{
			ImnodesNative.BeginNodeTitleBar();
		}

		public static void EndNodeTitleBar()
		{
			ImnodesNative.EndNodeTitleBar();
		}

		public static void BeginInputAttribute(int id, ImNodesPinShape shape)
		{
			ImnodesNative.BeginInputAttribute(id, shape);
		}

		public static void BeginInputAttribute(int id)
		{
			// defining omitted parameters
			ImNodesPinShape shape = ImNodesPinShape.CircleFilled;
			ImnodesNative.BeginInputAttribute(id, shape);
		}

		public static void EndInputAttribute()
		{
			ImnodesNative.EndInputAttribute();
		}

		public static void BeginOutputAttribute(int id, ImNodesPinShape shape)
		{
			ImnodesNative.BeginOutputAttribute(id, shape);
		}

		public static void BeginOutputAttribute(int id)
		{
			// defining omitted parameters
			ImNodesPinShape shape = ImNodesPinShape.CircleFilled;
			ImnodesNative.BeginOutputAttribute(id, shape);
		}

		public static void EndOutputAttribute()
		{
			ImnodesNative.EndOutputAttribute();
		}

		public static void BeginStaticAttribute(int id)
		{
			ImnodesNative.BeginStaticAttribute(id);
		}

		public static void EndStaticAttribute()
		{
			ImnodesNative.EndStaticAttribute();
		}

		public static void PushAttributeFlag(ImNodesAttributeFlags flag)
		{
			ImnodesNative.PushAttributeFlag(flag);
		}

		public static void PopAttributeFlag()
		{
			ImnodesNative.PopAttributeFlag();
		}

		public static void Link(int id, int startAttributeId, int endAttributeId)
		{
			ImnodesNative.Link(id, startAttributeId, endAttributeId);
		}

		public static void SetNodeDraggable(int nodeId, bool draggable)
		{
			var native_draggable = draggable ? (byte)1 : (byte)0;
			ImnodesNative.SetNodeDraggable(nodeId, native_draggable);
		}

		public static void SetNodeScreenSpacePos(int nodeId, Vector2 screenSpacePos)
		{
			ImnodesNative.SetNodeScreenSpacePos(nodeId, screenSpacePos);
		}

		public static void SetNodeEditorSpacePos(int nodeId, Vector2 editorSpacePos)
		{
			ImnodesNative.SetNodeEditorSpacePos(nodeId, editorSpacePos);
		}

		public static void SetNodeGridSpacePos(int nodeId, Vector2 gridPos)
		{
			ImnodesNative.SetNodeGridSpacePos(nodeId, gridPos);
		}

		public static void GetNodeScreenSpacePos(out Vector2 pOut, int nodeId)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImnodesNative.GetNodeScreenSpacePos(nativePOut, nodeId);
			}
		}

		public static void GetNodeEditorSpacePos(out Vector2 pOut, int nodeId)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImnodesNative.GetNodeEditorSpacePos(nativePOut, nodeId);
			}
		}

		public static void GetNodeGridSpacePos(out Vector2 pOut, int nodeId)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImnodesNative.GetNodeGridSpacePos(nativePOut, nodeId);
			}
		}

		public static void SnapNodeToGrid(int nodeId)
		{
			ImnodesNative.SnapNodeToGrid(nodeId);
		}

		public static bool IsEditorHovered()
		{
			var result = ImnodesNative.IsEditorHovered();
			return result != 0;
		}

		public static bool IsNodeHovered(ref int nodeId)
		{
			fixed (int* nativeNodeId = &nodeId)
			{
				var result = ImnodesNative.IsNodeHovered(nativeNodeId);
				return result != 0;
			}
		}

		public static bool IsLinkHovered(ref int linkId)
		{
			fixed (int* nativeLinkId = &linkId)
			{
				var result = ImnodesNative.IsLinkHovered(nativeLinkId);
				return result != 0;
			}
		}

		public static bool IsPinHovered(ref int attributeId)
		{
			fixed (int* nativeAttributeId = &attributeId)
			{
				var result = ImnodesNative.IsPinHovered(nativeAttributeId);
				return result != 0;
			}
		}

		public static int NumSelectedNodes()
		{
			return ImnodesNative.NumSelectedNodes();
		}

		public static int NumSelectedLinks()
		{
			return ImnodesNative.NumSelectedLinks();
		}

		public static void GetSelectedNodes(ref int nodeIds)
		{
			fixed (int* nativeNodeIds = &nodeIds)
			{
				ImnodesNative.GetSelectedNodes(nativeNodeIds);
			}
		}

		public static void GetSelectedLinks(ref int linkIds)
		{
			fixed (int* nativeLinkIds = &linkIds)
			{
				ImnodesNative.GetSelectedLinks(nativeLinkIds);
			}
		}

		public static void ClearNodeSelection()
		{
			ImnodesNative.ClearNodeSelection();
		}

		public static void ClearLinkSelection()
		{
			ImnodesNative.ClearLinkSelection();
		}

		public static void SelectNode(int nodeId)
		{
			ImnodesNative.SelectNode(nodeId);
		}

		public static void ClearNodeSelection(int nodeId)
		{
			ImnodesNative.ClearNodeSelection(nodeId);
		}

		public static bool IsNodeSelected(int nodeId)
		{
			var result = ImnodesNative.IsNodeSelected(nodeId);
			return result != 0;
		}

		public static void SelectLink(int linkId)
		{
			ImnodesNative.SelectLink(linkId);
		}

		public static void ClearLinkSelection(int linkId)
		{
			ImnodesNative.ClearLinkSelection(linkId);
		}

		public static bool IsLinkSelected(int linkId)
		{
			var result = ImnodesNative.IsLinkSelected(linkId);
			return result != 0;
		}

		public static bool IsAttributeActive()
		{
			var result = ImnodesNative.IsAttributeActive();
			return result != 0;
		}

		public static bool IsAnyAttributeActive(ref int attributeId)
		{
			fixed (int* nativeAttributeId = &attributeId)
			{
				var result = ImnodesNative.IsAnyAttributeActive(nativeAttributeId);
				return result != 0;
			}
		}

		public static bool IsAnyAttributeActive()
		{
			// defining omitted parameters
			int* attributeId = null;
			var result = ImnodesNative.IsAnyAttributeActive(attributeId);
			return result != 0;
		}

		public static bool IsLinkStarted(ref int startedAtAttributeId)
		{
			fixed (int* nativeStartedAtAttributeId = &startedAtAttributeId)
			{
				var result = ImnodesNative.IsLinkStarted(nativeStartedAtAttributeId);
				return result != 0;
			}
		}

		public static bool IsLinkDropped(ref int startedAtAttributeId, bool includingDetachedLinks)
		{
			var native_includingDetachedLinks = includingDetachedLinks ? (byte)1 : (byte)0;
			fixed (int* nativeStartedAtAttributeId = &startedAtAttributeId)
			{
				var result = ImnodesNative.IsLinkDropped(nativeStartedAtAttributeId, native_includingDetachedLinks);
				return result != 0;
			}
		}

		public static bool IsLinkDropped(ref int startedAtAttributeId)
		{
			// defining omitted parameters
			byte includingDetachedLinks = 1;
			fixed (int* nativeStartedAtAttributeId = &startedAtAttributeId)
			{
				var result = ImnodesNative.IsLinkDropped(nativeStartedAtAttributeId, includingDetachedLinks);
				return result != 0;
			}
		}

		public static bool IsLinkDropped()
		{
			// defining omitted parameters
			byte includingDetachedLinks = 1;
			int* startedAtAttributeId = null;
			var result = ImnodesNative.IsLinkDropped(startedAtAttributeId, includingDetachedLinks);
			return result != 0;
		}

		public static bool IsLinkCreated(ref int startedAtAttributeId, ref int endedAtAttributeId, ref bool createdFromSnap)
		{
			var nativeCreatedFromSnapVal = createdFromSnap ? (byte)1 : (byte)0;
			var nativeCreatedFromSnap = &nativeCreatedFromSnapVal;
			fixed (int* nativeStartedAtAttributeId = &startedAtAttributeId)
			fixed (int* nativeEndedAtAttributeId = &endedAtAttributeId)
			{
				var result = ImnodesNative.IsLinkCreated(nativeStartedAtAttributeId, nativeEndedAtAttributeId, nativeCreatedFromSnap);
				createdFromSnap = nativeCreatedFromSnapVal != 0;
				return result != 0;
			}
		}

		public static bool IsLinkCreated(ref int startedAtNodeId, ref int startedAtAttributeId, ref int endedAtNodeId, ref int endedAtAttributeId, ref bool createdFromSnap)
		{
			var nativeCreatedFromSnapVal = createdFromSnap ? (byte)1 : (byte)0;
			var nativeCreatedFromSnap = &nativeCreatedFromSnapVal;
			fixed (int* nativeStartedAtNodeId = &startedAtNodeId)
			fixed (int* nativeStartedAtAttributeId = &startedAtAttributeId)
			fixed (int* nativeEndedAtNodeId = &endedAtNodeId)
			fixed (int* nativeEndedAtAttributeId = &endedAtAttributeId)
			{
				var result = ImnodesNative.IsLinkCreated(nativeStartedAtNodeId, nativeStartedAtAttributeId, nativeEndedAtNodeId, nativeEndedAtAttributeId, nativeCreatedFromSnap);
				createdFromSnap = nativeCreatedFromSnapVal != 0;
				return result != 0;
			}
		}

		public static bool IsLinkDestroyed(ref int linkId)
		{
			fixed (int* nativeLinkId = &linkId)
			{
				var result = ImnodesNative.IsLinkDestroyed(nativeLinkId);
				return result != 0;
			}
		}

		public static ref byte SaveCurrentEditorStateToIniString(ref uint dataSize)
		{
			fixed (uint* nativeDataSize = &dataSize)
			{
				var nativeResult = ImnodesNative.SaveCurrentEditorStateToIniString(nativeDataSize);
				return ref *(byte*)&nativeResult;
			}
		}

		public static ref byte SaveCurrentEditorStateToIniString()
		{
			// defining omitted parameters
			uint* dataSize = null;
			var nativeResult = ImnodesNative.SaveCurrentEditorStateToIniString(dataSize);
			return ref *(byte*)&nativeResult;
		}

		public static ref byte SaveEditorStateToIniString(ImNodesEditorContextPtr editor, ref uint dataSize)
		{
			fixed (uint* nativeDataSize = &dataSize)
			{
				var nativeResult = ImnodesNative.SaveEditorStateToIniString(editor, nativeDataSize);
				return ref *(byte*)&nativeResult;
			}
		}

		public static ref byte SaveEditorStateToIniString(ImNodesEditorContextPtr editor)
		{
			// defining omitted parameters
			uint* dataSize = null;
			var nativeResult = ImnodesNative.SaveEditorStateToIniString(editor, dataSize);
			return ref *(byte*)&nativeResult;
		}

		public static void LoadCurrentEditorStateFromIniString(ReadOnlySpan<byte> data, uint dataSize)
		{
			fixed (byte* nativeData = data)
			{
				ImnodesNative.LoadCurrentEditorStateFromIniString(nativeData, dataSize);
			}
		}

		public static void LoadCurrentEditorStateFromIniString(ReadOnlySpan<char> data, uint dataSize)
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

			ImnodesNative.LoadCurrentEditorStateFromIniString(nativeData, dataSize);
			// Freeing data native string
			if (byteCountData > Utils.MaxStackallocSize)
				Utils.Free(nativeData);
		}

		public static void LoadEditorStateFromIniString(ImNodesEditorContextPtr editor, ReadOnlySpan<byte> data, uint dataSize)
		{
			fixed (byte* nativeData = data)
			{
				ImnodesNative.LoadEditorStateFromIniString(editor, nativeData, dataSize);
			}
		}

		public static void LoadEditorStateFromIniString(ImNodesEditorContextPtr editor, ReadOnlySpan<char> data, uint dataSize)
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

			ImnodesNative.LoadEditorStateFromIniString(editor, nativeData, dataSize);
			// Freeing data native string
			if (byteCountData > Utils.MaxStackallocSize)
				Utils.Free(nativeData);
		}

		public static void SaveCurrentEditorStateToIniFile(ReadOnlySpan<byte> fileName)
		{
			fixed (byte* nativeFileName = fileName)
			{
				ImnodesNative.SaveCurrentEditorStateToIniFile(nativeFileName);
			}
		}

		public static void SaveCurrentEditorStateToIniFile(ReadOnlySpan<char> fileName)
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

			ImnodesNative.SaveCurrentEditorStateToIniFile(nativeFileName);
			// Freeing fileName native string
			if (byteCountFileName > Utils.MaxStackallocSize)
				Utils.Free(nativeFileName);
		}

		public static void SaveEditorStateToIniFile(ImNodesEditorContextPtr editor, ReadOnlySpan<byte> fileName)
		{
			fixed (byte* nativeFileName = fileName)
			{
				ImnodesNative.SaveEditorStateToIniFile(editor, nativeFileName);
			}
		}

		public static void SaveEditorStateToIniFile(ImNodesEditorContextPtr editor, ReadOnlySpan<char> fileName)
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

			ImnodesNative.SaveEditorStateToIniFile(editor, nativeFileName);
			// Freeing fileName native string
			if (byteCountFileName > Utils.MaxStackallocSize)
				Utils.Free(nativeFileName);
		}

		public static void LoadCurrentEditorStateFromIniFile(ReadOnlySpan<byte> fileName)
		{
			fixed (byte* nativeFileName = fileName)
			{
				ImnodesNative.LoadCurrentEditorStateFromIniFile(nativeFileName);
			}
		}

		public static void LoadCurrentEditorStateFromIniFile(ReadOnlySpan<char> fileName)
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

			ImnodesNative.LoadCurrentEditorStateFromIniFile(nativeFileName);
			// Freeing fileName native string
			if (byteCountFileName > Utils.MaxStackallocSize)
				Utils.Free(nativeFileName);
		}

		public static void LoadEditorStateFromIniFile(ImNodesEditorContextPtr editor, ReadOnlySpan<byte> fileName)
		{
			fixed (byte* nativeFileName = fileName)
			{
				ImnodesNative.LoadEditorStateFromIniFile(editor, nativeFileName);
			}
		}

		public static void LoadEditorStateFromIniFile(ImNodesEditorContextPtr editor, ReadOnlySpan<char> fileName)
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

			ImnodesNative.LoadEditorStateFromIniFile(editor, nativeFileName);
			// Freeing fileName native string
			if (byteCountFileName > Utils.MaxStackallocSize)
				Utils.Free(nativeFileName);
		}

		public static ref byte GetIoKeyCtrlPtr()
		{
			var nativeResult = ImnodesNative.GetIoKeyCtrlPtr();
			return ref *(byte*)&nativeResult;
		}

	}
}
