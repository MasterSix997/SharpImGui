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

		public static void EditorContextGetPanning(ref Vector2 pOut)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImnodesNative.EditorContextGetPanning(native_pOut);
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

		public static void StyleColorsClassic(ImNodesStylePtr dest)
		{
			ImnodesNative.StyleColorsClassic(dest);
		}

		public static void StyleColorsLight(ImNodesStylePtr dest)
		{
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

		public static void BeginNode(int id)
		{
			ImnodesNative.BeginNode(id);
		}

		public static void EndNode()
		{
			ImnodesNative.EndNode();
		}

		public static void GetNodeDimensions(ref Vector2 pOut, int id)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImnodesNative.GetNodeDimensions(native_pOut, id);
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

		public static void EndInputAttribute()
		{
			ImnodesNative.EndInputAttribute();
		}

		public static void BeginOutputAttribute(int id, ImNodesPinShape shape)
		{
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

		public static void GetNodeScreenSpacePos(ref Vector2 pOut, int nodeId)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImnodesNative.GetNodeScreenSpacePos(native_pOut, nodeId);
			}
		}

		public static void GetNodeEditorSpacePos(ref Vector2 pOut, int nodeId)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImnodesNative.GetNodeEditorSpacePos(native_pOut, nodeId);
			}
		}

		public static void GetNodeGridSpacePos(ref Vector2 pOut, int nodeId)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImnodesNative.GetNodeGridSpacePos(native_pOut, nodeId);
			}
		}

		public static void SnapNodeToGrid(int nodeId)
		{
			ImnodesNative.SnapNodeToGrid(nodeId);
		}

		public static byte IsEditorHovered()
		{
			return ImnodesNative.IsEditorHovered();
		}

		public static byte IsNodeHovered(ref int nodeId)
		{
			fixed (int* native_nodeId = &nodeId)
			{
				var result = ImnodesNative.IsNodeHovered(native_nodeId);
				return result;
			}
		}

		public static byte IsLinkHovered(ref int linkId)
		{
			fixed (int* native_linkId = &linkId)
			{
				var result = ImnodesNative.IsLinkHovered(native_linkId);
				return result;
			}
		}

		public static byte IsPinHovered(ref int attributeId)
		{
			fixed (int* native_attributeId = &attributeId)
			{
				var result = ImnodesNative.IsPinHovered(native_attributeId);
				return result;
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
			fixed (int* native_nodeIds = &nodeIds)
			{
				ImnodesNative.GetSelectedNodes(native_nodeIds);
			}
		}

		public static void GetSelectedLinks(ref int linkIds)
		{
			fixed (int* native_linkIds = &linkIds)
			{
				ImnodesNative.GetSelectedLinks(native_linkIds);
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

		public static byte IsNodeSelected(int nodeId)
		{
			return ImnodesNative.IsNodeSelected(nodeId);
		}

		public static void SelectLink(int linkId)
		{
			ImnodesNative.SelectLink(linkId);
		}

		public static void ClearLinkSelection(int linkId)
		{
			ImnodesNative.ClearLinkSelection(linkId);
		}

		public static byte IsLinkSelected(int linkId)
		{
			return ImnodesNative.IsLinkSelected(linkId);
		}

		public static byte IsAttributeActive()
		{
			return ImnodesNative.IsAttributeActive();
		}

		public static byte IsAnyAttributeActive(ref int attributeId)
		{
			fixed (int* native_attributeId = &attributeId)
			{
				var result = ImnodesNative.IsAnyAttributeActive(native_attributeId);
				return result;
			}
		}

		public static byte IsLinkStarted(ref int startedAtAttributeId)
		{
			fixed (int* native_startedAtAttributeId = &startedAtAttributeId)
			{
				var result = ImnodesNative.IsLinkStarted(native_startedAtAttributeId);
				return result;
			}
		}

		public static byte IsLinkDropped(ref int startedAtAttributeId, bool includingDetachedLinks)
		{
			var native_includingDetachedLinks = includingDetachedLinks ? (byte)1 : (byte)0;
			fixed (int* native_startedAtAttributeId = &startedAtAttributeId)
			{
				var result = ImnodesNative.IsLinkDropped(native_startedAtAttributeId, native_includingDetachedLinks);
				return result;
			}
		}

		public static byte IsLinkCreated(ref int startedAtAttributeId, ref int endedAtAttributeId, ReadOnlySpan<char> createdFromSnap)
		{
			// Marshaling createdFromSnap to native string
			byte* native_createdFromSnap;
			var byteCount_createdFromSnap = 0;
			if (createdFromSnap != null)
			{
				byteCount_createdFromSnap = Encoding.UTF8.GetByteCount(createdFromSnap);
				if(byteCount_createdFromSnap > Utils.MaxStackallocSize)
				{
					native_createdFromSnap = Utils.Alloc<byte>(byteCount_createdFromSnap + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_createdFromSnap + 1];
					native_createdFromSnap = stackallocBytes;
				}
				var createdFromSnap_offset = Utils.EncodeStringUTF8(createdFromSnap, native_createdFromSnap, byteCount_createdFromSnap);
				native_createdFromSnap[createdFromSnap_offset] = 0;
			}
			else native_createdFromSnap = null;

			fixed (int* native_startedAtAttributeId = &startedAtAttributeId)
			fixed (int* native_endedAtAttributeId = &endedAtAttributeId)
			{
				var result = ImnodesNative.IsLinkCreated(native_startedAtAttributeId, native_endedAtAttributeId, native_createdFromSnap);
				// Freeing createdFromSnap native string
				if (byteCount_createdFromSnap > Utils.MaxStackallocSize)
					Utils.Free(native_createdFromSnap);
				return result;
			}
		}

		public static byte IsLinkCreated(ref int startedAtNodeId, ref int startedAtAttributeId, ref int endedAtNodeId, ref int endedAtAttributeId, ReadOnlySpan<char> createdFromSnap)
		{
			// Marshaling createdFromSnap to native string
			byte* native_createdFromSnap;
			var byteCount_createdFromSnap = 0;
			if (createdFromSnap != null)
			{
				byteCount_createdFromSnap = Encoding.UTF8.GetByteCount(createdFromSnap);
				if(byteCount_createdFromSnap > Utils.MaxStackallocSize)
				{
					native_createdFromSnap = Utils.Alloc<byte>(byteCount_createdFromSnap + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_createdFromSnap + 1];
					native_createdFromSnap = stackallocBytes;
				}
				var createdFromSnap_offset = Utils.EncodeStringUTF8(createdFromSnap, native_createdFromSnap, byteCount_createdFromSnap);
				native_createdFromSnap[createdFromSnap_offset] = 0;
			}
			else native_createdFromSnap = null;

			fixed (int* native_startedAtNodeId = &startedAtNodeId)
			fixed (int* native_startedAtAttributeId = &startedAtAttributeId)
			fixed (int* native_endedAtNodeId = &endedAtNodeId)
			fixed (int* native_endedAtAttributeId = &endedAtAttributeId)
			{
				var result = ImnodesNative.IsLinkCreated(native_startedAtNodeId, native_startedAtAttributeId, native_endedAtNodeId, native_endedAtAttributeId, native_createdFromSnap);
				// Freeing createdFromSnap native string
				if (byteCount_createdFromSnap > Utils.MaxStackallocSize)
					Utils.Free(native_createdFromSnap);
				return result;
			}
		}

		public static byte IsLinkDestroyed(ref int linkId)
		{
			fixed (int* native_linkId = &linkId)
			{
				var result = ImnodesNative.IsLinkDestroyed(native_linkId);
				return result;
			}
		}

		public static ref byte SaveCurrentEditorStateToIniString(ref uint dataSize)
		{
			fixed (uint* native_dataSize = &dataSize)
			{
				var nativeResult = ImnodesNative.SaveCurrentEditorStateToIniString(native_dataSize);
				return ref *(byte*)&nativeResult;
			}
		}

		public static ref byte SaveEditorStateToIniString(ImNodesEditorContextPtr editor, ref uint dataSize)
		{
			fixed (uint* native_dataSize = &dataSize)
			{
				var nativeResult = ImnodesNative.SaveEditorStateToIniString(editor, native_dataSize);
				return ref *(byte*)&nativeResult;
			}
		}

		public static void LoadCurrentEditorStateFromIniString(ReadOnlySpan<char> data, uint dataSize)
		{
			// Marshaling data to native string
			byte* native_data;
			var byteCount_data = 0;
			if (data != null)
			{
				byteCount_data = Encoding.UTF8.GetByteCount(data);
				if(byteCount_data > Utils.MaxStackallocSize)
				{
					native_data = Utils.Alloc<byte>(byteCount_data + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_data + 1];
					native_data = stackallocBytes;
				}
				var data_offset = Utils.EncodeStringUTF8(data, native_data, byteCount_data);
				native_data[data_offset] = 0;
			}
			else native_data = null;

			ImnodesNative.LoadCurrentEditorStateFromIniString(native_data, dataSize);
			// Freeing data native string
			if (byteCount_data > Utils.MaxStackallocSize)
				Utils.Free(native_data);
		}

		public static void LoadEditorStateFromIniString(ImNodesEditorContextPtr editor, ReadOnlySpan<char> data, uint dataSize)
		{
			// Marshaling data to native string
			byte* native_data;
			var byteCount_data = 0;
			if (data != null)
			{
				byteCount_data = Encoding.UTF8.GetByteCount(data);
				if(byteCount_data > Utils.MaxStackallocSize)
				{
					native_data = Utils.Alloc<byte>(byteCount_data + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_data + 1];
					native_data = stackallocBytes;
				}
				var data_offset = Utils.EncodeStringUTF8(data, native_data, byteCount_data);
				native_data[data_offset] = 0;
			}
			else native_data = null;

			ImnodesNative.LoadEditorStateFromIniString(editor, native_data, dataSize);
			// Freeing data native string
			if (byteCount_data > Utils.MaxStackallocSize)
				Utils.Free(native_data);
		}

		public static void SaveCurrentEditorStateToIniFile(ReadOnlySpan<char> fileName)
		{
			// Marshaling fileName to native string
			byte* native_fileName;
			var byteCount_fileName = 0;
			if (fileName != null)
			{
				byteCount_fileName = Encoding.UTF8.GetByteCount(fileName);
				if(byteCount_fileName > Utils.MaxStackallocSize)
				{
					native_fileName = Utils.Alloc<byte>(byteCount_fileName + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_fileName + 1];
					native_fileName = stackallocBytes;
				}
				var fileName_offset = Utils.EncodeStringUTF8(fileName, native_fileName, byteCount_fileName);
				native_fileName[fileName_offset] = 0;
			}
			else native_fileName = null;

			ImnodesNative.SaveCurrentEditorStateToIniFile(native_fileName);
			// Freeing fileName native string
			if (byteCount_fileName > Utils.MaxStackallocSize)
				Utils.Free(native_fileName);
		}

		public static void SaveEditorStateToIniFile(ImNodesEditorContextPtr editor, ReadOnlySpan<char> fileName)
		{
			// Marshaling fileName to native string
			byte* native_fileName;
			var byteCount_fileName = 0;
			if (fileName != null)
			{
				byteCount_fileName = Encoding.UTF8.GetByteCount(fileName);
				if(byteCount_fileName > Utils.MaxStackallocSize)
				{
					native_fileName = Utils.Alloc<byte>(byteCount_fileName + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_fileName + 1];
					native_fileName = stackallocBytes;
				}
				var fileName_offset = Utils.EncodeStringUTF8(fileName, native_fileName, byteCount_fileName);
				native_fileName[fileName_offset] = 0;
			}
			else native_fileName = null;

			ImnodesNative.SaveEditorStateToIniFile(editor, native_fileName);
			// Freeing fileName native string
			if (byteCount_fileName > Utils.MaxStackallocSize)
				Utils.Free(native_fileName);
		}

		public static void LoadCurrentEditorStateFromIniFile(ReadOnlySpan<char> fileName)
		{
			// Marshaling fileName to native string
			byte* native_fileName;
			var byteCount_fileName = 0;
			if (fileName != null)
			{
				byteCount_fileName = Encoding.UTF8.GetByteCount(fileName);
				if(byteCount_fileName > Utils.MaxStackallocSize)
				{
					native_fileName = Utils.Alloc<byte>(byteCount_fileName + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_fileName + 1];
					native_fileName = stackallocBytes;
				}
				var fileName_offset = Utils.EncodeStringUTF8(fileName, native_fileName, byteCount_fileName);
				native_fileName[fileName_offset] = 0;
			}
			else native_fileName = null;

			ImnodesNative.LoadCurrentEditorStateFromIniFile(native_fileName);
			// Freeing fileName native string
			if (byteCount_fileName > Utils.MaxStackallocSize)
				Utils.Free(native_fileName);
		}

		public static void LoadEditorStateFromIniFile(ImNodesEditorContextPtr editor, ReadOnlySpan<char> fileName)
		{
			// Marshaling fileName to native string
			byte* native_fileName;
			var byteCount_fileName = 0;
			if (fileName != null)
			{
				byteCount_fileName = Encoding.UTF8.GetByteCount(fileName);
				if(byteCount_fileName > Utils.MaxStackallocSize)
				{
					native_fileName = Utils.Alloc<byte>(byteCount_fileName + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_fileName + 1];
					native_fileName = stackallocBytes;
				}
				var fileName_offset = Utils.EncodeStringUTF8(fileName, native_fileName, byteCount_fileName);
				native_fileName[fileName_offset] = 0;
			}
			else native_fileName = null;

			ImnodesNative.LoadEditorStateFromIniFile(editor, native_fileName);
			// Freeing fileName native string
			if (byteCount_fileName > Utils.MaxStackallocSize)
				Utils.Free(native_fileName);
		}

		public static ref byte GetIoKeyCtrlPtr()
		{
			var nativeResult = ImnodesNative.GetIoKeyCtrlPtr();
			return ref *(byte*)&nativeResult;
		}

	}
}
