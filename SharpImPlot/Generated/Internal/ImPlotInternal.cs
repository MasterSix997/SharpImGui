using SharpImGui;
using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImPlot
{
	public static unsafe partial class ImPlotInternal
	{
		public static void AddTextCentered(ImDrawListPtr drawList, Vector2 topCenter, uint col, ReadOnlySpan<byte> textBegin, ReadOnlySpan<byte> textEnd)
		{
			fixed (byte* nativeTextBegin = textBegin)
			fixed (byte* nativeTextEnd = textEnd)
			{
				ImPlotNative.AddTextCentered(drawList, topCenter, col, nativeTextBegin, nativeTextEnd);
			}
		}

		public static void AddTextVertical(ImDrawListPtr drawList, Vector2 pos, uint col, ReadOnlySpan<byte> textBegin, ReadOnlySpan<byte> textEnd)
		{
			fixed (byte* nativeTextBegin = textBegin)
			fixed (byte* nativeTextEnd = textEnd)
			{
				ImPlotNative.AddTextVertical(drawList, pos, col, nativeTextBegin, nativeTextEnd);
			}
		}

		public static void AddTime(ImPlotTimePtr pOut, ImPlotTime t, ImPlotTimeUnit unit, int count)
		{
			ImPlotNative.AddTime(pOut, t, unit, count);
		}

		public static bool AllAxesInputLocked(ImPlotAxisPtr axes, int count)
		{
			var result = ImPlotNative.AllAxesInputLocked(axes, count);
			return result != 0;
		}

		public static bool AnyAxesHeld(ImPlotAxisPtr axes, int count)
		{
			var result = ImPlotNative.AnyAxesHeld(axes, count);
			return result != 0;
		}

		public static bool AnyAxesHovered(ImPlotAxisPtr axes, int count)
		{
			var result = ImPlotNative.AnyAxesHovered(axes, count);
			return result != 0;
		}

		public static bool AnyAxesInputLocked(ImPlotAxisPtr axes, int count)
		{
			var result = ImPlotNative.AnyAxesInputLocked(axes, count);
			return result != 0;
		}

		public static bool BeginItem(ReadOnlySpan<byte> labelId, ImPlotItemFlags flags, ImPlotCol recolorFrom)
		{
			fixed (byte* nativeLabelId = labelId)
			{
				var result = ImPlotNative.BeginItem(nativeLabelId, flags, recolorFrom);
				return result != 0;
			}
		}

		public static void BustItemCache()
		{
			ImPlotNative.BustItemCache();
		}

		public static void BustPlotCache()
		{
			ImPlotNative.BustPlotCache();
		}

		public static uint CalcHoverColor(uint col)
		{
			return ImPlotNative.CalcHoverColor(col);
		}

		public static void CalcLegendSize(out Vector2 pOut, ImPlotItemGroupPtr items, Vector2 pad, Vector2 spacing, bool vertical)
		{
			var native_vertical = vertical ? (byte)1 : (byte)0;
			fixed (Vector2* nativePOut = &pOut)
			{
				ImPlotNative.CalcLegendSize(nativePOut, items, pad, spacing, native_vertical);
			}
		}

		public static void CalcTextSizeVertical(out Vector2 pOut, ReadOnlySpan<byte> text)
		{
			fixed (Vector2* nativePOut = &pOut)
			fixed (byte* nativeText = text)
			{
				ImPlotNative.CalcTextSizeVertical(nativePOut, nativeText);
			}
		}

		public static void CeilTime(ImPlotTimePtr pOut, ImPlotTime t, ImPlotTimeUnit unit)
		{
			ImPlotNative.CeilTime(pOut, t, unit);
		}

		public static void ClampLabelPos(out Vector2 pOut, Vector2 pos, Vector2 size, Vector2 min, Vector2 max)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImPlotNative.ClampLabelPos(nativePOut, pos, size, min, max);
			}
		}

		public static bool ClampLegendRect(ImRectPtr legendRect, ImRect outerRect, Vector2 pad)
		{
			var result = ImPlotNative.ClampLegendRect(legendRect, outerRect, pad);
			return result != 0;
		}

		public static void CombineDateTime(ImPlotTimePtr pOut, ImPlotTime datePart, ImPlotTime timePart)
		{
			ImPlotNative.CombineDateTime(pOut, datePart, timePart);
		}

		public static void EndItem()
		{
			ImPlotNative.EndItem();
		}

		public static void FitPoint(ImPlotPoint p)
		{
			ImPlotNative.FitPoint(p);
		}

		public static void FitPointX(double x)
		{
			ImPlotNative.FitPointX(x);
		}

		public static void FitPointY(double y)
		{
			ImPlotNative.FitPointY(y);
		}

		public static bool FitThisFrame()
		{
			var result = ImPlotNative.FitThisFrame();
			return result != 0;
		}

		public static void FloorTime(ImPlotTimePtr pOut, ImPlotTime t, ImPlotTimeUnit unit)
		{
			ImPlotNative.FloorTime(pOut, t, unit);
		}

		public static int FormatDate(ImPlotTime t, byte[] buffer, int size, ImPlotDateFmt fmt, bool useIso_8601)
		{
			var native_useIso_8601 = useIso_8601 ? (byte)1 : (byte)0;
			fixed (byte* nativeBuffer = buffer)
			{
				return ImPlotNative.FormatDate(t, nativeBuffer, size, fmt, native_useIso_8601);
			}
		}

		public static int FormatDateTime(ImPlotTime t, byte[] buffer, int size, ImPlotDateTimeSpec fmt)
		{
			fixed (byte* nativeBuffer = buffer)
			{
				return ImPlotNative.FormatDateTime(t, nativeBuffer, size, fmt);
			}
		}

		public static int FormatTime(ImPlotTime t, byte[] buffer, int size, ImPlotTimeFmt fmt, bool use_24HrClk)
		{
			var native_use_24HrClk = use_24HrClk ? (byte)1 : (byte)0;
			fixed (byte* nativeBuffer = buffer)
			{
				return ImPlotNative.FormatTime(t, nativeBuffer, size, fmt, native_use_24HrClk);
			}
		}

		public static int FormatterDefault(double value, byte[] buff, int size, IntPtr data)
		{
			fixed (byte* nativeBuff = buff)
			{
				return ImPlotNative.FormatterDefault(value, nativeBuff, size, (void*)data);
			}
		}

		public static int FormatterLogit(double value, byte[] buff, int size, IntPtr noname1)
		{
			fixed (byte* nativeBuff = buff)
			{
				return ImPlotNative.FormatterLogit(value, nativeBuff, size, (void*)noname1);
			}
		}

		public static int FormatterTime(double noname1, byte[] buff, int size, IntPtr data)
		{
			fixed (byte* nativeBuff = buff)
			{
				return ImPlotNative.FormatterTime(noname1, nativeBuff, size, (void*)data);
			}
		}

		public static void GetAutoColor(out Vector4 pOut, ImPlotCol idx)
		{
			fixed (Vector4* nativePOut = &pOut)
			{
				ImPlotNative.GetAutoColor(nativePOut, idx);
			}
		}

		public static uint GetColormapColorU32(int idx, ImPlotColormap cmap)
		{
			return ImPlotNative.GetColormapColorU32(idx, cmap);
		}

		public static ImPlotItemPtr GetCurrentItem()
		{
			return ImPlotNative.GetCurrentItem();
		}

		public static ImPlotPlotPtr GetCurrentPlot()
		{
			return ImPlotNative.GetCurrentPlot();
		}

		public static int GetDaysInMonth(int year, int month)
		{
			return ImPlotNative.GetDaysInMonth(year, month);
		}

		public static TmPtr GetGmtTime(ImPlotTime t, TmPtr ptm)
		{
			return ImPlotNative.GetGmtTime(t, ptm);
		}

		public static ImPlotItemPtr GetItem(ReadOnlySpan<byte> labelId)
		{
			fixed (byte* nativeLabelId = labelId)
			{
				return ImPlotNative.GetItem(nativeLabelId);
			}
		}

		public static ImPlotNextItemDataPtr GetItemData()
		{
			return ImPlotNative.GetItemData();
		}

		public static TmPtr GetLocTime(ImPlotTime t, TmPtr ptm)
		{
			return ImPlotNative.GetLocTime(t, ptm);
		}

		public static void GetLocationPos(out Vector2 pOut, ImRect outerRect, Vector2 innerSize, ImPlotLocation location, Vector2 pad)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImPlotNative.GetLocationPos(nativePOut, outerRect, innerSize, location, pad);
			}
		}

		public static int GetMonth(ImPlotTime t)
		{
			return ImPlotNative.GetMonth(t);
		}

		public static ImPlotPlotPtr GetPlot(ReadOnlySpan<byte> title)
		{
			fixed (byte* nativeTitle = title)
			{
				return ImPlotNative.GetPlot(nativeTitle);
			}
		}

		public static uint GetStyleColorU32(ImPlotCol idx)
		{
			return ImPlotNative.GetStyleColorU32(idx);
		}

		public static void GetStyleColorVec4(out Vector4 pOut, ImPlotCol idx)
		{
			fixed (Vector4* nativePOut = &pOut)
			{
				ImPlotNative.GetStyleColorVec4(nativePOut, idx);
			}
		}

		public static TmPtr GetTime(ImPlotTime t, TmPtr ptm)
		{
			return ImPlotNative.GetTime(t, ptm);
		}

		public static int GetYear(ImPlotTime t)
		{
			return ImPlotNative.GetYear(t);
		}

		public static bool ImAlmostEqual(double v1, double v2, int ulp)
		{
			var result = ImPlotNative.ImAlmostEqual(v1, v2, ulp);
			return result != 0;
		}

		public static uint ImAlphaU32(uint col, float alpha)
		{
			return ImPlotNative.ImAlphaU32(col, alpha);
		}

		public static double ImConstrainInf(double val)
		{
			return ImPlotNative.ImConstrainInf(val);
		}

		public static double ImConstrainLog(double val)
		{
			return ImPlotNative.ImConstrainLog(val);
		}

		public static double ImConstrainNan(double val)
		{
			return ImPlotNative.ImConstrainNan(val);
		}

		public static double ImConstrainTime(double val)
		{
			return ImPlotNative.ImConstrainTime(val);
		}

		public static uint ImLerpU32(uint[] colors, int size, float t)
		{
			fixed (uint* nativeColors = colors)
			{
				return ImPlotNative.ImLerpU32(nativeColors, size, t);
			}
		}

		public static uint ImMixU32(uint a, uint b, uint s)
		{
			return ImPlotNative.ImMixU32(a, b, s);
		}

		public static bool ImNan(double val)
		{
			var result = ImPlotNative.ImNan(val);
			return result != 0;
		}

		public static bool ImNanOrInf(double val)
		{
			var result = ImPlotNative.ImNanOrInf(val);
			return result != 0;
		}

		public static int ImPosMod(int l, int r)
		{
			return ImPlotNative.ImPosMod(l, r);
		}

		public static void Initialize(ImPlotContextPtr ctx)
		{
			ImPlotNative.Initialize(ctx);
		}

		public static void Intersection(out Vector2 pOut, Vector2 a1, Vector2 a2, Vector2 b1, Vector2 b2)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImPlotNative.Intersection(nativePOut, a1, a2, b1, b2);
			}
		}

		public static bool IsLeapYear(int year)
		{
			var result = ImPlotNative.IsLeapYear(year);
			return result != 0;
		}

		public static void LabelAxisValue(ImPlotAxis axis, double value, byte[] buff, int size, bool round)
		{
			var native_round = round ? (byte)1 : (byte)0;
			fixed (byte* nativeBuff = buff)
			{
				ImPlotNative.LabelAxisValue(axis, value, nativeBuff, size, native_round);
			}
		}

		public static void LocatorDefault(ImPlotTickerPtr ticker, ImPlotRange range, float pixels, bool vertical, ImPlotFormatter formatter, IntPtr formatterData)
		{
			var native_vertical = vertical ? (byte)1 : (byte)0;
			ImPlotNative.LocatorDefault(ticker, range, pixels, native_vertical, formatter, (void*)formatterData);
		}

		public static void LocatorLog10(ImPlotTickerPtr ticker, ImPlotRange range, float pixels, bool vertical, ImPlotFormatter formatter, IntPtr formatterData)
		{
			var native_vertical = vertical ? (byte)1 : (byte)0;
			ImPlotNative.LocatorLog10(ticker, range, pixels, native_vertical, formatter, (void*)formatterData);
		}

		public static void LocatorSymLog(ImPlotTickerPtr ticker, ImPlotRange range, float pixels, bool vertical, ImPlotFormatter formatter, IntPtr formatterData)
		{
			var native_vertical = vertical ? (byte)1 : (byte)0;
			ImPlotNative.LocatorSymLog(ticker, range, pixels, native_vertical, formatter, (void*)formatterData);
		}

		public static void LocatorTime(ImPlotTickerPtr ticker, ImPlotRange range, float pixels, bool vertical, ImPlotFormatter formatter, IntPtr formatterData)
		{
			var native_vertical = vertical ? (byte)1 : (byte)0;
			ImPlotNative.LocatorTime(ticker, range, pixels, native_vertical, formatter, (void*)formatterData);
		}

		public static void MakeTime(ImPlotTimePtr pOut, int year, int month, int day, int hour, int min, int sec, int us)
		{
			ImPlotNative.MakeTime(pOut, year, month, day, hour, min, sec, us);
		}

		public static void MkGmtTime(ImPlotTimePtr pOut, TmPtr ptm)
		{
			ImPlotNative.MkGmtTime(pOut, ptm);
		}

		public static void MkLocTime(ImPlotTimePtr pOut, TmPtr ptm)
		{
			ImPlotNative.MkLocTime(pOut, ptm);
		}

		public static void MkTime(ImPlotTimePtr pOut, TmPtr ptm)
		{
			ImPlotNative.MkTime(pOut, ptm);
		}

		public static uint NextColormapColorU32()
		{
			return ImPlotNative.NextColormapColorU32();
		}

		public static double NiceNum(double x, bool round)
		{
			var native_round = round ? (byte)1 : (byte)0;
			return ImPlotNative.NiceNum(x, native_round);
		}

		public static void Now(ImPlotTimePtr pOut)
		{
			ImPlotNative.Now(pOut);
		}

		public static int OrderOfMagnitude(double val)
		{
			return ImPlotNative.OrderOfMagnitude(val);
		}

		public static int OrderToPrecision(int order)
		{
			return ImPlotNative.OrderToPrecision(order);
		}

		public static int Precision(double val)
		{
			return ImPlotNative.Precision(val);
		}

		public static bool RangesOverlap(ImPlotRange r1, ImPlotRange r2)
		{
			var result = ImPlotNative.RangesOverlap(r1, r2);
			return result != 0;
		}

		public static ImPlotItemPtr RegisterOrGetItem(ReadOnlySpan<byte> labelId, ImPlotItemFlags flags, ref bool justCreated)
		{
			var nativeJustCreatedVal = justCreated ? (byte)1 : (byte)0;
			var nativeJustCreated = &nativeJustCreatedVal;
			fixed (byte* nativeLabelId = labelId)
			{
				var result = ImPlotNative.RegisterOrGetItem(nativeLabelId, flags, nativeJustCreated);
				justCreated = nativeJustCreatedVal != 0;
				return result;
			}
		}

		public static void RenderColorBar(uint[] colors, int size, ImDrawListPtr drawList, ImRect bounds, bool vert, bool reversed, bool continuous)
		{
			var native_vert = vert ? (byte)1 : (byte)0;
			var native_reversed = reversed ? (byte)1 : (byte)0;
			var native_continuous = continuous ? (byte)1 : (byte)0;
			fixed (uint* nativeColors = colors)
			{
				ImPlotNative.RenderColorBar(nativeColors, size, drawList, bounds, native_vert, native_reversed, native_continuous);
			}
		}

		public static void ResetCtxForNextAlignedPlots(ImPlotContextPtr ctx)
		{
			ImPlotNative.ResetCtxForNextAlignedPlots(ctx);
		}

		public static void ResetCtxForNextPlot(ImPlotContextPtr ctx)
		{
			ImPlotNative.ResetCtxForNextPlot(ctx);
		}

		public static void ResetCtxForNextSubplot(ImPlotContextPtr ctx)
		{
			ImPlotNative.ResetCtxForNextSubplot(ctx);
		}

		public static void RoundTime(ImPlotTimePtr pOut, ImPlotTime t, ImPlotTimeUnit unit)
		{
			ImPlotNative.RoundTime(pOut, t, unit);
		}

		public static double RoundTo(double val, int prec)
		{
			return ImPlotNative.RoundTo(val, prec);
		}

		public static uint SampleColormapU32(float t, ImPlotColormap cmap)
		{
			return ImPlotNative.SampleColormapU32(t, cmap);
		}

		public static void SetupLock()
		{
			ImPlotNative.SetupLock();
		}

		public static void ShowAltLegend(ReadOnlySpan<byte> titleId, bool vertical, Vector2 size, bool interactable)
		{
			var native_vertical = vertical ? (byte)1 : (byte)0;
			var native_interactable = interactable ? (byte)1 : (byte)0;
			fixed (byte* nativeTitleId = titleId)
			{
				ImPlotNative.ShowAltLegend(nativeTitleId, native_vertical, size, native_interactable);
			}
		}

		public static void ShowAxisContextMenu(ImPlotAxisPtr axis, ImPlotAxisPtr equalAxis, bool timeAllowed)
		{
			var native_timeAllowed = timeAllowed ? (byte)1 : (byte)0;
			ImPlotNative.ShowAxisContextMenu(axis, equalAxis, native_timeAllowed);
		}

		public static bool ShowDatePicker(ReadOnlySpan<byte> id, ref int level, ImPlotTimePtr t, ImPlotTimePtr t1, ImPlotTimePtr t2)
		{
			fixed (byte* nativeId = id)
			fixed (int* nativeLevel = &level)
			{
				var result = ImPlotNative.ShowDatePicker(nativeId, nativeLevel, t, t1, t2);
				return result != 0;
			}
		}

		public static bool ShowLegendContextMenu(ImPlotLegendPtr legend, bool visible)
		{
			var native_visible = visible ? (byte)1 : (byte)0;
			var result = ImPlotNative.ShowLegendContextMenu(legend, native_visible);
			return result != 0;
		}

		public static bool ShowLegendEntries(ImPlotItemGroupPtr items, ImRect legendBb, bool interactable, Vector2 pad, Vector2 spacing, bool vertical, ImDrawListPtr drawList)
		{
			var native_interactable = interactable ? (byte)1 : (byte)0;
			var native_vertical = vertical ? (byte)1 : (byte)0;
			var result = ImPlotNative.ShowLegendEntries(items, legendBb, native_interactable, pad, spacing, native_vertical, drawList);
			return result != 0;
		}

		public static void ShowPlotContextMenu(ImPlotPlotPtr plot)
		{
			ImPlotNative.ShowPlotContextMenu(plot);
		}

		public static void ShowSubplotsContextMenu(ImPlotSubplotPtr subplot)
		{
			ImPlotNative.ShowSubplotsContextMenu(subplot);
		}

		public static bool ShowTimePicker(ReadOnlySpan<byte> id, ImPlotTimePtr t)
		{
			fixed (byte* nativeId = id)
			{
				var result = ImPlotNative.ShowTimePicker(nativeId, t);
				return result != 0;
			}
		}

		public static void SubplotNextCell()
		{
			ImPlotNative.SubplotNextCell();
		}

		public static void Today(ImPlotTimePtr pOut)
		{
			ImPlotNative.Today(pOut);
		}

		public static double TransformForwardLog10(double v, IntPtr noname1)
		{
			return ImPlotNative.TransformForwardLog10(v, (void*)noname1);
		}

		public static double TransformForwardLogit(double v, IntPtr noname1)
		{
			return ImPlotNative.TransformForwardLogit(v, (void*)noname1);
		}

		public static double TransformForwardSymLog(double v, IntPtr noname1)
		{
			return ImPlotNative.TransformForwardSymLog(v, (void*)noname1);
		}

		public static double TransformInverseLog10(double v, IntPtr noname1)
		{
			return ImPlotNative.TransformInverseLog10(v, (void*)noname1);
		}

		public static double TransformInverseLogit(double v, IntPtr noname1)
		{
			return ImPlotNative.TransformInverseLogit(v, (void*)noname1);
		}

		public static double TransformInverseSymLog(double v, IntPtr noname1)
		{
			return ImPlotNative.TransformInverseSymLog(v, (void*)noname1);
		}

	}
}
