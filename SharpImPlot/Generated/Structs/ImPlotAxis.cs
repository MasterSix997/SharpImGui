using SharpImGui;
using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImPlot
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlotAxis
	{
		public uint ID;
		public ImPlotAxisFlags Flags;
		public ImPlotAxisFlags PreviousFlags;
		public ImPlotRange Range;
		public ImPlotCond RangeCond;
		public ImPlotScale Scale;
		public ImPlotRange FitExtents;
		public unsafe ImPlotAxis* OrthoAxis;
		public ImPlotRange ConstraintRange;
		public ImPlotRange ConstraintZoom;
		public ImPlotTicker Ticker;
		public unsafe void* Formatter;
		public unsafe void* FormatterData;
		public byte FormatSpec_0;
		public byte FormatSpec_1;
		public byte FormatSpec_2;
		public byte FormatSpec_3;
		public byte FormatSpec_4;
		public byte FormatSpec_5;
		public byte FormatSpec_6;
		public byte FormatSpec_7;
		public byte FormatSpec_8;
		public byte FormatSpec_9;
		public byte FormatSpec_10;
		public byte FormatSpec_11;
		public byte FormatSpec_12;
		public byte FormatSpec_13;
		public byte FormatSpec_14;
		public byte FormatSpec_15;
		public unsafe void* Locator;
		public unsafe double* LinkedMin;
		public unsafe double* LinkedMax;
		public int PickerLevel;
		public ImPlotTime PickerTimeMin;
		public ImPlotTime PickerTimeMax;
		public unsafe void* TransformForward;
		public unsafe void* TransformInverse;
		public unsafe void* TransformData;
		public float PixelMin;
		public float PixelMax;
		public double ScaleMin;
		public double ScaleMax;
		public double ScaleToPixel;
		public float Datum1;
		public float Datum2;
		public ImRect HoverRect;
		public int LabelOffset;
		public uint ColorMaj;
		public uint ColorMin;
		public uint ColorTick;
		public uint ColorTxt;
		public uint ColorBg;
		public uint ColorHov;
		public uint ColorAct;
		public uint ColorHiLi;
		public byte Enabled;
		public byte Vertical;
		public byte FitThisFrame;
		public byte HasRange;
		public byte HasFormatSpec;
		public byte ShowDefaultTicks;
		public byte Hovered;
		public byte Held;
	}

	public unsafe partial struct ImPlotAxisPtr
	{
		public ImPlotAxis* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlotAxis this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);
		public ref ImPlotAxisFlags Flags => ref Unsafe.AsRef<ImPlotAxisFlags>(&NativePtr->Flags);
		public ref ImPlotAxisFlags PreviousFlags => ref Unsafe.AsRef<ImPlotAxisFlags>(&NativePtr->PreviousFlags);
		public ref ImPlotRange Range => ref Unsafe.AsRef<ImPlotRange>(&NativePtr->Range);
		public ref ImPlotCond RangeCond => ref Unsafe.AsRef<ImPlotCond>(&NativePtr->RangeCond);
		public ref ImPlotScale Scale => ref Unsafe.AsRef<ImPlotScale>(&NativePtr->Scale);
		public ref ImPlotRange FitExtents => ref Unsafe.AsRef<ImPlotRange>(&NativePtr->FitExtents);
		public ref ImPlotAxisPtr OrthoAxis => ref Unsafe.AsRef<ImPlotAxisPtr>(&NativePtr->OrthoAxis);
		public ref ImPlotRange ConstraintRange => ref Unsafe.AsRef<ImPlotRange>(&NativePtr->ConstraintRange);
		public ref ImPlotRange ConstraintZoom => ref Unsafe.AsRef<ImPlotRange>(&NativePtr->ConstraintZoom);
		public ref ImPlotTicker Ticker => ref Unsafe.AsRef<ImPlotTicker>(&NativePtr->Ticker);
		public IntPtr Formatter { get => (IntPtr)NativePtr->Formatter; set => NativePtr->Formatter = (void*)value; }
		public IntPtr FormatterData { get => (IntPtr)NativePtr->FormatterData; set => NativePtr->FormatterData = (void*)value; }
		public Span<byte> FormatSpec => new Span<byte>(&NativePtr->FormatSpec_0, 16);
		public IntPtr Locator { get => (IntPtr)NativePtr->Locator; set => NativePtr->Locator = (void*)value; }
		public IntPtr LinkedMin { get => (IntPtr)NativePtr->LinkedMin; set => NativePtr->LinkedMin = (double*)value; }
		public IntPtr LinkedMax { get => (IntPtr)NativePtr->LinkedMax; set => NativePtr->LinkedMax = (double*)value; }
		public ref int PickerLevel => ref Unsafe.AsRef<int>(&NativePtr->PickerLevel);
		public ref ImPlotTime PickerTimeMin => ref Unsafe.AsRef<ImPlotTime>(&NativePtr->PickerTimeMin);
		public ref ImPlotTime PickerTimeMax => ref Unsafe.AsRef<ImPlotTime>(&NativePtr->PickerTimeMax);
		public IntPtr TransformForward { get => (IntPtr)NativePtr->TransformForward; set => NativePtr->TransformForward = (void*)value; }
		public IntPtr TransformInverse { get => (IntPtr)NativePtr->TransformInverse; set => NativePtr->TransformInverse = (void*)value; }
		public IntPtr TransformData { get => (IntPtr)NativePtr->TransformData; set => NativePtr->TransformData = (void*)value; }
		public ref float PixelMin => ref Unsafe.AsRef<float>(&NativePtr->PixelMin);
		public ref float PixelMax => ref Unsafe.AsRef<float>(&NativePtr->PixelMax);
		public ref double ScaleMin => ref Unsafe.AsRef<double>(&NativePtr->ScaleMin);
		public ref double ScaleMax => ref Unsafe.AsRef<double>(&NativePtr->ScaleMax);
		public ref double ScaleToPixel => ref Unsafe.AsRef<double>(&NativePtr->ScaleToPixel);
		public ref float Datum1 => ref Unsafe.AsRef<float>(&NativePtr->Datum1);
		public ref float Datum2 => ref Unsafe.AsRef<float>(&NativePtr->Datum2);
		public ref ImRect HoverRect => ref Unsafe.AsRef<ImRect>(&NativePtr->HoverRect);
		public ref int LabelOffset => ref Unsafe.AsRef<int>(&NativePtr->LabelOffset);
		public ref uint ColorMaj => ref Unsafe.AsRef<uint>(&NativePtr->ColorMaj);
		public ref uint ColorMin => ref Unsafe.AsRef<uint>(&NativePtr->ColorMin);
		public ref uint ColorTick => ref Unsafe.AsRef<uint>(&NativePtr->ColorTick);
		public ref uint ColorTxt => ref Unsafe.AsRef<uint>(&NativePtr->ColorTxt);
		public ref uint ColorBg => ref Unsafe.AsRef<uint>(&NativePtr->ColorBg);
		public ref uint ColorHov => ref Unsafe.AsRef<uint>(&NativePtr->ColorHov);
		public ref uint ColorAct => ref Unsafe.AsRef<uint>(&NativePtr->ColorAct);
		public ref uint ColorHiLi => ref Unsafe.AsRef<uint>(&NativePtr->ColorHiLi);
		public ref bool Enabled => ref Unsafe.AsRef<bool>(&NativePtr->Enabled);
		public ref bool Vertical => ref Unsafe.AsRef<bool>(&NativePtr->Vertical);
		public ref bool FitThisFrame => ref Unsafe.AsRef<bool>(&NativePtr->FitThisFrame);
		public ref bool HasRange => ref Unsafe.AsRef<bool>(&NativePtr->HasRange);
		public ref bool HasFormatSpec => ref Unsafe.AsRef<bool>(&NativePtr->HasFormatSpec);
		public ref bool ShowDefaultTicks => ref Unsafe.AsRef<bool>(&NativePtr->ShowDefaultTicks);
		public ref bool Hovered => ref Unsafe.AsRef<bool>(&NativePtr->Hovered);
		public ref bool Held => ref Unsafe.AsRef<bool>(&NativePtr->Held);
		public ImPlotAxisPtr(ImPlotAxis* nativePtr) => NativePtr = nativePtr;
		public ImPlotAxisPtr(IntPtr nativePtr) => NativePtr = (ImPlotAxis*)nativePtr;
		public static implicit operator ImPlotAxisPtr(ImPlotAxis* ptr) => new ImPlotAxisPtr(ptr);
		public static implicit operator ImPlotAxisPtr(IntPtr ptr) => new ImPlotAxisPtr(ptr);
		public static implicit operator ImPlotAxis*(ImPlotAxisPtr nativePtr) => nativePtr.NativePtr;
		public void AxisPullLinks()
		{
			ImPlotNative.AxisPullLinks(NativePtr);
		}

		public void AxisPushLinks()
		{
			ImPlotNative.AxisPushLinks(NativePtr);
		}

		public byte AxisIsPanLocked(bool increasing)
		{
			var native_increasing = increasing ? (byte)1 : (byte)0;
			return ImPlotNative.AxisIsPanLocked(NativePtr, native_increasing);
		}

		public byte AxisHasMenus()
		{
			return ImPlotNative.AxisHasMenus(NativePtr);
		}

		public byte AxisIsInputLocked()
		{
			return ImPlotNative.AxisIsInputLocked(NativePtr);
		}

		public byte AxisIsInputLockedMax()
		{
			return ImPlotNative.AxisIsInputLockedMax(NativePtr);
		}

		public byte AxisIsInputLockedMin()
		{
			return ImPlotNative.AxisIsInputLockedMin(NativePtr);
		}

		public byte AxisIsLocked()
		{
			return ImPlotNative.AxisIsLocked(NativePtr);
		}

		public byte AxisIsLockedMax()
		{
			return ImPlotNative.AxisIsLockedMax(NativePtr);
		}

		public byte AxisIsLockedMin()
		{
			return ImPlotNative.AxisIsLockedMin(NativePtr);
		}

		public byte AxisIsRangeLocked()
		{
			return ImPlotNative.AxisIsRangeLocked(NativePtr);
		}

		public byte AxisCanInitFit()
		{
			return ImPlotNative.AxisCanInitFit(NativePtr);
		}

		public byte AxisIsAutoFitting()
		{
			return ImPlotNative.AxisIsAutoFitting(NativePtr);
		}

		public byte AxisIsForeground()
		{
			return ImPlotNative.AxisIsForeground(NativePtr);
		}

		public byte AxisIsInverted()
		{
			return ImPlotNative.AxisIsInverted(NativePtr);
		}

		public byte AxisIsOpposite()
		{
			return ImPlotNative.AxisIsOpposite(NativePtr);
		}

		public byte AxisWillRender()
		{
			return ImPlotNative.AxisWillRender(NativePtr);
		}

		public byte AxisHasTickMarks()
		{
			return ImPlotNative.AxisHasTickMarks(NativePtr);
		}

		public byte AxisHasTickLabels()
		{
			return ImPlotNative.AxisHasTickLabels(NativePtr);
		}

		public byte AxisHasGridLines()
		{
			return ImPlotNative.AxisHasGridLines(NativePtr);
		}

		public byte AxisHasLabel()
		{
			return ImPlotNative.AxisHasLabel(NativePtr);
		}

		public void AxisApplyFit(float padding)
		{
			ImPlotNative.AxisApplyFit(NativePtr, padding);
		}

		public void AxisExtendFitWith(ImPlotAxisPtr alt, double v, double vAlt)
		{
			ImPlotNative.AxisExtendFitWith(NativePtr, alt, v, vAlt);
		}

		public void AxisExtendFit(double v)
		{
			ImPlotNative.AxisExtendFit(NativePtr, v);
		}

		public double AxisPixelsToPlot(float pix)
		{
			return ImPlotNative.AxisPixelsToPlot(NativePtr, pix);
		}

		public float AxisPlotToPixels(double plt)
		{
			return ImPlotNative.AxisPlotToPixels(NativePtr, plt);
		}

		public void AxisUpdateTransformCache()
		{
			ImPlotNative.AxisUpdateTransformCache(NativePtr);
		}

		public void AxisConstrain()
		{
			ImPlotNative.AxisConstrain(NativePtr);
		}

		public double AxisGetAspect()
		{
			return ImPlotNative.AxisGetAspect(NativePtr);
		}

		public float AxisPixelSize()
		{
			return ImPlotNative.AxisPixelSize(NativePtr);
		}

		public void AxisSetAspect(double unitPerPix)
		{
			ImPlotNative.AxisSetAspect(NativePtr, unitPerPix);
		}

		public void AxisSetRangePlotRange(ImPlotRange range)
		{
			ImPlotNative.AxisSetRangePlotRange(NativePtr, range);
		}

		public void AxisSetRangeDouble(double v1, double v2)
		{
			ImPlotNative.AxisSetRangeDouble(NativePtr, v1, v2);
		}

		public byte AxisSetMax(double max, bool force)
		{
			var native_force = force ? (byte)1 : (byte)0;
			return ImPlotNative.AxisSetMax(NativePtr, max, native_force);
		}

		public byte AxisSetMin(double min, bool force)
		{
			var native_force = force ? (byte)1 : (byte)0;
			return ImPlotNative.AxisSetMin(NativePtr, min, native_force);
		}

		public void AxisReset()
		{
			ImPlotNative.AxisReset(NativePtr);
		}

		public void AxisDestroy()
		{
			ImPlotNative.AxisDestroy(NativePtr);
		}

		public ImPlotAxisPtr AxisAxis()
		{
			return ImPlotNative.AxisAxis();
		}

	}
}
