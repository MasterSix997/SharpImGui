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

		public static byte BeginPlot(ReadOnlySpan<char> titleId, Vector2 size, ImPlotFlags flags)
		{
			// Marshaling titleId to native string
			byte* native_titleId;
			var byteCount_titleId = 0;
			if (titleId != null)
			{
				byteCount_titleId = Encoding.UTF8.GetByteCount(titleId);
				if(byteCount_titleId > Utils.MaxStackallocSize)
				{
					native_titleId = Utils.Alloc<byte>(byteCount_titleId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_titleId + 1];
					native_titleId = stackallocBytes;
				}
				var titleId_offset = Utils.EncodeStringUTF8(titleId, native_titleId, byteCount_titleId);
				native_titleId[titleId_offset] = 0;
			}
			else native_titleId = null;

			return ImPlotNative.BeginPlot(native_titleId, size, flags);
			// Freeing titleId native string
			if (byteCount_titleId > Utils.MaxStackallocSize)
				Utils.Free(native_titleId);
		}

		public static void EndPlot()
		{
			ImPlotNative.EndPlot();
		}

		public static byte BeginSubplots(ReadOnlySpan<char> titleId, int rows, int cols, Vector2 size, ImPlotSubplotFlags flags, ref float rowRatios, ref float colRatios)
		{
			// Marshaling titleId to native string
			byte* native_titleId;
			var byteCount_titleId = 0;
			if (titleId != null)
			{
				byteCount_titleId = Encoding.UTF8.GetByteCount(titleId);
				if(byteCount_titleId > Utils.MaxStackallocSize)
				{
					native_titleId = Utils.Alloc<byte>(byteCount_titleId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_titleId + 1];
					native_titleId = stackallocBytes;
				}
				var titleId_offset = Utils.EncodeStringUTF8(titleId, native_titleId, byteCount_titleId);
				native_titleId[titleId_offset] = 0;
			}
			else native_titleId = null;

			fixed (float* native_rowRatios = &rowRatios)
			fixed (float* native_colRatios = &colRatios)
			{
				var result = ImPlotNative.BeginSubplots(native_titleId, rows, cols, size, flags, native_rowRatios, native_colRatios);
				// Freeing titleId native string
				if (byteCount_titleId > Utils.MaxStackallocSize)
					Utils.Free(native_titleId);
				return result;
			}
		}

		public static void EndSubplots()
		{
			ImPlotNative.EndSubplots();
		}

		public static void SetupAxis(ImAxis axis, ReadOnlySpan<char> label, ImPlotAxisFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			ImPlotNative.SetupAxis(axis, native_label, flags);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
		}

		public static void SetupAxisLimits(ImAxis axis, double vMin, double vMax, ImPlotCond cond)
		{
			ImPlotNative.SetupAxisLimits(axis, vMin, vMax, cond);
		}

		public static void SetupAxisLinks(ImAxis axis, ref double linkMin, ref double linkMax)
		{
			fixed (double* native_linkMin = &linkMin)
			fixed (double* native_linkMax = &linkMax)
			{
				ImPlotNative.SetupAxisLinks(axis, native_linkMin, native_linkMax);
			}
		}

		public static void SetupAxisFormatStr(ImAxis axis, ReadOnlySpan<char> fmt)
		{
			// Marshaling fmt to native string
			byte* native_fmt;
			var byteCount_fmt = 0;
			if (fmt != null)
			{
				byteCount_fmt = Encoding.UTF8.GetByteCount(fmt);
				if(byteCount_fmt > Utils.MaxStackallocSize)
				{
					native_fmt = Utils.Alloc<byte>(byteCount_fmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_fmt + 1];
					native_fmt = stackallocBytes;
				}
				var fmt_offset = Utils.EncodeStringUTF8(fmt, native_fmt, byteCount_fmt);
				native_fmt[fmt_offset] = 0;
			}
			else native_fmt = null;

			ImPlotNative.SetupAxisFormatStr(axis, native_fmt);
			// Freeing fmt native string
			if (byteCount_fmt > Utils.MaxStackallocSize)
				Utils.Free(native_fmt);
		}

		public static void SetupAxisFormatPlotFormatter(ImAxis axis, ImPlotFormatter formatter, IntPtr data)
		{
			ImPlotNative.SetupAxisFormatPlotFormatter(axis, formatter, (void*)data);
		}

		public static void SetupAxisTicksDoublePtr(ImAxis axis, ref double values, int nTicks, ref byte* labels, bool keepDefault)
		{
			var native_keepDefault = keepDefault ? (byte)1 : (byte)0;
			fixed (double* native_values = &values)
			fixed (byte** native_labels = &labels)
			{
				ImPlotNative.SetupAxisTicksDoublePtr(axis, native_values, nTicks, native_labels, native_keepDefault);
			}
		}

		public static void SetupAxisTicksDouble(ImAxis axis, double vMin, double vMax, int nTicks, ref byte* labels, bool keepDefault)
		{
			var native_keepDefault = keepDefault ? (byte)1 : (byte)0;
			fixed (byte** native_labels = &labels)
			{
				ImPlotNative.SetupAxisTicksDouble(axis, vMin, vMax, nTicks, native_labels, native_keepDefault);
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

		public static void SetupAxes(ReadOnlySpan<char> xLabel, ReadOnlySpan<char> yLabel, ImPlotAxisFlags xFlags, ImPlotAxisFlags yFlags)
		{
			// Marshaling xLabel to native string
			byte* native_xLabel;
			var byteCount_xLabel = 0;
			if (xLabel != null)
			{
				byteCount_xLabel = Encoding.UTF8.GetByteCount(xLabel);
				if(byteCount_xLabel > Utils.MaxStackallocSize)
				{
					native_xLabel = Utils.Alloc<byte>(byteCount_xLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_xLabel + 1];
					native_xLabel = stackallocBytes;
				}
				var xLabel_offset = Utils.EncodeStringUTF8(xLabel, native_xLabel, byteCount_xLabel);
				native_xLabel[xLabel_offset] = 0;
			}
			else native_xLabel = null;

			// Marshaling yLabel to native string
			byte* native_yLabel;
			var byteCount_yLabel = 0;
			if (yLabel != null)
			{
				byteCount_yLabel = Encoding.UTF8.GetByteCount(yLabel);
				if(byteCount_yLabel > Utils.MaxStackallocSize)
				{
					native_yLabel = Utils.Alloc<byte>(byteCount_yLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_yLabel + 1];
					native_yLabel = stackallocBytes;
				}
				var yLabel_offset = Utils.EncodeStringUTF8(yLabel, native_yLabel, byteCount_yLabel);
				native_yLabel[yLabel_offset] = 0;
			}
			else native_yLabel = null;

			ImPlotNative.SetupAxes(native_xLabel, native_yLabel, xFlags, yFlags);
			// Freeing xLabel native string
			if (byteCount_xLabel > Utils.MaxStackallocSize)
				Utils.Free(native_xLabel);
			// Freeing yLabel native string
			if (byteCount_yLabel > Utils.MaxStackallocSize)
				Utils.Free(native_yLabel);
		}

		public static void SetupAxesLimits(double xMin, double xMax, double yMin, double yMax, ImPlotCond cond)
		{
			ImPlotNative.SetupAxesLimits(xMin, xMax, yMin, yMax, cond);
		}

		public static void SetupLegend(ImPlotLocation location, ImPlotLegendFlags flags)
		{
			ImPlotNative.SetupLegend(location, flags);
		}

		public static void SetupMouseText(ImPlotLocation location, ImPlotMouseTextFlags flags)
		{
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

		public static void SetNextAxisLinks(ImAxis axis, ref double linkMin, ref double linkMax)
		{
			fixed (double* native_linkMin = &linkMin)
			fixed (double* native_linkMax = &linkMax)
			{
				ImPlotNative.SetNextAxisLinks(axis, native_linkMin, native_linkMax);
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

		public static void SetNextAxesToFit()
		{
			ImPlotNative.SetNextAxesToFit();
		}

		public static void PlotLineFloatPtrInt(ReadOnlySpan<char> labelId, ref float values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (float* native_values = &values)
			{
				ImPlotNative.PlotLineFloatPtrInt(native_labelId, native_values, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotLineDoublePtrInt(ReadOnlySpan<char> labelId, ref double values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (double* native_values = &values)
			{
				ImPlotNative.PlotLineDoublePtrInt(native_labelId, native_values, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotLineS8PtrInt(ReadOnlySpan<char> labelId, ref sbyte values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (sbyte* native_values = &values)
			{
				ImPlotNative.PlotLineS8PtrInt(native_labelId, native_values, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotLineU8PtrInt(ReadOnlySpan<char> labelId, ReadOnlySpan<char> values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			// Marshaling values to native string
			byte* native_values;
			var byteCount_values = 0;
			if (values != null)
			{
				byteCount_values = Encoding.UTF8.GetByteCount(values);
				if(byteCount_values > Utils.MaxStackallocSize)
				{
					native_values = Utils.Alloc<byte>(byteCount_values + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_values + 1];
					native_values = stackallocBytes;
				}
				var values_offset = Utils.EncodeStringUTF8(values, native_values, byteCount_values);
				native_values[values_offset] = 0;
			}
			else native_values = null;

			ImPlotNative.PlotLineU8PtrInt(native_labelId, native_values, count, xscale, xstart, flags, offset, stride);
			// Freeing labelId native string
			if (byteCount_labelId > Utils.MaxStackallocSize)
				Utils.Free(native_labelId);
			// Freeing values native string
			if (byteCount_values > Utils.MaxStackallocSize)
				Utils.Free(native_values);
		}

		public static void PlotLineS16PtrInt(ReadOnlySpan<char> labelId, ref short values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (short* native_values = &values)
			{
				ImPlotNative.PlotLineS16PtrInt(native_labelId, native_values, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotLineU16PtrInt(ReadOnlySpan<char> labelId, ref ushort values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (ushort* native_values = &values)
			{
				ImPlotNative.PlotLineU16PtrInt(native_labelId, native_values, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotLineS32PtrInt(ReadOnlySpan<char> labelId, ref int values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (int* native_values = &values)
			{
				ImPlotNative.PlotLineS32PtrInt(native_labelId, native_values, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotLineU32PtrInt(ReadOnlySpan<char> labelId, ref uint values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (uint* native_values = &values)
			{
				ImPlotNative.PlotLineU32PtrInt(native_labelId, native_values, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotLineS64PtrInt(ReadOnlySpan<char> labelId, ref long values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (long* native_values = &values)
			{
				ImPlotNative.PlotLineS64PtrInt(native_labelId, native_values, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotLineU64PtrInt(ReadOnlySpan<char> labelId, ref ulong values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (ulong* native_values = &values)
			{
				ImPlotNative.PlotLineU64PtrInt(native_labelId, native_values, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotLineFloatPtrFloatPtr(ReadOnlySpan<char> labelId, ref float xs, ref float ys, int count, ImPlotLineFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (float* native_xs = &xs)
			fixed (float* native_ys = &ys)
			{
				ImPlotNative.PlotLineFloatPtrFloatPtr(native_labelId, native_xs, native_ys, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotLineDoublePtrdoublePtr(ReadOnlySpan<char> labelId, ref double xs, ref double ys, int count, ImPlotLineFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (double* native_xs = &xs)
			fixed (double* native_ys = &ys)
			{
				ImPlotNative.PlotLineDoublePtrdoublePtr(native_labelId, native_xs, native_ys, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotLineS8PtrS8Ptr(ReadOnlySpan<char> labelId, ref sbyte xs, ref sbyte ys, int count, ImPlotLineFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (sbyte* native_xs = &xs)
			fixed (sbyte* native_ys = &ys)
			{
				ImPlotNative.PlotLineS8PtrS8Ptr(native_labelId, native_xs, native_ys, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotLineU8PtrU8Ptr(ReadOnlySpan<char> labelId, ReadOnlySpan<char> xs, ReadOnlySpan<char> ys, int count, ImPlotLineFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			// Marshaling xs to native string
			byte* native_xs;
			var byteCount_xs = 0;
			if (xs != null)
			{
				byteCount_xs = Encoding.UTF8.GetByteCount(xs);
				if(byteCount_xs > Utils.MaxStackallocSize)
				{
					native_xs = Utils.Alloc<byte>(byteCount_xs + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_xs + 1];
					native_xs = stackallocBytes;
				}
				var xs_offset = Utils.EncodeStringUTF8(xs, native_xs, byteCount_xs);
				native_xs[xs_offset] = 0;
			}
			else native_xs = null;

			// Marshaling ys to native string
			byte* native_ys;
			var byteCount_ys = 0;
			if (ys != null)
			{
				byteCount_ys = Encoding.UTF8.GetByteCount(ys);
				if(byteCount_ys > Utils.MaxStackallocSize)
				{
					native_ys = Utils.Alloc<byte>(byteCount_ys + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_ys + 1];
					native_ys = stackallocBytes;
				}
				var ys_offset = Utils.EncodeStringUTF8(ys, native_ys, byteCount_ys);
				native_ys[ys_offset] = 0;
			}
			else native_ys = null;

			ImPlotNative.PlotLineU8PtrU8Ptr(native_labelId, native_xs, native_ys, count, flags, offset, stride);
			// Freeing labelId native string
			if (byteCount_labelId > Utils.MaxStackallocSize)
				Utils.Free(native_labelId);
			// Freeing xs native string
			if (byteCount_xs > Utils.MaxStackallocSize)
				Utils.Free(native_xs);
			// Freeing ys native string
			if (byteCount_ys > Utils.MaxStackallocSize)
				Utils.Free(native_ys);
		}

		public static void PlotLineS16PtrS16Ptr(ReadOnlySpan<char> labelId, ref short xs, ref short ys, int count, ImPlotLineFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (short* native_xs = &xs)
			fixed (short* native_ys = &ys)
			{
				ImPlotNative.PlotLineS16PtrS16Ptr(native_labelId, native_xs, native_ys, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotLineU16PtrU16Ptr(ReadOnlySpan<char> labelId, ref ushort xs, ref ushort ys, int count, ImPlotLineFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (ushort* native_xs = &xs)
			fixed (ushort* native_ys = &ys)
			{
				ImPlotNative.PlotLineU16PtrU16Ptr(native_labelId, native_xs, native_ys, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotLineS32PtrS32Ptr(ReadOnlySpan<char> labelId, ref int xs, ref int ys, int count, ImPlotLineFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (int* native_xs = &xs)
			fixed (int* native_ys = &ys)
			{
				ImPlotNative.PlotLineS32PtrS32Ptr(native_labelId, native_xs, native_ys, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotLineU32PtrU32Ptr(ReadOnlySpan<char> labelId, ref uint xs, ref uint ys, int count, ImPlotLineFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (uint* native_xs = &xs)
			fixed (uint* native_ys = &ys)
			{
				ImPlotNative.PlotLineU32PtrU32Ptr(native_labelId, native_xs, native_ys, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotLineS64PtrS64Ptr(ReadOnlySpan<char> labelId, ref long xs, ref long ys, int count, ImPlotLineFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (long* native_xs = &xs)
			fixed (long* native_ys = &ys)
			{
				ImPlotNative.PlotLineS64PtrS64Ptr(native_labelId, native_xs, native_ys, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotLineU64PtrU64Ptr(ReadOnlySpan<char> labelId, ref ulong xs, ref ulong ys, int count, ImPlotLineFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (ulong* native_xs = &xs)
			fixed (ulong* native_ys = &ys)
			{
				ImPlotNative.PlotLineU64PtrU64Ptr(native_labelId, native_xs, native_ys, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotLineG(ReadOnlySpan<char> labelId, ImPlotPointGetter getter, IntPtr data, int count, ImPlotLineFlags flags)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			ImPlotNative.PlotLineG(native_labelId, getter, (void*)data, count, flags);
			// Freeing labelId native string
			if (byteCount_labelId > Utils.MaxStackallocSize)
				Utils.Free(native_labelId);
		}

		public static void PlotScatterFloatPtrInt(ReadOnlySpan<char> labelId, ref float values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (float* native_values = &values)
			{
				ImPlotNative.PlotScatterFloatPtrInt(native_labelId, native_values, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotScatterDoublePtrInt(ReadOnlySpan<char> labelId, ref double values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (double* native_values = &values)
			{
				ImPlotNative.PlotScatterDoublePtrInt(native_labelId, native_values, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotScatterS8PtrInt(ReadOnlySpan<char> labelId, ref sbyte values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (sbyte* native_values = &values)
			{
				ImPlotNative.PlotScatterS8PtrInt(native_labelId, native_values, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotScatterU8PtrInt(ReadOnlySpan<char> labelId, ReadOnlySpan<char> values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			// Marshaling values to native string
			byte* native_values;
			var byteCount_values = 0;
			if (values != null)
			{
				byteCount_values = Encoding.UTF8.GetByteCount(values);
				if(byteCount_values > Utils.MaxStackallocSize)
				{
					native_values = Utils.Alloc<byte>(byteCount_values + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_values + 1];
					native_values = stackallocBytes;
				}
				var values_offset = Utils.EncodeStringUTF8(values, native_values, byteCount_values);
				native_values[values_offset] = 0;
			}
			else native_values = null;

			ImPlotNative.PlotScatterU8PtrInt(native_labelId, native_values, count, xscale, xstart, flags, offset, stride);
			// Freeing labelId native string
			if (byteCount_labelId > Utils.MaxStackallocSize)
				Utils.Free(native_labelId);
			// Freeing values native string
			if (byteCount_values > Utils.MaxStackallocSize)
				Utils.Free(native_values);
		}

		public static void PlotScatterS16PtrInt(ReadOnlySpan<char> labelId, ref short values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (short* native_values = &values)
			{
				ImPlotNative.PlotScatterS16PtrInt(native_labelId, native_values, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotScatterU16PtrInt(ReadOnlySpan<char> labelId, ref ushort values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (ushort* native_values = &values)
			{
				ImPlotNative.PlotScatterU16PtrInt(native_labelId, native_values, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotScatterS32PtrInt(ReadOnlySpan<char> labelId, ref int values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (int* native_values = &values)
			{
				ImPlotNative.PlotScatterS32PtrInt(native_labelId, native_values, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotScatterU32PtrInt(ReadOnlySpan<char> labelId, ref uint values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (uint* native_values = &values)
			{
				ImPlotNative.PlotScatterU32PtrInt(native_labelId, native_values, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotScatterS64PtrInt(ReadOnlySpan<char> labelId, ref long values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (long* native_values = &values)
			{
				ImPlotNative.PlotScatterS64PtrInt(native_labelId, native_values, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotScatterU64PtrInt(ReadOnlySpan<char> labelId, ref ulong values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (ulong* native_values = &values)
			{
				ImPlotNative.PlotScatterU64PtrInt(native_labelId, native_values, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotScatterFloatPtrFloatPtr(ReadOnlySpan<char> labelId, ref float xs, ref float ys, int count, ImPlotScatterFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (float* native_xs = &xs)
			fixed (float* native_ys = &ys)
			{
				ImPlotNative.PlotScatterFloatPtrFloatPtr(native_labelId, native_xs, native_ys, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotScatterDoublePtrdoublePtr(ReadOnlySpan<char> labelId, ref double xs, ref double ys, int count, ImPlotScatterFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (double* native_xs = &xs)
			fixed (double* native_ys = &ys)
			{
				ImPlotNative.PlotScatterDoublePtrdoublePtr(native_labelId, native_xs, native_ys, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotScatterS8PtrS8Ptr(ReadOnlySpan<char> labelId, ref sbyte xs, ref sbyte ys, int count, ImPlotScatterFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (sbyte* native_xs = &xs)
			fixed (sbyte* native_ys = &ys)
			{
				ImPlotNative.PlotScatterS8PtrS8Ptr(native_labelId, native_xs, native_ys, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotScatterU8PtrU8Ptr(ReadOnlySpan<char> labelId, ReadOnlySpan<char> xs, ReadOnlySpan<char> ys, int count, ImPlotScatterFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			// Marshaling xs to native string
			byte* native_xs;
			var byteCount_xs = 0;
			if (xs != null)
			{
				byteCount_xs = Encoding.UTF8.GetByteCount(xs);
				if(byteCount_xs > Utils.MaxStackallocSize)
				{
					native_xs = Utils.Alloc<byte>(byteCount_xs + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_xs + 1];
					native_xs = stackallocBytes;
				}
				var xs_offset = Utils.EncodeStringUTF8(xs, native_xs, byteCount_xs);
				native_xs[xs_offset] = 0;
			}
			else native_xs = null;

			// Marshaling ys to native string
			byte* native_ys;
			var byteCount_ys = 0;
			if (ys != null)
			{
				byteCount_ys = Encoding.UTF8.GetByteCount(ys);
				if(byteCount_ys > Utils.MaxStackallocSize)
				{
					native_ys = Utils.Alloc<byte>(byteCount_ys + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_ys + 1];
					native_ys = stackallocBytes;
				}
				var ys_offset = Utils.EncodeStringUTF8(ys, native_ys, byteCount_ys);
				native_ys[ys_offset] = 0;
			}
			else native_ys = null;

			ImPlotNative.PlotScatterU8PtrU8Ptr(native_labelId, native_xs, native_ys, count, flags, offset, stride);
			// Freeing labelId native string
			if (byteCount_labelId > Utils.MaxStackallocSize)
				Utils.Free(native_labelId);
			// Freeing xs native string
			if (byteCount_xs > Utils.MaxStackallocSize)
				Utils.Free(native_xs);
			// Freeing ys native string
			if (byteCount_ys > Utils.MaxStackallocSize)
				Utils.Free(native_ys);
		}

		public static void PlotScatterS16PtrS16Ptr(ReadOnlySpan<char> labelId, ref short xs, ref short ys, int count, ImPlotScatterFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (short* native_xs = &xs)
			fixed (short* native_ys = &ys)
			{
				ImPlotNative.PlotScatterS16PtrS16Ptr(native_labelId, native_xs, native_ys, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotScatterU16PtrU16Ptr(ReadOnlySpan<char> labelId, ref ushort xs, ref ushort ys, int count, ImPlotScatterFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (ushort* native_xs = &xs)
			fixed (ushort* native_ys = &ys)
			{
				ImPlotNative.PlotScatterU16PtrU16Ptr(native_labelId, native_xs, native_ys, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotScatterS32PtrS32Ptr(ReadOnlySpan<char> labelId, ref int xs, ref int ys, int count, ImPlotScatterFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (int* native_xs = &xs)
			fixed (int* native_ys = &ys)
			{
				ImPlotNative.PlotScatterS32PtrS32Ptr(native_labelId, native_xs, native_ys, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotScatterU32PtrU32Ptr(ReadOnlySpan<char> labelId, ref uint xs, ref uint ys, int count, ImPlotScatterFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (uint* native_xs = &xs)
			fixed (uint* native_ys = &ys)
			{
				ImPlotNative.PlotScatterU32PtrU32Ptr(native_labelId, native_xs, native_ys, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotScatterS64PtrS64Ptr(ReadOnlySpan<char> labelId, ref long xs, ref long ys, int count, ImPlotScatterFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (long* native_xs = &xs)
			fixed (long* native_ys = &ys)
			{
				ImPlotNative.PlotScatterS64PtrS64Ptr(native_labelId, native_xs, native_ys, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotScatterU64PtrU64Ptr(ReadOnlySpan<char> labelId, ref ulong xs, ref ulong ys, int count, ImPlotScatterFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (ulong* native_xs = &xs)
			fixed (ulong* native_ys = &ys)
			{
				ImPlotNative.PlotScatterU64PtrU64Ptr(native_labelId, native_xs, native_ys, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotScatterG(ReadOnlySpan<char> labelId, ImPlotPointGetter getter, IntPtr data, int count, ImPlotScatterFlags flags)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			ImPlotNative.PlotScatterG(native_labelId, getter, (void*)data, count, flags);
			// Freeing labelId native string
			if (byteCount_labelId > Utils.MaxStackallocSize)
				Utils.Free(native_labelId);
		}

		public static void PlotStairsFloatPtrInt(ReadOnlySpan<char> labelId, ref float values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (float* native_values = &values)
			{
				ImPlotNative.PlotStairsFloatPtrInt(native_labelId, native_values, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotStairsDoublePtrInt(ReadOnlySpan<char> labelId, ref double values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (double* native_values = &values)
			{
				ImPlotNative.PlotStairsDoublePtrInt(native_labelId, native_values, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotStairsS8PtrInt(ReadOnlySpan<char> labelId, ref sbyte values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (sbyte* native_values = &values)
			{
				ImPlotNative.PlotStairsS8PtrInt(native_labelId, native_values, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotStairsU8PtrInt(ReadOnlySpan<char> labelId, ReadOnlySpan<char> values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			// Marshaling values to native string
			byte* native_values;
			var byteCount_values = 0;
			if (values != null)
			{
				byteCount_values = Encoding.UTF8.GetByteCount(values);
				if(byteCount_values > Utils.MaxStackallocSize)
				{
					native_values = Utils.Alloc<byte>(byteCount_values + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_values + 1];
					native_values = stackallocBytes;
				}
				var values_offset = Utils.EncodeStringUTF8(values, native_values, byteCount_values);
				native_values[values_offset] = 0;
			}
			else native_values = null;

			ImPlotNative.PlotStairsU8PtrInt(native_labelId, native_values, count, xscale, xstart, flags, offset, stride);
			// Freeing labelId native string
			if (byteCount_labelId > Utils.MaxStackallocSize)
				Utils.Free(native_labelId);
			// Freeing values native string
			if (byteCount_values > Utils.MaxStackallocSize)
				Utils.Free(native_values);
		}

		public static void PlotStairsS16PtrInt(ReadOnlySpan<char> labelId, ref short values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (short* native_values = &values)
			{
				ImPlotNative.PlotStairsS16PtrInt(native_labelId, native_values, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotStairsU16PtrInt(ReadOnlySpan<char> labelId, ref ushort values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (ushort* native_values = &values)
			{
				ImPlotNative.PlotStairsU16PtrInt(native_labelId, native_values, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotStairsS32PtrInt(ReadOnlySpan<char> labelId, ref int values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (int* native_values = &values)
			{
				ImPlotNative.PlotStairsS32PtrInt(native_labelId, native_values, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotStairsU32PtrInt(ReadOnlySpan<char> labelId, ref uint values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (uint* native_values = &values)
			{
				ImPlotNative.PlotStairsU32PtrInt(native_labelId, native_values, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotStairsS64PtrInt(ReadOnlySpan<char> labelId, ref long values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (long* native_values = &values)
			{
				ImPlotNative.PlotStairsS64PtrInt(native_labelId, native_values, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotStairsU64PtrInt(ReadOnlySpan<char> labelId, ref ulong values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (ulong* native_values = &values)
			{
				ImPlotNative.PlotStairsU64PtrInt(native_labelId, native_values, count, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotStairsFloatPtrFloatPtr(ReadOnlySpan<char> labelId, ref float xs, ref float ys, int count, ImPlotStairsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (float* native_xs = &xs)
			fixed (float* native_ys = &ys)
			{
				ImPlotNative.PlotStairsFloatPtrFloatPtr(native_labelId, native_xs, native_ys, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotStairsDoublePtrdoublePtr(ReadOnlySpan<char> labelId, ref double xs, ref double ys, int count, ImPlotStairsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (double* native_xs = &xs)
			fixed (double* native_ys = &ys)
			{
				ImPlotNative.PlotStairsDoublePtrdoublePtr(native_labelId, native_xs, native_ys, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotStairsS8PtrS8Ptr(ReadOnlySpan<char> labelId, ref sbyte xs, ref sbyte ys, int count, ImPlotStairsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (sbyte* native_xs = &xs)
			fixed (sbyte* native_ys = &ys)
			{
				ImPlotNative.PlotStairsS8PtrS8Ptr(native_labelId, native_xs, native_ys, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotStairsU8PtrU8Ptr(ReadOnlySpan<char> labelId, ReadOnlySpan<char> xs, ReadOnlySpan<char> ys, int count, ImPlotStairsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			// Marshaling xs to native string
			byte* native_xs;
			var byteCount_xs = 0;
			if (xs != null)
			{
				byteCount_xs = Encoding.UTF8.GetByteCount(xs);
				if(byteCount_xs > Utils.MaxStackallocSize)
				{
					native_xs = Utils.Alloc<byte>(byteCount_xs + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_xs + 1];
					native_xs = stackallocBytes;
				}
				var xs_offset = Utils.EncodeStringUTF8(xs, native_xs, byteCount_xs);
				native_xs[xs_offset] = 0;
			}
			else native_xs = null;

			// Marshaling ys to native string
			byte* native_ys;
			var byteCount_ys = 0;
			if (ys != null)
			{
				byteCount_ys = Encoding.UTF8.GetByteCount(ys);
				if(byteCount_ys > Utils.MaxStackallocSize)
				{
					native_ys = Utils.Alloc<byte>(byteCount_ys + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_ys + 1];
					native_ys = stackallocBytes;
				}
				var ys_offset = Utils.EncodeStringUTF8(ys, native_ys, byteCount_ys);
				native_ys[ys_offset] = 0;
			}
			else native_ys = null;

			ImPlotNative.PlotStairsU8PtrU8Ptr(native_labelId, native_xs, native_ys, count, flags, offset, stride);
			// Freeing labelId native string
			if (byteCount_labelId > Utils.MaxStackallocSize)
				Utils.Free(native_labelId);
			// Freeing xs native string
			if (byteCount_xs > Utils.MaxStackallocSize)
				Utils.Free(native_xs);
			// Freeing ys native string
			if (byteCount_ys > Utils.MaxStackallocSize)
				Utils.Free(native_ys);
		}

		public static void PlotStairsS16PtrS16Ptr(ReadOnlySpan<char> labelId, ref short xs, ref short ys, int count, ImPlotStairsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (short* native_xs = &xs)
			fixed (short* native_ys = &ys)
			{
				ImPlotNative.PlotStairsS16PtrS16Ptr(native_labelId, native_xs, native_ys, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotStairsU16PtrU16Ptr(ReadOnlySpan<char> labelId, ref ushort xs, ref ushort ys, int count, ImPlotStairsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (ushort* native_xs = &xs)
			fixed (ushort* native_ys = &ys)
			{
				ImPlotNative.PlotStairsU16PtrU16Ptr(native_labelId, native_xs, native_ys, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotStairsS32PtrS32Ptr(ReadOnlySpan<char> labelId, ref int xs, ref int ys, int count, ImPlotStairsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (int* native_xs = &xs)
			fixed (int* native_ys = &ys)
			{
				ImPlotNative.PlotStairsS32PtrS32Ptr(native_labelId, native_xs, native_ys, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotStairsU32PtrU32Ptr(ReadOnlySpan<char> labelId, ref uint xs, ref uint ys, int count, ImPlotStairsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (uint* native_xs = &xs)
			fixed (uint* native_ys = &ys)
			{
				ImPlotNative.PlotStairsU32PtrU32Ptr(native_labelId, native_xs, native_ys, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotStairsS64PtrS64Ptr(ReadOnlySpan<char> labelId, ref long xs, ref long ys, int count, ImPlotStairsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (long* native_xs = &xs)
			fixed (long* native_ys = &ys)
			{
				ImPlotNative.PlotStairsS64PtrS64Ptr(native_labelId, native_xs, native_ys, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotStairsU64PtrU64Ptr(ReadOnlySpan<char> labelId, ref ulong xs, ref ulong ys, int count, ImPlotStairsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (ulong* native_xs = &xs)
			fixed (ulong* native_ys = &ys)
			{
				ImPlotNative.PlotStairsU64PtrU64Ptr(native_labelId, native_xs, native_ys, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotStairsG(ReadOnlySpan<char> labelId, ImPlotPointGetter getter, IntPtr data, int count, ImPlotStairsFlags flags)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			ImPlotNative.PlotStairsG(native_labelId, getter, (void*)data, count, flags);
			// Freeing labelId native string
			if (byteCount_labelId > Utils.MaxStackallocSize)
				Utils.Free(native_labelId);
		}

		public static void PlotShadedFloatPtrInt(ReadOnlySpan<char> labelId, ref float values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (float* native_values = &values)
			{
				ImPlotNative.PlotShadedFloatPtrInt(native_labelId, native_values, count, yref, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotShadedDoublePtrInt(ReadOnlySpan<char> labelId, ref double values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (double* native_values = &values)
			{
				ImPlotNative.PlotShadedDoublePtrInt(native_labelId, native_values, count, yref, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotShadedS8PtrInt(ReadOnlySpan<char> labelId, ref sbyte values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (sbyte* native_values = &values)
			{
				ImPlotNative.PlotShadedS8PtrInt(native_labelId, native_values, count, yref, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotShadedU8PtrInt(ReadOnlySpan<char> labelId, ReadOnlySpan<char> values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			// Marshaling values to native string
			byte* native_values;
			var byteCount_values = 0;
			if (values != null)
			{
				byteCount_values = Encoding.UTF8.GetByteCount(values);
				if(byteCount_values > Utils.MaxStackallocSize)
				{
					native_values = Utils.Alloc<byte>(byteCount_values + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_values + 1];
					native_values = stackallocBytes;
				}
				var values_offset = Utils.EncodeStringUTF8(values, native_values, byteCount_values);
				native_values[values_offset] = 0;
			}
			else native_values = null;

			ImPlotNative.PlotShadedU8PtrInt(native_labelId, native_values, count, yref, xscale, xstart, flags, offset, stride);
			// Freeing labelId native string
			if (byteCount_labelId > Utils.MaxStackallocSize)
				Utils.Free(native_labelId);
			// Freeing values native string
			if (byteCount_values > Utils.MaxStackallocSize)
				Utils.Free(native_values);
		}

		public static void PlotShadedS16PtrInt(ReadOnlySpan<char> labelId, ref short values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (short* native_values = &values)
			{
				ImPlotNative.PlotShadedS16PtrInt(native_labelId, native_values, count, yref, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotShadedU16PtrInt(ReadOnlySpan<char> labelId, ref ushort values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (ushort* native_values = &values)
			{
				ImPlotNative.PlotShadedU16PtrInt(native_labelId, native_values, count, yref, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotShadedS32PtrInt(ReadOnlySpan<char> labelId, ref int values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (int* native_values = &values)
			{
				ImPlotNative.PlotShadedS32PtrInt(native_labelId, native_values, count, yref, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotShadedU32PtrInt(ReadOnlySpan<char> labelId, ref uint values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (uint* native_values = &values)
			{
				ImPlotNative.PlotShadedU32PtrInt(native_labelId, native_values, count, yref, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotShadedS64PtrInt(ReadOnlySpan<char> labelId, ref long values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (long* native_values = &values)
			{
				ImPlotNative.PlotShadedS64PtrInt(native_labelId, native_values, count, yref, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotShadedU64PtrInt(ReadOnlySpan<char> labelId, ref ulong values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (ulong* native_values = &values)
			{
				ImPlotNative.PlotShadedU64PtrInt(native_labelId, native_values, count, yref, xscale, xstart, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotShadedFloatPtrFloatPtrInt(ReadOnlySpan<char> labelId, ref float xs, ref float ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (float* native_xs = &xs)
			fixed (float* native_ys = &ys)
			{
				ImPlotNative.PlotShadedFloatPtrFloatPtrInt(native_labelId, native_xs, native_ys, count, yref, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotShadedDoublePtrdoublePtrInt(ReadOnlySpan<char> labelId, ref double xs, ref double ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (double* native_xs = &xs)
			fixed (double* native_ys = &ys)
			{
				ImPlotNative.PlotShadedDoublePtrdoublePtrInt(native_labelId, native_xs, native_ys, count, yref, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotShadedS8PtrS8PtrInt(ReadOnlySpan<char> labelId, ref sbyte xs, ref sbyte ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (sbyte* native_xs = &xs)
			fixed (sbyte* native_ys = &ys)
			{
				ImPlotNative.PlotShadedS8PtrS8PtrInt(native_labelId, native_xs, native_ys, count, yref, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotShadedU8PtrU8PtrInt(ReadOnlySpan<char> labelId, ReadOnlySpan<char> xs, ReadOnlySpan<char> ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			// Marshaling xs to native string
			byte* native_xs;
			var byteCount_xs = 0;
			if (xs != null)
			{
				byteCount_xs = Encoding.UTF8.GetByteCount(xs);
				if(byteCount_xs > Utils.MaxStackallocSize)
				{
					native_xs = Utils.Alloc<byte>(byteCount_xs + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_xs + 1];
					native_xs = stackallocBytes;
				}
				var xs_offset = Utils.EncodeStringUTF8(xs, native_xs, byteCount_xs);
				native_xs[xs_offset] = 0;
			}
			else native_xs = null;

			// Marshaling ys to native string
			byte* native_ys;
			var byteCount_ys = 0;
			if (ys != null)
			{
				byteCount_ys = Encoding.UTF8.GetByteCount(ys);
				if(byteCount_ys > Utils.MaxStackallocSize)
				{
					native_ys = Utils.Alloc<byte>(byteCount_ys + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_ys + 1];
					native_ys = stackallocBytes;
				}
				var ys_offset = Utils.EncodeStringUTF8(ys, native_ys, byteCount_ys);
				native_ys[ys_offset] = 0;
			}
			else native_ys = null;

			ImPlotNative.PlotShadedU8PtrU8PtrInt(native_labelId, native_xs, native_ys, count, yref, flags, offset, stride);
			// Freeing labelId native string
			if (byteCount_labelId > Utils.MaxStackallocSize)
				Utils.Free(native_labelId);
			// Freeing xs native string
			if (byteCount_xs > Utils.MaxStackallocSize)
				Utils.Free(native_xs);
			// Freeing ys native string
			if (byteCount_ys > Utils.MaxStackallocSize)
				Utils.Free(native_ys);
		}

		public static void PlotShadedS16PtrS16PtrInt(ReadOnlySpan<char> labelId, ref short xs, ref short ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (short* native_xs = &xs)
			fixed (short* native_ys = &ys)
			{
				ImPlotNative.PlotShadedS16PtrS16PtrInt(native_labelId, native_xs, native_ys, count, yref, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotShadedU16PtrU16PtrInt(ReadOnlySpan<char> labelId, ref ushort xs, ref ushort ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (ushort* native_xs = &xs)
			fixed (ushort* native_ys = &ys)
			{
				ImPlotNative.PlotShadedU16PtrU16PtrInt(native_labelId, native_xs, native_ys, count, yref, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotShadedS32PtrS32PtrInt(ReadOnlySpan<char> labelId, ref int xs, ref int ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (int* native_xs = &xs)
			fixed (int* native_ys = &ys)
			{
				ImPlotNative.PlotShadedS32PtrS32PtrInt(native_labelId, native_xs, native_ys, count, yref, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotShadedU32PtrU32PtrInt(ReadOnlySpan<char> labelId, ref uint xs, ref uint ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (uint* native_xs = &xs)
			fixed (uint* native_ys = &ys)
			{
				ImPlotNative.PlotShadedU32PtrU32PtrInt(native_labelId, native_xs, native_ys, count, yref, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotShadedS64PtrS64PtrInt(ReadOnlySpan<char> labelId, ref long xs, ref long ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (long* native_xs = &xs)
			fixed (long* native_ys = &ys)
			{
				ImPlotNative.PlotShadedS64PtrS64PtrInt(native_labelId, native_xs, native_ys, count, yref, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotShadedU64PtrU64PtrInt(ReadOnlySpan<char> labelId, ref ulong xs, ref ulong ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (ulong* native_xs = &xs)
			fixed (ulong* native_ys = &ys)
			{
				ImPlotNative.PlotShadedU64PtrU64PtrInt(native_labelId, native_xs, native_ys, count, yref, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotShadedFloatPtrFloatPtrFloatPtr(ReadOnlySpan<char> labelId, ref float xs, ref float ys1, ref float ys2, int count, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (float* native_xs = &xs)
			fixed (float* native_ys1 = &ys1)
			fixed (float* native_ys2 = &ys2)
			{
				ImPlotNative.PlotShadedFloatPtrFloatPtrFloatPtr(native_labelId, native_xs, native_ys1, native_ys2, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotShadedDoublePtrdoublePtrdoublePtr(ReadOnlySpan<char> labelId, ref double xs, ref double ys1, ref double ys2, int count, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (double* native_xs = &xs)
			fixed (double* native_ys1 = &ys1)
			fixed (double* native_ys2 = &ys2)
			{
				ImPlotNative.PlotShadedDoublePtrdoublePtrdoublePtr(native_labelId, native_xs, native_ys1, native_ys2, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotShadedS8PtrS8PtrS8Ptr(ReadOnlySpan<char> labelId, ref sbyte xs, ref sbyte ys1, ref sbyte ys2, int count, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (sbyte* native_xs = &xs)
			fixed (sbyte* native_ys1 = &ys1)
			fixed (sbyte* native_ys2 = &ys2)
			{
				ImPlotNative.PlotShadedS8PtrS8PtrS8Ptr(native_labelId, native_xs, native_ys1, native_ys2, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotShadedU8PtrU8PtrU8Ptr(ReadOnlySpan<char> labelId, ReadOnlySpan<char> xs, ReadOnlySpan<char> ys1, ReadOnlySpan<char> ys2, int count, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			// Marshaling xs to native string
			byte* native_xs;
			var byteCount_xs = 0;
			if (xs != null)
			{
				byteCount_xs = Encoding.UTF8.GetByteCount(xs);
				if(byteCount_xs > Utils.MaxStackallocSize)
				{
					native_xs = Utils.Alloc<byte>(byteCount_xs + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_xs + 1];
					native_xs = stackallocBytes;
				}
				var xs_offset = Utils.EncodeStringUTF8(xs, native_xs, byteCount_xs);
				native_xs[xs_offset] = 0;
			}
			else native_xs = null;

			// Marshaling ys1 to native string
			byte* native_ys1;
			var byteCount_ys1 = 0;
			if (ys1 != null)
			{
				byteCount_ys1 = Encoding.UTF8.GetByteCount(ys1);
				if(byteCount_ys1 > Utils.MaxStackallocSize)
				{
					native_ys1 = Utils.Alloc<byte>(byteCount_ys1 + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_ys1 + 1];
					native_ys1 = stackallocBytes;
				}
				var ys1_offset = Utils.EncodeStringUTF8(ys1, native_ys1, byteCount_ys1);
				native_ys1[ys1_offset] = 0;
			}
			else native_ys1 = null;

			// Marshaling ys2 to native string
			byte* native_ys2;
			var byteCount_ys2 = 0;
			if (ys2 != null)
			{
				byteCount_ys2 = Encoding.UTF8.GetByteCount(ys2);
				if(byteCount_ys2 > Utils.MaxStackallocSize)
				{
					native_ys2 = Utils.Alloc<byte>(byteCount_ys2 + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_ys2 + 1];
					native_ys2 = stackallocBytes;
				}
				var ys2_offset = Utils.EncodeStringUTF8(ys2, native_ys2, byteCount_ys2);
				native_ys2[ys2_offset] = 0;
			}
			else native_ys2 = null;

			ImPlotNative.PlotShadedU8PtrU8PtrU8Ptr(native_labelId, native_xs, native_ys1, native_ys2, count, flags, offset, stride);
			// Freeing labelId native string
			if (byteCount_labelId > Utils.MaxStackallocSize)
				Utils.Free(native_labelId);
			// Freeing xs native string
			if (byteCount_xs > Utils.MaxStackallocSize)
				Utils.Free(native_xs);
			// Freeing ys1 native string
			if (byteCount_ys1 > Utils.MaxStackallocSize)
				Utils.Free(native_ys1);
			// Freeing ys2 native string
			if (byteCount_ys2 > Utils.MaxStackallocSize)
				Utils.Free(native_ys2);
		}

		public static void PlotShadedS16PtrS16PtrS16Ptr(ReadOnlySpan<char> labelId, ref short xs, ref short ys1, ref short ys2, int count, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (short* native_xs = &xs)
			fixed (short* native_ys1 = &ys1)
			fixed (short* native_ys2 = &ys2)
			{
				ImPlotNative.PlotShadedS16PtrS16PtrS16Ptr(native_labelId, native_xs, native_ys1, native_ys2, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotShadedU16PtrU16PtrU16Ptr(ReadOnlySpan<char> labelId, ref ushort xs, ref ushort ys1, ref ushort ys2, int count, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (ushort* native_xs = &xs)
			fixed (ushort* native_ys1 = &ys1)
			fixed (ushort* native_ys2 = &ys2)
			{
				ImPlotNative.PlotShadedU16PtrU16PtrU16Ptr(native_labelId, native_xs, native_ys1, native_ys2, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotShadedS32PtrS32PtrS32Ptr(ReadOnlySpan<char> labelId, ref int xs, ref int ys1, ref int ys2, int count, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (int* native_xs = &xs)
			fixed (int* native_ys1 = &ys1)
			fixed (int* native_ys2 = &ys2)
			{
				ImPlotNative.PlotShadedS32PtrS32PtrS32Ptr(native_labelId, native_xs, native_ys1, native_ys2, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotShadedU32PtrU32PtrU32Ptr(ReadOnlySpan<char> labelId, ref uint xs, ref uint ys1, ref uint ys2, int count, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (uint* native_xs = &xs)
			fixed (uint* native_ys1 = &ys1)
			fixed (uint* native_ys2 = &ys2)
			{
				ImPlotNative.PlotShadedU32PtrU32PtrU32Ptr(native_labelId, native_xs, native_ys1, native_ys2, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotShadedS64PtrS64PtrS64Ptr(ReadOnlySpan<char> labelId, ref long xs, ref long ys1, ref long ys2, int count, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (long* native_xs = &xs)
			fixed (long* native_ys1 = &ys1)
			fixed (long* native_ys2 = &ys2)
			{
				ImPlotNative.PlotShadedS64PtrS64PtrS64Ptr(native_labelId, native_xs, native_ys1, native_ys2, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotShadedU64PtrU64PtrU64Ptr(ReadOnlySpan<char> labelId, ref ulong xs, ref ulong ys1, ref ulong ys2, int count, ImPlotShadedFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (ulong* native_xs = &xs)
			fixed (ulong* native_ys1 = &ys1)
			fixed (ulong* native_ys2 = &ys2)
			{
				ImPlotNative.PlotShadedU64PtrU64PtrU64Ptr(native_labelId, native_xs, native_ys1, native_ys2, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotShadedG(ReadOnlySpan<char> labelId, ImPlotPointGetter getter1, IntPtr data1, ImPlotPointGetter getter2, IntPtr data2, int count, ImPlotShadedFlags flags)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			ImPlotNative.PlotShadedG(native_labelId, getter1, (void*)data1, getter2, (void*)data2, count, flags);
			// Freeing labelId native string
			if (byteCount_labelId > Utils.MaxStackallocSize)
				Utils.Free(native_labelId);
		}

		public static void PlotBarsFloatPtrInt(ReadOnlySpan<char> labelId, ref float values, int count, double barSize, double shift, ImPlotBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (float* native_values = &values)
			{
				ImPlotNative.PlotBarsFloatPtrInt(native_labelId, native_values, count, barSize, shift, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotBarsDoublePtrInt(ReadOnlySpan<char> labelId, ref double values, int count, double barSize, double shift, ImPlotBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (double* native_values = &values)
			{
				ImPlotNative.PlotBarsDoublePtrInt(native_labelId, native_values, count, barSize, shift, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotBarsS8PtrInt(ReadOnlySpan<char> labelId, ref sbyte values, int count, double barSize, double shift, ImPlotBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (sbyte* native_values = &values)
			{
				ImPlotNative.PlotBarsS8PtrInt(native_labelId, native_values, count, barSize, shift, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotBarsU8PtrInt(ReadOnlySpan<char> labelId, ReadOnlySpan<char> values, int count, double barSize, double shift, ImPlotBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			// Marshaling values to native string
			byte* native_values;
			var byteCount_values = 0;
			if (values != null)
			{
				byteCount_values = Encoding.UTF8.GetByteCount(values);
				if(byteCount_values > Utils.MaxStackallocSize)
				{
					native_values = Utils.Alloc<byte>(byteCount_values + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_values + 1];
					native_values = stackallocBytes;
				}
				var values_offset = Utils.EncodeStringUTF8(values, native_values, byteCount_values);
				native_values[values_offset] = 0;
			}
			else native_values = null;

			ImPlotNative.PlotBarsU8PtrInt(native_labelId, native_values, count, barSize, shift, flags, offset, stride);
			// Freeing labelId native string
			if (byteCount_labelId > Utils.MaxStackallocSize)
				Utils.Free(native_labelId);
			// Freeing values native string
			if (byteCount_values > Utils.MaxStackallocSize)
				Utils.Free(native_values);
		}

		public static void PlotBarsS16PtrInt(ReadOnlySpan<char> labelId, ref short values, int count, double barSize, double shift, ImPlotBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (short* native_values = &values)
			{
				ImPlotNative.PlotBarsS16PtrInt(native_labelId, native_values, count, barSize, shift, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotBarsU16PtrInt(ReadOnlySpan<char> labelId, ref ushort values, int count, double barSize, double shift, ImPlotBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (ushort* native_values = &values)
			{
				ImPlotNative.PlotBarsU16PtrInt(native_labelId, native_values, count, barSize, shift, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotBarsS32PtrInt(ReadOnlySpan<char> labelId, ref int values, int count, double barSize, double shift, ImPlotBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (int* native_values = &values)
			{
				ImPlotNative.PlotBarsS32PtrInt(native_labelId, native_values, count, barSize, shift, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotBarsU32PtrInt(ReadOnlySpan<char> labelId, ref uint values, int count, double barSize, double shift, ImPlotBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (uint* native_values = &values)
			{
				ImPlotNative.PlotBarsU32PtrInt(native_labelId, native_values, count, barSize, shift, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotBarsS64PtrInt(ReadOnlySpan<char> labelId, ref long values, int count, double barSize, double shift, ImPlotBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (long* native_values = &values)
			{
				ImPlotNative.PlotBarsS64PtrInt(native_labelId, native_values, count, barSize, shift, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotBarsU64PtrInt(ReadOnlySpan<char> labelId, ref ulong values, int count, double barSize, double shift, ImPlotBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (ulong* native_values = &values)
			{
				ImPlotNative.PlotBarsU64PtrInt(native_labelId, native_values, count, barSize, shift, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotBarsFloatPtrFloatPtr(ReadOnlySpan<char> labelId, ref float xs, ref float ys, int count, double barSize, ImPlotBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (float* native_xs = &xs)
			fixed (float* native_ys = &ys)
			{
				ImPlotNative.PlotBarsFloatPtrFloatPtr(native_labelId, native_xs, native_ys, count, barSize, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotBarsDoublePtrdoublePtr(ReadOnlySpan<char> labelId, ref double xs, ref double ys, int count, double barSize, ImPlotBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (double* native_xs = &xs)
			fixed (double* native_ys = &ys)
			{
				ImPlotNative.PlotBarsDoublePtrdoublePtr(native_labelId, native_xs, native_ys, count, barSize, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotBarsS8PtrS8Ptr(ReadOnlySpan<char> labelId, ref sbyte xs, ref sbyte ys, int count, double barSize, ImPlotBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (sbyte* native_xs = &xs)
			fixed (sbyte* native_ys = &ys)
			{
				ImPlotNative.PlotBarsS8PtrS8Ptr(native_labelId, native_xs, native_ys, count, barSize, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotBarsU8PtrU8Ptr(ReadOnlySpan<char> labelId, ReadOnlySpan<char> xs, ReadOnlySpan<char> ys, int count, double barSize, ImPlotBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			// Marshaling xs to native string
			byte* native_xs;
			var byteCount_xs = 0;
			if (xs != null)
			{
				byteCount_xs = Encoding.UTF8.GetByteCount(xs);
				if(byteCount_xs > Utils.MaxStackallocSize)
				{
					native_xs = Utils.Alloc<byte>(byteCount_xs + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_xs + 1];
					native_xs = stackallocBytes;
				}
				var xs_offset = Utils.EncodeStringUTF8(xs, native_xs, byteCount_xs);
				native_xs[xs_offset] = 0;
			}
			else native_xs = null;

			// Marshaling ys to native string
			byte* native_ys;
			var byteCount_ys = 0;
			if (ys != null)
			{
				byteCount_ys = Encoding.UTF8.GetByteCount(ys);
				if(byteCount_ys > Utils.MaxStackallocSize)
				{
					native_ys = Utils.Alloc<byte>(byteCount_ys + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_ys + 1];
					native_ys = stackallocBytes;
				}
				var ys_offset = Utils.EncodeStringUTF8(ys, native_ys, byteCount_ys);
				native_ys[ys_offset] = 0;
			}
			else native_ys = null;

			ImPlotNative.PlotBarsU8PtrU8Ptr(native_labelId, native_xs, native_ys, count, barSize, flags, offset, stride);
			// Freeing labelId native string
			if (byteCount_labelId > Utils.MaxStackallocSize)
				Utils.Free(native_labelId);
			// Freeing xs native string
			if (byteCount_xs > Utils.MaxStackallocSize)
				Utils.Free(native_xs);
			// Freeing ys native string
			if (byteCount_ys > Utils.MaxStackallocSize)
				Utils.Free(native_ys);
		}

		public static void PlotBarsS16PtrS16Ptr(ReadOnlySpan<char> labelId, ref short xs, ref short ys, int count, double barSize, ImPlotBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (short* native_xs = &xs)
			fixed (short* native_ys = &ys)
			{
				ImPlotNative.PlotBarsS16PtrS16Ptr(native_labelId, native_xs, native_ys, count, barSize, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotBarsU16PtrU16Ptr(ReadOnlySpan<char> labelId, ref ushort xs, ref ushort ys, int count, double barSize, ImPlotBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (ushort* native_xs = &xs)
			fixed (ushort* native_ys = &ys)
			{
				ImPlotNative.PlotBarsU16PtrU16Ptr(native_labelId, native_xs, native_ys, count, barSize, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotBarsS32PtrS32Ptr(ReadOnlySpan<char> labelId, ref int xs, ref int ys, int count, double barSize, ImPlotBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (int* native_xs = &xs)
			fixed (int* native_ys = &ys)
			{
				ImPlotNative.PlotBarsS32PtrS32Ptr(native_labelId, native_xs, native_ys, count, barSize, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotBarsU32PtrU32Ptr(ReadOnlySpan<char> labelId, ref uint xs, ref uint ys, int count, double barSize, ImPlotBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (uint* native_xs = &xs)
			fixed (uint* native_ys = &ys)
			{
				ImPlotNative.PlotBarsU32PtrU32Ptr(native_labelId, native_xs, native_ys, count, barSize, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotBarsS64PtrS64Ptr(ReadOnlySpan<char> labelId, ref long xs, ref long ys, int count, double barSize, ImPlotBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (long* native_xs = &xs)
			fixed (long* native_ys = &ys)
			{
				ImPlotNative.PlotBarsS64PtrS64Ptr(native_labelId, native_xs, native_ys, count, barSize, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotBarsU64PtrU64Ptr(ReadOnlySpan<char> labelId, ref ulong xs, ref ulong ys, int count, double barSize, ImPlotBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (ulong* native_xs = &xs)
			fixed (ulong* native_ys = &ys)
			{
				ImPlotNative.PlotBarsU64PtrU64Ptr(native_labelId, native_xs, native_ys, count, barSize, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotBarsG(ReadOnlySpan<char> labelId, ImPlotPointGetter getter, IntPtr data, int count, double barSize, ImPlotBarsFlags flags)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			ImPlotNative.PlotBarsG(native_labelId, getter, (void*)data, count, barSize, flags);
			// Freeing labelId native string
			if (byteCount_labelId > Utils.MaxStackallocSize)
				Utils.Free(native_labelId);
		}

		public static void PlotBarGroupsFloatPtr(ref byte* labelIds, ref float values, int itemCount, int groupCount, double groupSize, double shift, ImPlotBarGroupsFlags flags)
		{
			fixed (byte** native_labelIds = &labelIds)
			fixed (float* native_values = &values)
			{
				ImPlotNative.PlotBarGroupsFloatPtr(native_labelIds, native_values, itemCount, groupCount, groupSize, shift, flags);
			}
		}

		public static void PlotBarGroupsDoublePtr(ref byte* labelIds, ref double values, int itemCount, int groupCount, double groupSize, double shift, ImPlotBarGroupsFlags flags)
		{
			fixed (byte** native_labelIds = &labelIds)
			fixed (double* native_values = &values)
			{
				ImPlotNative.PlotBarGroupsDoublePtr(native_labelIds, native_values, itemCount, groupCount, groupSize, shift, flags);
			}
		}

		public static void PlotBarGroupsS8Ptr(ref byte* labelIds, ref sbyte values, int itemCount, int groupCount, double groupSize, double shift, ImPlotBarGroupsFlags flags)
		{
			fixed (byte** native_labelIds = &labelIds)
			fixed (sbyte* native_values = &values)
			{
				ImPlotNative.PlotBarGroupsS8Ptr(native_labelIds, native_values, itemCount, groupCount, groupSize, shift, flags);
			}
		}

		public static void PlotBarGroupsU8Ptr(ref byte* labelIds, ReadOnlySpan<char> values, int itemCount, int groupCount, double groupSize, double shift, ImPlotBarGroupsFlags flags)
		{
			// Marshaling values to native string
			byte* native_values;
			var byteCount_values = 0;
			if (values != null)
			{
				byteCount_values = Encoding.UTF8.GetByteCount(values);
				if(byteCount_values > Utils.MaxStackallocSize)
				{
					native_values = Utils.Alloc<byte>(byteCount_values + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_values + 1];
					native_values = stackallocBytes;
				}
				var values_offset = Utils.EncodeStringUTF8(values, native_values, byteCount_values);
				native_values[values_offset] = 0;
			}
			else native_values = null;

			fixed (byte** native_labelIds = &labelIds)
			{
				ImPlotNative.PlotBarGroupsU8Ptr(native_labelIds, native_values, itemCount, groupCount, groupSize, shift, flags);
				// Freeing values native string
				if (byteCount_values > Utils.MaxStackallocSize)
					Utils.Free(native_values);
			}
		}

		public static void PlotBarGroupsS16Ptr(ref byte* labelIds, ref short values, int itemCount, int groupCount, double groupSize, double shift, ImPlotBarGroupsFlags flags)
		{
			fixed (byte** native_labelIds = &labelIds)
			fixed (short* native_values = &values)
			{
				ImPlotNative.PlotBarGroupsS16Ptr(native_labelIds, native_values, itemCount, groupCount, groupSize, shift, flags);
			}
		}

		public static void PlotBarGroupsU16Ptr(ref byte* labelIds, ref ushort values, int itemCount, int groupCount, double groupSize, double shift, ImPlotBarGroupsFlags flags)
		{
			fixed (byte** native_labelIds = &labelIds)
			fixed (ushort* native_values = &values)
			{
				ImPlotNative.PlotBarGroupsU16Ptr(native_labelIds, native_values, itemCount, groupCount, groupSize, shift, flags);
			}
		}

		public static void PlotBarGroupsS32Ptr(ref byte* labelIds, ref int values, int itemCount, int groupCount, double groupSize, double shift, ImPlotBarGroupsFlags flags)
		{
			fixed (byte** native_labelIds = &labelIds)
			fixed (int* native_values = &values)
			{
				ImPlotNative.PlotBarGroupsS32Ptr(native_labelIds, native_values, itemCount, groupCount, groupSize, shift, flags);
			}
		}

		public static void PlotBarGroupsU32Ptr(ref byte* labelIds, ref uint values, int itemCount, int groupCount, double groupSize, double shift, ImPlotBarGroupsFlags flags)
		{
			fixed (byte** native_labelIds = &labelIds)
			fixed (uint* native_values = &values)
			{
				ImPlotNative.PlotBarGroupsU32Ptr(native_labelIds, native_values, itemCount, groupCount, groupSize, shift, flags);
			}
		}

		public static void PlotBarGroupsS64Ptr(ref byte* labelIds, ref long values, int itemCount, int groupCount, double groupSize, double shift, ImPlotBarGroupsFlags flags)
		{
			fixed (byte** native_labelIds = &labelIds)
			fixed (long* native_values = &values)
			{
				ImPlotNative.PlotBarGroupsS64Ptr(native_labelIds, native_values, itemCount, groupCount, groupSize, shift, flags);
			}
		}

		public static void PlotBarGroupsU64Ptr(ref byte* labelIds, ref ulong values, int itemCount, int groupCount, double groupSize, double shift, ImPlotBarGroupsFlags flags)
		{
			fixed (byte** native_labelIds = &labelIds)
			fixed (ulong* native_values = &values)
			{
				ImPlotNative.PlotBarGroupsU64Ptr(native_labelIds, native_values, itemCount, groupCount, groupSize, shift, flags);
			}
		}

		public static void PlotErrorBarsFloatPtrFloatPtrFloatPtrInt(ReadOnlySpan<char> labelId, ref float xs, ref float ys, ref float err, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (float* native_xs = &xs)
			fixed (float* native_ys = &ys)
			fixed (float* native_err = &err)
			{
				ImPlotNative.PlotErrorBarsFloatPtrFloatPtrFloatPtrInt(native_labelId, native_xs, native_ys, native_err, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotErrorBarsDoublePtrdoublePtrdoublePtrInt(ReadOnlySpan<char> labelId, ref double xs, ref double ys, ref double err, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (double* native_xs = &xs)
			fixed (double* native_ys = &ys)
			fixed (double* native_err = &err)
			{
				ImPlotNative.PlotErrorBarsDoublePtrdoublePtrdoublePtrInt(native_labelId, native_xs, native_ys, native_err, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotErrorBarsS8PtrS8PtrS8PtrInt(ReadOnlySpan<char> labelId, ref sbyte xs, ref sbyte ys, ref sbyte err, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (sbyte* native_xs = &xs)
			fixed (sbyte* native_ys = &ys)
			fixed (sbyte* native_err = &err)
			{
				ImPlotNative.PlotErrorBarsS8PtrS8PtrS8PtrInt(native_labelId, native_xs, native_ys, native_err, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotErrorBarsU8PtrU8PtrU8PtrInt(ReadOnlySpan<char> labelId, ReadOnlySpan<char> xs, ReadOnlySpan<char> ys, ReadOnlySpan<char> err, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			// Marshaling xs to native string
			byte* native_xs;
			var byteCount_xs = 0;
			if (xs != null)
			{
				byteCount_xs = Encoding.UTF8.GetByteCount(xs);
				if(byteCount_xs > Utils.MaxStackallocSize)
				{
					native_xs = Utils.Alloc<byte>(byteCount_xs + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_xs + 1];
					native_xs = stackallocBytes;
				}
				var xs_offset = Utils.EncodeStringUTF8(xs, native_xs, byteCount_xs);
				native_xs[xs_offset] = 0;
			}
			else native_xs = null;

			// Marshaling ys to native string
			byte* native_ys;
			var byteCount_ys = 0;
			if (ys != null)
			{
				byteCount_ys = Encoding.UTF8.GetByteCount(ys);
				if(byteCount_ys > Utils.MaxStackallocSize)
				{
					native_ys = Utils.Alloc<byte>(byteCount_ys + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_ys + 1];
					native_ys = stackallocBytes;
				}
				var ys_offset = Utils.EncodeStringUTF8(ys, native_ys, byteCount_ys);
				native_ys[ys_offset] = 0;
			}
			else native_ys = null;

			// Marshaling err to native string
			byte* native_err;
			var byteCount_err = 0;
			if (err != null)
			{
				byteCount_err = Encoding.UTF8.GetByteCount(err);
				if(byteCount_err > Utils.MaxStackallocSize)
				{
					native_err = Utils.Alloc<byte>(byteCount_err + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_err + 1];
					native_err = stackallocBytes;
				}
				var err_offset = Utils.EncodeStringUTF8(err, native_err, byteCount_err);
				native_err[err_offset] = 0;
			}
			else native_err = null;

			ImPlotNative.PlotErrorBarsU8PtrU8PtrU8PtrInt(native_labelId, native_xs, native_ys, native_err, count, flags, offset, stride);
			// Freeing labelId native string
			if (byteCount_labelId > Utils.MaxStackallocSize)
				Utils.Free(native_labelId);
			// Freeing xs native string
			if (byteCount_xs > Utils.MaxStackallocSize)
				Utils.Free(native_xs);
			// Freeing ys native string
			if (byteCount_ys > Utils.MaxStackallocSize)
				Utils.Free(native_ys);
			// Freeing err native string
			if (byteCount_err > Utils.MaxStackallocSize)
				Utils.Free(native_err);
		}

		public static void PlotErrorBarsS16PtrS16PtrS16PtrInt(ReadOnlySpan<char> labelId, ref short xs, ref short ys, ref short err, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (short* native_xs = &xs)
			fixed (short* native_ys = &ys)
			fixed (short* native_err = &err)
			{
				ImPlotNative.PlotErrorBarsS16PtrS16PtrS16PtrInt(native_labelId, native_xs, native_ys, native_err, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotErrorBarsU16PtrU16PtrU16PtrInt(ReadOnlySpan<char> labelId, ref ushort xs, ref ushort ys, ref ushort err, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (ushort* native_xs = &xs)
			fixed (ushort* native_ys = &ys)
			fixed (ushort* native_err = &err)
			{
				ImPlotNative.PlotErrorBarsU16PtrU16PtrU16PtrInt(native_labelId, native_xs, native_ys, native_err, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotErrorBarsS32PtrS32PtrS32PtrInt(ReadOnlySpan<char> labelId, ref int xs, ref int ys, ref int err, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (int* native_xs = &xs)
			fixed (int* native_ys = &ys)
			fixed (int* native_err = &err)
			{
				ImPlotNative.PlotErrorBarsS32PtrS32PtrS32PtrInt(native_labelId, native_xs, native_ys, native_err, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotErrorBarsU32PtrU32PtrU32PtrInt(ReadOnlySpan<char> labelId, ref uint xs, ref uint ys, ref uint err, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (uint* native_xs = &xs)
			fixed (uint* native_ys = &ys)
			fixed (uint* native_err = &err)
			{
				ImPlotNative.PlotErrorBarsU32PtrU32PtrU32PtrInt(native_labelId, native_xs, native_ys, native_err, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotErrorBarsS64PtrS64PtrS64PtrInt(ReadOnlySpan<char> labelId, ref long xs, ref long ys, ref long err, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (long* native_xs = &xs)
			fixed (long* native_ys = &ys)
			fixed (long* native_err = &err)
			{
				ImPlotNative.PlotErrorBarsS64PtrS64PtrS64PtrInt(native_labelId, native_xs, native_ys, native_err, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotErrorBarsU64PtrU64PtrU64PtrInt(ReadOnlySpan<char> labelId, ref ulong xs, ref ulong ys, ref ulong err, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (ulong* native_xs = &xs)
			fixed (ulong* native_ys = &ys)
			fixed (ulong* native_err = &err)
			{
				ImPlotNative.PlotErrorBarsU64PtrU64PtrU64PtrInt(native_labelId, native_xs, native_ys, native_err, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotErrorBarsFloatPtrFloatPtrFloatPtrFloatPtr(ReadOnlySpan<char> labelId, ref float xs, ref float ys, ref float neg, ref float pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (float* native_xs = &xs)
			fixed (float* native_ys = &ys)
			fixed (float* native_neg = &neg)
			fixed (float* native_pos = &pos)
			{
				ImPlotNative.PlotErrorBarsFloatPtrFloatPtrFloatPtrFloatPtr(native_labelId, native_xs, native_ys, native_neg, native_pos, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotErrorBarsDoublePtrdoublePtrdoublePtrdoublePtr(ReadOnlySpan<char> labelId, ref double xs, ref double ys, ref double neg, ref double pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (double* native_xs = &xs)
			fixed (double* native_ys = &ys)
			fixed (double* native_neg = &neg)
			fixed (double* native_pos = &pos)
			{
				ImPlotNative.PlotErrorBarsDoublePtrdoublePtrdoublePtrdoublePtr(native_labelId, native_xs, native_ys, native_neg, native_pos, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotErrorBarsS8PtrS8PtrS8PtrS8Ptr(ReadOnlySpan<char> labelId, ref sbyte xs, ref sbyte ys, ref sbyte neg, ref sbyte pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (sbyte* native_xs = &xs)
			fixed (sbyte* native_ys = &ys)
			fixed (sbyte* native_neg = &neg)
			fixed (sbyte* native_pos = &pos)
			{
				ImPlotNative.PlotErrorBarsS8PtrS8PtrS8PtrS8Ptr(native_labelId, native_xs, native_ys, native_neg, native_pos, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotErrorBarsU8PtrU8PtrU8PtrU8Ptr(ReadOnlySpan<char> labelId, ReadOnlySpan<char> xs, ReadOnlySpan<char> ys, ReadOnlySpan<char> neg, ReadOnlySpan<char> pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			// Marshaling xs to native string
			byte* native_xs;
			var byteCount_xs = 0;
			if (xs != null)
			{
				byteCount_xs = Encoding.UTF8.GetByteCount(xs);
				if(byteCount_xs > Utils.MaxStackallocSize)
				{
					native_xs = Utils.Alloc<byte>(byteCount_xs + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_xs + 1];
					native_xs = stackallocBytes;
				}
				var xs_offset = Utils.EncodeStringUTF8(xs, native_xs, byteCount_xs);
				native_xs[xs_offset] = 0;
			}
			else native_xs = null;

			// Marshaling ys to native string
			byte* native_ys;
			var byteCount_ys = 0;
			if (ys != null)
			{
				byteCount_ys = Encoding.UTF8.GetByteCount(ys);
				if(byteCount_ys > Utils.MaxStackallocSize)
				{
					native_ys = Utils.Alloc<byte>(byteCount_ys + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_ys + 1];
					native_ys = stackallocBytes;
				}
				var ys_offset = Utils.EncodeStringUTF8(ys, native_ys, byteCount_ys);
				native_ys[ys_offset] = 0;
			}
			else native_ys = null;

			// Marshaling neg to native string
			byte* native_neg;
			var byteCount_neg = 0;
			if (neg != null)
			{
				byteCount_neg = Encoding.UTF8.GetByteCount(neg);
				if(byteCount_neg > Utils.MaxStackallocSize)
				{
					native_neg = Utils.Alloc<byte>(byteCount_neg + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_neg + 1];
					native_neg = stackallocBytes;
				}
				var neg_offset = Utils.EncodeStringUTF8(neg, native_neg, byteCount_neg);
				native_neg[neg_offset] = 0;
			}
			else native_neg = null;

			// Marshaling pos to native string
			byte* native_pos;
			var byteCount_pos = 0;
			if (pos != null)
			{
				byteCount_pos = Encoding.UTF8.GetByteCount(pos);
				if(byteCount_pos > Utils.MaxStackallocSize)
				{
					native_pos = Utils.Alloc<byte>(byteCount_pos + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_pos + 1];
					native_pos = stackallocBytes;
				}
				var pos_offset = Utils.EncodeStringUTF8(pos, native_pos, byteCount_pos);
				native_pos[pos_offset] = 0;
			}
			else native_pos = null;

			ImPlotNative.PlotErrorBarsU8PtrU8PtrU8PtrU8Ptr(native_labelId, native_xs, native_ys, native_neg, native_pos, count, flags, offset, stride);
			// Freeing labelId native string
			if (byteCount_labelId > Utils.MaxStackallocSize)
				Utils.Free(native_labelId);
			// Freeing xs native string
			if (byteCount_xs > Utils.MaxStackallocSize)
				Utils.Free(native_xs);
			// Freeing ys native string
			if (byteCount_ys > Utils.MaxStackallocSize)
				Utils.Free(native_ys);
			// Freeing neg native string
			if (byteCount_neg > Utils.MaxStackallocSize)
				Utils.Free(native_neg);
			// Freeing pos native string
			if (byteCount_pos > Utils.MaxStackallocSize)
				Utils.Free(native_pos);
		}

		public static void PlotErrorBarsS16PtrS16PtrS16PtrS16Ptr(ReadOnlySpan<char> labelId, ref short xs, ref short ys, ref short neg, ref short pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (short* native_xs = &xs)
			fixed (short* native_ys = &ys)
			fixed (short* native_neg = &neg)
			fixed (short* native_pos = &pos)
			{
				ImPlotNative.PlotErrorBarsS16PtrS16PtrS16PtrS16Ptr(native_labelId, native_xs, native_ys, native_neg, native_pos, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotErrorBarsU16PtrU16PtrU16PtrU16Ptr(ReadOnlySpan<char> labelId, ref ushort xs, ref ushort ys, ref ushort neg, ref ushort pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (ushort* native_xs = &xs)
			fixed (ushort* native_ys = &ys)
			fixed (ushort* native_neg = &neg)
			fixed (ushort* native_pos = &pos)
			{
				ImPlotNative.PlotErrorBarsU16PtrU16PtrU16PtrU16Ptr(native_labelId, native_xs, native_ys, native_neg, native_pos, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotErrorBarsS32PtrS32PtrS32PtrS32Ptr(ReadOnlySpan<char> labelId, ref int xs, ref int ys, ref int neg, ref int pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (int* native_xs = &xs)
			fixed (int* native_ys = &ys)
			fixed (int* native_neg = &neg)
			fixed (int* native_pos = &pos)
			{
				ImPlotNative.PlotErrorBarsS32PtrS32PtrS32PtrS32Ptr(native_labelId, native_xs, native_ys, native_neg, native_pos, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotErrorBarsU32PtrU32PtrU32PtrU32Ptr(ReadOnlySpan<char> labelId, ref uint xs, ref uint ys, ref uint neg, ref uint pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (uint* native_xs = &xs)
			fixed (uint* native_ys = &ys)
			fixed (uint* native_neg = &neg)
			fixed (uint* native_pos = &pos)
			{
				ImPlotNative.PlotErrorBarsU32PtrU32PtrU32PtrU32Ptr(native_labelId, native_xs, native_ys, native_neg, native_pos, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotErrorBarsS64PtrS64PtrS64PtrS64Ptr(ReadOnlySpan<char> labelId, ref long xs, ref long ys, ref long neg, ref long pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (long* native_xs = &xs)
			fixed (long* native_ys = &ys)
			fixed (long* native_neg = &neg)
			fixed (long* native_pos = &pos)
			{
				ImPlotNative.PlotErrorBarsS64PtrS64PtrS64PtrS64Ptr(native_labelId, native_xs, native_ys, native_neg, native_pos, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotErrorBarsU64PtrU64PtrU64PtrU64Ptr(ReadOnlySpan<char> labelId, ref ulong xs, ref ulong ys, ref ulong neg, ref ulong pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (ulong* native_xs = &xs)
			fixed (ulong* native_ys = &ys)
			fixed (ulong* native_neg = &neg)
			fixed (ulong* native_pos = &pos)
			{
				ImPlotNative.PlotErrorBarsU64PtrU64PtrU64PtrU64Ptr(native_labelId, native_xs, native_ys, native_neg, native_pos, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotStemsFloatPtrInt(ReadOnlySpan<char> labelId, ref float values, int count, double _ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (float* native_values = &values)
			{
				ImPlotNative.PlotStemsFloatPtrInt(native_labelId, native_values, count, _ref, scale, start, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotStemsDoublePtrInt(ReadOnlySpan<char> labelId, ref double values, int count, double _ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (double* native_values = &values)
			{
				ImPlotNative.PlotStemsDoublePtrInt(native_labelId, native_values, count, _ref, scale, start, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotStemsS8PtrInt(ReadOnlySpan<char> labelId, ref sbyte values, int count, double _ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (sbyte* native_values = &values)
			{
				ImPlotNative.PlotStemsS8PtrInt(native_labelId, native_values, count, _ref, scale, start, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotStemsU8PtrInt(ReadOnlySpan<char> labelId, ReadOnlySpan<char> values, int count, double _ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			// Marshaling values to native string
			byte* native_values;
			var byteCount_values = 0;
			if (values != null)
			{
				byteCount_values = Encoding.UTF8.GetByteCount(values);
				if(byteCount_values > Utils.MaxStackallocSize)
				{
					native_values = Utils.Alloc<byte>(byteCount_values + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_values + 1];
					native_values = stackallocBytes;
				}
				var values_offset = Utils.EncodeStringUTF8(values, native_values, byteCount_values);
				native_values[values_offset] = 0;
			}
			else native_values = null;

			ImPlotNative.PlotStemsU8PtrInt(native_labelId, native_values, count, _ref, scale, start, flags, offset, stride);
			// Freeing labelId native string
			if (byteCount_labelId > Utils.MaxStackallocSize)
				Utils.Free(native_labelId);
			// Freeing values native string
			if (byteCount_values > Utils.MaxStackallocSize)
				Utils.Free(native_values);
		}

		public static void PlotStemsS16PtrInt(ReadOnlySpan<char> labelId, ref short values, int count, double _ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (short* native_values = &values)
			{
				ImPlotNative.PlotStemsS16PtrInt(native_labelId, native_values, count, _ref, scale, start, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotStemsU16PtrInt(ReadOnlySpan<char> labelId, ref ushort values, int count, double _ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (ushort* native_values = &values)
			{
				ImPlotNative.PlotStemsU16PtrInt(native_labelId, native_values, count, _ref, scale, start, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotStemsS32PtrInt(ReadOnlySpan<char> labelId, ref int values, int count, double _ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (int* native_values = &values)
			{
				ImPlotNative.PlotStemsS32PtrInt(native_labelId, native_values, count, _ref, scale, start, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotStemsU32PtrInt(ReadOnlySpan<char> labelId, ref uint values, int count, double _ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (uint* native_values = &values)
			{
				ImPlotNative.PlotStemsU32PtrInt(native_labelId, native_values, count, _ref, scale, start, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotStemsS64PtrInt(ReadOnlySpan<char> labelId, ref long values, int count, double _ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (long* native_values = &values)
			{
				ImPlotNative.PlotStemsS64PtrInt(native_labelId, native_values, count, _ref, scale, start, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotStemsU64PtrInt(ReadOnlySpan<char> labelId, ref ulong values, int count, double _ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (ulong* native_values = &values)
			{
				ImPlotNative.PlotStemsU64PtrInt(native_labelId, native_values, count, _ref, scale, start, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotStemsFloatPtrFloatPtr(ReadOnlySpan<char> labelId, ref float xs, ref float ys, int count, double _ref, ImPlotStemsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (float* native_xs = &xs)
			fixed (float* native_ys = &ys)
			{
				ImPlotNative.PlotStemsFloatPtrFloatPtr(native_labelId, native_xs, native_ys, count, _ref, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotStemsDoublePtrdoublePtr(ReadOnlySpan<char> labelId, ref double xs, ref double ys, int count, double _ref, ImPlotStemsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (double* native_xs = &xs)
			fixed (double* native_ys = &ys)
			{
				ImPlotNative.PlotStemsDoublePtrdoublePtr(native_labelId, native_xs, native_ys, count, _ref, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotStemsS8PtrS8Ptr(ReadOnlySpan<char> labelId, ref sbyte xs, ref sbyte ys, int count, double _ref, ImPlotStemsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (sbyte* native_xs = &xs)
			fixed (sbyte* native_ys = &ys)
			{
				ImPlotNative.PlotStemsS8PtrS8Ptr(native_labelId, native_xs, native_ys, count, _ref, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotStemsU8PtrU8Ptr(ReadOnlySpan<char> labelId, ReadOnlySpan<char> xs, ReadOnlySpan<char> ys, int count, double _ref, ImPlotStemsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			// Marshaling xs to native string
			byte* native_xs;
			var byteCount_xs = 0;
			if (xs != null)
			{
				byteCount_xs = Encoding.UTF8.GetByteCount(xs);
				if(byteCount_xs > Utils.MaxStackallocSize)
				{
					native_xs = Utils.Alloc<byte>(byteCount_xs + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_xs + 1];
					native_xs = stackallocBytes;
				}
				var xs_offset = Utils.EncodeStringUTF8(xs, native_xs, byteCount_xs);
				native_xs[xs_offset] = 0;
			}
			else native_xs = null;

			// Marshaling ys to native string
			byte* native_ys;
			var byteCount_ys = 0;
			if (ys != null)
			{
				byteCount_ys = Encoding.UTF8.GetByteCount(ys);
				if(byteCount_ys > Utils.MaxStackallocSize)
				{
					native_ys = Utils.Alloc<byte>(byteCount_ys + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_ys + 1];
					native_ys = stackallocBytes;
				}
				var ys_offset = Utils.EncodeStringUTF8(ys, native_ys, byteCount_ys);
				native_ys[ys_offset] = 0;
			}
			else native_ys = null;

			ImPlotNative.PlotStemsU8PtrU8Ptr(native_labelId, native_xs, native_ys, count, _ref, flags, offset, stride);
			// Freeing labelId native string
			if (byteCount_labelId > Utils.MaxStackallocSize)
				Utils.Free(native_labelId);
			// Freeing xs native string
			if (byteCount_xs > Utils.MaxStackallocSize)
				Utils.Free(native_xs);
			// Freeing ys native string
			if (byteCount_ys > Utils.MaxStackallocSize)
				Utils.Free(native_ys);
		}

		public static void PlotStemsS16PtrS16Ptr(ReadOnlySpan<char> labelId, ref short xs, ref short ys, int count, double _ref, ImPlotStemsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (short* native_xs = &xs)
			fixed (short* native_ys = &ys)
			{
				ImPlotNative.PlotStemsS16PtrS16Ptr(native_labelId, native_xs, native_ys, count, _ref, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotStemsU16PtrU16Ptr(ReadOnlySpan<char> labelId, ref ushort xs, ref ushort ys, int count, double _ref, ImPlotStemsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (ushort* native_xs = &xs)
			fixed (ushort* native_ys = &ys)
			{
				ImPlotNative.PlotStemsU16PtrU16Ptr(native_labelId, native_xs, native_ys, count, _ref, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotStemsS32PtrS32Ptr(ReadOnlySpan<char> labelId, ref int xs, ref int ys, int count, double _ref, ImPlotStemsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (int* native_xs = &xs)
			fixed (int* native_ys = &ys)
			{
				ImPlotNative.PlotStemsS32PtrS32Ptr(native_labelId, native_xs, native_ys, count, _ref, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotStemsU32PtrU32Ptr(ReadOnlySpan<char> labelId, ref uint xs, ref uint ys, int count, double _ref, ImPlotStemsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (uint* native_xs = &xs)
			fixed (uint* native_ys = &ys)
			{
				ImPlotNative.PlotStemsU32PtrU32Ptr(native_labelId, native_xs, native_ys, count, _ref, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotStemsS64PtrS64Ptr(ReadOnlySpan<char> labelId, ref long xs, ref long ys, int count, double _ref, ImPlotStemsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (long* native_xs = &xs)
			fixed (long* native_ys = &ys)
			{
				ImPlotNative.PlotStemsS64PtrS64Ptr(native_labelId, native_xs, native_ys, count, _ref, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotStemsU64PtrU64Ptr(ReadOnlySpan<char> labelId, ref ulong xs, ref ulong ys, int count, double _ref, ImPlotStemsFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (ulong* native_xs = &xs)
			fixed (ulong* native_ys = &ys)
			{
				ImPlotNative.PlotStemsU64PtrU64Ptr(native_labelId, native_xs, native_ys, count, _ref, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotInfLinesFloatPtr(ReadOnlySpan<char> labelId, ref float values, int count, ImPlotInfLinesFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (float* native_values = &values)
			{
				ImPlotNative.PlotInfLinesFloatPtr(native_labelId, native_values, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotInfLinesDoublePtr(ReadOnlySpan<char> labelId, ref double values, int count, ImPlotInfLinesFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (double* native_values = &values)
			{
				ImPlotNative.PlotInfLinesDoublePtr(native_labelId, native_values, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotInfLinesS8Ptr(ReadOnlySpan<char> labelId, ref sbyte values, int count, ImPlotInfLinesFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (sbyte* native_values = &values)
			{
				ImPlotNative.PlotInfLinesS8Ptr(native_labelId, native_values, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotInfLinesU8Ptr(ReadOnlySpan<char> labelId, ReadOnlySpan<char> values, int count, ImPlotInfLinesFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			// Marshaling values to native string
			byte* native_values;
			var byteCount_values = 0;
			if (values != null)
			{
				byteCount_values = Encoding.UTF8.GetByteCount(values);
				if(byteCount_values > Utils.MaxStackallocSize)
				{
					native_values = Utils.Alloc<byte>(byteCount_values + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_values + 1];
					native_values = stackallocBytes;
				}
				var values_offset = Utils.EncodeStringUTF8(values, native_values, byteCount_values);
				native_values[values_offset] = 0;
			}
			else native_values = null;

			ImPlotNative.PlotInfLinesU8Ptr(native_labelId, native_values, count, flags, offset, stride);
			// Freeing labelId native string
			if (byteCount_labelId > Utils.MaxStackallocSize)
				Utils.Free(native_labelId);
			// Freeing values native string
			if (byteCount_values > Utils.MaxStackallocSize)
				Utils.Free(native_values);
		}

		public static void PlotInfLinesS16Ptr(ReadOnlySpan<char> labelId, ref short values, int count, ImPlotInfLinesFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (short* native_values = &values)
			{
				ImPlotNative.PlotInfLinesS16Ptr(native_labelId, native_values, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotInfLinesU16Ptr(ReadOnlySpan<char> labelId, ref ushort values, int count, ImPlotInfLinesFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (ushort* native_values = &values)
			{
				ImPlotNative.PlotInfLinesU16Ptr(native_labelId, native_values, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotInfLinesS32Ptr(ReadOnlySpan<char> labelId, ref int values, int count, ImPlotInfLinesFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (int* native_values = &values)
			{
				ImPlotNative.PlotInfLinesS32Ptr(native_labelId, native_values, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotInfLinesU32Ptr(ReadOnlySpan<char> labelId, ref uint values, int count, ImPlotInfLinesFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (uint* native_values = &values)
			{
				ImPlotNative.PlotInfLinesU32Ptr(native_labelId, native_values, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotInfLinesS64Ptr(ReadOnlySpan<char> labelId, ref long values, int count, ImPlotInfLinesFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (long* native_values = &values)
			{
				ImPlotNative.PlotInfLinesS64Ptr(native_labelId, native_values, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotInfLinesU64Ptr(ReadOnlySpan<char> labelId, ref ulong values, int count, ImPlotInfLinesFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (ulong* native_values = &values)
			{
				ImPlotNative.PlotInfLinesU64Ptr(native_labelId, native_values, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotPieChartFloatPtrPlotFormatter(ref byte* labelIds, ref float values, int count, double x, double y, double radius, ImPlotFormatter fmt, IntPtr fmtData, double angle0, ImPlotPieChartFlags flags)
		{
			fixed (byte** native_labelIds = &labelIds)
			fixed (float* native_values = &values)
			{
				ImPlotNative.PlotPieChartFloatPtrPlotFormatter(native_labelIds, native_values, count, x, y, radius, fmt, (void*)fmtData, angle0, flags);
			}
		}

		public static void PlotPieChartDoublePtrPlotFormatter(ref byte* labelIds, ref double values, int count, double x, double y, double radius, ImPlotFormatter fmt, IntPtr fmtData, double angle0, ImPlotPieChartFlags flags)
		{
			fixed (byte** native_labelIds = &labelIds)
			fixed (double* native_values = &values)
			{
				ImPlotNative.PlotPieChartDoublePtrPlotFormatter(native_labelIds, native_values, count, x, y, radius, fmt, (void*)fmtData, angle0, flags);
			}
		}

		public static void PlotPieChartS8PtrPlotFormatter(ref byte* labelIds, ref sbyte values, int count, double x, double y, double radius, ImPlotFormatter fmt, IntPtr fmtData, double angle0, ImPlotPieChartFlags flags)
		{
			fixed (byte** native_labelIds = &labelIds)
			fixed (sbyte* native_values = &values)
			{
				ImPlotNative.PlotPieChartS8PtrPlotFormatter(native_labelIds, native_values, count, x, y, radius, fmt, (void*)fmtData, angle0, flags);
			}
		}

		public static void PlotPieChartU8PtrPlotFormatter(ref byte* labelIds, ReadOnlySpan<char> values, int count, double x, double y, double radius, ImPlotFormatter fmt, IntPtr fmtData, double angle0, ImPlotPieChartFlags flags)
		{
			// Marshaling values to native string
			byte* native_values;
			var byteCount_values = 0;
			if (values != null)
			{
				byteCount_values = Encoding.UTF8.GetByteCount(values);
				if(byteCount_values > Utils.MaxStackallocSize)
				{
					native_values = Utils.Alloc<byte>(byteCount_values + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_values + 1];
					native_values = stackallocBytes;
				}
				var values_offset = Utils.EncodeStringUTF8(values, native_values, byteCount_values);
				native_values[values_offset] = 0;
			}
			else native_values = null;

			fixed (byte** native_labelIds = &labelIds)
			{
				ImPlotNative.PlotPieChartU8PtrPlotFormatter(native_labelIds, native_values, count, x, y, radius, fmt, (void*)fmtData, angle0, flags);
				// Freeing values native string
				if (byteCount_values > Utils.MaxStackallocSize)
					Utils.Free(native_values);
			}
		}

		public static void PlotPieChartS16PtrPlotFormatter(ref byte* labelIds, ref short values, int count, double x, double y, double radius, ImPlotFormatter fmt, IntPtr fmtData, double angle0, ImPlotPieChartFlags flags)
		{
			fixed (byte** native_labelIds = &labelIds)
			fixed (short* native_values = &values)
			{
				ImPlotNative.PlotPieChartS16PtrPlotFormatter(native_labelIds, native_values, count, x, y, radius, fmt, (void*)fmtData, angle0, flags);
			}
		}

		public static void PlotPieChartU16PtrPlotFormatter(ref byte* labelIds, ref ushort values, int count, double x, double y, double radius, ImPlotFormatter fmt, IntPtr fmtData, double angle0, ImPlotPieChartFlags flags)
		{
			fixed (byte** native_labelIds = &labelIds)
			fixed (ushort* native_values = &values)
			{
				ImPlotNative.PlotPieChartU16PtrPlotFormatter(native_labelIds, native_values, count, x, y, radius, fmt, (void*)fmtData, angle0, flags);
			}
		}

		public static void PlotPieChartS32PtrPlotFormatter(ref byte* labelIds, ref int values, int count, double x, double y, double radius, ImPlotFormatter fmt, IntPtr fmtData, double angle0, ImPlotPieChartFlags flags)
		{
			fixed (byte** native_labelIds = &labelIds)
			fixed (int* native_values = &values)
			{
				ImPlotNative.PlotPieChartS32PtrPlotFormatter(native_labelIds, native_values, count, x, y, radius, fmt, (void*)fmtData, angle0, flags);
			}
		}

		public static void PlotPieChartU32PtrPlotFormatter(ref byte* labelIds, ref uint values, int count, double x, double y, double radius, ImPlotFormatter fmt, IntPtr fmtData, double angle0, ImPlotPieChartFlags flags)
		{
			fixed (byte** native_labelIds = &labelIds)
			fixed (uint* native_values = &values)
			{
				ImPlotNative.PlotPieChartU32PtrPlotFormatter(native_labelIds, native_values, count, x, y, radius, fmt, (void*)fmtData, angle0, flags);
			}
		}

		public static void PlotPieChartS64PtrPlotFormatter(ref byte* labelIds, ref long values, int count, double x, double y, double radius, ImPlotFormatter fmt, IntPtr fmtData, double angle0, ImPlotPieChartFlags flags)
		{
			fixed (byte** native_labelIds = &labelIds)
			fixed (long* native_values = &values)
			{
				ImPlotNative.PlotPieChartS64PtrPlotFormatter(native_labelIds, native_values, count, x, y, radius, fmt, (void*)fmtData, angle0, flags);
			}
		}

		public static void PlotPieChartU64PtrPlotFormatter(ref byte* labelIds, ref ulong values, int count, double x, double y, double radius, ImPlotFormatter fmt, IntPtr fmtData, double angle0, ImPlotPieChartFlags flags)
		{
			fixed (byte** native_labelIds = &labelIds)
			fixed (ulong* native_values = &values)
			{
				ImPlotNative.PlotPieChartU64PtrPlotFormatter(native_labelIds, native_values, count, x, y, radius, fmt, (void*)fmtData, angle0, flags);
			}
		}

		public static void PlotPieChartFloatPtrStr(ref byte* labelIds, ref float values, int count, double x, double y, double radius, ReadOnlySpan<char> labelFmt, double angle0, ImPlotPieChartFlags flags)
		{
			// Marshaling labelFmt to native string
			byte* native_labelFmt;
			var byteCount_labelFmt = 0;
			if (labelFmt != null)
			{
				byteCount_labelFmt = Encoding.UTF8.GetByteCount(labelFmt);
				if(byteCount_labelFmt > Utils.MaxStackallocSize)
				{
					native_labelFmt = Utils.Alloc<byte>(byteCount_labelFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelFmt + 1];
					native_labelFmt = stackallocBytes;
				}
				var labelFmt_offset = Utils.EncodeStringUTF8(labelFmt, native_labelFmt, byteCount_labelFmt);
				native_labelFmt[labelFmt_offset] = 0;
			}
			else native_labelFmt = null;

			fixed (byte** native_labelIds = &labelIds)
			fixed (float* native_values = &values)
			{
				ImPlotNative.PlotPieChartFloatPtrStr(native_labelIds, native_values, count, x, y, radius, native_labelFmt, angle0, flags);
				// Freeing labelFmt native string
				if (byteCount_labelFmt > Utils.MaxStackallocSize)
					Utils.Free(native_labelFmt);
			}
		}

		public static void PlotPieChartDoublePtrStr(ref byte* labelIds, ref double values, int count, double x, double y, double radius, ReadOnlySpan<char> labelFmt, double angle0, ImPlotPieChartFlags flags)
		{
			// Marshaling labelFmt to native string
			byte* native_labelFmt;
			var byteCount_labelFmt = 0;
			if (labelFmt != null)
			{
				byteCount_labelFmt = Encoding.UTF8.GetByteCount(labelFmt);
				if(byteCount_labelFmt > Utils.MaxStackallocSize)
				{
					native_labelFmt = Utils.Alloc<byte>(byteCount_labelFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelFmt + 1];
					native_labelFmt = stackallocBytes;
				}
				var labelFmt_offset = Utils.EncodeStringUTF8(labelFmt, native_labelFmt, byteCount_labelFmt);
				native_labelFmt[labelFmt_offset] = 0;
			}
			else native_labelFmt = null;

			fixed (byte** native_labelIds = &labelIds)
			fixed (double* native_values = &values)
			{
				ImPlotNative.PlotPieChartDoublePtrStr(native_labelIds, native_values, count, x, y, radius, native_labelFmt, angle0, flags);
				// Freeing labelFmt native string
				if (byteCount_labelFmt > Utils.MaxStackallocSize)
					Utils.Free(native_labelFmt);
			}
		}

		public static void PlotPieChartS8PtrStr(ref byte* labelIds, ref sbyte values, int count, double x, double y, double radius, ReadOnlySpan<char> labelFmt, double angle0, ImPlotPieChartFlags flags)
		{
			// Marshaling labelFmt to native string
			byte* native_labelFmt;
			var byteCount_labelFmt = 0;
			if (labelFmt != null)
			{
				byteCount_labelFmt = Encoding.UTF8.GetByteCount(labelFmt);
				if(byteCount_labelFmt > Utils.MaxStackallocSize)
				{
					native_labelFmt = Utils.Alloc<byte>(byteCount_labelFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelFmt + 1];
					native_labelFmt = stackallocBytes;
				}
				var labelFmt_offset = Utils.EncodeStringUTF8(labelFmt, native_labelFmt, byteCount_labelFmt);
				native_labelFmt[labelFmt_offset] = 0;
			}
			else native_labelFmt = null;

			fixed (byte** native_labelIds = &labelIds)
			fixed (sbyte* native_values = &values)
			{
				ImPlotNative.PlotPieChartS8PtrStr(native_labelIds, native_values, count, x, y, radius, native_labelFmt, angle0, flags);
				// Freeing labelFmt native string
				if (byteCount_labelFmt > Utils.MaxStackallocSize)
					Utils.Free(native_labelFmt);
			}
		}

		public static void PlotPieChartU8PtrStr(ref byte* labelIds, ReadOnlySpan<char> values, int count, double x, double y, double radius, ReadOnlySpan<char> labelFmt, double angle0, ImPlotPieChartFlags flags)
		{
			// Marshaling values to native string
			byte* native_values;
			var byteCount_values = 0;
			if (values != null)
			{
				byteCount_values = Encoding.UTF8.GetByteCount(values);
				if(byteCount_values > Utils.MaxStackallocSize)
				{
					native_values = Utils.Alloc<byte>(byteCount_values + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_values + 1];
					native_values = stackallocBytes;
				}
				var values_offset = Utils.EncodeStringUTF8(values, native_values, byteCount_values);
				native_values[values_offset] = 0;
			}
			else native_values = null;

			// Marshaling labelFmt to native string
			byte* native_labelFmt;
			var byteCount_labelFmt = 0;
			if (labelFmt != null)
			{
				byteCount_labelFmt = Encoding.UTF8.GetByteCount(labelFmt);
				if(byteCount_labelFmt > Utils.MaxStackallocSize)
				{
					native_labelFmt = Utils.Alloc<byte>(byteCount_labelFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelFmt + 1];
					native_labelFmt = stackallocBytes;
				}
				var labelFmt_offset = Utils.EncodeStringUTF8(labelFmt, native_labelFmt, byteCount_labelFmt);
				native_labelFmt[labelFmt_offset] = 0;
			}
			else native_labelFmt = null;

			fixed (byte** native_labelIds = &labelIds)
			{
				ImPlotNative.PlotPieChartU8PtrStr(native_labelIds, native_values, count, x, y, radius, native_labelFmt, angle0, flags);
				// Freeing values native string
				if (byteCount_values > Utils.MaxStackallocSize)
					Utils.Free(native_values);
				// Freeing labelFmt native string
				if (byteCount_labelFmt > Utils.MaxStackallocSize)
					Utils.Free(native_labelFmt);
			}
		}

		public static void PlotPieChartS16PtrStr(ref byte* labelIds, ref short values, int count, double x, double y, double radius, ReadOnlySpan<char> labelFmt, double angle0, ImPlotPieChartFlags flags)
		{
			// Marshaling labelFmt to native string
			byte* native_labelFmt;
			var byteCount_labelFmt = 0;
			if (labelFmt != null)
			{
				byteCount_labelFmt = Encoding.UTF8.GetByteCount(labelFmt);
				if(byteCount_labelFmt > Utils.MaxStackallocSize)
				{
					native_labelFmt = Utils.Alloc<byte>(byteCount_labelFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelFmt + 1];
					native_labelFmt = stackallocBytes;
				}
				var labelFmt_offset = Utils.EncodeStringUTF8(labelFmt, native_labelFmt, byteCount_labelFmt);
				native_labelFmt[labelFmt_offset] = 0;
			}
			else native_labelFmt = null;

			fixed (byte** native_labelIds = &labelIds)
			fixed (short* native_values = &values)
			{
				ImPlotNative.PlotPieChartS16PtrStr(native_labelIds, native_values, count, x, y, radius, native_labelFmt, angle0, flags);
				// Freeing labelFmt native string
				if (byteCount_labelFmt > Utils.MaxStackallocSize)
					Utils.Free(native_labelFmt);
			}
		}

		public static void PlotPieChartU16PtrStr(ref byte* labelIds, ref ushort values, int count, double x, double y, double radius, ReadOnlySpan<char> labelFmt, double angle0, ImPlotPieChartFlags flags)
		{
			// Marshaling labelFmt to native string
			byte* native_labelFmt;
			var byteCount_labelFmt = 0;
			if (labelFmt != null)
			{
				byteCount_labelFmt = Encoding.UTF8.GetByteCount(labelFmt);
				if(byteCount_labelFmt > Utils.MaxStackallocSize)
				{
					native_labelFmt = Utils.Alloc<byte>(byteCount_labelFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelFmt + 1];
					native_labelFmt = stackallocBytes;
				}
				var labelFmt_offset = Utils.EncodeStringUTF8(labelFmt, native_labelFmt, byteCount_labelFmt);
				native_labelFmt[labelFmt_offset] = 0;
			}
			else native_labelFmt = null;

			fixed (byte** native_labelIds = &labelIds)
			fixed (ushort* native_values = &values)
			{
				ImPlotNative.PlotPieChartU16PtrStr(native_labelIds, native_values, count, x, y, radius, native_labelFmt, angle0, flags);
				// Freeing labelFmt native string
				if (byteCount_labelFmt > Utils.MaxStackallocSize)
					Utils.Free(native_labelFmt);
			}
		}

		public static void PlotPieChartS32PtrStr(ref byte* labelIds, ref int values, int count, double x, double y, double radius, ReadOnlySpan<char> labelFmt, double angle0, ImPlotPieChartFlags flags)
		{
			// Marshaling labelFmt to native string
			byte* native_labelFmt;
			var byteCount_labelFmt = 0;
			if (labelFmt != null)
			{
				byteCount_labelFmt = Encoding.UTF8.GetByteCount(labelFmt);
				if(byteCount_labelFmt > Utils.MaxStackallocSize)
				{
					native_labelFmt = Utils.Alloc<byte>(byteCount_labelFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelFmt + 1];
					native_labelFmt = stackallocBytes;
				}
				var labelFmt_offset = Utils.EncodeStringUTF8(labelFmt, native_labelFmt, byteCount_labelFmt);
				native_labelFmt[labelFmt_offset] = 0;
			}
			else native_labelFmt = null;

			fixed (byte** native_labelIds = &labelIds)
			fixed (int* native_values = &values)
			{
				ImPlotNative.PlotPieChartS32PtrStr(native_labelIds, native_values, count, x, y, radius, native_labelFmt, angle0, flags);
				// Freeing labelFmt native string
				if (byteCount_labelFmt > Utils.MaxStackallocSize)
					Utils.Free(native_labelFmt);
			}
		}

		public static void PlotPieChartU32PtrStr(ref byte* labelIds, ref uint values, int count, double x, double y, double radius, ReadOnlySpan<char> labelFmt, double angle0, ImPlotPieChartFlags flags)
		{
			// Marshaling labelFmt to native string
			byte* native_labelFmt;
			var byteCount_labelFmt = 0;
			if (labelFmt != null)
			{
				byteCount_labelFmt = Encoding.UTF8.GetByteCount(labelFmt);
				if(byteCount_labelFmt > Utils.MaxStackallocSize)
				{
					native_labelFmt = Utils.Alloc<byte>(byteCount_labelFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelFmt + 1];
					native_labelFmt = stackallocBytes;
				}
				var labelFmt_offset = Utils.EncodeStringUTF8(labelFmt, native_labelFmt, byteCount_labelFmt);
				native_labelFmt[labelFmt_offset] = 0;
			}
			else native_labelFmt = null;

			fixed (byte** native_labelIds = &labelIds)
			fixed (uint* native_values = &values)
			{
				ImPlotNative.PlotPieChartU32PtrStr(native_labelIds, native_values, count, x, y, radius, native_labelFmt, angle0, flags);
				// Freeing labelFmt native string
				if (byteCount_labelFmt > Utils.MaxStackallocSize)
					Utils.Free(native_labelFmt);
			}
		}

		public static void PlotPieChartS64PtrStr(ref byte* labelIds, ref long values, int count, double x, double y, double radius, ReadOnlySpan<char> labelFmt, double angle0, ImPlotPieChartFlags flags)
		{
			// Marshaling labelFmt to native string
			byte* native_labelFmt;
			var byteCount_labelFmt = 0;
			if (labelFmt != null)
			{
				byteCount_labelFmt = Encoding.UTF8.GetByteCount(labelFmt);
				if(byteCount_labelFmt > Utils.MaxStackallocSize)
				{
					native_labelFmt = Utils.Alloc<byte>(byteCount_labelFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelFmt + 1];
					native_labelFmt = stackallocBytes;
				}
				var labelFmt_offset = Utils.EncodeStringUTF8(labelFmt, native_labelFmt, byteCount_labelFmt);
				native_labelFmt[labelFmt_offset] = 0;
			}
			else native_labelFmt = null;

			fixed (byte** native_labelIds = &labelIds)
			fixed (long* native_values = &values)
			{
				ImPlotNative.PlotPieChartS64PtrStr(native_labelIds, native_values, count, x, y, radius, native_labelFmt, angle0, flags);
				// Freeing labelFmt native string
				if (byteCount_labelFmt > Utils.MaxStackallocSize)
					Utils.Free(native_labelFmt);
			}
		}

		public static void PlotPieChartU64PtrStr(ref byte* labelIds, ref ulong values, int count, double x, double y, double radius, ReadOnlySpan<char> labelFmt, double angle0, ImPlotPieChartFlags flags)
		{
			// Marshaling labelFmt to native string
			byte* native_labelFmt;
			var byteCount_labelFmt = 0;
			if (labelFmt != null)
			{
				byteCount_labelFmt = Encoding.UTF8.GetByteCount(labelFmt);
				if(byteCount_labelFmt > Utils.MaxStackallocSize)
				{
					native_labelFmt = Utils.Alloc<byte>(byteCount_labelFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelFmt + 1];
					native_labelFmt = stackallocBytes;
				}
				var labelFmt_offset = Utils.EncodeStringUTF8(labelFmt, native_labelFmt, byteCount_labelFmt);
				native_labelFmt[labelFmt_offset] = 0;
			}
			else native_labelFmt = null;

			fixed (byte** native_labelIds = &labelIds)
			fixed (ulong* native_values = &values)
			{
				ImPlotNative.PlotPieChartU64PtrStr(native_labelIds, native_values, count, x, y, radius, native_labelFmt, angle0, flags);
				// Freeing labelFmt native string
				if (byteCount_labelFmt > Utils.MaxStackallocSize)
					Utils.Free(native_labelFmt);
			}
		}

		public static void PlotHeatmapFloatPtr(ReadOnlySpan<char> labelId, ref float values, int rows, int cols, double scaleMin, double scaleMax, ReadOnlySpan<char> labelFmt, ImPlotPoint boundsMin, ImPlotPoint boundsMax, ImPlotHeatmapFlags flags)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			// Marshaling labelFmt to native string
			byte* native_labelFmt;
			var byteCount_labelFmt = 0;
			if (labelFmt != null)
			{
				byteCount_labelFmt = Encoding.UTF8.GetByteCount(labelFmt);
				if(byteCount_labelFmt > Utils.MaxStackallocSize)
				{
					native_labelFmt = Utils.Alloc<byte>(byteCount_labelFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelFmt + 1];
					native_labelFmt = stackallocBytes;
				}
				var labelFmt_offset = Utils.EncodeStringUTF8(labelFmt, native_labelFmt, byteCount_labelFmt);
				native_labelFmt[labelFmt_offset] = 0;
			}
			else native_labelFmt = null;

			fixed (float* native_values = &values)
			{
				ImPlotNative.PlotHeatmapFloatPtr(native_labelId, native_values, rows, cols, scaleMin, scaleMax, native_labelFmt, boundsMin, boundsMax, flags);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
				// Freeing labelFmt native string
				if (byteCount_labelFmt > Utils.MaxStackallocSize)
					Utils.Free(native_labelFmt);
			}
		}

		public static void PlotHeatmapDoublePtr(ReadOnlySpan<char> labelId, ref double values, int rows, int cols, double scaleMin, double scaleMax, ReadOnlySpan<char> labelFmt, ImPlotPoint boundsMin, ImPlotPoint boundsMax, ImPlotHeatmapFlags flags)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			// Marshaling labelFmt to native string
			byte* native_labelFmt;
			var byteCount_labelFmt = 0;
			if (labelFmt != null)
			{
				byteCount_labelFmt = Encoding.UTF8.GetByteCount(labelFmt);
				if(byteCount_labelFmt > Utils.MaxStackallocSize)
				{
					native_labelFmt = Utils.Alloc<byte>(byteCount_labelFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelFmt + 1];
					native_labelFmt = stackallocBytes;
				}
				var labelFmt_offset = Utils.EncodeStringUTF8(labelFmt, native_labelFmt, byteCount_labelFmt);
				native_labelFmt[labelFmt_offset] = 0;
			}
			else native_labelFmt = null;

			fixed (double* native_values = &values)
			{
				ImPlotNative.PlotHeatmapDoublePtr(native_labelId, native_values, rows, cols, scaleMin, scaleMax, native_labelFmt, boundsMin, boundsMax, flags);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
				// Freeing labelFmt native string
				if (byteCount_labelFmt > Utils.MaxStackallocSize)
					Utils.Free(native_labelFmt);
			}
		}

		public static void PlotHeatmapS8Ptr(ReadOnlySpan<char> labelId, ref sbyte values, int rows, int cols, double scaleMin, double scaleMax, ReadOnlySpan<char> labelFmt, ImPlotPoint boundsMin, ImPlotPoint boundsMax, ImPlotHeatmapFlags flags)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			// Marshaling labelFmt to native string
			byte* native_labelFmt;
			var byteCount_labelFmt = 0;
			if (labelFmt != null)
			{
				byteCount_labelFmt = Encoding.UTF8.GetByteCount(labelFmt);
				if(byteCount_labelFmt > Utils.MaxStackallocSize)
				{
					native_labelFmt = Utils.Alloc<byte>(byteCount_labelFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelFmt + 1];
					native_labelFmt = stackallocBytes;
				}
				var labelFmt_offset = Utils.EncodeStringUTF8(labelFmt, native_labelFmt, byteCount_labelFmt);
				native_labelFmt[labelFmt_offset] = 0;
			}
			else native_labelFmt = null;

			fixed (sbyte* native_values = &values)
			{
				ImPlotNative.PlotHeatmapS8Ptr(native_labelId, native_values, rows, cols, scaleMin, scaleMax, native_labelFmt, boundsMin, boundsMax, flags);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
				// Freeing labelFmt native string
				if (byteCount_labelFmt > Utils.MaxStackallocSize)
					Utils.Free(native_labelFmt);
			}
		}

		public static void PlotHeatmapU8Ptr(ReadOnlySpan<char> labelId, ReadOnlySpan<char> values, int rows, int cols, double scaleMin, double scaleMax, ReadOnlySpan<char> labelFmt, ImPlotPoint boundsMin, ImPlotPoint boundsMax, ImPlotHeatmapFlags flags)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			// Marshaling values to native string
			byte* native_values;
			var byteCount_values = 0;
			if (values != null)
			{
				byteCount_values = Encoding.UTF8.GetByteCount(values);
				if(byteCount_values > Utils.MaxStackallocSize)
				{
					native_values = Utils.Alloc<byte>(byteCount_values + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_values + 1];
					native_values = stackallocBytes;
				}
				var values_offset = Utils.EncodeStringUTF8(values, native_values, byteCount_values);
				native_values[values_offset] = 0;
			}
			else native_values = null;

			// Marshaling labelFmt to native string
			byte* native_labelFmt;
			var byteCount_labelFmt = 0;
			if (labelFmt != null)
			{
				byteCount_labelFmt = Encoding.UTF8.GetByteCount(labelFmt);
				if(byteCount_labelFmt > Utils.MaxStackallocSize)
				{
					native_labelFmt = Utils.Alloc<byte>(byteCount_labelFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelFmt + 1];
					native_labelFmt = stackallocBytes;
				}
				var labelFmt_offset = Utils.EncodeStringUTF8(labelFmt, native_labelFmt, byteCount_labelFmt);
				native_labelFmt[labelFmt_offset] = 0;
			}
			else native_labelFmt = null;

			ImPlotNative.PlotHeatmapU8Ptr(native_labelId, native_values, rows, cols, scaleMin, scaleMax, native_labelFmt, boundsMin, boundsMax, flags);
			// Freeing labelId native string
			if (byteCount_labelId > Utils.MaxStackallocSize)
				Utils.Free(native_labelId);
			// Freeing values native string
			if (byteCount_values > Utils.MaxStackallocSize)
				Utils.Free(native_values);
			// Freeing labelFmt native string
			if (byteCount_labelFmt > Utils.MaxStackallocSize)
				Utils.Free(native_labelFmt);
		}

		public static void PlotHeatmapS16Ptr(ReadOnlySpan<char> labelId, ref short values, int rows, int cols, double scaleMin, double scaleMax, ReadOnlySpan<char> labelFmt, ImPlotPoint boundsMin, ImPlotPoint boundsMax, ImPlotHeatmapFlags flags)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			// Marshaling labelFmt to native string
			byte* native_labelFmt;
			var byteCount_labelFmt = 0;
			if (labelFmt != null)
			{
				byteCount_labelFmt = Encoding.UTF8.GetByteCount(labelFmt);
				if(byteCount_labelFmt > Utils.MaxStackallocSize)
				{
					native_labelFmt = Utils.Alloc<byte>(byteCount_labelFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelFmt + 1];
					native_labelFmt = stackallocBytes;
				}
				var labelFmt_offset = Utils.EncodeStringUTF8(labelFmt, native_labelFmt, byteCount_labelFmt);
				native_labelFmt[labelFmt_offset] = 0;
			}
			else native_labelFmt = null;

			fixed (short* native_values = &values)
			{
				ImPlotNative.PlotHeatmapS16Ptr(native_labelId, native_values, rows, cols, scaleMin, scaleMax, native_labelFmt, boundsMin, boundsMax, flags);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
				// Freeing labelFmt native string
				if (byteCount_labelFmt > Utils.MaxStackallocSize)
					Utils.Free(native_labelFmt);
			}
		}

		public static void PlotHeatmapU16Ptr(ReadOnlySpan<char> labelId, ref ushort values, int rows, int cols, double scaleMin, double scaleMax, ReadOnlySpan<char> labelFmt, ImPlotPoint boundsMin, ImPlotPoint boundsMax, ImPlotHeatmapFlags flags)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			// Marshaling labelFmt to native string
			byte* native_labelFmt;
			var byteCount_labelFmt = 0;
			if (labelFmt != null)
			{
				byteCount_labelFmt = Encoding.UTF8.GetByteCount(labelFmt);
				if(byteCount_labelFmt > Utils.MaxStackallocSize)
				{
					native_labelFmt = Utils.Alloc<byte>(byteCount_labelFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelFmt + 1];
					native_labelFmt = stackallocBytes;
				}
				var labelFmt_offset = Utils.EncodeStringUTF8(labelFmt, native_labelFmt, byteCount_labelFmt);
				native_labelFmt[labelFmt_offset] = 0;
			}
			else native_labelFmt = null;

			fixed (ushort* native_values = &values)
			{
				ImPlotNative.PlotHeatmapU16Ptr(native_labelId, native_values, rows, cols, scaleMin, scaleMax, native_labelFmt, boundsMin, boundsMax, flags);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
				// Freeing labelFmt native string
				if (byteCount_labelFmt > Utils.MaxStackallocSize)
					Utils.Free(native_labelFmt);
			}
		}

		public static void PlotHeatmapS32Ptr(ReadOnlySpan<char> labelId, ref int values, int rows, int cols, double scaleMin, double scaleMax, ReadOnlySpan<char> labelFmt, ImPlotPoint boundsMin, ImPlotPoint boundsMax, ImPlotHeatmapFlags flags)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			// Marshaling labelFmt to native string
			byte* native_labelFmt;
			var byteCount_labelFmt = 0;
			if (labelFmt != null)
			{
				byteCount_labelFmt = Encoding.UTF8.GetByteCount(labelFmt);
				if(byteCount_labelFmt > Utils.MaxStackallocSize)
				{
					native_labelFmt = Utils.Alloc<byte>(byteCount_labelFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelFmt + 1];
					native_labelFmt = stackallocBytes;
				}
				var labelFmt_offset = Utils.EncodeStringUTF8(labelFmt, native_labelFmt, byteCount_labelFmt);
				native_labelFmt[labelFmt_offset] = 0;
			}
			else native_labelFmt = null;

			fixed (int* native_values = &values)
			{
				ImPlotNative.PlotHeatmapS32Ptr(native_labelId, native_values, rows, cols, scaleMin, scaleMax, native_labelFmt, boundsMin, boundsMax, flags);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
				// Freeing labelFmt native string
				if (byteCount_labelFmt > Utils.MaxStackallocSize)
					Utils.Free(native_labelFmt);
			}
		}

		public static void PlotHeatmapU32Ptr(ReadOnlySpan<char> labelId, ref uint values, int rows, int cols, double scaleMin, double scaleMax, ReadOnlySpan<char> labelFmt, ImPlotPoint boundsMin, ImPlotPoint boundsMax, ImPlotHeatmapFlags flags)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			// Marshaling labelFmt to native string
			byte* native_labelFmt;
			var byteCount_labelFmt = 0;
			if (labelFmt != null)
			{
				byteCount_labelFmt = Encoding.UTF8.GetByteCount(labelFmt);
				if(byteCount_labelFmt > Utils.MaxStackallocSize)
				{
					native_labelFmt = Utils.Alloc<byte>(byteCount_labelFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelFmt + 1];
					native_labelFmt = stackallocBytes;
				}
				var labelFmt_offset = Utils.EncodeStringUTF8(labelFmt, native_labelFmt, byteCount_labelFmt);
				native_labelFmt[labelFmt_offset] = 0;
			}
			else native_labelFmt = null;

			fixed (uint* native_values = &values)
			{
				ImPlotNative.PlotHeatmapU32Ptr(native_labelId, native_values, rows, cols, scaleMin, scaleMax, native_labelFmt, boundsMin, boundsMax, flags);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
				// Freeing labelFmt native string
				if (byteCount_labelFmt > Utils.MaxStackallocSize)
					Utils.Free(native_labelFmt);
			}
		}

		public static void PlotHeatmapS64Ptr(ReadOnlySpan<char> labelId, ref long values, int rows, int cols, double scaleMin, double scaleMax, ReadOnlySpan<char> labelFmt, ImPlotPoint boundsMin, ImPlotPoint boundsMax, ImPlotHeatmapFlags flags)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			// Marshaling labelFmt to native string
			byte* native_labelFmt;
			var byteCount_labelFmt = 0;
			if (labelFmt != null)
			{
				byteCount_labelFmt = Encoding.UTF8.GetByteCount(labelFmt);
				if(byteCount_labelFmt > Utils.MaxStackallocSize)
				{
					native_labelFmt = Utils.Alloc<byte>(byteCount_labelFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelFmt + 1];
					native_labelFmt = stackallocBytes;
				}
				var labelFmt_offset = Utils.EncodeStringUTF8(labelFmt, native_labelFmt, byteCount_labelFmt);
				native_labelFmt[labelFmt_offset] = 0;
			}
			else native_labelFmt = null;

			fixed (long* native_values = &values)
			{
				ImPlotNative.PlotHeatmapS64Ptr(native_labelId, native_values, rows, cols, scaleMin, scaleMax, native_labelFmt, boundsMin, boundsMax, flags);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
				// Freeing labelFmt native string
				if (byteCount_labelFmt > Utils.MaxStackallocSize)
					Utils.Free(native_labelFmt);
			}
		}

		public static void PlotHeatmapU64Ptr(ReadOnlySpan<char> labelId, ref ulong values, int rows, int cols, double scaleMin, double scaleMax, ReadOnlySpan<char> labelFmt, ImPlotPoint boundsMin, ImPlotPoint boundsMax, ImPlotHeatmapFlags flags)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			// Marshaling labelFmt to native string
			byte* native_labelFmt;
			var byteCount_labelFmt = 0;
			if (labelFmt != null)
			{
				byteCount_labelFmt = Encoding.UTF8.GetByteCount(labelFmt);
				if(byteCount_labelFmt > Utils.MaxStackallocSize)
				{
					native_labelFmt = Utils.Alloc<byte>(byteCount_labelFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelFmt + 1];
					native_labelFmt = stackallocBytes;
				}
				var labelFmt_offset = Utils.EncodeStringUTF8(labelFmt, native_labelFmt, byteCount_labelFmt);
				native_labelFmt[labelFmt_offset] = 0;
			}
			else native_labelFmt = null;

			fixed (ulong* native_values = &values)
			{
				ImPlotNative.PlotHeatmapU64Ptr(native_labelId, native_values, rows, cols, scaleMin, scaleMax, native_labelFmt, boundsMin, boundsMax, flags);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
				// Freeing labelFmt native string
				if (byteCount_labelFmt > Utils.MaxStackallocSize)
					Utils.Free(native_labelFmt);
			}
		}

		public static double PlotHistogramFloatPtr(ReadOnlySpan<char> labelId, ref float values, int count, int bins, double barScale, ImPlotRange range, ImPlotHistogramFlags flags)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (float* native_values = &values)
			{
				var result = ImPlotNative.PlotHistogramFloatPtr(native_labelId, native_values, count, bins, barScale, range, flags);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
				return result;
			}
		}

		public static double PlotHistogramDoublePtr(ReadOnlySpan<char> labelId, ref double values, int count, int bins, double barScale, ImPlotRange range, ImPlotHistogramFlags flags)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (double* native_values = &values)
			{
				var result = ImPlotNative.PlotHistogramDoublePtr(native_labelId, native_values, count, bins, barScale, range, flags);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
				return result;
			}
		}

		public static double PlotHistogramS8Ptr(ReadOnlySpan<char> labelId, ref sbyte values, int count, int bins, double barScale, ImPlotRange range, ImPlotHistogramFlags flags)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (sbyte* native_values = &values)
			{
				var result = ImPlotNative.PlotHistogramS8Ptr(native_labelId, native_values, count, bins, barScale, range, flags);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
				return result;
			}
		}

		public static double PlotHistogramU8Ptr(ReadOnlySpan<char> labelId, ReadOnlySpan<char> values, int count, int bins, double barScale, ImPlotRange range, ImPlotHistogramFlags flags)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			// Marshaling values to native string
			byte* native_values;
			var byteCount_values = 0;
			if (values != null)
			{
				byteCount_values = Encoding.UTF8.GetByteCount(values);
				if(byteCount_values > Utils.MaxStackallocSize)
				{
					native_values = Utils.Alloc<byte>(byteCount_values + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_values + 1];
					native_values = stackallocBytes;
				}
				var values_offset = Utils.EncodeStringUTF8(values, native_values, byteCount_values);
				native_values[values_offset] = 0;
			}
			else native_values = null;

			return ImPlotNative.PlotHistogramU8Ptr(native_labelId, native_values, count, bins, barScale, range, flags);
			// Freeing labelId native string
			if (byteCount_labelId > Utils.MaxStackallocSize)
				Utils.Free(native_labelId);
			// Freeing values native string
			if (byteCount_values > Utils.MaxStackallocSize)
				Utils.Free(native_values);
		}

		public static double PlotHistogramS16Ptr(ReadOnlySpan<char> labelId, ref short values, int count, int bins, double barScale, ImPlotRange range, ImPlotHistogramFlags flags)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (short* native_values = &values)
			{
				var result = ImPlotNative.PlotHistogramS16Ptr(native_labelId, native_values, count, bins, barScale, range, flags);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
				return result;
			}
		}

		public static double PlotHistogramU16Ptr(ReadOnlySpan<char> labelId, ref ushort values, int count, int bins, double barScale, ImPlotRange range, ImPlotHistogramFlags flags)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (ushort* native_values = &values)
			{
				var result = ImPlotNative.PlotHistogramU16Ptr(native_labelId, native_values, count, bins, barScale, range, flags);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
				return result;
			}
		}

		public static double PlotHistogramS32Ptr(ReadOnlySpan<char> labelId, ref int values, int count, int bins, double barScale, ImPlotRange range, ImPlotHistogramFlags flags)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (int* native_values = &values)
			{
				var result = ImPlotNative.PlotHistogramS32Ptr(native_labelId, native_values, count, bins, barScale, range, flags);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
				return result;
			}
		}

		public static double PlotHistogramU32Ptr(ReadOnlySpan<char> labelId, ref uint values, int count, int bins, double barScale, ImPlotRange range, ImPlotHistogramFlags flags)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (uint* native_values = &values)
			{
				var result = ImPlotNative.PlotHistogramU32Ptr(native_labelId, native_values, count, bins, barScale, range, flags);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
				return result;
			}
		}

		public static double PlotHistogramS64Ptr(ReadOnlySpan<char> labelId, ref long values, int count, int bins, double barScale, ImPlotRange range, ImPlotHistogramFlags flags)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (long* native_values = &values)
			{
				var result = ImPlotNative.PlotHistogramS64Ptr(native_labelId, native_values, count, bins, barScale, range, flags);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
				return result;
			}
		}

		public static double PlotHistogramU64Ptr(ReadOnlySpan<char> labelId, ref ulong values, int count, int bins, double barScale, ImPlotRange range, ImPlotHistogramFlags flags)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (ulong* native_values = &values)
			{
				var result = ImPlotNative.PlotHistogramU64Ptr(native_labelId, native_values, count, bins, barScale, range, flags);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
				return result;
			}
		}

		public static double PlotHistogram2DFloatPtr(ReadOnlySpan<char> labelId, ref float xs, ref float ys, int count, int xBins, int yBins, ImPlotRect range, ImPlotHistogramFlags flags)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (float* native_xs = &xs)
			fixed (float* native_ys = &ys)
			{
				var result = ImPlotNative.PlotHistogram2DFloatPtr(native_labelId, native_xs, native_ys, count, xBins, yBins, range, flags);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
				return result;
			}
		}

		public static double PlotHistogram2DDoublePtr(ReadOnlySpan<char> labelId, ref double xs, ref double ys, int count, int xBins, int yBins, ImPlotRect range, ImPlotHistogramFlags flags)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (double* native_xs = &xs)
			fixed (double* native_ys = &ys)
			{
				var result = ImPlotNative.PlotHistogram2DDoublePtr(native_labelId, native_xs, native_ys, count, xBins, yBins, range, flags);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
				return result;
			}
		}

		public static double PlotHistogram2DS8Ptr(ReadOnlySpan<char> labelId, ref sbyte xs, ref sbyte ys, int count, int xBins, int yBins, ImPlotRect range, ImPlotHistogramFlags flags)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (sbyte* native_xs = &xs)
			fixed (sbyte* native_ys = &ys)
			{
				var result = ImPlotNative.PlotHistogram2DS8Ptr(native_labelId, native_xs, native_ys, count, xBins, yBins, range, flags);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
				return result;
			}
		}

		public static double PlotHistogram2DU8Ptr(ReadOnlySpan<char> labelId, ReadOnlySpan<char> xs, ReadOnlySpan<char> ys, int count, int xBins, int yBins, ImPlotRect range, ImPlotHistogramFlags flags)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			// Marshaling xs to native string
			byte* native_xs;
			var byteCount_xs = 0;
			if (xs != null)
			{
				byteCount_xs = Encoding.UTF8.GetByteCount(xs);
				if(byteCount_xs > Utils.MaxStackallocSize)
				{
					native_xs = Utils.Alloc<byte>(byteCount_xs + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_xs + 1];
					native_xs = stackallocBytes;
				}
				var xs_offset = Utils.EncodeStringUTF8(xs, native_xs, byteCount_xs);
				native_xs[xs_offset] = 0;
			}
			else native_xs = null;

			// Marshaling ys to native string
			byte* native_ys;
			var byteCount_ys = 0;
			if (ys != null)
			{
				byteCount_ys = Encoding.UTF8.GetByteCount(ys);
				if(byteCount_ys > Utils.MaxStackallocSize)
				{
					native_ys = Utils.Alloc<byte>(byteCount_ys + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_ys + 1];
					native_ys = stackallocBytes;
				}
				var ys_offset = Utils.EncodeStringUTF8(ys, native_ys, byteCount_ys);
				native_ys[ys_offset] = 0;
			}
			else native_ys = null;

			return ImPlotNative.PlotHistogram2DU8Ptr(native_labelId, native_xs, native_ys, count, xBins, yBins, range, flags);
			// Freeing labelId native string
			if (byteCount_labelId > Utils.MaxStackallocSize)
				Utils.Free(native_labelId);
			// Freeing xs native string
			if (byteCount_xs > Utils.MaxStackallocSize)
				Utils.Free(native_xs);
			// Freeing ys native string
			if (byteCount_ys > Utils.MaxStackallocSize)
				Utils.Free(native_ys);
		}

		public static double PlotHistogram2DS16Ptr(ReadOnlySpan<char> labelId, ref short xs, ref short ys, int count, int xBins, int yBins, ImPlotRect range, ImPlotHistogramFlags flags)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (short* native_xs = &xs)
			fixed (short* native_ys = &ys)
			{
				var result = ImPlotNative.PlotHistogram2DS16Ptr(native_labelId, native_xs, native_ys, count, xBins, yBins, range, flags);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
				return result;
			}
		}

		public static double PlotHistogram2DU16Ptr(ReadOnlySpan<char> labelId, ref ushort xs, ref ushort ys, int count, int xBins, int yBins, ImPlotRect range, ImPlotHistogramFlags flags)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (ushort* native_xs = &xs)
			fixed (ushort* native_ys = &ys)
			{
				var result = ImPlotNative.PlotHistogram2DU16Ptr(native_labelId, native_xs, native_ys, count, xBins, yBins, range, flags);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
				return result;
			}
		}

		public static double PlotHistogram2DS32Ptr(ReadOnlySpan<char> labelId, ref int xs, ref int ys, int count, int xBins, int yBins, ImPlotRect range, ImPlotHistogramFlags flags)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (int* native_xs = &xs)
			fixed (int* native_ys = &ys)
			{
				var result = ImPlotNative.PlotHistogram2DS32Ptr(native_labelId, native_xs, native_ys, count, xBins, yBins, range, flags);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
				return result;
			}
		}

		public static double PlotHistogram2DU32Ptr(ReadOnlySpan<char> labelId, ref uint xs, ref uint ys, int count, int xBins, int yBins, ImPlotRect range, ImPlotHistogramFlags flags)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (uint* native_xs = &xs)
			fixed (uint* native_ys = &ys)
			{
				var result = ImPlotNative.PlotHistogram2DU32Ptr(native_labelId, native_xs, native_ys, count, xBins, yBins, range, flags);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
				return result;
			}
		}

		public static double PlotHistogram2DS64Ptr(ReadOnlySpan<char> labelId, ref long xs, ref long ys, int count, int xBins, int yBins, ImPlotRect range, ImPlotHistogramFlags flags)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (long* native_xs = &xs)
			fixed (long* native_ys = &ys)
			{
				var result = ImPlotNative.PlotHistogram2DS64Ptr(native_labelId, native_xs, native_ys, count, xBins, yBins, range, flags);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
				return result;
			}
		}

		public static double PlotHistogram2DU64Ptr(ReadOnlySpan<char> labelId, ref ulong xs, ref ulong ys, int count, int xBins, int yBins, ImPlotRect range, ImPlotHistogramFlags flags)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (ulong* native_xs = &xs)
			fixed (ulong* native_ys = &ys)
			{
				var result = ImPlotNative.PlotHistogram2DU64Ptr(native_labelId, native_xs, native_ys, count, xBins, yBins, range, flags);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
				return result;
			}
		}

		public static void PlotDigitalFloatPtr(ReadOnlySpan<char> labelId, ref float xs, ref float ys, int count, ImPlotDigitalFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (float* native_xs = &xs)
			fixed (float* native_ys = &ys)
			{
				ImPlotNative.PlotDigitalFloatPtr(native_labelId, native_xs, native_ys, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotDigitalDoublePtr(ReadOnlySpan<char> labelId, ref double xs, ref double ys, int count, ImPlotDigitalFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (double* native_xs = &xs)
			fixed (double* native_ys = &ys)
			{
				ImPlotNative.PlotDigitalDoublePtr(native_labelId, native_xs, native_ys, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotDigitalS8Ptr(ReadOnlySpan<char> labelId, ref sbyte xs, ref sbyte ys, int count, ImPlotDigitalFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (sbyte* native_xs = &xs)
			fixed (sbyte* native_ys = &ys)
			{
				ImPlotNative.PlotDigitalS8Ptr(native_labelId, native_xs, native_ys, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotDigitalU8Ptr(ReadOnlySpan<char> labelId, ReadOnlySpan<char> xs, ReadOnlySpan<char> ys, int count, ImPlotDigitalFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			// Marshaling xs to native string
			byte* native_xs;
			var byteCount_xs = 0;
			if (xs != null)
			{
				byteCount_xs = Encoding.UTF8.GetByteCount(xs);
				if(byteCount_xs > Utils.MaxStackallocSize)
				{
					native_xs = Utils.Alloc<byte>(byteCount_xs + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_xs + 1];
					native_xs = stackallocBytes;
				}
				var xs_offset = Utils.EncodeStringUTF8(xs, native_xs, byteCount_xs);
				native_xs[xs_offset] = 0;
			}
			else native_xs = null;

			// Marshaling ys to native string
			byte* native_ys;
			var byteCount_ys = 0;
			if (ys != null)
			{
				byteCount_ys = Encoding.UTF8.GetByteCount(ys);
				if(byteCount_ys > Utils.MaxStackallocSize)
				{
					native_ys = Utils.Alloc<byte>(byteCount_ys + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_ys + 1];
					native_ys = stackallocBytes;
				}
				var ys_offset = Utils.EncodeStringUTF8(ys, native_ys, byteCount_ys);
				native_ys[ys_offset] = 0;
			}
			else native_ys = null;

			ImPlotNative.PlotDigitalU8Ptr(native_labelId, native_xs, native_ys, count, flags, offset, stride);
			// Freeing labelId native string
			if (byteCount_labelId > Utils.MaxStackallocSize)
				Utils.Free(native_labelId);
			// Freeing xs native string
			if (byteCount_xs > Utils.MaxStackallocSize)
				Utils.Free(native_xs);
			// Freeing ys native string
			if (byteCount_ys > Utils.MaxStackallocSize)
				Utils.Free(native_ys);
		}

		public static void PlotDigitalS16Ptr(ReadOnlySpan<char> labelId, ref short xs, ref short ys, int count, ImPlotDigitalFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (short* native_xs = &xs)
			fixed (short* native_ys = &ys)
			{
				ImPlotNative.PlotDigitalS16Ptr(native_labelId, native_xs, native_ys, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotDigitalU16Ptr(ReadOnlySpan<char> labelId, ref ushort xs, ref ushort ys, int count, ImPlotDigitalFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (ushort* native_xs = &xs)
			fixed (ushort* native_ys = &ys)
			{
				ImPlotNative.PlotDigitalU16Ptr(native_labelId, native_xs, native_ys, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotDigitalS32Ptr(ReadOnlySpan<char> labelId, ref int xs, ref int ys, int count, ImPlotDigitalFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (int* native_xs = &xs)
			fixed (int* native_ys = &ys)
			{
				ImPlotNative.PlotDigitalS32Ptr(native_labelId, native_xs, native_ys, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotDigitalU32Ptr(ReadOnlySpan<char> labelId, ref uint xs, ref uint ys, int count, ImPlotDigitalFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (uint* native_xs = &xs)
			fixed (uint* native_ys = &ys)
			{
				ImPlotNative.PlotDigitalU32Ptr(native_labelId, native_xs, native_ys, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotDigitalS64Ptr(ReadOnlySpan<char> labelId, ref long xs, ref long ys, int count, ImPlotDigitalFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (long* native_xs = &xs)
			fixed (long* native_ys = &ys)
			{
				ImPlotNative.PlotDigitalS64Ptr(native_labelId, native_xs, native_ys, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotDigitalU64Ptr(ReadOnlySpan<char> labelId, ref ulong xs, ref ulong ys, int count, ImPlotDigitalFlags flags, int offset, int stride)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			fixed (ulong* native_xs = &xs)
			fixed (ulong* native_ys = &ys)
			{
				ImPlotNative.PlotDigitalU64Ptr(native_labelId, native_xs, native_ys, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotDigitalG(ReadOnlySpan<char> labelId, ImPlotPointGetter getter, IntPtr data, int count, ImPlotDigitalFlags flags)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			ImPlotNative.PlotDigitalG(native_labelId, getter, (void*)data, count, flags);
			// Freeing labelId native string
			if (byteCount_labelId > Utils.MaxStackallocSize)
				Utils.Free(native_labelId);
		}

		public static void PlotImage(ReadOnlySpan<char> labelId, ulong userTextureId, ImPlotPoint boundsMin, ImPlotPoint boundsMax, Vector2 uv0, Vector2 uv1, Vector4 tintCol, ImPlotImageFlags flags)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			ImPlotNative.PlotImage(native_labelId, userTextureId, boundsMin, boundsMax, uv0, uv1, tintCol, flags);
			// Freeing labelId native string
			if (byteCount_labelId > Utils.MaxStackallocSize)
				Utils.Free(native_labelId);
		}

		public static void PlotText(ReadOnlySpan<char> text, double x, double y, Vector2 pixOffset, ImPlotTextFlags flags)
		{
			// Marshaling text to native string
			byte* native_text;
			var byteCount_text = 0;
			if (text != null)
			{
				byteCount_text = Encoding.UTF8.GetByteCount(text);
				if(byteCount_text > Utils.MaxStackallocSize)
				{
					native_text = Utils.Alloc<byte>(byteCount_text + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_text + 1];
					native_text = stackallocBytes;
				}
				var text_offset = Utils.EncodeStringUTF8(text, native_text, byteCount_text);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			ImPlotNative.PlotText(native_text, x, y, pixOffset, flags);
			// Freeing text native string
			if (byteCount_text > Utils.MaxStackallocSize)
				Utils.Free(native_text);
		}

		public static void PlotDummy(ReadOnlySpan<char> labelId, ImPlotDummyFlags flags)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			ImPlotNative.PlotDummy(native_labelId, flags);
			// Freeing labelId native string
			if (byteCount_labelId > Utils.MaxStackallocSize)
				Utils.Free(native_labelId);
		}

		public static byte DragPoint(int id, ref double x, ref double y, Vector4 col, float size, ImPlotDragToolFlags flags, ReadOnlySpan<char> outClicked, ReadOnlySpan<char> outHovered, ReadOnlySpan<char> held)
		{
			// Marshaling outClicked to native string
			byte* native_outClicked;
			var byteCount_outClicked = 0;
			if (outClicked != null)
			{
				byteCount_outClicked = Encoding.UTF8.GetByteCount(outClicked);
				if(byteCount_outClicked > Utils.MaxStackallocSize)
				{
					native_outClicked = Utils.Alloc<byte>(byteCount_outClicked + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_outClicked + 1];
					native_outClicked = stackallocBytes;
				}
				var outClicked_offset = Utils.EncodeStringUTF8(outClicked, native_outClicked, byteCount_outClicked);
				native_outClicked[outClicked_offset] = 0;
			}
			else native_outClicked = null;

			// Marshaling outHovered to native string
			byte* native_outHovered;
			var byteCount_outHovered = 0;
			if (outHovered != null)
			{
				byteCount_outHovered = Encoding.UTF8.GetByteCount(outHovered);
				if(byteCount_outHovered > Utils.MaxStackallocSize)
				{
					native_outHovered = Utils.Alloc<byte>(byteCount_outHovered + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_outHovered + 1];
					native_outHovered = stackallocBytes;
				}
				var outHovered_offset = Utils.EncodeStringUTF8(outHovered, native_outHovered, byteCount_outHovered);
				native_outHovered[outHovered_offset] = 0;
			}
			else native_outHovered = null;

			// Marshaling held to native string
			byte* native_held;
			var byteCount_held = 0;
			if (held != null)
			{
				byteCount_held = Encoding.UTF8.GetByteCount(held);
				if(byteCount_held > Utils.MaxStackallocSize)
				{
					native_held = Utils.Alloc<byte>(byteCount_held + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_held + 1];
					native_held = stackallocBytes;
				}
				var held_offset = Utils.EncodeStringUTF8(held, native_held, byteCount_held);
				native_held[held_offset] = 0;
			}
			else native_held = null;

			fixed (double* native_x = &x)
			fixed (double* native_y = &y)
			{
				var result = ImPlotNative.DragPoint(id, native_x, native_y, col, size, flags, native_outClicked, native_outHovered, native_held);
				// Freeing outClicked native string
				if (byteCount_outClicked > Utils.MaxStackallocSize)
					Utils.Free(native_outClicked);
				// Freeing outHovered native string
				if (byteCount_outHovered > Utils.MaxStackallocSize)
					Utils.Free(native_outHovered);
				// Freeing held native string
				if (byteCount_held > Utils.MaxStackallocSize)
					Utils.Free(native_held);
				return result;
			}
		}

		public static byte DragLineX(int id, ref double x, Vector4 col, float thickness, ImPlotDragToolFlags flags, ReadOnlySpan<char> outClicked, ReadOnlySpan<char> outHovered, ReadOnlySpan<char> held)
		{
			// Marshaling outClicked to native string
			byte* native_outClicked;
			var byteCount_outClicked = 0;
			if (outClicked != null)
			{
				byteCount_outClicked = Encoding.UTF8.GetByteCount(outClicked);
				if(byteCount_outClicked > Utils.MaxStackallocSize)
				{
					native_outClicked = Utils.Alloc<byte>(byteCount_outClicked + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_outClicked + 1];
					native_outClicked = stackallocBytes;
				}
				var outClicked_offset = Utils.EncodeStringUTF8(outClicked, native_outClicked, byteCount_outClicked);
				native_outClicked[outClicked_offset] = 0;
			}
			else native_outClicked = null;

			// Marshaling outHovered to native string
			byte* native_outHovered;
			var byteCount_outHovered = 0;
			if (outHovered != null)
			{
				byteCount_outHovered = Encoding.UTF8.GetByteCount(outHovered);
				if(byteCount_outHovered > Utils.MaxStackallocSize)
				{
					native_outHovered = Utils.Alloc<byte>(byteCount_outHovered + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_outHovered + 1];
					native_outHovered = stackallocBytes;
				}
				var outHovered_offset = Utils.EncodeStringUTF8(outHovered, native_outHovered, byteCount_outHovered);
				native_outHovered[outHovered_offset] = 0;
			}
			else native_outHovered = null;

			// Marshaling held to native string
			byte* native_held;
			var byteCount_held = 0;
			if (held != null)
			{
				byteCount_held = Encoding.UTF8.GetByteCount(held);
				if(byteCount_held > Utils.MaxStackallocSize)
				{
					native_held = Utils.Alloc<byte>(byteCount_held + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_held + 1];
					native_held = stackallocBytes;
				}
				var held_offset = Utils.EncodeStringUTF8(held, native_held, byteCount_held);
				native_held[held_offset] = 0;
			}
			else native_held = null;

			fixed (double* native_x = &x)
			{
				var result = ImPlotNative.DragLineX(id, native_x, col, thickness, flags, native_outClicked, native_outHovered, native_held);
				// Freeing outClicked native string
				if (byteCount_outClicked > Utils.MaxStackallocSize)
					Utils.Free(native_outClicked);
				// Freeing outHovered native string
				if (byteCount_outHovered > Utils.MaxStackallocSize)
					Utils.Free(native_outHovered);
				// Freeing held native string
				if (byteCount_held > Utils.MaxStackallocSize)
					Utils.Free(native_held);
				return result;
			}
		}

		public static byte DragLineY(int id, ref double y, Vector4 col, float thickness, ImPlotDragToolFlags flags, ReadOnlySpan<char> outClicked, ReadOnlySpan<char> outHovered, ReadOnlySpan<char> held)
		{
			// Marshaling outClicked to native string
			byte* native_outClicked;
			var byteCount_outClicked = 0;
			if (outClicked != null)
			{
				byteCount_outClicked = Encoding.UTF8.GetByteCount(outClicked);
				if(byteCount_outClicked > Utils.MaxStackallocSize)
				{
					native_outClicked = Utils.Alloc<byte>(byteCount_outClicked + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_outClicked + 1];
					native_outClicked = stackallocBytes;
				}
				var outClicked_offset = Utils.EncodeStringUTF8(outClicked, native_outClicked, byteCount_outClicked);
				native_outClicked[outClicked_offset] = 0;
			}
			else native_outClicked = null;

			// Marshaling outHovered to native string
			byte* native_outHovered;
			var byteCount_outHovered = 0;
			if (outHovered != null)
			{
				byteCount_outHovered = Encoding.UTF8.GetByteCount(outHovered);
				if(byteCount_outHovered > Utils.MaxStackallocSize)
				{
					native_outHovered = Utils.Alloc<byte>(byteCount_outHovered + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_outHovered + 1];
					native_outHovered = stackallocBytes;
				}
				var outHovered_offset = Utils.EncodeStringUTF8(outHovered, native_outHovered, byteCount_outHovered);
				native_outHovered[outHovered_offset] = 0;
			}
			else native_outHovered = null;

			// Marshaling held to native string
			byte* native_held;
			var byteCount_held = 0;
			if (held != null)
			{
				byteCount_held = Encoding.UTF8.GetByteCount(held);
				if(byteCount_held > Utils.MaxStackallocSize)
				{
					native_held = Utils.Alloc<byte>(byteCount_held + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_held + 1];
					native_held = stackallocBytes;
				}
				var held_offset = Utils.EncodeStringUTF8(held, native_held, byteCount_held);
				native_held[held_offset] = 0;
			}
			else native_held = null;

			fixed (double* native_y = &y)
			{
				var result = ImPlotNative.DragLineY(id, native_y, col, thickness, flags, native_outClicked, native_outHovered, native_held);
				// Freeing outClicked native string
				if (byteCount_outClicked > Utils.MaxStackallocSize)
					Utils.Free(native_outClicked);
				// Freeing outHovered native string
				if (byteCount_outHovered > Utils.MaxStackallocSize)
					Utils.Free(native_outHovered);
				// Freeing held native string
				if (byteCount_held > Utils.MaxStackallocSize)
					Utils.Free(native_held);
				return result;
			}
		}

		public static byte DragRect(int id, ref double x1, ref double y1, ref double x2, ref double y2, Vector4 col, ImPlotDragToolFlags flags, ReadOnlySpan<char> outClicked, ReadOnlySpan<char> outHovered, ReadOnlySpan<char> held)
		{
			// Marshaling outClicked to native string
			byte* native_outClicked;
			var byteCount_outClicked = 0;
			if (outClicked != null)
			{
				byteCount_outClicked = Encoding.UTF8.GetByteCount(outClicked);
				if(byteCount_outClicked > Utils.MaxStackallocSize)
				{
					native_outClicked = Utils.Alloc<byte>(byteCount_outClicked + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_outClicked + 1];
					native_outClicked = stackallocBytes;
				}
				var outClicked_offset = Utils.EncodeStringUTF8(outClicked, native_outClicked, byteCount_outClicked);
				native_outClicked[outClicked_offset] = 0;
			}
			else native_outClicked = null;

			// Marshaling outHovered to native string
			byte* native_outHovered;
			var byteCount_outHovered = 0;
			if (outHovered != null)
			{
				byteCount_outHovered = Encoding.UTF8.GetByteCount(outHovered);
				if(byteCount_outHovered > Utils.MaxStackallocSize)
				{
					native_outHovered = Utils.Alloc<byte>(byteCount_outHovered + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_outHovered + 1];
					native_outHovered = stackallocBytes;
				}
				var outHovered_offset = Utils.EncodeStringUTF8(outHovered, native_outHovered, byteCount_outHovered);
				native_outHovered[outHovered_offset] = 0;
			}
			else native_outHovered = null;

			// Marshaling held to native string
			byte* native_held;
			var byteCount_held = 0;
			if (held != null)
			{
				byteCount_held = Encoding.UTF8.GetByteCount(held);
				if(byteCount_held > Utils.MaxStackallocSize)
				{
					native_held = Utils.Alloc<byte>(byteCount_held + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_held + 1];
					native_held = stackallocBytes;
				}
				var held_offset = Utils.EncodeStringUTF8(held, native_held, byteCount_held);
				native_held[held_offset] = 0;
			}
			else native_held = null;

			fixed (double* native_x1 = &x1)
			fixed (double* native_y1 = &y1)
			fixed (double* native_x2 = &x2)
			fixed (double* native_y2 = &y2)
			{
				var result = ImPlotNative.DragRect(id, native_x1, native_y1, native_x2, native_y2, col, flags, native_outClicked, native_outHovered, native_held);
				// Freeing outClicked native string
				if (byteCount_outClicked > Utils.MaxStackallocSize)
					Utils.Free(native_outClicked);
				// Freeing outHovered native string
				if (byteCount_outHovered > Utils.MaxStackallocSize)
					Utils.Free(native_outHovered);
				// Freeing held native string
				if (byteCount_held > Utils.MaxStackallocSize)
					Utils.Free(native_held);
				return result;
			}
		}

		public static void AnnotationBool(double x, double y, Vector4 col, Vector2 pixOffset, bool clamp, bool round)
		{
			var native_clamp = clamp ? (byte)1 : (byte)0;
			var native_round = round ? (byte)1 : (byte)0;
			ImPlotNative.AnnotationBool(x, y, col, pixOffset, native_clamp, native_round);
		}

		public static void AnnotationStr(double x, double y, Vector4 col, Vector2 pixOffset, bool clamp, ReadOnlySpan<char> fmt)
		{
			var native_clamp = clamp ? (byte)1 : (byte)0;
			// Marshaling fmt to native string
			byte* native_fmt;
			var byteCount_fmt = 0;
			if (fmt != null)
			{
				byteCount_fmt = Encoding.UTF8.GetByteCount(fmt);
				if(byteCount_fmt > Utils.MaxStackallocSize)
				{
					native_fmt = Utils.Alloc<byte>(byteCount_fmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_fmt + 1];
					native_fmt = stackallocBytes;
				}
				var fmt_offset = Utils.EncodeStringUTF8(fmt, native_fmt, byteCount_fmt);
				native_fmt[fmt_offset] = 0;
			}
			else native_fmt = null;

			ImPlotNative.AnnotationStr(x, y, col, pixOffset, native_clamp, native_fmt);
			// Freeing fmt native string
			if (byteCount_fmt > Utils.MaxStackallocSize)
				Utils.Free(native_fmt);
		}

		public static void TagXBool(double x, Vector4 col, bool round)
		{
			var native_round = round ? (byte)1 : (byte)0;
			ImPlotNative.TagXBool(x, col, native_round);
		}

		public static void TagXStr(double x, Vector4 col, ReadOnlySpan<char> fmt)
		{
			// Marshaling fmt to native string
			byte* native_fmt;
			var byteCount_fmt = 0;
			if (fmt != null)
			{
				byteCount_fmt = Encoding.UTF8.GetByteCount(fmt);
				if(byteCount_fmt > Utils.MaxStackallocSize)
				{
					native_fmt = Utils.Alloc<byte>(byteCount_fmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_fmt + 1];
					native_fmt = stackallocBytes;
				}
				var fmt_offset = Utils.EncodeStringUTF8(fmt, native_fmt, byteCount_fmt);
				native_fmt[fmt_offset] = 0;
			}
			else native_fmt = null;

			ImPlotNative.TagXStr(x, col, native_fmt);
			// Freeing fmt native string
			if (byteCount_fmt > Utils.MaxStackallocSize)
				Utils.Free(native_fmt);
		}

		public static void TagYBool(double y, Vector4 col, bool round)
		{
			var native_round = round ? (byte)1 : (byte)0;
			ImPlotNative.TagYBool(y, col, native_round);
		}

		public static void TagYStr(double y, Vector4 col, ReadOnlySpan<char> fmt)
		{
			// Marshaling fmt to native string
			byte* native_fmt;
			var byteCount_fmt = 0;
			if (fmt != null)
			{
				byteCount_fmt = Encoding.UTF8.GetByteCount(fmt);
				if(byteCount_fmt > Utils.MaxStackallocSize)
				{
					native_fmt = Utils.Alloc<byte>(byteCount_fmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_fmt + 1];
					native_fmt = stackallocBytes;
				}
				var fmt_offset = Utils.EncodeStringUTF8(fmt, native_fmt, byteCount_fmt);
				native_fmt[fmt_offset] = 0;
			}
			else native_fmt = null;

			ImPlotNative.TagYStr(y, col, native_fmt);
			// Freeing fmt native string
			if (byteCount_fmt > Utils.MaxStackallocSize)
				Utils.Free(native_fmt);
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

		public static void PlotToPixelsPlotPoInt(ref Vector2 pOut, ImPlotPoint plt, ImAxis xAxis, ImAxis yAxis)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImPlotNative.PlotToPixelsPlotPoInt(native_pOut, plt, xAxis, yAxis);
			}
		}

		public static void PlotToPixelsDouble(ref Vector2 pOut, double x, double y, ImAxis xAxis, ImAxis yAxis)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImPlotNative.PlotToPixelsDouble(native_pOut, x, y, xAxis, yAxis);
			}
		}

		public static void GetPlotPos(ref Vector2 pOut)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImPlotNative.GetPlotPos(native_pOut);
			}
		}

		public static void GetPlotSize(ref Vector2 pOut)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImPlotNative.GetPlotSize(native_pOut);
			}
		}

		public static void GetPlotMousePos(ImPlotPointPtr pOut, ImAxis xAxis, ImAxis yAxis)
		{
			ImPlotNative.GetPlotMousePos(pOut, xAxis, yAxis);
		}

		public static void GetPlotLimits(ImPlotRectPtr pOut, ImAxis xAxis, ImAxis yAxis)
		{
			ImPlotNative.GetPlotLimits(pOut, xAxis, yAxis);
		}

		public static byte IsPlotHovered()
		{
			return ImPlotNative.IsPlotHovered();
		}

		public static byte IsAxisHovered(ImAxis axis)
		{
			return ImPlotNative.IsAxisHovered(axis);
		}

		public static byte IsSubplotsHovered()
		{
			return ImPlotNative.IsSubplotsHovered();
		}

		public static byte IsPlotSelected()
		{
			return ImPlotNative.IsPlotSelected();
		}

		public static void GetPlotSelection(ImPlotRectPtr pOut, ImAxis xAxis, ImAxis yAxis)
		{
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

		public static byte BeginAlignedPlots(ReadOnlySpan<char> groupId, bool vertical)
		{
			// Marshaling groupId to native string
			byte* native_groupId;
			var byteCount_groupId = 0;
			if (groupId != null)
			{
				byteCount_groupId = Encoding.UTF8.GetByteCount(groupId);
				if(byteCount_groupId > Utils.MaxStackallocSize)
				{
					native_groupId = Utils.Alloc<byte>(byteCount_groupId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_groupId + 1];
					native_groupId = stackallocBytes;
				}
				var groupId_offset = Utils.EncodeStringUTF8(groupId, native_groupId, byteCount_groupId);
				native_groupId[groupId_offset] = 0;
			}
			else native_groupId = null;

			var native_vertical = vertical ? (byte)1 : (byte)0;
			return ImPlotNative.BeginAlignedPlots(native_groupId, native_vertical);
			// Freeing groupId native string
			if (byteCount_groupId > Utils.MaxStackallocSize)
				Utils.Free(native_groupId);
		}

		public static void EndAlignedPlots()
		{
			ImPlotNative.EndAlignedPlots();
		}

		public static byte BeginLegendPopup(ReadOnlySpan<char> labelId, ImGuiMouseButton mouseButton)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			return ImPlotNative.BeginLegendPopup(native_labelId, mouseButton);
			// Freeing labelId native string
			if (byteCount_labelId > Utils.MaxStackallocSize)
				Utils.Free(native_labelId);
		}

		public static void EndLegendPopup()
		{
			ImPlotNative.EndLegendPopup();
		}

		public static byte IsLegendEntryHovered(ReadOnlySpan<char> labelId)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			return ImPlotNative.IsLegendEntryHovered(native_labelId);
			// Freeing labelId native string
			if (byteCount_labelId > Utils.MaxStackallocSize)
				Utils.Free(native_labelId);
		}

		public static byte BeginDragDropTargetPlot()
		{
			return ImPlotNative.BeginDragDropTargetPlot();
		}

		public static byte BeginDragDropTargetAxis(ImAxis axis)
		{
			return ImPlotNative.BeginDragDropTargetAxis(axis);
		}

		public static byte BeginDragDropTargetLegend()
		{
			return ImPlotNative.BeginDragDropTargetLegend();
		}

		public static void EndDragDropTarget()
		{
			ImPlotNative.EndDragDropTarget();
		}

		public static byte BeginDragDropSourcePlot(ImGuiDragDropFlags flags)
		{
			return ImPlotNative.BeginDragDropSourcePlot(flags);
		}

		public static byte BeginDragDropSourceAxis(ImAxis axis, ImGuiDragDropFlags flags)
		{
			return ImPlotNative.BeginDragDropSourceAxis(axis, flags);
		}

		public static byte BeginDragDropSourceItem(ReadOnlySpan<char> labelId, ImGuiDragDropFlags flags)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			return ImPlotNative.BeginDragDropSourceItem(native_labelId, flags);
			// Freeing labelId native string
			if (byteCount_labelId > Utils.MaxStackallocSize)
				Utils.Free(native_labelId);
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

		public static void StyleColorsClassic(ImPlotStylePtr dst)
		{
			ImPlotNative.StyleColorsClassic(dst);
		}

		public static void StyleColorsDark(ImPlotStylePtr dst)
		{
			ImPlotNative.StyleColorsDark(dst);
		}

		public static void StyleColorsLight(ImPlotStylePtr dst)
		{
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

		public static void SetNextLineStyle(Vector4 col, float weight)
		{
			ImPlotNative.SetNextLineStyle(col, weight);
		}

		public static void SetNextFillStyle(Vector4 col, float alphaMod)
		{
			ImPlotNative.SetNextFillStyle(col, alphaMod);
		}

		public static void SetNextMarkerStyle(ImPlotMarker marker, float size, Vector4 fill, float weight, Vector4 outline)
		{
			ImPlotNative.SetNextMarkerStyle(marker, size, fill, weight, outline);
		}

		public static void SetNextErrorBarStyle(Vector4 col, float size, float weight)
		{
			ImPlotNative.SetNextErrorBarStyle(col, size, weight);
		}

		public static void GetLastItemColor(ref Vector4 pOut)
		{
			fixed (Vector4* native_pOut = &pOut)
			{
				ImPlotNative.GetLastItemColor(native_pOut);
			}
		}

		public static ref byte GetStyleColorName(ImPlotCol idx)
		{
			var nativeResult = ImPlotNative.GetStyleColorName(idx);
			return ref *(byte*)&nativeResult;
		}

		public static ref byte GetMarkerName(ImPlotMarker idx)
		{
			var nativeResult = ImPlotNative.GetMarkerName(idx);
			return ref *(byte*)&nativeResult;
		}

		public static ImPlotColormap AddColormapVec4Ptr(ReadOnlySpan<char> name, ref Vector4 cols, int size, bool qual)
		{
			// Marshaling name to native string
			byte* native_name;
			var byteCount_name = 0;
			if (name != null)
			{
				byteCount_name = Encoding.UTF8.GetByteCount(name);
				if(byteCount_name > Utils.MaxStackallocSize)
				{
					native_name = Utils.Alloc<byte>(byteCount_name + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_name + 1];
					native_name = stackallocBytes;
				}
				var name_offset = Utils.EncodeStringUTF8(name, native_name, byteCount_name);
				native_name[name_offset] = 0;
			}
			else native_name = null;

			var native_qual = qual ? (byte)1 : (byte)0;
			fixed (Vector4* native_cols = &cols)
			{
				var result = ImPlotNative.AddColormapVec4Ptr(native_name, native_cols, size, native_qual);
				// Freeing name native string
				if (byteCount_name > Utils.MaxStackallocSize)
					Utils.Free(native_name);
				return result;
			}
		}

		public static ImPlotColormap AddColormapU32Ptr(ReadOnlySpan<char> name, ref uint cols, int size, bool qual)
		{
			// Marshaling name to native string
			byte* native_name;
			var byteCount_name = 0;
			if (name != null)
			{
				byteCount_name = Encoding.UTF8.GetByteCount(name);
				if(byteCount_name > Utils.MaxStackallocSize)
				{
					native_name = Utils.Alloc<byte>(byteCount_name + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_name + 1];
					native_name = stackallocBytes;
				}
				var name_offset = Utils.EncodeStringUTF8(name, native_name, byteCount_name);
				native_name[name_offset] = 0;
			}
			else native_name = null;

			var native_qual = qual ? (byte)1 : (byte)0;
			fixed (uint* native_cols = &cols)
			{
				var result = ImPlotNative.AddColormapU32Ptr(native_name, native_cols, size, native_qual);
				// Freeing name native string
				if (byteCount_name > Utils.MaxStackallocSize)
					Utils.Free(native_name);
				return result;
			}
		}

		public static int GetColormapCount()
		{
			return ImPlotNative.GetColormapCount();
		}

		public static ref byte GetColormapName(ImPlotColormap cmap)
		{
			var nativeResult = ImPlotNative.GetColormapName(cmap);
			return ref *(byte*)&nativeResult;
		}

		public static ImPlotColormap GetColormapIndex(ReadOnlySpan<char> name)
		{
			// Marshaling name to native string
			byte* native_name;
			var byteCount_name = 0;
			if (name != null)
			{
				byteCount_name = Encoding.UTF8.GetByteCount(name);
				if(byteCount_name > Utils.MaxStackallocSize)
				{
					native_name = Utils.Alloc<byte>(byteCount_name + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_name + 1];
					native_name = stackallocBytes;
				}
				var name_offset = Utils.EncodeStringUTF8(name, native_name, byteCount_name);
				native_name[name_offset] = 0;
			}
			else native_name = null;

			return ImPlotNative.GetColormapIndex(native_name);
			// Freeing name native string
			if (byteCount_name > Utils.MaxStackallocSize)
				Utils.Free(native_name);
		}

		public static void PushColormapPlotColormap(ImPlotColormap cmap)
		{
			ImPlotNative.PushColormapPlotColormap(cmap);
		}

		public static void PushColormapStr(ReadOnlySpan<char> name)
		{
			// Marshaling name to native string
			byte* native_name;
			var byteCount_name = 0;
			if (name != null)
			{
				byteCount_name = Encoding.UTF8.GetByteCount(name);
				if(byteCount_name > Utils.MaxStackallocSize)
				{
					native_name = Utils.Alloc<byte>(byteCount_name + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_name + 1];
					native_name = stackallocBytes;
				}
				var name_offset = Utils.EncodeStringUTF8(name, native_name, byteCount_name);
				native_name[name_offset] = 0;
			}
			else native_name = null;

			ImPlotNative.PushColormapStr(native_name);
			// Freeing name native string
			if (byteCount_name > Utils.MaxStackallocSize)
				Utils.Free(native_name);
		}

		public static void PopColormap(int count)
		{
			ImPlotNative.PopColormap(count);
		}

		public static void NextColormapColor(ref Vector4 pOut)
		{
			fixed (Vector4* native_pOut = &pOut)
			{
				ImPlotNative.NextColormapColor(native_pOut);
			}
		}

		public static int GetColormapSize(ImPlotColormap cmap)
		{
			return ImPlotNative.GetColormapSize(cmap);
		}

		public static void GetColormapColor(ref Vector4 pOut, int idx, ImPlotColormap cmap)
		{
			fixed (Vector4* native_pOut = &pOut)
			{
				ImPlotNative.GetColormapColor(native_pOut, idx, cmap);
			}
		}

		public static void SampleColormap(ref Vector4 pOut, float t, ImPlotColormap cmap)
		{
			fixed (Vector4* native_pOut = &pOut)
			{
				ImPlotNative.SampleColormap(native_pOut, t, cmap);
			}
		}

		public static void ColormapScale(ReadOnlySpan<char> label, double scaleMin, double scaleMax, Vector2 size, ReadOnlySpan<char> format, ImPlotColormapScaleFlags flags, ImPlotColormap cmap)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			ImPlotNative.ColormapScale(native_label, scaleMin, scaleMax, size, native_format, flags, cmap);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
			// Freeing format native string
			if (byteCount_format > Utils.MaxStackallocSize)
				Utils.Free(native_format);
		}

		public static byte ColormapSlider(ReadOnlySpan<char> label, ref float t, ref Vector4 _out, ReadOnlySpan<char> format, ImPlotColormap cmap)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (float* native_t = &t)
			fixed (Vector4* native__out = &_out)
			{
				var result = ImPlotNative.ColormapSlider(native_label, native_t, native__out, native_format, cmap);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				// Freeing format native string
				if (byteCount_format > Utils.MaxStackallocSize)
					Utils.Free(native_format);
				return result;
			}
		}

		public static byte ColormapButton(ReadOnlySpan<char> label, Vector2 size, ImPlotColormap cmap)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			return ImPlotNative.ColormapButton(native_label, size, cmap);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
		}

		public static void BustColorCache(ReadOnlySpan<char> plotTitleId)
		{
			// Marshaling plotTitleId to native string
			byte* native_plotTitleId;
			var byteCount_plotTitleId = 0;
			if (plotTitleId != null)
			{
				byteCount_plotTitleId = Encoding.UTF8.GetByteCount(plotTitleId);
				if(byteCount_plotTitleId > Utils.MaxStackallocSize)
				{
					native_plotTitleId = Utils.Alloc<byte>(byteCount_plotTitleId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_plotTitleId + 1];
					native_plotTitleId = stackallocBytes;
				}
				var plotTitleId_offset = Utils.EncodeStringUTF8(plotTitleId, native_plotTitleId, byteCount_plotTitleId);
				native_plotTitleId[plotTitleId_offset] = 0;
			}
			else native_plotTitleId = null;

			ImPlotNative.BustColorCache(native_plotTitleId);
			// Freeing plotTitleId native string
			if (byteCount_plotTitleId > Utils.MaxStackallocSize)
				Utils.Free(native_plotTitleId);
		}

		public static ImPlotInputMapPtr GetInputMap()
		{
			return ImPlotNative.GetInputMap();
		}

		public static void MapInputDefault(ImPlotInputMapPtr dst)
		{
			ImPlotNative.MapInputDefault(dst);
		}

		public static void MapInputReverse(ImPlotInputMapPtr dst)
		{
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

		public static void PopPlotClipRect()
		{
			ImPlotNative.PopPlotClipRect();
		}

		public static byte ShowStyleSelector(ReadOnlySpan<char> label)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			return ImPlotNative.ShowStyleSelector(native_label);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
		}

		public static byte ShowColormapSelector(ReadOnlySpan<char> label)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			return ImPlotNative.ShowColormapSelector(native_label);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
		}

		public static byte ShowInputMapSelector(ReadOnlySpan<char> label)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			return ImPlotNative.ShowInputMapSelector(native_label);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
		}

		public static void ShowStyleEditor(ImPlotStylePtr _ref)
		{
			ImPlotNative.ShowStyleEditor(_ref);
		}

		public static void ShowUserGuide()
		{
			ImPlotNative.ShowUserGuide();
		}

		public static void ShowMetricsWindow(ReadOnlySpan<char> pPopen)
		{
			// Marshaling pPopen to native string
			byte* native_pPopen;
			var byteCount_pPopen = 0;
			if (pPopen != null)
			{
				byteCount_pPopen = Encoding.UTF8.GetByteCount(pPopen);
				if(byteCount_pPopen > Utils.MaxStackallocSize)
				{
					native_pPopen = Utils.Alloc<byte>(byteCount_pPopen + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_pPopen + 1];
					native_pPopen = stackallocBytes;
				}
				var pPopen_offset = Utils.EncodeStringUTF8(pPopen, native_pPopen, byteCount_pPopen);
				native_pPopen[pPopen_offset] = 0;
			}
			else native_pPopen = null;

			ImPlotNative.ShowMetricsWindow(native_pPopen);
			// Freeing pPopen native string
			if (byteCount_pPopen > Utils.MaxStackallocSize)
				Utils.Free(native_pPopen);
		}

		public static void ShowDemoWindow(ReadOnlySpan<char> pOpen)
		{
			// Marshaling pOpen to native string
			byte* native_pOpen;
			var byteCount_pOpen = 0;
			if (pOpen != null)
			{
				byteCount_pOpen = Encoding.UTF8.GetByteCount(pOpen);
				if(byteCount_pOpen > Utils.MaxStackallocSize)
				{
					native_pOpen = Utils.Alloc<byte>(byteCount_pOpen + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_pOpen + 1];
					native_pOpen = stackallocBytes;
				}
				var pOpen_offset = Utils.EncodeStringUTF8(pOpen, native_pOpen, byteCount_pOpen);
				native_pOpen[pOpen_offset] = 0;
			}
			else native_pOpen = null;

			ImPlotNative.ShowDemoWindow(native_pOpen);
			// Freeing pOpen native string
			if (byteCount_pOpen > Utils.MaxStackallocSize)
				Utils.Free(native_pOpen);
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

		public static byte ImRemapU8(bool x, bool x0, bool x1, bool y0, bool y1)
		{
			var native_x = x ? (byte)1 : (byte)0;
			var native_x0 = x0 ? (byte)1 : (byte)0;
			var native_x1 = x1 ? (byte)1 : (byte)0;
			var native_y0 = y0 ? (byte)1 : (byte)0;
			var native_y1 = y1 ? (byte)1 : (byte)0;
			return ImPlotNative.ImRemapU8(native_x, native_x0, native_x1, native_y0, native_y1);
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

		public static byte ImRemap01U8(bool x, bool x0, bool x1)
		{
			var native_x = x ? (byte)1 : (byte)0;
			var native_x0 = x0 ? (byte)1 : (byte)0;
			var native_x1 = x1 ? (byte)1 : (byte)0;
			return ImPlotNative.ImRemap01U8(native_x, native_x0, native_x1);
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

		public static int ImPosMod(int l, int r)
		{
			return ImPlotNative.ImPosMod(l, r);
		}

		public static byte ImNan(double val)
		{
			return ImPlotNative.ImNan(val);
		}

		public static byte ImNanOrInf(double val)
		{
			return ImPlotNative.ImNanOrInf(val);
		}

		public static double ImConstrainNan(double val)
		{
			return ImPlotNative.ImConstrainNan(val);
		}

		public static double ImConstrainInf(double val)
		{
			return ImPlotNative.ImConstrainInf(val);
		}

		public static double ImConstrainLog(double val)
		{
			return ImPlotNative.ImConstrainLog(val);
		}

		public static double ImConstrainTime(double val)
		{
			return ImPlotNative.ImConstrainTime(val);
		}

		public static byte ImAlmostEqual(double v1, double v2, int ulp)
		{
			return ImPlotNative.ImAlmostEqual(v1, v2, ulp);
		}

		public static float ImMinArrayFloatPtr(ref float values, int count)
		{
			fixed (float* native_values = &values)
			{
				var result = ImPlotNative.ImMinArrayFloatPtr(native_values, count);
				return result;
			}
		}

		public static double ImMinArrayDoublePtr(ref double values, int count)
		{
			fixed (double* native_values = &values)
			{
				var result = ImPlotNative.ImMinArrayDoublePtr(native_values, count);
				return result;
			}
		}

		public static sbyte ImMinArrayS8Ptr(ref sbyte values, int count)
		{
			fixed (sbyte* native_values = &values)
			{
				var result = ImPlotNative.ImMinArrayS8Ptr(native_values, count);
				return result;
			}
		}

		public static byte ImMinArrayU8Ptr(ReadOnlySpan<char> values, int count)
		{
			// Marshaling values to native string
			byte* native_values;
			var byteCount_values = 0;
			if (values != null)
			{
				byteCount_values = Encoding.UTF8.GetByteCount(values);
				if(byteCount_values > Utils.MaxStackallocSize)
				{
					native_values = Utils.Alloc<byte>(byteCount_values + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_values + 1];
					native_values = stackallocBytes;
				}
				var values_offset = Utils.EncodeStringUTF8(values, native_values, byteCount_values);
				native_values[values_offset] = 0;
			}
			else native_values = null;

			return ImPlotNative.ImMinArrayU8Ptr(native_values, count);
			// Freeing values native string
			if (byteCount_values > Utils.MaxStackallocSize)
				Utils.Free(native_values);
		}

		public static short ImMinArrayS16Ptr(ref short values, int count)
		{
			fixed (short* native_values = &values)
			{
				var result = ImPlotNative.ImMinArrayS16Ptr(native_values, count);
				return result;
			}
		}

		public static ushort ImMinArrayU16Ptr(ref ushort values, int count)
		{
			fixed (ushort* native_values = &values)
			{
				var result = ImPlotNative.ImMinArrayU16Ptr(native_values, count);
				return result;
			}
		}

		public static int ImMinArrayS32Ptr(ref int values, int count)
		{
			fixed (int* native_values = &values)
			{
				var result = ImPlotNative.ImMinArrayS32Ptr(native_values, count);
				return result;
			}
		}

		public static uint ImMinArrayU32Ptr(ref uint values, int count)
		{
			fixed (uint* native_values = &values)
			{
				var result = ImPlotNative.ImMinArrayU32Ptr(native_values, count);
				return result;
			}
		}

		public static long ImMinArrayS64Ptr(ref long values, int count)
		{
			fixed (long* native_values = &values)
			{
				var result = ImPlotNative.ImMinArrayS64Ptr(native_values, count);
				return result;
			}
		}

		public static ulong ImMinArrayU64Ptr(ref ulong values, int count)
		{
			fixed (ulong* native_values = &values)
			{
				var result = ImPlotNative.ImMinArrayU64Ptr(native_values, count);
				return result;
			}
		}

		public static float ImMaxArrayFloatPtr(ref float values, int count)
		{
			fixed (float* native_values = &values)
			{
				var result = ImPlotNative.ImMaxArrayFloatPtr(native_values, count);
				return result;
			}
		}

		public static double ImMaxArrayDoublePtr(ref double values, int count)
		{
			fixed (double* native_values = &values)
			{
				var result = ImPlotNative.ImMaxArrayDoublePtr(native_values, count);
				return result;
			}
		}

		public static sbyte ImMaxArrayS8Ptr(ref sbyte values, int count)
		{
			fixed (sbyte* native_values = &values)
			{
				var result = ImPlotNative.ImMaxArrayS8Ptr(native_values, count);
				return result;
			}
		}

		public static byte ImMaxArrayU8Ptr(ReadOnlySpan<char> values, int count)
		{
			// Marshaling values to native string
			byte* native_values;
			var byteCount_values = 0;
			if (values != null)
			{
				byteCount_values = Encoding.UTF8.GetByteCount(values);
				if(byteCount_values > Utils.MaxStackallocSize)
				{
					native_values = Utils.Alloc<byte>(byteCount_values + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_values + 1];
					native_values = stackallocBytes;
				}
				var values_offset = Utils.EncodeStringUTF8(values, native_values, byteCount_values);
				native_values[values_offset] = 0;
			}
			else native_values = null;

			return ImPlotNative.ImMaxArrayU8Ptr(native_values, count);
			// Freeing values native string
			if (byteCount_values > Utils.MaxStackallocSize)
				Utils.Free(native_values);
		}

		public static short ImMaxArrayS16Ptr(ref short values, int count)
		{
			fixed (short* native_values = &values)
			{
				var result = ImPlotNative.ImMaxArrayS16Ptr(native_values, count);
				return result;
			}
		}

		public static ushort ImMaxArrayU16Ptr(ref ushort values, int count)
		{
			fixed (ushort* native_values = &values)
			{
				var result = ImPlotNative.ImMaxArrayU16Ptr(native_values, count);
				return result;
			}
		}

		public static int ImMaxArrayS32Ptr(ref int values, int count)
		{
			fixed (int* native_values = &values)
			{
				var result = ImPlotNative.ImMaxArrayS32Ptr(native_values, count);
				return result;
			}
		}

		public static uint ImMaxArrayU32Ptr(ref uint values, int count)
		{
			fixed (uint* native_values = &values)
			{
				var result = ImPlotNative.ImMaxArrayU32Ptr(native_values, count);
				return result;
			}
		}

		public static long ImMaxArrayS64Ptr(ref long values, int count)
		{
			fixed (long* native_values = &values)
			{
				var result = ImPlotNative.ImMaxArrayS64Ptr(native_values, count);
				return result;
			}
		}

		public static ulong ImMaxArrayU64Ptr(ref ulong values, int count)
		{
			fixed (ulong* native_values = &values)
			{
				var result = ImPlotNative.ImMaxArrayU64Ptr(native_values, count);
				return result;
			}
		}

		public static void ImMinMaxArrayFloatPtr(ref float values, int count, ref float minOut, ref float maxOut)
		{
			fixed (float* native_values = &values)
			fixed (float* native_minOut = &minOut)
			fixed (float* native_maxOut = &maxOut)
			{
				ImPlotNative.ImMinMaxArrayFloatPtr(native_values, count, native_minOut, native_maxOut);
			}
		}

		public static void ImMinMaxArrayDoublePtr(ref double values, int count, ref double minOut, ref double maxOut)
		{
			fixed (double* native_values = &values)
			fixed (double* native_minOut = &minOut)
			fixed (double* native_maxOut = &maxOut)
			{
				ImPlotNative.ImMinMaxArrayDoublePtr(native_values, count, native_minOut, native_maxOut);
			}
		}

		public static void ImMinMaxArrayS8Ptr(ref sbyte values, int count, ref sbyte minOut, ref sbyte maxOut)
		{
			fixed (sbyte* native_values = &values)
			fixed (sbyte* native_minOut = &minOut)
			fixed (sbyte* native_maxOut = &maxOut)
			{
				ImPlotNative.ImMinMaxArrayS8Ptr(native_values, count, native_minOut, native_maxOut);
			}
		}

		public static void ImMinMaxArrayU8Ptr(ReadOnlySpan<char> values, int count, ReadOnlySpan<char> minOut, ReadOnlySpan<char> maxOut)
		{
			// Marshaling values to native string
			byte* native_values;
			var byteCount_values = 0;
			if (values != null)
			{
				byteCount_values = Encoding.UTF8.GetByteCount(values);
				if(byteCount_values > Utils.MaxStackallocSize)
				{
					native_values = Utils.Alloc<byte>(byteCount_values + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_values + 1];
					native_values = stackallocBytes;
				}
				var values_offset = Utils.EncodeStringUTF8(values, native_values, byteCount_values);
				native_values[values_offset] = 0;
			}
			else native_values = null;

			// Marshaling minOut to native string
			byte* native_minOut;
			var byteCount_minOut = 0;
			if (minOut != null)
			{
				byteCount_minOut = Encoding.UTF8.GetByteCount(minOut);
				if(byteCount_minOut > Utils.MaxStackallocSize)
				{
					native_minOut = Utils.Alloc<byte>(byteCount_minOut + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_minOut + 1];
					native_minOut = stackallocBytes;
				}
				var minOut_offset = Utils.EncodeStringUTF8(minOut, native_minOut, byteCount_minOut);
				native_minOut[minOut_offset] = 0;
			}
			else native_minOut = null;

			// Marshaling maxOut to native string
			byte* native_maxOut;
			var byteCount_maxOut = 0;
			if (maxOut != null)
			{
				byteCount_maxOut = Encoding.UTF8.GetByteCount(maxOut);
				if(byteCount_maxOut > Utils.MaxStackallocSize)
				{
					native_maxOut = Utils.Alloc<byte>(byteCount_maxOut + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_maxOut + 1];
					native_maxOut = stackallocBytes;
				}
				var maxOut_offset = Utils.EncodeStringUTF8(maxOut, native_maxOut, byteCount_maxOut);
				native_maxOut[maxOut_offset] = 0;
			}
			else native_maxOut = null;

			ImPlotNative.ImMinMaxArrayU8Ptr(native_values, count, native_minOut, native_maxOut);
			// Freeing values native string
			if (byteCount_values > Utils.MaxStackallocSize)
				Utils.Free(native_values);
			// Freeing minOut native string
			if (byteCount_minOut > Utils.MaxStackallocSize)
				Utils.Free(native_minOut);
			// Freeing maxOut native string
			if (byteCount_maxOut > Utils.MaxStackallocSize)
				Utils.Free(native_maxOut);
		}

		public static void ImMinMaxArrayS16Ptr(ref short values, int count, ref short minOut, ref short maxOut)
		{
			fixed (short* native_values = &values)
			fixed (short* native_minOut = &minOut)
			fixed (short* native_maxOut = &maxOut)
			{
				ImPlotNative.ImMinMaxArrayS16Ptr(native_values, count, native_minOut, native_maxOut);
			}
		}

		public static void ImMinMaxArrayU16Ptr(ref ushort values, int count, ref ushort minOut, ref ushort maxOut)
		{
			fixed (ushort* native_values = &values)
			fixed (ushort* native_minOut = &minOut)
			fixed (ushort* native_maxOut = &maxOut)
			{
				ImPlotNative.ImMinMaxArrayU16Ptr(native_values, count, native_minOut, native_maxOut);
			}
		}

		public static void ImMinMaxArrayS32Ptr(ref int values, int count, ref int minOut, ref int maxOut)
		{
			fixed (int* native_values = &values)
			fixed (int* native_minOut = &minOut)
			fixed (int* native_maxOut = &maxOut)
			{
				ImPlotNative.ImMinMaxArrayS32Ptr(native_values, count, native_minOut, native_maxOut);
			}
		}

		public static void ImMinMaxArrayU32Ptr(ref uint values, int count, ref uint minOut, ref uint maxOut)
		{
			fixed (uint* native_values = &values)
			fixed (uint* native_minOut = &minOut)
			fixed (uint* native_maxOut = &maxOut)
			{
				ImPlotNative.ImMinMaxArrayU32Ptr(native_values, count, native_minOut, native_maxOut);
			}
		}

		public static void ImMinMaxArrayS64Ptr(ref long values, int count, ref long minOut, ref long maxOut)
		{
			fixed (long* native_values = &values)
			fixed (long* native_minOut = &minOut)
			fixed (long* native_maxOut = &maxOut)
			{
				ImPlotNative.ImMinMaxArrayS64Ptr(native_values, count, native_minOut, native_maxOut);
			}
		}

		public static void ImMinMaxArrayU64Ptr(ref ulong values, int count, ref ulong minOut, ref ulong maxOut)
		{
			fixed (ulong* native_values = &values)
			fixed (ulong* native_minOut = &minOut)
			fixed (ulong* native_maxOut = &maxOut)
			{
				ImPlotNative.ImMinMaxArrayU64Ptr(native_values, count, native_minOut, native_maxOut);
			}
		}

		public static float ImSumFloatPtr(ref float values, int count)
		{
			fixed (float* native_values = &values)
			{
				var result = ImPlotNative.ImSumFloatPtr(native_values, count);
				return result;
			}
		}

		public static double ImSumDoublePtr(ref double values, int count)
		{
			fixed (double* native_values = &values)
			{
				var result = ImPlotNative.ImSumDoublePtr(native_values, count);
				return result;
			}
		}

		public static sbyte ImSumS8Ptr(ref sbyte values, int count)
		{
			fixed (sbyte* native_values = &values)
			{
				var result = ImPlotNative.ImSumS8Ptr(native_values, count);
				return result;
			}
		}

		public static byte ImSumU8Ptr(ReadOnlySpan<char> values, int count)
		{
			// Marshaling values to native string
			byte* native_values;
			var byteCount_values = 0;
			if (values != null)
			{
				byteCount_values = Encoding.UTF8.GetByteCount(values);
				if(byteCount_values > Utils.MaxStackallocSize)
				{
					native_values = Utils.Alloc<byte>(byteCount_values + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_values + 1];
					native_values = stackallocBytes;
				}
				var values_offset = Utils.EncodeStringUTF8(values, native_values, byteCount_values);
				native_values[values_offset] = 0;
			}
			else native_values = null;

			return ImPlotNative.ImSumU8Ptr(native_values, count);
			// Freeing values native string
			if (byteCount_values > Utils.MaxStackallocSize)
				Utils.Free(native_values);
		}

		public static short ImSumS16Ptr(ref short values, int count)
		{
			fixed (short* native_values = &values)
			{
				var result = ImPlotNative.ImSumS16Ptr(native_values, count);
				return result;
			}
		}

		public static ushort ImSumU16Ptr(ref ushort values, int count)
		{
			fixed (ushort* native_values = &values)
			{
				var result = ImPlotNative.ImSumU16Ptr(native_values, count);
				return result;
			}
		}

		public static int ImSumS32Ptr(ref int values, int count)
		{
			fixed (int* native_values = &values)
			{
				var result = ImPlotNative.ImSumS32Ptr(native_values, count);
				return result;
			}
		}

		public static uint ImSumU32Ptr(ref uint values, int count)
		{
			fixed (uint* native_values = &values)
			{
				var result = ImPlotNative.ImSumU32Ptr(native_values, count);
				return result;
			}
		}

		public static long ImSumS64Ptr(ref long values, int count)
		{
			fixed (long* native_values = &values)
			{
				var result = ImPlotNative.ImSumS64Ptr(native_values, count);
				return result;
			}
		}

		public static ulong ImSumU64Ptr(ref ulong values, int count)
		{
			fixed (ulong* native_values = &values)
			{
				var result = ImPlotNative.ImSumU64Ptr(native_values, count);
				return result;
			}
		}

		public static double ImMeanFloatPtr(ref float values, int count)
		{
			fixed (float* native_values = &values)
			{
				var result = ImPlotNative.ImMeanFloatPtr(native_values, count);
				return result;
			}
		}

		public static double ImMeanDoublePtr(ref double values, int count)
		{
			fixed (double* native_values = &values)
			{
				var result = ImPlotNative.ImMeanDoublePtr(native_values, count);
				return result;
			}
		}

		public static double ImMeanS8Ptr(ref sbyte values, int count)
		{
			fixed (sbyte* native_values = &values)
			{
				var result = ImPlotNative.ImMeanS8Ptr(native_values, count);
				return result;
			}
		}

		public static double ImMeanU8Ptr(ReadOnlySpan<char> values, int count)
		{
			// Marshaling values to native string
			byte* native_values;
			var byteCount_values = 0;
			if (values != null)
			{
				byteCount_values = Encoding.UTF8.GetByteCount(values);
				if(byteCount_values > Utils.MaxStackallocSize)
				{
					native_values = Utils.Alloc<byte>(byteCount_values + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_values + 1];
					native_values = stackallocBytes;
				}
				var values_offset = Utils.EncodeStringUTF8(values, native_values, byteCount_values);
				native_values[values_offset] = 0;
			}
			else native_values = null;

			return ImPlotNative.ImMeanU8Ptr(native_values, count);
			// Freeing values native string
			if (byteCount_values > Utils.MaxStackallocSize)
				Utils.Free(native_values);
		}

		public static double ImMeanS16Ptr(ref short values, int count)
		{
			fixed (short* native_values = &values)
			{
				var result = ImPlotNative.ImMeanS16Ptr(native_values, count);
				return result;
			}
		}

		public static double ImMeanU16Ptr(ref ushort values, int count)
		{
			fixed (ushort* native_values = &values)
			{
				var result = ImPlotNative.ImMeanU16Ptr(native_values, count);
				return result;
			}
		}

		public static double ImMeanS32Ptr(ref int values, int count)
		{
			fixed (int* native_values = &values)
			{
				var result = ImPlotNative.ImMeanS32Ptr(native_values, count);
				return result;
			}
		}

		public static double ImMeanU32Ptr(ref uint values, int count)
		{
			fixed (uint* native_values = &values)
			{
				var result = ImPlotNative.ImMeanU32Ptr(native_values, count);
				return result;
			}
		}

		public static double ImMeanS64Ptr(ref long values, int count)
		{
			fixed (long* native_values = &values)
			{
				var result = ImPlotNative.ImMeanS64Ptr(native_values, count);
				return result;
			}
		}

		public static double ImMeanU64Ptr(ref ulong values, int count)
		{
			fixed (ulong* native_values = &values)
			{
				var result = ImPlotNative.ImMeanU64Ptr(native_values, count);
				return result;
			}
		}

		public static double ImStdDevFloatPtr(ref float values, int count)
		{
			fixed (float* native_values = &values)
			{
				var result = ImPlotNative.ImStdDevFloatPtr(native_values, count);
				return result;
			}
		}

		public static double ImStdDevDoublePtr(ref double values, int count)
		{
			fixed (double* native_values = &values)
			{
				var result = ImPlotNative.ImStdDevDoublePtr(native_values, count);
				return result;
			}
		}

		public static double ImStdDevS8Ptr(ref sbyte values, int count)
		{
			fixed (sbyte* native_values = &values)
			{
				var result = ImPlotNative.ImStdDevS8Ptr(native_values, count);
				return result;
			}
		}

		public static double ImStdDevU8Ptr(ReadOnlySpan<char> values, int count)
		{
			// Marshaling values to native string
			byte* native_values;
			var byteCount_values = 0;
			if (values != null)
			{
				byteCount_values = Encoding.UTF8.GetByteCount(values);
				if(byteCount_values > Utils.MaxStackallocSize)
				{
					native_values = Utils.Alloc<byte>(byteCount_values + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_values + 1];
					native_values = stackallocBytes;
				}
				var values_offset = Utils.EncodeStringUTF8(values, native_values, byteCount_values);
				native_values[values_offset] = 0;
			}
			else native_values = null;

			return ImPlotNative.ImStdDevU8Ptr(native_values, count);
			// Freeing values native string
			if (byteCount_values > Utils.MaxStackallocSize)
				Utils.Free(native_values);
		}

		public static double ImStdDevS16Ptr(ref short values, int count)
		{
			fixed (short* native_values = &values)
			{
				var result = ImPlotNative.ImStdDevS16Ptr(native_values, count);
				return result;
			}
		}

		public static double ImStdDevU16Ptr(ref ushort values, int count)
		{
			fixed (ushort* native_values = &values)
			{
				var result = ImPlotNative.ImStdDevU16Ptr(native_values, count);
				return result;
			}
		}

		public static double ImStdDevS32Ptr(ref int values, int count)
		{
			fixed (int* native_values = &values)
			{
				var result = ImPlotNative.ImStdDevS32Ptr(native_values, count);
				return result;
			}
		}

		public static double ImStdDevU32Ptr(ref uint values, int count)
		{
			fixed (uint* native_values = &values)
			{
				var result = ImPlotNative.ImStdDevU32Ptr(native_values, count);
				return result;
			}
		}

		public static double ImStdDevS64Ptr(ref long values, int count)
		{
			fixed (long* native_values = &values)
			{
				var result = ImPlotNative.ImStdDevS64Ptr(native_values, count);
				return result;
			}
		}

		public static double ImStdDevU64Ptr(ref ulong values, int count)
		{
			fixed (ulong* native_values = &values)
			{
				var result = ImPlotNative.ImStdDevU64Ptr(native_values, count);
				return result;
			}
		}

		public static uint ImMixU32(uint a, uint b, uint s)
		{
			return ImPlotNative.ImMixU32(a, b, s);
		}

		public static uint ImLerpU32(ref uint colors, int size, float t)
		{
			fixed (uint* native_colors = &colors)
			{
				var result = ImPlotNative.ImLerpU32(native_colors, size, t);
				return result;
			}
		}

		public static uint ImAlphaU32(uint col, float alpha)
		{
			return ImPlotNative.ImAlphaU32(col, alpha);
		}

		public static byte ImOverlapsFloat(float minA, float maxA, float minB, float maxB)
		{
			return ImPlotNative.ImOverlapsFloat(minA, maxA, minB, maxB);
		}

		public static byte ImOverlapsDouble(double minA, double maxA, double minB, double maxB)
		{
			return ImPlotNative.ImOverlapsDouble(minA, maxA, minB, maxB);
		}

		public static byte ImOverlapsS8(sbyte minA, sbyte maxA, sbyte minB, sbyte maxB)
		{
			return ImPlotNative.ImOverlapsS8(minA, maxA, minB, maxB);
		}

		public static byte ImOverlapsU8(bool minA, bool maxA, bool minB, bool maxB)
		{
			var native_minA = minA ? (byte)1 : (byte)0;
			var native_maxA = maxA ? (byte)1 : (byte)0;
			var native_minB = minB ? (byte)1 : (byte)0;
			var native_maxB = maxB ? (byte)1 : (byte)0;
			return ImPlotNative.ImOverlapsU8(native_minA, native_maxA, native_minB, native_maxB);
		}

		public static byte ImOverlapsS16(short minA, short maxA, short minB, short maxB)
		{
			return ImPlotNative.ImOverlapsS16(minA, maxA, minB, maxB);
		}

		public static byte ImOverlapsU16(ushort minA, ushort maxA, ushort minB, ushort maxB)
		{
			return ImPlotNative.ImOverlapsU16(minA, maxA, minB, maxB);
		}

		public static byte ImOverlapsS32(int minA, int maxA, int minB, int maxB)
		{
			return ImPlotNative.ImOverlapsS32(minA, maxA, minB, maxB);
		}

		public static byte ImOverlapsU32(uint minA, uint maxA, uint minB, uint maxB)
		{
			return ImPlotNative.ImOverlapsU32(minA, maxA, minB, maxB);
		}

		public static byte ImOverlapsS64(long minA, long maxA, long minB, long maxB)
		{
			return ImPlotNative.ImOverlapsS64(minA, maxA, minB, maxB);
		}

		public static byte ImOverlapsU64(ulong minA, ulong maxA, ulong minB, ulong maxB)
		{
			return ImPlotNative.ImOverlapsU64(minA, maxA, minB, maxB);
		}

		public static void Initialize(ImPlotContextPtr ctx)
		{
			ImPlotNative.Initialize(ctx);
		}

		public static void ResetCtxForNextPlot(ImPlotContextPtr ctx)
		{
			ImPlotNative.ResetCtxForNextPlot(ctx);
		}

		public static void ResetCtxForNextAlignedPlots(ImPlotContextPtr ctx)
		{
			ImPlotNative.ResetCtxForNextAlignedPlots(ctx);
		}

		public static void ResetCtxForNextSubplot(ImPlotContextPtr ctx)
		{
			ImPlotNative.ResetCtxForNextSubplot(ctx);
		}

		public static ImPlotPlotPtr GetPlot(ReadOnlySpan<char> title)
		{
			// Marshaling title to native string
			byte* native_title;
			var byteCount_title = 0;
			if (title != null)
			{
				byteCount_title = Encoding.UTF8.GetByteCount(title);
				if(byteCount_title > Utils.MaxStackallocSize)
				{
					native_title = Utils.Alloc<byte>(byteCount_title + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_title + 1];
					native_title = stackallocBytes;
				}
				var title_offset = Utils.EncodeStringUTF8(title, native_title, byteCount_title);
				native_title[title_offset] = 0;
			}
			else native_title = null;

			return ImPlotNative.GetPlot(native_title);
			// Freeing title native string
			if (byteCount_title > Utils.MaxStackallocSize)
				Utils.Free(native_title);
		}

		public static ImPlotPlotPtr GetCurrentPlot()
		{
			return ImPlotNative.GetCurrentPlot();
		}

		public static void BustPlotCache()
		{
			ImPlotNative.BustPlotCache();
		}

		public static void ShowPlotContextMenu(ImPlotPlotPtr plot)
		{
			ImPlotNative.ShowPlotContextMenu(plot);
		}

		public static void SetupLock()
		{
			ImPlotNative.SetupLock();
		}

		public static void SubplotNextCell()
		{
			ImPlotNative.SubplotNextCell();
		}

		public static void ShowSubplotsContextMenu(ImPlotSubplotPtr subplot)
		{
			ImPlotNative.ShowSubplotsContextMenu(subplot);
		}

		public static byte BeginItem(ReadOnlySpan<char> labelId, ImPlotItemFlags flags, ImPlotCol recolorFrom)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			return ImPlotNative.BeginItem(native_labelId, flags, recolorFrom);
			// Freeing labelId native string
			if (byteCount_labelId > Utils.MaxStackallocSize)
				Utils.Free(native_labelId);
		}

		public static void EndItem()
		{
			ImPlotNative.EndItem();
		}

		public static ImPlotItemPtr RegisterOrGetItem(ReadOnlySpan<char> labelId, ImPlotItemFlags flags, ReadOnlySpan<char> justCreated)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			// Marshaling justCreated to native string
			byte* native_justCreated;
			var byteCount_justCreated = 0;
			if (justCreated != null)
			{
				byteCount_justCreated = Encoding.UTF8.GetByteCount(justCreated);
				if(byteCount_justCreated > Utils.MaxStackallocSize)
				{
					native_justCreated = Utils.Alloc<byte>(byteCount_justCreated + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_justCreated + 1];
					native_justCreated = stackallocBytes;
				}
				var justCreated_offset = Utils.EncodeStringUTF8(justCreated, native_justCreated, byteCount_justCreated);
				native_justCreated[justCreated_offset] = 0;
			}
			else native_justCreated = null;

			return ImPlotNative.RegisterOrGetItem(native_labelId, flags, native_justCreated);
			// Freeing labelId native string
			if (byteCount_labelId > Utils.MaxStackallocSize)
				Utils.Free(native_labelId);
			// Freeing justCreated native string
			if (byteCount_justCreated > Utils.MaxStackallocSize)
				Utils.Free(native_justCreated);
		}

		public static ImPlotItemPtr GetItem(ReadOnlySpan<char> labelId)
		{
			// Marshaling labelId to native string
			byte* native_labelId;
			var byteCount_labelId = 0;
			if (labelId != null)
			{
				byteCount_labelId = Encoding.UTF8.GetByteCount(labelId);
				if(byteCount_labelId > Utils.MaxStackallocSize)
				{
					native_labelId = Utils.Alloc<byte>(byteCount_labelId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelId + 1];
					native_labelId = stackallocBytes;
				}
				var labelId_offset = Utils.EncodeStringUTF8(labelId, native_labelId, byteCount_labelId);
				native_labelId[labelId_offset] = 0;
			}
			else native_labelId = null;

			return ImPlotNative.GetItem(native_labelId);
			// Freeing labelId native string
			if (byteCount_labelId > Utils.MaxStackallocSize)
				Utils.Free(native_labelId);
		}

		public static ImPlotItemPtr GetCurrentItem()
		{
			return ImPlotNative.GetCurrentItem();
		}

		public static void BustItemCache()
		{
			ImPlotNative.BustItemCache();
		}

		public static byte AnyAxesInputLocked(ImPlotAxisPtr axes, int count)
		{
			return ImPlotNative.AnyAxesInputLocked(axes, count);
		}

		public static byte AllAxesInputLocked(ImPlotAxisPtr axes, int count)
		{
			return ImPlotNative.AllAxesInputLocked(axes, count);
		}

		public static byte AnyAxesHeld(ImPlotAxisPtr axes, int count)
		{
			return ImPlotNative.AnyAxesHeld(axes, count);
		}

		public static byte AnyAxesHovered(ImPlotAxisPtr axes, int count)
		{
			return ImPlotNative.AnyAxesHovered(axes, count);
		}

		public static byte FitThisFrame()
		{
			return ImPlotNative.FitThisFrame();
		}

		public static void FitPointX(double x)
		{
			ImPlotNative.FitPointX(x);
		}

		public static void FitPointY(double y)
		{
			ImPlotNative.FitPointY(y);
		}

		public static void FitPoint(ImPlotPoint p)
		{
			ImPlotNative.FitPoint(p);
		}

		public static byte RangesOverlap(ImPlotRange r1, ImPlotRange r2)
		{
			return ImPlotNative.RangesOverlap(r1, r2);
		}

		public static void ShowAxisContextMenu(ImPlotAxisPtr axis, ImPlotAxisPtr equalAxis, bool timeAllowed)
		{
			var native_timeAllowed = timeAllowed ? (byte)1 : (byte)0;
			ImPlotNative.ShowAxisContextMenu(axis, equalAxis, native_timeAllowed);
		}

		public static void GetLocationPos(ref Vector2 pOut, ImRect outerRect, Vector2 innerSize, ImPlotLocation location, Vector2 pad)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImPlotNative.GetLocationPos(native_pOut, outerRect, innerSize, location, pad);
			}
		}

		public static void CalcLegendSize(ref Vector2 pOut, ImPlotItemGroupPtr items, Vector2 pad, Vector2 spacing, bool vertical)
		{
			var native_vertical = vertical ? (byte)1 : (byte)0;
			fixed (Vector2* native_pOut = &pOut)
			{
				ImPlotNative.CalcLegendSize(native_pOut, items, pad, spacing, native_vertical);
			}
		}

		public static byte ClampLegendRect(ImRectPtr legendRect, ImRect outerRect, Vector2 pad)
		{
			return ImPlotNative.ClampLegendRect(legendRect, outerRect, pad);
		}

		public static byte ShowLegendEntries(ImPlotItemGroupPtr items, ImRect legendBb, bool interactable, Vector2 pad, Vector2 spacing, bool vertical, ImDrawListPtr drawList)
		{
			var native_interactable = interactable ? (byte)1 : (byte)0;
			var native_vertical = vertical ? (byte)1 : (byte)0;
			return ImPlotNative.ShowLegendEntries(items, legendBb, native_interactable, pad, spacing, native_vertical, drawList);
		}

		public static void ShowAltLegend(ReadOnlySpan<char> titleId, bool vertical, Vector2 size, bool interactable)
		{
			// Marshaling titleId to native string
			byte* native_titleId;
			var byteCount_titleId = 0;
			if (titleId != null)
			{
				byteCount_titleId = Encoding.UTF8.GetByteCount(titleId);
				if(byteCount_titleId > Utils.MaxStackallocSize)
				{
					native_titleId = Utils.Alloc<byte>(byteCount_titleId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_titleId + 1];
					native_titleId = stackallocBytes;
				}
				var titleId_offset = Utils.EncodeStringUTF8(titleId, native_titleId, byteCount_titleId);
				native_titleId[titleId_offset] = 0;
			}
			else native_titleId = null;

			var native_vertical = vertical ? (byte)1 : (byte)0;
			var native_interactable = interactable ? (byte)1 : (byte)0;
			ImPlotNative.ShowAltLegend(native_titleId, native_vertical, size, native_interactable);
			// Freeing titleId native string
			if (byteCount_titleId > Utils.MaxStackallocSize)
				Utils.Free(native_titleId);
		}

		public static byte ShowLegendContextMenu(ImPlotLegendPtr legend, bool visible)
		{
			var native_visible = visible ? (byte)1 : (byte)0;
			return ImPlotNative.ShowLegendContextMenu(legend, native_visible);
		}

		public static void LabelAxisValue(ImPlotAxis axis, double value, ReadOnlySpan<char> buff, int size, bool round)
		{
			// Marshaling buff to native string
			byte* native_buff;
			var byteCount_buff = 0;
			if (buff != null)
			{
				byteCount_buff = Encoding.UTF8.GetByteCount(buff);
				if(byteCount_buff > Utils.MaxStackallocSize)
				{
					native_buff = Utils.Alloc<byte>(byteCount_buff + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_buff + 1];
					native_buff = stackallocBytes;
				}
				var buff_offset = Utils.EncodeStringUTF8(buff, native_buff, byteCount_buff);
				native_buff[buff_offset] = 0;
			}
			else native_buff = null;

			var native_round = round ? (byte)1 : (byte)0;
			ImPlotNative.LabelAxisValue(axis, value, native_buff, size, native_round);
			// Freeing buff native string
			if (byteCount_buff > Utils.MaxStackallocSize)
				Utils.Free(native_buff);
		}

		public static ImPlotNextItemDataPtr GetItemData()
		{
			return ImPlotNative.GetItemData();
		}

		public static byte IsColorAutoVec4(Vector4 col)
		{
			return ImPlotNative.IsColorAutoVec4(col);
		}

		public static byte IsColorAutoPlotCol(ImPlotCol idx)
		{
			return ImPlotNative.IsColorAutoPlotCol(idx);
		}

		public static void GetAutoColor(ref Vector4 pOut, ImPlotCol idx)
		{
			fixed (Vector4* native_pOut = &pOut)
			{
				ImPlotNative.GetAutoColor(native_pOut, idx);
			}
		}

		public static void GetStyleColorVec4(ref Vector4 pOut, ImPlotCol idx)
		{
			fixed (Vector4* native_pOut = &pOut)
			{
				ImPlotNative.GetStyleColorVec4(native_pOut, idx);
			}
		}

		public static uint GetStyleColorU32(ImPlotCol idx)
		{
			return ImPlotNative.GetStyleColorU32(idx);
		}

		public static void AddTextVertical(ImDrawListPtr drawList, Vector2 pos, uint col, ReadOnlySpan<char> textBegin, ReadOnlySpan<char> textEnd)
		{
			// Marshaling textBegin to native string
			byte* native_textBegin;
			var byteCount_textBegin = 0;
			if (textBegin != null)
			{
				byteCount_textBegin = Encoding.UTF8.GetByteCount(textBegin);
				if(byteCount_textBegin > Utils.MaxStackallocSize)
				{
					native_textBegin = Utils.Alloc<byte>(byteCount_textBegin + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_textBegin + 1];
					native_textBegin = stackallocBytes;
				}
				var textBegin_offset = Utils.EncodeStringUTF8(textBegin, native_textBegin, byteCount_textBegin);
				native_textBegin[textBegin_offset] = 0;
			}
			else native_textBegin = null;

			// Marshaling textEnd to native string
			byte* native_textEnd;
			var byteCount_textEnd = 0;
			if (textEnd != null)
			{
				byteCount_textEnd = Encoding.UTF8.GetByteCount(textEnd);
				if(byteCount_textEnd > Utils.MaxStackallocSize)
				{
					native_textEnd = Utils.Alloc<byte>(byteCount_textEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_textEnd + 1];
					native_textEnd = stackallocBytes;
				}
				var textEnd_offset = Utils.EncodeStringUTF8(textEnd, native_textEnd, byteCount_textEnd);
				native_textEnd[textEnd_offset] = 0;
			}
			else native_textEnd = null;

			ImPlotNative.AddTextVertical(drawList, pos, col, native_textBegin, native_textEnd);
			// Freeing textBegin native string
			if (byteCount_textBegin > Utils.MaxStackallocSize)
				Utils.Free(native_textBegin);
			// Freeing textEnd native string
			if (byteCount_textEnd > Utils.MaxStackallocSize)
				Utils.Free(native_textEnd);
		}

		public static void AddTextCentered(ImDrawListPtr drawList, Vector2 topCenter, uint col, ReadOnlySpan<char> textBegin, ReadOnlySpan<char> textEnd)
		{
			// Marshaling textBegin to native string
			byte* native_textBegin;
			var byteCount_textBegin = 0;
			if (textBegin != null)
			{
				byteCount_textBegin = Encoding.UTF8.GetByteCount(textBegin);
				if(byteCount_textBegin > Utils.MaxStackallocSize)
				{
					native_textBegin = Utils.Alloc<byte>(byteCount_textBegin + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_textBegin + 1];
					native_textBegin = stackallocBytes;
				}
				var textBegin_offset = Utils.EncodeStringUTF8(textBegin, native_textBegin, byteCount_textBegin);
				native_textBegin[textBegin_offset] = 0;
			}
			else native_textBegin = null;

			// Marshaling textEnd to native string
			byte* native_textEnd;
			var byteCount_textEnd = 0;
			if (textEnd != null)
			{
				byteCount_textEnd = Encoding.UTF8.GetByteCount(textEnd);
				if(byteCount_textEnd > Utils.MaxStackallocSize)
				{
					native_textEnd = Utils.Alloc<byte>(byteCount_textEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_textEnd + 1];
					native_textEnd = stackallocBytes;
				}
				var textEnd_offset = Utils.EncodeStringUTF8(textEnd, native_textEnd, byteCount_textEnd);
				native_textEnd[textEnd_offset] = 0;
			}
			else native_textEnd = null;

			ImPlotNative.AddTextCentered(drawList, topCenter, col, native_textBegin, native_textEnd);
			// Freeing textBegin native string
			if (byteCount_textBegin > Utils.MaxStackallocSize)
				Utils.Free(native_textBegin);
			// Freeing textEnd native string
			if (byteCount_textEnd > Utils.MaxStackallocSize)
				Utils.Free(native_textEnd);
		}

		public static void CalcTextSizeVertical(ref Vector2 pOut, ReadOnlySpan<char> text)
		{
			// Marshaling text to native string
			byte* native_text;
			var byteCount_text = 0;
			if (text != null)
			{
				byteCount_text = Encoding.UTF8.GetByteCount(text);
				if(byteCount_text > Utils.MaxStackallocSize)
				{
					native_text = Utils.Alloc<byte>(byteCount_text + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_text + 1];
					native_text = stackallocBytes;
				}
				var text_offset = Utils.EncodeStringUTF8(text, native_text, byteCount_text);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			fixed (Vector2* native_pOut = &pOut)
			{
				ImPlotNative.CalcTextSizeVertical(native_pOut, native_text);
				// Freeing text native string
				if (byteCount_text > Utils.MaxStackallocSize)
					Utils.Free(native_text);
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

		public static uint CalcHoverColor(uint col)
		{
			return ImPlotNative.CalcHoverColor(col);
		}

		public static void ClampLabelPos(ref Vector2 pOut, Vector2 pos, Vector2 size, Vector2 min, Vector2 max)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImPlotNative.ClampLabelPos(native_pOut, pos, size, min, max);
			}
		}

		public static uint GetColormapColorU32(int idx, ImPlotColormap cmap)
		{
			return ImPlotNative.GetColormapColorU32(idx, cmap);
		}

		public static uint NextColormapColorU32()
		{
			return ImPlotNative.NextColormapColorU32();
		}

		public static uint SampleColormapU32(float t, ImPlotColormap cmap)
		{
			return ImPlotNative.SampleColormapU32(t, cmap);
		}

		public static void RenderColorBar(ref uint colors, int size, ImDrawListPtr drawList, ImRect bounds, bool vert, bool reversed, bool continuous)
		{
			var native_vert = vert ? (byte)1 : (byte)0;
			var native_reversed = reversed ? (byte)1 : (byte)0;
			var native_continuous = continuous ? (byte)1 : (byte)0;
			fixed (uint* native_colors = &colors)
			{
				ImPlotNative.RenderColorBar(native_colors, size, drawList, bounds, native_vert, native_reversed, native_continuous);
			}
		}

		public static double NiceNum(double x, bool round)
		{
			var native_round = round ? (byte)1 : (byte)0;
			return ImPlotNative.NiceNum(x, native_round);
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

		public static double RoundTo(double val, int prec)
		{
			return ImPlotNative.RoundTo(val, prec);
		}

		public static void Intersection(ref Vector2 pOut, Vector2 a1, Vector2 a2, Vector2 b1, Vector2 b2)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImPlotNative.Intersection(native_pOut, a1, a2, b1, b2);
			}
		}

		public static void FillRangeVectorFloatPtr(ref ImVector<float> buffer, int n, float vmin, float vmax)
		{
			fixed (ImVector<float>* native_buffer = &buffer)
			{
				ImPlotNative.FillRangeVectorFloatPtr(native_buffer, n, vmin, vmax);
			}
		}

		public static void FillRangeVectorDoublePtr(ref ImVector<double> buffer, int n, double vmin, double vmax)
		{
			fixed (ImVector<double>* native_buffer = &buffer)
			{
				ImPlotNative.FillRangeVectorDoublePtr(native_buffer, n, vmin, vmax);
			}
		}

		public static void FillRangeVectorS8Ptr(ref ImVector<sbyte> buffer, int n, sbyte vmin, sbyte vmax)
		{
			fixed (ImVector<sbyte>* native_buffer = &buffer)
			{
				ImPlotNative.FillRangeVectorS8Ptr(native_buffer, n, vmin, vmax);
			}
		}

		public static void FillRangeVectorU8Ptr(ref ImVector<byte> buffer, int n, bool vmin, bool vmax)
		{
			var native_vmin = vmin ? (byte)1 : (byte)0;
			var native_vmax = vmax ? (byte)1 : (byte)0;
			fixed (ImVector<byte>* native_buffer = &buffer)
			{
				ImPlotNative.FillRangeVectorU8Ptr(native_buffer, n, native_vmin, native_vmax);
			}
		}

		public static void FillRangeVectorS16Ptr(ref ImVector<short> buffer, int n, short vmin, short vmax)
		{
			fixed (ImVector<short>* native_buffer = &buffer)
			{
				ImPlotNative.FillRangeVectorS16Ptr(native_buffer, n, vmin, vmax);
			}
		}

		public static void FillRangeVectorU16Ptr(ref ImVector<ushort> buffer, int n, ushort vmin, ushort vmax)
		{
			fixed (ImVector<ushort>* native_buffer = &buffer)
			{
				ImPlotNative.FillRangeVectorU16Ptr(native_buffer, n, vmin, vmax);
			}
		}

		public static void FillRangeVectorS32Ptr(ref ImVector<int> buffer, int n, int vmin, int vmax)
		{
			fixed (ImVector<int>* native_buffer = &buffer)
			{
				ImPlotNative.FillRangeVectorS32Ptr(native_buffer, n, vmin, vmax);
			}
		}

		public static void FillRangeVectorU32Ptr(ref ImVector<uint> buffer, int n, uint vmin, uint vmax)
		{
			fixed (ImVector<uint>* native_buffer = &buffer)
			{
				ImPlotNative.FillRangeVectorU32Ptr(native_buffer, n, vmin, vmax);
			}
		}

		public static void FillRangeVectorS64Ptr(ref ImVector<long> buffer, int n, long vmin, long vmax)
		{
			fixed (ImVector<long>* native_buffer = &buffer)
			{
				ImPlotNative.FillRangeVectorS64Ptr(native_buffer, n, vmin, vmax);
			}
		}

		public static void FillRangeVectorU64Ptr(ref ImVector<ulong> buffer, int n, ulong vmin, ulong vmax)
		{
			fixed (ImVector<ulong>* native_buffer = &buffer)
			{
				ImPlotNative.FillRangeVectorU64Ptr(native_buffer, n, vmin, vmax);
			}
		}

		public static void CalculateBinsFloatPtr(ref float values, int count, ImPlotBin meth, ImPlotRange range, ref int binsOut, ref double widthOut)
		{
			fixed (float* native_values = &values)
			fixed (int* native_binsOut = &binsOut)
			fixed (double* native_widthOut = &widthOut)
			{
				ImPlotNative.CalculateBinsFloatPtr(native_values, count, meth, range, native_binsOut, native_widthOut);
			}
		}

		public static void CalculateBinsDoublePtr(ref double values, int count, ImPlotBin meth, ImPlotRange range, ref int binsOut, ref double widthOut)
		{
			fixed (double* native_values = &values)
			fixed (int* native_binsOut = &binsOut)
			fixed (double* native_widthOut = &widthOut)
			{
				ImPlotNative.CalculateBinsDoublePtr(native_values, count, meth, range, native_binsOut, native_widthOut);
			}
		}

		public static void CalculateBinsS8Ptr(ref sbyte values, int count, ImPlotBin meth, ImPlotRange range, ref int binsOut, ref double widthOut)
		{
			fixed (sbyte* native_values = &values)
			fixed (int* native_binsOut = &binsOut)
			fixed (double* native_widthOut = &widthOut)
			{
				ImPlotNative.CalculateBinsS8Ptr(native_values, count, meth, range, native_binsOut, native_widthOut);
			}
		}

		public static void CalculateBinsU8Ptr(ReadOnlySpan<char> values, int count, ImPlotBin meth, ImPlotRange range, ref int binsOut, ref double widthOut)
		{
			// Marshaling values to native string
			byte* native_values;
			var byteCount_values = 0;
			if (values != null)
			{
				byteCount_values = Encoding.UTF8.GetByteCount(values);
				if(byteCount_values > Utils.MaxStackallocSize)
				{
					native_values = Utils.Alloc<byte>(byteCount_values + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_values + 1];
					native_values = stackallocBytes;
				}
				var values_offset = Utils.EncodeStringUTF8(values, native_values, byteCount_values);
				native_values[values_offset] = 0;
			}
			else native_values = null;

			fixed (int* native_binsOut = &binsOut)
			fixed (double* native_widthOut = &widthOut)
			{
				ImPlotNative.CalculateBinsU8Ptr(native_values, count, meth, range, native_binsOut, native_widthOut);
				// Freeing values native string
				if (byteCount_values > Utils.MaxStackallocSize)
					Utils.Free(native_values);
			}
		}

		public static void CalculateBinsS16Ptr(ref short values, int count, ImPlotBin meth, ImPlotRange range, ref int binsOut, ref double widthOut)
		{
			fixed (short* native_values = &values)
			fixed (int* native_binsOut = &binsOut)
			fixed (double* native_widthOut = &widthOut)
			{
				ImPlotNative.CalculateBinsS16Ptr(native_values, count, meth, range, native_binsOut, native_widthOut);
			}
		}

		public static void CalculateBinsU16Ptr(ref ushort values, int count, ImPlotBin meth, ImPlotRange range, ref int binsOut, ref double widthOut)
		{
			fixed (ushort* native_values = &values)
			fixed (int* native_binsOut = &binsOut)
			fixed (double* native_widthOut = &widthOut)
			{
				ImPlotNative.CalculateBinsU16Ptr(native_values, count, meth, range, native_binsOut, native_widthOut);
			}
		}

		public static void CalculateBinsS32Ptr(ref int values, int count, ImPlotBin meth, ImPlotRange range, ref int binsOut, ref double widthOut)
		{
			fixed (int* native_values = &values)
			fixed (int* native_binsOut = &binsOut)
			fixed (double* native_widthOut = &widthOut)
			{
				ImPlotNative.CalculateBinsS32Ptr(native_values, count, meth, range, native_binsOut, native_widthOut);
			}
		}

		public static void CalculateBinsU32Ptr(ref uint values, int count, ImPlotBin meth, ImPlotRange range, ref int binsOut, ref double widthOut)
		{
			fixed (uint* native_values = &values)
			fixed (int* native_binsOut = &binsOut)
			fixed (double* native_widthOut = &widthOut)
			{
				ImPlotNative.CalculateBinsU32Ptr(native_values, count, meth, range, native_binsOut, native_widthOut);
			}
		}

		public static void CalculateBinsS64Ptr(ref long values, int count, ImPlotBin meth, ImPlotRange range, ref int binsOut, ref double widthOut)
		{
			fixed (long* native_values = &values)
			fixed (int* native_binsOut = &binsOut)
			fixed (double* native_widthOut = &widthOut)
			{
				ImPlotNative.CalculateBinsS64Ptr(native_values, count, meth, range, native_binsOut, native_widthOut);
			}
		}

		public static void CalculateBinsU64Ptr(ref ulong values, int count, ImPlotBin meth, ImPlotRange range, ref int binsOut, ref double widthOut)
		{
			fixed (ulong* native_values = &values)
			fixed (int* native_binsOut = &binsOut)
			fixed (double* native_widthOut = &widthOut)
			{
				ImPlotNative.CalculateBinsU64Ptr(native_values, count, meth, range, native_binsOut, native_widthOut);
			}
		}

		public static byte IsLeapYear(int year)
		{
			return ImPlotNative.IsLeapYear(year);
		}

		public static int GetDaysInMonth(int year, int month)
		{
			return ImPlotNative.GetDaysInMonth(year, month);
		}

		public static void MkGmtTime(ImPlotTimePtr pOut, TmPtr ptm)
		{
			ImPlotNative.MkGmtTime(pOut, ptm);
		}

		public static TmPtr GetGmtTime(ImPlotTime t, TmPtr ptm)
		{
			return ImPlotNative.GetGmtTime(t, ptm);
		}

		public static void MkLocTime(ImPlotTimePtr pOut, TmPtr ptm)
		{
			ImPlotNative.MkLocTime(pOut, ptm);
		}

		public static TmPtr GetLocTime(ImPlotTime t, TmPtr ptm)
		{
			return ImPlotNative.GetLocTime(t, ptm);
		}

		public static void MkTime(ImPlotTimePtr pOut, TmPtr ptm)
		{
			ImPlotNative.MkTime(pOut, ptm);
		}

		public static TmPtr GetTime(ImPlotTime t, TmPtr ptm)
		{
			return ImPlotNative.GetTime(t, ptm);
		}

		public static void MakeTime(ImPlotTimePtr pOut, int year, int month, int day, int hour, int min, int sec, int us)
		{
			ImPlotNative.MakeTime(pOut, year, month, day, hour, min, sec, us);
		}

		public static int GetYear(ImPlotTime t)
		{
			return ImPlotNative.GetYear(t);
		}

		public static int GetMonth(ImPlotTime t)
		{
			return ImPlotNative.GetMonth(t);
		}

		public static void AddTime(ImPlotTimePtr pOut, ImPlotTime t, ImPlotTimeUnit unit, int count)
		{
			ImPlotNative.AddTime(pOut, t, unit, count);
		}

		public static void FloorTime(ImPlotTimePtr pOut, ImPlotTime t, ImPlotTimeUnit unit)
		{
			ImPlotNative.FloorTime(pOut, t, unit);
		}

		public static void CeilTime(ImPlotTimePtr pOut, ImPlotTime t, ImPlotTimeUnit unit)
		{
			ImPlotNative.CeilTime(pOut, t, unit);
		}

		public static void RoundTime(ImPlotTimePtr pOut, ImPlotTime t, ImPlotTimeUnit unit)
		{
			ImPlotNative.RoundTime(pOut, t, unit);
		}

		public static void CombineDateTime(ImPlotTimePtr pOut, ImPlotTime datePart, ImPlotTime timePart)
		{
			ImPlotNative.CombineDateTime(pOut, datePart, timePart);
		}

		public static void Now(ImPlotTimePtr pOut)
		{
			ImPlotNative.Now(pOut);
		}

		public static void Today(ImPlotTimePtr pOut)
		{
			ImPlotNative.Today(pOut);
		}

		public static int FormatTime(ImPlotTime t, ReadOnlySpan<char> buffer, int size, ImPlotTimeFmt fmt, bool use_24HrClk)
		{
			// Marshaling buffer to native string
			byte* native_buffer;
			var byteCount_buffer = 0;
			if (buffer != null)
			{
				byteCount_buffer = Encoding.UTF8.GetByteCount(buffer);
				if(byteCount_buffer > Utils.MaxStackallocSize)
				{
					native_buffer = Utils.Alloc<byte>(byteCount_buffer + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_buffer + 1];
					native_buffer = stackallocBytes;
				}
				var buffer_offset = Utils.EncodeStringUTF8(buffer, native_buffer, byteCount_buffer);
				native_buffer[buffer_offset] = 0;
			}
			else native_buffer = null;

			var native_use_24HrClk = use_24HrClk ? (byte)1 : (byte)0;
			return ImPlotNative.FormatTime(t, native_buffer, size, fmt, native_use_24HrClk);
			// Freeing buffer native string
			if (byteCount_buffer > Utils.MaxStackallocSize)
				Utils.Free(native_buffer);
		}

		public static int FormatDate(ImPlotTime t, ReadOnlySpan<char> buffer, int size, ImPlotDateFmt fmt, bool useIso_8601)
		{
			// Marshaling buffer to native string
			byte* native_buffer;
			var byteCount_buffer = 0;
			if (buffer != null)
			{
				byteCount_buffer = Encoding.UTF8.GetByteCount(buffer);
				if(byteCount_buffer > Utils.MaxStackallocSize)
				{
					native_buffer = Utils.Alloc<byte>(byteCount_buffer + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_buffer + 1];
					native_buffer = stackallocBytes;
				}
				var buffer_offset = Utils.EncodeStringUTF8(buffer, native_buffer, byteCount_buffer);
				native_buffer[buffer_offset] = 0;
			}
			else native_buffer = null;

			var native_useIso_8601 = useIso_8601 ? (byte)1 : (byte)0;
			return ImPlotNative.FormatDate(t, native_buffer, size, fmt, native_useIso_8601);
			// Freeing buffer native string
			if (byteCount_buffer > Utils.MaxStackallocSize)
				Utils.Free(native_buffer);
		}

		public static int FormatDateTime(ImPlotTime t, ReadOnlySpan<char> buffer, int size, ImPlotDateTimeSpec fmt)
		{
			// Marshaling buffer to native string
			byte* native_buffer;
			var byteCount_buffer = 0;
			if (buffer != null)
			{
				byteCount_buffer = Encoding.UTF8.GetByteCount(buffer);
				if(byteCount_buffer > Utils.MaxStackallocSize)
				{
					native_buffer = Utils.Alloc<byte>(byteCount_buffer + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_buffer + 1];
					native_buffer = stackallocBytes;
				}
				var buffer_offset = Utils.EncodeStringUTF8(buffer, native_buffer, byteCount_buffer);
				native_buffer[buffer_offset] = 0;
			}
			else native_buffer = null;

			return ImPlotNative.FormatDateTime(t, native_buffer, size, fmt);
			// Freeing buffer native string
			if (byteCount_buffer > Utils.MaxStackallocSize)
				Utils.Free(native_buffer);
		}

		public static byte ShowDatePicker(ReadOnlySpan<char> id, ref int level, ImPlotTimePtr t, ImPlotTimePtr t1, ImPlotTimePtr t2)
		{
			// Marshaling id to native string
			byte* native_id;
			var byteCount_id = 0;
			if (id != null)
			{
				byteCount_id = Encoding.UTF8.GetByteCount(id);
				if(byteCount_id > Utils.MaxStackallocSize)
				{
					native_id = Utils.Alloc<byte>(byteCount_id + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_id + 1];
					native_id = stackallocBytes;
				}
				var id_offset = Utils.EncodeStringUTF8(id, native_id, byteCount_id);
				native_id[id_offset] = 0;
			}
			else native_id = null;

			fixed (int* native_level = &level)
			{
				var result = ImPlotNative.ShowDatePicker(native_id, native_level, t, t1, t2);
				// Freeing id native string
				if (byteCount_id > Utils.MaxStackallocSize)
					Utils.Free(native_id);
				return result;
			}
		}

		public static byte ShowTimePicker(ReadOnlySpan<char> id, ImPlotTimePtr t)
		{
			// Marshaling id to native string
			byte* native_id;
			var byteCount_id = 0;
			if (id != null)
			{
				byteCount_id = Encoding.UTF8.GetByteCount(id);
				if(byteCount_id > Utils.MaxStackallocSize)
				{
					native_id = Utils.Alloc<byte>(byteCount_id + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_id + 1];
					native_id = stackallocBytes;
				}
				var id_offset = Utils.EncodeStringUTF8(id, native_id, byteCount_id);
				native_id[id_offset] = 0;
			}
			else native_id = null;

			return ImPlotNative.ShowTimePicker(native_id, t);
			// Freeing id native string
			if (byteCount_id > Utils.MaxStackallocSize)
				Utils.Free(native_id);
		}

		public static double TransformForwardLog10(double v, IntPtr noname1)
		{
			return ImPlotNative.TransformForwardLog10(v, (void*)noname1);
		}

		public static double TransformInverseLog10(double v, IntPtr noname1)
		{
			return ImPlotNative.TransformInverseLog10(v, (void*)noname1);
		}

		public static double TransformForwardSymLog(double v, IntPtr noname1)
		{
			return ImPlotNative.TransformForwardSymLog(v, (void*)noname1);
		}

		public static double TransformInverseSymLog(double v, IntPtr noname1)
		{
			return ImPlotNative.TransformInverseSymLog(v, (void*)noname1);
		}

		public static double TransformForwardLogit(double v, IntPtr noname1)
		{
			return ImPlotNative.TransformForwardLogit(v, (void*)noname1);
		}

		public static double TransformInverseLogit(double v, IntPtr noname1)
		{
			return ImPlotNative.TransformInverseLogit(v, (void*)noname1);
		}

		public static int FormatterDefault(double value, ReadOnlySpan<char> buff, int size, IntPtr data)
		{
			// Marshaling buff to native string
			byte* native_buff;
			var byteCount_buff = 0;
			if (buff != null)
			{
				byteCount_buff = Encoding.UTF8.GetByteCount(buff);
				if(byteCount_buff > Utils.MaxStackallocSize)
				{
					native_buff = Utils.Alloc<byte>(byteCount_buff + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_buff + 1];
					native_buff = stackallocBytes;
				}
				var buff_offset = Utils.EncodeStringUTF8(buff, native_buff, byteCount_buff);
				native_buff[buff_offset] = 0;
			}
			else native_buff = null;

			return ImPlotNative.FormatterDefault(value, native_buff, size, (void*)data);
			// Freeing buff native string
			if (byteCount_buff > Utils.MaxStackallocSize)
				Utils.Free(native_buff);
		}

		public static int FormatterLogit(double value, ReadOnlySpan<char> buff, int size, IntPtr noname1)
		{
			// Marshaling buff to native string
			byte* native_buff;
			var byteCount_buff = 0;
			if (buff != null)
			{
				byteCount_buff = Encoding.UTF8.GetByteCount(buff);
				if(byteCount_buff > Utils.MaxStackallocSize)
				{
					native_buff = Utils.Alloc<byte>(byteCount_buff + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_buff + 1];
					native_buff = stackallocBytes;
				}
				var buff_offset = Utils.EncodeStringUTF8(buff, native_buff, byteCount_buff);
				native_buff[buff_offset] = 0;
			}
			else native_buff = null;

			return ImPlotNative.FormatterLogit(value, native_buff, size, (void*)noname1);
			// Freeing buff native string
			if (byteCount_buff > Utils.MaxStackallocSize)
				Utils.Free(native_buff);
		}

		public static int FormatterTime(double noname1, ReadOnlySpan<char> buff, int size, IntPtr data)
		{
			// Marshaling buff to native string
			byte* native_buff;
			var byteCount_buff = 0;
			if (buff != null)
			{
				byteCount_buff = Encoding.UTF8.GetByteCount(buff);
				if(byteCount_buff > Utils.MaxStackallocSize)
				{
					native_buff = Utils.Alloc<byte>(byteCount_buff + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_buff + 1];
					native_buff = stackallocBytes;
				}
				var buff_offset = Utils.EncodeStringUTF8(buff, native_buff, byteCount_buff);
				native_buff[buff_offset] = 0;
			}
			else native_buff = null;

			return ImPlotNative.FormatterTime(noname1, native_buff, size, (void*)data);
			// Freeing buff native string
			if (byteCount_buff > Utils.MaxStackallocSize)
				Utils.Free(native_buff);
		}

		public static void LocatorDefault(ImPlotTickerPtr ticker, ImPlotRange range, float pixels, bool vertical, ImPlotFormatter formatter, IntPtr formatterData)
		{
			var native_vertical = vertical ? (byte)1 : (byte)0;
			ImPlotNative.LocatorDefault(ticker, range, pixels, native_vertical, formatter, (void*)formatterData);
		}

		public static void LocatorTime(ImPlotTickerPtr ticker, ImPlotRange range, float pixels, bool vertical, ImPlotFormatter formatter, IntPtr formatterData)
		{
			var native_vertical = vertical ? (byte)1 : (byte)0;
			ImPlotNative.LocatorTime(ticker, range, pixels, native_vertical, formatter, (void*)formatterData);
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

	}
}
