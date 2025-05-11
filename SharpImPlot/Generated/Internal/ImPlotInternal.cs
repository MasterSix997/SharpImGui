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
		public static void AddTextCentered(ImDrawListPtr drawList, Vector2 topCenter, uint col, ReadOnlySpan<byte> textBegin)
		{
			// defining omitted parameters
			byte* textEnd = null;
			fixed (byte* nativeTextBegin = textBegin)
			{
				ImPlotNative.AddTextCentered(drawList, topCenter, col, nativeTextBegin, textEnd);
			}
		}

		public static void AddTextVertical(ImDrawListPtr drawList, Vector2 pos, uint col, ReadOnlySpan<byte> textBegin)
		{
			// defining omitted parameters
			byte* textEnd = null;
			fixed (byte* nativeTextBegin = textBegin)
			{
				ImPlotNative.AddTextVertical(drawList, pos, col, nativeTextBegin, textEnd);
			}
		}

		public static bool BeginItem(ReadOnlySpan<byte> labelId, ImPlotItemFlags flags)
		{
			// defining omitted parameters
			ImPlotCol recolorFrom = (ImPlotCol)0;
			fixed (byte* nativeLabelId = labelId)
			{
				var result = ImPlotNative.BeginItem(nativeLabelId, flags, recolorFrom);
				return result != 0;
			}
		}

		public static void GetLocationPos(out Vector2 pOut, ImRect outerRect, Vector2 innerSize, ImPlotLocation location)
		{
			// defining omitted parameters
			Vector2 pad = new Vector2(0,0);
			fixed (Vector2* nativePOut = &pOut)
			{
				ImPlotNative.GetLocationPos(nativePOut, outerRect, innerSize, location, pad);
			}
		}

		public static bool ImAlmostEqual(double v1, double v2)
		{
			// defining omitted parameters
			int ulp = 2;
			var result = ImPlotNative.ImAlmostEqual(v1, v2, ulp);
			return result != 0;
		}

		public static void LabelAxisValue(ImPlotAxis axis, double value, byte[] buff, int size)
		{
			// defining omitted parameters
			byte round = 0;
			fixed (byte* nativeBuff = buff)
			{
				ImPlotNative.LabelAxisValue(axis, value, nativeBuff, size, round);
			}
		}

		public static void MakeTime(ImPlotTimePtr pOut, int year, int month, int day, int hour, int min, int sec)
		{
			// defining omitted parameters
			int us = 0;
			ImPlotNative.MakeTime(pOut, year, month, day, hour, min, sec, us);
		}

		public static ImPlotItemPtr RegisterOrGetItem(ReadOnlySpan<byte> labelId, ImPlotItemFlags flags)
		{
			// defining omitted parameters
			byte* justCreated = null;
			fixed (byte* nativeLabelId = labelId)
			{
				return ImPlotNative.RegisterOrGetItem(nativeLabelId, flags, justCreated);
			}
		}

		public static void ShowAltLegend(ReadOnlySpan<byte> titleId, bool vertical, Vector2 size)
		{
			// defining omitted parameters
			byte interactable = 1;
			var native_vertical = vertical ? (byte)1 : (byte)0;
			fixed (byte* nativeTitleId = titleId)
			{
				ImPlotNative.ShowAltLegend(nativeTitleId, native_vertical, size, interactable);
			}
		}

		public static void ShowAxisContextMenu(ImPlotAxisPtr axis, ImPlotAxisPtr equalAxis)
		{
			// defining omitted parameters
			byte timeAllowed = 0;
			ImPlotNative.ShowAxisContextMenu(axis, equalAxis, timeAllowed);
		}

		public static bool ShowDatePicker(ReadOnlySpan<byte> id, ref int level, ImPlotTimePtr t, ImPlotTimePtr t1)
		{
			// defining omitted parameters
			ImPlotTime* t2 = null;
			fixed (byte* nativeId = id)
			fixed (int* nativeLevel = &level)
			{
				var result = ImPlotNative.ShowDatePicker(nativeId, nativeLevel, t, t1, t2);
				return result != 0;
			}
		}

	}
}
