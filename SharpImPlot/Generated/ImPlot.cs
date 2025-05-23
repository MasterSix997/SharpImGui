using SharpImGui;
using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImPlot
{
	public static unsafe partial class ImPlot
	{
		public static ImPlotContextPtr CreateContext()
		{
			return ImPlotNative.CreateContext();
		}

		public static void DestroyContext(ImPlotContextPtr ctx)
		{
			ImPlotNative.DestroyContext(ctx);
		}

		public static void DestroyContext()
		{
			// defining omitted parameters
			ImPlotContext* ctx = null;
			ImPlotNative.DestroyContext(ctx);
		}

		public static ImPlotContextPtr GetCurrentContext()
		{
			return ImPlotNative.GetCurrentContext();
		}

		public static void SetCurrentContext(ImPlotContextPtr ctx)
		{
			ImPlotNative.SetCurrentContext(ctx);
		}

		public static void SetImGuiContext(ImGuiContextPtr ctx)
		{
			ImPlotNative.SetImGuiContext(ctx);
		}

		public static bool BeginPlot(ReadOnlySpan<byte> titleId, Vector2 size, ImPlotFlags flags)
		{
			fixed (byte* nativeTitleId = titleId)
			{
				var result = ImPlotNative.BeginPlot(nativeTitleId, size, flags);
				return result != 0;
			}
		}

		public static bool BeginPlot(ReadOnlySpan<char> titleId, Vector2 size, ImPlotFlags flags)
		{
			// Marshaling titleId to native string
			byte* nativeTitleId;
			var byteCountTitleId = 0;
			if (titleId != null && !titleId.IsEmpty)
			{
				byteCountTitleId = Encoding.UTF8.GetByteCount(titleId);
				if(byteCountTitleId > Utils.MaxStackallocSize)
				{
					nativeTitleId = Utils.Alloc<byte>(byteCountTitleId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTitleId + 1];
					nativeTitleId = stackallocBytes;
				}
				var offsetTitleId = Utils.EncodeStringUTF8(titleId, nativeTitleId, byteCountTitleId);
				nativeTitleId[offsetTitleId] = 0;
			}
			else nativeTitleId = null;

			var result = ImPlotNative.BeginPlot(nativeTitleId, size, flags);
			// Freeing titleId native string
			if (byteCountTitleId > Utils.MaxStackallocSize)
				Utils.Free(nativeTitleId);
			return result != 0;
		}

		public static bool BeginPlot(ReadOnlySpan<byte> titleId, Vector2 size)
		{
			// defining omitted parameters
			ImPlotFlags flags = ImPlotFlags.None;
			fixed (byte* nativeTitleId = titleId)
			{
				var result = ImPlotNative.BeginPlot(nativeTitleId, size, flags);
				return result != 0;
			}
		}

		public static bool BeginPlot(ReadOnlySpan<char> titleId, Vector2 size)
		{
			// defining omitted parameters
			ImPlotFlags flags = ImPlotFlags.None;
			// Marshaling titleId to native string
			byte* nativeTitleId;
			var byteCountTitleId = 0;
			if (titleId != null && !titleId.IsEmpty)
			{
				byteCountTitleId = Encoding.UTF8.GetByteCount(titleId);
				if(byteCountTitleId > Utils.MaxStackallocSize)
				{
					nativeTitleId = Utils.Alloc<byte>(byteCountTitleId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTitleId + 1];
					nativeTitleId = stackallocBytes;
				}
				var offsetTitleId = Utils.EncodeStringUTF8(titleId, nativeTitleId, byteCountTitleId);
				nativeTitleId[offsetTitleId] = 0;
			}
			else nativeTitleId = null;

			var result = ImPlotNative.BeginPlot(nativeTitleId, size, flags);
			// Freeing titleId native string
			if (byteCountTitleId > Utils.MaxStackallocSize)
				Utils.Free(nativeTitleId);
			return result != 0;
		}

		public static bool BeginPlot(ReadOnlySpan<byte> titleId)
		{
			// defining omitted parameters
			ImPlotFlags flags = ImPlotFlags.None;
			Vector2 size = new Vector2(-1,0);
			fixed (byte* nativeTitleId = titleId)
			{
				var result = ImPlotNative.BeginPlot(nativeTitleId, size, flags);
				return result != 0;
			}
		}

		public static bool BeginPlot(ReadOnlySpan<char> titleId)
		{
			// defining omitted parameters
			ImPlotFlags flags = ImPlotFlags.None;
			Vector2 size = new Vector2(-1,0);
			// Marshaling titleId to native string
			byte* nativeTitleId;
			var byteCountTitleId = 0;
			if (titleId != null && !titleId.IsEmpty)
			{
				byteCountTitleId = Encoding.UTF8.GetByteCount(titleId);
				if(byteCountTitleId > Utils.MaxStackallocSize)
				{
					nativeTitleId = Utils.Alloc<byte>(byteCountTitleId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTitleId + 1];
					nativeTitleId = stackallocBytes;
				}
				var offsetTitleId = Utils.EncodeStringUTF8(titleId, nativeTitleId, byteCountTitleId);
				nativeTitleId[offsetTitleId] = 0;
			}
			else nativeTitleId = null;

			var result = ImPlotNative.BeginPlot(nativeTitleId, size, flags);
			// Freeing titleId native string
			if (byteCountTitleId > Utils.MaxStackallocSize)
				Utils.Free(nativeTitleId);
			return result != 0;
		}

		public static void EndPlot()
		{
			ImPlotNative.EndPlot();
		}

		public static bool BeginSubplots(ReadOnlySpan<byte> titleId, int rows, int cols, Vector2 size, ImPlotSubplotFlags flags, ref float rowRatios, ref float colRatios)
		{
			fixed (byte* nativeTitleId = titleId)
			fixed (float* nativeRowRatios = &rowRatios)
			fixed (float* nativeColRatios = &colRatios)
			{
				var result = ImPlotNative.BeginSubplots(nativeTitleId, rows, cols, size, flags, nativeRowRatios, nativeColRatios);
				return result != 0;
			}
		}

		public static bool BeginSubplots(ReadOnlySpan<char> titleId, int rows, int cols, Vector2 size, ImPlotSubplotFlags flags, ref float rowRatios, ref float colRatios)
		{
			// Marshaling titleId to native string
			byte* nativeTitleId;
			var byteCountTitleId = 0;
			if (titleId != null && !titleId.IsEmpty)
			{
				byteCountTitleId = Encoding.UTF8.GetByteCount(titleId);
				if(byteCountTitleId > Utils.MaxStackallocSize)
				{
					nativeTitleId = Utils.Alloc<byte>(byteCountTitleId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTitleId + 1];
					nativeTitleId = stackallocBytes;
				}
				var offsetTitleId = Utils.EncodeStringUTF8(titleId, nativeTitleId, byteCountTitleId);
				nativeTitleId[offsetTitleId] = 0;
			}
			else nativeTitleId = null;

			fixed (float* nativeRowRatios = &rowRatios)
			fixed (float* nativeColRatios = &colRatios)
			{
				var result = ImPlotNative.BeginSubplots(nativeTitleId, rows, cols, size, flags, nativeRowRatios, nativeColRatios);
				// Freeing titleId native string
				if (byteCountTitleId > Utils.MaxStackallocSize)
					Utils.Free(nativeTitleId);
				return result != 0;
			}
		}

		public static bool BeginSubplots(ReadOnlySpan<byte> titleId, int rows, int cols, Vector2 size, ImPlotSubplotFlags flags, ref float rowRatios)
		{
			// defining omitted parameters
			float* colRatios = null;
			fixed (byte* nativeTitleId = titleId)
			fixed (float* nativeRowRatios = &rowRatios)
			{
				var result = ImPlotNative.BeginSubplots(nativeTitleId, rows, cols, size, flags, nativeRowRatios, colRatios);
				return result != 0;
			}
		}

		public static bool BeginSubplots(ReadOnlySpan<char> titleId, int rows, int cols, Vector2 size, ImPlotSubplotFlags flags, ref float rowRatios)
		{
			// defining omitted parameters
			float* colRatios = null;
			// Marshaling titleId to native string
			byte* nativeTitleId;
			var byteCountTitleId = 0;
			if (titleId != null && !titleId.IsEmpty)
			{
				byteCountTitleId = Encoding.UTF8.GetByteCount(titleId);
				if(byteCountTitleId > Utils.MaxStackallocSize)
				{
					nativeTitleId = Utils.Alloc<byte>(byteCountTitleId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTitleId + 1];
					nativeTitleId = stackallocBytes;
				}
				var offsetTitleId = Utils.EncodeStringUTF8(titleId, nativeTitleId, byteCountTitleId);
				nativeTitleId[offsetTitleId] = 0;
			}
			else nativeTitleId = null;

			fixed (float* nativeRowRatios = &rowRatios)
			{
				var result = ImPlotNative.BeginSubplots(nativeTitleId, rows, cols, size, flags, nativeRowRatios, colRatios);
				// Freeing titleId native string
				if (byteCountTitleId > Utils.MaxStackallocSize)
					Utils.Free(nativeTitleId);
				return result != 0;
			}
		}

		public static bool BeginSubplots(ReadOnlySpan<byte> titleId, int rows, int cols, Vector2 size, ImPlotSubplotFlags flags)
		{
			// defining omitted parameters
			float* colRatios = null;
			float* rowRatios = null;
			fixed (byte* nativeTitleId = titleId)
			{
				var result = ImPlotNative.BeginSubplots(nativeTitleId, rows, cols, size, flags, rowRatios, colRatios);
				return result != 0;
			}
		}

		public static bool BeginSubplots(ReadOnlySpan<char> titleId, int rows, int cols, Vector2 size, ImPlotSubplotFlags flags)
		{
			// defining omitted parameters
			float* colRatios = null;
			float* rowRatios = null;
			// Marshaling titleId to native string
			byte* nativeTitleId;
			var byteCountTitleId = 0;
			if (titleId != null && !titleId.IsEmpty)
			{
				byteCountTitleId = Encoding.UTF8.GetByteCount(titleId);
				if(byteCountTitleId > Utils.MaxStackallocSize)
				{
					nativeTitleId = Utils.Alloc<byte>(byteCountTitleId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTitleId + 1];
					nativeTitleId = stackallocBytes;
				}
				var offsetTitleId = Utils.EncodeStringUTF8(titleId, nativeTitleId, byteCountTitleId);
				nativeTitleId[offsetTitleId] = 0;
			}
			else nativeTitleId = null;

			var result = ImPlotNative.BeginSubplots(nativeTitleId, rows, cols, size, flags, rowRatios, colRatios);
			// Freeing titleId native string
			if (byteCountTitleId > Utils.MaxStackallocSize)
				Utils.Free(nativeTitleId);
			return result != 0;
		}

		public static bool BeginSubplots(ReadOnlySpan<byte> titleId, int rows, int cols, Vector2 size)
		{
			// defining omitted parameters
			float* colRatios = null;
			float* rowRatios = null;
			ImPlotSubplotFlags flags = ImPlotSubplotFlags.None;
			fixed (byte* nativeTitleId = titleId)
			{
				var result = ImPlotNative.BeginSubplots(nativeTitleId, rows, cols, size, flags, rowRatios, colRatios);
				return result != 0;
			}
		}

		public static bool BeginSubplots(ReadOnlySpan<char> titleId, int rows, int cols, Vector2 size)
		{
			// defining omitted parameters
			float* colRatios = null;
			float* rowRatios = null;
			ImPlotSubplotFlags flags = ImPlotSubplotFlags.None;
			// Marshaling titleId to native string
			byte* nativeTitleId;
			var byteCountTitleId = 0;
			if (titleId != null && !titleId.IsEmpty)
			{
				byteCountTitleId = Encoding.UTF8.GetByteCount(titleId);
				if(byteCountTitleId > Utils.MaxStackallocSize)
				{
					nativeTitleId = Utils.Alloc<byte>(byteCountTitleId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTitleId + 1];
					nativeTitleId = stackallocBytes;
				}
				var offsetTitleId = Utils.EncodeStringUTF8(titleId, nativeTitleId, byteCountTitleId);
				nativeTitleId[offsetTitleId] = 0;
			}
			else nativeTitleId = null;

			var result = ImPlotNative.BeginSubplots(nativeTitleId, rows, cols, size, flags, rowRatios, colRatios);
			// Freeing titleId native string
			if (byteCountTitleId > Utils.MaxStackallocSize)
				Utils.Free(nativeTitleId);
			return result != 0;
		}

		public static void EndSubplots()
		{
			ImPlotNative.EndSubplots();
		}

		public static void SetupAxis(ImAxis axis, ReadOnlySpan<byte> label, ImPlotAxisFlags flags)
		{
			fixed (byte* nativeLabel = label)
			{
				ImPlotNative.SetupAxis(axis, nativeLabel, flags);
			}
		}

		public static void SetupAxis(ImAxis axis, ReadOnlySpan<char> label, ImPlotAxisFlags flags)
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

			ImPlotNative.SetupAxis(axis, nativeLabel, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
		}

		public static void SetupAxis(ImAxis axis, ReadOnlySpan<byte> label)
		{
			// defining omitted parameters
			ImPlotAxisFlags flags = ImPlotAxisFlags.None;
			fixed (byte* nativeLabel = label)
			{
				ImPlotNative.SetupAxis(axis, nativeLabel, flags);
			}
		}

		public static void SetupAxis(ImAxis axis, ReadOnlySpan<char> label)
		{
			// defining omitted parameters
			ImPlotAxisFlags flags = ImPlotAxisFlags.None;
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

			ImPlotNative.SetupAxis(axis, nativeLabel, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
		}

		public static void SetupAxis(ImAxis axis)
		{
			// defining omitted parameters
			ImPlotAxisFlags flags = ImPlotAxisFlags.None;
			byte* label = null;
			ImPlotNative.SetupAxis(axis, label, flags);
		}

		public static void SetupAxisLimits(ImAxis axis, double vMin, double vMax, ImPlotCond cond)
		{
			ImPlotNative.SetupAxisLimits(axis, vMin, vMax, cond);
		}

		public static void SetupAxisLimits(ImAxis axis, double vMin, double vMax)
		{
			// defining omitted parameters
			ImPlotCond cond = ImPlotCond.Once;
			ImPlotNative.SetupAxisLimits(axis, vMin, vMax, cond);
		}

		public static void SetupAxisLinks(ImAxis axis, ref double linkMin, ref double linkMax)
		{
			fixed (double* nativeLinkMin = &linkMin)
			fixed (double* nativeLinkMax = &linkMax)
			{
				ImPlotNative.SetupAxisLinks(axis, nativeLinkMin, nativeLinkMax);
			}
		}

		public static void SetupAxisFormatStr(ImAxis axis, ReadOnlySpan<byte> fmt)
		{
			fixed (byte* nativeFmt = fmt)
			{
				ImPlotNative.SetupAxisFormatStr(axis, nativeFmt);
			}
		}

		public static void SetupAxisFormatStr(ImAxis axis, ReadOnlySpan<char> fmt)
		{
			// Marshaling fmt to native string
			byte* nativeFmt;
			var byteCountFmt = 0;
			if (fmt != null && !fmt.IsEmpty)
			{
				byteCountFmt = Encoding.UTF8.GetByteCount(fmt);
				if(byteCountFmt > Utils.MaxStackallocSize)
				{
					nativeFmt = Utils.Alloc<byte>(byteCountFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFmt + 1];
					nativeFmt = stackallocBytes;
				}
				var offsetFmt = Utils.EncodeStringUTF8(fmt, nativeFmt, byteCountFmt);
				nativeFmt[offsetFmt] = 0;
			}
			else nativeFmt = null;

			ImPlotNative.SetupAxisFormatStr(axis, nativeFmt);
			// Freeing fmt native string
			if (byteCountFmt > Utils.MaxStackallocSize)
				Utils.Free(nativeFmt);
		}

		public static void SetupAxisFormatPlotFormatter(ImAxis axis, ImPlotFormatter formatter, IntPtr data)
		{
			ImPlotNative.SetupAxisFormatPlotFormatter(axis, formatter, (void*)data);
		}

		public static void SetupAxisTicksDoublePtr(ImAxis axis, double[] values, int nTicks, ref byte* labels, bool keepDefault)
		{
			var native_keepDefault = keepDefault ? (byte)1 : (byte)0;
			fixed (double* nativeValues = values)
			fixed (byte** nativeLabels = &labels)
			{
				ImPlotNative.SetupAxisTicksDoublePtr(axis, nativeValues, nTicks, nativeLabels, native_keepDefault);
			}
		}

		public static void SetupAxisTicksDouble(ImAxis axis, double vMin, double vMax, int nTicks, ref byte* labels, bool keepDefault)
		{
			var native_keepDefault = keepDefault ? (byte)1 : (byte)0;
			fixed (byte** nativeLabels = &labels)
			{
				ImPlotNative.SetupAxisTicksDouble(axis, vMin, vMax, nTicks, nativeLabels, native_keepDefault);
			}
		}

		public static void SetupAxisScalePlotScale(ImAxis axis, ImPlotScale scale)
		{
			ImPlotNative.SetupAxisScalePlotScale(axis, scale);
		}

		public static void SetupAxisScalePlotTransform(ImAxis axis, ImPlotTransform forward, ImPlotTransform inverse, IntPtr data)
		{
			ImPlotNative.SetupAxisScalePlotTransform(axis, forward, inverse, (void*)data);
		}

		public static void SetupAxisLimitsConstraints(ImAxis axis, double vMin, double vMax)
		{
			ImPlotNative.SetupAxisLimitsConstraints(axis, vMin, vMax);
		}

		public static void SetupAxisZoomConstraints(ImAxis axis, double zMin, double zMax)
		{
			ImPlotNative.SetupAxisZoomConstraints(axis, zMin, zMax);
		}

		public static void SetupAxes(ReadOnlySpan<byte> xLabel, ReadOnlySpan<byte> yLabel, ImPlotAxisFlags xFlags, ImPlotAxisFlags yFlags)
		{
			fixed (byte* nativeXLabel = xLabel)
			fixed (byte* nativeYLabel = yLabel)
			{
				ImPlotNative.SetupAxes(nativeXLabel, nativeYLabel, xFlags, yFlags);
			}
		}

		public static void SetupAxes(ReadOnlySpan<char> xLabel, ReadOnlySpan<char> yLabel, ImPlotAxisFlags xFlags, ImPlotAxisFlags yFlags)
		{
			// Marshaling xLabel to native string
			byte* nativeXLabel;
			var byteCountXLabel = 0;
			if (xLabel != null && !xLabel.IsEmpty)
			{
				byteCountXLabel = Encoding.UTF8.GetByteCount(xLabel);
				if(byteCountXLabel > Utils.MaxStackallocSize)
				{
					nativeXLabel = Utils.Alloc<byte>(byteCountXLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountXLabel + 1];
					nativeXLabel = stackallocBytes;
				}
				var offsetXLabel = Utils.EncodeStringUTF8(xLabel, nativeXLabel, byteCountXLabel);
				nativeXLabel[offsetXLabel] = 0;
			}
			else nativeXLabel = null;

			// Marshaling yLabel to native string
			byte* nativeYLabel;
			var byteCountYLabel = 0;
			if (yLabel != null && !yLabel.IsEmpty)
			{
				byteCountYLabel = Encoding.UTF8.GetByteCount(yLabel);
				if(byteCountYLabel > Utils.MaxStackallocSize)
				{
					nativeYLabel = Utils.Alloc<byte>(byteCountYLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountYLabel + 1];
					nativeYLabel = stackallocBytes;
				}
				var offsetYLabel = Utils.EncodeStringUTF8(yLabel, nativeYLabel, byteCountYLabel);
				nativeYLabel[offsetYLabel] = 0;
			}
			else nativeYLabel = null;

			ImPlotNative.SetupAxes(nativeXLabel, nativeYLabel, xFlags, yFlags);
			// Freeing xLabel native string
			if (byteCountXLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeXLabel);
			// Freeing yLabel native string
			if (byteCountYLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeYLabel);
		}

		public static void SetupAxes(ReadOnlySpan<byte> xLabel, ReadOnlySpan<byte> yLabel, ImPlotAxisFlags xFlags)
		{
			// defining omitted parameters
			ImPlotAxisFlags yFlags = ImPlotAxisFlags.None;
			fixed (byte* nativeXLabel = xLabel)
			fixed (byte* nativeYLabel = yLabel)
			{
				ImPlotNative.SetupAxes(nativeXLabel, nativeYLabel, xFlags, yFlags);
			}
		}

		public static void SetupAxes(ReadOnlySpan<char> xLabel, ReadOnlySpan<char> yLabel, ImPlotAxisFlags xFlags)
		{
			// defining omitted parameters
			ImPlotAxisFlags yFlags = ImPlotAxisFlags.None;
			// Marshaling xLabel to native string
			byte* nativeXLabel;
			var byteCountXLabel = 0;
			if (xLabel != null && !xLabel.IsEmpty)
			{
				byteCountXLabel = Encoding.UTF8.GetByteCount(xLabel);
				if(byteCountXLabel > Utils.MaxStackallocSize)
				{
					nativeXLabel = Utils.Alloc<byte>(byteCountXLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountXLabel + 1];
					nativeXLabel = stackallocBytes;
				}
				var offsetXLabel = Utils.EncodeStringUTF8(xLabel, nativeXLabel, byteCountXLabel);
				nativeXLabel[offsetXLabel] = 0;
			}
			else nativeXLabel = null;

			// Marshaling yLabel to native string
			byte* nativeYLabel;
			var byteCountYLabel = 0;
			if (yLabel != null && !yLabel.IsEmpty)
			{
				byteCountYLabel = Encoding.UTF8.GetByteCount(yLabel);
				if(byteCountYLabel > Utils.MaxStackallocSize)
				{
					nativeYLabel = Utils.Alloc<byte>(byteCountYLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountYLabel + 1];
					nativeYLabel = stackallocBytes;
				}
				var offsetYLabel = Utils.EncodeStringUTF8(yLabel, nativeYLabel, byteCountYLabel);
				nativeYLabel[offsetYLabel] = 0;
			}
			else nativeYLabel = null;

			ImPlotNative.SetupAxes(nativeXLabel, nativeYLabel, xFlags, yFlags);
			// Freeing xLabel native string
			if (byteCountXLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeXLabel);
			// Freeing yLabel native string
			if (byteCountYLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeYLabel);
		}

		public static void SetupAxes(ReadOnlySpan<byte> xLabel, ReadOnlySpan<byte> yLabel)
		{
			// defining omitted parameters
			ImPlotAxisFlags yFlags = ImPlotAxisFlags.None;
			ImPlotAxisFlags xFlags = ImPlotAxisFlags.None;
			fixed (byte* nativeXLabel = xLabel)
			fixed (byte* nativeYLabel = yLabel)
			{
				ImPlotNative.SetupAxes(nativeXLabel, nativeYLabel, xFlags, yFlags);
			}
		}

		public static void SetupAxes(ReadOnlySpan<char> xLabel, ReadOnlySpan<char> yLabel)
		{
			// defining omitted parameters
			ImPlotAxisFlags yFlags = ImPlotAxisFlags.None;
			ImPlotAxisFlags xFlags = ImPlotAxisFlags.None;
			// Marshaling xLabel to native string
			byte* nativeXLabel;
			var byteCountXLabel = 0;
			if (xLabel != null && !xLabel.IsEmpty)
			{
				byteCountXLabel = Encoding.UTF8.GetByteCount(xLabel);
				if(byteCountXLabel > Utils.MaxStackallocSize)
				{
					nativeXLabel = Utils.Alloc<byte>(byteCountXLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountXLabel + 1];
					nativeXLabel = stackallocBytes;
				}
				var offsetXLabel = Utils.EncodeStringUTF8(xLabel, nativeXLabel, byteCountXLabel);
				nativeXLabel[offsetXLabel] = 0;
			}
			else nativeXLabel = null;

			// Marshaling yLabel to native string
			byte* nativeYLabel;
			var byteCountYLabel = 0;
			if (yLabel != null && !yLabel.IsEmpty)
			{
				byteCountYLabel = Encoding.UTF8.GetByteCount(yLabel);
				if(byteCountYLabel > Utils.MaxStackallocSize)
				{
					nativeYLabel = Utils.Alloc<byte>(byteCountYLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountYLabel + 1];
					nativeYLabel = stackallocBytes;
				}
				var offsetYLabel = Utils.EncodeStringUTF8(yLabel, nativeYLabel, byteCountYLabel);
				nativeYLabel[offsetYLabel] = 0;
			}
			else nativeYLabel = null;

			ImPlotNative.SetupAxes(nativeXLabel, nativeYLabel, xFlags, yFlags);
			// Freeing xLabel native string
			if (byteCountXLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeXLabel);
			// Freeing yLabel native string
			if (byteCountYLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeYLabel);
		}

		public static void SetupAxesLimits(double xMin, double xMax, double yMin, double yMax, ImPlotCond cond)
		{
			ImPlotNative.SetupAxesLimits(xMin, xMax, yMin, yMax, cond);
		}

		public static void SetupAxesLimits(double xMin, double xMax, double yMin, double yMax)
		{
			// defining omitted parameters
			ImPlotCond cond = ImPlotCond.Once;
			ImPlotNative.SetupAxesLimits(xMin, xMax, yMin, yMax, cond);
		}

		public static void SetupLegend(ImPlotLocation location, ImPlotLegendFlags flags)
		{
			ImPlotNative.SetupLegend(location, flags);
		}

		public static void SetupLegend(ImPlotLocation location)
		{
			// defining omitted parameters
			ImPlotLegendFlags flags = ImPlotLegendFlags.None;
			ImPlotNative.SetupLegend(location, flags);
		}

		public static void SetupMouseText(ImPlotLocation location, ImPlotMouseTextFlags flags)
		{
			ImPlotNative.SetupMouseText(location, flags);
		}

		public static void SetupMouseText(ImPlotLocation location)
		{
			// defining omitted parameters
			ImPlotMouseTextFlags flags = ImPlotMouseTextFlags.None;
			ImPlotNative.SetupMouseText(location, flags);
		}

		public static void SetupFinish()
		{
			ImPlotNative.SetupFinish();
		}

		public static void SetNextAxisLimits(ImAxis axis, double vMin, double vMax, ImPlotCond cond)
		{
			ImPlotNative.SetNextAxisLimits(axis, vMin, vMax, cond);
		}

		public static void SetNextAxisLimits(ImAxis axis, double vMin, double vMax)
		{
			// defining omitted parameters
			ImPlotCond cond = ImPlotCond.Once;
			ImPlotNative.SetNextAxisLimits(axis, vMin, vMax, cond);
		}

		public static void SetNextAxisLinks(ImAxis axis, ref double linkMin, ref double linkMax)
		{
			fixed (double* nativeLinkMin = &linkMin)
			fixed (double* nativeLinkMax = &linkMax)
			{
				ImPlotNative.SetNextAxisLinks(axis, nativeLinkMin, nativeLinkMax);
			}
		}

		public static void SetNextAxisToFit(ImAxis axis)
		{
			ImPlotNative.SetNextAxisToFit(axis);
		}

		public static void SetNextAxesLimits(double xMin, double xMax, double yMin, double yMax, ImPlotCond cond)
		{
			ImPlotNative.SetNextAxesLimits(xMin, xMax, yMin, yMax, cond);
		}

		public static void SetNextAxesLimits(double xMin, double xMax, double yMin, double yMax)
		{
			// defining omitted parameters
			ImPlotCond cond = ImPlotCond.Once;
			ImPlotNative.SetNextAxesLimits(xMin, xMax, yMin, yMax, cond);
		}

		public static void SetNextAxesToFit()
		{
			ImPlotNative.SetNextAxesToFit();
		}

		public static void PlotLineFloatPtrInt(ReadOnlySpan<byte> labelId, float[] values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (float* nativeValues = values)
			{
				ImPlotNative.PlotLineFloatPtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
			}
		}

		public static void PlotLineFloatPtrInt(ReadOnlySpan<char> labelId, float[] values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (float* nativeValues = values)
			{
				ImPlotNative.PlotLineFloatPtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotLineDoublePtrInt(ReadOnlySpan<byte> labelId, double[] values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (double* nativeValues = values)
			{
				ImPlotNative.PlotLineDoublePtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
			}
		}

		public static void PlotLineDoublePtrInt(ReadOnlySpan<char> labelId, double[] values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (double* nativeValues = values)
			{
				ImPlotNative.PlotLineDoublePtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotLineS8PtrInt(ReadOnlySpan<byte> labelId, sbyte[] values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (sbyte* nativeValues = values)
			{
				ImPlotNative.PlotLineS8PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
			}
		}

		public static void PlotLineS8PtrInt(ReadOnlySpan<char> labelId, sbyte[] values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (sbyte* nativeValues = values)
			{
				ImPlotNative.PlotLineS8PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotLineU8PtrInt(ReadOnlySpan<byte> labelId, byte[] values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (byte* nativeValues = values)
			{
				ImPlotNative.PlotLineU8PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
			}
		}

		public static void PlotLineU8PtrInt(ReadOnlySpan<char> labelId, byte[] values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (byte* nativeValues = values)
			{
				ImPlotNative.PlotLineU8PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotLineS16PtrInt(ReadOnlySpan<byte> labelId, short[] values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (short* nativeValues = values)
			{
				ImPlotNative.PlotLineS16PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
			}
		}

		public static void PlotLineS16PtrInt(ReadOnlySpan<char> labelId, short[] values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (short* nativeValues = values)
			{
				ImPlotNative.PlotLineS16PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotLineU16PtrInt(ReadOnlySpan<byte> labelId, ushort[] values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ushort* nativeValues = values)
			{
				ImPlotNative.PlotLineU16PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
			}
		}

		public static void PlotLineU16PtrInt(ReadOnlySpan<char> labelId, ushort[] values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (ushort* nativeValues = values)
			{
				ImPlotNative.PlotLineU16PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotLineS32PtrInt(ReadOnlySpan<byte> labelId, int[] values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (int* nativeValues = values)
			{
				ImPlotNative.PlotLineS32PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
			}
		}

		public static void PlotLineS32PtrInt(ReadOnlySpan<char> labelId, int[] values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (int* nativeValues = values)
			{
				ImPlotNative.PlotLineS32PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotLineU32PtrInt(ReadOnlySpan<byte> labelId, uint[] values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (uint* nativeValues = values)
			{
				ImPlotNative.PlotLineU32PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
			}
		}

		public static void PlotLineU32PtrInt(ReadOnlySpan<char> labelId, uint[] values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (uint* nativeValues = values)
			{
				ImPlotNative.PlotLineU32PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotLineS64PtrInt(ReadOnlySpan<byte> labelId, long[] values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (long* nativeValues = values)
			{
				ImPlotNative.PlotLineS64PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
			}
		}

		public static void PlotLineS64PtrInt(ReadOnlySpan<char> labelId, long[] values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (long* nativeValues = values)
			{
				ImPlotNative.PlotLineS64PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotLineU64PtrInt(ReadOnlySpan<byte> labelId, ulong[] values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ulong* nativeValues = values)
			{
				ImPlotNative.PlotLineU64PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
			}
		}

		public static void PlotLineU64PtrInt(ReadOnlySpan<char> labelId, ulong[] values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (ulong* nativeValues = values)
			{
				ImPlotNative.PlotLineU64PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotLineFloatPtrFloatPtr(ReadOnlySpan<byte> labelId, float[] xs, float[] ys, int count, ImPlotLineFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (float* nativeXs = xs)
			fixed (float* nativeYs = ys)
			{
				ImPlotNative.PlotLineFloatPtrFloatPtr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
			}
		}

		public static void PlotLineFloatPtrFloatPtr(ReadOnlySpan<char> labelId, float[] xs, float[] ys, int count, ImPlotLineFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (float* nativeXs = xs)
			fixed (float* nativeYs = ys)
			{
				ImPlotNative.PlotLineFloatPtrFloatPtr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotLineDoublePtrdoublePtr(ReadOnlySpan<byte> labelId, double[] xs, double[] ys, int count, ImPlotLineFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (double* nativeXs = xs)
			fixed (double* nativeYs = ys)
			{
				ImPlotNative.PlotLineDoublePtrdoublePtr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
			}
		}

		public static void PlotLineDoublePtrdoublePtr(ReadOnlySpan<char> labelId, double[] xs, double[] ys, int count, ImPlotLineFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (double* nativeXs = xs)
			fixed (double* nativeYs = ys)
			{
				ImPlotNative.PlotLineDoublePtrdoublePtr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotLineS8PtrS8Ptr(ReadOnlySpan<byte> labelId, sbyte[] xs, sbyte[] ys, int count, ImPlotLineFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (sbyte* nativeXs = xs)
			fixed (sbyte* nativeYs = ys)
			{
				ImPlotNative.PlotLineS8PtrS8Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
			}
		}

		public static void PlotLineS8PtrS8Ptr(ReadOnlySpan<char> labelId, sbyte[] xs, sbyte[] ys, int count, ImPlotLineFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (sbyte* nativeXs = xs)
			fixed (sbyte* nativeYs = ys)
			{
				ImPlotNative.PlotLineS8PtrS8Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotLineU8PtrU8Ptr(ReadOnlySpan<byte> labelId, byte[] xs, byte[] ys, int count, ImPlotLineFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (byte* nativeXs = xs)
			fixed (byte* nativeYs = ys)
			{
				ImPlotNative.PlotLineU8PtrU8Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
			}
		}

		public static void PlotLineU8PtrU8Ptr(ReadOnlySpan<char> labelId, byte[] xs, byte[] ys, int count, ImPlotLineFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (byte* nativeXs = xs)
			fixed (byte* nativeYs = ys)
			{
				ImPlotNative.PlotLineU8PtrU8Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotLineS16PtrS16Ptr(ReadOnlySpan<byte> labelId, short[] xs, short[] ys, int count, ImPlotLineFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (short* nativeXs = xs)
			fixed (short* nativeYs = ys)
			{
				ImPlotNative.PlotLineS16PtrS16Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
			}
		}

		public static void PlotLineS16PtrS16Ptr(ReadOnlySpan<char> labelId, short[] xs, short[] ys, int count, ImPlotLineFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (short* nativeXs = xs)
			fixed (short* nativeYs = ys)
			{
				ImPlotNative.PlotLineS16PtrS16Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotLineU16PtrU16Ptr(ReadOnlySpan<byte> labelId, ushort[] xs, ushort[] ys, int count, ImPlotLineFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ushort* nativeXs = xs)
			fixed (ushort* nativeYs = ys)
			{
				ImPlotNative.PlotLineU16PtrU16Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
			}
		}

		public static void PlotLineU16PtrU16Ptr(ReadOnlySpan<char> labelId, ushort[] xs, ushort[] ys, int count, ImPlotLineFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (ushort* nativeXs = xs)
			fixed (ushort* nativeYs = ys)
			{
				ImPlotNative.PlotLineU16PtrU16Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotLineS32PtrS32Ptr(ReadOnlySpan<byte> labelId, int[] xs, int[] ys, int count, ImPlotLineFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (int* nativeXs = xs)
			fixed (int* nativeYs = ys)
			{
				ImPlotNative.PlotLineS32PtrS32Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
			}
		}

		public static void PlotLineS32PtrS32Ptr(ReadOnlySpan<char> labelId, int[] xs, int[] ys, int count, ImPlotLineFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (int* nativeXs = xs)
			fixed (int* nativeYs = ys)
			{
				ImPlotNative.PlotLineS32PtrS32Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotLineU32PtrU32Ptr(ReadOnlySpan<byte> labelId, uint[] xs, uint[] ys, int count, ImPlotLineFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (uint* nativeXs = xs)
			fixed (uint* nativeYs = ys)
			{
				ImPlotNative.PlotLineU32PtrU32Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
			}
		}

		public static void PlotLineU32PtrU32Ptr(ReadOnlySpan<char> labelId, uint[] xs, uint[] ys, int count, ImPlotLineFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (uint* nativeXs = xs)
			fixed (uint* nativeYs = ys)
			{
				ImPlotNative.PlotLineU32PtrU32Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotLineS64PtrS64Ptr(ReadOnlySpan<byte> labelId, long[] xs, long[] ys, int count, ImPlotLineFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (long* nativeXs = xs)
			fixed (long* nativeYs = ys)
			{
				ImPlotNative.PlotLineS64PtrS64Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
			}
		}

		public static void PlotLineS64PtrS64Ptr(ReadOnlySpan<char> labelId, long[] xs, long[] ys, int count, ImPlotLineFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (long* nativeXs = xs)
			fixed (long* nativeYs = ys)
			{
				ImPlotNative.PlotLineS64PtrS64Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotLineU64PtrU64Ptr(ReadOnlySpan<byte> labelId, ulong[] xs, ulong[] ys, int count, ImPlotLineFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ulong* nativeXs = xs)
			fixed (ulong* nativeYs = ys)
			{
				ImPlotNative.PlotLineU64PtrU64Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
			}
		}

		public static void PlotLineU64PtrU64Ptr(ReadOnlySpan<char> labelId, ulong[] xs, ulong[] ys, int count, ImPlotLineFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (ulong* nativeXs = xs)
			fixed (ulong* nativeYs = ys)
			{
				ImPlotNative.PlotLineU64PtrU64Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotLineG(ReadOnlySpan<byte> labelId, ImPlotPointGetter getter, IntPtr data, int count, ImPlotLineFlags flags)
		{
			fixed (byte* nativeLabelId = labelId)
			{
				ImPlotNative.PlotLineG(nativeLabelId, getter, (void*)data, count, flags);
			}
		}

		public static void PlotLineG(ReadOnlySpan<char> labelId, ImPlotPointGetter getter, IntPtr data, int count, ImPlotLineFlags flags)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			ImPlotNative.PlotLineG(nativeLabelId, getter, (void*)data, count, flags);
			// Freeing labelId native string
			if (byteCountLabelId > Utils.MaxStackallocSize)
				Utils.Free(nativeLabelId);
		}

		public static void PlotLineG(ReadOnlySpan<byte> labelId, ImPlotPointGetter getter, IntPtr data, int count)
		{
			// defining omitted parameters
			ImPlotLineFlags flags = ImPlotLineFlags.None;
			fixed (byte* nativeLabelId = labelId)
			{
				ImPlotNative.PlotLineG(nativeLabelId, getter, (void*)data, count, flags);
			}
		}

		public static void PlotLineG(ReadOnlySpan<char> labelId, ImPlotPointGetter getter, IntPtr data, int count)
		{
			// defining omitted parameters
			ImPlotLineFlags flags = ImPlotLineFlags.None;
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			ImPlotNative.PlotLineG(nativeLabelId, getter, (void*)data, count, flags);
			// Freeing labelId native string
			if (byteCountLabelId > Utils.MaxStackallocSize)
				Utils.Free(nativeLabelId);
		}

		public static void PlotScatterFloatPtrInt(ReadOnlySpan<byte> labelId, float[] values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (float* nativeValues = values)
			{
				ImPlotNative.PlotScatterFloatPtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
			}
		}

		public static void PlotScatterFloatPtrInt(ReadOnlySpan<char> labelId, float[] values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (float* nativeValues = values)
			{
				ImPlotNative.PlotScatterFloatPtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotScatterDoublePtrInt(ReadOnlySpan<byte> labelId, double[] values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (double* nativeValues = values)
			{
				ImPlotNative.PlotScatterDoublePtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
			}
		}

		public static void PlotScatterDoublePtrInt(ReadOnlySpan<char> labelId, double[] values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (double* nativeValues = values)
			{
				ImPlotNative.PlotScatterDoublePtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotScatterS8PtrInt(ReadOnlySpan<byte> labelId, sbyte[] values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (sbyte* nativeValues = values)
			{
				ImPlotNative.PlotScatterS8PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
			}
		}

		public static void PlotScatterS8PtrInt(ReadOnlySpan<char> labelId, sbyte[] values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (sbyte* nativeValues = values)
			{
				ImPlotNative.PlotScatterS8PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotScatterU8PtrInt(ReadOnlySpan<byte> labelId, byte[] values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (byte* nativeValues = values)
			{
				ImPlotNative.PlotScatterU8PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
			}
		}

		public static void PlotScatterU8PtrInt(ReadOnlySpan<char> labelId, byte[] values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (byte* nativeValues = values)
			{
				ImPlotNative.PlotScatterU8PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotScatterS16PtrInt(ReadOnlySpan<byte> labelId, short[] values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (short* nativeValues = values)
			{
				ImPlotNative.PlotScatterS16PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
			}
		}

		public static void PlotScatterS16PtrInt(ReadOnlySpan<char> labelId, short[] values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (short* nativeValues = values)
			{
				ImPlotNative.PlotScatterS16PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotScatterU16PtrInt(ReadOnlySpan<byte> labelId, ushort[] values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ushort* nativeValues = values)
			{
				ImPlotNative.PlotScatterU16PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
			}
		}

		public static void PlotScatterU16PtrInt(ReadOnlySpan<char> labelId, ushort[] values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (ushort* nativeValues = values)
			{
				ImPlotNative.PlotScatterU16PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotScatterS32PtrInt(ReadOnlySpan<byte> labelId, int[] values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (int* nativeValues = values)
			{
				ImPlotNative.PlotScatterS32PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
			}
		}

		public static void PlotScatterS32PtrInt(ReadOnlySpan<char> labelId, int[] values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (int* nativeValues = values)
			{
				ImPlotNative.PlotScatterS32PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotScatterU32PtrInt(ReadOnlySpan<byte> labelId, uint[] values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (uint* nativeValues = values)
			{
				ImPlotNative.PlotScatterU32PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
			}
		}

		public static void PlotScatterU32PtrInt(ReadOnlySpan<char> labelId, uint[] values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (uint* nativeValues = values)
			{
				ImPlotNative.PlotScatterU32PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotScatterS64PtrInt(ReadOnlySpan<byte> labelId, long[] values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (long* nativeValues = values)
			{
				ImPlotNative.PlotScatterS64PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
			}
		}

		public static void PlotScatterS64PtrInt(ReadOnlySpan<char> labelId, long[] values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (long* nativeValues = values)
			{
				ImPlotNative.PlotScatterS64PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotScatterU64PtrInt(ReadOnlySpan<byte> labelId, ulong[] values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ulong* nativeValues = values)
			{
				ImPlotNative.PlotScatterU64PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
			}
		}

		public static void PlotScatterU64PtrInt(ReadOnlySpan<char> labelId, ulong[] values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (ulong* nativeValues = values)
			{
				ImPlotNative.PlotScatterU64PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotScatterFloatPtrFloatPtr(ReadOnlySpan<byte> labelId, float[] xs, float[] ys, int count, ImPlotScatterFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (float* nativeXs = xs)
			fixed (float* nativeYs = ys)
			{
				ImPlotNative.PlotScatterFloatPtrFloatPtr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
			}
		}

		public static void PlotScatterFloatPtrFloatPtr(ReadOnlySpan<char> labelId, float[] xs, float[] ys, int count, ImPlotScatterFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (float* nativeXs = xs)
			fixed (float* nativeYs = ys)
			{
				ImPlotNative.PlotScatterFloatPtrFloatPtr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotScatterDoublePtrdoublePtr(ReadOnlySpan<byte> labelId, double[] xs, double[] ys, int count, ImPlotScatterFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (double* nativeXs = xs)
			fixed (double* nativeYs = ys)
			{
				ImPlotNative.PlotScatterDoublePtrdoublePtr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
			}
		}

		public static void PlotScatterDoublePtrdoublePtr(ReadOnlySpan<char> labelId, double[] xs, double[] ys, int count, ImPlotScatterFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (double* nativeXs = xs)
			fixed (double* nativeYs = ys)
			{
				ImPlotNative.PlotScatterDoublePtrdoublePtr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotScatterS8PtrS8Ptr(ReadOnlySpan<byte> labelId, sbyte[] xs, sbyte[] ys, int count, ImPlotScatterFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (sbyte* nativeXs = xs)
			fixed (sbyte* nativeYs = ys)
			{
				ImPlotNative.PlotScatterS8PtrS8Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
			}
		}

		public static void PlotScatterS8PtrS8Ptr(ReadOnlySpan<char> labelId, sbyte[] xs, sbyte[] ys, int count, ImPlotScatterFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (sbyte* nativeXs = xs)
			fixed (sbyte* nativeYs = ys)
			{
				ImPlotNative.PlotScatterS8PtrS8Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotScatterU8PtrU8Ptr(ReadOnlySpan<byte> labelId, byte[] xs, byte[] ys, int count, ImPlotScatterFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (byte* nativeXs = xs)
			fixed (byte* nativeYs = ys)
			{
				ImPlotNative.PlotScatterU8PtrU8Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
			}
		}

		public static void PlotScatterU8PtrU8Ptr(ReadOnlySpan<char> labelId, byte[] xs, byte[] ys, int count, ImPlotScatterFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (byte* nativeXs = xs)
			fixed (byte* nativeYs = ys)
			{
				ImPlotNative.PlotScatterU8PtrU8Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotScatterS16PtrS16Ptr(ReadOnlySpan<byte> labelId, short[] xs, short[] ys, int count, ImPlotScatterFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (short* nativeXs = xs)
			fixed (short* nativeYs = ys)
			{
				ImPlotNative.PlotScatterS16PtrS16Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
			}
		}

		public static void PlotScatterS16PtrS16Ptr(ReadOnlySpan<char> labelId, short[] xs, short[] ys, int count, ImPlotScatterFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (short* nativeXs = xs)
			fixed (short* nativeYs = ys)
			{
				ImPlotNative.PlotScatterS16PtrS16Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotScatterU16PtrU16Ptr(ReadOnlySpan<byte> labelId, ushort[] xs, ushort[] ys, int count, ImPlotScatterFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ushort* nativeXs = xs)
			fixed (ushort* nativeYs = ys)
			{
				ImPlotNative.PlotScatterU16PtrU16Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
			}
		}

		public static void PlotScatterU16PtrU16Ptr(ReadOnlySpan<char> labelId, ushort[] xs, ushort[] ys, int count, ImPlotScatterFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (ushort* nativeXs = xs)
			fixed (ushort* nativeYs = ys)
			{
				ImPlotNative.PlotScatterU16PtrU16Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotScatterS32PtrS32Ptr(ReadOnlySpan<byte> labelId, int[] xs, int[] ys, int count, ImPlotScatterFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (int* nativeXs = xs)
			fixed (int* nativeYs = ys)
			{
				ImPlotNative.PlotScatterS32PtrS32Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
			}
		}

		public static void PlotScatterS32PtrS32Ptr(ReadOnlySpan<char> labelId, int[] xs, int[] ys, int count, ImPlotScatterFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (int* nativeXs = xs)
			fixed (int* nativeYs = ys)
			{
				ImPlotNative.PlotScatterS32PtrS32Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotScatterU32PtrU32Ptr(ReadOnlySpan<byte> labelId, uint[] xs, uint[] ys, int count, ImPlotScatterFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (uint* nativeXs = xs)
			fixed (uint* nativeYs = ys)
			{
				ImPlotNative.PlotScatterU32PtrU32Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
			}
		}

		public static void PlotScatterU32PtrU32Ptr(ReadOnlySpan<char> labelId, uint[] xs, uint[] ys, int count, ImPlotScatterFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (uint* nativeXs = xs)
			fixed (uint* nativeYs = ys)
			{
				ImPlotNative.PlotScatterU32PtrU32Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotScatterS64PtrS64Ptr(ReadOnlySpan<byte> labelId, long[] xs, long[] ys, int count, ImPlotScatterFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (long* nativeXs = xs)
			fixed (long* nativeYs = ys)
			{
				ImPlotNative.PlotScatterS64PtrS64Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
			}
		}

		public static void PlotScatterS64PtrS64Ptr(ReadOnlySpan<char> labelId, long[] xs, long[] ys, int count, ImPlotScatterFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (long* nativeXs = xs)
			fixed (long* nativeYs = ys)
			{
				ImPlotNative.PlotScatterS64PtrS64Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotScatterU64PtrU64Ptr(ReadOnlySpan<byte> labelId, ulong[] xs, ulong[] ys, int count, ImPlotScatterFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ulong* nativeXs = xs)
			fixed (ulong* nativeYs = ys)
			{
				ImPlotNative.PlotScatterU64PtrU64Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
			}
		}

		public static void PlotScatterU64PtrU64Ptr(ReadOnlySpan<char> labelId, ulong[] xs, ulong[] ys, int count, ImPlotScatterFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (ulong* nativeXs = xs)
			fixed (ulong* nativeYs = ys)
			{
				ImPlotNative.PlotScatterU64PtrU64Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotScatterG(ReadOnlySpan<byte> labelId, ImPlotPointGetter getter, IntPtr data, int count, ImPlotScatterFlags flags)
		{
			fixed (byte* nativeLabelId = labelId)
			{
				ImPlotNative.PlotScatterG(nativeLabelId, getter, (void*)data, count, flags);
			}
		}

		public static void PlotScatterG(ReadOnlySpan<char> labelId, ImPlotPointGetter getter, IntPtr data, int count, ImPlotScatterFlags flags)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			ImPlotNative.PlotScatterG(nativeLabelId, getter, (void*)data, count, flags);
			// Freeing labelId native string
			if (byteCountLabelId > Utils.MaxStackallocSize)
				Utils.Free(nativeLabelId);
		}

		public static void PlotScatterG(ReadOnlySpan<byte> labelId, ImPlotPointGetter getter, IntPtr data, int count)
		{
			// defining omitted parameters
			ImPlotScatterFlags flags = ImPlotScatterFlags.None;
			fixed (byte* nativeLabelId = labelId)
			{
				ImPlotNative.PlotScatterG(nativeLabelId, getter, (void*)data, count, flags);
			}
		}

		public static void PlotScatterG(ReadOnlySpan<char> labelId, ImPlotPointGetter getter, IntPtr data, int count)
		{
			// defining omitted parameters
			ImPlotScatterFlags flags = ImPlotScatterFlags.None;
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			ImPlotNative.PlotScatterG(nativeLabelId, getter, (void*)data, count, flags);
			// Freeing labelId native string
			if (byteCountLabelId > Utils.MaxStackallocSize)
				Utils.Free(nativeLabelId);
		}

		public static void PlotStairsFloatPtrInt(ReadOnlySpan<byte> labelId, float[] values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (float* nativeValues = values)
			{
				ImPlotNative.PlotStairsFloatPtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
			}
		}

		public static void PlotStairsFloatPtrInt(ReadOnlySpan<char> labelId, float[] values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (float* nativeValues = values)
			{
				ImPlotNative.PlotStairsFloatPtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotStairsDoublePtrInt(ReadOnlySpan<byte> labelId, double[] values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (double* nativeValues = values)
			{
				ImPlotNative.PlotStairsDoublePtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
			}
		}

		public static void PlotStairsDoublePtrInt(ReadOnlySpan<char> labelId, double[] values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (double* nativeValues = values)
			{
				ImPlotNative.PlotStairsDoublePtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotStairsS8PtrInt(ReadOnlySpan<byte> labelId, sbyte[] values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (sbyte* nativeValues = values)
			{
				ImPlotNative.PlotStairsS8PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
			}
		}

		public static void PlotStairsS8PtrInt(ReadOnlySpan<char> labelId, sbyte[] values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (sbyte* nativeValues = values)
			{
				ImPlotNative.PlotStairsS8PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotStairsU8PtrInt(ReadOnlySpan<byte> labelId, byte[] values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (byte* nativeValues = values)
			{
				ImPlotNative.PlotStairsU8PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
			}
		}

		public static void PlotStairsU8PtrInt(ReadOnlySpan<char> labelId, byte[] values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (byte* nativeValues = values)
			{
				ImPlotNative.PlotStairsU8PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotStairsS16PtrInt(ReadOnlySpan<byte> labelId, short[] values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (short* nativeValues = values)
			{
				ImPlotNative.PlotStairsS16PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
			}
		}

		public static void PlotStairsS16PtrInt(ReadOnlySpan<char> labelId, short[] values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (short* nativeValues = values)
			{
				ImPlotNative.PlotStairsS16PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotStairsU16PtrInt(ReadOnlySpan<byte> labelId, ushort[] values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ushort* nativeValues = values)
			{
				ImPlotNative.PlotStairsU16PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
			}
		}

		public static void PlotStairsU16PtrInt(ReadOnlySpan<char> labelId, ushort[] values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (ushort* nativeValues = values)
			{
				ImPlotNative.PlotStairsU16PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotStairsS32PtrInt(ReadOnlySpan<byte> labelId, int[] values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (int* nativeValues = values)
			{
				ImPlotNative.PlotStairsS32PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
			}
		}

		public static void PlotStairsS32PtrInt(ReadOnlySpan<char> labelId, int[] values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (int* nativeValues = values)
			{
				ImPlotNative.PlotStairsS32PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotStairsU32PtrInt(ReadOnlySpan<byte> labelId, uint[] values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (uint* nativeValues = values)
			{
				ImPlotNative.PlotStairsU32PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
			}
		}

		public static void PlotStairsU32PtrInt(ReadOnlySpan<char> labelId, uint[] values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (uint* nativeValues = values)
			{
				ImPlotNative.PlotStairsU32PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotStairsS64PtrInt(ReadOnlySpan<byte> labelId, long[] values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (long* nativeValues = values)
			{
				ImPlotNative.PlotStairsS64PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
			}
		}

		public static void PlotStairsS64PtrInt(ReadOnlySpan<char> labelId, long[] values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (long* nativeValues = values)
			{
				ImPlotNative.PlotStairsS64PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotStairsU64PtrInt(ReadOnlySpan<byte> labelId, ulong[] values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ulong* nativeValues = values)
			{
				ImPlotNative.PlotStairsU64PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
			}
		}

		public static void PlotStairsU64PtrInt(ReadOnlySpan<char> labelId, ulong[] values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (ulong* nativeValues = values)
			{
				ImPlotNative.PlotStairsU64PtrInt(nativeLabelId, nativeValues, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotStairsFloatPtrFloatPtr(ReadOnlySpan<byte> labelId, float[] xs, float[] ys, int count, ImPlotStairsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (float* nativeXs = xs)
			fixed (float* nativeYs = ys)
			{
				ImPlotNative.PlotStairsFloatPtrFloatPtr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
			}
		}

		public static void PlotStairsFloatPtrFloatPtr(ReadOnlySpan<char> labelId, float[] xs, float[] ys, int count, ImPlotStairsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (float* nativeXs = xs)
			fixed (float* nativeYs = ys)
			{
				ImPlotNative.PlotStairsFloatPtrFloatPtr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotStairsDoublePtrdoublePtr(ReadOnlySpan<byte> labelId, double[] xs, double[] ys, int count, ImPlotStairsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (double* nativeXs = xs)
			fixed (double* nativeYs = ys)
			{
				ImPlotNative.PlotStairsDoublePtrdoublePtr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
			}
		}

		public static void PlotStairsDoublePtrdoublePtr(ReadOnlySpan<char> labelId, double[] xs, double[] ys, int count, ImPlotStairsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (double* nativeXs = xs)
			fixed (double* nativeYs = ys)
			{
				ImPlotNative.PlotStairsDoublePtrdoublePtr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotStairsS8PtrS8Ptr(ReadOnlySpan<byte> labelId, sbyte[] xs, sbyte[] ys, int count, ImPlotStairsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (sbyte* nativeXs = xs)
			fixed (sbyte* nativeYs = ys)
			{
				ImPlotNative.PlotStairsS8PtrS8Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
			}
		}

		public static void PlotStairsS8PtrS8Ptr(ReadOnlySpan<char> labelId, sbyte[] xs, sbyte[] ys, int count, ImPlotStairsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (sbyte* nativeXs = xs)
			fixed (sbyte* nativeYs = ys)
			{
				ImPlotNative.PlotStairsS8PtrS8Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotStairsU8PtrU8Ptr(ReadOnlySpan<byte> labelId, byte[] xs, byte[] ys, int count, ImPlotStairsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (byte* nativeXs = xs)
			fixed (byte* nativeYs = ys)
			{
				ImPlotNative.PlotStairsU8PtrU8Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
			}
		}

		public static void PlotStairsU8PtrU8Ptr(ReadOnlySpan<char> labelId, byte[] xs, byte[] ys, int count, ImPlotStairsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (byte* nativeXs = xs)
			fixed (byte* nativeYs = ys)
			{
				ImPlotNative.PlotStairsU8PtrU8Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotStairsS16PtrS16Ptr(ReadOnlySpan<byte> labelId, short[] xs, short[] ys, int count, ImPlotStairsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (short* nativeXs = xs)
			fixed (short* nativeYs = ys)
			{
				ImPlotNative.PlotStairsS16PtrS16Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
			}
		}

		public static void PlotStairsS16PtrS16Ptr(ReadOnlySpan<char> labelId, short[] xs, short[] ys, int count, ImPlotStairsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (short* nativeXs = xs)
			fixed (short* nativeYs = ys)
			{
				ImPlotNative.PlotStairsS16PtrS16Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotStairsU16PtrU16Ptr(ReadOnlySpan<byte> labelId, ushort[] xs, ushort[] ys, int count, ImPlotStairsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ushort* nativeXs = xs)
			fixed (ushort* nativeYs = ys)
			{
				ImPlotNative.PlotStairsU16PtrU16Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
			}
		}

		public static void PlotStairsU16PtrU16Ptr(ReadOnlySpan<char> labelId, ushort[] xs, ushort[] ys, int count, ImPlotStairsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (ushort* nativeXs = xs)
			fixed (ushort* nativeYs = ys)
			{
				ImPlotNative.PlotStairsU16PtrU16Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotStairsS32PtrS32Ptr(ReadOnlySpan<byte> labelId, int[] xs, int[] ys, int count, ImPlotStairsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (int* nativeXs = xs)
			fixed (int* nativeYs = ys)
			{
				ImPlotNative.PlotStairsS32PtrS32Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
			}
		}

		public static void PlotStairsS32PtrS32Ptr(ReadOnlySpan<char> labelId, int[] xs, int[] ys, int count, ImPlotStairsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (int* nativeXs = xs)
			fixed (int* nativeYs = ys)
			{
				ImPlotNative.PlotStairsS32PtrS32Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotStairsU32PtrU32Ptr(ReadOnlySpan<byte> labelId, uint[] xs, uint[] ys, int count, ImPlotStairsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (uint* nativeXs = xs)
			fixed (uint* nativeYs = ys)
			{
				ImPlotNative.PlotStairsU32PtrU32Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
			}
		}

		public static void PlotStairsU32PtrU32Ptr(ReadOnlySpan<char> labelId, uint[] xs, uint[] ys, int count, ImPlotStairsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (uint* nativeXs = xs)
			fixed (uint* nativeYs = ys)
			{
				ImPlotNative.PlotStairsU32PtrU32Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotStairsS64PtrS64Ptr(ReadOnlySpan<byte> labelId, long[] xs, long[] ys, int count, ImPlotStairsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (long* nativeXs = xs)
			fixed (long* nativeYs = ys)
			{
				ImPlotNative.PlotStairsS64PtrS64Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
			}
		}

		public static void PlotStairsS64PtrS64Ptr(ReadOnlySpan<char> labelId, long[] xs, long[] ys, int count, ImPlotStairsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (long* nativeXs = xs)
			fixed (long* nativeYs = ys)
			{
				ImPlotNative.PlotStairsS64PtrS64Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotStairsU64PtrU64Ptr(ReadOnlySpan<byte> labelId, ulong[] xs, ulong[] ys, int count, ImPlotStairsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ulong* nativeXs = xs)
			fixed (ulong* nativeYs = ys)
			{
				ImPlotNative.PlotStairsU64PtrU64Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
			}
		}

		public static void PlotStairsU64PtrU64Ptr(ReadOnlySpan<char> labelId, ulong[] xs, ulong[] ys, int count, ImPlotStairsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (ulong* nativeXs = xs)
			fixed (ulong* nativeYs = ys)
			{
				ImPlotNative.PlotStairsU64PtrU64Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotStairsG(ReadOnlySpan<byte> labelId, ImPlotPointGetter getter, IntPtr data, int count, ImPlotStairsFlags flags)
		{
			fixed (byte* nativeLabelId = labelId)
			{
				ImPlotNative.PlotStairsG(nativeLabelId, getter, (void*)data, count, flags);
			}
		}

		public static void PlotStairsG(ReadOnlySpan<char> labelId, ImPlotPointGetter getter, IntPtr data, int count, ImPlotStairsFlags flags)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			ImPlotNative.PlotStairsG(nativeLabelId, getter, (void*)data, count, flags);
			// Freeing labelId native string
			if (byteCountLabelId > Utils.MaxStackallocSize)
				Utils.Free(nativeLabelId);
		}

		public static void PlotStairsG(ReadOnlySpan<byte> labelId, ImPlotPointGetter getter, IntPtr data, int count)
		{
			// defining omitted parameters
			ImPlotStairsFlags flags = ImPlotStairsFlags.None;
			fixed (byte* nativeLabelId = labelId)
			{
				ImPlotNative.PlotStairsG(nativeLabelId, getter, (void*)data, count, flags);
			}
		}

		public static void PlotStairsG(ReadOnlySpan<char> labelId, ImPlotPointGetter getter, IntPtr data, int count)
		{
			// defining omitted parameters
			ImPlotStairsFlags flags = ImPlotStairsFlags.None;
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			ImPlotNative.PlotStairsG(nativeLabelId, getter, (void*)data, count, flags);
			// Freeing labelId native string
			if (byteCountLabelId > Utils.MaxStackallocSize)
				Utils.Free(nativeLabelId);
		}

		public static void PlotShadedFloatPtrInt(ReadOnlySpan<byte> labelId, float[] values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (float* nativeValues = values)
			{
				ImPlotNative.PlotShadedFloatPtrInt(nativeLabelId, nativeValues, count, yref, xscale, xstart, flags, offset, stride);
			}
		}

		public static void PlotShadedFloatPtrInt(ReadOnlySpan<char> labelId, float[] values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (float* nativeValues = values)
			{
				ImPlotNative.PlotShadedFloatPtrInt(nativeLabelId, nativeValues, count, yref, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotShadedDoublePtrInt(ReadOnlySpan<byte> labelId, double[] values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (double* nativeValues = values)
			{
				ImPlotNative.PlotShadedDoublePtrInt(nativeLabelId, nativeValues, count, yref, xscale, xstart, flags, offset, stride);
			}
		}

		public static void PlotShadedDoublePtrInt(ReadOnlySpan<char> labelId, double[] values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (double* nativeValues = values)
			{
				ImPlotNative.PlotShadedDoublePtrInt(nativeLabelId, nativeValues, count, yref, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotShadedS8PtrInt(ReadOnlySpan<byte> labelId, sbyte[] values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (sbyte* nativeValues = values)
			{
				ImPlotNative.PlotShadedS8PtrInt(nativeLabelId, nativeValues, count, yref, xscale, xstart, flags, offset, stride);
			}
		}

		public static void PlotShadedS8PtrInt(ReadOnlySpan<char> labelId, sbyte[] values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (sbyte* nativeValues = values)
			{
				ImPlotNative.PlotShadedS8PtrInt(nativeLabelId, nativeValues, count, yref, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotShadedU8PtrInt(ReadOnlySpan<byte> labelId, byte[] values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (byte* nativeValues = values)
			{
				ImPlotNative.PlotShadedU8PtrInt(nativeLabelId, nativeValues, count, yref, xscale, xstart, flags, offset, stride);
			}
		}

		public static void PlotShadedU8PtrInt(ReadOnlySpan<char> labelId, byte[] values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (byte* nativeValues = values)
			{
				ImPlotNative.PlotShadedU8PtrInt(nativeLabelId, nativeValues, count, yref, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotShadedS16PtrInt(ReadOnlySpan<byte> labelId, short[] values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (short* nativeValues = values)
			{
				ImPlotNative.PlotShadedS16PtrInt(nativeLabelId, nativeValues, count, yref, xscale, xstart, flags, offset, stride);
			}
		}

		public static void PlotShadedS16PtrInt(ReadOnlySpan<char> labelId, short[] values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (short* nativeValues = values)
			{
				ImPlotNative.PlotShadedS16PtrInt(nativeLabelId, nativeValues, count, yref, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotShadedU16PtrInt(ReadOnlySpan<byte> labelId, ushort[] values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ushort* nativeValues = values)
			{
				ImPlotNative.PlotShadedU16PtrInt(nativeLabelId, nativeValues, count, yref, xscale, xstart, flags, offset, stride);
			}
		}

		public static void PlotShadedU16PtrInt(ReadOnlySpan<char> labelId, ushort[] values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (ushort* nativeValues = values)
			{
				ImPlotNative.PlotShadedU16PtrInt(nativeLabelId, nativeValues, count, yref, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotShadedS32PtrInt(ReadOnlySpan<byte> labelId, int[] values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (int* nativeValues = values)
			{
				ImPlotNative.PlotShadedS32PtrInt(nativeLabelId, nativeValues, count, yref, xscale, xstart, flags, offset, stride);
			}
		}

		public static void PlotShadedS32PtrInt(ReadOnlySpan<char> labelId, int[] values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (int* nativeValues = values)
			{
				ImPlotNative.PlotShadedS32PtrInt(nativeLabelId, nativeValues, count, yref, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotShadedU32PtrInt(ReadOnlySpan<byte> labelId, uint[] values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (uint* nativeValues = values)
			{
				ImPlotNative.PlotShadedU32PtrInt(nativeLabelId, nativeValues, count, yref, xscale, xstart, flags, offset, stride);
			}
		}

		public static void PlotShadedU32PtrInt(ReadOnlySpan<char> labelId, uint[] values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (uint* nativeValues = values)
			{
				ImPlotNative.PlotShadedU32PtrInt(nativeLabelId, nativeValues, count, yref, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotShadedS64PtrInt(ReadOnlySpan<byte> labelId, long[] values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (long* nativeValues = values)
			{
				ImPlotNative.PlotShadedS64PtrInt(nativeLabelId, nativeValues, count, yref, xscale, xstart, flags, offset, stride);
			}
		}

		public static void PlotShadedS64PtrInt(ReadOnlySpan<char> labelId, long[] values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (long* nativeValues = values)
			{
				ImPlotNative.PlotShadedS64PtrInt(nativeLabelId, nativeValues, count, yref, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotShadedU64PtrInt(ReadOnlySpan<byte> labelId, ulong[] values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ulong* nativeValues = values)
			{
				ImPlotNative.PlotShadedU64PtrInt(nativeLabelId, nativeValues, count, yref, xscale, xstart, flags, offset, stride);
			}
		}

		public static void PlotShadedU64PtrInt(ReadOnlySpan<char> labelId, ulong[] values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (ulong* nativeValues = values)
			{
				ImPlotNative.PlotShadedU64PtrInt(nativeLabelId, nativeValues, count, yref, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotShadedFloatPtrFloatPtrInt(ReadOnlySpan<byte> labelId, float[] xs, float[] ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (float* nativeXs = xs)
			fixed (float* nativeYs = ys)
			{
				ImPlotNative.PlotShadedFloatPtrFloatPtrInt(nativeLabelId, nativeXs, nativeYs, count, yref, flags, offset, stride);
			}
		}

		public static void PlotShadedFloatPtrFloatPtrInt(ReadOnlySpan<char> labelId, float[] xs, float[] ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (float* nativeXs = xs)
			fixed (float* nativeYs = ys)
			{
				ImPlotNative.PlotShadedFloatPtrFloatPtrInt(nativeLabelId, nativeXs, nativeYs, count, yref, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotShadedDoublePtrdoublePtrInt(ReadOnlySpan<byte> labelId, double[] xs, double[] ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (double* nativeXs = xs)
			fixed (double* nativeYs = ys)
			{
				ImPlotNative.PlotShadedDoublePtrdoublePtrInt(nativeLabelId, nativeXs, nativeYs, count, yref, flags, offset, stride);
			}
		}

		public static void PlotShadedDoublePtrdoublePtrInt(ReadOnlySpan<char> labelId, double[] xs, double[] ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (double* nativeXs = xs)
			fixed (double* nativeYs = ys)
			{
				ImPlotNative.PlotShadedDoublePtrdoublePtrInt(nativeLabelId, nativeXs, nativeYs, count, yref, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotShadedS8PtrS8PtrInt(ReadOnlySpan<byte> labelId, sbyte[] xs, sbyte[] ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (sbyte* nativeXs = xs)
			fixed (sbyte* nativeYs = ys)
			{
				ImPlotNative.PlotShadedS8PtrS8PtrInt(nativeLabelId, nativeXs, nativeYs, count, yref, flags, offset, stride);
			}
		}

		public static void PlotShadedS8PtrS8PtrInt(ReadOnlySpan<char> labelId, sbyte[] xs, sbyte[] ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (sbyte* nativeXs = xs)
			fixed (sbyte* nativeYs = ys)
			{
				ImPlotNative.PlotShadedS8PtrS8PtrInt(nativeLabelId, nativeXs, nativeYs, count, yref, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotShadedU8PtrU8PtrInt(ReadOnlySpan<byte> labelId, byte[] xs, byte[] ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (byte* nativeXs = xs)
			fixed (byte* nativeYs = ys)
			{
				ImPlotNative.PlotShadedU8PtrU8PtrInt(nativeLabelId, nativeXs, nativeYs, count, yref, flags, offset, stride);
			}
		}

		public static void PlotShadedU8PtrU8PtrInt(ReadOnlySpan<char> labelId, byte[] xs, byte[] ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (byte* nativeXs = xs)
			fixed (byte* nativeYs = ys)
			{
				ImPlotNative.PlotShadedU8PtrU8PtrInt(nativeLabelId, nativeXs, nativeYs, count, yref, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotShadedS16PtrS16PtrInt(ReadOnlySpan<byte> labelId, short[] xs, short[] ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (short* nativeXs = xs)
			fixed (short* nativeYs = ys)
			{
				ImPlotNative.PlotShadedS16PtrS16PtrInt(nativeLabelId, nativeXs, nativeYs, count, yref, flags, offset, stride);
			}
		}

		public static void PlotShadedS16PtrS16PtrInt(ReadOnlySpan<char> labelId, short[] xs, short[] ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (short* nativeXs = xs)
			fixed (short* nativeYs = ys)
			{
				ImPlotNative.PlotShadedS16PtrS16PtrInt(nativeLabelId, nativeXs, nativeYs, count, yref, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotShadedU16PtrU16PtrInt(ReadOnlySpan<byte> labelId, ushort[] xs, ushort[] ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ushort* nativeXs = xs)
			fixed (ushort* nativeYs = ys)
			{
				ImPlotNative.PlotShadedU16PtrU16PtrInt(nativeLabelId, nativeXs, nativeYs, count, yref, flags, offset, stride);
			}
		}

		public static void PlotShadedU16PtrU16PtrInt(ReadOnlySpan<char> labelId, ushort[] xs, ushort[] ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (ushort* nativeXs = xs)
			fixed (ushort* nativeYs = ys)
			{
				ImPlotNative.PlotShadedU16PtrU16PtrInt(nativeLabelId, nativeXs, nativeYs, count, yref, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotShadedS32PtrS32PtrInt(ReadOnlySpan<byte> labelId, int[] xs, int[] ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (int* nativeXs = xs)
			fixed (int* nativeYs = ys)
			{
				ImPlotNative.PlotShadedS32PtrS32PtrInt(nativeLabelId, nativeXs, nativeYs, count, yref, flags, offset, stride);
			}
		}

		public static void PlotShadedS32PtrS32PtrInt(ReadOnlySpan<char> labelId, int[] xs, int[] ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (int* nativeXs = xs)
			fixed (int* nativeYs = ys)
			{
				ImPlotNative.PlotShadedS32PtrS32PtrInt(nativeLabelId, nativeXs, nativeYs, count, yref, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotShadedU32PtrU32PtrInt(ReadOnlySpan<byte> labelId, uint[] xs, uint[] ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (uint* nativeXs = xs)
			fixed (uint* nativeYs = ys)
			{
				ImPlotNative.PlotShadedU32PtrU32PtrInt(nativeLabelId, nativeXs, nativeYs, count, yref, flags, offset, stride);
			}
		}

		public static void PlotShadedU32PtrU32PtrInt(ReadOnlySpan<char> labelId, uint[] xs, uint[] ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (uint* nativeXs = xs)
			fixed (uint* nativeYs = ys)
			{
				ImPlotNative.PlotShadedU32PtrU32PtrInt(nativeLabelId, nativeXs, nativeYs, count, yref, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotShadedS64PtrS64PtrInt(ReadOnlySpan<byte> labelId, long[] xs, long[] ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (long* nativeXs = xs)
			fixed (long* nativeYs = ys)
			{
				ImPlotNative.PlotShadedS64PtrS64PtrInt(nativeLabelId, nativeXs, nativeYs, count, yref, flags, offset, stride);
			}
		}

		public static void PlotShadedS64PtrS64PtrInt(ReadOnlySpan<char> labelId, long[] xs, long[] ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (long* nativeXs = xs)
			fixed (long* nativeYs = ys)
			{
				ImPlotNative.PlotShadedS64PtrS64PtrInt(nativeLabelId, nativeXs, nativeYs, count, yref, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotShadedU64PtrU64PtrInt(ReadOnlySpan<byte> labelId, ulong[] xs, ulong[] ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ulong* nativeXs = xs)
			fixed (ulong* nativeYs = ys)
			{
				ImPlotNative.PlotShadedU64PtrU64PtrInt(nativeLabelId, nativeXs, nativeYs, count, yref, flags, offset, stride);
			}
		}

		public static void PlotShadedU64PtrU64PtrInt(ReadOnlySpan<char> labelId, ulong[] xs, ulong[] ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (ulong* nativeXs = xs)
			fixed (ulong* nativeYs = ys)
			{
				ImPlotNative.PlotShadedU64PtrU64PtrInt(nativeLabelId, nativeXs, nativeYs, count, yref, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotShadedFloatPtrFloatPtrFloatPtr(ReadOnlySpan<byte> labelId, float[] xs, float[] ys1, float[] ys2, int count, ImPlotShadedFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (float* nativeXs = xs)
			fixed (float* nativeYs1 = ys1)
			fixed (float* nativeYs2 = ys2)
			{
				ImPlotNative.PlotShadedFloatPtrFloatPtrFloatPtr(nativeLabelId, nativeXs, nativeYs1, nativeYs2, count, flags, offset, stride);
			}
		}

		public static void PlotShadedFloatPtrFloatPtrFloatPtr(ReadOnlySpan<char> labelId, float[] xs, float[] ys1, float[] ys2, int count, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (float* nativeXs = xs)
			fixed (float* nativeYs1 = ys1)
			fixed (float* nativeYs2 = ys2)
			{
				ImPlotNative.PlotShadedFloatPtrFloatPtrFloatPtr(nativeLabelId, nativeXs, nativeYs1, nativeYs2, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotShadedDoublePtrdoublePtrdoublePtr(ReadOnlySpan<byte> labelId, double[] xs, double[] ys1, double[] ys2, int count, ImPlotShadedFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (double* nativeXs = xs)
			fixed (double* nativeYs1 = ys1)
			fixed (double* nativeYs2 = ys2)
			{
				ImPlotNative.PlotShadedDoublePtrdoublePtrdoublePtr(nativeLabelId, nativeXs, nativeYs1, nativeYs2, count, flags, offset, stride);
			}
		}

		public static void PlotShadedDoublePtrdoublePtrdoublePtr(ReadOnlySpan<char> labelId, double[] xs, double[] ys1, double[] ys2, int count, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (double* nativeXs = xs)
			fixed (double* nativeYs1 = ys1)
			fixed (double* nativeYs2 = ys2)
			{
				ImPlotNative.PlotShadedDoublePtrdoublePtrdoublePtr(nativeLabelId, nativeXs, nativeYs1, nativeYs2, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotShadedS8PtrS8PtrS8Ptr(ReadOnlySpan<byte> labelId, sbyte[] xs, sbyte[] ys1, sbyte[] ys2, int count, ImPlotShadedFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (sbyte* nativeXs = xs)
			fixed (sbyte* nativeYs1 = ys1)
			fixed (sbyte* nativeYs2 = ys2)
			{
				ImPlotNative.PlotShadedS8PtrS8PtrS8Ptr(nativeLabelId, nativeXs, nativeYs1, nativeYs2, count, flags, offset, stride);
			}
		}

		public static void PlotShadedS8PtrS8PtrS8Ptr(ReadOnlySpan<char> labelId, sbyte[] xs, sbyte[] ys1, sbyte[] ys2, int count, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (sbyte* nativeXs = xs)
			fixed (sbyte* nativeYs1 = ys1)
			fixed (sbyte* nativeYs2 = ys2)
			{
				ImPlotNative.PlotShadedS8PtrS8PtrS8Ptr(nativeLabelId, nativeXs, nativeYs1, nativeYs2, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotShadedU8PtrU8PtrU8Ptr(ReadOnlySpan<byte> labelId, byte[] xs, byte[] ys1, byte[] ys2, int count, ImPlotShadedFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (byte* nativeXs = xs)
			fixed (byte* nativeYs1 = ys1)
			fixed (byte* nativeYs2 = ys2)
			{
				ImPlotNative.PlotShadedU8PtrU8PtrU8Ptr(nativeLabelId, nativeXs, nativeYs1, nativeYs2, count, flags, offset, stride);
			}
		}

		public static void PlotShadedU8PtrU8PtrU8Ptr(ReadOnlySpan<char> labelId, byte[] xs, byte[] ys1, byte[] ys2, int count, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (byte* nativeXs = xs)
			fixed (byte* nativeYs1 = ys1)
			fixed (byte* nativeYs2 = ys2)
			{
				ImPlotNative.PlotShadedU8PtrU8PtrU8Ptr(nativeLabelId, nativeXs, nativeYs1, nativeYs2, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotShadedS16PtrS16PtrS16Ptr(ReadOnlySpan<byte> labelId, short[] xs, short[] ys1, short[] ys2, int count, ImPlotShadedFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (short* nativeXs = xs)
			fixed (short* nativeYs1 = ys1)
			fixed (short* nativeYs2 = ys2)
			{
				ImPlotNative.PlotShadedS16PtrS16PtrS16Ptr(nativeLabelId, nativeXs, nativeYs1, nativeYs2, count, flags, offset, stride);
			}
		}

		public static void PlotShadedS16PtrS16PtrS16Ptr(ReadOnlySpan<char> labelId, short[] xs, short[] ys1, short[] ys2, int count, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (short* nativeXs = xs)
			fixed (short* nativeYs1 = ys1)
			fixed (short* nativeYs2 = ys2)
			{
				ImPlotNative.PlotShadedS16PtrS16PtrS16Ptr(nativeLabelId, nativeXs, nativeYs1, nativeYs2, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotShadedU16PtrU16PtrU16Ptr(ReadOnlySpan<byte> labelId, ushort[] xs, ushort[] ys1, ushort[] ys2, int count, ImPlotShadedFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ushort* nativeXs = xs)
			fixed (ushort* nativeYs1 = ys1)
			fixed (ushort* nativeYs2 = ys2)
			{
				ImPlotNative.PlotShadedU16PtrU16PtrU16Ptr(nativeLabelId, nativeXs, nativeYs1, nativeYs2, count, flags, offset, stride);
			}
		}

		public static void PlotShadedU16PtrU16PtrU16Ptr(ReadOnlySpan<char> labelId, ushort[] xs, ushort[] ys1, ushort[] ys2, int count, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (ushort* nativeXs = xs)
			fixed (ushort* nativeYs1 = ys1)
			fixed (ushort* nativeYs2 = ys2)
			{
				ImPlotNative.PlotShadedU16PtrU16PtrU16Ptr(nativeLabelId, nativeXs, nativeYs1, nativeYs2, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotShadedS32PtrS32PtrS32Ptr(ReadOnlySpan<byte> labelId, int[] xs, int[] ys1, int[] ys2, int count, ImPlotShadedFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (int* nativeXs = xs)
			fixed (int* nativeYs1 = ys1)
			fixed (int* nativeYs2 = ys2)
			{
				ImPlotNative.PlotShadedS32PtrS32PtrS32Ptr(nativeLabelId, nativeXs, nativeYs1, nativeYs2, count, flags, offset, stride);
			}
		}

		public static void PlotShadedS32PtrS32PtrS32Ptr(ReadOnlySpan<char> labelId, int[] xs, int[] ys1, int[] ys2, int count, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (int* nativeXs = xs)
			fixed (int* nativeYs1 = ys1)
			fixed (int* nativeYs2 = ys2)
			{
				ImPlotNative.PlotShadedS32PtrS32PtrS32Ptr(nativeLabelId, nativeXs, nativeYs1, nativeYs2, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotShadedU32PtrU32PtrU32Ptr(ReadOnlySpan<byte> labelId, uint[] xs, uint[] ys1, uint[] ys2, int count, ImPlotShadedFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (uint* nativeXs = xs)
			fixed (uint* nativeYs1 = ys1)
			fixed (uint* nativeYs2 = ys2)
			{
				ImPlotNative.PlotShadedU32PtrU32PtrU32Ptr(nativeLabelId, nativeXs, nativeYs1, nativeYs2, count, flags, offset, stride);
			}
		}

		public static void PlotShadedU32PtrU32PtrU32Ptr(ReadOnlySpan<char> labelId, uint[] xs, uint[] ys1, uint[] ys2, int count, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (uint* nativeXs = xs)
			fixed (uint* nativeYs1 = ys1)
			fixed (uint* nativeYs2 = ys2)
			{
				ImPlotNative.PlotShadedU32PtrU32PtrU32Ptr(nativeLabelId, nativeXs, nativeYs1, nativeYs2, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotShadedS64PtrS64PtrS64Ptr(ReadOnlySpan<byte> labelId, long[] xs, long[] ys1, long[] ys2, int count, ImPlotShadedFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (long* nativeXs = xs)
			fixed (long* nativeYs1 = ys1)
			fixed (long* nativeYs2 = ys2)
			{
				ImPlotNative.PlotShadedS64PtrS64PtrS64Ptr(nativeLabelId, nativeXs, nativeYs1, nativeYs2, count, flags, offset, stride);
			}
		}

		public static void PlotShadedS64PtrS64PtrS64Ptr(ReadOnlySpan<char> labelId, long[] xs, long[] ys1, long[] ys2, int count, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (long* nativeXs = xs)
			fixed (long* nativeYs1 = ys1)
			fixed (long* nativeYs2 = ys2)
			{
				ImPlotNative.PlotShadedS64PtrS64PtrS64Ptr(nativeLabelId, nativeXs, nativeYs1, nativeYs2, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotShadedU64PtrU64PtrU64Ptr(ReadOnlySpan<byte> labelId, ulong[] xs, ulong[] ys1, ulong[] ys2, int count, ImPlotShadedFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ulong* nativeXs = xs)
			fixed (ulong* nativeYs1 = ys1)
			fixed (ulong* nativeYs2 = ys2)
			{
				ImPlotNative.PlotShadedU64PtrU64PtrU64Ptr(nativeLabelId, nativeXs, nativeYs1, nativeYs2, count, flags, offset, stride);
			}
		}

		public static void PlotShadedU64PtrU64PtrU64Ptr(ReadOnlySpan<char> labelId, ulong[] xs, ulong[] ys1, ulong[] ys2, int count, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (ulong* nativeXs = xs)
			fixed (ulong* nativeYs1 = ys1)
			fixed (ulong* nativeYs2 = ys2)
			{
				ImPlotNative.PlotShadedU64PtrU64PtrU64Ptr(nativeLabelId, nativeXs, nativeYs1, nativeYs2, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotShadedG(ReadOnlySpan<byte> labelId, ImPlotPointGetter getter1, IntPtr data1, ImPlotPointGetter getter2, IntPtr data2, int count, ImPlotShadedFlags flags)
		{
			fixed (byte* nativeLabelId = labelId)
			{
				ImPlotNative.PlotShadedG(nativeLabelId, getter1, (void*)data1, getter2, (void*)data2, count, flags);
			}
		}

		public static void PlotShadedG(ReadOnlySpan<char> labelId, ImPlotPointGetter getter1, IntPtr data1, ImPlotPointGetter getter2, IntPtr data2, int count, ImPlotShadedFlags flags)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			ImPlotNative.PlotShadedG(nativeLabelId, getter1, (void*)data1, getter2, (void*)data2, count, flags);
			// Freeing labelId native string
			if (byteCountLabelId > Utils.MaxStackallocSize)
				Utils.Free(nativeLabelId);
		}

		public static void PlotShadedG(ReadOnlySpan<byte> labelId, ImPlotPointGetter getter1, IntPtr data1, ImPlotPointGetter getter2, IntPtr data2, int count)
		{
			// defining omitted parameters
			ImPlotShadedFlags flags = ImPlotShadedFlags.None;
			fixed (byte* nativeLabelId = labelId)
			{
				ImPlotNative.PlotShadedG(nativeLabelId, getter1, (void*)data1, getter2, (void*)data2, count, flags);
			}
		}

		public static void PlotShadedG(ReadOnlySpan<char> labelId, ImPlotPointGetter getter1, IntPtr data1, ImPlotPointGetter getter2, IntPtr data2, int count)
		{
			// defining omitted parameters
			ImPlotShadedFlags flags = ImPlotShadedFlags.None;
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			ImPlotNative.PlotShadedG(nativeLabelId, getter1, (void*)data1, getter2, (void*)data2, count, flags);
			// Freeing labelId native string
			if (byteCountLabelId > Utils.MaxStackallocSize)
				Utils.Free(nativeLabelId);
		}

		public static void PlotBarsFloatPtrInt(ReadOnlySpan<byte> labelId, float[] values, int count, double barSize, double shift, ImPlotBarsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (float* nativeValues = values)
			{
				ImPlotNative.PlotBarsFloatPtrInt(nativeLabelId, nativeValues, count, barSize, shift, flags, offset, stride);
			}
		}

		public static void PlotBarsFloatPtrInt(ReadOnlySpan<char> labelId, float[] values, int count, double barSize, double shift, ImPlotBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (float* nativeValues = values)
			{
				ImPlotNative.PlotBarsFloatPtrInt(nativeLabelId, nativeValues, count, barSize, shift, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotBarsDoublePtrInt(ReadOnlySpan<byte> labelId, double[] values, int count, double barSize, double shift, ImPlotBarsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (double* nativeValues = values)
			{
				ImPlotNative.PlotBarsDoublePtrInt(nativeLabelId, nativeValues, count, barSize, shift, flags, offset, stride);
			}
		}

		public static void PlotBarsDoublePtrInt(ReadOnlySpan<char> labelId, double[] values, int count, double barSize, double shift, ImPlotBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (double* nativeValues = values)
			{
				ImPlotNative.PlotBarsDoublePtrInt(nativeLabelId, nativeValues, count, barSize, shift, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotBarsS8PtrInt(ReadOnlySpan<byte> labelId, sbyte[] values, int count, double barSize, double shift, ImPlotBarsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (sbyte* nativeValues = values)
			{
				ImPlotNative.PlotBarsS8PtrInt(nativeLabelId, nativeValues, count, barSize, shift, flags, offset, stride);
			}
		}

		public static void PlotBarsS8PtrInt(ReadOnlySpan<char> labelId, sbyte[] values, int count, double barSize, double shift, ImPlotBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (sbyte* nativeValues = values)
			{
				ImPlotNative.PlotBarsS8PtrInt(nativeLabelId, nativeValues, count, barSize, shift, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotBarsU8PtrInt(ReadOnlySpan<byte> labelId, byte[] values, int count, double barSize, double shift, ImPlotBarsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (byte* nativeValues = values)
			{
				ImPlotNative.PlotBarsU8PtrInt(nativeLabelId, nativeValues, count, barSize, shift, flags, offset, stride);
			}
		}

		public static void PlotBarsU8PtrInt(ReadOnlySpan<char> labelId, byte[] values, int count, double barSize, double shift, ImPlotBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (byte* nativeValues = values)
			{
				ImPlotNative.PlotBarsU8PtrInt(nativeLabelId, nativeValues, count, barSize, shift, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotBarsS16PtrInt(ReadOnlySpan<byte> labelId, short[] values, int count, double barSize, double shift, ImPlotBarsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (short* nativeValues = values)
			{
				ImPlotNative.PlotBarsS16PtrInt(nativeLabelId, nativeValues, count, barSize, shift, flags, offset, stride);
			}
		}

		public static void PlotBarsS16PtrInt(ReadOnlySpan<char> labelId, short[] values, int count, double barSize, double shift, ImPlotBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (short* nativeValues = values)
			{
				ImPlotNative.PlotBarsS16PtrInt(nativeLabelId, nativeValues, count, barSize, shift, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotBarsU16PtrInt(ReadOnlySpan<byte> labelId, ushort[] values, int count, double barSize, double shift, ImPlotBarsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ushort* nativeValues = values)
			{
				ImPlotNative.PlotBarsU16PtrInt(nativeLabelId, nativeValues, count, barSize, shift, flags, offset, stride);
			}
		}

		public static void PlotBarsU16PtrInt(ReadOnlySpan<char> labelId, ushort[] values, int count, double barSize, double shift, ImPlotBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (ushort* nativeValues = values)
			{
				ImPlotNative.PlotBarsU16PtrInt(nativeLabelId, nativeValues, count, barSize, shift, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotBarsS32PtrInt(ReadOnlySpan<byte> labelId, int[] values, int count, double barSize, double shift, ImPlotBarsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (int* nativeValues = values)
			{
				ImPlotNative.PlotBarsS32PtrInt(nativeLabelId, nativeValues, count, barSize, shift, flags, offset, stride);
			}
		}

		public static void PlotBarsS32PtrInt(ReadOnlySpan<char> labelId, int[] values, int count, double barSize, double shift, ImPlotBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (int* nativeValues = values)
			{
				ImPlotNative.PlotBarsS32PtrInt(nativeLabelId, nativeValues, count, barSize, shift, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotBarsU32PtrInt(ReadOnlySpan<byte> labelId, uint[] values, int count, double barSize, double shift, ImPlotBarsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (uint* nativeValues = values)
			{
				ImPlotNative.PlotBarsU32PtrInt(nativeLabelId, nativeValues, count, barSize, shift, flags, offset, stride);
			}
		}

		public static void PlotBarsU32PtrInt(ReadOnlySpan<char> labelId, uint[] values, int count, double barSize, double shift, ImPlotBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (uint* nativeValues = values)
			{
				ImPlotNative.PlotBarsU32PtrInt(nativeLabelId, nativeValues, count, barSize, shift, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotBarsS64PtrInt(ReadOnlySpan<byte> labelId, long[] values, int count, double barSize, double shift, ImPlotBarsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (long* nativeValues = values)
			{
				ImPlotNative.PlotBarsS64PtrInt(nativeLabelId, nativeValues, count, barSize, shift, flags, offset, stride);
			}
		}

		public static void PlotBarsS64PtrInt(ReadOnlySpan<char> labelId, long[] values, int count, double barSize, double shift, ImPlotBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (long* nativeValues = values)
			{
				ImPlotNative.PlotBarsS64PtrInt(nativeLabelId, nativeValues, count, barSize, shift, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotBarsU64PtrInt(ReadOnlySpan<byte> labelId, ulong[] values, int count, double barSize, double shift, ImPlotBarsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ulong* nativeValues = values)
			{
				ImPlotNative.PlotBarsU64PtrInt(nativeLabelId, nativeValues, count, barSize, shift, flags, offset, stride);
			}
		}

		public static void PlotBarsU64PtrInt(ReadOnlySpan<char> labelId, ulong[] values, int count, double barSize, double shift, ImPlotBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (ulong* nativeValues = values)
			{
				ImPlotNative.PlotBarsU64PtrInt(nativeLabelId, nativeValues, count, barSize, shift, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotBarsFloatPtrFloatPtr(ReadOnlySpan<byte> labelId, float[] xs, float[] ys, int count, double barSize, ImPlotBarsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (float* nativeXs = xs)
			fixed (float* nativeYs = ys)
			{
				ImPlotNative.PlotBarsFloatPtrFloatPtr(nativeLabelId, nativeXs, nativeYs, count, barSize, flags, offset, stride);
			}
		}

		public static void PlotBarsFloatPtrFloatPtr(ReadOnlySpan<char> labelId, float[] xs, float[] ys, int count, double barSize, ImPlotBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (float* nativeXs = xs)
			fixed (float* nativeYs = ys)
			{
				ImPlotNative.PlotBarsFloatPtrFloatPtr(nativeLabelId, nativeXs, nativeYs, count, barSize, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotBarsDoublePtrdoublePtr(ReadOnlySpan<byte> labelId, double[] xs, double[] ys, int count, double barSize, ImPlotBarsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (double* nativeXs = xs)
			fixed (double* nativeYs = ys)
			{
				ImPlotNative.PlotBarsDoublePtrdoublePtr(nativeLabelId, nativeXs, nativeYs, count, barSize, flags, offset, stride);
			}
		}

		public static void PlotBarsDoublePtrdoublePtr(ReadOnlySpan<char> labelId, double[] xs, double[] ys, int count, double barSize, ImPlotBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (double* nativeXs = xs)
			fixed (double* nativeYs = ys)
			{
				ImPlotNative.PlotBarsDoublePtrdoublePtr(nativeLabelId, nativeXs, nativeYs, count, barSize, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotBarsS8PtrS8Ptr(ReadOnlySpan<byte> labelId, sbyte[] xs, sbyte[] ys, int count, double barSize, ImPlotBarsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (sbyte* nativeXs = xs)
			fixed (sbyte* nativeYs = ys)
			{
				ImPlotNative.PlotBarsS8PtrS8Ptr(nativeLabelId, nativeXs, nativeYs, count, barSize, flags, offset, stride);
			}
		}

		public static void PlotBarsS8PtrS8Ptr(ReadOnlySpan<char> labelId, sbyte[] xs, sbyte[] ys, int count, double barSize, ImPlotBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (sbyte* nativeXs = xs)
			fixed (sbyte* nativeYs = ys)
			{
				ImPlotNative.PlotBarsS8PtrS8Ptr(nativeLabelId, nativeXs, nativeYs, count, barSize, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotBarsU8PtrU8Ptr(ReadOnlySpan<byte> labelId, byte[] xs, byte[] ys, int count, double barSize, ImPlotBarsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (byte* nativeXs = xs)
			fixed (byte* nativeYs = ys)
			{
				ImPlotNative.PlotBarsU8PtrU8Ptr(nativeLabelId, nativeXs, nativeYs, count, barSize, flags, offset, stride);
			}
		}

		public static void PlotBarsU8PtrU8Ptr(ReadOnlySpan<char> labelId, byte[] xs, byte[] ys, int count, double barSize, ImPlotBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (byte* nativeXs = xs)
			fixed (byte* nativeYs = ys)
			{
				ImPlotNative.PlotBarsU8PtrU8Ptr(nativeLabelId, nativeXs, nativeYs, count, barSize, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotBarsS16PtrS16Ptr(ReadOnlySpan<byte> labelId, short[] xs, short[] ys, int count, double barSize, ImPlotBarsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (short* nativeXs = xs)
			fixed (short* nativeYs = ys)
			{
				ImPlotNative.PlotBarsS16PtrS16Ptr(nativeLabelId, nativeXs, nativeYs, count, barSize, flags, offset, stride);
			}
		}

		public static void PlotBarsS16PtrS16Ptr(ReadOnlySpan<char> labelId, short[] xs, short[] ys, int count, double barSize, ImPlotBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (short* nativeXs = xs)
			fixed (short* nativeYs = ys)
			{
				ImPlotNative.PlotBarsS16PtrS16Ptr(nativeLabelId, nativeXs, nativeYs, count, barSize, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotBarsU16PtrU16Ptr(ReadOnlySpan<byte> labelId, ushort[] xs, ushort[] ys, int count, double barSize, ImPlotBarsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ushort* nativeXs = xs)
			fixed (ushort* nativeYs = ys)
			{
				ImPlotNative.PlotBarsU16PtrU16Ptr(nativeLabelId, nativeXs, nativeYs, count, barSize, flags, offset, stride);
			}
		}

		public static void PlotBarsU16PtrU16Ptr(ReadOnlySpan<char> labelId, ushort[] xs, ushort[] ys, int count, double barSize, ImPlotBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (ushort* nativeXs = xs)
			fixed (ushort* nativeYs = ys)
			{
				ImPlotNative.PlotBarsU16PtrU16Ptr(nativeLabelId, nativeXs, nativeYs, count, barSize, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotBarsS32PtrS32Ptr(ReadOnlySpan<byte> labelId, int[] xs, int[] ys, int count, double barSize, ImPlotBarsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (int* nativeXs = xs)
			fixed (int* nativeYs = ys)
			{
				ImPlotNative.PlotBarsS32PtrS32Ptr(nativeLabelId, nativeXs, nativeYs, count, barSize, flags, offset, stride);
			}
		}

		public static void PlotBarsS32PtrS32Ptr(ReadOnlySpan<char> labelId, int[] xs, int[] ys, int count, double barSize, ImPlotBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (int* nativeXs = xs)
			fixed (int* nativeYs = ys)
			{
				ImPlotNative.PlotBarsS32PtrS32Ptr(nativeLabelId, nativeXs, nativeYs, count, barSize, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotBarsU32PtrU32Ptr(ReadOnlySpan<byte> labelId, uint[] xs, uint[] ys, int count, double barSize, ImPlotBarsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (uint* nativeXs = xs)
			fixed (uint* nativeYs = ys)
			{
				ImPlotNative.PlotBarsU32PtrU32Ptr(nativeLabelId, nativeXs, nativeYs, count, barSize, flags, offset, stride);
			}
		}

		public static void PlotBarsU32PtrU32Ptr(ReadOnlySpan<char> labelId, uint[] xs, uint[] ys, int count, double barSize, ImPlotBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (uint* nativeXs = xs)
			fixed (uint* nativeYs = ys)
			{
				ImPlotNative.PlotBarsU32PtrU32Ptr(nativeLabelId, nativeXs, nativeYs, count, barSize, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotBarsS64PtrS64Ptr(ReadOnlySpan<byte> labelId, long[] xs, long[] ys, int count, double barSize, ImPlotBarsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (long* nativeXs = xs)
			fixed (long* nativeYs = ys)
			{
				ImPlotNative.PlotBarsS64PtrS64Ptr(nativeLabelId, nativeXs, nativeYs, count, barSize, flags, offset, stride);
			}
		}

		public static void PlotBarsS64PtrS64Ptr(ReadOnlySpan<char> labelId, long[] xs, long[] ys, int count, double barSize, ImPlotBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (long* nativeXs = xs)
			fixed (long* nativeYs = ys)
			{
				ImPlotNative.PlotBarsS64PtrS64Ptr(nativeLabelId, nativeXs, nativeYs, count, barSize, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotBarsU64PtrU64Ptr(ReadOnlySpan<byte> labelId, ulong[] xs, ulong[] ys, int count, double barSize, ImPlotBarsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ulong* nativeXs = xs)
			fixed (ulong* nativeYs = ys)
			{
				ImPlotNative.PlotBarsU64PtrU64Ptr(nativeLabelId, nativeXs, nativeYs, count, barSize, flags, offset, stride);
			}
		}

		public static void PlotBarsU64PtrU64Ptr(ReadOnlySpan<char> labelId, ulong[] xs, ulong[] ys, int count, double barSize, ImPlotBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (ulong* nativeXs = xs)
			fixed (ulong* nativeYs = ys)
			{
				ImPlotNative.PlotBarsU64PtrU64Ptr(nativeLabelId, nativeXs, nativeYs, count, barSize, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotBarsG(ReadOnlySpan<byte> labelId, ImPlotPointGetter getter, IntPtr data, int count, double barSize, ImPlotBarsFlags flags)
		{
			fixed (byte* nativeLabelId = labelId)
			{
				ImPlotNative.PlotBarsG(nativeLabelId, getter, (void*)data, count, barSize, flags);
			}
		}

		public static void PlotBarsG(ReadOnlySpan<char> labelId, ImPlotPointGetter getter, IntPtr data, int count, double barSize, ImPlotBarsFlags flags)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			ImPlotNative.PlotBarsG(nativeLabelId, getter, (void*)data, count, barSize, flags);
			// Freeing labelId native string
			if (byteCountLabelId > Utils.MaxStackallocSize)
				Utils.Free(nativeLabelId);
		}

		public static void PlotBarsG(ReadOnlySpan<byte> labelId, ImPlotPointGetter getter, IntPtr data, int count, double barSize)
		{
			// defining omitted parameters
			ImPlotBarsFlags flags = ImPlotBarsFlags.None;
			fixed (byte* nativeLabelId = labelId)
			{
				ImPlotNative.PlotBarsG(nativeLabelId, getter, (void*)data, count, barSize, flags);
			}
		}

		public static void PlotBarsG(ReadOnlySpan<char> labelId, ImPlotPointGetter getter, IntPtr data, int count, double barSize)
		{
			// defining omitted parameters
			ImPlotBarsFlags flags = ImPlotBarsFlags.None;
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			ImPlotNative.PlotBarsG(nativeLabelId, getter, (void*)data, count, barSize, flags);
			// Freeing labelId native string
			if (byteCountLabelId > Utils.MaxStackallocSize)
				Utils.Free(nativeLabelId);
		}

		public static void PlotBarGroupsFloatPtr(ref byte* labelIds, float[] values, int itemCount, int groupCount, double groupSize, double shift, ImPlotBarGroupsFlags flags)
		{
			fixed (byte** nativeLabelIds = &labelIds)
			fixed (float* nativeValues = values)
			{
				ImPlotNative.PlotBarGroupsFloatPtr(nativeLabelIds, nativeValues, itemCount, groupCount, groupSize, shift, flags);
			}
		}

		public static void PlotBarGroupsDoublePtr(ref byte* labelIds, double[] values, int itemCount, int groupCount, double groupSize, double shift, ImPlotBarGroupsFlags flags)
		{
			fixed (byte** nativeLabelIds = &labelIds)
			fixed (double* nativeValues = values)
			{
				ImPlotNative.PlotBarGroupsDoublePtr(nativeLabelIds, nativeValues, itemCount, groupCount, groupSize, shift, flags);
			}
		}

		public static void PlotBarGroupsS8Ptr(ref byte* labelIds, sbyte[] values, int itemCount, int groupCount, double groupSize, double shift, ImPlotBarGroupsFlags flags)
		{
			fixed (byte** nativeLabelIds = &labelIds)
			fixed (sbyte* nativeValues = values)
			{
				ImPlotNative.PlotBarGroupsS8Ptr(nativeLabelIds, nativeValues, itemCount, groupCount, groupSize, shift, flags);
			}
		}

		public static void PlotBarGroupsU8Ptr(ref byte* labelIds, byte[] values, int itemCount, int groupCount, double groupSize, double shift, ImPlotBarGroupsFlags flags)
		{
			fixed (byte** nativeLabelIds = &labelIds)
			fixed (byte* nativeValues = values)
			{
				ImPlotNative.PlotBarGroupsU8Ptr(nativeLabelIds, nativeValues, itemCount, groupCount, groupSize, shift, flags);
			}
		}

		public static void PlotBarGroupsS16Ptr(ref byte* labelIds, short[] values, int itemCount, int groupCount, double groupSize, double shift, ImPlotBarGroupsFlags flags)
		{
			fixed (byte** nativeLabelIds = &labelIds)
			fixed (short* nativeValues = values)
			{
				ImPlotNative.PlotBarGroupsS16Ptr(nativeLabelIds, nativeValues, itemCount, groupCount, groupSize, shift, flags);
			}
		}

		public static void PlotBarGroupsU16Ptr(ref byte* labelIds, ushort[] values, int itemCount, int groupCount, double groupSize, double shift, ImPlotBarGroupsFlags flags)
		{
			fixed (byte** nativeLabelIds = &labelIds)
			fixed (ushort* nativeValues = values)
			{
				ImPlotNative.PlotBarGroupsU16Ptr(nativeLabelIds, nativeValues, itemCount, groupCount, groupSize, shift, flags);
			}
		}

		public static void PlotBarGroupsS32Ptr(ref byte* labelIds, int[] values, int itemCount, int groupCount, double groupSize, double shift, ImPlotBarGroupsFlags flags)
		{
			fixed (byte** nativeLabelIds = &labelIds)
			fixed (int* nativeValues = values)
			{
				ImPlotNative.PlotBarGroupsS32Ptr(nativeLabelIds, nativeValues, itemCount, groupCount, groupSize, shift, flags);
			}
		}

		public static void PlotBarGroupsU32Ptr(ref byte* labelIds, uint[] values, int itemCount, int groupCount, double groupSize, double shift, ImPlotBarGroupsFlags flags)
		{
			fixed (byte** nativeLabelIds = &labelIds)
			fixed (uint* nativeValues = values)
			{
				ImPlotNative.PlotBarGroupsU32Ptr(nativeLabelIds, nativeValues, itemCount, groupCount, groupSize, shift, flags);
			}
		}

		public static void PlotBarGroupsS64Ptr(ref byte* labelIds, long[] values, int itemCount, int groupCount, double groupSize, double shift, ImPlotBarGroupsFlags flags)
		{
			fixed (byte** nativeLabelIds = &labelIds)
			fixed (long* nativeValues = values)
			{
				ImPlotNative.PlotBarGroupsS64Ptr(nativeLabelIds, nativeValues, itemCount, groupCount, groupSize, shift, flags);
			}
		}

		public static void PlotBarGroupsU64Ptr(ref byte* labelIds, ulong[] values, int itemCount, int groupCount, double groupSize, double shift, ImPlotBarGroupsFlags flags)
		{
			fixed (byte** nativeLabelIds = &labelIds)
			fixed (ulong* nativeValues = values)
			{
				ImPlotNative.PlotBarGroupsU64Ptr(nativeLabelIds, nativeValues, itemCount, groupCount, groupSize, shift, flags);
			}
		}

		public static void PlotErrorBarsFloatPtrFloatPtrFloatPtrInt(ReadOnlySpan<byte> labelId, float[] xs, float[] ys, float[] err, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (float* nativeXs = xs)
			fixed (float* nativeYs = ys)
			fixed (float* nativeErr = err)
			{
				ImPlotNative.PlotErrorBarsFloatPtrFloatPtrFloatPtrInt(nativeLabelId, nativeXs, nativeYs, nativeErr, count, flags, offset, stride);
			}
		}

		public static void PlotErrorBarsFloatPtrFloatPtrFloatPtrInt(ReadOnlySpan<char> labelId, float[] xs, float[] ys, float[] err, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (float* nativeXs = xs)
			fixed (float* nativeYs = ys)
			fixed (float* nativeErr = err)
			{
				ImPlotNative.PlotErrorBarsFloatPtrFloatPtrFloatPtrInt(nativeLabelId, nativeXs, nativeYs, nativeErr, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotErrorBarsDoublePtrdoublePtrdoublePtrInt(ReadOnlySpan<byte> labelId, double[] xs, double[] ys, double[] err, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (double* nativeXs = xs)
			fixed (double* nativeYs = ys)
			fixed (double* nativeErr = err)
			{
				ImPlotNative.PlotErrorBarsDoublePtrdoublePtrdoublePtrInt(nativeLabelId, nativeXs, nativeYs, nativeErr, count, flags, offset, stride);
			}
		}

		public static void PlotErrorBarsDoublePtrdoublePtrdoublePtrInt(ReadOnlySpan<char> labelId, double[] xs, double[] ys, double[] err, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (double* nativeXs = xs)
			fixed (double* nativeYs = ys)
			fixed (double* nativeErr = err)
			{
				ImPlotNative.PlotErrorBarsDoublePtrdoublePtrdoublePtrInt(nativeLabelId, nativeXs, nativeYs, nativeErr, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotErrorBarsS8PtrS8PtrS8PtrInt(ReadOnlySpan<byte> labelId, sbyte[] xs, sbyte[] ys, sbyte[] err, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (sbyte* nativeXs = xs)
			fixed (sbyte* nativeYs = ys)
			fixed (sbyte* nativeErr = err)
			{
				ImPlotNative.PlotErrorBarsS8PtrS8PtrS8PtrInt(nativeLabelId, nativeXs, nativeYs, nativeErr, count, flags, offset, stride);
			}
		}

		public static void PlotErrorBarsS8PtrS8PtrS8PtrInt(ReadOnlySpan<char> labelId, sbyte[] xs, sbyte[] ys, sbyte[] err, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (sbyte* nativeXs = xs)
			fixed (sbyte* nativeYs = ys)
			fixed (sbyte* nativeErr = err)
			{
				ImPlotNative.PlotErrorBarsS8PtrS8PtrS8PtrInt(nativeLabelId, nativeXs, nativeYs, nativeErr, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotErrorBarsU8PtrU8PtrU8PtrInt(ReadOnlySpan<byte> labelId, byte[] xs, byte[] ys, byte[] err, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (byte* nativeXs = xs)
			fixed (byte* nativeYs = ys)
			fixed (byte* nativeErr = err)
			{
				ImPlotNative.PlotErrorBarsU8PtrU8PtrU8PtrInt(nativeLabelId, nativeXs, nativeYs, nativeErr, count, flags, offset, stride);
			}
		}

		public static void PlotErrorBarsU8PtrU8PtrU8PtrInt(ReadOnlySpan<char> labelId, byte[] xs, byte[] ys, byte[] err, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (byte* nativeXs = xs)
			fixed (byte* nativeYs = ys)
			fixed (byte* nativeErr = err)
			{
				ImPlotNative.PlotErrorBarsU8PtrU8PtrU8PtrInt(nativeLabelId, nativeXs, nativeYs, nativeErr, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotErrorBarsS16PtrS16PtrS16PtrInt(ReadOnlySpan<byte> labelId, short[] xs, short[] ys, short[] err, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (short* nativeXs = xs)
			fixed (short* nativeYs = ys)
			fixed (short* nativeErr = err)
			{
				ImPlotNative.PlotErrorBarsS16PtrS16PtrS16PtrInt(nativeLabelId, nativeXs, nativeYs, nativeErr, count, flags, offset, stride);
			}
		}

		public static void PlotErrorBarsS16PtrS16PtrS16PtrInt(ReadOnlySpan<char> labelId, short[] xs, short[] ys, short[] err, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (short* nativeXs = xs)
			fixed (short* nativeYs = ys)
			fixed (short* nativeErr = err)
			{
				ImPlotNative.PlotErrorBarsS16PtrS16PtrS16PtrInt(nativeLabelId, nativeXs, nativeYs, nativeErr, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotErrorBarsU16PtrU16PtrU16PtrInt(ReadOnlySpan<byte> labelId, ushort[] xs, ushort[] ys, ushort[] err, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ushort* nativeXs = xs)
			fixed (ushort* nativeYs = ys)
			fixed (ushort* nativeErr = err)
			{
				ImPlotNative.PlotErrorBarsU16PtrU16PtrU16PtrInt(nativeLabelId, nativeXs, nativeYs, nativeErr, count, flags, offset, stride);
			}
		}

		public static void PlotErrorBarsU16PtrU16PtrU16PtrInt(ReadOnlySpan<char> labelId, ushort[] xs, ushort[] ys, ushort[] err, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (ushort* nativeXs = xs)
			fixed (ushort* nativeYs = ys)
			fixed (ushort* nativeErr = err)
			{
				ImPlotNative.PlotErrorBarsU16PtrU16PtrU16PtrInt(nativeLabelId, nativeXs, nativeYs, nativeErr, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotErrorBarsS32PtrS32PtrS32PtrInt(ReadOnlySpan<byte> labelId, int[] xs, int[] ys, int[] err, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (int* nativeXs = xs)
			fixed (int* nativeYs = ys)
			fixed (int* nativeErr = err)
			{
				ImPlotNative.PlotErrorBarsS32PtrS32PtrS32PtrInt(nativeLabelId, nativeXs, nativeYs, nativeErr, count, flags, offset, stride);
			}
		}

		public static void PlotErrorBarsS32PtrS32PtrS32PtrInt(ReadOnlySpan<char> labelId, int[] xs, int[] ys, int[] err, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (int* nativeXs = xs)
			fixed (int* nativeYs = ys)
			fixed (int* nativeErr = err)
			{
				ImPlotNative.PlotErrorBarsS32PtrS32PtrS32PtrInt(nativeLabelId, nativeXs, nativeYs, nativeErr, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotErrorBarsU32PtrU32PtrU32PtrInt(ReadOnlySpan<byte> labelId, uint[] xs, uint[] ys, uint[] err, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (uint* nativeXs = xs)
			fixed (uint* nativeYs = ys)
			fixed (uint* nativeErr = err)
			{
				ImPlotNative.PlotErrorBarsU32PtrU32PtrU32PtrInt(nativeLabelId, nativeXs, nativeYs, nativeErr, count, flags, offset, stride);
			}
		}

		public static void PlotErrorBarsU32PtrU32PtrU32PtrInt(ReadOnlySpan<char> labelId, uint[] xs, uint[] ys, uint[] err, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (uint* nativeXs = xs)
			fixed (uint* nativeYs = ys)
			fixed (uint* nativeErr = err)
			{
				ImPlotNative.PlotErrorBarsU32PtrU32PtrU32PtrInt(nativeLabelId, nativeXs, nativeYs, nativeErr, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotErrorBarsS64PtrS64PtrS64PtrInt(ReadOnlySpan<byte> labelId, long[] xs, long[] ys, long[] err, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (long* nativeXs = xs)
			fixed (long* nativeYs = ys)
			fixed (long* nativeErr = err)
			{
				ImPlotNative.PlotErrorBarsS64PtrS64PtrS64PtrInt(nativeLabelId, nativeXs, nativeYs, nativeErr, count, flags, offset, stride);
			}
		}

		public static void PlotErrorBarsS64PtrS64PtrS64PtrInt(ReadOnlySpan<char> labelId, long[] xs, long[] ys, long[] err, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (long* nativeXs = xs)
			fixed (long* nativeYs = ys)
			fixed (long* nativeErr = err)
			{
				ImPlotNative.PlotErrorBarsS64PtrS64PtrS64PtrInt(nativeLabelId, nativeXs, nativeYs, nativeErr, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotErrorBarsU64PtrU64PtrU64PtrInt(ReadOnlySpan<byte> labelId, ulong[] xs, ulong[] ys, ulong[] err, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ulong* nativeXs = xs)
			fixed (ulong* nativeYs = ys)
			fixed (ulong* nativeErr = err)
			{
				ImPlotNative.PlotErrorBarsU64PtrU64PtrU64PtrInt(nativeLabelId, nativeXs, nativeYs, nativeErr, count, flags, offset, stride);
			}
		}

		public static void PlotErrorBarsU64PtrU64PtrU64PtrInt(ReadOnlySpan<char> labelId, ulong[] xs, ulong[] ys, ulong[] err, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (ulong* nativeXs = xs)
			fixed (ulong* nativeYs = ys)
			fixed (ulong* nativeErr = err)
			{
				ImPlotNative.PlotErrorBarsU64PtrU64PtrU64PtrInt(nativeLabelId, nativeXs, nativeYs, nativeErr, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotErrorBarsFloatPtrFloatPtrFloatPtrFloatPtr(ReadOnlySpan<byte> labelId, float[] xs, float[] ys, float[] neg, float[] pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (float* nativeXs = xs)
			fixed (float* nativeYs = ys)
			fixed (float* nativeNeg = neg)
			fixed (float* nativePos = pos)
			{
				ImPlotNative.PlotErrorBarsFloatPtrFloatPtrFloatPtrFloatPtr(nativeLabelId, nativeXs, nativeYs, nativeNeg, nativePos, count, flags, offset, stride);
			}
		}

		public static void PlotErrorBarsFloatPtrFloatPtrFloatPtrFloatPtr(ReadOnlySpan<char> labelId, float[] xs, float[] ys, float[] neg, float[] pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (float* nativeXs = xs)
			fixed (float* nativeYs = ys)
			fixed (float* nativeNeg = neg)
			fixed (float* nativePos = pos)
			{
				ImPlotNative.PlotErrorBarsFloatPtrFloatPtrFloatPtrFloatPtr(nativeLabelId, nativeXs, nativeYs, nativeNeg, nativePos, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotErrorBarsDoublePtrdoublePtrdoublePtrdoublePtr(ReadOnlySpan<byte> labelId, double[] xs, double[] ys, double[] neg, double[] pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (double* nativeXs = xs)
			fixed (double* nativeYs = ys)
			fixed (double* nativeNeg = neg)
			fixed (double* nativePos = pos)
			{
				ImPlotNative.PlotErrorBarsDoublePtrdoublePtrdoublePtrdoublePtr(nativeLabelId, nativeXs, nativeYs, nativeNeg, nativePos, count, flags, offset, stride);
			}
		}

		public static void PlotErrorBarsDoublePtrdoublePtrdoublePtrdoublePtr(ReadOnlySpan<char> labelId, double[] xs, double[] ys, double[] neg, double[] pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (double* nativeXs = xs)
			fixed (double* nativeYs = ys)
			fixed (double* nativeNeg = neg)
			fixed (double* nativePos = pos)
			{
				ImPlotNative.PlotErrorBarsDoublePtrdoublePtrdoublePtrdoublePtr(nativeLabelId, nativeXs, nativeYs, nativeNeg, nativePos, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotErrorBarsS8PtrS8PtrS8PtrS8Ptr(ReadOnlySpan<byte> labelId, sbyte[] xs, sbyte[] ys, sbyte[] neg, sbyte[] pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (sbyte* nativeXs = xs)
			fixed (sbyte* nativeYs = ys)
			fixed (sbyte* nativeNeg = neg)
			fixed (sbyte* nativePos = pos)
			{
				ImPlotNative.PlotErrorBarsS8PtrS8PtrS8PtrS8Ptr(nativeLabelId, nativeXs, nativeYs, nativeNeg, nativePos, count, flags, offset, stride);
			}
		}

		public static void PlotErrorBarsS8PtrS8PtrS8PtrS8Ptr(ReadOnlySpan<char> labelId, sbyte[] xs, sbyte[] ys, sbyte[] neg, sbyte[] pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (sbyte* nativeXs = xs)
			fixed (sbyte* nativeYs = ys)
			fixed (sbyte* nativeNeg = neg)
			fixed (sbyte* nativePos = pos)
			{
				ImPlotNative.PlotErrorBarsS8PtrS8PtrS8PtrS8Ptr(nativeLabelId, nativeXs, nativeYs, nativeNeg, nativePos, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotErrorBarsU8PtrU8PtrU8PtrU8Ptr(ReadOnlySpan<byte> labelId, byte[] xs, byte[] ys, byte[] neg, byte[] pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (byte* nativeXs = xs)
			fixed (byte* nativeYs = ys)
			fixed (byte* nativeNeg = neg)
			fixed (byte* nativePos = pos)
			{
				ImPlotNative.PlotErrorBarsU8PtrU8PtrU8PtrU8Ptr(nativeLabelId, nativeXs, nativeYs, nativeNeg, nativePos, count, flags, offset, stride);
			}
		}

		public static void PlotErrorBarsU8PtrU8PtrU8PtrU8Ptr(ReadOnlySpan<char> labelId, byte[] xs, byte[] ys, byte[] neg, byte[] pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (byte* nativeXs = xs)
			fixed (byte* nativeYs = ys)
			fixed (byte* nativeNeg = neg)
			fixed (byte* nativePos = pos)
			{
				ImPlotNative.PlotErrorBarsU8PtrU8PtrU8PtrU8Ptr(nativeLabelId, nativeXs, nativeYs, nativeNeg, nativePos, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotErrorBarsS16PtrS16PtrS16PtrS16Ptr(ReadOnlySpan<byte> labelId, short[] xs, short[] ys, short[] neg, short[] pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (short* nativeXs = xs)
			fixed (short* nativeYs = ys)
			fixed (short* nativeNeg = neg)
			fixed (short* nativePos = pos)
			{
				ImPlotNative.PlotErrorBarsS16PtrS16PtrS16PtrS16Ptr(nativeLabelId, nativeXs, nativeYs, nativeNeg, nativePos, count, flags, offset, stride);
			}
		}

		public static void PlotErrorBarsS16PtrS16PtrS16PtrS16Ptr(ReadOnlySpan<char> labelId, short[] xs, short[] ys, short[] neg, short[] pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (short* nativeXs = xs)
			fixed (short* nativeYs = ys)
			fixed (short* nativeNeg = neg)
			fixed (short* nativePos = pos)
			{
				ImPlotNative.PlotErrorBarsS16PtrS16PtrS16PtrS16Ptr(nativeLabelId, nativeXs, nativeYs, nativeNeg, nativePos, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotErrorBarsU16PtrU16PtrU16PtrU16Ptr(ReadOnlySpan<byte> labelId, ushort[] xs, ushort[] ys, ushort[] neg, ushort[] pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ushort* nativeXs = xs)
			fixed (ushort* nativeYs = ys)
			fixed (ushort* nativeNeg = neg)
			fixed (ushort* nativePos = pos)
			{
				ImPlotNative.PlotErrorBarsU16PtrU16PtrU16PtrU16Ptr(nativeLabelId, nativeXs, nativeYs, nativeNeg, nativePos, count, flags, offset, stride);
			}
		}

		public static void PlotErrorBarsU16PtrU16PtrU16PtrU16Ptr(ReadOnlySpan<char> labelId, ushort[] xs, ushort[] ys, ushort[] neg, ushort[] pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (ushort* nativeXs = xs)
			fixed (ushort* nativeYs = ys)
			fixed (ushort* nativeNeg = neg)
			fixed (ushort* nativePos = pos)
			{
				ImPlotNative.PlotErrorBarsU16PtrU16PtrU16PtrU16Ptr(nativeLabelId, nativeXs, nativeYs, nativeNeg, nativePos, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotErrorBarsS32PtrS32PtrS32PtrS32Ptr(ReadOnlySpan<byte> labelId, int[] xs, int[] ys, int[] neg, int[] pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (int* nativeXs = xs)
			fixed (int* nativeYs = ys)
			fixed (int* nativeNeg = neg)
			fixed (int* nativePos = pos)
			{
				ImPlotNative.PlotErrorBarsS32PtrS32PtrS32PtrS32Ptr(nativeLabelId, nativeXs, nativeYs, nativeNeg, nativePos, count, flags, offset, stride);
			}
		}

		public static void PlotErrorBarsS32PtrS32PtrS32PtrS32Ptr(ReadOnlySpan<char> labelId, int[] xs, int[] ys, int[] neg, int[] pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (int* nativeXs = xs)
			fixed (int* nativeYs = ys)
			fixed (int* nativeNeg = neg)
			fixed (int* nativePos = pos)
			{
				ImPlotNative.PlotErrorBarsS32PtrS32PtrS32PtrS32Ptr(nativeLabelId, nativeXs, nativeYs, nativeNeg, nativePos, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotErrorBarsU32PtrU32PtrU32PtrU32Ptr(ReadOnlySpan<byte> labelId, uint[] xs, uint[] ys, uint[] neg, uint[] pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (uint* nativeXs = xs)
			fixed (uint* nativeYs = ys)
			fixed (uint* nativeNeg = neg)
			fixed (uint* nativePos = pos)
			{
				ImPlotNative.PlotErrorBarsU32PtrU32PtrU32PtrU32Ptr(nativeLabelId, nativeXs, nativeYs, nativeNeg, nativePos, count, flags, offset, stride);
			}
		}

		public static void PlotErrorBarsU32PtrU32PtrU32PtrU32Ptr(ReadOnlySpan<char> labelId, uint[] xs, uint[] ys, uint[] neg, uint[] pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (uint* nativeXs = xs)
			fixed (uint* nativeYs = ys)
			fixed (uint* nativeNeg = neg)
			fixed (uint* nativePos = pos)
			{
				ImPlotNative.PlotErrorBarsU32PtrU32PtrU32PtrU32Ptr(nativeLabelId, nativeXs, nativeYs, nativeNeg, nativePos, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotErrorBarsS64PtrS64PtrS64PtrS64Ptr(ReadOnlySpan<byte> labelId, long[] xs, long[] ys, long[] neg, long[] pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (long* nativeXs = xs)
			fixed (long* nativeYs = ys)
			fixed (long* nativeNeg = neg)
			fixed (long* nativePos = pos)
			{
				ImPlotNative.PlotErrorBarsS64PtrS64PtrS64PtrS64Ptr(nativeLabelId, nativeXs, nativeYs, nativeNeg, nativePos, count, flags, offset, stride);
			}
		}

		public static void PlotErrorBarsS64PtrS64PtrS64PtrS64Ptr(ReadOnlySpan<char> labelId, long[] xs, long[] ys, long[] neg, long[] pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (long* nativeXs = xs)
			fixed (long* nativeYs = ys)
			fixed (long* nativeNeg = neg)
			fixed (long* nativePos = pos)
			{
				ImPlotNative.PlotErrorBarsS64PtrS64PtrS64PtrS64Ptr(nativeLabelId, nativeXs, nativeYs, nativeNeg, nativePos, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotErrorBarsU64PtrU64PtrU64PtrU64Ptr(ReadOnlySpan<byte> labelId, ulong[] xs, ulong[] ys, ulong[] neg, ulong[] pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ulong* nativeXs = xs)
			fixed (ulong* nativeYs = ys)
			fixed (ulong* nativeNeg = neg)
			fixed (ulong* nativePos = pos)
			{
				ImPlotNative.PlotErrorBarsU64PtrU64PtrU64PtrU64Ptr(nativeLabelId, nativeXs, nativeYs, nativeNeg, nativePos, count, flags, offset, stride);
			}
		}

		public static void PlotErrorBarsU64PtrU64PtrU64PtrU64Ptr(ReadOnlySpan<char> labelId, ulong[] xs, ulong[] ys, ulong[] neg, ulong[] pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (ulong* nativeXs = xs)
			fixed (ulong* nativeYs = ys)
			fixed (ulong* nativeNeg = neg)
			fixed (ulong* nativePos = pos)
			{
				ImPlotNative.PlotErrorBarsU64PtrU64PtrU64PtrU64Ptr(nativeLabelId, nativeXs, nativeYs, nativeNeg, nativePos, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotStemsFloatPtrInt(ReadOnlySpan<byte> labelId, float[] values, int count, double _ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (float* nativeValues = values)
			{
				ImPlotNative.PlotStemsFloatPtrInt(nativeLabelId, nativeValues, count, _ref, scale, start, flags, offset, stride);
			}
		}

		public static void PlotStemsFloatPtrInt(ReadOnlySpan<char> labelId, float[] values, int count, double _ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (float* nativeValues = values)
			{
				ImPlotNative.PlotStemsFloatPtrInt(nativeLabelId, nativeValues, count, _ref, scale, start, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotStemsDoublePtrInt(ReadOnlySpan<byte> labelId, double[] values, int count, double _ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (double* nativeValues = values)
			{
				ImPlotNative.PlotStemsDoublePtrInt(nativeLabelId, nativeValues, count, _ref, scale, start, flags, offset, stride);
			}
		}

		public static void PlotStemsDoublePtrInt(ReadOnlySpan<char> labelId, double[] values, int count, double _ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (double* nativeValues = values)
			{
				ImPlotNative.PlotStemsDoublePtrInt(nativeLabelId, nativeValues, count, _ref, scale, start, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotStemsS8PtrInt(ReadOnlySpan<byte> labelId, sbyte[] values, int count, double _ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (sbyte* nativeValues = values)
			{
				ImPlotNative.PlotStemsS8PtrInt(nativeLabelId, nativeValues, count, _ref, scale, start, flags, offset, stride);
			}
		}

		public static void PlotStemsS8PtrInt(ReadOnlySpan<char> labelId, sbyte[] values, int count, double _ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (sbyte* nativeValues = values)
			{
				ImPlotNative.PlotStemsS8PtrInt(nativeLabelId, nativeValues, count, _ref, scale, start, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotStemsU8PtrInt(ReadOnlySpan<byte> labelId, byte[] values, int count, double _ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (byte* nativeValues = values)
			{
				ImPlotNative.PlotStemsU8PtrInt(nativeLabelId, nativeValues, count, _ref, scale, start, flags, offset, stride);
			}
		}

		public static void PlotStemsU8PtrInt(ReadOnlySpan<char> labelId, byte[] values, int count, double _ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (byte* nativeValues = values)
			{
				ImPlotNative.PlotStemsU8PtrInt(nativeLabelId, nativeValues, count, _ref, scale, start, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotStemsS16PtrInt(ReadOnlySpan<byte> labelId, short[] values, int count, double _ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (short* nativeValues = values)
			{
				ImPlotNative.PlotStemsS16PtrInt(nativeLabelId, nativeValues, count, _ref, scale, start, flags, offset, stride);
			}
		}

		public static void PlotStemsS16PtrInt(ReadOnlySpan<char> labelId, short[] values, int count, double _ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (short* nativeValues = values)
			{
				ImPlotNative.PlotStemsS16PtrInt(nativeLabelId, nativeValues, count, _ref, scale, start, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotStemsU16PtrInt(ReadOnlySpan<byte> labelId, ushort[] values, int count, double _ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ushort* nativeValues = values)
			{
				ImPlotNative.PlotStemsU16PtrInt(nativeLabelId, nativeValues, count, _ref, scale, start, flags, offset, stride);
			}
		}

		public static void PlotStemsU16PtrInt(ReadOnlySpan<char> labelId, ushort[] values, int count, double _ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (ushort* nativeValues = values)
			{
				ImPlotNative.PlotStemsU16PtrInt(nativeLabelId, nativeValues, count, _ref, scale, start, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotStemsS32PtrInt(ReadOnlySpan<byte> labelId, int[] values, int count, double _ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (int* nativeValues = values)
			{
				ImPlotNative.PlotStemsS32PtrInt(nativeLabelId, nativeValues, count, _ref, scale, start, flags, offset, stride);
			}
		}

		public static void PlotStemsS32PtrInt(ReadOnlySpan<char> labelId, int[] values, int count, double _ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (int* nativeValues = values)
			{
				ImPlotNative.PlotStemsS32PtrInt(nativeLabelId, nativeValues, count, _ref, scale, start, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotStemsU32PtrInt(ReadOnlySpan<byte> labelId, uint[] values, int count, double _ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (uint* nativeValues = values)
			{
				ImPlotNative.PlotStemsU32PtrInt(nativeLabelId, nativeValues, count, _ref, scale, start, flags, offset, stride);
			}
		}

		public static void PlotStemsU32PtrInt(ReadOnlySpan<char> labelId, uint[] values, int count, double _ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (uint* nativeValues = values)
			{
				ImPlotNative.PlotStemsU32PtrInt(nativeLabelId, nativeValues, count, _ref, scale, start, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotStemsS64PtrInt(ReadOnlySpan<byte> labelId, long[] values, int count, double _ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (long* nativeValues = values)
			{
				ImPlotNative.PlotStemsS64PtrInt(nativeLabelId, nativeValues, count, _ref, scale, start, flags, offset, stride);
			}
		}

		public static void PlotStemsS64PtrInt(ReadOnlySpan<char> labelId, long[] values, int count, double _ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (long* nativeValues = values)
			{
				ImPlotNative.PlotStemsS64PtrInt(nativeLabelId, nativeValues, count, _ref, scale, start, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotStemsU64PtrInt(ReadOnlySpan<byte> labelId, ulong[] values, int count, double _ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ulong* nativeValues = values)
			{
				ImPlotNative.PlotStemsU64PtrInt(nativeLabelId, nativeValues, count, _ref, scale, start, flags, offset, stride);
			}
		}

		public static void PlotStemsU64PtrInt(ReadOnlySpan<char> labelId, ulong[] values, int count, double _ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (ulong* nativeValues = values)
			{
				ImPlotNative.PlotStemsU64PtrInt(nativeLabelId, nativeValues, count, _ref, scale, start, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotStemsFloatPtrFloatPtr(ReadOnlySpan<byte> labelId, float[] xs, float[] ys, int count, double _ref, ImPlotStemsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (float* nativeXs = xs)
			fixed (float* nativeYs = ys)
			{
				ImPlotNative.PlotStemsFloatPtrFloatPtr(nativeLabelId, nativeXs, nativeYs, count, _ref, flags, offset, stride);
			}
		}

		public static void PlotStemsFloatPtrFloatPtr(ReadOnlySpan<char> labelId, float[] xs, float[] ys, int count, double _ref, ImPlotStemsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (float* nativeXs = xs)
			fixed (float* nativeYs = ys)
			{
				ImPlotNative.PlotStemsFloatPtrFloatPtr(nativeLabelId, nativeXs, nativeYs, count, _ref, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotStemsDoublePtrdoublePtr(ReadOnlySpan<byte> labelId, double[] xs, double[] ys, int count, double _ref, ImPlotStemsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (double* nativeXs = xs)
			fixed (double* nativeYs = ys)
			{
				ImPlotNative.PlotStemsDoublePtrdoublePtr(nativeLabelId, nativeXs, nativeYs, count, _ref, flags, offset, stride);
			}
		}

		public static void PlotStemsDoublePtrdoublePtr(ReadOnlySpan<char> labelId, double[] xs, double[] ys, int count, double _ref, ImPlotStemsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (double* nativeXs = xs)
			fixed (double* nativeYs = ys)
			{
				ImPlotNative.PlotStemsDoublePtrdoublePtr(nativeLabelId, nativeXs, nativeYs, count, _ref, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotStemsS8PtrS8Ptr(ReadOnlySpan<byte> labelId, sbyte[] xs, sbyte[] ys, int count, double _ref, ImPlotStemsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (sbyte* nativeXs = xs)
			fixed (sbyte* nativeYs = ys)
			{
				ImPlotNative.PlotStemsS8PtrS8Ptr(nativeLabelId, nativeXs, nativeYs, count, _ref, flags, offset, stride);
			}
		}

		public static void PlotStemsS8PtrS8Ptr(ReadOnlySpan<char> labelId, sbyte[] xs, sbyte[] ys, int count, double _ref, ImPlotStemsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (sbyte* nativeXs = xs)
			fixed (sbyte* nativeYs = ys)
			{
				ImPlotNative.PlotStemsS8PtrS8Ptr(nativeLabelId, nativeXs, nativeYs, count, _ref, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotStemsU8PtrU8Ptr(ReadOnlySpan<byte> labelId, byte[] xs, byte[] ys, int count, double _ref, ImPlotStemsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (byte* nativeXs = xs)
			fixed (byte* nativeYs = ys)
			{
				ImPlotNative.PlotStemsU8PtrU8Ptr(nativeLabelId, nativeXs, nativeYs, count, _ref, flags, offset, stride);
			}
		}

		public static void PlotStemsU8PtrU8Ptr(ReadOnlySpan<char> labelId, byte[] xs, byte[] ys, int count, double _ref, ImPlotStemsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (byte* nativeXs = xs)
			fixed (byte* nativeYs = ys)
			{
				ImPlotNative.PlotStemsU8PtrU8Ptr(nativeLabelId, nativeXs, nativeYs, count, _ref, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotStemsS16PtrS16Ptr(ReadOnlySpan<byte> labelId, short[] xs, short[] ys, int count, double _ref, ImPlotStemsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (short* nativeXs = xs)
			fixed (short* nativeYs = ys)
			{
				ImPlotNative.PlotStemsS16PtrS16Ptr(nativeLabelId, nativeXs, nativeYs, count, _ref, flags, offset, stride);
			}
		}

		public static void PlotStemsS16PtrS16Ptr(ReadOnlySpan<char> labelId, short[] xs, short[] ys, int count, double _ref, ImPlotStemsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (short* nativeXs = xs)
			fixed (short* nativeYs = ys)
			{
				ImPlotNative.PlotStemsS16PtrS16Ptr(nativeLabelId, nativeXs, nativeYs, count, _ref, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotStemsU16PtrU16Ptr(ReadOnlySpan<byte> labelId, ushort[] xs, ushort[] ys, int count, double _ref, ImPlotStemsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ushort* nativeXs = xs)
			fixed (ushort* nativeYs = ys)
			{
				ImPlotNative.PlotStemsU16PtrU16Ptr(nativeLabelId, nativeXs, nativeYs, count, _ref, flags, offset, stride);
			}
		}

		public static void PlotStemsU16PtrU16Ptr(ReadOnlySpan<char> labelId, ushort[] xs, ushort[] ys, int count, double _ref, ImPlotStemsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (ushort* nativeXs = xs)
			fixed (ushort* nativeYs = ys)
			{
				ImPlotNative.PlotStemsU16PtrU16Ptr(nativeLabelId, nativeXs, nativeYs, count, _ref, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotStemsS32PtrS32Ptr(ReadOnlySpan<byte> labelId, int[] xs, int[] ys, int count, double _ref, ImPlotStemsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (int* nativeXs = xs)
			fixed (int* nativeYs = ys)
			{
				ImPlotNative.PlotStemsS32PtrS32Ptr(nativeLabelId, nativeXs, nativeYs, count, _ref, flags, offset, stride);
			}
		}

		public static void PlotStemsS32PtrS32Ptr(ReadOnlySpan<char> labelId, int[] xs, int[] ys, int count, double _ref, ImPlotStemsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (int* nativeXs = xs)
			fixed (int* nativeYs = ys)
			{
				ImPlotNative.PlotStemsS32PtrS32Ptr(nativeLabelId, nativeXs, nativeYs, count, _ref, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotStemsU32PtrU32Ptr(ReadOnlySpan<byte> labelId, uint[] xs, uint[] ys, int count, double _ref, ImPlotStemsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (uint* nativeXs = xs)
			fixed (uint* nativeYs = ys)
			{
				ImPlotNative.PlotStemsU32PtrU32Ptr(nativeLabelId, nativeXs, nativeYs, count, _ref, flags, offset, stride);
			}
		}

		public static void PlotStemsU32PtrU32Ptr(ReadOnlySpan<char> labelId, uint[] xs, uint[] ys, int count, double _ref, ImPlotStemsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (uint* nativeXs = xs)
			fixed (uint* nativeYs = ys)
			{
				ImPlotNative.PlotStemsU32PtrU32Ptr(nativeLabelId, nativeXs, nativeYs, count, _ref, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotStemsS64PtrS64Ptr(ReadOnlySpan<byte> labelId, long[] xs, long[] ys, int count, double _ref, ImPlotStemsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (long* nativeXs = xs)
			fixed (long* nativeYs = ys)
			{
				ImPlotNative.PlotStemsS64PtrS64Ptr(nativeLabelId, nativeXs, nativeYs, count, _ref, flags, offset, stride);
			}
		}

		public static void PlotStemsS64PtrS64Ptr(ReadOnlySpan<char> labelId, long[] xs, long[] ys, int count, double _ref, ImPlotStemsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (long* nativeXs = xs)
			fixed (long* nativeYs = ys)
			{
				ImPlotNative.PlotStemsS64PtrS64Ptr(nativeLabelId, nativeXs, nativeYs, count, _ref, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotStemsU64PtrU64Ptr(ReadOnlySpan<byte> labelId, ulong[] xs, ulong[] ys, int count, double _ref, ImPlotStemsFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ulong* nativeXs = xs)
			fixed (ulong* nativeYs = ys)
			{
				ImPlotNative.PlotStemsU64PtrU64Ptr(nativeLabelId, nativeXs, nativeYs, count, _ref, flags, offset, stride);
			}
		}

		public static void PlotStemsU64PtrU64Ptr(ReadOnlySpan<char> labelId, ulong[] xs, ulong[] ys, int count, double _ref, ImPlotStemsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (ulong* nativeXs = xs)
			fixed (ulong* nativeYs = ys)
			{
				ImPlotNative.PlotStemsU64PtrU64Ptr(nativeLabelId, nativeXs, nativeYs, count, _ref, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotInfLinesFloatPtr(ReadOnlySpan<byte> labelId, float[] values, int count, ImPlotInfLinesFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (float* nativeValues = values)
			{
				ImPlotNative.PlotInfLinesFloatPtr(nativeLabelId, nativeValues, count, flags, offset, stride);
			}
		}

		public static void PlotInfLinesFloatPtr(ReadOnlySpan<char> labelId, float[] values, int count, ImPlotInfLinesFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (float* nativeValues = values)
			{
				ImPlotNative.PlotInfLinesFloatPtr(nativeLabelId, nativeValues, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotInfLinesDoublePtr(ReadOnlySpan<byte> labelId, double[] values, int count, ImPlotInfLinesFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (double* nativeValues = values)
			{
				ImPlotNative.PlotInfLinesDoublePtr(nativeLabelId, nativeValues, count, flags, offset, stride);
			}
		}

		public static void PlotInfLinesDoublePtr(ReadOnlySpan<char> labelId, double[] values, int count, ImPlotInfLinesFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (double* nativeValues = values)
			{
				ImPlotNative.PlotInfLinesDoublePtr(nativeLabelId, nativeValues, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotInfLinesS8Ptr(ReadOnlySpan<byte> labelId, sbyte[] values, int count, ImPlotInfLinesFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (sbyte* nativeValues = values)
			{
				ImPlotNative.PlotInfLinesS8Ptr(nativeLabelId, nativeValues, count, flags, offset, stride);
			}
		}

		public static void PlotInfLinesS8Ptr(ReadOnlySpan<char> labelId, sbyte[] values, int count, ImPlotInfLinesFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (sbyte* nativeValues = values)
			{
				ImPlotNative.PlotInfLinesS8Ptr(nativeLabelId, nativeValues, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotInfLinesU8Ptr(ReadOnlySpan<byte> labelId, byte[] values, int count, ImPlotInfLinesFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (byte* nativeValues = values)
			{
				ImPlotNative.PlotInfLinesU8Ptr(nativeLabelId, nativeValues, count, flags, offset, stride);
			}
		}

		public static void PlotInfLinesU8Ptr(ReadOnlySpan<char> labelId, byte[] values, int count, ImPlotInfLinesFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (byte* nativeValues = values)
			{
				ImPlotNative.PlotInfLinesU8Ptr(nativeLabelId, nativeValues, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotInfLinesS16Ptr(ReadOnlySpan<byte> labelId, short[] values, int count, ImPlotInfLinesFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (short* nativeValues = values)
			{
				ImPlotNative.PlotInfLinesS16Ptr(nativeLabelId, nativeValues, count, flags, offset, stride);
			}
		}

		public static void PlotInfLinesS16Ptr(ReadOnlySpan<char> labelId, short[] values, int count, ImPlotInfLinesFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (short* nativeValues = values)
			{
				ImPlotNative.PlotInfLinesS16Ptr(nativeLabelId, nativeValues, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotInfLinesU16Ptr(ReadOnlySpan<byte> labelId, ushort[] values, int count, ImPlotInfLinesFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ushort* nativeValues = values)
			{
				ImPlotNative.PlotInfLinesU16Ptr(nativeLabelId, nativeValues, count, flags, offset, stride);
			}
		}

		public static void PlotInfLinesU16Ptr(ReadOnlySpan<char> labelId, ushort[] values, int count, ImPlotInfLinesFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (ushort* nativeValues = values)
			{
				ImPlotNative.PlotInfLinesU16Ptr(nativeLabelId, nativeValues, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotInfLinesS32Ptr(ReadOnlySpan<byte> labelId, int[] values, int count, ImPlotInfLinesFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (int* nativeValues = values)
			{
				ImPlotNative.PlotInfLinesS32Ptr(nativeLabelId, nativeValues, count, flags, offset, stride);
			}
		}

		public static void PlotInfLinesS32Ptr(ReadOnlySpan<char> labelId, int[] values, int count, ImPlotInfLinesFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (int* nativeValues = values)
			{
				ImPlotNative.PlotInfLinesS32Ptr(nativeLabelId, nativeValues, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotInfLinesU32Ptr(ReadOnlySpan<byte> labelId, uint[] values, int count, ImPlotInfLinesFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (uint* nativeValues = values)
			{
				ImPlotNative.PlotInfLinesU32Ptr(nativeLabelId, nativeValues, count, flags, offset, stride);
			}
		}

		public static void PlotInfLinesU32Ptr(ReadOnlySpan<char> labelId, uint[] values, int count, ImPlotInfLinesFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (uint* nativeValues = values)
			{
				ImPlotNative.PlotInfLinesU32Ptr(nativeLabelId, nativeValues, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotInfLinesS64Ptr(ReadOnlySpan<byte> labelId, long[] values, int count, ImPlotInfLinesFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (long* nativeValues = values)
			{
				ImPlotNative.PlotInfLinesS64Ptr(nativeLabelId, nativeValues, count, flags, offset, stride);
			}
		}

		public static void PlotInfLinesS64Ptr(ReadOnlySpan<char> labelId, long[] values, int count, ImPlotInfLinesFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (long* nativeValues = values)
			{
				ImPlotNative.PlotInfLinesS64Ptr(nativeLabelId, nativeValues, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotInfLinesU64Ptr(ReadOnlySpan<byte> labelId, ulong[] values, int count, ImPlotInfLinesFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ulong* nativeValues = values)
			{
				ImPlotNative.PlotInfLinesU64Ptr(nativeLabelId, nativeValues, count, flags, offset, stride);
			}
		}

		public static void PlotInfLinesU64Ptr(ReadOnlySpan<char> labelId, ulong[] values, int count, ImPlotInfLinesFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (ulong* nativeValues = values)
			{
				ImPlotNative.PlotInfLinesU64Ptr(nativeLabelId, nativeValues, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotPieChartFloatPtrPlotFormatter(ref byte* labelIds, float[] values, int count, double x, double y, double radius, ImPlotFormatter fmt, IntPtr fmtData, double angle0, ImPlotPieChartFlags flags)
		{
			fixed (byte** nativeLabelIds = &labelIds)
			fixed (float* nativeValues = values)
			{
				ImPlotNative.PlotPieChartFloatPtrPlotFormatter(nativeLabelIds, nativeValues, count, x, y, radius, fmt, (void*)fmtData, angle0, flags);
			}
		}

		public static void PlotPieChartDoublePtrPlotFormatter(ref byte* labelIds, double[] values, int count, double x, double y, double radius, ImPlotFormatter fmt, IntPtr fmtData, double angle0, ImPlotPieChartFlags flags)
		{
			fixed (byte** nativeLabelIds = &labelIds)
			fixed (double* nativeValues = values)
			{
				ImPlotNative.PlotPieChartDoublePtrPlotFormatter(nativeLabelIds, nativeValues, count, x, y, radius, fmt, (void*)fmtData, angle0, flags);
			}
		}

		public static void PlotPieChartS8PtrPlotFormatter(ref byte* labelIds, sbyte[] values, int count, double x, double y, double radius, ImPlotFormatter fmt, IntPtr fmtData, double angle0, ImPlotPieChartFlags flags)
		{
			fixed (byte** nativeLabelIds = &labelIds)
			fixed (sbyte* nativeValues = values)
			{
				ImPlotNative.PlotPieChartS8PtrPlotFormatter(nativeLabelIds, nativeValues, count, x, y, radius, fmt, (void*)fmtData, angle0, flags);
			}
		}

		public static void PlotPieChartU8PtrPlotFormatter(ref byte* labelIds, byte[] values, int count, double x, double y, double radius, ImPlotFormatter fmt, IntPtr fmtData, double angle0, ImPlotPieChartFlags flags)
		{
			fixed (byte** nativeLabelIds = &labelIds)
			fixed (byte* nativeValues = values)
			{
				ImPlotNative.PlotPieChartU8PtrPlotFormatter(nativeLabelIds, nativeValues, count, x, y, radius, fmt, (void*)fmtData, angle0, flags);
			}
		}

		public static void PlotPieChartS16PtrPlotFormatter(ref byte* labelIds, short[] values, int count, double x, double y, double radius, ImPlotFormatter fmt, IntPtr fmtData, double angle0, ImPlotPieChartFlags flags)
		{
			fixed (byte** nativeLabelIds = &labelIds)
			fixed (short* nativeValues = values)
			{
				ImPlotNative.PlotPieChartS16PtrPlotFormatter(nativeLabelIds, nativeValues, count, x, y, radius, fmt, (void*)fmtData, angle0, flags);
			}
		}

		public static void PlotPieChartU16PtrPlotFormatter(ref byte* labelIds, ushort[] values, int count, double x, double y, double radius, ImPlotFormatter fmt, IntPtr fmtData, double angle0, ImPlotPieChartFlags flags)
		{
			fixed (byte** nativeLabelIds = &labelIds)
			fixed (ushort* nativeValues = values)
			{
				ImPlotNative.PlotPieChartU16PtrPlotFormatter(nativeLabelIds, nativeValues, count, x, y, radius, fmt, (void*)fmtData, angle0, flags);
			}
		}

		public static void PlotPieChartS32PtrPlotFormatter(ref byte* labelIds, int[] values, int count, double x, double y, double radius, ImPlotFormatter fmt, IntPtr fmtData, double angle0, ImPlotPieChartFlags flags)
		{
			fixed (byte** nativeLabelIds = &labelIds)
			fixed (int* nativeValues = values)
			{
				ImPlotNative.PlotPieChartS32PtrPlotFormatter(nativeLabelIds, nativeValues, count, x, y, radius, fmt, (void*)fmtData, angle0, flags);
			}
		}

		public static void PlotPieChartU32PtrPlotFormatter(ref byte* labelIds, uint[] values, int count, double x, double y, double radius, ImPlotFormatter fmt, IntPtr fmtData, double angle0, ImPlotPieChartFlags flags)
		{
			fixed (byte** nativeLabelIds = &labelIds)
			fixed (uint* nativeValues = values)
			{
				ImPlotNative.PlotPieChartU32PtrPlotFormatter(nativeLabelIds, nativeValues, count, x, y, radius, fmt, (void*)fmtData, angle0, flags);
			}
		}

		public static void PlotPieChartS64PtrPlotFormatter(ref byte* labelIds, long[] values, int count, double x, double y, double radius, ImPlotFormatter fmt, IntPtr fmtData, double angle0, ImPlotPieChartFlags flags)
		{
			fixed (byte** nativeLabelIds = &labelIds)
			fixed (long* nativeValues = values)
			{
				ImPlotNative.PlotPieChartS64PtrPlotFormatter(nativeLabelIds, nativeValues, count, x, y, radius, fmt, (void*)fmtData, angle0, flags);
			}
		}

		public static void PlotPieChartU64PtrPlotFormatter(ref byte* labelIds, ulong[] values, int count, double x, double y, double radius, ImPlotFormatter fmt, IntPtr fmtData, double angle0, ImPlotPieChartFlags flags)
		{
			fixed (byte** nativeLabelIds = &labelIds)
			fixed (ulong* nativeValues = values)
			{
				ImPlotNative.PlotPieChartU64PtrPlotFormatter(nativeLabelIds, nativeValues, count, x, y, radius, fmt, (void*)fmtData, angle0, flags);
			}
		}

		public static void PlotPieChartFloatPtrStr(ref byte* labelIds, float[] values, int count, double x, double y, double radius, ReadOnlySpan<byte> labelFmt, double angle0, ImPlotPieChartFlags flags)
		{
			fixed (byte** nativeLabelIds = &labelIds)
			fixed (float* nativeValues = values)
			fixed (byte* nativeLabelFmt = labelFmt)
			{
				ImPlotNative.PlotPieChartFloatPtrStr(nativeLabelIds, nativeValues, count, x, y, radius, nativeLabelFmt, angle0, flags);
			}
		}

		public static void PlotPieChartFloatPtrStr(ref byte* labelIds, float[] values, int count, double x, double y, double radius, ReadOnlySpan<char> labelFmt, double angle0, ImPlotPieChartFlags flags)
		{
			// Marshaling labelFmt to native string
			byte* nativeLabelFmt;
			var byteCountLabelFmt = 0;
			if (labelFmt != null && !labelFmt.IsEmpty)
			{
				byteCountLabelFmt = Encoding.UTF8.GetByteCount(labelFmt);
				if(byteCountLabelFmt > Utils.MaxStackallocSize)
				{
					nativeLabelFmt = Utils.Alloc<byte>(byteCountLabelFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelFmt + 1];
					nativeLabelFmt = stackallocBytes;
				}
				var offsetLabelFmt = Utils.EncodeStringUTF8(labelFmt, nativeLabelFmt, byteCountLabelFmt);
				nativeLabelFmt[offsetLabelFmt] = 0;
			}
			else nativeLabelFmt = null;

			fixed (byte** nativeLabelIds = &labelIds)
			fixed (float* nativeValues = values)
			{
				ImPlotNative.PlotPieChartFloatPtrStr(nativeLabelIds, nativeValues, count, x, y, radius, nativeLabelFmt, angle0, flags);
				// Freeing labelFmt native string
				if (byteCountLabelFmt > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelFmt);
			}
		}

		public static void PlotPieChartDoublePtrStr(ref byte* labelIds, double[] values, int count, double x, double y, double radius, ReadOnlySpan<byte> labelFmt, double angle0, ImPlotPieChartFlags flags)
		{
			fixed (byte** nativeLabelIds = &labelIds)
			fixed (double* nativeValues = values)
			fixed (byte* nativeLabelFmt = labelFmt)
			{
				ImPlotNative.PlotPieChartDoublePtrStr(nativeLabelIds, nativeValues, count, x, y, radius, nativeLabelFmt, angle0, flags);
			}
		}

		public static void PlotPieChartDoublePtrStr(ref byte* labelIds, double[] values, int count, double x, double y, double radius, ReadOnlySpan<char> labelFmt, double angle0, ImPlotPieChartFlags flags)
		{
			// Marshaling labelFmt to native string
			byte* nativeLabelFmt;
			var byteCountLabelFmt = 0;
			if (labelFmt != null && !labelFmt.IsEmpty)
			{
				byteCountLabelFmt = Encoding.UTF8.GetByteCount(labelFmt);
				if(byteCountLabelFmt > Utils.MaxStackallocSize)
				{
					nativeLabelFmt = Utils.Alloc<byte>(byteCountLabelFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelFmt + 1];
					nativeLabelFmt = stackallocBytes;
				}
				var offsetLabelFmt = Utils.EncodeStringUTF8(labelFmt, nativeLabelFmt, byteCountLabelFmt);
				nativeLabelFmt[offsetLabelFmt] = 0;
			}
			else nativeLabelFmt = null;

			fixed (byte** nativeLabelIds = &labelIds)
			fixed (double* nativeValues = values)
			{
				ImPlotNative.PlotPieChartDoublePtrStr(nativeLabelIds, nativeValues, count, x, y, radius, nativeLabelFmt, angle0, flags);
				// Freeing labelFmt native string
				if (byteCountLabelFmt > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelFmt);
			}
		}

		public static void PlotPieChartS8PtrStr(ref byte* labelIds, sbyte[] values, int count, double x, double y, double radius, ReadOnlySpan<byte> labelFmt, double angle0, ImPlotPieChartFlags flags)
		{
			fixed (byte** nativeLabelIds = &labelIds)
			fixed (sbyte* nativeValues = values)
			fixed (byte* nativeLabelFmt = labelFmt)
			{
				ImPlotNative.PlotPieChartS8PtrStr(nativeLabelIds, nativeValues, count, x, y, radius, nativeLabelFmt, angle0, flags);
			}
		}

		public static void PlotPieChartS8PtrStr(ref byte* labelIds, sbyte[] values, int count, double x, double y, double radius, ReadOnlySpan<char> labelFmt, double angle0, ImPlotPieChartFlags flags)
		{
			// Marshaling labelFmt to native string
			byte* nativeLabelFmt;
			var byteCountLabelFmt = 0;
			if (labelFmt != null && !labelFmt.IsEmpty)
			{
				byteCountLabelFmt = Encoding.UTF8.GetByteCount(labelFmt);
				if(byteCountLabelFmt > Utils.MaxStackallocSize)
				{
					nativeLabelFmt = Utils.Alloc<byte>(byteCountLabelFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelFmt + 1];
					nativeLabelFmt = stackallocBytes;
				}
				var offsetLabelFmt = Utils.EncodeStringUTF8(labelFmt, nativeLabelFmt, byteCountLabelFmt);
				nativeLabelFmt[offsetLabelFmt] = 0;
			}
			else nativeLabelFmt = null;

			fixed (byte** nativeLabelIds = &labelIds)
			fixed (sbyte* nativeValues = values)
			{
				ImPlotNative.PlotPieChartS8PtrStr(nativeLabelIds, nativeValues, count, x, y, radius, nativeLabelFmt, angle0, flags);
				// Freeing labelFmt native string
				if (byteCountLabelFmt > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelFmt);
			}
		}

		public static void PlotPieChartU8PtrStr(ref byte* labelIds, byte[] values, int count, double x, double y, double radius, ReadOnlySpan<byte> labelFmt, double angle0, ImPlotPieChartFlags flags)
		{
			fixed (byte** nativeLabelIds = &labelIds)
			fixed (byte* nativeValues = values)
			fixed (byte* nativeLabelFmt = labelFmt)
			{
				ImPlotNative.PlotPieChartU8PtrStr(nativeLabelIds, nativeValues, count, x, y, radius, nativeLabelFmt, angle0, flags);
			}
		}

		public static void PlotPieChartU8PtrStr(ref byte* labelIds, byte[] values, int count, double x, double y, double radius, ReadOnlySpan<char> labelFmt, double angle0, ImPlotPieChartFlags flags)
		{
			// Marshaling labelFmt to native string
			byte* nativeLabelFmt;
			var byteCountLabelFmt = 0;
			if (labelFmt != null && !labelFmt.IsEmpty)
			{
				byteCountLabelFmt = Encoding.UTF8.GetByteCount(labelFmt);
				if(byteCountLabelFmt > Utils.MaxStackallocSize)
				{
					nativeLabelFmt = Utils.Alloc<byte>(byteCountLabelFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelFmt + 1];
					nativeLabelFmt = stackallocBytes;
				}
				var offsetLabelFmt = Utils.EncodeStringUTF8(labelFmt, nativeLabelFmt, byteCountLabelFmt);
				nativeLabelFmt[offsetLabelFmt] = 0;
			}
			else nativeLabelFmt = null;

			fixed (byte** nativeLabelIds = &labelIds)
			fixed (byte* nativeValues = values)
			{
				ImPlotNative.PlotPieChartU8PtrStr(nativeLabelIds, nativeValues, count, x, y, radius, nativeLabelFmt, angle0, flags);
				// Freeing labelFmt native string
				if (byteCountLabelFmt > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelFmt);
			}
		}

		public static void PlotPieChartS16PtrStr(ref byte* labelIds, short[] values, int count, double x, double y, double radius, ReadOnlySpan<byte> labelFmt, double angle0, ImPlotPieChartFlags flags)
		{
			fixed (byte** nativeLabelIds = &labelIds)
			fixed (short* nativeValues = values)
			fixed (byte* nativeLabelFmt = labelFmt)
			{
				ImPlotNative.PlotPieChartS16PtrStr(nativeLabelIds, nativeValues, count, x, y, radius, nativeLabelFmt, angle0, flags);
			}
		}

		public static void PlotPieChartS16PtrStr(ref byte* labelIds, short[] values, int count, double x, double y, double radius, ReadOnlySpan<char> labelFmt, double angle0, ImPlotPieChartFlags flags)
		{
			// Marshaling labelFmt to native string
			byte* nativeLabelFmt;
			var byteCountLabelFmt = 0;
			if (labelFmt != null && !labelFmt.IsEmpty)
			{
				byteCountLabelFmt = Encoding.UTF8.GetByteCount(labelFmt);
				if(byteCountLabelFmt > Utils.MaxStackallocSize)
				{
					nativeLabelFmt = Utils.Alloc<byte>(byteCountLabelFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelFmt + 1];
					nativeLabelFmt = stackallocBytes;
				}
				var offsetLabelFmt = Utils.EncodeStringUTF8(labelFmt, nativeLabelFmt, byteCountLabelFmt);
				nativeLabelFmt[offsetLabelFmt] = 0;
			}
			else nativeLabelFmt = null;

			fixed (byte** nativeLabelIds = &labelIds)
			fixed (short* nativeValues = values)
			{
				ImPlotNative.PlotPieChartS16PtrStr(nativeLabelIds, nativeValues, count, x, y, radius, nativeLabelFmt, angle0, flags);
				// Freeing labelFmt native string
				if (byteCountLabelFmt > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelFmt);
			}
		}

		public static void PlotPieChartU16PtrStr(ref byte* labelIds, ushort[] values, int count, double x, double y, double radius, ReadOnlySpan<byte> labelFmt, double angle0, ImPlotPieChartFlags flags)
		{
			fixed (byte** nativeLabelIds = &labelIds)
			fixed (ushort* nativeValues = values)
			fixed (byte* nativeLabelFmt = labelFmt)
			{
				ImPlotNative.PlotPieChartU16PtrStr(nativeLabelIds, nativeValues, count, x, y, radius, nativeLabelFmt, angle0, flags);
			}
		}

		public static void PlotPieChartU16PtrStr(ref byte* labelIds, ushort[] values, int count, double x, double y, double radius, ReadOnlySpan<char> labelFmt, double angle0, ImPlotPieChartFlags flags)
		{
			// Marshaling labelFmt to native string
			byte* nativeLabelFmt;
			var byteCountLabelFmt = 0;
			if (labelFmt != null && !labelFmt.IsEmpty)
			{
				byteCountLabelFmt = Encoding.UTF8.GetByteCount(labelFmt);
				if(byteCountLabelFmt > Utils.MaxStackallocSize)
				{
					nativeLabelFmt = Utils.Alloc<byte>(byteCountLabelFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelFmt + 1];
					nativeLabelFmt = stackallocBytes;
				}
				var offsetLabelFmt = Utils.EncodeStringUTF8(labelFmt, nativeLabelFmt, byteCountLabelFmt);
				nativeLabelFmt[offsetLabelFmt] = 0;
			}
			else nativeLabelFmt = null;

			fixed (byte** nativeLabelIds = &labelIds)
			fixed (ushort* nativeValues = values)
			{
				ImPlotNative.PlotPieChartU16PtrStr(nativeLabelIds, nativeValues, count, x, y, radius, nativeLabelFmt, angle0, flags);
				// Freeing labelFmt native string
				if (byteCountLabelFmt > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelFmt);
			}
		}

		public static void PlotPieChartS32PtrStr(ref byte* labelIds, int[] values, int count, double x, double y, double radius, ReadOnlySpan<byte> labelFmt, double angle0, ImPlotPieChartFlags flags)
		{
			fixed (byte** nativeLabelIds = &labelIds)
			fixed (int* nativeValues = values)
			fixed (byte* nativeLabelFmt = labelFmt)
			{
				ImPlotNative.PlotPieChartS32PtrStr(nativeLabelIds, nativeValues, count, x, y, radius, nativeLabelFmt, angle0, flags);
			}
		}

		public static void PlotPieChartS32PtrStr(ref byte* labelIds, int[] values, int count, double x, double y, double radius, ReadOnlySpan<char> labelFmt, double angle0, ImPlotPieChartFlags flags)
		{
			// Marshaling labelFmt to native string
			byte* nativeLabelFmt;
			var byteCountLabelFmt = 0;
			if (labelFmt != null && !labelFmt.IsEmpty)
			{
				byteCountLabelFmt = Encoding.UTF8.GetByteCount(labelFmt);
				if(byteCountLabelFmt > Utils.MaxStackallocSize)
				{
					nativeLabelFmt = Utils.Alloc<byte>(byteCountLabelFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelFmt + 1];
					nativeLabelFmt = stackallocBytes;
				}
				var offsetLabelFmt = Utils.EncodeStringUTF8(labelFmt, nativeLabelFmt, byteCountLabelFmt);
				nativeLabelFmt[offsetLabelFmt] = 0;
			}
			else nativeLabelFmt = null;

			fixed (byte** nativeLabelIds = &labelIds)
			fixed (int* nativeValues = values)
			{
				ImPlotNative.PlotPieChartS32PtrStr(nativeLabelIds, nativeValues, count, x, y, radius, nativeLabelFmt, angle0, flags);
				// Freeing labelFmt native string
				if (byteCountLabelFmt > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelFmt);
			}
		}

		public static void PlotPieChartU32PtrStr(ref byte* labelIds, uint[] values, int count, double x, double y, double radius, ReadOnlySpan<byte> labelFmt, double angle0, ImPlotPieChartFlags flags)
		{
			fixed (byte** nativeLabelIds = &labelIds)
			fixed (uint* nativeValues = values)
			fixed (byte* nativeLabelFmt = labelFmt)
			{
				ImPlotNative.PlotPieChartU32PtrStr(nativeLabelIds, nativeValues, count, x, y, radius, nativeLabelFmt, angle0, flags);
			}
		}

		public static void PlotPieChartU32PtrStr(ref byte* labelIds, uint[] values, int count, double x, double y, double radius, ReadOnlySpan<char> labelFmt, double angle0, ImPlotPieChartFlags flags)
		{
			// Marshaling labelFmt to native string
			byte* nativeLabelFmt;
			var byteCountLabelFmt = 0;
			if (labelFmt != null && !labelFmt.IsEmpty)
			{
				byteCountLabelFmt = Encoding.UTF8.GetByteCount(labelFmt);
				if(byteCountLabelFmt > Utils.MaxStackallocSize)
				{
					nativeLabelFmt = Utils.Alloc<byte>(byteCountLabelFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelFmt + 1];
					nativeLabelFmt = stackallocBytes;
				}
				var offsetLabelFmt = Utils.EncodeStringUTF8(labelFmt, nativeLabelFmt, byteCountLabelFmt);
				nativeLabelFmt[offsetLabelFmt] = 0;
			}
			else nativeLabelFmt = null;

			fixed (byte** nativeLabelIds = &labelIds)
			fixed (uint* nativeValues = values)
			{
				ImPlotNative.PlotPieChartU32PtrStr(nativeLabelIds, nativeValues, count, x, y, radius, nativeLabelFmt, angle0, flags);
				// Freeing labelFmt native string
				if (byteCountLabelFmt > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelFmt);
			}
		}

		public static void PlotPieChartS64PtrStr(ref byte* labelIds, long[] values, int count, double x, double y, double radius, ReadOnlySpan<byte> labelFmt, double angle0, ImPlotPieChartFlags flags)
		{
			fixed (byte** nativeLabelIds = &labelIds)
			fixed (long* nativeValues = values)
			fixed (byte* nativeLabelFmt = labelFmt)
			{
				ImPlotNative.PlotPieChartS64PtrStr(nativeLabelIds, nativeValues, count, x, y, radius, nativeLabelFmt, angle0, flags);
			}
		}

		public static void PlotPieChartS64PtrStr(ref byte* labelIds, long[] values, int count, double x, double y, double radius, ReadOnlySpan<char> labelFmt, double angle0, ImPlotPieChartFlags flags)
		{
			// Marshaling labelFmt to native string
			byte* nativeLabelFmt;
			var byteCountLabelFmt = 0;
			if (labelFmt != null && !labelFmt.IsEmpty)
			{
				byteCountLabelFmt = Encoding.UTF8.GetByteCount(labelFmt);
				if(byteCountLabelFmt > Utils.MaxStackallocSize)
				{
					nativeLabelFmt = Utils.Alloc<byte>(byteCountLabelFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelFmt + 1];
					nativeLabelFmt = stackallocBytes;
				}
				var offsetLabelFmt = Utils.EncodeStringUTF8(labelFmt, nativeLabelFmt, byteCountLabelFmt);
				nativeLabelFmt[offsetLabelFmt] = 0;
			}
			else nativeLabelFmt = null;

			fixed (byte** nativeLabelIds = &labelIds)
			fixed (long* nativeValues = values)
			{
				ImPlotNative.PlotPieChartS64PtrStr(nativeLabelIds, nativeValues, count, x, y, radius, nativeLabelFmt, angle0, flags);
				// Freeing labelFmt native string
				if (byteCountLabelFmt > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelFmt);
			}
		}

		public static void PlotPieChartU64PtrStr(ref byte* labelIds, ulong[] values, int count, double x, double y, double radius, ReadOnlySpan<byte> labelFmt, double angle0, ImPlotPieChartFlags flags)
		{
			fixed (byte** nativeLabelIds = &labelIds)
			fixed (ulong* nativeValues = values)
			fixed (byte* nativeLabelFmt = labelFmt)
			{
				ImPlotNative.PlotPieChartU64PtrStr(nativeLabelIds, nativeValues, count, x, y, radius, nativeLabelFmt, angle0, flags);
			}
		}

		public static void PlotPieChartU64PtrStr(ref byte* labelIds, ulong[] values, int count, double x, double y, double radius, ReadOnlySpan<char> labelFmt, double angle0, ImPlotPieChartFlags flags)
		{
			// Marshaling labelFmt to native string
			byte* nativeLabelFmt;
			var byteCountLabelFmt = 0;
			if (labelFmt != null && !labelFmt.IsEmpty)
			{
				byteCountLabelFmt = Encoding.UTF8.GetByteCount(labelFmt);
				if(byteCountLabelFmt > Utils.MaxStackallocSize)
				{
					nativeLabelFmt = Utils.Alloc<byte>(byteCountLabelFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelFmt + 1];
					nativeLabelFmt = stackallocBytes;
				}
				var offsetLabelFmt = Utils.EncodeStringUTF8(labelFmt, nativeLabelFmt, byteCountLabelFmt);
				nativeLabelFmt[offsetLabelFmt] = 0;
			}
			else nativeLabelFmt = null;

			fixed (byte** nativeLabelIds = &labelIds)
			fixed (ulong* nativeValues = values)
			{
				ImPlotNative.PlotPieChartU64PtrStr(nativeLabelIds, nativeValues, count, x, y, radius, nativeLabelFmt, angle0, flags);
				// Freeing labelFmt native string
				if (byteCountLabelFmt > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelFmt);
			}
		}

		public static void PlotHeatmapFloatPtr(ReadOnlySpan<byte> labelId, float[] values, int rows, int cols, double scaleMin, double scaleMax, ReadOnlySpan<byte> labelFmt, ImPlotPoint boundsMin, ImPlotPoint boundsMax, ImPlotHeatmapFlags flags)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (float* nativeValues = values)
			fixed (byte* nativeLabelFmt = labelFmt)
			{
				ImPlotNative.PlotHeatmapFloatPtr(nativeLabelId, nativeValues, rows, cols, scaleMin, scaleMax, nativeLabelFmt, boundsMin, boundsMax, flags);
			}
		}

		public static void PlotHeatmapFloatPtr(ReadOnlySpan<char> labelId, float[] values, int rows, int cols, double scaleMin, double scaleMax, ReadOnlySpan<char> labelFmt, ImPlotPoint boundsMin, ImPlotPoint boundsMax, ImPlotHeatmapFlags flags)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			// Marshaling labelFmt to native string
			byte* nativeLabelFmt;
			var byteCountLabelFmt = 0;
			if (labelFmt != null && !labelFmt.IsEmpty)
			{
				byteCountLabelFmt = Encoding.UTF8.GetByteCount(labelFmt);
				if(byteCountLabelFmt > Utils.MaxStackallocSize)
				{
					nativeLabelFmt = Utils.Alloc<byte>(byteCountLabelFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelFmt + 1];
					nativeLabelFmt = stackallocBytes;
				}
				var offsetLabelFmt = Utils.EncodeStringUTF8(labelFmt, nativeLabelFmt, byteCountLabelFmt);
				nativeLabelFmt[offsetLabelFmt] = 0;
			}
			else nativeLabelFmt = null;

			fixed (float* nativeValues = values)
			{
				ImPlotNative.PlotHeatmapFloatPtr(nativeLabelId, nativeValues, rows, cols, scaleMin, scaleMax, nativeLabelFmt, boundsMin, boundsMax, flags);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
				// Freeing labelFmt native string
				if (byteCountLabelFmt > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelFmt);
			}
		}

		public static void PlotHeatmapDoublePtr(ReadOnlySpan<byte> labelId, double[] values, int rows, int cols, double scaleMin, double scaleMax, ReadOnlySpan<byte> labelFmt, ImPlotPoint boundsMin, ImPlotPoint boundsMax, ImPlotHeatmapFlags flags)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (double* nativeValues = values)
			fixed (byte* nativeLabelFmt = labelFmt)
			{
				ImPlotNative.PlotHeatmapDoublePtr(nativeLabelId, nativeValues, rows, cols, scaleMin, scaleMax, nativeLabelFmt, boundsMin, boundsMax, flags);
			}
		}

		public static void PlotHeatmapDoublePtr(ReadOnlySpan<char> labelId, double[] values, int rows, int cols, double scaleMin, double scaleMax, ReadOnlySpan<char> labelFmt, ImPlotPoint boundsMin, ImPlotPoint boundsMax, ImPlotHeatmapFlags flags)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			// Marshaling labelFmt to native string
			byte* nativeLabelFmt;
			var byteCountLabelFmt = 0;
			if (labelFmt != null && !labelFmt.IsEmpty)
			{
				byteCountLabelFmt = Encoding.UTF8.GetByteCount(labelFmt);
				if(byteCountLabelFmt > Utils.MaxStackallocSize)
				{
					nativeLabelFmt = Utils.Alloc<byte>(byteCountLabelFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelFmt + 1];
					nativeLabelFmt = stackallocBytes;
				}
				var offsetLabelFmt = Utils.EncodeStringUTF8(labelFmt, nativeLabelFmt, byteCountLabelFmt);
				nativeLabelFmt[offsetLabelFmt] = 0;
			}
			else nativeLabelFmt = null;

			fixed (double* nativeValues = values)
			{
				ImPlotNative.PlotHeatmapDoublePtr(nativeLabelId, nativeValues, rows, cols, scaleMin, scaleMax, nativeLabelFmt, boundsMin, boundsMax, flags);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
				// Freeing labelFmt native string
				if (byteCountLabelFmt > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelFmt);
			}
		}

		public static void PlotHeatmapS8Ptr(ReadOnlySpan<byte> labelId, sbyte[] values, int rows, int cols, double scaleMin, double scaleMax, ReadOnlySpan<byte> labelFmt, ImPlotPoint boundsMin, ImPlotPoint boundsMax, ImPlotHeatmapFlags flags)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (sbyte* nativeValues = values)
			fixed (byte* nativeLabelFmt = labelFmt)
			{
				ImPlotNative.PlotHeatmapS8Ptr(nativeLabelId, nativeValues, rows, cols, scaleMin, scaleMax, nativeLabelFmt, boundsMin, boundsMax, flags);
			}
		}

		public static void PlotHeatmapS8Ptr(ReadOnlySpan<char> labelId, sbyte[] values, int rows, int cols, double scaleMin, double scaleMax, ReadOnlySpan<char> labelFmt, ImPlotPoint boundsMin, ImPlotPoint boundsMax, ImPlotHeatmapFlags flags)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			// Marshaling labelFmt to native string
			byte* nativeLabelFmt;
			var byteCountLabelFmt = 0;
			if (labelFmt != null && !labelFmt.IsEmpty)
			{
				byteCountLabelFmt = Encoding.UTF8.GetByteCount(labelFmt);
				if(byteCountLabelFmt > Utils.MaxStackallocSize)
				{
					nativeLabelFmt = Utils.Alloc<byte>(byteCountLabelFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelFmt + 1];
					nativeLabelFmt = stackallocBytes;
				}
				var offsetLabelFmt = Utils.EncodeStringUTF8(labelFmt, nativeLabelFmt, byteCountLabelFmt);
				nativeLabelFmt[offsetLabelFmt] = 0;
			}
			else nativeLabelFmt = null;

			fixed (sbyte* nativeValues = values)
			{
				ImPlotNative.PlotHeatmapS8Ptr(nativeLabelId, nativeValues, rows, cols, scaleMin, scaleMax, nativeLabelFmt, boundsMin, boundsMax, flags);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
				// Freeing labelFmt native string
				if (byteCountLabelFmt > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelFmt);
			}
		}

		public static void PlotHeatmapU8Ptr(ReadOnlySpan<byte> labelId, byte[] values, int rows, int cols, double scaleMin, double scaleMax, ReadOnlySpan<byte> labelFmt, ImPlotPoint boundsMin, ImPlotPoint boundsMax, ImPlotHeatmapFlags flags)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (byte* nativeValues = values)
			fixed (byte* nativeLabelFmt = labelFmt)
			{
				ImPlotNative.PlotHeatmapU8Ptr(nativeLabelId, nativeValues, rows, cols, scaleMin, scaleMax, nativeLabelFmt, boundsMin, boundsMax, flags);
			}
		}

		public static void PlotHeatmapU8Ptr(ReadOnlySpan<char> labelId, byte[] values, int rows, int cols, double scaleMin, double scaleMax, ReadOnlySpan<char> labelFmt, ImPlotPoint boundsMin, ImPlotPoint boundsMax, ImPlotHeatmapFlags flags)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			// Marshaling labelFmt to native string
			byte* nativeLabelFmt;
			var byteCountLabelFmt = 0;
			if (labelFmt != null && !labelFmt.IsEmpty)
			{
				byteCountLabelFmt = Encoding.UTF8.GetByteCount(labelFmt);
				if(byteCountLabelFmt > Utils.MaxStackallocSize)
				{
					nativeLabelFmt = Utils.Alloc<byte>(byteCountLabelFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelFmt + 1];
					nativeLabelFmt = stackallocBytes;
				}
				var offsetLabelFmt = Utils.EncodeStringUTF8(labelFmt, nativeLabelFmt, byteCountLabelFmt);
				nativeLabelFmt[offsetLabelFmt] = 0;
			}
			else nativeLabelFmt = null;

			fixed (byte* nativeValues = values)
			{
				ImPlotNative.PlotHeatmapU8Ptr(nativeLabelId, nativeValues, rows, cols, scaleMin, scaleMax, nativeLabelFmt, boundsMin, boundsMax, flags);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
				// Freeing labelFmt native string
				if (byteCountLabelFmt > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelFmt);
			}
		}

		public static void PlotHeatmapS16Ptr(ReadOnlySpan<byte> labelId, short[] values, int rows, int cols, double scaleMin, double scaleMax, ReadOnlySpan<byte> labelFmt, ImPlotPoint boundsMin, ImPlotPoint boundsMax, ImPlotHeatmapFlags flags)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (short* nativeValues = values)
			fixed (byte* nativeLabelFmt = labelFmt)
			{
				ImPlotNative.PlotHeatmapS16Ptr(nativeLabelId, nativeValues, rows, cols, scaleMin, scaleMax, nativeLabelFmt, boundsMin, boundsMax, flags);
			}
		}

		public static void PlotHeatmapS16Ptr(ReadOnlySpan<char> labelId, short[] values, int rows, int cols, double scaleMin, double scaleMax, ReadOnlySpan<char> labelFmt, ImPlotPoint boundsMin, ImPlotPoint boundsMax, ImPlotHeatmapFlags flags)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			// Marshaling labelFmt to native string
			byte* nativeLabelFmt;
			var byteCountLabelFmt = 0;
			if (labelFmt != null && !labelFmt.IsEmpty)
			{
				byteCountLabelFmt = Encoding.UTF8.GetByteCount(labelFmt);
				if(byteCountLabelFmt > Utils.MaxStackallocSize)
				{
					nativeLabelFmt = Utils.Alloc<byte>(byteCountLabelFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelFmt + 1];
					nativeLabelFmt = stackallocBytes;
				}
				var offsetLabelFmt = Utils.EncodeStringUTF8(labelFmt, nativeLabelFmt, byteCountLabelFmt);
				nativeLabelFmt[offsetLabelFmt] = 0;
			}
			else nativeLabelFmt = null;

			fixed (short* nativeValues = values)
			{
				ImPlotNative.PlotHeatmapS16Ptr(nativeLabelId, nativeValues, rows, cols, scaleMin, scaleMax, nativeLabelFmt, boundsMin, boundsMax, flags);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
				// Freeing labelFmt native string
				if (byteCountLabelFmt > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelFmt);
			}
		}

		public static void PlotHeatmapU16Ptr(ReadOnlySpan<byte> labelId, ushort[] values, int rows, int cols, double scaleMin, double scaleMax, ReadOnlySpan<byte> labelFmt, ImPlotPoint boundsMin, ImPlotPoint boundsMax, ImPlotHeatmapFlags flags)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ushort* nativeValues = values)
			fixed (byte* nativeLabelFmt = labelFmt)
			{
				ImPlotNative.PlotHeatmapU16Ptr(nativeLabelId, nativeValues, rows, cols, scaleMin, scaleMax, nativeLabelFmt, boundsMin, boundsMax, flags);
			}
		}

		public static void PlotHeatmapU16Ptr(ReadOnlySpan<char> labelId, ushort[] values, int rows, int cols, double scaleMin, double scaleMax, ReadOnlySpan<char> labelFmt, ImPlotPoint boundsMin, ImPlotPoint boundsMax, ImPlotHeatmapFlags flags)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			// Marshaling labelFmt to native string
			byte* nativeLabelFmt;
			var byteCountLabelFmt = 0;
			if (labelFmt != null && !labelFmt.IsEmpty)
			{
				byteCountLabelFmt = Encoding.UTF8.GetByteCount(labelFmt);
				if(byteCountLabelFmt > Utils.MaxStackallocSize)
				{
					nativeLabelFmt = Utils.Alloc<byte>(byteCountLabelFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelFmt + 1];
					nativeLabelFmt = stackallocBytes;
				}
				var offsetLabelFmt = Utils.EncodeStringUTF8(labelFmt, nativeLabelFmt, byteCountLabelFmt);
				nativeLabelFmt[offsetLabelFmt] = 0;
			}
			else nativeLabelFmt = null;

			fixed (ushort* nativeValues = values)
			{
				ImPlotNative.PlotHeatmapU16Ptr(nativeLabelId, nativeValues, rows, cols, scaleMin, scaleMax, nativeLabelFmt, boundsMin, boundsMax, flags);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
				// Freeing labelFmt native string
				if (byteCountLabelFmt > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelFmt);
			}
		}

		public static void PlotHeatmapS32Ptr(ReadOnlySpan<byte> labelId, int[] values, int rows, int cols, double scaleMin, double scaleMax, ReadOnlySpan<byte> labelFmt, ImPlotPoint boundsMin, ImPlotPoint boundsMax, ImPlotHeatmapFlags flags)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (int* nativeValues = values)
			fixed (byte* nativeLabelFmt = labelFmt)
			{
				ImPlotNative.PlotHeatmapS32Ptr(nativeLabelId, nativeValues, rows, cols, scaleMin, scaleMax, nativeLabelFmt, boundsMin, boundsMax, flags);
			}
		}

		public static void PlotHeatmapS32Ptr(ReadOnlySpan<char> labelId, int[] values, int rows, int cols, double scaleMin, double scaleMax, ReadOnlySpan<char> labelFmt, ImPlotPoint boundsMin, ImPlotPoint boundsMax, ImPlotHeatmapFlags flags)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			// Marshaling labelFmt to native string
			byte* nativeLabelFmt;
			var byteCountLabelFmt = 0;
			if (labelFmt != null && !labelFmt.IsEmpty)
			{
				byteCountLabelFmt = Encoding.UTF8.GetByteCount(labelFmt);
				if(byteCountLabelFmt > Utils.MaxStackallocSize)
				{
					nativeLabelFmt = Utils.Alloc<byte>(byteCountLabelFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelFmt + 1];
					nativeLabelFmt = stackallocBytes;
				}
				var offsetLabelFmt = Utils.EncodeStringUTF8(labelFmt, nativeLabelFmt, byteCountLabelFmt);
				nativeLabelFmt[offsetLabelFmt] = 0;
			}
			else nativeLabelFmt = null;

			fixed (int* nativeValues = values)
			{
				ImPlotNative.PlotHeatmapS32Ptr(nativeLabelId, nativeValues, rows, cols, scaleMin, scaleMax, nativeLabelFmt, boundsMin, boundsMax, flags);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
				// Freeing labelFmt native string
				if (byteCountLabelFmt > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelFmt);
			}
		}

		public static void PlotHeatmapU32Ptr(ReadOnlySpan<byte> labelId, uint[] values, int rows, int cols, double scaleMin, double scaleMax, ReadOnlySpan<byte> labelFmt, ImPlotPoint boundsMin, ImPlotPoint boundsMax, ImPlotHeatmapFlags flags)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (uint* nativeValues = values)
			fixed (byte* nativeLabelFmt = labelFmt)
			{
				ImPlotNative.PlotHeatmapU32Ptr(nativeLabelId, nativeValues, rows, cols, scaleMin, scaleMax, nativeLabelFmt, boundsMin, boundsMax, flags);
			}
		}

		public static void PlotHeatmapU32Ptr(ReadOnlySpan<char> labelId, uint[] values, int rows, int cols, double scaleMin, double scaleMax, ReadOnlySpan<char> labelFmt, ImPlotPoint boundsMin, ImPlotPoint boundsMax, ImPlotHeatmapFlags flags)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			// Marshaling labelFmt to native string
			byte* nativeLabelFmt;
			var byteCountLabelFmt = 0;
			if (labelFmt != null && !labelFmt.IsEmpty)
			{
				byteCountLabelFmt = Encoding.UTF8.GetByteCount(labelFmt);
				if(byteCountLabelFmt > Utils.MaxStackallocSize)
				{
					nativeLabelFmt = Utils.Alloc<byte>(byteCountLabelFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelFmt + 1];
					nativeLabelFmt = stackallocBytes;
				}
				var offsetLabelFmt = Utils.EncodeStringUTF8(labelFmt, nativeLabelFmt, byteCountLabelFmt);
				nativeLabelFmt[offsetLabelFmt] = 0;
			}
			else nativeLabelFmt = null;

			fixed (uint* nativeValues = values)
			{
				ImPlotNative.PlotHeatmapU32Ptr(nativeLabelId, nativeValues, rows, cols, scaleMin, scaleMax, nativeLabelFmt, boundsMin, boundsMax, flags);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
				// Freeing labelFmt native string
				if (byteCountLabelFmt > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelFmt);
			}
		}

		public static void PlotHeatmapS64Ptr(ReadOnlySpan<byte> labelId, long[] values, int rows, int cols, double scaleMin, double scaleMax, ReadOnlySpan<byte> labelFmt, ImPlotPoint boundsMin, ImPlotPoint boundsMax, ImPlotHeatmapFlags flags)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (long* nativeValues = values)
			fixed (byte* nativeLabelFmt = labelFmt)
			{
				ImPlotNative.PlotHeatmapS64Ptr(nativeLabelId, nativeValues, rows, cols, scaleMin, scaleMax, nativeLabelFmt, boundsMin, boundsMax, flags);
			}
		}

		public static void PlotHeatmapS64Ptr(ReadOnlySpan<char> labelId, long[] values, int rows, int cols, double scaleMin, double scaleMax, ReadOnlySpan<char> labelFmt, ImPlotPoint boundsMin, ImPlotPoint boundsMax, ImPlotHeatmapFlags flags)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			// Marshaling labelFmt to native string
			byte* nativeLabelFmt;
			var byteCountLabelFmt = 0;
			if (labelFmt != null && !labelFmt.IsEmpty)
			{
				byteCountLabelFmt = Encoding.UTF8.GetByteCount(labelFmt);
				if(byteCountLabelFmt > Utils.MaxStackallocSize)
				{
					nativeLabelFmt = Utils.Alloc<byte>(byteCountLabelFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelFmt + 1];
					nativeLabelFmt = stackallocBytes;
				}
				var offsetLabelFmt = Utils.EncodeStringUTF8(labelFmt, nativeLabelFmt, byteCountLabelFmt);
				nativeLabelFmt[offsetLabelFmt] = 0;
			}
			else nativeLabelFmt = null;

			fixed (long* nativeValues = values)
			{
				ImPlotNative.PlotHeatmapS64Ptr(nativeLabelId, nativeValues, rows, cols, scaleMin, scaleMax, nativeLabelFmt, boundsMin, boundsMax, flags);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
				// Freeing labelFmt native string
				if (byteCountLabelFmt > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelFmt);
			}
		}

		public static void PlotHeatmapU64Ptr(ReadOnlySpan<byte> labelId, ulong[] values, int rows, int cols, double scaleMin, double scaleMax, ReadOnlySpan<byte> labelFmt, ImPlotPoint boundsMin, ImPlotPoint boundsMax, ImPlotHeatmapFlags flags)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ulong* nativeValues = values)
			fixed (byte* nativeLabelFmt = labelFmt)
			{
				ImPlotNative.PlotHeatmapU64Ptr(nativeLabelId, nativeValues, rows, cols, scaleMin, scaleMax, nativeLabelFmt, boundsMin, boundsMax, flags);
			}
		}

		public static void PlotHeatmapU64Ptr(ReadOnlySpan<char> labelId, ulong[] values, int rows, int cols, double scaleMin, double scaleMax, ReadOnlySpan<char> labelFmt, ImPlotPoint boundsMin, ImPlotPoint boundsMax, ImPlotHeatmapFlags flags)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			// Marshaling labelFmt to native string
			byte* nativeLabelFmt;
			var byteCountLabelFmt = 0;
			if (labelFmt != null && !labelFmt.IsEmpty)
			{
				byteCountLabelFmt = Encoding.UTF8.GetByteCount(labelFmt);
				if(byteCountLabelFmt > Utils.MaxStackallocSize)
				{
					nativeLabelFmt = Utils.Alloc<byte>(byteCountLabelFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelFmt + 1];
					nativeLabelFmt = stackallocBytes;
				}
				var offsetLabelFmt = Utils.EncodeStringUTF8(labelFmt, nativeLabelFmt, byteCountLabelFmt);
				nativeLabelFmt[offsetLabelFmt] = 0;
			}
			else nativeLabelFmt = null;

			fixed (ulong* nativeValues = values)
			{
				ImPlotNative.PlotHeatmapU64Ptr(nativeLabelId, nativeValues, rows, cols, scaleMin, scaleMax, nativeLabelFmt, boundsMin, boundsMax, flags);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
				// Freeing labelFmt native string
				if (byteCountLabelFmt > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelFmt);
			}
		}

		public static double PlotHistogramFloatPtr(ReadOnlySpan<byte> labelId, float[] values, int count, int bins, double barScale, ImPlotRange range, ImPlotHistogramFlags flags)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (float* nativeValues = values)
			{
				return ImPlotNative.PlotHistogramFloatPtr(nativeLabelId, nativeValues, count, bins, barScale, range, flags);
			}
		}

		public static double PlotHistogramFloatPtr(ReadOnlySpan<char> labelId, float[] values, int count, int bins, double barScale, ImPlotRange range, ImPlotHistogramFlags flags)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (float* nativeValues = values)
			{
				var result = ImPlotNative.PlotHistogramFloatPtr(nativeLabelId, nativeValues, count, bins, barScale, range, flags);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
				return result;
			}
		}

		public static double PlotHistogramDoublePtr(ReadOnlySpan<byte> labelId, double[] values, int count, int bins, double barScale, ImPlotRange range, ImPlotHistogramFlags flags)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (double* nativeValues = values)
			{
				return ImPlotNative.PlotHistogramDoublePtr(nativeLabelId, nativeValues, count, bins, barScale, range, flags);
			}
		}

		public static double PlotHistogramDoublePtr(ReadOnlySpan<char> labelId, double[] values, int count, int bins, double barScale, ImPlotRange range, ImPlotHistogramFlags flags)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (double* nativeValues = values)
			{
				var result = ImPlotNative.PlotHistogramDoublePtr(nativeLabelId, nativeValues, count, bins, barScale, range, flags);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
				return result;
			}
		}

		public static double PlotHistogramS8Ptr(ReadOnlySpan<byte> labelId, sbyte[] values, int count, int bins, double barScale, ImPlotRange range, ImPlotHistogramFlags flags)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (sbyte* nativeValues = values)
			{
				return ImPlotNative.PlotHistogramS8Ptr(nativeLabelId, nativeValues, count, bins, barScale, range, flags);
			}
		}

		public static double PlotHistogramS8Ptr(ReadOnlySpan<char> labelId, sbyte[] values, int count, int bins, double barScale, ImPlotRange range, ImPlotHistogramFlags flags)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (sbyte* nativeValues = values)
			{
				var result = ImPlotNative.PlotHistogramS8Ptr(nativeLabelId, nativeValues, count, bins, barScale, range, flags);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
				return result;
			}
		}

		public static double PlotHistogramU8Ptr(ReadOnlySpan<byte> labelId, byte[] values, int count, int bins, double barScale, ImPlotRange range, ImPlotHistogramFlags flags)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (byte* nativeValues = values)
			{
				return ImPlotNative.PlotHistogramU8Ptr(nativeLabelId, nativeValues, count, bins, barScale, range, flags);
			}
		}

		public static double PlotHistogramU8Ptr(ReadOnlySpan<char> labelId, byte[] values, int count, int bins, double barScale, ImPlotRange range, ImPlotHistogramFlags flags)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (byte* nativeValues = values)
			{
				var result = ImPlotNative.PlotHistogramU8Ptr(nativeLabelId, nativeValues, count, bins, barScale, range, flags);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
				return result;
			}
		}

		public static double PlotHistogramS16Ptr(ReadOnlySpan<byte> labelId, short[] values, int count, int bins, double barScale, ImPlotRange range, ImPlotHistogramFlags flags)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (short* nativeValues = values)
			{
				return ImPlotNative.PlotHistogramS16Ptr(nativeLabelId, nativeValues, count, bins, barScale, range, flags);
			}
		}

		public static double PlotHistogramS16Ptr(ReadOnlySpan<char> labelId, short[] values, int count, int bins, double barScale, ImPlotRange range, ImPlotHistogramFlags flags)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (short* nativeValues = values)
			{
				var result = ImPlotNative.PlotHistogramS16Ptr(nativeLabelId, nativeValues, count, bins, barScale, range, flags);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
				return result;
			}
		}

		public static double PlotHistogramU16Ptr(ReadOnlySpan<byte> labelId, ushort[] values, int count, int bins, double barScale, ImPlotRange range, ImPlotHistogramFlags flags)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ushort* nativeValues = values)
			{
				return ImPlotNative.PlotHistogramU16Ptr(nativeLabelId, nativeValues, count, bins, barScale, range, flags);
			}
		}

		public static double PlotHistogramU16Ptr(ReadOnlySpan<char> labelId, ushort[] values, int count, int bins, double barScale, ImPlotRange range, ImPlotHistogramFlags flags)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (ushort* nativeValues = values)
			{
				var result = ImPlotNative.PlotHistogramU16Ptr(nativeLabelId, nativeValues, count, bins, barScale, range, flags);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
				return result;
			}
		}

		public static double PlotHistogramS32Ptr(ReadOnlySpan<byte> labelId, int[] values, int count, int bins, double barScale, ImPlotRange range, ImPlotHistogramFlags flags)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (int* nativeValues = values)
			{
				return ImPlotNative.PlotHistogramS32Ptr(nativeLabelId, nativeValues, count, bins, barScale, range, flags);
			}
		}

		public static double PlotHistogramS32Ptr(ReadOnlySpan<char> labelId, int[] values, int count, int bins, double barScale, ImPlotRange range, ImPlotHistogramFlags flags)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (int* nativeValues = values)
			{
				var result = ImPlotNative.PlotHistogramS32Ptr(nativeLabelId, nativeValues, count, bins, barScale, range, flags);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
				return result;
			}
		}

		public static double PlotHistogramU32Ptr(ReadOnlySpan<byte> labelId, uint[] values, int count, int bins, double barScale, ImPlotRange range, ImPlotHistogramFlags flags)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (uint* nativeValues = values)
			{
				return ImPlotNative.PlotHistogramU32Ptr(nativeLabelId, nativeValues, count, bins, barScale, range, flags);
			}
		}

		public static double PlotHistogramU32Ptr(ReadOnlySpan<char> labelId, uint[] values, int count, int bins, double barScale, ImPlotRange range, ImPlotHistogramFlags flags)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (uint* nativeValues = values)
			{
				var result = ImPlotNative.PlotHistogramU32Ptr(nativeLabelId, nativeValues, count, bins, barScale, range, flags);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
				return result;
			}
		}

		public static double PlotHistogramS64Ptr(ReadOnlySpan<byte> labelId, long[] values, int count, int bins, double barScale, ImPlotRange range, ImPlotHistogramFlags flags)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (long* nativeValues = values)
			{
				return ImPlotNative.PlotHistogramS64Ptr(nativeLabelId, nativeValues, count, bins, barScale, range, flags);
			}
		}

		public static double PlotHistogramS64Ptr(ReadOnlySpan<char> labelId, long[] values, int count, int bins, double barScale, ImPlotRange range, ImPlotHistogramFlags flags)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (long* nativeValues = values)
			{
				var result = ImPlotNative.PlotHistogramS64Ptr(nativeLabelId, nativeValues, count, bins, barScale, range, flags);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
				return result;
			}
		}

		public static double PlotHistogramU64Ptr(ReadOnlySpan<byte> labelId, ulong[] values, int count, int bins, double barScale, ImPlotRange range, ImPlotHistogramFlags flags)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ulong* nativeValues = values)
			{
				return ImPlotNative.PlotHistogramU64Ptr(nativeLabelId, nativeValues, count, bins, barScale, range, flags);
			}
		}

		public static double PlotHistogramU64Ptr(ReadOnlySpan<char> labelId, ulong[] values, int count, int bins, double barScale, ImPlotRange range, ImPlotHistogramFlags flags)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (ulong* nativeValues = values)
			{
				var result = ImPlotNative.PlotHistogramU64Ptr(nativeLabelId, nativeValues, count, bins, barScale, range, flags);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
				return result;
			}
		}

		public static double PlotHistogram2DFloatPtr(ReadOnlySpan<byte> labelId, float[] xs, float[] ys, int count, int xBins, int yBins, ImPlotRect range, ImPlotHistogramFlags flags)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (float* nativeXs = xs)
			fixed (float* nativeYs = ys)
			{
				return ImPlotNative.PlotHistogram2DFloatPtr(nativeLabelId, nativeXs, nativeYs, count, xBins, yBins, range, flags);
			}
		}

		public static double PlotHistogram2DFloatPtr(ReadOnlySpan<char> labelId, float[] xs, float[] ys, int count, int xBins, int yBins, ImPlotRect range, ImPlotHistogramFlags flags)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (float* nativeXs = xs)
			fixed (float* nativeYs = ys)
			{
				var result = ImPlotNative.PlotHistogram2DFloatPtr(nativeLabelId, nativeXs, nativeYs, count, xBins, yBins, range, flags);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
				return result;
			}
		}

		public static double PlotHistogram2DDoublePtr(ReadOnlySpan<byte> labelId, double[] xs, double[] ys, int count, int xBins, int yBins, ImPlotRect range, ImPlotHistogramFlags flags)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (double* nativeXs = xs)
			fixed (double* nativeYs = ys)
			{
				return ImPlotNative.PlotHistogram2DDoublePtr(nativeLabelId, nativeXs, nativeYs, count, xBins, yBins, range, flags);
			}
		}

		public static double PlotHistogram2DDoublePtr(ReadOnlySpan<char> labelId, double[] xs, double[] ys, int count, int xBins, int yBins, ImPlotRect range, ImPlotHistogramFlags flags)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (double* nativeXs = xs)
			fixed (double* nativeYs = ys)
			{
				var result = ImPlotNative.PlotHistogram2DDoublePtr(nativeLabelId, nativeXs, nativeYs, count, xBins, yBins, range, flags);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
				return result;
			}
		}

		public static double PlotHistogram2DS8Ptr(ReadOnlySpan<byte> labelId, sbyte[] xs, sbyte[] ys, int count, int xBins, int yBins, ImPlotRect range, ImPlotHistogramFlags flags)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (sbyte* nativeXs = xs)
			fixed (sbyte* nativeYs = ys)
			{
				return ImPlotNative.PlotHistogram2DS8Ptr(nativeLabelId, nativeXs, nativeYs, count, xBins, yBins, range, flags);
			}
		}

		public static double PlotHistogram2DS8Ptr(ReadOnlySpan<char> labelId, sbyte[] xs, sbyte[] ys, int count, int xBins, int yBins, ImPlotRect range, ImPlotHistogramFlags flags)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (sbyte* nativeXs = xs)
			fixed (sbyte* nativeYs = ys)
			{
				var result = ImPlotNative.PlotHistogram2DS8Ptr(nativeLabelId, nativeXs, nativeYs, count, xBins, yBins, range, flags);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
				return result;
			}
		}

		public static double PlotHistogram2DU8Ptr(ReadOnlySpan<byte> labelId, byte[] xs, byte[] ys, int count, int xBins, int yBins, ImPlotRect range, ImPlotHistogramFlags flags)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (byte* nativeXs = xs)
			fixed (byte* nativeYs = ys)
			{
				return ImPlotNative.PlotHistogram2DU8Ptr(nativeLabelId, nativeXs, nativeYs, count, xBins, yBins, range, flags);
			}
		}

		public static double PlotHistogram2DU8Ptr(ReadOnlySpan<char> labelId, byte[] xs, byte[] ys, int count, int xBins, int yBins, ImPlotRect range, ImPlotHistogramFlags flags)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (byte* nativeXs = xs)
			fixed (byte* nativeYs = ys)
			{
				var result = ImPlotNative.PlotHistogram2DU8Ptr(nativeLabelId, nativeXs, nativeYs, count, xBins, yBins, range, flags);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
				return result;
			}
		}

		public static double PlotHistogram2DS16Ptr(ReadOnlySpan<byte> labelId, short[] xs, short[] ys, int count, int xBins, int yBins, ImPlotRect range, ImPlotHistogramFlags flags)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (short* nativeXs = xs)
			fixed (short* nativeYs = ys)
			{
				return ImPlotNative.PlotHistogram2DS16Ptr(nativeLabelId, nativeXs, nativeYs, count, xBins, yBins, range, flags);
			}
		}

		public static double PlotHistogram2DS16Ptr(ReadOnlySpan<char> labelId, short[] xs, short[] ys, int count, int xBins, int yBins, ImPlotRect range, ImPlotHistogramFlags flags)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (short* nativeXs = xs)
			fixed (short* nativeYs = ys)
			{
				var result = ImPlotNative.PlotHistogram2DS16Ptr(nativeLabelId, nativeXs, nativeYs, count, xBins, yBins, range, flags);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
				return result;
			}
		}

		public static double PlotHistogram2DU16Ptr(ReadOnlySpan<byte> labelId, ushort[] xs, ushort[] ys, int count, int xBins, int yBins, ImPlotRect range, ImPlotHistogramFlags flags)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ushort* nativeXs = xs)
			fixed (ushort* nativeYs = ys)
			{
				return ImPlotNative.PlotHistogram2DU16Ptr(nativeLabelId, nativeXs, nativeYs, count, xBins, yBins, range, flags);
			}
		}

		public static double PlotHistogram2DU16Ptr(ReadOnlySpan<char> labelId, ushort[] xs, ushort[] ys, int count, int xBins, int yBins, ImPlotRect range, ImPlotHistogramFlags flags)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (ushort* nativeXs = xs)
			fixed (ushort* nativeYs = ys)
			{
				var result = ImPlotNative.PlotHistogram2DU16Ptr(nativeLabelId, nativeXs, nativeYs, count, xBins, yBins, range, flags);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
				return result;
			}
		}

		public static double PlotHistogram2DS32Ptr(ReadOnlySpan<byte> labelId, int[] xs, int[] ys, int count, int xBins, int yBins, ImPlotRect range, ImPlotHistogramFlags flags)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (int* nativeXs = xs)
			fixed (int* nativeYs = ys)
			{
				return ImPlotNative.PlotHistogram2DS32Ptr(nativeLabelId, nativeXs, nativeYs, count, xBins, yBins, range, flags);
			}
		}

		public static double PlotHistogram2DS32Ptr(ReadOnlySpan<char> labelId, int[] xs, int[] ys, int count, int xBins, int yBins, ImPlotRect range, ImPlotHistogramFlags flags)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (int* nativeXs = xs)
			fixed (int* nativeYs = ys)
			{
				var result = ImPlotNative.PlotHistogram2DS32Ptr(nativeLabelId, nativeXs, nativeYs, count, xBins, yBins, range, flags);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
				return result;
			}
		}

		public static double PlotHistogram2DU32Ptr(ReadOnlySpan<byte> labelId, uint[] xs, uint[] ys, int count, int xBins, int yBins, ImPlotRect range, ImPlotHistogramFlags flags)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (uint* nativeXs = xs)
			fixed (uint* nativeYs = ys)
			{
				return ImPlotNative.PlotHistogram2DU32Ptr(nativeLabelId, nativeXs, nativeYs, count, xBins, yBins, range, flags);
			}
		}

		public static double PlotHistogram2DU32Ptr(ReadOnlySpan<char> labelId, uint[] xs, uint[] ys, int count, int xBins, int yBins, ImPlotRect range, ImPlotHistogramFlags flags)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (uint* nativeXs = xs)
			fixed (uint* nativeYs = ys)
			{
				var result = ImPlotNative.PlotHistogram2DU32Ptr(nativeLabelId, nativeXs, nativeYs, count, xBins, yBins, range, flags);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
				return result;
			}
		}

		public static double PlotHistogram2DS64Ptr(ReadOnlySpan<byte> labelId, long[] xs, long[] ys, int count, int xBins, int yBins, ImPlotRect range, ImPlotHistogramFlags flags)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (long* nativeXs = xs)
			fixed (long* nativeYs = ys)
			{
				return ImPlotNative.PlotHistogram2DS64Ptr(nativeLabelId, nativeXs, nativeYs, count, xBins, yBins, range, flags);
			}
		}

		public static double PlotHistogram2DS64Ptr(ReadOnlySpan<char> labelId, long[] xs, long[] ys, int count, int xBins, int yBins, ImPlotRect range, ImPlotHistogramFlags flags)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (long* nativeXs = xs)
			fixed (long* nativeYs = ys)
			{
				var result = ImPlotNative.PlotHistogram2DS64Ptr(nativeLabelId, nativeXs, nativeYs, count, xBins, yBins, range, flags);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
				return result;
			}
		}

		public static double PlotHistogram2DU64Ptr(ReadOnlySpan<byte> labelId, ulong[] xs, ulong[] ys, int count, int xBins, int yBins, ImPlotRect range, ImPlotHistogramFlags flags)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ulong* nativeXs = xs)
			fixed (ulong* nativeYs = ys)
			{
				return ImPlotNative.PlotHistogram2DU64Ptr(nativeLabelId, nativeXs, nativeYs, count, xBins, yBins, range, flags);
			}
		}

		public static double PlotHistogram2DU64Ptr(ReadOnlySpan<char> labelId, ulong[] xs, ulong[] ys, int count, int xBins, int yBins, ImPlotRect range, ImPlotHistogramFlags flags)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (ulong* nativeXs = xs)
			fixed (ulong* nativeYs = ys)
			{
				var result = ImPlotNative.PlotHistogram2DU64Ptr(nativeLabelId, nativeXs, nativeYs, count, xBins, yBins, range, flags);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
				return result;
			}
		}

		public static void PlotDigitalFloatPtr(ReadOnlySpan<byte> labelId, float[] xs, float[] ys, int count, ImPlotDigitalFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (float* nativeXs = xs)
			fixed (float* nativeYs = ys)
			{
				ImPlotNative.PlotDigitalFloatPtr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
			}
		}

		public static void PlotDigitalFloatPtr(ReadOnlySpan<char> labelId, float[] xs, float[] ys, int count, ImPlotDigitalFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (float* nativeXs = xs)
			fixed (float* nativeYs = ys)
			{
				ImPlotNative.PlotDigitalFloatPtr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotDigitalDoublePtr(ReadOnlySpan<byte> labelId, double[] xs, double[] ys, int count, ImPlotDigitalFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (double* nativeXs = xs)
			fixed (double* nativeYs = ys)
			{
				ImPlotNative.PlotDigitalDoublePtr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
			}
		}

		public static void PlotDigitalDoublePtr(ReadOnlySpan<char> labelId, double[] xs, double[] ys, int count, ImPlotDigitalFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (double* nativeXs = xs)
			fixed (double* nativeYs = ys)
			{
				ImPlotNative.PlotDigitalDoublePtr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotDigitalS8Ptr(ReadOnlySpan<byte> labelId, sbyte[] xs, sbyte[] ys, int count, ImPlotDigitalFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (sbyte* nativeXs = xs)
			fixed (sbyte* nativeYs = ys)
			{
				ImPlotNative.PlotDigitalS8Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
			}
		}

		public static void PlotDigitalS8Ptr(ReadOnlySpan<char> labelId, sbyte[] xs, sbyte[] ys, int count, ImPlotDigitalFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (sbyte* nativeXs = xs)
			fixed (sbyte* nativeYs = ys)
			{
				ImPlotNative.PlotDigitalS8Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotDigitalU8Ptr(ReadOnlySpan<byte> labelId, byte[] xs, byte[] ys, int count, ImPlotDigitalFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (byte* nativeXs = xs)
			fixed (byte* nativeYs = ys)
			{
				ImPlotNative.PlotDigitalU8Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
			}
		}

		public static void PlotDigitalU8Ptr(ReadOnlySpan<char> labelId, byte[] xs, byte[] ys, int count, ImPlotDigitalFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (byte* nativeXs = xs)
			fixed (byte* nativeYs = ys)
			{
				ImPlotNative.PlotDigitalU8Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotDigitalS16Ptr(ReadOnlySpan<byte> labelId, short[] xs, short[] ys, int count, ImPlotDigitalFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (short* nativeXs = xs)
			fixed (short* nativeYs = ys)
			{
				ImPlotNative.PlotDigitalS16Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
			}
		}

		public static void PlotDigitalS16Ptr(ReadOnlySpan<char> labelId, short[] xs, short[] ys, int count, ImPlotDigitalFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (short* nativeXs = xs)
			fixed (short* nativeYs = ys)
			{
				ImPlotNative.PlotDigitalS16Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotDigitalU16Ptr(ReadOnlySpan<byte> labelId, ushort[] xs, ushort[] ys, int count, ImPlotDigitalFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ushort* nativeXs = xs)
			fixed (ushort* nativeYs = ys)
			{
				ImPlotNative.PlotDigitalU16Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
			}
		}

		public static void PlotDigitalU16Ptr(ReadOnlySpan<char> labelId, ushort[] xs, ushort[] ys, int count, ImPlotDigitalFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (ushort* nativeXs = xs)
			fixed (ushort* nativeYs = ys)
			{
				ImPlotNative.PlotDigitalU16Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotDigitalS32Ptr(ReadOnlySpan<byte> labelId, int[] xs, int[] ys, int count, ImPlotDigitalFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (int* nativeXs = xs)
			fixed (int* nativeYs = ys)
			{
				ImPlotNative.PlotDigitalS32Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
			}
		}

		public static void PlotDigitalS32Ptr(ReadOnlySpan<char> labelId, int[] xs, int[] ys, int count, ImPlotDigitalFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (int* nativeXs = xs)
			fixed (int* nativeYs = ys)
			{
				ImPlotNative.PlotDigitalS32Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotDigitalU32Ptr(ReadOnlySpan<byte> labelId, uint[] xs, uint[] ys, int count, ImPlotDigitalFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (uint* nativeXs = xs)
			fixed (uint* nativeYs = ys)
			{
				ImPlotNative.PlotDigitalU32Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
			}
		}

		public static void PlotDigitalU32Ptr(ReadOnlySpan<char> labelId, uint[] xs, uint[] ys, int count, ImPlotDigitalFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (uint* nativeXs = xs)
			fixed (uint* nativeYs = ys)
			{
				ImPlotNative.PlotDigitalU32Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotDigitalS64Ptr(ReadOnlySpan<byte> labelId, long[] xs, long[] ys, int count, ImPlotDigitalFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (long* nativeXs = xs)
			fixed (long* nativeYs = ys)
			{
				ImPlotNative.PlotDigitalS64Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
			}
		}

		public static void PlotDigitalS64Ptr(ReadOnlySpan<char> labelId, long[] xs, long[] ys, int count, ImPlotDigitalFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (long* nativeXs = xs)
			fixed (long* nativeYs = ys)
			{
				ImPlotNative.PlotDigitalS64Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotDigitalU64Ptr(ReadOnlySpan<byte> labelId, ulong[] xs, ulong[] ys, int count, ImPlotDigitalFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ulong* nativeXs = xs)
			fixed (ulong* nativeYs = ys)
			{
				ImPlotNative.PlotDigitalU64Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
			}
		}

		public static void PlotDigitalU64Ptr(ReadOnlySpan<char> labelId, ulong[] xs, ulong[] ys, int count, ImPlotDigitalFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			fixed (ulong* nativeXs = xs)
			fixed (ulong* nativeYs = ys)
			{
				ImPlotNative.PlotDigitalU64Ptr(nativeLabelId, nativeXs, nativeYs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotDigitalG(ReadOnlySpan<byte> labelId, ImPlotPointGetter getter, IntPtr data, int count, ImPlotDigitalFlags flags)
		{
			fixed (byte* nativeLabelId = labelId)
			{
				ImPlotNative.PlotDigitalG(nativeLabelId, getter, (void*)data, count, flags);
			}
		}

		public static void PlotDigitalG(ReadOnlySpan<char> labelId, ImPlotPointGetter getter, IntPtr data, int count, ImPlotDigitalFlags flags)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			ImPlotNative.PlotDigitalG(nativeLabelId, getter, (void*)data, count, flags);
			// Freeing labelId native string
			if (byteCountLabelId > Utils.MaxStackallocSize)
				Utils.Free(nativeLabelId);
		}

		public static void PlotDigitalG(ReadOnlySpan<byte> labelId, ImPlotPointGetter getter, IntPtr data, int count)
		{
			// defining omitted parameters
			ImPlotDigitalFlags flags = ImPlotDigitalFlags.None;
			fixed (byte* nativeLabelId = labelId)
			{
				ImPlotNative.PlotDigitalG(nativeLabelId, getter, (void*)data, count, flags);
			}
		}

		public static void PlotDigitalG(ReadOnlySpan<char> labelId, ImPlotPointGetter getter, IntPtr data, int count)
		{
			// defining omitted parameters
			ImPlotDigitalFlags flags = ImPlotDigitalFlags.None;
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			ImPlotNative.PlotDigitalG(nativeLabelId, getter, (void*)data, count, flags);
			// Freeing labelId native string
			if (byteCountLabelId > Utils.MaxStackallocSize)
				Utils.Free(nativeLabelId);
		}

		public static void PlotImage(ReadOnlySpan<byte> labelId, ulong userTextureId, ImPlotPoint boundsMin, ImPlotPoint boundsMax, Vector2 uv0, Vector2 uv1, Vector4 tintCol, ImPlotImageFlags flags)
		{
			fixed (byte* nativeLabelId = labelId)
			{
				ImPlotNative.PlotImage(nativeLabelId, userTextureId, boundsMin, boundsMax, uv0, uv1, tintCol, flags);
			}
		}

		public static void PlotImage(ReadOnlySpan<char> labelId, ulong userTextureId, ImPlotPoint boundsMin, ImPlotPoint boundsMax, Vector2 uv0, Vector2 uv1, Vector4 tintCol, ImPlotImageFlags flags)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			ImPlotNative.PlotImage(nativeLabelId, userTextureId, boundsMin, boundsMax, uv0, uv1, tintCol, flags);
			// Freeing labelId native string
			if (byteCountLabelId > Utils.MaxStackallocSize)
				Utils.Free(nativeLabelId);
		}

		public static void PlotImage(ReadOnlySpan<byte> labelId, ulong userTextureId, ImPlotPoint boundsMin, ImPlotPoint boundsMax, Vector2 uv0, Vector2 uv1, Vector4 tintCol)
		{
			// defining omitted parameters
			ImPlotImageFlags flags = ImPlotImageFlags.None;
			fixed (byte* nativeLabelId = labelId)
			{
				ImPlotNative.PlotImage(nativeLabelId, userTextureId, boundsMin, boundsMax, uv0, uv1, tintCol, flags);
			}
		}

		public static void PlotImage(ReadOnlySpan<char> labelId, ulong userTextureId, ImPlotPoint boundsMin, ImPlotPoint boundsMax, Vector2 uv0, Vector2 uv1, Vector4 tintCol)
		{
			// defining omitted parameters
			ImPlotImageFlags flags = ImPlotImageFlags.None;
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			ImPlotNative.PlotImage(nativeLabelId, userTextureId, boundsMin, boundsMax, uv0, uv1, tintCol, flags);
			// Freeing labelId native string
			if (byteCountLabelId > Utils.MaxStackallocSize)
				Utils.Free(nativeLabelId);
		}

		public static void PlotImage(ReadOnlySpan<byte> labelId, ulong userTextureId, ImPlotPoint boundsMin, ImPlotPoint boundsMax, Vector2 uv0, Vector2 uv1)
		{
			// defining omitted parameters
			ImPlotImageFlags flags = ImPlotImageFlags.None;
			Vector4 tintCol = new Vector4(1,1,1,1);
			fixed (byte* nativeLabelId = labelId)
			{
				ImPlotNative.PlotImage(nativeLabelId, userTextureId, boundsMin, boundsMax, uv0, uv1, tintCol, flags);
			}
		}

		public static void PlotImage(ReadOnlySpan<char> labelId, ulong userTextureId, ImPlotPoint boundsMin, ImPlotPoint boundsMax, Vector2 uv0, Vector2 uv1)
		{
			// defining omitted parameters
			ImPlotImageFlags flags = ImPlotImageFlags.None;
			Vector4 tintCol = new Vector4(1,1,1,1);
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			ImPlotNative.PlotImage(nativeLabelId, userTextureId, boundsMin, boundsMax, uv0, uv1, tintCol, flags);
			// Freeing labelId native string
			if (byteCountLabelId > Utils.MaxStackallocSize)
				Utils.Free(nativeLabelId);
		}

		public static void PlotImage(ReadOnlySpan<byte> labelId, ulong userTextureId, ImPlotPoint boundsMin, ImPlotPoint boundsMax, Vector2 uv0)
		{
			// defining omitted parameters
			ImPlotImageFlags flags = ImPlotImageFlags.None;
			Vector4 tintCol = new Vector4(1,1,1,1);
			Vector2 uv1 = new Vector2(1,1);
			fixed (byte* nativeLabelId = labelId)
			{
				ImPlotNative.PlotImage(nativeLabelId, userTextureId, boundsMin, boundsMax, uv0, uv1, tintCol, flags);
			}
		}

		public static void PlotImage(ReadOnlySpan<char> labelId, ulong userTextureId, ImPlotPoint boundsMin, ImPlotPoint boundsMax, Vector2 uv0)
		{
			// defining omitted parameters
			ImPlotImageFlags flags = ImPlotImageFlags.None;
			Vector4 tintCol = new Vector4(1,1,1,1);
			Vector2 uv1 = new Vector2(1,1);
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			ImPlotNative.PlotImage(nativeLabelId, userTextureId, boundsMin, boundsMax, uv0, uv1, tintCol, flags);
			// Freeing labelId native string
			if (byteCountLabelId > Utils.MaxStackallocSize)
				Utils.Free(nativeLabelId);
		}

		public static void PlotImage(ReadOnlySpan<byte> labelId, ulong userTextureId, ImPlotPoint boundsMin, ImPlotPoint boundsMax)
		{
			// defining omitted parameters
			ImPlotImageFlags flags = ImPlotImageFlags.None;
			Vector4 tintCol = new Vector4(1,1,1,1);
			Vector2 uv1 = new Vector2(1,1);
			Vector2 uv0 = new Vector2(0,0);
			fixed (byte* nativeLabelId = labelId)
			{
				ImPlotNative.PlotImage(nativeLabelId, userTextureId, boundsMin, boundsMax, uv0, uv1, tintCol, flags);
			}
		}

		public static void PlotImage(ReadOnlySpan<char> labelId, ulong userTextureId, ImPlotPoint boundsMin, ImPlotPoint boundsMax)
		{
			// defining omitted parameters
			ImPlotImageFlags flags = ImPlotImageFlags.None;
			Vector4 tintCol = new Vector4(1,1,1,1);
			Vector2 uv1 = new Vector2(1,1);
			Vector2 uv0 = new Vector2(0,0);
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			ImPlotNative.PlotImage(nativeLabelId, userTextureId, boundsMin, boundsMax, uv0, uv1, tintCol, flags);
			// Freeing labelId native string
			if (byteCountLabelId > Utils.MaxStackallocSize)
				Utils.Free(nativeLabelId);
		}

		public static void PlotText(ReadOnlySpan<byte> text, double x, double y, Vector2 pixOffset, ImPlotTextFlags flags)
		{
			fixed (byte* nativeText = text)
			{
				ImPlotNative.PlotText(nativeText, x, y, pixOffset, flags);
			}
		}

		public static void PlotText(ReadOnlySpan<char> text, double x, double y, Vector2 pixOffset, ImPlotTextFlags flags)
		{
			// Marshaling text to native string
			byte* nativeText;
			var byteCountText = 0;
			if (text != null && !text.IsEmpty)
			{
				byteCountText = Encoding.UTF8.GetByteCount(text);
				if(byteCountText > Utils.MaxStackallocSize)
				{
					nativeText = Utils.Alloc<byte>(byteCountText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountText + 1];
					nativeText = stackallocBytes;
				}
				var offsetText = Utils.EncodeStringUTF8(text, nativeText, byteCountText);
				nativeText[offsetText] = 0;
			}
			else nativeText = null;

			ImPlotNative.PlotText(nativeText, x, y, pixOffset, flags);
			// Freeing text native string
			if (byteCountText > Utils.MaxStackallocSize)
				Utils.Free(nativeText);
		}

		public static void PlotText(ReadOnlySpan<byte> text, double x, double y, Vector2 pixOffset)
		{
			// defining omitted parameters
			ImPlotTextFlags flags = ImPlotTextFlags.None;
			fixed (byte* nativeText = text)
			{
				ImPlotNative.PlotText(nativeText, x, y, pixOffset, flags);
			}
		}

		public static void PlotText(ReadOnlySpan<char> text, double x, double y, Vector2 pixOffset)
		{
			// defining omitted parameters
			ImPlotTextFlags flags = ImPlotTextFlags.None;
			// Marshaling text to native string
			byte* nativeText;
			var byteCountText = 0;
			if (text != null && !text.IsEmpty)
			{
				byteCountText = Encoding.UTF8.GetByteCount(text);
				if(byteCountText > Utils.MaxStackallocSize)
				{
					nativeText = Utils.Alloc<byte>(byteCountText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountText + 1];
					nativeText = stackallocBytes;
				}
				var offsetText = Utils.EncodeStringUTF8(text, nativeText, byteCountText);
				nativeText[offsetText] = 0;
			}
			else nativeText = null;

			ImPlotNative.PlotText(nativeText, x, y, pixOffset, flags);
			// Freeing text native string
			if (byteCountText > Utils.MaxStackallocSize)
				Utils.Free(nativeText);
		}

		public static void PlotText(ReadOnlySpan<byte> text, double x, double y)
		{
			// defining omitted parameters
			ImPlotTextFlags flags = ImPlotTextFlags.None;
			Vector2 pixOffset = new Vector2(0,0);
			fixed (byte* nativeText = text)
			{
				ImPlotNative.PlotText(nativeText, x, y, pixOffset, flags);
			}
		}

		public static void PlotText(ReadOnlySpan<char> text, double x, double y)
		{
			// defining omitted parameters
			ImPlotTextFlags flags = ImPlotTextFlags.None;
			Vector2 pixOffset = new Vector2(0,0);
			// Marshaling text to native string
			byte* nativeText;
			var byteCountText = 0;
			if (text != null && !text.IsEmpty)
			{
				byteCountText = Encoding.UTF8.GetByteCount(text);
				if(byteCountText > Utils.MaxStackallocSize)
				{
					nativeText = Utils.Alloc<byte>(byteCountText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountText + 1];
					nativeText = stackallocBytes;
				}
				var offsetText = Utils.EncodeStringUTF8(text, nativeText, byteCountText);
				nativeText[offsetText] = 0;
			}
			else nativeText = null;

			ImPlotNative.PlotText(nativeText, x, y, pixOffset, flags);
			// Freeing text native string
			if (byteCountText > Utils.MaxStackallocSize)
				Utils.Free(nativeText);
		}

		public static void PlotDummy(ReadOnlySpan<byte> labelId, ImPlotDummyFlags flags)
		{
			fixed (byte* nativeLabelId = labelId)
			{
				ImPlotNative.PlotDummy(nativeLabelId, flags);
			}
		}

		public static void PlotDummy(ReadOnlySpan<char> labelId, ImPlotDummyFlags flags)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			ImPlotNative.PlotDummy(nativeLabelId, flags);
			// Freeing labelId native string
			if (byteCountLabelId > Utils.MaxStackallocSize)
				Utils.Free(nativeLabelId);
		}

		public static void PlotDummy(ReadOnlySpan<byte> labelId)
		{
			// defining omitted parameters
			ImPlotDummyFlags flags = ImPlotDummyFlags.None;
			fixed (byte* nativeLabelId = labelId)
			{
				ImPlotNative.PlotDummy(nativeLabelId, flags);
			}
		}

		public static void PlotDummy(ReadOnlySpan<char> labelId)
		{
			// defining omitted parameters
			ImPlotDummyFlags flags = ImPlotDummyFlags.None;
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			ImPlotNative.PlotDummy(nativeLabelId, flags);
			// Freeing labelId native string
			if (byteCountLabelId > Utils.MaxStackallocSize)
				Utils.Free(nativeLabelId);
		}

		public static bool DragPoint(int id, ref double x, ref double y, Vector4 col, float size, ImPlotDragToolFlags flags, ref bool outClicked, ref bool outHovered, ref bool held)
		{
			var nativeOutClickedVal = outClicked ? (byte)1 : (byte)0;
			var nativeOutClicked = &nativeOutClickedVal;
			var nativeOutHoveredVal = outHovered ? (byte)1 : (byte)0;
			var nativeOutHovered = &nativeOutHoveredVal;
			var nativeHeldVal = held ? (byte)1 : (byte)0;
			var nativeHeld = &nativeHeldVal;
			fixed (double* nativeX = &x)
			fixed (double* nativeY = &y)
			{
				var result = ImPlotNative.DragPoint(id, nativeX, nativeY, col, size, flags, nativeOutClicked, nativeOutHovered, nativeHeld);
				outClicked = nativeOutClickedVal != 0;
				outHovered = nativeOutHoveredVal != 0;
				held = nativeHeldVal != 0;
				return result != 0;
			}
		}

		public static bool DragPoint(int id, ref double x, ref double y, Vector4 col, float size, ImPlotDragToolFlags flags, ref bool outClicked, ref bool outHovered)
		{
			// defining omitted parameters
			byte* held = null;
			var nativeOutClickedVal = outClicked ? (byte)1 : (byte)0;
			var nativeOutClicked = &nativeOutClickedVal;
			var nativeOutHoveredVal = outHovered ? (byte)1 : (byte)0;
			var nativeOutHovered = &nativeOutHoveredVal;
			fixed (double* nativeX = &x)
			fixed (double* nativeY = &y)
			{
				var result = ImPlotNative.DragPoint(id, nativeX, nativeY, col, size, flags, nativeOutClicked, nativeOutHovered, held);
				outClicked = nativeOutClickedVal != 0;
				outHovered = nativeOutHoveredVal != 0;
				return result != 0;
			}
		}

		public static bool DragPoint(int id, ref double x, ref double y, Vector4 col, float size, ImPlotDragToolFlags flags, ref bool outClicked)
		{
			// defining omitted parameters
			byte* held = null;
			byte* outHovered = null;
			var nativeOutClickedVal = outClicked ? (byte)1 : (byte)0;
			var nativeOutClicked = &nativeOutClickedVal;
			fixed (double* nativeX = &x)
			fixed (double* nativeY = &y)
			{
				var result = ImPlotNative.DragPoint(id, nativeX, nativeY, col, size, flags, nativeOutClicked, outHovered, held);
				outClicked = nativeOutClickedVal != 0;
				return result != 0;
			}
		}

		public static bool DragPoint(int id, ref double x, ref double y, Vector4 col, float size, ImPlotDragToolFlags flags)
		{
			// defining omitted parameters
			byte* held = null;
			byte* outHovered = null;
			byte* outClicked = null;
			fixed (double* nativeX = &x)
			fixed (double* nativeY = &y)
			{
				var result = ImPlotNative.DragPoint(id, nativeX, nativeY, col, size, flags, outClicked, outHovered, held);
				return result != 0;
			}
		}

		public static bool DragPoint(int id, ref double x, ref double y, Vector4 col, float size)
		{
			// defining omitted parameters
			byte* held = null;
			byte* outHovered = null;
			byte* outClicked = null;
			ImPlotDragToolFlags flags = ImPlotDragToolFlags.None;
			fixed (double* nativeX = &x)
			fixed (double* nativeY = &y)
			{
				var result = ImPlotNative.DragPoint(id, nativeX, nativeY, col, size, flags, outClicked, outHovered, held);
				return result != 0;
			}
		}

		public static bool DragPoint(int id, ref double x, ref double y, Vector4 col)
		{
			// defining omitted parameters
			float size = 4;
			byte* held = null;
			byte* outHovered = null;
			byte* outClicked = null;
			ImPlotDragToolFlags flags = ImPlotDragToolFlags.None;
			fixed (double* nativeX = &x)
			fixed (double* nativeY = &y)
			{
				var result = ImPlotNative.DragPoint(id, nativeX, nativeY, col, size, flags, outClicked, outHovered, held);
				return result != 0;
			}
		}

		public static bool DragLineX(int id, ref double x, Vector4 col, float thickness, ImPlotDragToolFlags flags, ref bool outClicked, ref bool outHovered, ref bool held)
		{
			var nativeOutClickedVal = outClicked ? (byte)1 : (byte)0;
			var nativeOutClicked = &nativeOutClickedVal;
			var nativeOutHoveredVal = outHovered ? (byte)1 : (byte)0;
			var nativeOutHovered = &nativeOutHoveredVal;
			var nativeHeldVal = held ? (byte)1 : (byte)0;
			var nativeHeld = &nativeHeldVal;
			fixed (double* nativeX = &x)
			{
				var result = ImPlotNative.DragLineX(id, nativeX, col, thickness, flags, nativeOutClicked, nativeOutHovered, nativeHeld);
				outClicked = nativeOutClickedVal != 0;
				outHovered = nativeOutHoveredVal != 0;
				held = nativeHeldVal != 0;
				return result != 0;
			}
		}

		public static bool DragLineX(int id, ref double x, Vector4 col, float thickness, ImPlotDragToolFlags flags, ref bool outClicked, ref bool outHovered)
		{
			// defining omitted parameters
			byte* held = null;
			var nativeOutClickedVal = outClicked ? (byte)1 : (byte)0;
			var nativeOutClicked = &nativeOutClickedVal;
			var nativeOutHoveredVal = outHovered ? (byte)1 : (byte)0;
			var nativeOutHovered = &nativeOutHoveredVal;
			fixed (double* nativeX = &x)
			{
				var result = ImPlotNative.DragLineX(id, nativeX, col, thickness, flags, nativeOutClicked, nativeOutHovered, held);
				outClicked = nativeOutClickedVal != 0;
				outHovered = nativeOutHoveredVal != 0;
				return result != 0;
			}
		}

		public static bool DragLineX(int id, ref double x, Vector4 col, float thickness, ImPlotDragToolFlags flags, ref bool outClicked)
		{
			// defining omitted parameters
			byte* held = null;
			byte* outHovered = null;
			var nativeOutClickedVal = outClicked ? (byte)1 : (byte)0;
			var nativeOutClicked = &nativeOutClickedVal;
			fixed (double* nativeX = &x)
			{
				var result = ImPlotNative.DragLineX(id, nativeX, col, thickness, flags, nativeOutClicked, outHovered, held);
				outClicked = nativeOutClickedVal != 0;
				return result != 0;
			}
		}

		public static bool DragLineX(int id, ref double x, Vector4 col, float thickness, ImPlotDragToolFlags flags)
		{
			// defining omitted parameters
			byte* held = null;
			byte* outHovered = null;
			byte* outClicked = null;
			fixed (double* nativeX = &x)
			{
				var result = ImPlotNative.DragLineX(id, nativeX, col, thickness, flags, outClicked, outHovered, held);
				return result != 0;
			}
		}

		public static bool DragLineX(int id, ref double x, Vector4 col, float thickness)
		{
			// defining omitted parameters
			byte* held = null;
			byte* outHovered = null;
			byte* outClicked = null;
			ImPlotDragToolFlags flags = ImPlotDragToolFlags.None;
			fixed (double* nativeX = &x)
			{
				var result = ImPlotNative.DragLineX(id, nativeX, col, thickness, flags, outClicked, outHovered, held);
				return result != 0;
			}
		}

		public static bool DragLineX(int id, ref double x, Vector4 col)
		{
			// defining omitted parameters
			float thickness = 1;
			byte* held = null;
			byte* outHovered = null;
			byte* outClicked = null;
			ImPlotDragToolFlags flags = ImPlotDragToolFlags.None;
			fixed (double* nativeX = &x)
			{
				var result = ImPlotNative.DragLineX(id, nativeX, col, thickness, flags, outClicked, outHovered, held);
				return result != 0;
			}
		}

		public static bool DragLineY(int id, ref double y, Vector4 col, float thickness, ImPlotDragToolFlags flags, ref bool outClicked, ref bool outHovered, ref bool held)
		{
			var nativeOutClickedVal = outClicked ? (byte)1 : (byte)0;
			var nativeOutClicked = &nativeOutClickedVal;
			var nativeOutHoveredVal = outHovered ? (byte)1 : (byte)0;
			var nativeOutHovered = &nativeOutHoveredVal;
			var nativeHeldVal = held ? (byte)1 : (byte)0;
			var nativeHeld = &nativeHeldVal;
			fixed (double* nativeY = &y)
			{
				var result = ImPlotNative.DragLineY(id, nativeY, col, thickness, flags, nativeOutClicked, nativeOutHovered, nativeHeld);
				outClicked = nativeOutClickedVal != 0;
				outHovered = nativeOutHoveredVal != 0;
				held = nativeHeldVal != 0;
				return result != 0;
			}
		}

		public static bool DragLineY(int id, ref double y, Vector4 col, float thickness, ImPlotDragToolFlags flags, ref bool outClicked, ref bool outHovered)
		{
			// defining omitted parameters
			byte* held = null;
			var nativeOutClickedVal = outClicked ? (byte)1 : (byte)0;
			var nativeOutClicked = &nativeOutClickedVal;
			var nativeOutHoveredVal = outHovered ? (byte)1 : (byte)0;
			var nativeOutHovered = &nativeOutHoveredVal;
			fixed (double* nativeY = &y)
			{
				var result = ImPlotNative.DragLineY(id, nativeY, col, thickness, flags, nativeOutClicked, nativeOutHovered, held);
				outClicked = nativeOutClickedVal != 0;
				outHovered = nativeOutHoveredVal != 0;
				return result != 0;
			}
		}

		public static bool DragLineY(int id, ref double y, Vector4 col, float thickness, ImPlotDragToolFlags flags, ref bool outClicked)
		{
			// defining omitted parameters
			byte* held = null;
			byte* outHovered = null;
			var nativeOutClickedVal = outClicked ? (byte)1 : (byte)0;
			var nativeOutClicked = &nativeOutClickedVal;
			fixed (double* nativeY = &y)
			{
				var result = ImPlotNative.DragLineY(id, nativeY, col, thickness, flags, nativeOutClicked, outHovered, held);
				outClicked = nativeOutClickedVal != 0;
				return result != 0;
			}
		}

		public static bool DragLineY(int id, ref double y, Vector4 col, float thickness, ImPlotDragToolFlags flags)
		{
			// defining omitted parameters
			byte* held = null;
			byte* outHovered = null;
			byte* outClicked = null;
			fixed (double* nativeY = &y)
			{
				var result = ImPlotNative.DragLineY(id, nativeY, col, thickness, flags, outClicked, outHovered, held);
				return result != 0;
			}
		}

		public static bool DragLineY(int id, ref double y, Vector4 col, float thickness)
		{
			// defining omitted parameters
			byte* held = null;
			byte* outHovered = null;
			byte* outClicked = null;
			ImPlotDragToolFlags flags = ImPlotDragToolFlags.None;
			fixed (double* nativeY = &y)
			{
				var result = ImPlotNative.DragLineY(id, nativeY, col, thickness, flags, outClicked, outHovered, held);
				return result != 0;
			}
		}

		public static bool DragLineY(int id, ref double y, Vector4 col)
		{
			// defining omitted parameters
			float thickness = 1;
			byte* held = null;
			byte* outHovered = null;
			byte* outClicked = null;
			ImPlotDragToolFlags flags = ImPlotDragToolFlags.None;
			fixed (double* nativeY = &y)
			{
				var result = ImPlotNative.DragLineY(id, nativeY, col, thickness, flags, outClicked, outHovered, held);
				return result != 0;
			}
		}

		public static bool DragRect(int id, ref double x1, ref double y1, ref double x2, ref double y2, Vector4 col, ImPlotDragToolFlags flags, ref bool outClicked, ref bool outHovered, ref bool held)
		{
			var nativeOutClickedVal = outClicked ? (byte)1 : (byte)0;
			var nativeOutClicked = &nativeOutClickedVal;
			var nativeOutHoveredVal = outHovered ? (byte)1 : (byte)0;
			var nativeOutHovered = &nativeOutHoveredVal;
			var nativeHeldVal = held ? (byte)1 : (byte)0;
			var nativeHeld = &nativeHeldVal;
			fixed (double* nativeX1 = &x1)
			fixed (double* nativeY1 = &y1)
			fixed (double* nativeX2 = &x2)
			fixed (double* nativeY2 = &y2)
			{
				var result = ImPlotNative.DragRect(id, nativeX1, nativeY1, nativeX2, nativeY2, col, flags, nativeOutClicked, nativeOutHovered, nativeHeld);
				outClicked = nativeOutClickedVal != 0;
				outHovered = nativeOutHoveredVal != 0;
				held = nativeHeldVal != 0;
				return result != 0;
			}
		}

		public static bool DragRect(int id, ref double x1, ref double y1, ref double x2, ref double y2, Vector4 col, ImPlotDragToolFlags flags, ref bool outClicked, ref bool outHovered)
		{
			// defining omitted parameters
			byte* held = null;
			var nativeOutClickedVal = outClicked ? (byte)1 : (byte)0;
			var nativeOutClicked = &nativeOutClickedVal;
			var nativeOutHoveredVal = outHovered ? (byte)1 : (byte)0;
			var nativeOutHovered = &nativeOutHoveredVal;
			fixed (double* nativeX1 = &x1)
			fixed (double* nativeY1 = &y1)
			fixed (double* nativeX2 = &x2)
			fixed (double* nativeY2 = &y2)
			{
				var result = ImPlotNative.DragRect(id, nativeX1, nativeY1, nativeX2, nativeY2, col, flags, nativeOutClicked, nativeOutHovered, held);
				outClicked = nativeOutClickedVal != 0;
				outHovered = nativeOutHoveredVal != 0;
				return result != 0;
			}
		}

		public static bool DragRect(int id, ref double x1, ref double y1, ref double x2, ref double y2, Vector4 col, ImPlotDragToolFlags flags, ref bool outClicked)
		{
			// defining omitted parameters
			byte* held = null;
			byte* outHovered = null;
			var nativeOutClickedVal = outClicked ? (byte)1 : (byte)0;
			var nativeOutClicked = &nativeOutClickedVal;
			fixed (double* nativeX1 = &x1)
			fixed (double* nativeY1 = &y1)
			fixed (double* nativeX2 = &x2)
			fixed (double* nativeY2 = &y2)
			{
				var result = ImPlotNative.DragRect(id, nativeX1, nativeY1, nativeX2, nativeY2, col, flags, nativeOutClicked, outHovered, held);
				outClicked = nativeOutClickedVal != 0;
				return result != 0;
			}
		}

		public static bool DragRect(int id, ref double x1, ref double y1, ref double x2, ref double y2, Vector4 col, ImPlotDragToolFlags flags)
		{
			// defining omitted parameters
			byte* held = null;
			byte* outHovered = null;
			byte* outClicked = null;
			fixed (double* nativeX1 = &x1)
			fixed (double* nativeY1 = &y1)
			fixed (double* nativeX2 = &x2)
			fixed (double* nativeY2 = &y2)
			{
				var result = ImPlotNative.DragRect(id, nativeX1, nativeY1, nativeX2, nativeY2, col, flags, outClicked, outHovered, held);
				return result != 0;
			}
		}

		public static bool DragRect(int id, ref double x1, ref double y1, ref double x2, ref double y2, Vector4 col)
		{
			// defining omitted parameters
			byte* held = null;
			byte* outHovered = null;
			byte* outClicked = null;
			ImPlotDragToolFlags flags = ImPlotDragToolFlags.None;
			fixed (double* nativeX1 = &x1)
			fixed (double* nativeY1 = &y1)
			fixed (double* nativeX2 = &x2)
			fixed (double* nativeY2 = &y2)
			{
				var result = ImPlotNative.DragRect(id, nativeX1, nativeY1, nativeX2, nativeY2, col, flags, outClicked, outHovered, held);
				return result != 0;
			}
		}

		public static void AnnotationBool(double x, double y, Vector4 col, Vector2 pixOffset, bool clamp, bool round)
		{
			var native_clamp = clamp ? (byte)1 : (byte)0;
			var native_round = round ? (byte)1 : (byte)0;
			ImPlotNative.AnnotationBool(x, y, col, pixOffset, native_clamp, native_round);
		}

		public static void AnnotationStr(double x, double y, Vector4 col, Vector2 pixOffset, bool clamp, ReadOnlySpan<byte> fmt)
		{
			var native_clamp = clamp ? (byte)1 : (byte)0;
			fixed (byte* nativeFmt = fmt)
			{
				ImPlotNative.AnnotationStr(x, y, col, pixOffset, native_clamp, nativeFmt);
			}
		}

		public static void AnnotationStr(double x, double y, Vector4 col, Vector2 pixOffset, bool clamp, ReadOnlySpan<char> fmt)
		{
			var native_clamp = clamp ? (byte)1 : (byte)0;
			// Marshaling fmt to native string
			byte* nativeFmt;
			var byteCountFmt = 0;
			if (fmt != null && !fmt.IsEmpty)
			{
				byteCountFmt = Encoding.UTF8.GetByteCount(fmt);
				if(byteCountFmt > Utils.MaxStackallocSize)
				{
					nativeFmt = Utils.Alloc<byte>(byteCountFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFmt + 1];
					nativeFmt = stackallocBytes;
				}
				var offsetFmt = Utils.EncodeStringUTF8(fmt, nativeFmt, byteCountFmt);
				nativeFmt[offsetFmt] = 0;
			}
			else nativeFmt = null;

			ImPlotNative.AnnotationStr(x, y, col, pixOffset, native_clamp, nativeFmt);
			// Freeing fmt native string
			if (byteCountFmt > Utils.MaxStackallocSize)
				Utils.Free(nativeFmt);
		}

		public static void TagXBool(double x, Vector4 col, bool round)
		{
			var native_round = round ? (byte)1 : (byte)0;
			ImPlotNative.TagXBool(x, col, native_round);
		}

		public static void TagXStr(double x, Vector4 col, ReadOnlySpan<byte> fmt)
		{
			fixed (byte* nativeFmt = fmt)
			{
				ImPlotNative.TagXStr(x, col, nativeFmt);
			}
		}

		public static void TagXStr(double x, Vector4 col, ReadOnlySpan<char> fmt)
		{
			// Marshaling fmt to native string
			byte* nativeFmt;
			var byteCountFmt = 0;
			if (fmt != null && !fmt.IsEmpty)
			{
				byteCountFmt = Encoding.UTF8.GetByteCount(fmt);
				if(byteCountFmt > Utils.MaxStackallocSize)
				{
					nativeFmt = Utils.Alloc<byte>(byteCountFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFmt + 1];
					nativeFmt = stackallocBytes;
				}
				var offsetFmt = Utils.EncodeStringUTF8(fmt, nativeFmt, byteCountFmt);
				nativeFmt[offsetFmt] = 0;
			}
			else nativeFmt = null;

			ImPlotNative.TagXStr(x, col, nativeFmt);
			// Freeing fmt native string
			if (byteCountFmt > Utils.MaxStackallocSize)
				Utils.Free(nativeFmt);
		}

		public static void TagYBool(double y, Vector4 col, bool round)
		{
			var native_round = round ? (byte)1 : (byte)0;
			ImPlotNative.TagYBool(y, col, native_round);
		}

		public static void TagYStr(double y, Vector4 col, ReadOnlySpan<byte> fmt)
		{
			fixed (byte* nativeFmt = fmt)
			{
				ImPlotNative.TagYStr(y, col, nativeFmt);
			}
		}

		public static void TagYStr(double y, Vector4 col, ReadOnlySpan<char> fmt)
		{
			// Marshaling fmt to native string
			byte* nativeFmt;
			var byteCountFmt = 0;
			if (fmt != null && !fmt.IsEmpty)
			{
				byteCountFmt = Encoding.UTF8.GetByteCount(fmt);
				if(byteCountFmt > Utils.MaxStackallocSize)
				{
					nativeFmt = Utils.Alloc<byte>(byteCountFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFmt + 1];
					nativeFmt = stackallocBytes;
				}
				var offsetFmt = Utils.EncodeStringUTF8(fmt, nativeFmt, byteCountFmt);
				nativeFmt[offsetFmt] = 0;
			}
			else nativeFmt = null;

			ImPlotNative.TagYStr(y, col, nativeFmt);
			// Freeing fmt native string
			if (byteCountFmt > Utils.MaxStackallocSize)
				Utils.Free(nativeFmt);
		}

		public static void SetAxis(ImAxis axis)
		{
			ImPlotNative.SetAxis(axis);
		}

		public static void SetAxes(ImAxis xAxis, ImAxis yAxis)
		{
			ImPlotNative.SetAxes(xAxis, yAxis);
		}

		public static void PixelsToPlotVec2(ImPlotPointPtr pOut, Vector2 pix, ImAxis xAxis, ImAxis yAxis)
		{
			ImPlotNative.PixelsToPlotVec2(pOut, pix, xAxis, yAxis);
		}

		public static void PixelsToPlotFloat(ImPlotPointPtr pOut, float x, float y, ImAxis xAxis, ImAxis yAxis)
		{
			ImPlotNative.PixelsToPlotFloat(pOut, x, y, xAxis, yAxis);
		}

		public static void PlotToPixelsPlotPoInt(out Vector2 pOut, ImPlotPoint plt, ImAxis xAxis, ImAxis yAxis)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImPlotNative.PlotToPixelsPlotPoInt(nativePOut, plt, xAxis, yAxis);
			}
		}

		public static void PlotToPixelsDouble(out Vector2 pOut, double x, double y, ImAxis xAxis, ImAxis yAxis)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImPlotNative.PlotToPixelsDouble(nativePOut, x, y, xAxis, yAxis);
			}
		}

		public static void GetPlotPos(out Vector2 pOut)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImPlotNative.GetPlotPos(nativePOut);
			}
		}

		public static void GetPlotSize(out Vector2 pOut)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImPlotNative.GetPlotSize(nativePOut);
			}
		}

		public static void GetPlotMousePos(ImPlotPointPtr pOut, ImAxis xAxis, ImAxis yAxis)
		{
			ImPlotNative.GetPlotMousePos(pOut, xAxis, yAxis);
		}

		public static void GetPlotMousePos(ImPlotPointPtr pOut, ImAxis xAxis)
		{
			// defining omitted parameters
			ImAxis yAxis = (ImAxis)0;
			ImPlotNative.GetPlotMousePos(pOut, xAxis, yAxis);
		}

		public static void GetPlotMousePos(ImPlotPointPtr pOut)
		{
			// defining omitted parameters
			ImAxis yAxis = (ImAxis)0;
			ImAxis xAxis = (ImAxis)0;
			ImPlotNative.GetPlotMousePos(pOut, xAxis, yAxis);
		}

		public static void GetPlotLimits(ImPlotRectPtr pOut, ImAxis xAxis, ImAxis yAxis)
		{
			ImPlotNative.GetPlotLimits(pOut, xAxis, yAxis);
		}

		public static void GetPlotLimits(ImPlotRectPtr pOut, ImAxis xAxis)
		{
			// defining omitted parameters
			ImAxis yAxis = (ImAxis)0;
			ImPlotNative.GetPlotLimits(pOut, xAxis, yAxis);
		}

		public static void GetPlotLimits(ImPlotRectPtr pOut)
		{
			// defining omitted parameters
			ImAxis yAxis = (ImAxis)0;
			ImAxis xAxis = (ImAxis)0;
			ImPlotNative.GetPlotLimits(pOut, xAxis, yAxis);
		}

		public static bool IsPlotHovered()
		{
			var result = ImPlotNative.IsPlotHovered();
			return result != 0;
		}

		public static bool IsAxisHovered(ImAxis axis)
		{
			var result = ImPlotNative.IsAxisHovered(axis);
			return result != 0;
		}

		public static bool IsSubplotsHovered()
		{
			var result = ImPlotNative.IsSubplotsHovered();
			return result != 0;
		}

		public static bool IsPlotSelected()
		{
			var result = ImPlotNative.IsPlotSelected();
			return result != 0;
		}

		public static void GetPlotSelection(ImPlotRectPtr pOut, ImAxis xAxis, ImAxis yAxis)
		{
			ImPlotNative.GetPlotSelection(pOut, xAxis, yAxis);
		}

		public static void GetPlotSelection(ImPlotRectPtr pOut, ImAxis xAxis)
		{
			// defining omitted parameters
			ImAxis yAxis = (ImAxis)0;
			ImPlotNative.GetPlotSelection(pOut, xAxis, yAxis);
		}

		public static void GetPlotSelection(ImPlotRectPtr pOut)
		{
			// defining omitted parameters
			ImAxis yAxis = (ImAxis)0;
			ImAxis xAxis = (ImAxis)0;
			ImPlotNative.GetPlotSelection(pOut, xAxis, yAxis);
		}

		public static void CancelPlotSelection()
		{
			ImPlotNative.CancelPlotSelection();
		}

		public static void HideNextItem(bool hidden, ImPlotCond cond)
		{
			var native_hidden = hidden ? (byte)1 : (byte)0;
			ImPlotNative.HideNextItem(native_hidden, cond);
		}

		public static void HideNextItem(bool hidden)
		{
			// defining omitted parameters
			ImPlotCond cond = ImPlotCond.Once;
			var native_hidden = hidden ? (byte)1 : (byte)0;
			ImPlotNative.HideNextItem(native_hidden, cond);
		}

		public static void HideNextItem()
		{
			// defining omitted parameters
			ImPlotCond cond = ImPlotCond.Once;
			byte hidden = 1;
			ImPlotNative.HideNextItem(hidden, cond);
		}

		public static bool BeginAlignedPlots(ReadOnlySpan<byte> groupId, bool vertical)
		{
			var native_vertical = vertical ? (byte)1 : (byte)0;
			fixed (byte* nativeGroupId = groupId)
			{
				var result = ImPlotNative.BeginAlignedPlots(nativeGroupId, native_vertical);
				return result != 0;
			}
		}

		public static bool BeginAlignedPlots(ReadOnlySpan<char> groupId, bool vertical)
		{
			// Marshaling groupId to native string
			byte* nativeGroupId;
			var byteCountGroupId = 0;
			if (groupId != null && !groupId.IsEmpty)
			{
				byteCountGroupId = Encoding.UTF8.GetByteCount(groupId);
				if(byteCountGroupId > Utils.MaxStackallocSize)
				{
					nativeGroupId = Utils.Alloc<byte>(byteCountGroupId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountGroupId + 1];
					nativeGroupId = stackallocBytes;
				}
				var offsetGroupId = Utils.EncodeStringUTF8(groupId, nativeGroupId, byteCountGroupId);
				nativeGroupId[offsetGroupId] = 0;
			}
			else nativeGroupId = null;

			var native_vertical = vertical ? (byte)1 : (byte)0;
			var result = ImPlotNative.BeginAlignedPlots(nativeGroupId, native_vertical);
			// Freeing groupId native string
			if (byteCountGroupId > Utils.MaxStackallocSize)
				Utils.Free(nativeGroupId);
			return result != 0;
		}

		public static bool BeginAlignedPlots(ReadOnlySpan<byte> groupId)
		{
			// defining omitted parameters
			byte vertical = 1;
			fixed (byte* nativeGroupId = groupId)
			{
				var result = ImPlotNative.BeginAlignedPlots(nativeGroupId, vertical);
				return result != 0;
			}
		}

		public static bool BeginAlignedPlots(ReadOnlySpan<char> groupId)
		{
			// defining omitted parameters
			byte vertical = 1;
			// Marshaling groupId to native string
			byte* nativeGroupId;
			var byteCountGroupId = 0;
			if (groupId != null && !groupId.IsEmpty)
			{
				byteCountGroupId = Encoding.UTF8.GetByteCount(groupId);
				if(byteCountGroupId > Utils.MaxStackallocSize)
				{
					nativeGroupId = Utils.Alloc<byte>(byteCountGroupId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountGroupId + 1];
					nativeGroupId = stackallocBytes;
				}
				var offsetGroupId = Utils.EncodeStringUTF8(groupId, nativeGroupId, byteCountGroupId);
				nativeGroupId[offsetGroupId] = 0;
			}
			else nativeGroupId = null;

			var result = ImPlotNative.BeginAlignedPlots(nativeGroupId, vertical);
			// Freeing groupId native string
			if (byteCountGroupId > Utils.MaxStackallocSize)
				Utils.Free(nativeGroupId);
			return result != 0;
		}

		public static void EndAlignedPlots()
		{
			ImPlotNative.EndAlignedPlots();
		}

		public static bool BeginLegendPopup(ReadOnlySpan<byte> labelId, ImGuiMouseButton mouseButton)
		{
			fixed (byte* nativeLabelId = labelId)
			{
				var result = ImPlotNative.BeginLegendPopup(nativeLabelId, mouseButton);
				return result != 0;
			}
		}

		public static bool BeginLegendPopup(ReadOnlySpan<char> labelId, ImGuiMouseButton mouseButton)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			var result = ImPlotNative.BeginLegendPopup(nativeLabelId, mouseButton);
			// Freeing labelId native string
			if (byteCountLabelId > Utils.MaxStackallocSize)
				Utils.Free(nativeLabelId);
			return result != 0;
		}

		public static bool BeginLegendPopup(ReadOnlySpan<byte> labelId)
		{
			// defining omitted parameters
			ImGuiMouseButton mouseButton = ImGuiMouseButton.Right;
			fixed (byte* nativeLabelId = labelId)
			{
				var result = ImPlotNative.BeginLegendPopup(nativeLabelId, mouseButton);
				return result != 0;
			}
		}

		public static bool BeginLegendPopup(ReadOnlySpan<char> labelId)
		{
			// defining omitted parameters
			ImGuiMouseButton mouseButton = ImGuiMouseButton.Right;
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			var result = ImPlotNative.BeginLegendPopup(nativeLabelId, mouseButton);
			// Freeing labelId native string
			if (byteCountLabelId > Utils.MaxStackallocSize)
				Utils.Free(nativeLabelId);
			return result != 0;
		}

		public static void EndLegendPopup()
		{
			ImPlotNative.EndLegendPopup();
		}

		public static bool IsLegendEntryHovered(ReadOnlySpan<byte> labelId)
		{
			fixed (byte* nativeLabelId = labelId)
			{
				var result = ImPlotNative.IsLegendEntryHovered(nativeLabelId);
				return result != 0;
			}
		}

		public static bool IsLegendEntryHovered(ReadOnlySpan<char> labelId)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			var result = ImPlotNative.IsLegendEntryHovered(nativeLabelId);
			// Freeing labelId native string
			if (byteCountLabelId > Utils.MaxStackallocSize)
				Utils.Free(nativeLabelId);
			return result != 0;
		}

		public static bool BeginDragDropTargetPlot()
		{
			var result = ImPlotNative.BeginDragDropTargetPlot();
			return result != 0;
		}

		public static bool BeginDragDropTargetAxis(ImAxis axis)
		{
			var result = ImPlotNative.BeginDragDropTargetAxis(axis);
			return result != 0;
		}

		public static bool BeginDragDropTargetLegend()
		{
			var result = ImPlotNative.BeginDragDropTargetLegend();
			return result != 0;
		}

		public static void EndDragDropTarget()
		{
			ImPlotNative.EndDragDropTarget();
		}

		public static bool BeginDragDropSourcePlot(ImGuiDragDropFlags flags)
		{
			var result = ImPlotNative.BeginDragDropSourcePlot(flags);
			return result != 0;
		}

		public static bool BeginDragDropSourcePlot()
		{
			// defining omitted parameters
			ImGuiDragDropFlags flags = ImGuiDragDropFlags.None;
			var result = ImPlotNative.BeginDragDropSourcePlot(flags);
			return result != 0;
		}

		public static bool BeginDragDropSourceAxis(ImAxis axis, ImGuiDragDropFlags flags)
		{
			var result = ImPlotNative.BeginDragDropSourceAxis(axis, flags);
			return result != 0;
		}

		public static bool BeginDragDropSourceAxis(ImAxis axis)
		{
			// defining omitted parameters
			ImGuiDragDropFlags flags = ImGuiDragDropFlags.None;
			var result = ImPlotNative.BeginDragDropSourceAxis(axis, flags);
			return result != 0;
		}

		public static bool BeginDragDropSourceItem(ReadOnlySpan<byte> labelId, ImGuiDragDropFlags flags)
		{
			fixed (byte* nativeLabelId = labelId)
			{
				var result = ImPlotNative.BeginDragDropSourceItem(nativeLabelId, flags);
				return result != 0;
			}
		}

		public static bool BeginDragDropSourceItem(ReadOnlySpan<char> labelId, ImGuiDragDropFlags flags)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			var result = ImPlotNative.BeginDragDropSourceItem(nativeLabelId, flags);
			// Freeing labelId native string
			if (byteCountLabelId > Utils.MaxStackallocSize)
				Utils.Free(nativeLabelId);
			return result != 0;
		}

		public static bool BeginDragDropSourceItem(ReadOnlySpan<byte> labelId)
		{
			// defining omitted parameters
			ImGuiDragDropFlags flags = ImGuiDragDropFlags.None;
			fixed (byte* nativeLabelId = labelId)
			{
				var result = ImPlotNative.BeginDragDropSourceItem(nativeLabelId, flags);
				return result != 0;
			}
		}

		public static bool BeginDragDropSourceItem(ReadOnlySpan<char> labelId)
		{
			// defining omitted parameters
			ImGuiDragDropFlags flags = ImGuiDragDropFlags.None;
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			var result = ImPlotNative.BeginDragDropSourceItem(nativeLabelId, flags);
			// Freeing labelId native string
			if (byteCountLabelId > Utils.MaxStackallocSize)
				Utils.Free(nativeLabelId);
			return result != 0;
		}

		public static void EndDragDropSource()
		{
			ImPlotNative.EndDragDropSource();
		}

		public static ImPlotStylePtr GetStyle()
		{
			return ImPlotNative.GetStyle();
		}

		public static void StyleColorsAuto(ImPlotStylePtr dst)
		{
			ImPlotNative.StyleColorsAuto(dst);
		}

		public static void StyleColorsAuto()
		{
			// defining omitted parameters
			ImPlotStyle* dst = null;
			ImPlotNative.StyleColorsAuto(dst);
		}

		public static void StyleColorsClassic(ImPlotStylePtr dst)
		{
			ImPlotNative.StyleColorsClassic(dst);
		}

		public static void StyleColorsClassic()
		{
			// defining omitted parameters
			ImPlotStyle* dst = null;
			ImPlotNative.StyleColorsClassic(dst);
		}

		public static void StyleColorsDark(ImPlotStylePtr dst)
		{
			ImPlotNative.StyleColorsDark(dst);
		}

		public static void StyleColorsDark()
		{
			// defining omitted parameters
			ImPlotStyle* dst = null;
			ImPlotNative.StyleColorsDark(dst);
		}

		public static void StyleColorsLight(ImPlotStylePtr dst)
		{
			ImPlotNative.StyleColorsLight(dst);
		}

		public static void StyleColorsLight()
		{
			// defining omitted parameters
			ImPlotStyle* dst = null;
			ImPlotNative.StyleColorsLight(dst);
		}

		public static void PushStyleColorU32(ImPlotCol idx, uint col)
		{
			ImPlotNative.PushStyleColorU32(idx, col);
		}

		public static void PushStyleColorVec4(ImPlotCol idx, Vector4 col)
		{
			ImPlotNative.PushStyleColorVec4(idx, col);
		}

		public static void PopStyleColor(int count)
		{
			ImPlotNative.PopStyleColor(count);
		}

		public static void PopStyleColor()
		{
			// defining omitted parameters
			int count = 1;
			ImPlotNative.PopStyleColor(count);
		}

		public static void PushStyleVarFloat(ImPlotStyleVar idx, float val)
		{
			ImPlotNative.PushStyleVarFloat(idx, val);
		}

		public static void PushStyleVarInt(ImPlotStyleVar idx, int val)
		{
			ImPlotNative.PushStyleVarInt(idx, val);
		}

		public static void PushStyleVarVec2(ImPlotStyleVar idx, Vector2 val)
		{
			ImPlotNative.PushStyleVarVec2(idx, val);
		}

		public static void PopStyleVar(int count)
		{
			ImPlotNative.PopStyleVar(count);
		}

		public static void PopStyleVar()
		{
			// defining omitted parameters
			int count = 1;
			ImPlotNative.PopStyleVar(count);
		}

		public static void SetNextLineStyle(Vector4 col, float weight)
		{
			ImPlotNative.SetNextLineStyle(col, weight);
		}

		public static void SetNextLineStyle(Vector4 col)
		{
			// defining omitted parameters
			float weight = -1;
			ImPlotNative.SetNextLineStyle(col, weight);
		}

		public static void SetNextLineStyle()
		{
			// defining omitted parameters
			float weight = -1;
			Vector4 col = new Vector4(0,0,0,-1);
			ImPlotNative.SetNextLineStyle(col, weight);
		}

		public static void SetNextFillStyle(Vector4 col, float alphaMod)
		{
			ImPlotNative.SetNextFillStyle(col, alphaMod);
		}

		public static void SetNextFillStyle(Vector4 col)
		{
			// defining omitted parameters
			float alphaMod = -1;
			ImPlotNative.SetNextFillStyle(col, alphaMod);
		}

		public static void SetNextFillStyle()
		{
			// defining omitted parameters
			float alphaMod = -1;
			Vector4 col = new Vector4(0,0,0,-1);
			ImPlotNative.SetNextFillStyle(col, alphaMod);
		}

		public static void SetNextMarkerStyle(ImPlotMarker marker, float size, Vector4 fill, float weight, Vector4 outline)
		{
			ImPlotNative.SetNextMarkerStyle(marker, size, fill, weight, outline);
		}

		public static void SetNextMarkerStyle(ImPlotMarker marker, float size, Vector4 fill, float weight)
		{
			// defining omitted parameters
			Vector4 outline = new Vector4(0,0,0,-1);
			ImPlotNative.SetNextMarkerStyle(marker, size, fill, weight, outline);
		}

		public static void SetNextMarkerStyle(ImPlotMarker marker, float size, Vector4 fill)
		{
			// defining omitted parameters
			float weight = -1;
			Vector4 outline = new Vector4(0,0,0,-1);
			ImPlotNative.SetNextMarkerStyle(marker, size, fill, weight, outline);
		}

		public static void SetNextMarkerStyle(ImPlotMarker marker, float size)
		{
			// defining omitted parameters
			float weight = -1;
			Vector4 outline = new Vector4(0,0,0,-1);
			Vector4 fill = new Vector4(0,0,0,-1);
			ImPlotNative.SetNextMarkerStyle(marker, size, fill, weight, outline);
		}

		public static void SetNextMarkerStyle(ImPlotMarker marker)
		{
			// defining omitted parameters
			float weight = -1;
			float size = -1;
			Vector4 outline = new Vector4(0,0,0,-1);
			Vector4 fill = new Vector4(0,0,0,-1);
			ImPlotNative.SetNextMarkerStyle(marker, size, fill, weight, outline);
		}

		public static void SetNextMarkerStyle()
		{
			// defining omitted parameters
			float weight = -1;
			float size = -1;
			Vector4 outline = new Vector4(0,0,0,-1);
			Vector4 fill = new Vector4(0,0,0,-1);
			ImPlotMarker marker = ImPlotMarker.None;
			ImPlotNative.SetNextMarkerStyle(marker, size, fill, weight, outline);
		}

		public static void SetNextErrorBarStyle(Vector4 col, float size, float weight)
		{
			ImPlotNative.SetNextErrorBarStyle(col, size, weight);
		}

		public static void SetNextErrorBarStyle(Vector4 col, float size)
		{
			// defining omitted parameters
			float weight = -1;
			ImPlotNative.SetNextErrorBarStyle(col, size, weight);
		}

		public static void SetNextErrorBarStyle(Vector4 col)
		{
			// defining omitted parameters
			float weight = -1;
			float size = -1;
			ImPlotNative.SetNextErrorBarStyle(col, size, weight);
		}

		public static void SetNextErrorBarStyle()
		{
			// defining omitted parameters
			float weight = -1;
			float size = -1;
			Vector4 col = new Vector4(0,0,0,-1);
			ImPlotNative.SetNextErrorBarStyle(col, size, weight);
		}

		public static void GetLastItemColor(out Vector4 pOut)
		{
			fixed (Vector4* nativePOut = &pOut)
			{
				ImPlotNative.GetLastItemColor(nativePOut);
			}
		}

		public static string GetStyleColorName(ImPlotCol idx)
		{
			var result = ImPlotNative.GetStyleColorName(idx);
			return Utils.DecodeStringUTF8(result);
		}

		public static string GetMarkerName(ImPlotMarker idx)
		{
			var result = ImPlotNative.GetMarkerName(idx);
			return Utils.DecodeStringUTF8(result);
		}

		public static ImPlotColormap AddColormapVec4Ptr(ReadOnlySpan<byte> name, Vector4[] cols, int size, bool qual)
		{
			var native_qual = qual ? (byte)1 : (byte)0;
			fixed (byte* nativeName = name)
			fixed (Vector4* nativeCols = cols)
			{
				return ImPlotNative.AddColormapVec4Ptr(nativeName, nativeCols, size, native_qual);
			}
		}

		public static ImPlotColormap AddColormapVec4Ptr(ReadOnlySpan<char> name, Vector4[] cols, int size, bool qual)
		{
			// Marshaling name to native string
			byte* nativeName;
			var byteCountName = 0;
			if (name != null && !name.IsEmpty)
			{
				byteCountName = Encoding.UTF8.GetByteCount(name);
				if(byteCountName > Utils.MaxStackallocSize)
				{
					nativeName = Utils.Alloc<byte>(byteCountName + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountName + 1];
					nativeName = stackallocBytes;
				}
				var offsetName = Utils.EncodeStringUTF8(name, nativeName, byteCountName);
				nativeName[offsetName] = 0;
			}
			else nativeName = null;

			var native_qual = qual ? (byte)1 : (byte)0;
			fixed (Vector4* nativeCols = cols)
			{
				var result = ImPlotNative.AddColormapVec4Ptr(nativeName, nativeCols, size, native_qual);
				// Freeing name native string
				if (byteCountName > Utils.MaxStackallocSize)
					Utils.Free(nativeName);
				return result;
			}
		}

		public static ImPlotColormap AddColormapU32Ptr(ReadOnlySpan<byte> name, uint[] cols, int size, bool qual)
		{
			var native_qual = qual ? (byte)1 : (byte)0;
			fixed (byte* nativeName = name)
			fixed (uint* nativeCols = cols)
			{
				return ImPlotNative.AddColormapU32Ptr(nativeName, nativeCols, size, native_qual);
			}
		}

		public static ImPlotColormap AddColormapU32Ptr(ReadOnlySpan<char> name, uint[] cols, int size, bool qual)
		{
			// Marshaling name to native string
			byte* nativeName;
			var byteCountName = 0;
			if (name != null && !name.IsEmpty)
			{
				byteCountName = Encoding.UTF8.GetByteCount(name);
				if(byteCountName > Utils.MaxStackallocSize)
				{
					nativeName = Utils.Alloc<byte>(byteCountName + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountName + 1];
					nativeName = stackallocBytes;
				}
				var offsetName = Utils.EncodeStringUTF8(name, nativeName, byteCountName);
				nativeName[offsetName] = 0;
			}
			else nativeName = null;

			var native_qual = qual ? (byte)1 : (byte)0;
			fixed (uint* nativeCols = cols)
			{
				var result = ImPlotNative.AddColormapU32Ptr(nativeName, nativeCols, size, native_qual);
				// Freeing name native string
				if (byteCountName > Utils.MaxStackallocSize)
					Utils.Free(nativeName);
				return result;
			}
		}

		public static int GetColormapCount()
		{
			return ImPlotNative.GetColormapCount();
		}

		public static string GetColormapName(ImPlotColormap cmap)
		{
			var result = ImPlotNative.GetColormapName(cmap);
			return Utils.DecodeStringUTF8(result);
		}

		public static ImPlotColormap GetColormapIndex(ReadOnlySpan<byte> name)
		{
			fixed (byte* nativeName = name)
			{
				return ImPlotNative.GetColormapIndex(nativeName);
			}
		}

		public static ImPlotColormap GetColormapIndex(ReadOnlySpan<char> name)
		{
			// Marshaling name to native string
			byte* nativeName;
			var byteCountName = 0;
			if (name != null && !name.IsEmpty)
			{
				byteCountName = Encoding.UTF8.GetByteCount(name);
				if(byteCountName > Utils.MaxStackallocSize)
				{
					nativeName = Utils.Alloc<byte>(byteCountName + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountName + 1];
					nativeName = stackallocBytes;
				}
				var offsetName = Utils.EncodeStringUTF8(name, nativeName, byteCountName);
				nativeName[offsetName] = 0;
			}
			else nativeName = null;

			var result = ImPlotNative.GetColormapIndex(nativeName);
			// Freeing name native string
			if (byteCountName > Utils.MaxStackallocSize)
				Utils.Free(nativeName);
			return result;
		}

		public static void PushColormapPlotColormap(ImPlotColormap cmap)
		{
			ImPlotNative.PushColormapPlotColormap(cmap);
		}

		public static void PushColormapStr(ReadOnlySpan<byte> name)
		{
			fixed (byte* nativeName = name)
			{
				ImPlotNative.PushColormapStr(nativeName);
			}
		}

		public static void PushColormapStr(ReadOnlySpan<char> name)
		{
			// Marshaling name to native string
			byte* nativeName;
			var byteCountName = 0;
			if (name != null && !name.IsEmpty)
			{
				byteCountName = Encoding.UTF8.GetByteCount(name);
				if(byteCountName > Utils.MaxStackallocSize)
				{
					nativeName = Utils.Alloc<byte>(byteCountName + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountName + 1];
					nativeName = stackallocBytes;
				}
				var offsetName = Utils.EncodeStringUTF8(name, nativeName, byteCountName);
				nativeName[offsetName] = 0;
			}
			else nativeName = null;

			ImPlotNative.PushColormapStr(nativeName);
			// Freeing name native string
			if (byteCountName > Utils.MaxStackallocSize)
				Utils.Free(nativeName);
		}

		public static void PopColormap(int count)
		{
			ImPlotNative.PopColormap(count);
		}

		public static void PopColormap()
		{
			// defining omitted parameters
			int count = 1;
			ImPlotNative.PopColormap(count);
		}

		public static void NextColormapColor(out Vector4 pOut)
		{
			fixed (Vector4* nativePOut = &pOut)
			{
				ImPlotNative.NextColormapColor(nativePOut);
			}
		}

		public static int GetColormapSize(ImPlotColormap cmap)
		{
			return ImPlotNative.GetColormapSize(cmap);
		}

		public static int GetColormapSize()
		{
			// defining omitted parameters
			ImPlotColormap cmap = (ImPlotColormap)0;
			return ImPlotNative.GetColormapSize(cmap);
		}

		public static void GetColormapColor(out Vector4 pOut, int idx, ImPlotColormap cmap)
		{
			fixed (Vector4* nativePOut = &pOut)
			{
				ImPlotNative.GetColormapColor(nativePOut, idx, cmap);
			}
		}

		public static void GetColormapColor(out Vector4 pOut, int idx)
		{
			// defining omitted parameters
			ImPlotColormap cmap = (ImPlotColormap)0;
			fixed (Vector4* nativePOut = &pOut)
			{
				ImPlotNative.GetColormapColor(nativePOut, idx, cmap);
			}
		}

		public static void SampleColormap(out Vector4 pOut, float t, ImPlotColormap cmap)
		{
			fixed (Vector4* nativePOut = &pOut)
			{
				ImPlotNative.SampleColormap(nativePOut, t, cmap);
			}
		}

		public static void SampleColormap(out Vector4 pOut, float t)
		{
			// defining omitted parameters
			ImPlotColormap cmap = (ImPlotColormap)0;
			fixed (Vector4* nativePOut = &pOut)
			{
				ImPlotNative.SampleColormap(nativePOut, t, cmap);
			}
		}

		public static void ColormapScale(ReadOnlySpan<byte> label, double scaleMin, double scaleMax, Vector2 size, ReadOnlySpan<byte> format, ImPlotColormapScaleFlags flags, ImPlotColormap cmap)
		{
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeFormat = format)
			{
				ImPlotNative.ColormapScale(nativeLabel, scaleMin, scaleMax, size, nativeFormat, flags, cmap);
			}
		}

		public static void ColormapScale(ReadOnlySpan<char> label, double scaleMin, double scaleMax, Vector2 size, ReadOnlySpan<char> format, ImPlotColormapScaleFlags flags, ImPlotColormap cmap)
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

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			ImPlotNative.ColormapScale(nativeLabel, scaleMin, scaleMax, size, nativeFormat, flags, cmap);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			// Freeing format native string
			if (byteCountFormat > Utils.MaxStackallocSize)
				Utils.Free(nativeFormat);
		}

		public static void ColormapScale(ReadOnlySpan<byte> label, double scaleMin, double scaleMax, Vector2 size, ReadOnlySpan<byte> format, ImPlotColormapScaleFlags flags)
		{
			// defining omitted parameters
			ImPlotColormap cmap = (ImPlotColormap)0;
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeFormat = format)
			{
				ImPlotNative.ColormapScale(nativeLabel, scaleMin, scaleMax, size, nativeFormat, flags, cmap);
			}
		}

		public static void ColormapScale(ReadOnlySpan<char> label, double scaleMin, double scaleMax, Vector2 size, ReadOnlySpan<char> format, ImPlotColormapScaleFlags flags)
		{
			// defining omitted parameters
			ImPlotColormap cmap = (ImPlotColormap)0;
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

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			ImPlotNative.ColormapScale(nativeLabel, scaleMin, scaleMax, size, nativeFormat, flags, cmap);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			// Freeing format native string
			if (byteCountFormat > Utils.MaxStackallocSize)
				Utils.Free(nativeFormat);
		}

		public static void ColormapScale(ReadOnlySpan<byte> label, double scaleMin, double scaleMax, Vector2 size, ReadOnlySpan<byte> format)
		{
			// defining omitted parameters
			ImPlotColormap cmap = (ImPlotColormap)0;
			ImPlotColormapScaleFlags flags = ImPlotColormapScaleFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeFormat = format)
			{
				ImPlotNative.ColormapScale(nativeLabel, scaleMin, scaleMax, size, nativeFormat, flags, cmap);
			}
		}

		public static void ColormapScale(ReadOnlySpan<char> label, double scaleMin, double scaleMax, Vector2 size, ReadOnlySpan<char> format)
		{
			// defining omitted parameters
			ImPlotColormap cmap = (ImPlotColormap)0;
			ImPlotColormapScaleFlags flags = ImPlotColormapScaleFlags.None;
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

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			ImPlotNative.ColormapScale(nativeLabel, scaleMin, scaleMax, size, nativeFormat, flags, cmap);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			// Freeing format native string
			if (byteCountFormat > Utils.MaxStackallocSize)
				Utils.Free(nativeFormat);
		}

		public static void ColormapScale(ReadOnlySpan<byte> label, double scaleMin, double scaleMax, Vector2 size)
		{
			// defining omitted parameters
			ImPlotColormap cmap = (ImPlotColormap)0;
			ImPlotColormapScaleFlags flags = ImPlotColormapScaleFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%g");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%g", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			{
				ImPlotNative.ColormapScale(nativeLabel, scaleMin, scaleMax, size, nativeFormat, flags, cmap);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
			}
		}

		public static void ColormapScale(ReadOnlySpan<char> label, double scaleMin, double scaleMax, Vector2 size)
		{
			// defining omitted parameters
			ImPlotColormap cmap = (ImPlotColormap)0;
			ImPlotColormapScaleFlags flags = ImPlotColormapScaleFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%g");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%g", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
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

			ImPlotNative.ColormapScale(nativeLabel, scaleMin, scaleMax, size, nativeNativeFormat, flags, cmap);
			if (byteCountNativeFormat > Utils.MaxStackallocSize)
				Utils.Free(nativeNativeFormat);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
		}

		public static void ColormapScale(ReadOnlySpan<byte> label, double scaleMin, double scaleMax)
		{
			// defining omitted parameters
			ImPlotColormap cmap = (ImPlotColormap)0;
			ImPlotColormapScaleFlags flags = ImPlotColormapScaleFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%g");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%g", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			Vector2 size = new Vector2(0,0);
			fixed (byte* nativeLabel = label)
			{
				ImPlotNative.ColormapScale(nativeLabel, scaleMin, scaleMax, size, nativeFormat, flags, cmap);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
			}
		}

		public static void ColormapScale(ReadOnlySpan<char> label, double scaleMin, double scaleMax)
		{
			// defining omitted parameters
			ImPlotColormap cmap = (ImPlotColormap)0;
			ImPlotColormapScaleFlags flags = ImPlotColormapScaleFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%g");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%g", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			Vector2 size = new Vector2(0,0);
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

			ImPlotNative.ColormapScale(nativeLabel, scaleMin, scaleMax, size, nativeNativeFormat, flags, cmap);
			if (byteCountNativeFormat > Utils.MaxStackallocSize)
				Utils.Free(nativeNativeFormat);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
		}

		public static bool ColormapSlider(ReadOnlySpan<byte> label, ref float t, out Vector4 _out, ReadOnlySpan<byte> format, ImPlotColormap cmap)
		{
			fixed (byte* nativeLabel = label)
			fixed (float* nativeT = &t)
			fixed (Vector4* nativeOut = &_out)
			fixed (byte* nativeFormat = format)
			{
				var result = ImPlotNative.ColormapSlider(nativeLabel, nativeT, nativeOut, nativeFormat, cmap);
				return result != 0;
			}
		}

		public static bool ColormapSlider(ReadOnlySpan<char> label, ref float t, out Vector4 _out, ReadOnlySpan<char> format, ImPlotColormap cmap)
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

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (float* nativeT = &t)
			fixed (Vector4* nativeOut = &_out)
			{
				var result = ImPlotNative.ColormapSlider(nativeLabel, nativeT, nativeOut, nativeFormat, cmap);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool ColormapSlider(ReadOnlySpan<byte> label, ref float t, out Vector4 _out, ReadOnlySpan<byte> format)
		{
			// defining omitted parameters
			ImPlotColormap cmap = (ImPlotColormap)0;
			fixed (byte* nativeLabel = label)
			fixed (float* nativeT = &t)
			fixed (Vector4* nativeOut = &_out)
			fixed (byte* nativeFormat = format)
			{
				var result = ImPlotNative.ColormapSlider(nativeLabel, nativeT, nativeOut, nativeFormat, cmap);
				return result != 0;
			}
		}

		public static bool ColormapSlider(ReadOnlySpan<char> label, ref float t, out Vector4 _out, ReadOnlySpan<char> format)
		{
			// defining omitted parameters
			ImPlotColormap cmap = (ImPlotColormap)0;
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

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (float* nativeT = &t)
			fixed (Vector4* nativeOut = &_out)
			{
				var result = ImPlotNative.ColormapSlider(nativeLabel, nativeT, nativeOut, nativeFormat, cmap);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool ColormapSlider(ReadOnlySpan<byte> label, ref float t, out Vector4 _out)
		{
			// defining omitted parameters
			ImPlotColormap cmap = (ImPlotColormap)0;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (float* nativeT = &t)
			fixed (Vector4* nativeOut = &_out)
			{
				var result = ImPlotNative.ColormapSlider(nativeLabel, nativeT, nativeOut, nativeFormat, cmap);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool ColormapSlider(ReadOnlySpan<char> label, ref float t, out Vector4 _out)
		{
			// defining omitted parameters
			ImPlotColormap cmap = (ImPlotColormap)0;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
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

			fixed (float* nativeT = &t)
			fixed (Vector4* nativeOut = &_out)
			{
				var result = ImPlotNative.ColormapSlider(nativeLabel, nativeT, nativeOut, nativeNativeFormat, cmap);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool ColormapSlider(ReadOnlySpan<byte> label, ref float t)
		{
			// defining omitted parameters
			ImPlotColormap cmap = (ImPlotColormap)0;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			Vector4* _out = null;
			fixed (byte* nativeLabel = label)
			fixed (float* nativeT = &t)
			{
				var result = ImPlotNative.ColormapSlider(nativeLabel, nativeT, _out, nativeFormat, cmap);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool ColormapSlider(ReadOnlySpan<char> label, ref float t)
		{
			// defining omitted parameters
			ImPlotColormap cmap = (ImPlotColormap)0;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			Vector4* _out = null;
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

			fixed (float* nativeT = &t)
			{
				var result = ImPlotNative.ColormapSlider(nativeLabel, nativeT, _out, nativeNativeFormat, cmap);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool ColormapButton(ReadOnlySpan<byte> label, Vector2 size, ImPlotColormap cmap)
		{
			fixed (byte* nativeLabel = label)
			{
				var result = ImPlotNative.ColormapButton(nativeLabel, size, cmap);
				return result != 0;
			}
		}

		public static bool ColormapButton(ReadOnlySpan<char> label, Vector2 size, ImPlotColormap cmap)
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

			var result = ImPlotNative.ColormapButton(nativeLabel, size, cmap);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		public static bool ColormapButton(ReadOnlySpan<byte> label, Vector2 size)
		{
			// defining omitted parameters
			ImPlotColormap cmap = (ImPlotColormap)0;
			fixed (byte* nativeLabel = label)
			{
				var result = ImPlotNative.ColormapButton(nativeLabel, size, cmap);
				return result != 0;
			}
		}

		public static bool ColormapButton(ReadOnlySpan<char> label, Vector2 size)
		{
			// defining omitted parameters
			ImPlotColormap cmap = (ImPlotColormap)0;
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

			var result = ImPlotNative.ColormapButton(nativeLabel, size, cmap);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		public static bool ColormapButton(ReadOnlySpan<byte> label)
		{
			// defining omitted parameters
			ImPlotColormap cmap = (ImPlotColormap)0;
			Vector2 size = new Vector2(0,0);
			fixed (byte* nativeLabel = label)
			{
				var result = ImPlotNative.ColormapButton(nativeLabel, size, cmap);
				return result != 0;
			}
		}

		public static bool ColormapButton(ReadOnlySpan<char> label)
		{
			// defining omitted parameters
			ImPlotColormap cmap = (ImPlotColormap)0;
			Vector2 size = new Vector2(0,0);
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

			var result = ImPlotNative.ColormapButton(nativeLabel, size, cmap);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		public static void BustColorCache(ReadOnlySpan<byte> plotTitleId)
		{
			fixed (byte* nativePlotTitleId = plotTitleId)
			{
				ImPlotNative.BustColorCache(nativePlotTitleId);
			}
		}

		public static void BustColorCache(ReadOnlySpan<char> plotTitleId)
		{
			// Marshaling plotTitleId to native string
			byte* nativePlotTitleId;
			var byteCountPlotTitleId = 0;
			if (plotTitleId != null && !plotTitleId.IsEmpty)
			{
				byteCountPlotTitleId = Encoding.UTF8.GetByteCount(plotTitleId);
				if(byteCountPlotTitleId > Utils.MaxStackallocSize)
				{
					nativePlotTitleId = Utils.Alloc<byte>(byteCountPlotTitleId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountPlotTitleId + 1];
					nativePlotTitleId = stackallocBytes;
				}
				var offsetPlotTitleId = Utils.EncodeStringUTF8(plotTitleId, nativePlotTitleId, byteCountPlotTitleId);
				nativePlotTitleId[offsetPlotTitleId] = 0;
			}
			else nativePlotTitleId = null;

			ImPlotNative.BustColorCache(nativePlotTitleId);
			// Freeing plotTitleId native string
			if (byteCountPlotTitleId > Utils.MaxStackallocSize)
				Utils.Free(nativePlotTitleId);
		}

		public static void BustColorCache()
		{
			// defining omitted parameters
			byte* plotTitleId = null;
			ImPlotNative.BustColorCache(plotTitleId);
		}

		public static ImPlotInputMapPtr GetInputMap()
		{
			return ImPlotNative.GetInputMap();
		}

		public static void MapInputDefault(ImPlotInputMapPtr dst)
		{
			ImPlotNative.MapInputDefault(dst);
		}

		public static void MapInputDefault()
		{
			// defining omitted parameters
			ImPlotInputMap* dst = null;
			ImPlotNative.MapInputDefault(dst);
		}

		public static void MapInputReverse(ImPlotInputMapPtr dst)
		{
			ImPlotNative.MapInputReverse(dst);
		}

		public static void MapInputReverse()
		{
			// defining omitted parameters
			ImPlotInputMap* dst = null;
			ImPlotNative.MapInputReverse(dst);
		}

		public static void ItemIconVec4(Vector4 col)
		{
			ImPlotNative.ItemIconVec4(col);
		}

		public static void ItemIconU32(uint col)
		{
			ImPlotNative.ItemIconU32(col);
		}

		public static void ColormapIcon(ImPlotColormap cmap)
		{
			ImPlotNative.ColormapIcon(cmap);
		}

		public static ImDrawListPtr GetPlotDrawList()
		{
			return ImPlotNative.GetPlotDrawList();
		}

		public static void PushPlotClipRect(float expand)
		{
			ImPlotNative.PushPlotClipRect(expand);
		}

		public static void PushPlotClipRect()
		{
			// defining omitted parameters
			float expand = 0;
			ImPlotNative.PushPlotClipRect(expand);
		}

		public static void PopPlotClipRect()
		{
			ImPlotNative.PopPlotClipRect();
		}

		public static bool ShowStyleSelector(ReadOnlySpan<byte> label)
		{
			fixed (byte* nativeLabel = label)
			{
				var result = ImPlotNative.ShowStyleSelector(nativeLabel);
				return result != 0;
			}
		}

		public static bool ShowStyleSelector(ReadOnlySpan<char> label)
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

			var result = ImPlotNative.ShowStyleSelector(nativeLabel);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		public static bool ShowColormapSelector(ReadOnlySpan<byte> label)
		{
			fixed (byte* nativeLabel = label)
			{
				var result = ImPlotNative.ShowColormapSelector(nativeLabel);
				return result != 0;
			}
		}

		public static bool ShowColormapSelector(ReadOnlySpan<char> label)
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

			var result = ImPlotNative.ShowColormapSelector(nativeLabel);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		public static bool ShowInputMapSelector(ReadOnlySpan<byte> label)
		{
			fixed (byte* nativeLabel = label)
			{
				var result = ImPlotNative.ShowInputMapSelector(nativeLabel);
				return result != 0;
			}
		}

		public static bool ShowInputMapSelector(ReadOnlySpan<char> label)
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

			var result = ImPlotNative.ShowInputMapSelector(nativeLabel);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		public static void ShowStyleEditor(ImPlotStylePtr _ref)
		{
			ImPlotNative.ShowStyleEditor(_ref);
		}

		public static void ShowStyleEditor()
		{
			// defining omitted parameters
			ImPlotStyle* _ref = null;
			ImPlotNative.ShowStyleEditor(_ref);
		}

		public static void ShowUserGuide()
		{
			ImPlotNative.ShowUserGuide();
		}

		public static void ShowMetricsWindow(ref bool pPopen)
		{
			var nativePPopenVal = pPopen ? (byte)1 : (byte)0;
			var nativePPopen = &nativePPopenVal;
			ImPlotNative.ShowMetricsWindow(nativePPopen);
			pPopen = nativePPopenVal != 0;
		}

		public static void ShowMetricsWindow()
		{
			// defining omitted parameters
			byte* pPopen = null;
			ImPlotNative.ShowMetricsWindow(pPopen);
		}

		public static void ShowDemoWindow(ref bool pOpen)
		{
			var nativePOpenVal = pOpen ? (byte)1 : (byte)0;
			var nativePOpen = &nativePOpenVal;
			ImPlotNative.ShowDemoWindow(nativePOpen);
			pOpen = nativePOpenVal != 0;
		}

		public static void ShowDemoWindow()
		{
			// defining omitted parameters
			byte* pOpen = null;
			ImPlotNative.ShowDemoWindow(pOpen);
		}

		public static float ImLog10Float(float x)
		{
			return ImPlotNative.ImLog10Float(x);
		}

		public static double ImLog10Double(double x)
		{
			return ImPlotNative.ImLog10Double(x);
		}

		public static float ImSinhFloat(float x)
		{
			return ImPlotNative.ImSinhFloat(x);
		}

		public static double ImSinhDouble(double x)
		{
			return ImPlotNative.ImSinhDouble(x);
		}

		public static float ImAsinhFloat(float x)
		{
			return ImPlotNative.ImAsinhFloat(x);
		}

		public static double ImAsinhDouble(double x)
		{
			return ImPlotNative.ImAsinhDouble(x);
		}

		public static float ImRemapFloat(float x, float x0, float x1, float y0, float y1)
		{
			return ImPlotNative.ImRemapFloat(x, x0, x1, y0, y1);
		}

		public static double ImRemapDouble(double x, double x0, double x1, double y0, double y1)
		{
			return ImPlotNative.ImRemapDouble(x, x0, x1, y0, y1);
		}

		public static sbyte ImRemapS8(sbyte x, sbyte x0, sbyte x1, sbyte y0, sbyte y1)
		{
			return ImPlotNative.ImRemapS8(x, x0, x1, y0, y1);
		}

		public static bool ImRemapU8(bool x, bool x0, bool x1, bool y0, bool y1)
		{
			var native_x = x ? (byte)1 : (byte)0;
			var native_x0 = x0 ? (byte)1 : (byte)0;
			var native_x1 = x1 ? (byte)1 : (byte)0;
			var native_y0 = y0 ? (byte)1 : (byte)0;
			var native_y1 = y1 ? (byte)1 : (byte)0;
			var result = ImPlotNative.ImRemapU8(native_x, native_x0, native_x1, native_y0, native_y1);
			return result != 0;
		}

		public static short ImRemapS16(short x, short x0, short x1, short y0, short y1)
		{
			return ImPlotNative.ImRemapS16(x, x0, x1, y0, y1);
		}

		public static ushort ImRemapU16(ushort x, ushort x0, ushort x1, ushort y0, ushort y1)
		{
			return ImPlotNative.ImRemapU16(x, x0, x1, y0, y1);
		}

		public static int ImRemapS32(int x, int x0, int x1, int y0, int y1)
		{
			return ImPlotNative.ImRemapS32(x, x0, x1, y0, y1);
		}

		public static uint ImRemapU32(uint x, uint x0, uint x1, uint y0, uint y1)
		{
			return ImPlotNative.ImRemapU32(x, x0, x1, y0, y1);
		}

		public static long ImRemapS64(long x, long x0, long x1, long y0, long y1)
		{
			return ImPlotNative.ImRemapS64(x, x0, x1, y0, y1);
		}

		public static ulong ImRemapU64(ulong x, ulong x0, ulong x1, ulong y0, ulong y1)
		{
			return ImPlotNative.ImRemapU64(x, x0, x1, y0, y1);
		}

		public static float ImRemap01Float(float x, float x0, float x1)
		{
			return ImPlotNative.ImRemap01Float(x, x0, x1);
		}

		public static double ImRemap01Double(double x, double x0, double x1)
		{
			return ImPlotNative.ImRemap01Double(x, x0, x1);
		}

		public static sbyte ImRemap01S8(sbyte x, sbyte x0, sbyte x1)
		{
			return ImPlotNative.ImRemap01S8(x, x0, x1);
		}

		public static bool ImRemap01U8(bool x, bool x0, bool x1)
		{
			var native_x = x ? (byte)1 : (byte)0;
			var native_x0 = x0 ? (byte)1 : (byte)0;
			var native_x1 = x1 ? (byte)1 : (byte)0;
			var result = ImPlotNative.ImRemap01U8(native_x, native_x0, native_x1);
			return result != 0;
		}

		public static short ImRemap01S16(short x, short x0, short x1)
		{
			return ImPlotNative.ImRemap01S16(x, x0, x1);
		}

		public static ushort ImRemap01U16(ushort x, ushort x0, ushort x1)
		{
			return ImPlotNative.ImRemap01U16(x, x0, x1);
		}

		public static int ImRemap01S32(int x, int x0, int x1)
		{
			return ImPlotNative.ImRemap01S32(x, x0, x1);
		}

		public static uint ImRemap01U32(uint x, uint x0, uint x1)
		{
			return ImPlotNative.ImRemap01U32(x, x0, x1);
		}

		public static long ImRemap01S64(long x, long x0, long x1)
		{
			return ImPlotNative.ImRemap01S64(x, x0, x1);
		}

		public static ulong ImRemap01U64(ulong x, ulong x0, ulong x1)
		{
			return ImPlotNative.ImRemap01U64(x, x0, x1);
		}

		public static bool ImAlmostEqual(double v1, double v2)
		{
			// defining omitted parameters
			int ulp = 2;
			var result = ImPlotNative.ImAlmostEqual(v1, v2, ulp);
			return result != 0;
		}

		public static float ImMinArrayFloatPtr(float[] values, int count)
		{
			fixed (float* nativeValues = values)
			{
				return ImPlotNative.ImMinArrayFloatPtr(nativeValues, count);
			}
		}

		public static double ImMinArrayDoublePtr(double[] values, int count)
		{
			fixed (double* nativeValues = values)
			{
				return ImPlotNative.ImMinArrayDoublePtr(nativeValues, count);
			}
		}

		public static sbyte ImMinArrayS8Ptr(sbyte[] values, int count)
		{
			fixed (sbyte* nativeValues = values)
			{
				return ImPlotNative.ImMinArrayS8Ptr(nativeValues, count);
			}
		}

		public static bool ImMinArrayU8Ptr(byte[] values, int count)
		{
			fixed (byte* nativeValues = values)
			{
				var result = ImPlotNative.ImMinArrayU8Ptr(nativeValues, count);
				return result != 0;
			}
		}

		public static short ImMinArrayS16Ptr(short[] values, int count)
		{
			fixed (short* nativeValues = values)
			{
				return ImPlotNative.ImMinArrayS16Ptr(nativeValues, count);
			}
		}

		public static ushort ImMinArrayU16Ptr(ushort[] values, int count)
		{
			fixed (ushort* nativeValues = values)
			{
				return ImPlotNative.ImMinArrayU16Ptr(nativeValues, count);
			}
		}

		public static int ImMinArrayS32Ptr(int[] values, int count)
		{
			fixed (int* nativeValues = values)
			{
				return ImPlotNative.ImMinArrayS32Ptr(nativeValues, count);
			}
		}

		public static uint ImMinArrayU32Ptr(uint[] values, int count)
		{
			fixed (uint* nativeValues = values)
			{
				return ImPlotNative.ImMinArrayU32Ptr(nativeValues, count);
			}
		}

		public static long ImMinArrayS64Ptr(long[] values, int count)
		{
			fixed (long* nativeValues = values)
			{
				return ImPlotNative.ImMinArrayS64Ptr(nativeValues, count);
			}
		}

		public static ulong ImMinArrayU64Ptr(ulong[] values, int count)
		{
			fixed (ulong* nativeValues = values)
			{
				return ImPlotNative.ImMinArrayU64Ptr(nativeValues, count);
			}
		}

		public static float ImMaxArrayFloatPtr(float[] values, int count)
		{
			fixed (float* nativeValues = values)
			{
				return ImPlotNative.ImMaxArrayFloatPtr(nativeValues, count);
			}
		}

		public static double ImMaxArrayDoublePtr(double[] values, int count)
		{
			fixed (double* nativeValues = values)
			{
				return ImPlotNative.ImMaxArrayDoublePtr(nativeValues, count);
			}
		}

		public static sbyte ImMaxArrayS8Ptr(sbyte[] values, int count)
		{
			fixed (sbyte* nativeValues = values)
			{
				return ImPlotNative.ImMaxArrayS8Ptr(nativeValues, count);
			}
		}

		public static bool ImMaxArrayU8Ptr(byte[] values, int count)
		{
			fixed (byte* nativeValues = values)
			{
				var result = ImPlotNative.ImMaxArrayU8Ptr(nativeValues, count);
				return result != 0;
			}
		}

		public static short ImMaxArrayS16Ptr(short[] values, int count)
		{
			fixed (short* nativeValues = values)
			{
				return ImPlotNative.ImMaxArrayS16Ptr(nativeValues, count);
			}
		}

		public static ushort ImMaxArrayU16Ptr(ushort[] values, int count)
		{
			fixed (ushort* nativeValues = values)
			{
				return ImPlotNative.ImMaxArrayU16Ptr(nativeValues, count);
			}
		}

		public static int ImMaxArrayS32Ptr(int[] values, int count)
		{
			fixed (int* nativeValues = values)
			{
				return ImPlotNative.ImMaxArrayS32Ptr(nativeValues, count);
			}
		}

		public static uint ImMaxArrayU32Ptr(uint[] values, int count)
		{
			fixed (uint* nativeValues = values)
			{
				return ImPlotNative.ImMaxArrayU32Ptr(nativeValues, count);
			}
		}

		public static long ImMaxArrayS64Ptr(long[] values, int count)
		{
			fixed (long* nativeValues = values)
			{
				return ImPlotNative.ImMaxArrayS64Ptr(nativeValues, count);
			}
		}

		public static ulong ImMaxArrayU64Ptr(ulong[] values, int count)
		{
			fixed (ulong* nativeValues = values)
			{
				return ImPlotNative.ImMaxArrayU64Ptr(nativeValues, count);
			}
		}

		public static void ImMinMaxArrayFloatPtr(float[] values, int count, out float minOut, out float maxOut)
		{
			fixed (float* nativeValues = values)
			fixed (float* nativeMinOut = &minOut)
			fixed (float* nativeMaxOut = &maxOut)
			{
				ImPlotNative.ImMinMaxArrayFloatPtr(nativeValues, count, nativeMinOut, nativeMaxOut);
			}
		}

		public static void ImMinMaxArrayDoublePtr(double[] values, int count, out double minOut, out double maxOut)
		{
			fixed (double* nativeValues = values)
			fixed (double* nativeMinOut = &minOut)
			fixed (double* nativeMaxOut = &maxOut)
			{
				ImPlotNative.ImMinMaxArrayDoublePtr(nativeValues, count, nativeMinOut, nativeMaxOut);
			}
		}

		public static void ImMinMaxArrayS8Ptr(sbyte[] values, int count, out sbyte minOut, out sbyte maxOut)
		{
			fixed (sbyte* nativeValues = values)
			fixed (sbyte* nativeMinOut = &minOut)
			fixed (sbyte* nativeMaxOut = &maxOut)
			{
				ImPlotNative.ImMinMaxArrayS8Ptr(nativeValues, count, nativeMinOut, nativeMaxOut);
			}
		}

		public static void ImMinMaxArrayU8Ptr(byte[] values, int count, out byte minOut, out byte maxOut)
		{
			fixed (byte* nativeValues = values)
			fixed (byte* nativeMinOut = &minOut)
			fixed (byte* nativeMaxOut = &maxOut)
			{
				ImPlotNative.ImMinMaxArrayU8Ptr(nativeValues, count, nativeMinOut, nativeMaxOut);
			}
		}

		public static void ImMinMaxArrayS16Ptr(short[] values, int count, out short minOut, out short maxOut)
		{
			fixed (short* nativeValues = values)
			fixed (short* nativeMinOut = &minOut)
			fixed (short* nativeMaxOut = &maxOut)
			{
				ImPlotNative.ImMinMaxArrayS16Ptr(nativeValues, count, nativeMinOut, nativeMaxOut);
			}
		}

		public static void ImMinMaxArrayU16Ptr(ushort[] values, int count, out ushort minOut, out ushort maxOut)
		{
			fixed (ushort* nativeValues = values)
			fixed (ushort* nativeMinOut = &minOut)
			fixed (ushort* nativeMaxOut = &maxOut)
			{
				ImPlotNative.ImMinMaxArrayU16Ptr(nativeValues, count, nativeMinOut, nativeMaxOut);
			}
		}

		public static void ImMinMaxArrayS32Ptr(int[] values, int count, out int minOut, out int maxOut)
		{
			fixed (int* nativeValues = values)
			fixed (int* nativeMinOut = &minOut)
			fixed (int* nativeMaxOut = &maxOut)
			{
				ImPlotNative.ImMinMaxArrayS32Ptr(nativeValues, count, nativeMinOut, nativeMaxOut);
			}
		}

		public static void ImMinMaxArrayU32Ptr(uint[] values, int count, out uint minOut, out uint maxOut)
		{
			fixed (uint* nativeValues = values)
			fixed (uint* nativeMinOut = &minOut)
			fixed (uint* nativeMaxOut = &maxOut)
			{
				ImPlotNative.ImMinMaxArrayU32Ptr(nativeValues, count, nativeMinOut, nativeMaxOut);
			}
		}

		public static void ImMinMaxArrayS64Ptr(long[] values, int count, out long minOut, out long maxOut)
		{
			fixed (long* nativeValues = values)
			fixed (long* nativeMinOut = &minOut)
			fixed (long* nativeMaxOut = &maxOut)
			{
				ImPlotNative.ImMinMaxArrayS64Ptr(nativeValues, count, nativeMinOut, nativeMaxOut);
			}
		}

		public static void ImMinMaxArrayU64Ptr(ulong[] values, int count, out ulong minOut, out ulong maxOut)
		{
			fixed (ulong* nativeValues = values)
			fixed (ulong* nativeMinOut = &minOut)
			fixed (ulong* nativeMaxOut = &maxOut)
			{
				ImPlotNative.ImMinMaxArrayU64Ptr(nativeValues, count, nativeMinOut, nativeMaxOut);
			}
		}

		public static float ImSumFloatPtr(float[] values, int count)
		{
			fixed (float* nativeValues = values)
			{
				return ImPlotNative.ImSumFloatPtr(nativeValues, count);
			}
		}

		public static double ImSumDoublePtr(double[] values, int count)
		{
			fixed (double* nativeValues = values)
			{
				return ImPlotNative.ImSumDoublePtr(nativeValues, count);
			}
		}

		public static sbyte ImSumS8Ptr(sbyte[] values, int count)
		{
			fixed (sbyte* nativeValues = values)
			{
				return ImPlotNative.ImSumS8Ptr(nativeValues, count);
			}
		}

		public static bool ImSumU8Ptr(byte[] values, int count)
		{
			fixed (byte* nativeValues = values)
			{
				var result = ImPlotNative.ImSumU8Ptr(nativeValues, count);
				return result != 0;
			}
		}

		public static short ImSumS16Ptr(short[] values, int count)
		{
			fixed (short* nativeValues = values)
			{
				return ImPlotNative.ImSumS16Ptr(nativeValues, count);
			}
		}

		public static ushort ImSumU16Ptr(ushort[] values, int count)
		{
			fixed (ushort* nativeValues = values)
			{
				return ImPlotNative.ImSumU16Ptr(nativeValues, count);
			}
		}

		public static int ImSumS32Ptr(int[] values, int count)
		{
			fixed (int* nativeValues = values)
			{
				return ImPlotNative.ImSumS32Ptr(nativeValues, count);
			}
		}

		public static uint ImSumU32Ptr(uint[] values, int count)
		{
			fixed (uint* nativeValues = values)
			{
				return ImPlotNative.ImSumU32Ptr(nativeValues, count);
			}
		}

		public static long ImSumS64Ptr(long[] values, int count)
		{
			fixed (long* nativeValues = values)
			{
				return ImPlotNative.ImSumS64Ptr(nativeValues, count);
			}
		}

		public static ulong ImSumU64Ptr(ulong[] values, int count)
		{
			fixed (ulong* nativeValues = values)
			{
				return ImPlotNative.ImSumU64Ptr(nativeValues, count);
			}
		}

		public static double ImMeanFloatPtr(float[] values, int count)
		{
			fixed (float* nativeValues = values)
			{
				return ImPlotNative.ImMeanFloatPtr(nativeValues, count);
			}
		}

		public static double ImMeanDoublePtr(double[] values, int count)
		{
			fixed (double* nativeValues = values)
			{
				return ImPlotNative.ImMeanDoublePtr(nativeValues, count);
			}
		}

		public static double ImMeanS8Ptr(sbyte[] values, int count)
		{
			fixed (sbyte* nativeValues = values)
			{
				return ImPlotNative.ImMeanS8Ptr(nativeValues, count);
			}
		}

		public static double ImMeanU8Ptr(byte[] values, int count)
		{
			fixed (byte* nativeValues = values)
			{
				return ImPlotNative.ImMeanU8Ptr(nativeValues, count);
			}
		}

		public static double ImMeanS16Ptr(short[] values, int count)
		{
			fixed (short* nativeValues = values)
			{
				return ImPlotNative.ImMeanS16Ptr(nativeValues, count);
			}
		}

		public static double ImMeanU16Ptr(ushort[] values, int count)
		{
			fixed (ushort* nativeValues = values)
			{
				return ImPlotNative.ImMeanU16Ptr(nativeValues, count);
			}
		}

		public static double ImMeanS32Ptr(int[] values, int count)
		{
			fixed (int* nativeValues = values)
			{
				return ImPlotNative.ImMeanS32Ptr(nativeValues, count);
			}
		}

		public static double ImMeanU32Ptr(uint[] values, int count)
		{
			fixed (uint* nativeValues = values)
			{
				return ImPlotNative.ImMeanU32Ptr(nativeValues, count);
			}
		}

		public static double ImMeanS64Ptr(long[] values, int count)
		{
			fixed (long* nativeValues = values)
			{
				return ImPlotNative.ImMeanS64Ptr(nativeValues, count);
			}
		}

		public static double ImMeanU64Ptr(ulong[] values, int count)
		{
			fixed (ulong* nativeValues = values)
			{
				return ImPlotNative.ImMeanU64Ptr(nativeValues, count);
			}
		}

		public static double ImStdDevFloatPtr(float[] values, int count)
		{
			fixed (float* nativeValues = values)
			{
				return ImPlotNative.ImStdDevFloatPtr(nativeValues, count);
			}
		}

		public static double ImStdDevDoublePtr(double[] values, int count)
		{
			fixed (double* nativeValues = values)
			{
				return ImPlotNative.ImStdDevDoublePtr(nativeValues, count);
			}
		}

		public static double ImStdDevS8Ptr(sbyte[] values, int count)
		{
			fixed (sbyte* nativeValues = values)
			{
				return ImPlotNative.ImStdDevS8Ptr(nativeValues, count);
			}
		}

		public static double ImStdDevU8Ptr(byte[] values, int count)
		{
			fixed (byte* nativeValues = values)
			{
				return ImPlotNative.ImStdDevU8Ptr(nativeValues, count);
			}
		}

		public static double ImStdDevS16Ptr(short[] values, int count)
		{
			fixed (short* nativeValues = values)
			{
				return ImPlotNative.ImStdDevS16Ptr(nativeValues, count);
			}
		}

		public static double ImStdDevU16Ptr(ushort[] values, int count)
		{
			fixed (ushort* nativeValues = values)
			{
				return ImPlotNative.ImStdDevU16Ptr(nativeValues, count);
			}
		}

		public static double ImStdDevS32Ptr(int[] values, int count)
		{
			fixed (int* nativeValues = values)
			{
				return ImPlotNative.ImStdDevS32Ptr(nativeValues, count);
			}
		}

		public static double ImStdDevU32Ptr(uint[] values, int count)
		{
			fixed (uint* nativeValues = values)
			{
				return ImPlotNative.ImStdDevU32Ptr(nativeValues, count);
			}
		}

		public static double ImStdDevS64Ptr(long[] values, int count)
		{
			fixed (long* nativeValues = values)
			{
				return ImPlotNative.ImStdDevS64Ptr(nativeValues, count);
			}
		}

		public static double ImStdDevU64Ptr(ulong[] values, int count)
		{
			fixed (ulong* nativeValues = values)
			{
				return ImPlotNative.ImStdDevU64Ptr(nativeValues, count);
			}
		}

		public static bool ImOverlapsFloat(float minA, float maxA, float minB, float maxB)
		{
			var result = ImPlotNative.ImOverlapsFloat(minA, maxA, minB, maxB);
			return result != 0;
		}

		public static bool ImOverlapsDouble(double minA, double maxA, double minB, double maxB)
		{
			var result = ImPlotNative.ImOverlapsDouble(minA, maxA, minB, maxB);
			return result != 0;
		}

		public static bool ImOverlapsS8(sbyte minA, sbyte maxA, sbyte minB, sbyte maxB)
		{
			var result = ImPlotNative.ImOverlapsS8(minA, maxA, minB, maxB);
			return result != 0;
		}

		public static bool ImOverlapsU8(bool minA, bool maxA, bool minB, bool maxB)
		{
			var native_minA = minA ? (byte)1 : (byte)0;
			var native_maxA = maxA ? (byte)1 : (byte)0;
			var native_minB = minB ? (byte)1 : (byte)0;
			var native_maxB = maxB ? (byte)1 : (byte)0;
			var result = ImPlotNative.ImOverlapsU8(native_minA, native_maxA, native_minB, native_maxB);
			return result != 0;
		}

		public static bool ImOverlapsS16(short minA, short maxA, short minB, short maxB)
		{
			var result = ImPlotNative.ImOverlapsS16(minA, maxA, minB, maxB);
			return result != 0;
		}

		public static bool ImOverlapsU16(ushort minA, ushort maxA, ushort minB, ushort maxB)
		{
			var result = ImPlotNative.ImOverlapsU16(minA, maxA, minB, maxB);
			return result != 0;
		}

		public static bool ImOverlapsS32(int minA, int maxA, int minB, int maxB)
		{
			var result = ImPlotNative.ImOverlapsS32(minA, maxA, minB, maxB);
			return result != 0;
		}

		public static bool ImOverlapsU32(uint minA, uint maxA, uint minB, uint maxB)
		{
			var result = ImPlotNative.ImOverlapsU32(minA, maxA, minB, maxB);
			return result != 0;
		}

		public static bool ImOverlapsS64(long minA, long maxA, long minB, long maxB)
		{
			var result = ImPlotNative.ImOverlapsS64(minA, maxA, minB, maxB);
			return result != 0;
		}

		public static bool ImOverlapsU64(ulong minA, ulong maxA, ulong minB, ulong maxB)
		{
			var result = ImPlotNative.ImOverlapsU64(minA, maxA, minB, maxB);
			return result != 0;
		}

		public static ImPlotPlotPtr GetPlot(ReadOnlySpan<char> title)
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

			var result = ImPlotNative.GetPlot(nativeTitle);
			// Freeing title native string
			if (byteCountTitle > Utils.MaxStackallocSize)
				Utils.Free(nativeTitle);
			return result;
		}

		public static bool BeginItem(ReadOnlySpan<char> labelId, ImPlotItemFlags flags, ImPlotCol recolorFrom)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			var result = ImPlotNative.BeginItem(nativeLabelId, flags, recolorFrom);
			// Freeing labelId native string
			if (byteCountLabelId > Utils.MaxStackallocSize)
				Utils.Free(nativeLabelId);
			return result != 0;
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

		public static bool BeginItem(ReadOnlySpan<char> labelId, ImPlotItemFlags flags)
		{
			// defining omitted parameters
			ImPlotCol recolorFrom = (ImPlotCol)0;
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			var result = ImPlotNative.BeginItem(nativeLabelId, flags, recolorFrom);
			// Freeing labelId native string
			if (byteCountLabelId > Utils.MaxStackallocSize)
				Utils.Free(nativeLabelId);
			return result != 0;
		}

		public static bool BeginItem(ReadOnlySpan<byte> labelId)
		{
			// defining omitted parameters
			ImPlotCol recolorFrom = (ImPlotCol)0;
			ImPlotItemFlags flags = ImPlotItemFlags.None;
			fixed (byte* nativeLabelId = labelId)
			{
				var result = ImPlotNative.BeginItem(nativeLabelId, flags, recolorFrom);
				return result != 0;
			}
		}

		public static bool BeginItem(ReadOnlySpan<char> labelId)
		{
			// defining omitted parameters
			ImPlotCol recolorFrom = (ImPlotCol)0;
			ImPlotItemFlags flags = ImPlotItemFlags.None;
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			var result = ImPlotNative.BeginItem(nativeLabelId, flags, recolorFrom);
			// Freeing labelId native string
			if (byteCountLabelId > Utils.MaxStackallocSize)
				Utils.Free(nativeLabelId);
			return result != 0;
		}

		public static ImPlotItemPtr RegisterOrGetItem(ReadOnlySpan<char> labelId, ImPlotItemFlags flags, ref bool justCreated)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			var nativeJustCreatedVal = justCreated ? (byte)1 : (byte)0;
			var nativeJustCreated = &nativeJustCreatedVal;
			var result = ImPlotNative.RegisterOrGetItem(nativeLabelId, flags, nativeJustCreated);
			// Freeing labelId native string
			if (byteCountLabelId > Utils.MaxStackallocSize)
				Utils.Free(nativeLabelId);
			justCreated = nativeJustCreatedVal != 0;
			return result;
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

		public static ImPlotItemPtr RegisterOrGetItem(ReadOnlySpan<char> labelId, ImPlotItemFlags flags)
		{
			// defining omitted parameters
			byte* justCreated = null;
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			var result = ImPlotNative.RegisterOrGetItem(nativeLabelId, flags, justCreated);
			// Freeing labelId native string
			if (byteCountLabelId > Utils.MaxStackallocSize)
				Utils.Free(nativeLabelId);
			return result;
		}

		public static ImPlotItemPtr GetItem(ReadOnlySpan<char> labelId)
		{
			// Marshaling labelId to native string
			byte* nativeLabelId;
			var byteCountLabelId = 0;
			if (labelId != null && !labelId.IsEmpty)
			{
				byteCountLabelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCountLabelId > Utils.MaxStackallocSize)
				{
					nativeLabelId = Utils.Alloc<byte>(byteCountLabelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelId + 1];
					nativeLabelId = stackallocBytes;
				}
				var offsetLabelId = Utils.EncodeStringUTF8(labelId, nativeLabelId, byteCountLabelId);
				nativeLabelId[offsetLabelId] = 0;
			}
			else nativeLabelId = null;

			var result = ImPlotNative.GetItem(nativeLabelId);
			// Freeing labelId native string
			if (byteCountLabelId > Utils.MaxStackallocSize)
				Utils.Free(nativeLabelId);
			return result;
		}

		public static void ShowAxisContextMenu(ImPlotAxisPtr axis, ImPlotAxisPtr equalAxis)
		{
			// defining omitted parameters
			byte timeAllowed = 0;
			ImPlotNative.ShowAxisContextMenu(axis, equalAxis, timeAllowed);
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

		public static void ShowAltLegend(ReadOnlySpan<char> titleId, bool vertical, Vector2 size, bool interactable)
		{
			// Marshaling titleId to native string
			byte* nativeTitleId;
			var byteCountTitleId = 0;
			if (titleId != null && !titleId.IsEmpty)
			{
				byteCountTitleId = Encoding.UTF8.GetByteCount(titleId);
				if(byteCountTitleId > Utils.MaxStackallocSize)
				{
					nativeTitleId = Utils.Alloc<byte>(byteCountTitleId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTitleId + 1];
					nativeTitleId = stackallocBytes;
				}
				var offsetTitleId = Utils.EncodeStringUTF8(titleId, nativeTitleId, byteCountTitleId);
				nativeTitleId[offsetTitleId] = 0;
			}
			else nativeTitleId = null;

			var native_vertical = vertical ? (byte)1 : (byte)0;
			var native_interactable = interactable ? (byte)1 : (byte)0;
			ImPlotNative.ShowAltLegend(nativeTitleId, native_vertical, size, native_interactable);
			// Freeing titleId native string
			if (byteCountTitleId > Utils.MaxStackallocSize)
				Utils.Free(nativeTitleId);
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

		public static void ShowAltLegend(ReadOnlySpan<char> titleId, bool vertical, Vector2 size)
		{
			// defining omitted parameters
			byte interactable = 1;
			// Marshaling titleId to native string
			byte* nativeTitleId;
			var byteCountTitleId = 0;
			if (titleId != null && !titleId.IsEmpty)
			{
				byteCountTitleId = Encoding.UTF8.GetByteCount(titleId);
				if(byteCountTitleId > Utils.MaxStackallocSize)
				{
					nativeTitleId = Utils.Alloc<byte>(byteCountTitleId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTitleId + 1];
					nativeTitleId = stackallocBytes;
				}
				var offsetTitleId = Utils.EncodeStringUTF8(titleId, nativeTitleId, byteCountTitleId);
				nativeTitleId[offsetTitleId] = 0;
			}
			else nativeTitleId = null;

			var native_vertical = vertical ? (byte)1 : (byte)0;
			ImPlotNative.ShowAltLegend(nativeTitleId, native_vertical, size, interactable);
			// Freeing titleId native string
			if (byteCountTitleId > Utils.MaxStackallocSize)
				Utils.Free(nativeTitleId);
		}

		public static void ShowAltLegend(ReadOnlySpan<byte> titleId, bool vertical)
		{
			// defining omitted parameters
			byte interactable = 1;
			Vector2 size = new Vector2(0,0);
			var native_vertical = vertical ? (byte)1 : (byte)0;
			fixed (byte* nativeTitleId = titleId)
			{
				ImPlotNative.ShowAltLegend(nativeTitleId, native_vertical, size, interactable);
			}
		}

		public static void ShowAltLegend(ReadOnlySpan<char> titleId, bool vertical)
		{
			// defining omitted parameters
			byte interactable = 1;
			Vector2 size = new Vector2(0,0);
			// Marshaling titleId to native string
			byte* nativeTitleId;
			var byteCountTitleId = 0;
			if (titleId != null && !titleId.IsEmpty)
			{
				byteCountTitleId = Encoding.UTF8.GetByteCount(titleId);
				if(byteCountTitleId > Utils.MaxStackallocSize)
				{
					nativeTitleId = Utils.Alloc<byte>(byteCountTitleId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTitleId + 1];
					nativeTitleId = stackallocBytes;
				}
				var offsetTitleId = Utils.EncodeStringUTF8(titleId, nativeTitleId, byteCountTitleId);
				nativeTitleId[offsetTitleId] = 0;
			}
			else nativeTitleId = null;

			var native_vertical = vertical ? (byte)1 : (byte)0;
			ImPlotNative.ShowAltLegend(nativeTitleId, native_vertical, size, interactable);
			// Freeing titleId native string
			if (byteCountTitleId > Utils.MaxStackallocSize)
				Utils.Free(nativeTitleId);
		}

		public static void ShowAltLegend(ReadOnlySpan<byte> titleId)
		{
			// defining omitted parameters
			byte interactable = 1;
			Vector2 size = new Vector2(0,0);
			byte vertical = 1;
			fixed (byte* nativeTitleId = titleId)
			{
				ImPlotNative.ShowAltLegend(nativeTitleId, vertical, size, interactable);
			}
		}

		public static void ShowAltLegend(ReadOnlySpan<char> titleId)
		{
			// defining omitted parameters
			byte interactable = 1;
			Vector2 size = new Vector2(0,0);
			byte vertical = 1;
			// Marshaling titleId to native string
			byte* nativeTitleId;
			var byteCountTitleId = 0;
			if (titleId != null && !titleId.IsEmpty)
			{
				byteCountTitleId = Encoding.UTF8.GetByteCount(titleId);
				if(byteCountTitleId > Utils.MaxStackallocSize)
				{
					nativeTitleId = Utils.Alloc<byte>(byteCountTitleId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTitleId + 1];
					nativeTitleId = stackallocBytes;
				}
				var offsetTitleId = Utils.EncodeStringUTF8(titleId, nativeTitleId, byteCountTitleId);
				nativeTitleId[offsetTitleId] = 0;
			}
			else nativeTitleId = null;

			ImPlotNative.ShowAltLegend(nativeTitleId, vertical, size, interactable);
			// Freeing titleId native string
			if (byteCountTitleId > Utils.MaxStackallocSize)
				Utils.Free(nativeTitleId);
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

		public static bool IsColorAutoVec4(Vector4 col)
		{
			var result = ImPlotNative.IsColorAutoVec4(col);
			return result != 0;
		}

		public static bool IsColorAutoPlotCol(ImPlotCol idx)
		{
			var result = ImPlotNative.IsColorAutoPlotCol(idx);
			return result != 0;
		}

		public static void AddTextVertical(ImDrawListPtr drawList, Vector2 pos, uint col, ReadOnlySpan<char> textBegin, ReadOnlySpan<char> textEnd)
		{
			// Marshaling textBegin to native string
			byte* nativeTextBegin;
			var byteCountTextBegin = 0;
			if (textBegin != null && !textBegin.IsEmpty)
			{
				byteCountTextBegin = Encoding.UTF8.GetByteCount(textBegin);
				if(byteCountTextBegin > Utils.MaxStackallocSize)
				{
					nativeTextBegin = Utils.Alloc<byte>(byteCountTextBegin + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTextBegin + 1];
					nativeTextBegin = stackallocBytes;
				}
				var offsetTextBegin = Utils.EncodeStringUTF8(textBegin, nativeTextBegin, byteCountTextBegin);
				nativeTextBegin[offsetTextBegin] = 0;
			}
			else nativeTextBegin = null;

			// Marshaling textEnd to native string
			byte* nativeTextEnd;
			var byteCountTextEnd = 0;
			if (textEnd != null && !textEnd.IsEmpty)
			{
				byteCountTextEnd = Encoding.UTF8.GetByteCount(textEnd);
				if(byteCountTextEnd > Utils.MaxStackallocSize)
				{
					nativeTextEnd = Utils.Alloc<byte>(byteCountTextEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTextEnd + 1];
					nativeTextEnd = stackallocBytes;
				}
				var offsetTextEnd = Utils.EncodeStringUTF8(textEnd, nativeTextEnd, byteCountTextEnd);
				nativeTextEnd[offsetTextEnd] = 0;
			}
			else nativeTextEnd = null;

			ImPlotNative.AddTextVertical(drawList, pos, col, nativeTextBegin, nativeTextEnd);
			// Freeing textBegin native string
			if (byteCountTextBegin > Utils.MaxStackallocSize)
				Utils.Free(nativeTextBegin);
			// Freeing textEnd native string
			if (byteCountTextEnd > Utils.MaxStackallocSize)
				Utils.Free(nativeTextEnd);
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

		public static void AddTextVertical(ImDrawListPtr drawList, Vector2 pos, uint col, ReadOnlySpan<char> textBegin)
		{
			// defining omitted parameters
			byte* textEnd = null;
			// Marshaling textBegin to native string
			byte* nativeTextBegin;
			var byteCountTextBegin = 0;
			if (textBegin != null && !textBegin.IsEmpty)
			{
				byteCountTextBegin = Encoding.UTF8.GetByteCount(textBegin);
				if(byteCountTextBegin > Utils.MaxStackallocSize)
				{
					nativeTextBegin = Utils.Alloc<byte>(byteCountTextBegin + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTextBegin + 1];
					nativeTextBegin = stackallocBytes;
				}
				var offsetTextBegin = Utils.EncodeStringUTF8(textBegin, nativeTextBegin, byteCountTextBegin);
				nativeTextBegin[offsetTextBegin] = 0;
			}
			else nativeTextBegin = null;

			ImPlotNative.AddTextVertical(drawList, pos, col, nativeTextBegin, textEnd);
			// Freeing textBegin native string
			if (byteCountTextBegin > Utils.MaxStackallocSize)
				Utils.Free(nativeTextBegin);
		}

		public static void AddTextCentered(ImDrawListPtr drawList, Vector2 topCenter, uint col, ReadOnlySpan<char> textBegin, ReadOnlySpan<char> textEnd)
		{
			// Marshaling textBegin to native string
			byte* nativeTextBegin;
			var byteCountTextBegin = 0;
			if (textBegin != null && !textBegin.IsEmpty)
			{
				byteCountTextBegin = Encoding.UTF8.GetByteCount(textBegin);
				if(byteCountTextBegin > Utils.MaxStackallocSize)
				{
					nativeTextBegin = Utils.Alloc<byte>(byteCountTextBegin + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTextBegin + 1];
					nativeTextBegin = stackallocBytes;
				}
				var offsetTextBegin = Utils.EncodeStringUTF8(textBegin, nativeTextBegin, byteCountTextBegin);
				nativeTextBegin[offsetTextBegin] = 0;
			}
			else nativeTextBegin = null;

			// Marshaling textEnd to native string
			byte* nativeTextEnd;
			var byteCountTextEnd = 0;
			if (textEnd != null && !textEnd.IsEmpty)
			{
				byteCountTextEnd = Encoding.UTF8.GetByteCount(textEnd);
				if(byteCountTextEnd > Utils.MaxStackallocSize)
				{
					nativeTextEnd = Utils.Alloc<byte>(byteCountTextEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTextEnd + 1];
					nativeTextEnd = stackallocBytes;
				}
				var offsetTextEnd = Utils.EncodeStringUTF8(textEnd, nativeTextEnd, byteCountTextEnd);
				nativeTextEnd[offsetTextEnd] = 0;
			}
			else nativeTextEnd = null;

			ImPlotNative.AddTextCentered(drawList, topCenter, col, nativeTextBegin, nativeTextEnd);
			// Freeing textBegin native string
			if (byteCountTextBegin > Utils.MaxStackallocSize)
				Utils.Free(nativeTextBegin);
			// Freeing textEnd native string
			if (byteCountTextEnd > Utils.MaxStackallocSize)
				Utils.Free(nativeTextEnd);
		}

		public static void AddTextCentered(ImDrawListPtr drawList, Vector2 topCenter, uint col, ReadOnlySpan<byte> textBegin)
		{
			// defining omitted parameters
			byte* textEnd = null;
			fixed (byte* nativeTextBegin = textBegin)
			{
				ImPlotNative.AddTextCentered(drawList, topCenter, col, nativeTextBegin, textEnd);
			}
		}

		public static void AddTextCentered(ImDrawListPtr drawList, Vector2 topCenter, uint col, ReadOnlySpan<char> textBegin)
		{
			// defining omitted parameters
			byte* textEnd = null;
			// Marshaling textBegin to native string
			byte* nativeTextBegin;
			var byteCountTextBegin = 0;
			if (textBegin != null && !textBegin.IsEmpty)
			{
				byteCountTextBegin = Encoding.UTF8.GetByteCount(textBegin);
				if(byteCountTextBegin > Utils.MaxStackallocSize)
				{
					nativeTextBegin = Utils.Alloc<byte>(byteCountTextBegin + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTextBegin + 1];
					nativeTextBegin = stackallocBytes;
				}
				var offsetTextBegin = Utils.EncodeStringUTF8(textBegin, nativeTextBegin, byteCountTextBegin);
				nativeTextBegin[offsetTextBegin] = 0;
			}
			else nativeTextBegin = null;

			ImPlotNative.AddTextCentered(drawList, topCenter, col, nativeTextBegin, textEnd);
			// Freeing textBegin native string
			if (byteCountTextBegin > Utils.MaxStackallocSize)
				Utils.Free(nativeTextBegin);
		}

		public static void CalcTextSizeVertical(out Vector2 pOut, ReadOnlySpan<char> text)
		{
			// Marshaling text to native string
			byte* nativeText;
			var byteCountText = 0;
			if (text != null && !text.IsEmpty)
			{
				byteCountText = Encoding.UTF8.GetByteCount(text);
				if(byteCountText > Utils.MaxStackallocSize)
				{
					nativeText = Utils.Alloc<byte>(byteCountText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountText + 1];
					nativeText = stackallocBytes;
				}
				var offsetText = Utils.EncodeStringUTF8(text, nativeText, byteCountText);
				nativeText[offsetText] = 0;
			}
			else nativeText = null;

			fixed (Vector2* nativePOut = &pOut)
			{
				ImPlotNative.CalcTextSizeVertical(nativePOut, nativeText);
				// Freeing text native string
				if (byteCountText > Utils.MaxStackallocSize)
					Utils.Free(nativeText);
			}
		}

		public static uint CalcTextColorVec4(Vector4 bg)
		{
			return ImPlotNative.CalcTextColorVec4(bg);
		}

		public static uint CalcTextColorU32(uint bg)
		{
			return ImPlotNative.CalcTextColorU32(bg);
		}

		public static void FillRangeVectorFloatPtr(ref ImVector<float> buffer, int n, float vmin, float vmax)
		{
			fixed (ImVector<float>* nativeBuffer = &buffer)
			{
				ImPlotNative.FillRangeVectorFloatPtr(nativeBuffer, n, vmin, vmax);
			}
		}

		public static void FillRangeVectorDoublePtr(ref ImVector<double> buffer, int n, double vmin, double vmax)
		{
			fixed (ImVector<double>* nativeBuffer = &buffer)
			{
				ImPlotNative.FillRangeVectorDoublePtr(nativeBuffer, n, vmin, vmax);
			}
		}

		public static void FillRangeVectorS8Ptr(ref ImVector<sbyte> buffer, int n, sbyte vmin, sbyte vmax)
		{
			fixed (ImVector<sbyte>* nativeBuffer = &buffer)
			{
				ImPlotNative.FillRangeVectorS8Ptr(nativeBuffer, n, vmin, vmax);
			}
		}

		public static void FillRangeVectorU8Ptr(ref ImVector<byte> buffer, int n, bool vmin, bool vmax)
		{
			var native_vmin = vmin ? (byte)1 : (byte)0;
			var native_vmax = vmax ? (byte)1 : (byte)0;
			fixed (ImVector<byte>* nativeBuffer = &buffer)
			{
				ImPlotNative.FillRangeVectorU8Ptr(nativeBuffer, n, native_vmin, native_vmax);
			}
		}

		public static void FillRangeVectorS16Ptr(ref ImVector<short> buffer, int n, short vmin, short vmax)
		{
			fixed (ImVector<short>* nativeBuffer = &buffer)
			{
				ImPlotNative.FillRangeVectorS16Ptr(nativeBuffer, n, vmin, vmax);
			}
		}

		public static void FillRangeVectorU16Ptr(ref ImVector<ushort> buffer, int n, ushort vmin, ushort vmax)
		{
			fixed (ImVector<ushort>* nativeBuffer = &buffer)
			{
				ImPlotNative.FillRangeVectorU16Ptr(nativeBuffer, n, vmin, vmax);
			}
		}

		public static void FillRangeVectorS32Ptr(ref ImVector<int> buffer, int n, int vmin, int vmax)
		{
			fixed (ImVector<int>* nativeBuffer = &buffer)
			{
				ImPlotNative.FillRangeVectorS32Ptr(nativeBuffer, n, vmin, vmax);
			}
		}

		public static void FillRangeVectorU32Ptr(ref ImVector<uint> buffer, int n, uint vmin, uint vmax)
		{
			fixed (ImVector<uint>* nativeBuffer = &buffer)
			{
				ImPlotNative.FillRangeVectorU32Ptr(nativeBuffer, n, vmin, vmax);
			}
		}

		public static void FillRangeVectorS64Ptr(ref ImVector<long> buffer, int n, long vmin, long vmax)
		{
			fixed (ImVector<long>* nativeBuffer = &buffer)
			{
				ImPlotNative.FillRangeVectorS64Ptr(nativeBuffer, n, vmin, vmax);
			}
		}

		public static void FillRangeVectorU64Ptr(ref ImVector<ulong> buffer, int n, ulong vmin, ulong vmax)
		{
			fixed (ImVector<ulong>* nativeBuffer = &buffer)
			{
				ImPlotNative.FillRangeVectorU64Ptr(nativeBuffer, n, vmin, vmax);
			}
		}

		public static void CalculateBinsFloatPtr(float[] values, int count, ImPlotBin meth, ImPlotRange range, out int binsOut, out double widthOut)
		{
			fixed (float* nativeValues = values)
			fixed (int* nativeBinsOut = &binsOut)
			fixed (double* nativeWidthOut = &widthOut)
			{
				ImPlotNative.CalculateBinsFloatPtr(nativeValues, count, meth, range, nativeBinsOut, nativeWidthOut);
			}
		}

		public static void CalculateBinsDoublePtr(double[] values, int count, ImPlotBin meth, ImPlotRange range, out int binsOut, out double widthOut)
		{
			fixed (double* nativeValues = values)
			fixed (int* nativeBinsOut = &binsOut)
			fixed (double* nativeWidthOut = &widthOut)
			{
				ImPlotNative.CalculateBinsDoublePtr(nativeValues, count, meth, range, nativeBinsOut, nativeWidthOut);
			}
		}

		public static void CalculateBinsS8Ptr(sbyte[] values, int count, ImPlotBin meth, ImPlotRange range, out int binsOut, out double widthOut)
		{
			fixed (sbyte* nativeValues = values)
			fixed (int* nativeBinsOut = &binsOut)
			fixed (double* nativeWidthOut = &widthOut)
			{
				ImPlotNative.CalculateBinsS8Ptr(nativeValues, count, meth, range, nativeBinsOut, nativeWidthOut);
			}
		}

		public static void CalculateBinsU8Ptr(byte[] values, int count, ImPlotBin meth, ImPlotRange range, out int binsOut, out double widthOut)
		{
			fixed (byte* nativeValues = values)
			fixed (int* nativeBinsOut = &binsOut)
			fixed (double* nativeWidthOut = &widthOut)
			{
				ImPlotNative.CalculateBinsU8Ptr(nativeValues, count, meth, range, nativeBinsOut, nativeWidthOut);
			}
		}

		public static void CalculateBinsS16Ptr(short[] values, int count, ImPlotBin meth, ImPlotRange range, out int binsOut, out double widthOut)
		{
			fixed (short* nativeValues = values)
			fixed (int* nativeBinsOut = &binsOut)
			fixed (double* nativeWidthOut = &widthOut)
			{
				ImPlotNative.CalculateBinsS16Ptr(nativeValues, count, meth, range, nativeBinsOut, nativeWidthOut);
			}
		}

		public static void CalculateBinsU16Ptr(ushort[] values, int count, ImPlotBin meth, ImPlotRange range, out int binsOut, out double widthOut)
		{
			fixed (ushort* nativeValues = values)
			fixed (int* nativeBinsOut = &binsOut)
			fixed (double* nativeWidthOut = &widthOut)
			{
				ImPlotNative.CalculateBinsU16Ptr(nativeValues, count, meth, range, nativeBinsOut, nativeWidthOut);
			}
		}

		public static void CalculateBinsS32Ptr(int[] values, int count, ImPlotBin meth, ImPlotRange range, out int binsOut, out double widthOut)
		{
			fixed (int* nativeValues = values)
			fixed (int* nativeBinsOut = &binsOut)
			fixed (double* nativeWidthOut = &widthOut)
			{
				ImPlotNative.CalculateBinsS32Ptr(nativeValues, count, meth, range, nativeBinsOut, nativeWidthOut);
			}
		}

		public static void CalculateBinsU32Ptr(uint[] values, int count, ImPlotBin meth, ImPlotRange range, out int binsOut, out double widthOut)
		{
			fixed (uint* nativeValues = values)
			fixed (int* nativeBinsOut = &binsOut)
			fixed (double* nativeWidthOut = &widthOut)
			{
				ImPlotNative.CalculateBinsU32Ptr(nativeValues, count, meth, range, nativeBinsOut, nativeWidthOut);
			}
		}

		public static void CalculateBinsS64Ptr(long[] values, int count, ImPlotBin meth, ImPlotRange range, out int binsOut, out double widthOut)
		{
			fixed (long* nativeValues = values)
			fixed (int* nativeBinsOut = &binsOut)
			fixed (double* nativeWidthOut = &widthOut)
			{
				ImPlotNative.CalculateBinsS64Ptr(nativeValues, count, meth, range, nativeBinsOut, nativeWidthOut);
			}
		}

		public static void CalculateBinsU64Ptr(ulong[] values, int count, ImPlotBin meth, ImPlotRange range, out int binsOut, out double widthOut)
		{
			fixed (ulong* nativeValues = values)
			fixed (int* nativeBinsOut = &binsOut)
			fixed (double* nativeWidthOut = &widthOut)
			{
				ImPlotNative.CalculateBinsU64Ptr(nativeValues, count, meth, range, nativeBinsOut, nativeWidthOut);
			}
		}

		public static void MakeTime(ImPlotTimePtr pOut, int year, int month, int day, int hour, int min, int sec)
		{
			// defining omitted parameters
			int us = 0;
			ImPlotNative.MakeTime(pOut, year, month, day, hour, min, sec, us);
		}

		public static void MakeTime(ImPlotTimePtr pOut, int year, int month, int day, int hour, int min)
		{
			// defining omitted parameters
			int us = 0;
			int sec = 0;
			ImPlotNative.MakeTime(pOut, year, month, day, hour, min, sec, us);
		}

		public static void MakeTime(ImPlotTimePtr pOut, int year, int month, int day, int hour)
		{
			// defining omitted parameters
			int us = 0;
			int sec = 0;
			int min = 0;
			ImPlotNative.MakeTime(pOut, year, month, day, hour, min, sec, us);
		}

		public static void MakeTime(ImPlotTimePtr pOut, int year, int month, int day)
		{
			// defining omitted parameters
			int us = 0;
			int sec = 0;
			int min = 0;
			int hour = 0;
			ImPlotNative.MakeTime(pOut, year, month, day, hour, min, sec, us);
		}

		public static void MakeTime(ImPlotTimePtr pOut, int year, int month)
		{
			// defining omitted parameters
			int us = 0;
			int sec = 0;
			int min = 0;
			int hour = 0;
			int day = 1;
			ImPlotNative.MakeTime(pOut, year, month, day, hour, min, sec, us);
		}

		public static void MakeTime(ImPlotTimePtr pOut, int year)
		{
			// defining omitted parameters
			int us = 0;
			int sec = 0;
			int min = 0;
			int hour = 0;
			int day = 1;
			int month = 0;
			ImPlotNative.MakeTime(pOut, year, month, day, hour, min, sec, us);
		}

		public static bool ShowDatePicker(ReadOnlySpan<char> id, ref int level, ImPlotTimePtr t, ImPlotTimePtr t1, ImPlotTimePtr t2)
		{
			// Marshaling id to native string
			byte* nativeId;
			var byteCountId = 0;
			if (id != null && !id.IsEmpty)
			{
				byteCountId = Encoding.UTF8.GetByteCount(id);
				if(byteCountId > Utils.MaxStackallocSize)
				{
					nativeId = Utils.Alloc<byte>(byteCountId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountId + 1];
					nativeId = stackallocBytes;
				}
				var offsetId = Utils.EncodeStringUTF8(id, nativeId, byteCountId);
				nativeId[offsetId] = 0;
			}
			else nativeId = null;

			fixed (int* nativeLevel = &level)
			{
				var result = ImPlotNative.ShowDatePicker(nativeId, nativeLevel, t, t1, t2);
				// Freeing id native string
				if (byteCountId > Utils.MaxStackallocSize)
					Utils.Free(nativeId);
				return result != 0;
			}
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

		public static bool ShowDatePicker(ReadOnlySpan<char> id, ref int level, ImPlotTimePtr t, ImPlotTimePtr t1)
		{
			// defining omitted parameters
			ImPlotTime* t2 = null;
			// Marshaling id to native string
			byte* nativeId;
			var byteCountId = 0;
			if (id != null && !id.IsEmpty)
			{
				byteCountId = Encoding.UTF8.GetByteCount(id);
				if(byteCountId > Utils.MaxStackallocSize)
				{
					nativeId = Utils.Alloc<byte>(byteCountId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountId + 1];
					nativeId = stackallocBytes;
				}
				var offsetId = Utils.EncodeStringUTF8(id, nativeId, byteCountId);
				nativeId[offsetId] = 0;
			}
			else nativeId = null;

			fixed (int* nativeLevel = &level)
			{
				var result = ImPlotNative.ShowDatePicker(nativeId, nativeLevel, t, t1, t2);
				// Freeing id native string
				if (byteCountId > Utils.MaxStackallocSize)
					Utils.Free(nativeId);
				return result != 0;
			}
		}

		public static bool ShowDatePicker(ReadOnlySpan<byte> id, ref int level, ImPlotTimePtr t)
		{
			// defining omitted parameters
			ImPlotTime* t2 = null;
			ImPlotTime* t1 = null;
			fixed (byte* nativeId = id)
			fixed (int* nativeLevel = &level)
			{
				var result = ImPlotNative.ShowDatePicker(nativeId, nativeLevel, t, t1, t2);
				return result != 0;
			}
		}

		public static bool ShowDatePicker(ReadOnlySpan<char> id, ref int level, ImPlotTimePtr t)
		{
			// defining omitted parameters
			ImPlotTime* t2 = null;
			ImPlotTime* t1 = null;
			// Marshaling id to native string
			byte* nativeId;
			var byteCountId = 0;
			if (id != null && !id.IsEmpty)
			{
				byteCountId = Encoding.UTF8.GetByteCount(id);
				if(byteCountId > Utils.MaxStackallocSize)
				{
					nativeId = Utils.Alloc<byte>(byteCountId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountId + 1];
					nativeId = stackallocBytes;
				}
				var offsetId = Utils.EncodeStringUTF8(id, nativeId, byteCountId);
				nativeId[offsetId] = 0;
			}
			else nativeId = null;

			fixed (int* nativeLevel = &level)
			{
				var result = ImPlotNative.ShowDatePicker(nativeId, nativeLevel, t, t1, t2);
				// Freeing id native string
				if (byteCountId > Utils.MaxStackallocSize)
					Utils.Free(nativeId);
				return result != 0;
			}
		}

		public static bool ShowTimePicker(ReadOnlySpan<char> id, ImPlotTimePtr t)
		{
			// Marshaling id to native string
			byte* nativeId;
			var byteCountId = 0;
			if (id != null && !id.IsEmpty)
			{
				byteCountId = Encoding.UTF8.GetByteCount(id);
				if(byteCountId > Utils.MaxStackallocSize)
				{
					nativeId = Utils.Alloc<byte>(byteCountId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountId + 1];
					nativeId = stackallocBytes;
				}
				var offsetId = Utils.EncodeStringUTF8(id, nativeId, byteCountId);
				nativeId[offsetId] = 0;
			}
			else nativeId = null;

			var result = ImPlotNative.ShowTimePicker(nativeId, t);
			// Freeing id native string
			if (byteCountId > Utils.MaxStackallocSize)
				Utils.Free(nativeId);
			return result != 0;
		}

	}
}
