using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	public static unsafe partial class ImGuiInternal
	{
		public static bool ArrowButtonEx(ReadOnlySpan<byte> strId, ImGuiDir dir, Vector2 sizeArg)
		{
			// defining omitted parameters
			ImGuiButtonFlags flags = ImGuiButtonFlags.None;
			fixed (byte* nativeStrId = strId)
			{
				var result = ImGuiNative.ArrowButtonEx(nativeStrId, dir, sizeArg, flags);
				return result != 0;
			}
		}

		/// <summary>
		/// setup number of columns. use an identifier to distinguish multiple column sets. close with EndColumns().<br/>
		/// </summary>
		public static void BeginColumns(ReadOnlySpan<byte> strId, int count)
		{
			// defining omitted parameters
			ImGuiOldColumnFlags flags = ImGuiOldColumnFlags.None;
			fixed (byte* nativeStrId = strId)
			{
				ImGuiNative.BeginColumns(nativeStrId, count, flags);
			}
		}

		public static bool BeginMenuEx(ReadOnlySpan<byte> label, ReadOnlySpan<byte> icon)
		{
			// defining omitted parameters
			byte enabled = 1;
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeIcon = icon)
			{
				var result = ImGuiNative.BeginMenuEx(nativeLabel, nativeIcon, enabled);
				return result != 0;
			}
		}

		public static bool BeginTableEx(ReadOnlySpan<byte> name, uint id, int columnsCount, ImGuiTableFlags flags, Vector2 outerSize)
		{
			// defining omitted parameters
			float innerWidth = 0.0f;
			fixed (byte* nativeName = name)
			{
				var result = ImGuiNative.BeginTableEx(nativeName, id, columnsCount, flags, outerSize, innerWidth);
				return result != 0;
			}
		}

		public static bool ButtonBehavior(ImRect bb, uint id, ref bool outHovered, ref bool outHeld)
		{
			// defining omitted parameters
			ImGuiButtonFlags flags = ImGuiButtonFlags.None;
			var nativeOutHoveredVal = outHovered ? (byte)1 : (byte)0;
			var nativeOutHovered = &nativeOutHoveredVal;
			var nativeOutHeldVal = outHeld ? (byte)1 : (byte)0;
			var nativeOutHeld = &nativeOutHeldVal;
			var result = ImGuiNative.ButtonBehavior(bb, id, nativeOutHovered, nativeOutHeld, flags);
			outHovered = nativeOutHoveredVal != 0;
			outHeld = nativeOutHeldVal != 0;
			return result != 0;
		}

		public static bool ButtonEx(ReadOnlySpan<byte> label, Vector2 sizeArg)
		{
			// defining omitted parameters
			ImGuiButtonFlags flags = ImGuiButtonFlags.None;
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.ButtonEx(nativeLabel, sizeArg, flags);
				return result != 0;
			}
		}

		public static bool DataTypeApplyFromText(ReadOnlySpan<byte> buf, ImGuiDataType dataType, IntPtr pData, ReadOnlySpan<byte> format)
		{
			// defining omitted parameters
			void* pDataWhenEmpty = null;
			fixed (byte* nativeBuf = buf)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.DataTypeApplyFromText(nativeBuf, dataType, (void*)pData, nativeFormat, pDataWhenEmpty);
				return result != 0;
			}
		}

		public static void DebugDrawCursorPos()
		{
			// defining omitted parameters
			uint col = 4278190335;
			ImGuiNative.DebugDrawCursorPos(col);
		}

		public static void DebugDrawItemRect()
		{
			// defining omitted parameters
			uint col = 4278190335;
			ImGuiNative.DebugDrawItemRect(col);
		}

		public static void DebugDrawLineExtents()
		{
			// defining omitted parameters
			uint col = 4278190335;
			ImGuiNative.DebugDrawLineExtents(col);
		}

		public static uint DockBuilderAddNode(uint nodeId)
		{
			// defining omitted parameters
			ImGuiDockNodeFlags flags = ImGuiDockNodeFlags.None;
			return ImGuiNative.DockBuilderAddNode(nodeId, flags);
		}

		public static void DockBuilderRemoveNodeDockedWindows(uint nodeId)
		{
			// defining omitted parameters
			byte clearSettingsRefs = 1;
			ImGuiNative.DockBuilderRemoveNodeDockedWindows(nodeId, clearSettingsRefs);
		}

		public static void DockContextProcessUndockWindow(ImGuiContextPtr ctx, ImGuiWindowPtr window)
		{
			// defining omitted parameters
			byte clearPersistentDockingRef = 1;
			ImGuiNative.DockContextProcessUndockWindow(ctx, window, clearPersistentDockingRef);
		}

		/// <summary>
		/// Find the optional ## from which we stop displaying text.<br/>
		/// </summary>
		public static ref byte FindRenderedTextEnd(ReadOnlySpan<byte> text)
		{
			// defining omitted parameters
			byte* textEnd = null;
			fixed (byte* nativeText = text)
			{
				var nativeResult = ImGuiNative.FindRenderedTextEnd(nativeText, textEnd);
				return ref *(byte*)&nativeResult;
			}
		}

		public static void FocusWindow(ImGuiWindowPtr window)
		{
			// defining omitted parameters
			ImGuiFocusRequestFlags flags = ImGuiFocusRequestFlags.None;
			ImGuiNative.FocusWindow(window, flags);
		}

		public static ImGuiTypingSelectRequestPtr GetTypingSelectRequest()
		{
			// defining omitted parameters
			ImGuiTypingSelectFlags flags = ImGuiTypingSelectFlags.None;
			return ImGuiNative.GetTypingSelectRequest(flags);
		}

		public static IntPtr ImFileLoadToMemory(ReadOnlySpan<byte> filename, ReadOnlySpan<byte> mode, out uint outFileSize)
		{
			// defining omitted parameters
			int paddingBytes = 0;
			fixed (byte* nativeFilename = filename)
			fixed (byte* nativeMode = mode)
			fixed (uint* nativeOutFileSize = &outFileSize)
			{
				return (IntPtr)ImGuiNative.ImFileLoadToMemory(nativeFilename, nativeMode, nativeOutFileSize, paddingBytes);
			}
		}

		public static uint ImHashData(IntPtr data, uint dataSize)
		{
			// defining omitted parameters
			uint seed = 0;
			return ImGuiNative.ImHashData((void*)data, dataSize, seed);
		}

		public static uint ImHashStr(ReadOnlySpan<byte> data, uint dataSize)
		{
			// defining omitted parameters
			uint seed = 0;
			fixed (byte* nativeData = data)
			{
				return ImGuiNative.ImHashStr(nativeData, dataSize, seed);
			}
		}

		/// <summary>
		/// return input UTF-8 bytes count<br/>
		/// </summary>
		public static int ImTextStrFromUtf8(out ushort outBuf, int outBufSize, ReadOnlySpan<byte> inText, ReadOnlySpan<byte> inTextEnd)
		{
			// defining omitted parameters
			byte** inRemaining = null;
			fixed (ushort* nativeOutBuf = &outBuf)
			fixed (byte* nativeInText = inText)
			fixed (byte* nativeInTextEnd = inTextEnd)
			{
				return ImGuiNative.ImTextStrFromUtf8(nativeOutBuf, outBufSize, nativeInText, nativeInTextEnd, inRemaining);
			}
		}

		public static bool ImageButtonEx(uint id, ulong userTextureId, Vector2 imageSize, Vector2 uv0, Vector2 uv1, Vector4 bgCol, Vector4 tintCol)
		{
			// defining omitted parameters
			ImGuiButtonFlags flags = ImGuiButtonFlags.None;
			var result = ImGuiNative.ImageButtonEx(id, userTextureId, imageSize, uv0, uv1, bgCol, tintCol, flags);
			return result != 0;
		}

		public static bool InputTextEx(ReadOnlySpan<byte> label, ReadOnlySpan<byte> hint, byte[] buf, int bufSize, Vector2 sizeArg, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback)
		{
			// defining omitted parameters
			void* userData = null;
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeHint = hint)
			fixed (byte* nativeBuf = buf)
			{
				var result = ImGuiNative.InputTextEx(nativeLabel, nativeHint, nativeBuf, bufSize, sizeArg, flags, callback, userData);
				return result != 0;
			}
		}

		public static bool IsMouseDragPastThreshold(ImGuiMouseButton button)
		{
			// defining omitted parameters
			float lockThreshold = -1.0f;
			var result = ImGuiNative.IsMouseDragPastThreshold(button, lockThreshold);
			return result != 0;
		}

		public static bool IsWindowContentHoverable(ImGuiWindowPtr window)
		{
			// defining omitted parameters
			ImGuiHoveredFlags flags = ImGuiHoveredFlags.None;
			var result = ImGuiNative.IsWindowContentHoverable(window, flags);
			return result != 0;
		}

		public static bool ItemAdd(ImRect bb, uint id, ImRectPtr navBb)
		{
			// defining omitted parameters
			ImGuiItemFlags extraFlags = ImGuiItemFlags.None;
			var result = ImGuiNative.ItemAdd(bb, id, navBb, extraFlags);
			return result != 0;
		}

		public static void LogRenderedText(ref Vector2 refPos, ReadOnlySpan<byte> text)
		{
			// defining omitted parameters
			byte* textEnd = null;
			fixed (Vector2* nativeRefPos = &refPos)
			fixed (byte* nativeText = text)
			{
				ImGuiNative.LogRenderedText(nativeRefPos, nativeText, textEnd);
			}
		}

		/// <summary>
		/// Start logging/capturing to internal buffer<br/>
		/// </summary>
		public static void LogToBuffer()
		{
			// defining omitted parameters
			int autoOpenDepth = -1;
			ImGuiNative.LogToBuffer(autoOpenDepth);
		}

		public static bool MenuItemEx(ReadOnlySpan<byte> label, ReadOnlySpan<byte> icon, ReadOnlySpan<byte> shortcut, bool selected)
		{
			// defining omitted parameters
			byte enabled = 1;
			var native_selected = selected ? (byte)1 : (byte)0;
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeIcon = icon)
			fixed (byte* nativeShortcut = shortcut)
			{
				var result = ImGuiNative.MenuItemEx(nativeLabel, nativeIcon, nativeShortcut, native_selected, enabled);
				return result != 0;
			}
		}

		public static void OpenPopupEx(uint id)
		{
			// defining omitted parameters
			ImGuiPopupFlags popupFlags = ImGuiPopupFlags.None;
			ImGuiNative.OpenPopupEx(id, popupFlags);
		}

		public static void RenderArrow(ImDrawListPtr drawList, Vector2 pos, uint col, ImGuiDir dir)
		{
			// defining omitted parameters
			float scale = 1.0f;
			ImGuiNative.RenderArrow(drawList, pos, col, dir, scale);
		}

		public static void RenderColorRectWithAlphaCheckerboard(ImDrawListPtr drawList, Vector2 pMin, Vector2 pMax, uint fillCol, float gridStep, Vector2 gridOff, float rounding)
		{
			// defining omitted parameters
			ImDrawFlags flags = ImDrawFlags.None;
			ImGuiNative.RenderColorRectWithAlphaCheckerboard(drawList, pMin, pMax, fillCol, gridStep, gridOff, rounding, flags);
		}

		public static void RenderFrame(Vector2 pMin, Vector2 pMax, uint fillCol, bool borders)
		{
			// defining omitted parameters
			float rounding = 0.0f;
			var native_borders = borders ? (byte)1 : (byte)0;
			ImGuiNative.RenderFrame(pMin, pMax, fillCol, native_borders, rounding);
		}

		public static void RenderFrameBorder(Vector2 pMin, Vector2 pMax)
		{
			// defining omitted parameters
			float rounding = 0.0f;
			ImGuiNative.RenderFrameBorder(pMin, pMax, rounding);
		}

		/// <summary>
		/// Navigation highlight<br/>
		/// </summary>
		public static void RenderNavCursor(ImRect bb, uint id)
		{
			// defining omitted parameters
			ImGuiNavRenderCursorFlags flags = ImGuiNavRenderCursorFlags.None;
			ImGuiNative.RenderNavCursor(bb, id, flags);
		}

		public static void RenderText(Vector2 pos, ReadOnlySpan<byte> text, ReadOnlySpan<byte> textEnd)
		{
			// defining omitted parameters
			byte hideTextAfterHash = 1;
			fixed (byte* nativeText = text)
			fixed (byte* nativeTextEnd = textEnd)
			{
				ImGuiNative.RenderText(pos, nativeText, nativeTextEnd, hideTextAfterHash);
			}
		}

		public static void RenderTextClipped(Vector2 posMin, Vector2 posMax, ReadOnlySpan<byte> text, ReadOnlySpan<byte> textEnd, ref Vector2 textSizeIfKnown, Vector2 align)
		{
			// defining omitted parameters
			ImRect* clipRect = null;
			fixed (byte* nativeText = text)
			fixed (byte* nativeTextEnd = textEnd)
			fixed (Vector2* nativeTextSizeIfKnown = &textSizeIfKnown)
			{
				ImGuiNative.RenderTextClipped(posMin, posMax, nativeText, nativeTextEnd, nativeTextSizeIfKnown, align, clipRect);
			}
		}

		public static void RenderTextClippedEx(ImDrawListPtr drawList, Vector2 posMin, Vector2 posMax, ReadOnlySpan<byte> text, ReadOnlySpan<byte> textEnd, ref Vector2 textSizeIfKnown, Vector2 align)
		{
			// defining omitted parameters
			ImRect* clipRect = null;
			fixed (byte* nativeText = text)
			fixed (byte* nativeTextEnd = textEnd)
			fixed (Vector2* nativeTextSizeIfKnown = &textSizeIfKnown)
			{
				ImGuiNative.RenderTextClippedEx(drawList, posMin, posMax, nativeText, nativeTextEnd, nativeTextSizeIfKnown, align, clipRect);
			}
		}

		public static void ScrollToItem()
		{
			// defining omitted parameters
			ImGuiScrollFlags flags = ImGuiScrollFlags.None;
			ImGuiNative.ScrollToItem(flags);
		}

		public static void ScrollToRect(ImGuiWindowPtr window, ImRect rect)
		{
			// defining omitted parameters
			ImGuiScrollFlags flags = ImGuiScrollFlags.None;
			ImGuiNative.ScrollToRect(window, rect, flags);
		}

		public static void ScrollToRectEx(out Vector2 pOut, ImGuiWindowPtr window, ImRect rect)
		{
			// defining omitted parameters
			ImGuiScrollFlags flags = ImGuiScrollFlags.None;
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.ScrollToRectEx(nativePOut, window, rect, flags);
			}
		}

		public static bool ScrollbarEx(ImRect bb, uint id, ImGuiAxis axis, ref long pScrollV, long availV, long contentsV)
		{
			// defining omitted parameters
			ImDrawFlags drawRoundingFlags = ImDrawFlags.None;
			fixed (long* nativePScrollV = &pScrollV)
			{
				var result = ImGuiNative.ScrollbarEx(bb, id, axis, nativePScrollV, availV, contentsV, drawRoundingFlags);
				return result != 0;
			}
		}

		public static void SeparatorEx(ImGuiSeparatorFlags flags)
		{
			// defining omitted parameters
			float thickness = 1.0f;
			ImGuiNative.SeparatorEx(flags, thickness);
		}

		public static void SetKeyOwner(ImGuiKey key, uint ownerId)
		{
			// defining omitted parameters
			ImGuiInputFlags flags = ImGuiInputFlags.None;
			ImGuiNative.SetKeyOwner(key, ownerId, flags);
		}

		public static void SetKeyOwnersForKeyChord(int key, uint ownerId)
		{
			// defining omitted parameters
			ImGuiInputFlags flags = ImGuiInputFlags.None;
			ImGuiNative.SetKeyOwnersForKeyChord(key, ownerId, flags);
		}

		public static bool SplitterBehavior(ImRect bb, uint id, ImGuiAxis axis, ref float size1, ref float size2, float minSize1, float minSize2, float hoverExtend, float hoverVisibilityDelay)
		{
			// defining omitted parameters
			uint bgCol = 0;
			fixed (float* nativeSize1 = &size1)
			fixed (float* nativeSize2 = &size2)
			{
				var result = ImGuiNative.SplitterBehavior(bb, id, axis, nativeSize1, nativeSize2, minSize1, minSize2, hoverExtend, hoverVisibilityDelay, bgCol);
				return result != 0;
			}
		}

		public static uint TableGetColumnResizeID(ImGuiTablePtr table, int columnN)
		{
			// defining omitted parameters
			int instanceNo = 0;
			return ImGuiNative.TableGetColumnResizeID(table, columnN, instanceNo);
		}

		public static void TableOpenContextMenu()
		{
			// defining omitted parameters
			int columnN = -1;
			ImGuiNative.TableOpenContextMenu(columnN);
		}

		public static bool TempInputScalar(ImRect bb, uint id, ReadOnlySpan<byte> label, ImGuiDataType dataType, IntPtr pData, ReadOnlySpan<byte> format, IntPtr pClampMin)
		{
			// defining omitted parameters
			void* pClampMax = null;
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.TempInputScalar(bb, id, nativeLabel, dataType, (void*)pData, nativeFormat, (void*)pClampMin, pClampMax);
				return result != 0;
			}
		}

		public static void TextEx(ReadOnlySpan<byte> text, ReadOnlySpan<byte> textEnd)
		{
			// defining omitted parameters
			ImGuiTextFlags flags = ImGuiTextFlags.None;
			fixed (byte* nativeText = text)
			fixed (byte* nativeTextEnd = textEnd)
			{
				ImGuiNative.TextEx(nativeText, nativeTextEnd, flags);
			}
		}

		public static bool TreeNodeBehavior(uint id, ImGuiTreeNodeFlags flags, ReadOnlySpan<byte> label)
		{
			// defining omitted parameters
			byte* labelEnd = null;
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.TreeNodeBehavior(id, flags, nativeLabel, labelEnd);
				return result != 0;
			}
		}

	}
}
