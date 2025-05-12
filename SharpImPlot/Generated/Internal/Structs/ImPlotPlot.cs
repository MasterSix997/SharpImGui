using SharpImGui;
using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImPlot
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlotPlot
	{
		public uint ID;
		public ImPlotFlags Flags;
		public ImPlotFlags PreviousFlags;
		public ImPlotLocation MouseTextLocation;
		public ImPlotMouseTextFlags MouseTextFlags;
		public ImPlotAxis Axes_0;
		public ImPlotAxis Axes_1;
		public ImPlotAxis Axes_2;
		public ImPlotAxis Axes_3;
		public ImPlotAxis Axes_4;
		public ImPlotAxis Axes_5;
		public ImGuiTextBuffer TextBuffer;
		public ImPlotItemGroup Items;
		public ImAxis CurrentX;
		public ImAxis CurrentY;
		public ImRect FrameRect;
		public ImRect CanvasRect;
		public ImRect PlotRect;
		public ImRect AxesRect;
		public ImRect SelectRect;
		public Vector2 SelectStart;
		public int TitleOffset;
		public byte JustCreated;
		public byte Initialized;
		public byte SetupLocked;
		public byte FitThisFrame;
		public byte Hovered;
		public byte Held;
		public byte Selecting;
		public byte Selected;
		public byte ContextLocked;
	}

	public unsafe partial struct ImPlotPlotPtr
	{
		public ImPlotPlot* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlotPlot this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);
		public ref ImPlotFlags Flags => ref Unsafe.AsRef<ImPlotFlags>(&NativePtr->Flags);
		public ref ImPlotFlags PreviousFlags => ref Unsafe.AsRef<ImPlotFlags>(&NativePtr->PreviousFlags);
		public ref ImPlotLocation MouseTextLocation => ref Unsafe.AsRef<ImPlotLocation>(&NativePtr->MouseTextLocation);
		public ref ImPlotMouseTextFlags MouseTextFlags => ref Unsafe.AsRef<ImPlotMouseTextFlags>(&NativePtr->MouseTextFlags);
		public Span<ImPlotAxis> Axes => new Span<ImPlotAxis>(&NativePtr->Axes_0, 6);
		public ref ImGuiTextBuffer TextBuffer => ref Unsafe.AsRef<ImGuiTextBuffer>(&NativePtr->TextBuffer);
		public ref ImPlotItemGroup Items => ref Unsafe.AsRef<ImPlotItemGroup>(&NativePtr->Items);
		public ref ImAxis CurrentX => ref Unsafe.AsRef<ImAxis>(&NativePtr->CurrentX);
		public ref ImAxis CurrentY => ref Unsafe.AsRef<ImAxis>(&NativePtr->CurrentY);
		public ref ImRect FrameRect => ref Unsafe.AsRef<ImRect>(&NativePtr->FrameRect);
		public ref ImRect CanvasRect => ref Unsafe.AsRef<ImRect>(&NativePtr->CanvasRect);
		public ref ImRect PlotRect => ref Unsafe.AsRef<ImRect>(&NativePtr->PlotRect);
		public ref ImRect AxesRect => ref Unsafe.AsRef<ImRect>(&NativePtr->AxesRect);
		public ref ImRect SelectRect => ref Unsafe.AsRef<ImRect>(&NativePtr->SelectRect);
		public ref Vector2 SelectStart => ref Unsafe.AsRef<Vector2>(&NativePtr->SelectStart);
		public ref int TitleOffset => ref Unsafe.AsRef<int>(&NativePtr->TitleOffset);
		public ref bool JustCreated => ref Unsafe.AsRef<bool>(&NativePtr->JustCreated);
		public ref bool Initialized => ref Unsafe.AsRef<bool>(&NativePtr->Initialized);
		public ref bool SetupLocked => ref Unsafe.AsRef<bool>(&NativePtr->SetupLocked);
		public ref bool FitThisFrame => ref Unsafe.AsRef<bool>(&NativePtr->FitThisFrame);
		public ref bool Hovered => ref Unsafe.AsRef<bool>(&NativePtr->Hovered);
		public ref bool Held => ref Unsafe.AsRef<bool>(&NativePtr->Held);
		public ref bool Selecting => ref Unsafe.AsRef<bool>(&NativePtr->Selecting);
		public ref bool Selected => ref Unsafe.AsRef<bool>(&NativePtr->Selected);
		public ref bool ContextLocked => ref Unsafe.AsRef<bool>(&NativePtr->ContextLocked);
		public ImPlotPlotPtr(ImPlotPlot* nativePtr) => NativePtr = nativePtr;
		public ImPlotPlotPtr(IntPtr nativePtr) => NativePtr = (ImPlotPlot*)nativePtr;
		public static implicit operator ImPlotPlotPtr(ImPlotPlot* ptr) => new ImPlotPlotPtr(ptr);
		public static implicit operator ImPlotPlotPtr(IntPtr ptr) => new ImPlotPlotPtr(ptr);
		public static implicit operator ImPlotPlot*(ImPlotPlotPtr nativePtr) => nativePtr.NativePtr;
		public ref byte PlotGetAxisLabel(ImPlotAxis axis)
		{
			var nativeResult = ImPlotNative.PlotGetAxisLabel(NativePtr, axis);
			return ref *(byte*)&nativeResult;
		}

		public void PlotSetAxisLabel(ImPlotAxisPtr axis, ReadOnlySpan<byte> label)
		{
			fixed (byte* nativeLabel = label)
			{
				ImPlotNative.PlotSetAxisLabel(NativePtr, axis, nativeLabel);
			}
		}

		public void PlotSetAxisLabel(ImPlotAxisPtr axis, ReadOnlySpan<char> label)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			ImPlotNative.PlotSetAxisLabel(NativePtr, axis, nativeLabel);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
		}

		public int PlotEnabledAxesY()
		{
			return ImPlotNative.PlotEnabledAxesY(NativePtr);
		}

		public int PlotEnabledAxesX()
		{
			return ImPlotNative.PlotEnabledAxesX(NativePtr);
		}

		public ImPlotAxisPtr PlotYAxisConst(int i)
		{
			return ImPlotNative.PlotYAxisConst(NativePtr, i);
		}

		public ImPlotAxisPtr PlotYAxisNil(int i)
		{
			return ImPlotNative.PlotYAxisNil(NativePtr, i);
		}

		public ImPlotAxisPtr PlotXAxisConst(int i)
		{
			return ImPlotNative.PlotXAxisConst(NativePtr, i);
		}

		public ImPlotAxisPtr PlotXAxisNil(int i)
		{
			return ImPlotNative.PlotXAxisNil(NativePtr, i);
		}

		public ref byte PlotGetTitle()
		{
			var nativeResult = ImPlotNative.PlotGetTitle(NativePtr);
			return ref *(byte*)&nativeResult;
		}

		public bool PlotHasTitle()
		{
			var result = ImPlotNative.PlotHasTitle(NativePtr);
			return result != 0;
		}

		public void PlotSetTitle(ReadOnlySpan<byte> title)
		{
			fixed (byte* nativeTitle = title)
			{
				ImPlotNative.PlotSetTitle(NativePtr, nativeTitle);
			}
		}

		public void PlotSetTitle(ReadOnlySpan<char> title)
		{
			// Marshaling title to native string
			byte* nativeTitle;
			var byteCountTitle = 0;
			if (title != null && !title.IsEmpty)
			{
				byteCountTitle = Encoding.UTF8.GetByteCount(title);
				if(byteCountTitle > Utils.MaxStackallocSize)
				{
					nativeTitle = Utils.Alloc<byte>(byteCountTitle + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTitle + 1];
					nativeTitle = stackallocBytes;
				}
				var offsetTitle = Utils.EncodeStringUTF8(title, nativeTitle, byteCountTitle);
				nativeTitle[offsetTitle] = 0;
			}
			else nativeTitle = null;

			ImPlotNative.PlotSetTitle(NativePtr, nativeTitle);
			// Freeing title native string
			if (byteCountTitle > Utils.MaxStackallocSize)
				Utils.Free(nativeTitle);
		}

		public void PlotClearTextBuffer()
		{
			ImPlotNative.PlotClearTextBuffer(NativePtr);
		}

		public bool PlotIsInputLocked()
		{
			var result = ImPlotNative.PlotIsInputLocked(NativePtr);
			return result != 0;
		}

		public void PlotDestroy()
		{
			ImPlotNative.PlotDestroy(NativePtr);
		}

		public ImPlotPlotPtr PlotPlot()
		{
			return ImPlotNative.PlotPlot();
		}

	}
}
