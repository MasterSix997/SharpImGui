using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using SharpImGui;

namespace SharpImPlot
{
	public unsafe partial class ImPlotNative
	{
		static ImPlotNative()
		{
			InitApi(new NativeLibraryContext(LibraryLoader.LoadLibrary(GetLibraryName, null)));
		}

		public static string GetLibraryName()
		{
			return "cimplot";
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotPoint* PointPoint()
		{
			return (ImPlotPoint*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[0])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PointDestroy(ImPlotPoint* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotPoint* PointPointDouble(double x, double y)
		{
			return (ImPlotPoint*)((delegate* unmanaged[Cdecl]<double, double, IntPtr>)FuncTable[2])(x, y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotPoint* PointPoint(Vector2 p)
		{
			return (ImPlotPoint*)((delegate* unmanaged[Cdecl]<Vector2, IntPtr>)FuncTable[3])(p);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotRange* RangeRangeNil()
		{
			return (ImPlotRange*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[4])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RangeDestroy(ImPlotRange* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[5])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotRange* RangeRangeDouble(double min, double max)
		{
			return (ImPlotRange*)((delegate* unmanaged[Cdecl]<double, double, IntPtr>)FuncTable[6])(min, max);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte RangeContains(ImPlotRange* self, double value)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, double, byte>)FuncTable[7])((IntPtr)self, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double RangeSize(ImPlotRange* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, double>)FuncTable[8])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double RangeClamp(ImPlotRange* self, double value)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, double, double>)FuncTable[9])((IntPtr)self, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotRect* RectRectNil()
		{
			return (ImPlotRect*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[10])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectDestroy(ImPlotRect* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[11])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotRect* RectRectDouble(double xMin, double xMax, double yMin, double yMax)
		{
			return (ImPlotRect*)((delegate* unmanaged[Cdecl]<double, double, double, double, IntPtr>)FuncTable[12])(xMin, xMax, yMin, yMax);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte RectContainsPlotPoInt(ImPlotRect* self, ImPlotPoint p)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImPlotPoint, byte>)FuncTable[13])((IntPtr)self, p);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte RectContainsDouble(ImPlotRect* self, double x, double y)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, double, double, byte>)FuncTable[14])((IntPtr)self, x, y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectSize(ImPlotPoint* pOut, ImPlotRect* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[15])((IntPtr)pOut, (IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectClampPlotPoInt(ImPlotPoint* pOut, ImPlotRect* self, ImPlotPoint p)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImPlotPoint, void>)FuncTable[16])((IntPtr)pOut, (IntPtr)self, p);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectClampDouble(ImPlotPoint* pOut, ImPlotRect* self, double x, double y)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, double, void>)FuncTable[17])((IntPtr)pOut, (IntPtr)self, x, y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectMin(ImPlotPoint* pOut, ImPlotRect* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[18])((IntPtr)pOut, (IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RectMax(ImPlotPoint* pOut, ImPlotRect* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[19])((IntPtr)pOut, (IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotStyle* StyleStyle()
		{
			return (ImPlotStyle*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[20])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void StyleDestroy(ImPlotStyle* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[21])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotInputMap* InputMapInputMap()
		{
			return (ImPlotInputMap*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[22])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InputMapDestroy(ImPlotInputMap* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[23])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotContext* CreateContext()
		{
			return (ImPlotContext*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[24])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DestroyContext(ImPlotContext* ctx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[25])((IntPtr)ctx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotContext* GetCurrentContext()
		{
			return (ImPlotContext*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[26])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCurrentContext(ImPlotContext* ctx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[27])((IntPtr)ctx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetImGuiContext(ImGuiContext* ctx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[28])((IntPtr)ctx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginPlot(byte* titleId, Vector2 size, ImPlotFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, Vector2, ImPlotFlags, byte>)FuncTable[29])((IntPtr)titleId, size, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void EndPlot()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[30])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginSubplots(byte* titleId, int rows, int cols, Vector2 size, ImPlotSubplotFlags flags, float* rowRatios, float* colRatios)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, int, Vector2, ImPlotSubplotFlags, IntPtr, IntPtr, byte>)FuncTable[31])((IntPtr)titleId, rows, cols, size, flags, (IntPtr)rowRatios, (IntPtr)colRatios);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void EndSubplots()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[32])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetupAxis(ImAxis axis, byte* label, ImPlotAxisFlags flags)
		{
			((delegate* unmanaged[Cdecl]<ImAxis, IntPtr, ImPlotAxisFlags, void>)FuncTable[33])(axis, (IntPtr)label, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetupAxisLimits(ImAxis axis, double vMin, double vMax, ImPlotCond cond)
		{
			((delegate* unmanaged[Cdecl]<ImAxis, double, double, ImPlotCond, void>)FuncTable[34])(axis, vMin, vMax, cond);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetupAxisLinks(ImAxis axis, double* linkMin, double* linkMax)
		{
			((delegate* unmanaged[Cdecl]<ImAxis, IntPtr, IntPtr, void>)FuncTable[35])(axis, (IntPtr)linkMin, (IntPtr)linkMax);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetupAxisFormatStr(ImAxis axis, byte* fmt)
		{
			((delegate* unmanaged[Cdecl]<ImAxis, IntPtr, void>)FuncTable[36])(axis, (IntPtr)fmt);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetupAxisFormatPlotFormatter(ImAxis axis, IntPtr formatter, void* data)
		{
			((delegate* unmanaged[Cdecl]<ImAxis, IntPtr, IntPtr, void>)FuncTable[37])(axis, formatter, (IntPtr)data);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetupAxisTicksDoublePtr(ImAxis axis, double* values, int nTicks, byte** labels, byte keepDefault)
		{
			((delegate* unmanaged[Cdecl]<ImAxis, IntPtr, int, IntPtr, byte, void>)FuncTable[38])(axis, (IntPtr)values, nTicks, (IntPtr)labels, keepDefault);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetupAxisTicksDouble(ImAxis axis, double vMin, double vMax, int nTicks, byte** labels, byte keepDefault)
		{
			((delegate* unmanaged[Cdecl]<ImAxis, double, double, int, IntPtr, byte, void>)FuncTable[39])(axis, vMin, vMax, nTicks, (IntPtr)labels, keepDefault);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetupAxisScalePlotScale(ImAxis axis, ImPlotScale scale)
		{
			((delegate* unmanaged[Cdecl]<ImAxis, ImPlotScale, void>)FuncTable[40])(axis, scale);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetupAxisScalePlotTransform(ImAxis axis, IntPtr forward, IntPtr inverse, void* data)
		{
			((delegate* unmanaged[Cdecl]<ImAxis, IntPtr, IntPtr, IntPtr, void>)FuncTable[41])(axis, forward, inverse, (IntPtr)data);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetupAxisLimitsConstraints(ImAxis axis, double vMin, double vMax)
		{
			((delegate* unmanaged[Cdecl]<ImAxis, double, double, void>)FuncTable[42])(axis, vMin, vMax);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetupAxisZoomConstraints(ImAxis axis, double zMin, double zMax)
		{
			((delegate* unmanaged[Cdecl]<ImAxis, double, double, void>)FuncTable[43])(axis, zMin, zMax);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetupAxes(byte* xLabel, byte* yLabel, ImPlotAxisFlags xFlags, ImPlotAxisFlags yFlags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImPlotAxisFlags, ImPlotAxisFlags, void>)FuncTable[44])((IntPtr)xLabel, (IntPtr)yLabel, xFlags, yFlags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetupAxesLimits(double xMin, double xMax, double yMin, double yMax, ImPlotCond cond)
		{
			((delegate* unmanaged[Cdecl]<double, double, double, double, ImPlotCond, void>)FuncTable[45])(xMin, xMax, yMin, yMax, cond);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetupLegend(ImPlotLocation location, ImPlotLegendFlags flags)
		{
			((delegate* unmanaged[Cdecl]<ImPlotLocation, ImPlotLegendFlags, void>)FuncTable[46])(location, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetupMouseText(ImPlotLocation location, ImPlotMouseTextFlags flags)
		{
			((delegate* unmanaged[Cdecl]<ImPlotLocation, ImPlotMouseTextFlags, void>)FuncTable[47])(location, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetupFinish()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[48])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetNextAxisLimits(ImAxis axis, double vMin, double vMax, ImPlotCond cond)
		{
			((delegate* unmanaged[Cdecl]<ImAxis, double, double, ImPlotCond, void>)FuncTable[49])(axis, vMin, vMax, cond);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetNextAxisLinks(ImAxis axis, double* linkMin, double* linkMax)
		{
			((delegate* unmanaged[Cdecl]<ImAxis, IntPtr, IntPtr, void>)FuncTable[50])(axis, (IntPtr)linkMin, (IntPtr)linkMax);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetNextAxisToFit(ImAxis axis)
		{
			((delegate* unmanaged[Cdecl]<ImAxis, void>)FuncTable[51])(axis);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetNextAxesLimits(double xMin, double xMax, double yMin, double yMax, ImPlotCond cond)
		{
			((delegate* unmanaged[Cdecl]<double, double, double, double, ImPlotCond, void>)FuncTable[52])(xMin, xMax, yMin, yMax, cond);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetNextAxesToFit()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[53])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotLineFloatPtrInt(byte* labelId, float* values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, ImPlotLineFlags, int, int, void>)FuncTable[54])((IntPtr)labelId, (IntPtr)values, count, xscale, xstart, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotLineDoublePtrInt(byte* labelId, double* values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, ImPlotLineFlags, int, int, void>)FuncTable[55])((IntPtr)labelId, (IntPtr)values, count, xscale, xstart, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotLineS8PtrInt(byte* labelId, sbyte* values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, ImPlotLineFlags, int, int, void>)FuncTable[56])((IntPtr)labelId, (IntPtr)values, count, xscale, xstart, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotLineU8PtrInt(byte* labelId, byte* values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, ImPlotLineFlags, int, int, void>)FuncTable[57])((IntPtr)labelId, (IntPtr)values, count, xscale, xstart, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotLineS16PtrInt(byte* labelId, short* values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, ImPlotLineFlags, int, int, void>)FuncTable[58])((IntPtr)labelId, (IntPtr)values, count, xscale, xstart, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotLineU16PtrInt(byte* labelId, ushort* values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, ImPlotLineFlags, int, int, void>)FuncTable[59])((IntPtr)labelId, (IntPtr)values, count, xscale, xstart, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotLineS32PtrInt(byte* labelId, int* values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, ImPlotLineFlags, int, int, void>)FuncTable[60])((IntPtr)labelId, (IntPtr)values, count, xscale, xstart, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotLineU32PtrInt(byte* labelId, uint* values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, ImPlotLineFlags, int, int, void>)FuncTable[61])((IntPtr)labelId, (IntPtr)values, count, xscale, xstart, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotLineS64PtrInt(byte* labelId, long* values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, ImPlotLineFlags, int, int, void>)FuncTable[62])((IntPtr)labelId, (IntPtr)values, count, xscale, xstart, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotLineU64PtrInt(byte* labelId, ulong* values, int count, double xscale, double xstart, ImPlotLineFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, ImPlotLineFlags, int, int, void>)FuncTable[63])((IntPtr)labelId, (IntPtr)values, count, xscale, xstart, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotLineFloatPtrFloatPtr(byte* labelId, float* xs, float* ys, int count, ImPlotLineFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotLineFlags, int, int, void>)FuncTable[64])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotLineDoublePtrdoublePtr(byte* labelId, double* xs, double* ys, int count, ImPlotLineFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotLineFlags, int, int, void>)FuncTable[65])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotLineS8PtrS8Ptr(byte* labelId, sbyte* xs, sbyte* ys, int count, ImPlotLineFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotLineFlags, int, int, void>)FuncTable[66])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotLineU8PtrU8Ptr(byte* labelId, byte* xs, byte* ys, int count, ImPlotLineFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotLineFlags, int, int, void>)FuncTable[67])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotLineS16PtrS16Ptr(byte* labelId, short* xs, short* ys, int count, ImPlotLineFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotLineFlags, int, int, void>)FuncTable[68])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotLineU16PtrU16Ptr(byte* labelId, ushort* xs, ushort* ys, int count, ImPlotLineFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotLineFlags, int, int, void>)FuncTable[69])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotLineS32PtrS32Ptr(byte* labelId, int* xs, int* ys, int count, ImPlotLineFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotLineFlags, int, int, void>)FuncTable[70])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotLineU32PtrU32Ptr(byte* labelId, uint* xs, uint* ys, int count, ImPlotLineFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotLineFlags, int, int, void>)FuncTable[71])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotLineS64PtrS64Ptr(byte* labelId, long* xs, long* ys, int count, ImPlotLineFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotLineFlags, int, int, void>)FuncTable[72])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotLineU64PtrU64Ptr(byte* labelId, ulong* xs, ulong* ys, int count, ImPlotLineFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotLineFlags, int, int, void>)FuncTable[73])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotLineG(byte* labelId, void* getter, void* data, int count, ImPlotLineFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotLineFlags, void>)FuncTable[74])((IntPtr)labelId, (IntPtr)getter, (IntPtr)data, count, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotScatterFloatPtrInt(byte* labelId, float* values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, ImPlotScatterFlags, int, int, void>)FuncTable[75])((IntPtr)labelId, (IntPtr)values, count, xscale, xstart, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotScatterDoublePtrInt(byte* labelId, double* values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, ImPlotScatterFlags, int, int, void>)FuncTable[76])((IntPtr)labelId, (IntPtr)values, count, xscale, xstart, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotScatterS8PtrInt(byte* labelId, sbyte* values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, ImPlotScatterFlags, int, int, void>)FuncTable[77])((IntPtr)labelId, (IntPtr)values, count, xscale, xstart, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotScatterU8PtrInt(byte* labelId, byte* values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, ImPlotScatterFlags, int, int, void>)FuncTable[78])((IntPtr)labelId, (IntPtr)values, count, xscale, xstart, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotScatterS16PtrInt(byte* labelId, short* values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, ImPlotScatterFlags, int, int, void>)FuncTable[79])((IntPtr)labelId, (IntPtr)values, count, xscale, xstart, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotScatterU16PtrInt(byte* labelId, ushort* values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, ImPlotScatterFlags, int, int, void>)FuncTable[80])((IntPtr)labelId, (IntPtr)values, count, xscale, xstart, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotScatterS32PtrInt(byte* labelId, int* values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, ImPlotScatterFlags, int, int, void>)FuncTable[81])((IntPtr)labelId, (IntPtr)values, count, xscale, xstart, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotScatterU32PtrInt(byte* labelId, uint* values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, ImPlotScatterFlags, int, int, void>)FuncTable[82])((IntPtr)labelId, (IntPtr)values, count, xscale, xstart, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotScatterS64PtrInt(byte* labelId, long* values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, ImPlotScatterFlags, int, int, void>)FuncTable[83])((IntPtr)labelId, (IntPtr)values, count, xscale, xstart, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotScatterU64PtrInt(byte* labelId, ulong* values, int count, double xscale, double xstart, ImPlotScatterFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, ImPlotScatterFlags, int, int, void>)FuncTable[84])((IntPtr)labelId, (IntPtr)values, count, xscale, xstart, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotScatterFloatPtrFloatPtr(byte* labelId, float* xs, float* ys, int count, ImPlotScatterFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotScatterFlags, int, int, void>)FuncTable[85])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotScatterDoublePtrdoublePtr(byte* labelId, double* xs, double* ys, int count, ImPlotScatterFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotScatterFlags, int, int, void>)FuncTable[86])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotScatterS8PtrS8Ptr(byte* labelId, sbyte* xs, sbyte* ys, int count, ImPlotScatterFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotScatterFlags, int, int, void>)FuncTable[87])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotScatterU8PtrU8Ptr(byte* labelId, byte* xs, byte* ys, int count, ImPlotScatterFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotScatterFlags, int, int, void>)FuncTable[88])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotScatterS16PtrS16Ptr(byte* labelId, short* xs, short* ys, int count, ImPlotScatterFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotScatterFlags, int, int, void>)FuncTable[89])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotScatterU16PtrU16Ptr(byte* labelId, ushort* xs, ushort* ys, int count, ImPlotScatterFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotScatterFlags, int, int, void>)FuncTable[90])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotScatterS32PtrS32Ptr(byte* labelId, int* xs, int* ys, int count, ImPlotScatterFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotScatterFlags, int, int, void>)FuncTable[91])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotScatterU32PtrU32Ptr(byte* labelId, uint* xs, uint* ys, int count, ImPlotScatterFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotScatterFlags, int, int, void>)FuncTable[92])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotScatterS64PtrS64Ptr(byte* labelId, long* xs, long* ys, int count, ImPlotScatterFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotScatterFlags, int, int, void>)FuncTable[93])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotScatterU64PtrU64Ptr(byte* labelId, ulong* xs, ulong* ys, int count, ImPlotScatterFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotScatterFlags, int, int, void>)FuncTable[94])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotScatterG(byte* labelId, void* getter, void* data, int count, ImPlotScatterFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotScatterFlags, void>)FuncTable[95])((IntPtr)labelId, (IntPtr)getter, (IntPtr)data, count, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotStairsFloatPtrInt(byte* labelId, float* values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, ImPlotStairsFlags, int, int, void>)FuncTable[96])((IntPtr)labelId, (IntPtr)values, count, xscale, xstart, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotStairsDoublePtrInt(byte* labelId, double* values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, ImPlotStairsFlags, int, int, void>)FuncTable[97])((IntPtr)labelId, (IntPtr)values, count, xscale, xstart, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotStairsS8PtrInt(byte* labelId, sbyte* values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, ImPlotStairsFlags, int, int, void>)FuncTable[98])((IntPtr)labelId, (IntPtr)values, count, xscale, xstart, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotStairsU8PtrInt(byte* labelId, byte* values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, ImPlotStairsFlags, int, int, void>)FuncTable[99])((IntPtr)labelId, (IntPtr)values, count, xscale, xstart, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotStairsS16PtrInt(byte* labelId, short* values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, ImPlotStairsFlags, int, int, void>)FuncTable[100])((IntPtr)labelId, (IntPtr)values, count, xscale, xstart, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotStairsU16PtrInt(byte* labelId, ushort* values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, ImPlotStairsFlags, int, int, void>)FuncTable[101])((IntPtr)labelId, (IntPtr)values, count, xscale, xstart, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotStairsS32PtrInt(byte* labelId, int* values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, ImPlotStairsFlags, int, int, void>)FuncTable[102])((IntPtr)labelId, (IntPtr)values, count, xscale, xstart, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotStairsU32PtrInt(byte* labelId, uint* values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, ImPlotStairsFlags, int, int, void>)FuncTable[103])((IntPtr)labelId, (IntPtr)values, count, xscale, xstart, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotStairsS64PtrInt(byte* labelId, long* values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, ImPlotStairsFlags, int, int, void>)FuncTable[104])((IntPtr)labelId, (IntPtr)values, count, xscale, xstart, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotStairsU64PtrInt(byte* labelId, ulong* values, int count, double xscale, double xstart, ImPlotStairsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, ImPlotStairsFlags, int, int, void>)FuncTable[105])((IntPtr)labelId, (IntPtr)values, count, xscale, xstart, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotStairsFloatPtrFloatPtr(byte* labelId, float* xs, float* ys, int count, ImPlotStairsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotStairsFlags, int, int, void>)FuncTable[106])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotStairsDoublePtrdoublePtr(byte* labelId, double* xs, double* ys, int count, ImPlotStairsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotStairsFlags, int, int, void>)FuncTable[107])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotStairsS8PtrS8Ptr(byte* labelId, sbyte* xs, sbyte* ys, int count, ImPlotStairsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotStairsFlags, int, int, void>)FuncTable[108])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotStairsU8PtrU8Ptr(byte* labelId, byte* xs, byte* ys, int count, ImPlotStairsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotStairsFlags, int, int, void>)FuncTable[109])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotStairsS16PtrS16Ptr(byte* labelId, short* xs, short* ys, int count, ImPlotStairsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotStairsFlags, int, int, void>)FuncTable[110])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotStairsU16PtrU16Ptr(byte* labelId, ushort* xs, ushort* ys, int count, ImPlotStairsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotStairsFlags, int, int, void>)FuncTable[111])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotStairsS32PtrS32Ptr(byte* labelId, int* xs, int* ys, int count, ImPlotStairsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotStairsFlags, int, int, void>)FuncTable[112])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotStairsU32PtrU32Ptr(byte* labelId, uint* xs, uint* ys, int count, ImPlotStairsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotStairsFlags, int, int, void>)FuncTable[113])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotStairsS64PtrS64Ptr(byte* labelId, long* xs, long* ys, int count, ImPlotStairsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotStairsFlags, int, int, void>)FuncTable[114])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotStairsU64PtrU64Ptr(byte* labelId, ulong* xs, ulong* ys, int count, ImPlotStairsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotStairsFlags, int, int, void>)FuncTable[115])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotStairsG(byte* labelId, void* getter, void* data, int count, ImPlotStairsFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotStairsFlags, void>)FuncTable[116])((IntPtr)labelId, (IntPtr)getter, (IntPtr)data, count, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotShadedFloatPtrInt(byte* labelId, float* values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, double, ImPlotShadedFlags, int, int, void>)FuncTable[117])((IntPtr)labelId, (IntPtr)values, count, yref, xscale, xstart, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotShadedDoublePtrInt(byte* labelId, double* values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, double, ImPlotShadedFlags, int, int, void>)FuncTable[118])((IntPtr)labelId, (IntPtr)values, count, yref, xscale, xstart, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotShadedS8PtrInt(byte* labelId, sbyte* values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, double, ImPlotShadedFlags, int, int, void>)FuncTable[119])((IntPtr)labelId, (IntPtr)values, count, yref, xscale, xstart, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotShadedU8PtrInt(byte* labelId, byte* values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, double, ImPlotShadedFlags, int, int, void>)FuncTable[120])((IntPtr)labelId, (IntPtr)values, count, yref, xscale, xstart, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotShadedS16PtrInt(byte* labelId, short* values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, double, ImPlotShadedFlags, int, int, void>)FuncTable[121])((IntPtr)labelId, (IntPtr)values, count, yref, xscale, xstart, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotShadedU16PtrInt(byte* labelId, ushort* values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, double, ImPlotShadedFlags, int, int, void>)FuncTable[122])((IntPtr)labelId, (IntPtr)values, count, yref, xscale, xstart, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotShadedS32PtrInt(byte* labelId, int* values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, double, ImPlotShadedFlags, int, int, void>)FuncTable[123])((IntPtr)labelId, (IntPtr)values, count, yref, xscale, xstart, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotShadedU32PtrInt(byte* labelId, uint* values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, double, ImPlotShadedFlags, int, int, void>)FuncTable[124])((IntPtr)labelId, (IntPtr)values, count, yref, xscale, xstart, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotShadedS64PtrInt(byte* labelId, long* values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, double, ImPlotShadedFlags, int, int, void>)FuncTable[125])((IntPtr)labelId, (IntPtr)values, count, yref, xscale, xstart, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotShadedU64PtrInt(byte* labelId, ulong* values, int count, double yref, double xscale, double xstart, ImPlotShadedFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, double, ImPlotShadedFlags, int, int, void>)FuncTable[126])((IntPtr)labelId, (IntPtr)values, count, yref, xscale, xstart, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotShadedFloatPtrFloatPtrInt(byte* labelId, float* xs, float* ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, double, ImPlotShadedFlags, int, int, void>)FuncTable[127])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, yref, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotShadedDoublePtrdoublePtrInt(byte* labelId, double* xs, double* ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, double, ImPlotShadedFlags, int, int, void>)FuncTable[128])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, yref, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotShadedS8PtrS8PtrInt(byte* labelId, sbyte* xs, sbyte* ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, double, ImPlotShadedFlags, int, int, void>)FuncTable[129])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, yref, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotShadedU8PtrU8PtrInt(byte* labelId, byte* xs, byte* ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, double, ImPlotShadedFlags, int, int, void>)FuncTable[130])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, yref, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotShadedS16PtrS16PtrInt(byte* labelId, short* xs, short* ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, double, ImPlotShadedFlags, int, int, void>)FuncTable[131])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, yref, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotShadedU16PtrU16PtrInt(byte* labelId, ushort* xs, ushort* ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, double, ImPlotShadedFlags, int, int, void>)FuncTable[132])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, yref, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotShadedS32PtrS32PtrInt(byte* labelId, int* xs, int* ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, double, ImPlotShadedFlags, int, int, void>)FuncTable[133])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, yref, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotShadedU32PtrU32PtrInt(byte* labelId, uint* xs, uint* ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, double, ImPlotShadedFlags, int, int, void>)FuncTable[134])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, yref, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotShadedS64PtrS64PtrInt(byte* labelId, long* xs, long* ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, double, ImPlotShadedFlags, int, int, void>)FuncTable[135])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, yref, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotShadedU64PtrU64PtrInt(byte* labelId, ulong* xs, ulong* ys, int count, double yref, ImPlotShadedFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, double, ImPlotShadedFlags, int, int, void>)FuncTable[136])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, yref, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotShadedFloatPtrFloatPtrFloatPtr(byte* labelId, float* xs, float* ys1, float* ys2, int count, ImPlotShadedFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlotShadedFlags, int, int, void>)FuncTable[137])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys1, (IntPtr)ys2, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotShadedDoublePtrdoublePtrdoublePtr(byte* labelId, double* xs, double* ys1, double* ys2, int count, ImPlotShadedFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlotShadedFlags, int, int, void>)FuncTable[138])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys1, (IntPtr)ys2, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotShadedS8PtrS8PtrS8Ptr(byte* labelId, sbyte* xs, sbyte* ys1, sbyte* ys2, int count, ImPlotShadedFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlotShadedFlags, int, int, void>)FuncTable[139])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys1, (IntPtr)ys2, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotShadedU8PtrU8PtrU8Ptr(byte* labelId, byte* xs, byte* ys1, byte* ys2, int count, ImPlotShadedFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlotShadedFlags, int, int, void>)FuncTable[140])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys1, (IntPtr)ys2, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotShadedS16PtrS16PtrS16Ptr(byte* labelId, short* xs, short* ys1, short* ys2, int count, ImPlotShadedFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlotShadedFlags, int, int, void>)FuncTable[141])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys1, (IntPtr)ys2, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotShadedU16PtrU16PtrU16Ptr(byte* labelId, ushort* xs, ushort* ys1, ushort* ys2, int count, ImPlotShadedFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlotShadedFlags, int, int, void>)FuncTable[142])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys1, (IntPtr)ys2, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotShadedS32PtrS32PtrS32Ptr(byte* labelId, int* xs, int* ys1, int* ys2, int count, ImPlotShadedFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlotShadedFlags, int, int, void>)FuncTable[143])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys1, (IntPtr)ys2, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotShadedU32PtrU32PtrU32Ptr(byte* labelId, uint* xs, uint* ys1, uint* ys2, int count, ImPlotShadedFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlotShadedFlags, int, int, void>)FuncTable[144])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys1, (IntPtr)ys2, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotShadedS64PtrS64PtrS64Ptr(byte* labelId, long* xs, long* ys1, long* ys2, int count, ImPlotShadedFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlotShadedFlags, int, int, void>)FuncTable[145])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys1, (IntPtr)ys2, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotShadedU64PtrU64PtrU64Ptr(byte* labelId, ulong* xs, ulong* ys1, ulong* ys2, int count, ImPlotShadedFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlotShadedFlags, int, int, void>)FuncTable[146])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys1, (IntPtr)ys2, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotShadedG(byte* labelId, void* getter1, void* data1, void* getter2, void* data2, int count, ImPlotShadedFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlotShadedFlags, void>)FuncTable[147])((IntPtr)labelId, (IntPtr)getter1, (IntPtr)data1, (IntPtr)getter2, (IntPtr)data2, count, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotBarsFloatPtrInt(byte* labelId, float* values, int count, double barSize, double shift, ImPlotBarsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, ImPlotBarsFlags, int, int, void>)FuncTable[148])((IntPtr)labelId, (IntPtr)values, count, barSize, shift, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotBarsDoublePtrInt(byte* labelId, double* values, int count, double barSize, double shift, ImPlotBarsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, ImPlotBarsFlags, int, int, void>)FuncTable[149])((IntPtr)labelId, (IntPtr)values, count, barSize, shift, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotBarsS8PtrInt(byte* labelId, sbyte* values, int count, double barSize, double shift, ImPlotBarsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, ImPlotBarsFlags, int, int, void>)FuncTable[150])((IntPtr)labelId, (IntPtr)values, count, barSize, shift, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotBarsU8PtrInt(byte* labelId, byte* values, int count, double barSize, double shift, ImPlotBarsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, ImPlotBarsFlags, int, int, void>)FuncTable[151])((IntPtr)labelId, (IntPtr)values, count, barSize, shift, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotBarsS16PtrInt(byte* labelId, short* values, int count, double barSize, double shift, ImPlotBarsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, ImPlotBarsFlags, int, int, void>)FuncTable[152])((IntPtr)labelId, (IntPtr)values, count, barSize, shift, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotBarsU16PtrInt(byte* labelId, ushort* values, int count, double barSize, double shift, ImPlotBarsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, ImPlotBarsFlags, int, int, void>)FuncTable[153])((IntPtr)labelId, (IntPtr)values, count, barSize, shift, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotBarsS32PtrInt(byte* labelId, int* values, int count, double barSize, double shift, ImPlotBarsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, ImPlotBarsFlags, int, int, void>)FuncTable[154])((IntPtr)labelId, (IntPtr)values, count, barSize, shift, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotBarsU32PtrInt(byte* labelId, uint* values, int count, double barSize, double shift, ImPlotBarsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, ImPlotBarsFlags, int, int, void>)FuncTable[155])((IntPtr)labelId, (IntPtr)values, count, barSize, shift, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotBarsS64PtrInt(byte* labelId, long* values, int count, double barSize, double shift, ImPlotBarsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, ImPlotBarsFlags, int, int, void>)FuncTable[156])((IntPtr)labelId, (IntPtr)values, count, barSize, shift, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotBarsU64PtrInt(byte* labelId, ulong* values, int count, double barSize, double shift, ImPlotBarsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, ImPlotBarsFlags, int, int, void>)FuncTable[157])((IntPtr)labelId, (IntPtr)values, count, barSize, shift, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotBarsFloatPtrFloatPtr(byte* labelId, float* xs, float* ys, int count, double barSize, ImPlotBarsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, double, ImPlotBarsFlags, int, int, void>)FuncTable[158])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, barSize, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotBarsDoublePtrdoublePtr(byte* labelId, double* xs, double* ys, int count, double barSize, ImPlotBarsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, double, ImPlotBarsFlags, int, int, void>)FuncTable[159])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, barSize, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotBarsS8PtrS8Ptr(byte* labelId, sbyte* xs, sbyte* ys, int count, double barSize, ImPlotBarsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, double, ImPlotBarsFlags, int, int, void>)FuncTable[160])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, barSize, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotBarsU8PtrU8Ptr(byte* labelId, byte* xs, byte* ys, int count, double barSize, ImPlotBarsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, double, ImPlotBarsFlags, int, int, void>)FuncTable[161])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, barSize, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotBarsS16PtrS16Ptr(byte* labelId, short* xs, short* ys, int count, double barSize, ImPlotBarsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, double, ImPlotBarsFlags, int, int, void>)FuncTable[162])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, barSize, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotBarsU16PtrU16Ptr(byte* labelId, ushort* xs, ushort* ys, int count, double barSize, ImPlotBarsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, double, ImPlotBarsFlags, int, int, void>)FuncTable[163])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, barSize, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotBarsS32PtrS32Ptr(byte* labelId, int* xs, int* ys, int count, double barSize, ImPlotBarsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, double, ImPlotBarsFlags, int, int, void>)FuncTable[164])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, barSize, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotBarsU32PtrU32Ptr(byte* labelId, uint* xs, uint* ys, int count, double barSize, ImPlotBarsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, double, ImPlotBarsFlags, int, int, void>)FuncTable[165])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, barSize, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotBarsS64PtrS64Ptr(byte* labelId, long* xs, long* ys, int count, double barSize, ImPlotBarsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, double, ImPlotBarsFlags, int, int, void>)FuncTable[166])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, barSize, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotBarsU64PtrU64Ptr(byte* labelId, ulong* xs, ulong* ys, int count, double barSize, ImPlotBarsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, double, ImPlotBarsFlags, int, int, void>)FuncTable[167])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, barSize, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotBarsG(byte* labelId, void* getter, void* data, int count, double barSize, ImPlotBarsFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, double, ImPlotBarsFlags, void>)FuncTable[168])((IntPtr)labelId, (IntPtr)getter, (IntPtr)data, count, barSize, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotBarGroupsFloatPtr(byte** labelIds, float* values, int itemCount, int groupCount, double groupSize, double shift, ImPlotBarGroupsFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, double, double, ImPlotBarGroupsFlags, void>)FuncTable[169])((IntPtr)labelIds, (IntPtr)values, itemCount, groupCount, groupSize, shift, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotBarGroupsDoublePtr(byte** labelIds, double* values, int itemCount, int groupCount, double groupSize, double shift, ImPlotBarGroupsFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, double, double, ImPlotBarGroupsFlags, void>)FuncTable[170])((IntPtr)labelIds, (IntPtr)values, itemCount, groupCount, groupSize, shift, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotBarGroupsS8Ptr(byte** labelIds, sbyte* values, int itemCount, int groupCount, double groupSize, double shift, ImPlotBarGroupsFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, double, double, ImPlotBarGroupsFlags, void>)FuncTable[171])((IntPtr)labelIds, (IntPtr)values, itemCount, groupCount, groupSize, shift, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotBarGroupsU8Ptr(byte** labelIds, byte* values, int itemCount, int groupCount, double groupSize, double shift, ImPlotBarGroupsFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, double, double, ImPlotBarGroupsFlags, void>)FuncTable[172])((IntPtr)labelIds, (IntPtr)values, itemCount, groupCount, groupSize, shift, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotBarGroupsS16Ptr(byte** labelIds, short* values, int itemCount, int groupCount, double groupSize, double shift, ImPlotBarGroupsFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, double, double, ImPlotBarGroupsFlags, void>)FuncTable[173])((IntPtr)labelIds, (IntPtr)values, itemCount, groupCount, groupSize, shift, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotBarGroupsU16Ptr(byte** labelIds, ushort* values, int itemCount, int groupCount, double groupSize, double shift, ImPlotBarGroupsFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, double, double, ImPlotBarGroupsFlags, void>)FuncTable[174])((IntPtr)labelIds, (IntPtr)values, itemCount, groupCount, groupSize, shift, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotBarGroupsS32Ptr(byte** labelIds, int* values, int itemCount, int groupCount, double groupSize, double shift, ImPlotBarGroupsFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, double, double, ImPlotBarGroupsFlags, void>)FuncTable[175])((IntPtr)labelIds, (IntPtr)values, itemCount, groupCount, groupSize, shift, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotBarGroupsU32Ptr(byte** labelIds, uint* values, int itemCount, int groupCount, double groupSize, double shift, ImPlotBarGroupsFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, double, double, ImPlotBarGroupsFlags, void>)FuncTable[176])((IntPtr)labelIds, (IntPtr)values, itemCount, groupCount, groupSize, shift, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotBarGroupsS64Ptr(byte** labelIds, long* values, int itemCount, int groupCount, double groupSize, double shift, ImPlotBarGroupsFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, double, double, ImPlotBarGroupsFlags, void>)FuncTable[177])((IntPtr)labelIds, (IntPtr)values, itemCount, groupCount, groupSize, shift, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotBarGroupsU64Ptr(byte** labelIds, ulong* values, int itemCount, int groupCount, double groupSize, double shift, ImPlotBarGroupsFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, double, double, ImPlotBarGroupsFlags, void>)FuncTable[178])((IntPtr)labelIds, (IntPtr)values, itemCount, groupCount, groupSize, shift, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotErrorBarsFloatPtrFloatPtrFloatPtrInt(byte* labelId, float* xs, float* ys, float* err, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlotErrorBarsFlags, int, int, void>)FuncTable[179])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)err, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotErrorBarsDoublePtrdoublePtrdoublePtrInt(byte* labelId, double* xs, double* ys, double* err, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlotErrorBarsFlags, int, int, void>)FuncTable[180])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)err, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotErrorBarsS8PtrS8PtrS8PtrInt(byte* labelId, sbyte* xs, sbyte* ys, sbyte* err, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlotErrorBarsFlags, int, int, void>)FuncTable[181])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)err, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotErrorBarsU8PtrU8PtrU8PtrInt(byte* labelId, byte* xs, byte* ys, byte* err, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlotErrorBarsFlags, int, int, void>)FuncTable[182])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)err, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotErrorBarsS16PtrS16PtrS16PtrInt(byte* labelId, short* xs, short* ys, short* err, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlotErrorBarsFlags, int, int, void>)FuncTable[183])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)err, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotErrorBarsU16PtrU16PtrU16PtrInt(byte* labelId, ushort* xs, ushort* ys, ushort* err, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlotErrorBarsFlags, int, int, void>)FuncTable[184])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)err, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotErrorBarsS32PtrS32PtrS32PtrInt(byte* labelId, int* xs, int* ys, int* err, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlotErrorBarsFlags, int, int, void>)FuncTable[185])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)err, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotErrorBarsU32PtrU32PtrU32PtrInt(byte* labelId, uint* xs, uint* ys, uint* err, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlotErrorBarsFlags, int, int, void>)FuncTable[186])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)err, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotErrorBarsS64PtrS64PtrS64PtrInt(byte* labelId, long* xs, long* ys, long* err, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlotErrorBarsFlags, int, int, void>)FuncTable[187])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)err, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotErrorBarsU64PtrU64PtrU64PtrInt(byte* labelId, ulong* xs, ulong* ys, ulong* err, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlotErrorBarsFlags, int, int, void>)FuncTable[188])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)err, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotErrorBarsFloatPtrFloatPtrFloatPtrFloatPtr(byte* labelId, float* xs, float* ys, float* neg, float* pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlotErrorBarsFlags, int, int, void>)FuncTable[189])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)neg, (IntPtr)pos, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotErrorBarsDoublePtrdoublePtrdoublePtrdoublePtr(byte* labelId, double* xs, double* ys, double* neg, double* pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlotErrorBarsFlags, int, int, void>)FuncTable[190])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)neg, (IntPtr)pos, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotErrorBarsS8PtrS8PtrS8PtrS8Ptr(byte* labelId, sbyte* xs, sbyte* ys, sbyte* neg, sbyte* pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlotErrorBarsFlags, int, int, void>)FuncTable[191])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)neg, (IntPtr)pos, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotErrorBarsU8PtrU8PtrU8PtrU8Ptr(byte* labelId, byte* xs, byte* ys, byte* neg, byte* pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlotErrorBarsFlags, int, int, void>)FuncTable[192])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)neg, (IntPtr)pos, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotErrorBarsS16PtrS16PtrS16PtrS16Ptr(byte* labelId, short* xs, short* ys, short* neg, short* pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlotErrorBarsFlags, int, int, void>)FuncTable[193])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)neg, (IntPtr)pos, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotErrorBarsU16PtrU16PtrU16PtrU16Ptr(byte* labelId, ushort* xs, ushort* ys, ushort* neg, ushort* pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlotErrorBarsFlags, int, int, void>)FuncTable[194])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)neg, (IntPtr)pos, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotErrorBarsS32PtrS32PtrS32PtrS32Ptr(byte* labelId, int* xs, int* ys, int* neg, int* pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlotErrorBarsFlags, int, int, void>)FuncTable[195])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)neg, (IntPtr)pos, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotErrorBarsU32PtrU32PtrU32PtrU32Ptr(byte* labelId, uint* xs, uint* ys, uint* neg, uint* pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlotErrorBarsFlags, int, int, void>)FuncTable[196])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)neg, (IntPtr)pos, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotErrorBarsS64PtrS64PtrS64PtrS64Ptr(byte* labelId, long* xs, long* ys, long* neg, long* pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlotErrorBarsFlags, int, int, void>)FuncTable[197])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)neg, (IntPtr)pos, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotErrorBarsU64PtrU64PtrU64PtrU64Ptr(byte* labelId, ulong* xs, ulong* ys, ulong* neg, ulong* pos, int count, ImPlotErrorBarsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlotErrorBarsFlags, int, int, void>)FuncTable[198])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)neg, (IntPtr)pos, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotStemsFloatPtrInt(byte* labelId, float* values, int count, double @ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, double, ImPlotStemsFlags, int, int, void>)FuncTable[199])((IntPtr)labelId, (IntPtr)values, count, @ref, scale, start, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotStemsDoublePtrInt(byte* labelId, double* values, int count, double @ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, double, ImPlotStemsFlags, int, int, void>)FuncTable[200])((IntPtr)labelId, (IntPtr)values, count, @ref, scale, start, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotStemsS8PtrInt(byte* labelId, sbyte* values, int count, double @ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, double, ImPlotStemsFlags, int, int, void>)FuncTable[201])((IntPtr)labelId, (IntPtr)values, count, @ref, scale, start, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotStemsU8PtrInt(byte* labelId, byte* values, int count, double @ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, double, ImPlotStemsFlags, int, int, void>)FuncTable[202])((IntPtr)labelId, (IntPtr)values, count, @ref, scale, start, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotStemsS16PtrInt(byte* labelId, short* values, int count, double @ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, double, ImPlotStemsFlags, int, int, void>)FuncTable[203])((IntPtr)labelId, (IntPtr)values, count, @ref, scale, start, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotStemsU16PtrInt(byte* labelId, ushort* values, int count, double @ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, double, ImPlotStemsFlags, int, int, void>)FuncTable[204])((IntPtr)labelId, (IntPtr)values, count, @ref, scale, start, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotStemsS32PtrInt(byte* labelId, int* values, int count, double @ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, double, ImPlotStemsFlags, int, int, void>)FuncTable[205])((IntPtr)labelId, (IntPtr)values, count, @ref, scale, start, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotStemsU32PtrInt(byte* labelId, uint* values, int count, double @ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, double, ImPlotStemsFlags, int, int, void>)FuncTable[206])((IntPtr)labelId, (IntPtr)values, count, @ref, scale, start, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotStemsS64PtrInt(byte* labelId, long* values, int count, double @ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, double, ImPlotStemsFlags, int, int, void>)FuncTable[207])((IntPtr)labelId, (IntPtr)values, count, @ref, scale, start, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotStemsU64PtrInt(byte* labelId, ulong* values, int count, double @ref, double scale, double start, ImPlotStemsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, double, ImPlotStemsFlags, int, int, void>)FuncTable[208])((IntPtr)labelId, (IntPtr)values, count, @ref, scale, start, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotStemsFloatPtrFloatPtr(byte* labelId, float* xs, float* ys, int count, double @ref, ImPlotStemsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, double, ImPlotStemsFlags, int, int, void>)FuncTable[209])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, @ref, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotStemsDoublePtrdoublePtr(byte* labelId, double* xs, double* ys, int count, double @ref, ImPlotStemsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, double, ImPlotStemsFlags, int, int, void>)FuncTable[210])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, @ref, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotStemsS8PtrS8Ptr(byte* labelId, sbyte* xs, sbyte* ys, int count, double @ref, ImPlotStemsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, double, ImPlotStemsFlags, int, int, void>)FuncTable[211])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, @ref, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotStemsU8PtrU8Ptr(byte* labelId, byte* xs, byte* ys, int count, double @ref, ImPlotStemsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, double, ImPlotStemsFlags, int, int, void>)FuncTable[212])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, @ref, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotStemsS16PtrS16Ptr(byte* labelId, short* xs, short* ys, int count, double @ref, ImPlotStemsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, double, ImPlotStemsFlags, int, int, void>)FuncTable[213])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, @ref, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotStemsU16PtrU16Ptr(byte* labelId, ushort* xs, ushort* ys, int count, double @ref, ImPlotStemsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, double, ImPlotStemsFlags, int, int, void>)FuncTable[214])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, @ref, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotStemsS32PtrS32Ptr(byte* labelId, int* xs, int* ys, int count, double @ref, ImPlotStemsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, double, ImPlotStemsFlags, int, int, void>)FuncTable[215])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, @ref, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotStemsU32PtrU32Ptr(byte* labelId, uint* xs, uint* ys, int count, double @ref, ImPlotStemsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, double, ImPlotStemsFlags, int, int, void>)FuncTable[216])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, @ref, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotStemsS64PtrS64Ptr(byte* labelId, long* xs, long* ys, int count, double @ref, ImPlotStemsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, double, ImPlotStemsFlags, int, int, void>)FuncTable[217])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, @ref, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotStemsU64PtrU64Ptr(byte* labelId, ulong* xs, ulong* ys, int count, double @ref, ImPlotStemsFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, double, ImPlotStemsFlags, int, int, void>)FuncTable[218])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, @ref, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotInfLinesFloatPtr(byte* labelId, float* values, int count, ImPlotInfLinesFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, ImPlotInfLinesFlags, int, int, void>)FuncTable[219])((IntPtr)labelId, (IntPtr)values, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotInfLinesDoublePtr(byte* labelId, double* values, int count, ImPlotInfLinesFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, ImPlotInfLinesFlags, int, int, void>)FuncTable[220])((IntPtr)labelId, (IntPtr)values, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotInfLinesS8Ptr(byte* labelId, sbyte* values, int count, ImPlotInfLinesFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, ImPlotInfLinesFlags, int, int, void>)FuncTable[221])((IntPtr)labelId, (IntPtr)values, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotInfLinesU8Ptr(byte* labelId, byte* values, int count, ImPlotInfLinesFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, ImPlotInfLinesFlags, int, int, void>)FuncTable[222])((IntPtr)labelId, (IntPtr)values, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotInfLinesS16Ptr(byte* labelId, short* values, int count, ImPlotInfLinesFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, ImPlotInfLinesFlags, int, int, void>)FuncTable[223])((IntPtr)labelId, (IntPtr)values, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotInfLinesU16Ptr(byte* labelId, ushort* values, int count, ImPlotInfLinesFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, ImPlotInfLinesFlags, int, int, void>)FuncTable[224])((IntPtr)labelId, (IntPtr)values, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotInfLinesS32Ptr(byte* labelId, int* values, int count, ImPlotInfLinesFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, ImPlotInfLinesFlags, int, int, void>)FuncTable[225])((IntPtr)labelId, (IntPtr)values, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotInfLinesU32Ptr(byte* labelId, uint* values, int count, ImPlotInfLinesFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, ImPlotInfLinesFlags, int, int, void>)FuncTable[226])((IntPtr)labelId, (IntPtr)values, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotInfLinesS64Ptr(byte* labelId, long* values, int count, ImPlotInfLinesFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, ImPlotInfLinesFlags, int, int, void>)FuncTable[227])((IntPtr)labelId, (IntPtr)values, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotInfLinesU64Ptr(byte* labelId, ulong* values, int count, ImPlotInfLinesFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, ImPlotInfLinesFlags, int, int, void>)FuncTable[228])((IntPtr)labelId, (IntPtr)values, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotPieChartFloatPtrPlotFormatter(byte** labelIds, float* values, int count, double x, double y, double radius, IntPtr fmt, void* fmtData, double angle0, ImPlotPieChartFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, double, IntPtr, IntPtr, double, ImPlotPieChartFlags, void>)FuncTable[229])((IntPtr)labelIds, (IntPtr)values, count, x, y, radius, fmt, (IntPtr)fmtData, angle0, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotPieChartDoublePtrPlotFormatter(byte** labelIds, double* values, int count, double x, double y, double radius, IntPtr fmt, void* fmtData, double angle0, ImPlotPieChartFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, double, IntPtr, IntPtr, double, ImPlotPieChartFlags, void>)FuncTable[230])((IntPtr)labelIds, (IntPtr)values, count, x, y, radius, fmt, (IntPtr)fmtData, angle0, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotPieChartS8PtrPlotFormatter(byte** labelIds, sbyte* values, int count, double x, double y, double radius, IntPtr fmt, void* fmtData, double angle0, ImPlotPieChartFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, double, IntPtr, IntPtr, double, ImPlotPieChartFlags, void>)FuncTable[231])((IntPtr)labelIds, (IntPtr)values, count, x, y, radius, fmt, (IntPtr)fmtData, angle0, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotPieChartU8PtrPlotFormatter(byte** labelIds, byte* values, int count, double x, double y, double radius, IntPtr fmt, void* fmtData, double angle0, ImPlotPieChartFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, double, IntPtr, IntPtr, double, ImPlotPieChartFlags, void>)FuncTable[232])((IntPtr)labelIds, (IntPtr)values, count, x, y, radius, fmt, (IntPtr)fmtData, angle0, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotPieChartS16PtrPlotFormatter(byte** labelIds, short* values, int count, double x, double y, double radius, IntPtr fmt, void* fmtData, double angle0, ImPlotPieChartFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, double, IntPtr, IntPtr, double, ImPlotPieChartFlags, void>)FuncTable[233])((IntPtr)labelIds, (IntPtr)values, count, x, y, radius, fmt, (IntPtr)fmtData, angle0, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotPieChartU16PtrPlotFormatter(byte** labelIds, ushort* values, int count, double x, double y, double radius, IntPtr fmt, void* fmtData, double angle0, ImPlotPieChartFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, double, IntPtr, IntPtr, double, ImPlotPieChartFlags, void>)FuncTable[234])((IntPtr)labelIds, (IntPtr)values, count, x, y, radius, fmt, (IntPtr)fmtData, angle0, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotPieChartS32PtrPlotFormatter(byte** labelIds, int* values, int count, double x, double y, double radius, IntPtr fmt, void* fmtData, double angle0, ImPlotPieChartFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, double, IntPtr, IntPtr, double, ImPlotPieChartFlags, void>)FuncTable[235])((IntPtr)labelIds, (IntPtr)values, count, x, y, radius, fmt, (IntPtr)fmtData, angle0, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotPieChartU32PtrPlotFormatter(byte** labelIds, uint* values, int count, double x, double y, double radius, IntPtr fmt, void* fmtData, double angle0, ImPlotPieChartFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, double, IntPtr, IntPtr, double, ImPlotPieChartFlags, void>)FuncTable[236])((IntPtr)labelIds, (IntPtr)values, count, x, y, radius, fmt, (IntPtr)fmtData, angle0, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotPieChartS64PtrPlotFormatter(byte** labelIds, long* values, int count, double x, double y, double radius, IntPtr fmt, void* fmtData, double angle0, ImPlotPieChartFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, double, IntPtr, IntPtr, double, ImPlotPieChartFlags, void>)FuncTable[237])((IntPtr)labelIds, (IntPtr)values, count, x, y, radius, fmt, (IntPtr)fmtData, angle0, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotPieChartU64PtrPlotFormatter(byte** labelIds, ulong* values, int count, double x, double y, double radius, IntPtr fmt, void* fmtData, double angle0, ImPlotPieChartFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, double, IntPtr, IntPtr, double, ImPlotPieChartFlags, void>)FuncTable[238])((IntPtr)labelIds, (IntPtr)values, count, x, y, radius, fmt, (IntPtr)fmtData, angle0, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotPieChartFloatPtrStr(byte** labelIds, float* values, int count, double x, double y, double radius, byte* labelFmt, double angle0, ImPlotPieChartFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, double, IntPtr, double, ImPlotPieChartFlags, void>)FuncTable[239])((IntPtr)labelIds, (IntPtr)values, count, x, y, radius, (IntPtr)labelFmt, angle0, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotPieChartDoublePtrStr(byte** labelIds, double* values, int count, double x, double y, double radius, byte* labelFmt, double angle0, ImPlotPieChartFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, double, IntPtr, double, ImPlotPieChartFlags, void>)FuncTable[240])((IntPtr)labelIds, (IntPtr)values, count, x, y, radius, (IntPtr)labelFmt, angle0, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotPieChartS8PtrStr(byte** labelIds, sbyte* values, int count, double x, double y, double radius, byte* labelFmt, double angle0, ImPlotPieChartFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, double, IntPtr, double, ImPlotPieChartFlags, void>)FuncTable[241])((IntPtr)labelIds, (IntPtr)values, count, x, y, radius, (IntPtr)labelFmt, angle0, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotPieChartU8PtrStr(byte** labelIds, byte* values, int count, double x, double y, double radius, byte* labelFmt, double angle0, ImPlotPieChartFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, double, IntPtr, double, ImPlotPieChartFlags, void>)FuncTable[242])((IntPtr)labelIds, (IntPtr)values, count, x, y, radius, (IntPtr)labelFmt, angle0, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotPieChartS16PtrStr(byte** labelIds, short* values, int count, double x, double y, double radius, byte* labelFmt, double angle0, ImPlotPieChartFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, double, IntPtr, double, ImPlotPieChartFlags, void>)FuncTable[243])((IntPtr)labelIds, (IntPtr)values, count, x, y, radius, (IntPtr)labelFmt, angle0, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotPieChartU16PtrStr(byte** labelIds, ushort* values, int count, double x, double y, double radius, byte* labelFmt, double angle0, ImPlotPieChartFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, double, IntPtr, double, ImPlotPieChartFlags, void>)FuncTable[244])((IntPtr)labelIds, (IntPtr)values, count, x, y, radius, (IntPtr)labelFmt, angle0, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotPieChartS32PtrStr(byte** labelIds, int* values, int count, double x, double y, double radius, byte* labelFmt, double angle0, ImPlotPieChartFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, double, IntPtr, double, ImPlotPieChartFlags, void>)FuncTable[245])((IntPtr)labelIds, (IntPtr)values, count, x, y, radius, (IntPtr)labelFmt, angle0, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotPieChartU32PtrStr(byte** labelIds, uint* values, int count, double x, double y, double radius, byte* labelFmt, double angle0, ImPlotPieChartFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, double, IntPtr, double, ImPlotPieChartFlags, void>)FuncTable[246])((IntPtr)labelIds, (IntPtr)values, count, x, y, radius, (IntPtr)labelFmt, angle0, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotPieChartS64PtrStr(byte** labelIds, long* values, int count, double x, double y, double radius, byte* labelFmt, double angle0, ImPlotPieChartFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, double, IntPtr, double, ImPlotPieChartFlags, void>)FuncTable[247])((IntPtr)labelIds, (IntPtr)values, count, x, y, radius, (IntPtr)labelFmt, angle0, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotPieChartU64PtrStr(byte** labelIds, ulong* values, int count, double x, double y, double radius, byte* labelFmt, double angle0, ImPlotPieChartFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, double, double, double, IntPtr, double, ImPlotPieChartFlags, void>)FuncTable[248])((IntPtr)labelIds, (IntPtr)values, count, x, y, radius, (IntPtr)labelFmt, angle0, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotHeatmapFloatPtr(byte* labelId, float* values, int rows, int cols, double scaleMin, double scaleMax, byte* labelFmt, ImPlotPoint boundsMin, ImPlotPoint boundsMax, ImPlotHeatmapFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, double, double, IntPtr, ImPlotPoint, ImPlotPoint, ImPlotHeatmapFlags, void>)FuncTable[249])((IntPtr)labelId, (IntPtr)values, rows, cols, scaleMin, scaleMax, (IntPtr)labelFmt, boundsMin, boundsMax, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotHeatmapDoublePtr(byte* labelId, double* values, int rows, int cols, double scaleMin, double scaleMax, byte* labelFmt, ImPlotPoint boundsMin, ImPlotPoint boundsMax, ImPlotHeatmapFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, double, double, IntPtr, ImPlotPoint, ImPlotPoint, ImPlotHeatmapFlags, void>)FuncTable[250])((IntPtr)labelId, (IntPtr)values, rows, cols, scaleMin, scaleMax, (IntPtr)labelFmt, boundsMin, boundsMax, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotHeatmapS8Ptr(byte* labelId, sbyte* values, int rows, int cols, double scaleMin, double scaleMax, byte* labelFmt, ImPlotPoint boundsMin, ImPlotPoint boundsMax, ImPlotHeatmapFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, double, double, IntPtr, ImPlotPoint, ImPlotPoint, ImPlotHeatmapFlags, void>)FuncTable[251])((IntPtr)labelId, (IntPtr)values, rows, cols, scaleMin, scaleMax, (IntPtr)labelFmt, boundsMin, boundsMax, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotHeatmapU8Ptr(byte* labelId, byte* values, int rows, int cols, double scaleMin, double scaleMax, byte* labelFmt, ImPlotPoint boundsMin, ImPlotPoint boundsMax, ImPlotHeatmapFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, double, double, IntPtr, ImPlotPoint, ImPlotPoint, ImPlotHeatmapFlags, void>)FuncTable[252])((IntPtr)labelId, (IntPtr)values, rows, cols, scaleMin, scaleMax, (IntPtr)labelFmt, boundsMin, boundsMax, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotHeatmapS16Ptr(byte* labelId, short* values, int rows, int cols, double scaleMin, double scaleMax, byte* labelFmt, ImPlotPoint boundsMin, ImPlotPoint boundsMax, ImPlotHeatmapFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, double, double, IntPtr, ImPlotPoint, ImPlotPoint, ImPlotHeatmapFlags, void>)FuncTable[253])((IntPtr)labelId, (IntPtr)values, rows, cols, scaleMin, scaleMax, (IntPtr)labelFmt, boundsMin, boundsMax, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotHeatmapU16Ptr(byte* labelId, ushort* values, int rows, int cols, double scaleMin, double scaleMax, byte* labelFmt, ImPlotPoint boundsMin, ImPlotPoint boundsMax, ImPlotHeatmapFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, double, double, IntPtr, ImPlotPoint, ImPlotPoint, ImPlotHeatmapFlags, void>)FuncTable[254])((IntPtr)labelId, (IntPtr)values, rows, cols, scaleMin, scaleMax, (IntPtr)labelFmt, boundsMin, boundsMax, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotHeatmapS32Ptr(byte* labelId, int* values, int rows, int cols, double scaleMin, double scaleMax, byte* labelFmt, ImPlotPoint boundsMin, ImPlotPoint boundsMax, ImPlotHeatmapFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, double, double, IntPtr, ImPlotPoint, ImPlotPoint, ImPlotHeatmapFlags, void>)FuncTable[255])((IntPtr)labelId, (IntPtr)values, rows, cols, scaleMin, scaleMax, (IntPtr)labelFmt, boundsMin, boundsMax, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotHeatmapU32Ptr(byte* labelId, uint* values, int rows, int cols, double scaleMin, double scaleMax, byte* labelFmt, ImPlotPoint boundsMin, ImPlotPoint boundsMax, ImPlotHeatmapFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, double, double, IntPtr, ImPlotPoint, ImPlotPoint, ImPlotHeatmapFlags, void>)FuncTable[256])((IntPtr)labelId, (IntPtr)values, rows, cols, scaleMin, scaleMax, (IntPtr)labelFmt, boundsMin, boundsMax, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotHeatmapS64Ptr(byte* labelId, long* values, int rows, int cols, double scaleMin, double scaleMax, byte* labelFmt, ImPlotPoint boundsMin, ImPlotPoint boundsMax, ImPlotHeatmapFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, double, double, IntPtr, ImPlotPoint, ImPlotPoint, ImPlotHeatmapFlags, void>)FuncTable[257])((IntPtr)labelId, (IntPtr)values, rows, cols, scaleMin, scaleMax, (IntPtr)labelFmt, boundsMin, boundsMax, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotHeatmapU64Ptr(byte* labelId, ulong* values, int rows, int cols, double scaleMin, double scaleMax, byte* labelFmt, ImPlotPoint boundsMin, ImPlotPoint boundsMax, ImPlotHeatmapFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, double, double, IntPtr, ImPlotPoint, ImPlotPoint, ImPlotHeatmapFlags, void>)FuncTable[258])((IntPtr)labelId, (IntPtr)values, rows, cols, scaleMin, scaleMax, (IntPtr)labelFmt, boundsMin, boundsMax, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double PlotHistogramFloatPtr(byte* labelId, float* values, int count, int bins, double barScale, ImPlotRange range, ImPlotHistogramFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, double, ImPlotRange, ImPlotHistogramFlags, double>)FuncTable[259])((IntPtr)labelId, (IntPtr)values, count, bins, barScale, range, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double PlotHistogramDoublePtr(byte* labelId, double* values, int count, int bins, double barScale, ImPlotRange range, ImPlotHistogramFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, double, ImPlotRange, ImPlotHistogramFlags, double>)FuncTable[260])((IntPtr)labelId, (IntPtr)values, count, bins, barScale, range, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double PlotHistogramS8Ptr(byte* labelId, sbyte* values, int count, int bins, double barScale, ImPlotRange range, ImPlotHistogramFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, double, ImPlotRange, ImPlotHistogramFlags, double>)FuncTable[261])((IntPtr)labelId, (IntPtr)values, count, bins, barScale, range, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double PlotHistogramU8Ptr(byte* labelId, byte* values, int count, int bins, double barScale, ImPlotRange range, ImPlotHistogramFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, double, ImPlotRange, ImPlotHistogramFlags, double>)FuncTable[262])((IntPtr)labelId, (IntPtr)values, count, bins, barScale, range, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double PlotHistogramS16Ptr(byte* labelId, short* values, int count, int bins, double barScale, ImPlotRange range, ImPlotHistogramFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, double, ImPlotRange, ImPlotHistogramFlags, double>)FuncTable[263])((IntPtr)labelId, (IntPtr)values, count, bins, barScale, range, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double PlotHistogramU16Ptr(byte* labelId, ushort* values, int count, int bins, double barScale, ImPlotRange range, ImPlotHistogramFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, double, ImPlotRange, ImPlotHistogramFlags, double>)FuncTable[264])((IntPtr)labelId, (IntPtr)values, count, bins, barScale, range, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double PlotHistogramS32Ptr(byte* labelId, int* values, int count, int bins, double barScale, ImPlotRange range, ImPlotHistogramFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, double, ImPlotRange, ImPlotHistogramFlags, double>)FuncTable[265])((IntPtr)labelId, (IntPtr)values, count, bins, barScale, range, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double PlotHistogramU32Ptr(byte* labelId, uint* values, int count, int bins, double barScale, ImPlotRange range, ImPlotHistogramFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, double, ImPlotRange, ImPlotHistogramFlags, double>)FuncTable[266])((IntPtr)labelId, (IntPtr)values, count, bins, barScale, range, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double PlotHistogramS64Ptr(byte* labelId, long* values, int count, int bins, double barScale, ImPlotRange range, ImPlotHistogramFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, double, ImPlotRange, ImPlotHistogramFlags, double>)FuncTable[267])((IntPtr)labelId, (IntPtr)values, count, bins, barScale, range, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double PlotHistogramU64Ptr(byte* labelId, ulong* values, int count, int bins, double barScale, ImPlotRange range, ImPlotHistogramFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, double, ImPlotRange, ImPlotHistogramFlags, double>)FuncTable[268])((IntPtr)labelId, (IntPtr)values, count, bins, barScale, range, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double PlotHistogram2DFloatPtr(byte* labelId, float* xs, float* ys, int count, int xBins, int yBins, ImPlotRect range, ImPlotHistogramFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, int, int, ImPlotRect, ImPlotHistogramFlags, double>)FuncTable[269])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, xBins, yBins, range, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double PlotHistogram2DDoublePtr(byte* labelId, double* xs, double* ys, int count, int xBins, int yBins, ImPlotRect range, ImPlotHistogramFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, int, int, ImPlotRect, ImPlotHistogramFlags, double>)FuncTable[270])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, xBins, yBins, range, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double PlotHistogram2DS8Ptr(byte* labelId, sbyte* xs, sbyte* ys, int count, int xBins, int yBins, ImPlotRect range, ImPlotHistogramFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, int, int, ImPlotRect, ImPlotHistogramFlags, double>)FuncTable[271])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, xBins, yBins, range, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double PlotHistogram2DU8Ptr(byte* labelId, byte* xs, byte* ys, int count, int xBins, int yBins, ImPlotRect range, ImPlotHistogramFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, int, int, ImPlotRect, ImPlotHistogramFlags, double>)FuncTable[272])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, xBins, yBins, range, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double PlotHistogram2DS16Ptr(byte* labelId, short* xs, short* ys, int count, int xBins, int yBins, ImPlotRect range, ImPlotHistogramFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, int, int, ImPlotRect, ImPlotHistogramFlags, double>)FuncTable[273])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, xBins, yBins, range, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double PlotHistogram2DU16Ptr(byte* labelId, ushort* xs, ushort* ys, int count, int xBins, int yBins, ImPlotRect range, ImPlotHistogramFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, int, int, ImPlotRect, ImPlotHistogramFlags, double>)FuncTable[274])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, xBins, yBins, range, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double PlotHistogram2DS32Ptr(byte* labelId, int* xs, int* ys, int count, int xBins, int yBins, ImPlotRect range, ImPlotHistogramFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, int, int, ImPlotRect, ImPlotHistogramFlags, double>)FuncTable[275])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, xBins, yBins, range, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double PlotHistogram2DU32Ptr(byte* labelId, uint* xs, uint* ys, int count, int xBins, int yBins, ImPlotRect range, ImPlotHistogramFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, int, int, ImPlotRect, ImPlotHistogramFlags, double>)FuncTable[276])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, xBins, yBins, range, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double PlotHistogram2DS64Ptr(byte* labelId, long* xs, long* ys, int count, int xBins, int yBins, ImPlotRect range, ImPlotHistogramFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, int, int, ImPlotRect, ImPlotHistogramFlags, double>)FuncTable[277])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, xBins, yBins, range, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double PlotHistogram2DU64Ptr(byte* labelId, ulong* xs, ulong* ys, int count, int xBins, int yBins, ImPlotRect range, ImPlotHistogramFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, int, int, ImPlotRect, ImPlotHistogramFlags, double>)FuncTable[278])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, xBins, yBins, range, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotDigitalFloatPtr(byte* labelId, float* xs, float* ys, int count, ImPlotDigitalFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotDigitalFlags, int, int, void>)FuncTable[279])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotDigitalDoublePtr(byte* labelId, double* xs, double* ys, int count, ImPlotDigitalFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotDigitalFlags, int, int, void>)FuncTable[280])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotDigitalS8Ptr(byte* labelId, sbyte* xs, sbyte* ys, int count, ImPlotDigitalFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotDigitalFlags, int, int, void>)FuncTable[281])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotDigitalU8Ptr(byte* labelId, byte* xs, byte* ys, int count, ImPlotDigitalFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotDigitalFlags, int, int, void>)FuncTable[282])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotDigitalS16Ptr(byte* labelId, short* xs, short* ys, int count, ImPlotDigitalFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotDigitalFlags, int, int, void>)FuncTable[283])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotDigitalU16Ptr(byte* labelId, ushort* xs, ushort* ys, int count, ImPlotDigitalFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotDigitalFlags, int, int, void>)FuncTable[284])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotDigitalS32Ptr(byte* labelId, int* xs, int* ys, int count, ImPlotDigitalFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotDigitalFlags, int, int, void>)FuncTable[285])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotDigitalU32Ptr(byte* labelId, uint* xs, uint* ys, int count, ImPlotDigitalFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotDigitalFlags, int, int, void>)FuncTable[286])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotDigitalS64Ptr(byte* labelId, long* xs, long* ys, int count, ImPlotDigitalFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotDigitalFlags, int, int, void>)FuncTable[287])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotDigitalU64Ptr(byte* labelId, ulong* xs, ulong* ys, int count, ImPlotDigitalFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotDigitalFlags, int, int, void>)FuncTable[288])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotDigitalG(byte* labelId, void* getter, void* data, int count, ImPlotDigitalFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, ImPlotDigitalFlags, void>)FuncTable[289])((IntPtr)labelId, (IntPtr)getter, (IntPtr)data, count, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotImage(byte* labelId, IntPtr userTextureId, ImPlotPoint boundsMin, ImPlotPoint boundsMax, Vector2 uv0, Vector2 uv1, Vector4 tintCol, ImPlotImageFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImPlotPoint, ImPlotPoint, Vector2, Vector2, Vector4, ImPlotImageFlags, void>)FuncTable[290])((IntPtr)labelId, userTextureId, boundsMin, boundsMax, uv0, uv1, tintCol, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotText(byte* text, double x, double y, Vector2 pixOffset, ImPlotTextFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, double, double, Vector2, ImPlotTextFlags, void>)FuncTable[291])((IntPtr)text, x, y, pixOffset, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotDummy(byte* labelId, ImPlotDummyFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImPlotDummyFlags, void>)FuncTable[292])((IntPtr)labelId, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte DragPoint(int id, double* x, double* y, Vector4 col, float size, ImPlotDragToolFlags flags, byte* outClicked, byte* outHovered, byte* held)
		{
			return ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, Vector4, float, ImPlotDragToolFlags, IntPtr, IntPtr, IntPtr, byte>)FuncTable[293])(id, (IntPtr)x, (IntPtr)y, col, size, flags, (IntPtr)outClicked, (IntPtr)outHovered, (IntPtr)held);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte DragLineX(int id, double* x, Vector4 col, float thickness, ImPlotDragToolFlags flags, byte* outClicked, byte* outHovered, byte* held)
		{
			return ((delegate* unmanaged[Cdecl]<int, IntPtr, Vector4, float, ImPlotDragToolFlags, IntPtr, IntPtr, IntPtr, byte>)FuncTable[294])(id, (IntPtr)x, col, thickness, flags, (IntPtr)outClicked, (IntPtr)outHovered, (IntPtr)held);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte DragLineY(int id, double* y, Vector4 col, float thickness, ImPlotDragToolFlags flags, byte* outClicked, byte* outHovered, byte* held)
		{
			return ((delegate* unmanaged[Cdecl]<int, IntPtr, Vector4, float, ImPlotDragToolFlags, IntPtr, IntPtr, IntPtr, byte>)FuncTable[295])(id, (IntPtr)y, col, thickness, flags, (IntPtr)outClicked, (IntPtr)outHovered, (IntPtr)held);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte DragRect(int id, double* x1, double* y1, double* x2, double* y2, Vector4 col, ImPlotDragToolFlags flags, byte* outClicked, byte* outHovered, byte* held)
		{
			return ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, IntPtr, IntPtr, Vector4, ImPlotDragToolFlags, IntPtr, IntPtr, IntPtr, byte>)FuncTable[296])(id, (IntPtr)x1, (IntPtr)y1, (IntPtr)x2, (IntPtr)y2, col, flags, (IntPtr)outClicked, (IntPtr)outHovered, (IntPtr)held);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Annotation(double x, double y, Vector4 col, Vector2 pixOffset, byte clamp, byte round)
		{
			((delegate* unmanaged[Cdecl]<double, double, Vector4, Vector2, byte, byte, void>)FuncTable[297])(x, y, col, pixOffset, clamp, round);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Annotation(double x, double y, Vector4 col, Vector2 pixOffset, byte clamp, byte* fmt)
		{
			((delegate* unmanaged[Cdecl]<double, double, Vector4, Vector2, byte, IntPtr, void>)FuncTable[298])(x, y, col, pixOffset, clamp, (IntPtr)fmt);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TagX(double x, Vector4 col, byte round)
		{
			((delegate* unmanaged[Cdecl]<double, Vector4, byte, void>)FuncTable[299])(x, col, round);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TagX(double x, Vector4 col, byte* fmt)
		{
			((delegate* unmanaged[Cdecl]<double, Vector4, IntPtr, void>)FuncTable[300])(x, col, (IntPtr)fmt);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TagY(double y, Vector4 col, byte round)
		{
			((delegate* unmanaged[Cdecl]<double, Vector4, byte, void>)FuncTable[301])(y, col, round);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TagY(double y, Vector4 col, byte* fmt)
		{
			((delegate* unmanaged[Cdecl]<double, Vector4, IntPtr, void>)FuncTable[302])(y, col, (IntPtr)fmt);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAxis(ImAxis axis)
		{
			((delegate* unmanaged[Cdecl]<ImAxis, void>)FuncTable[303])(axis);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAxes(ImAxis xAxis, ImAxis yAxis)
		{
			((delegate* unmanaged[Cdecl]<ImAxis, ImAxis, void>)FuncTable[304])(xAxis, yAxis);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PixelsToPlot(ImPlotPoint* pOut, Vector2 pix, ImAxis xAxis, ImAxis yAxis)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, ImAxis, ImAxis, void>)FuncTable[305])((IntPtr)pOut, pix, xAxis, yAxis);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PixelsToPlot(ImPlotPoint* pOut, float x, float y, ImAxis xAxis, ImAxis yAxis)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, float, ImAxis, ImAxis, void>)FuncTable[306])((IntPtr)pOut, x, y, xAxis, yAxis);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotToPixelsPlotPoInt(Vector2* pOut, ImPlotPoint plt, ImAxis xAxis, ImAxis yAxis)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImPlotPoint, ImAxis, ImAxis, void>)FuncTable[307])((IntPtr)pOut, plt, xAxis, yAxis);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotToPixelsDouble(Vector2* pOut, double x, double y, ImAxis xAxis, ImAxis yAxis)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, double, double, ImAxis, ImAxis, void>)FuncTable[308])((IntPtr)pOut, x, y, xAxis, yAxis);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GetPlotPos(Vector2* pOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[309])((IntPtr)pOut);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GetPlotSize(Vector2* pOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[310])((IntPtr)pOut);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GetPlotMousePos(ImPlotPoint* pOut, ImAxis xAxis, ImAxis yAxis)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImAxis, ImAxis, void>)FuncTable[311])((IntPtr)pOut, xAxis, yAxis);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GetPlotLimits(ImPlotRect* pOut, ImAxis xAxis, ImAxis yAxis)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImAxis, ImAxis, void>)FuncTable[312])((IntPtr)pOut, xAxis, yAxis);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsPlotHovered()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[313])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsAxisHovered(ImAxis axis)
		{
			return ((delegate* unmanaged[Cdecl]<ImAxis, byte>)FuncTable[314])(axis);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsSubplotsHovered()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[315])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsPlotSelected()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[316])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GetPlotSelection(ImPlotRect* pOut, ImAxis xAxis, ImAxis yAxis)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImAxis, ImAxis, void>)FuncTable[317])((IntPtr)pOut, xAxis, yAxis);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CancelPlotSelection()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[318])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void HideNextItem(byte hidden, ImPlotCond cond)
		{
			((delegate* unmanaged[Cdecl]<byte, ImPlotCond, void>)FuncTable[319])(hidden, cond);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginAlignedPlots(byte* groupId, byte vertical)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte, byte>)FuncTable[320])((IntPtr)groupId, vertical);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void EndAlignedPlots()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[321])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginLegendPopup(byte* labelId, ImGuiMouseButton mouseButton)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiMouseButton, byte>)FuncTable[322])((IntPtr)labelId, mouseButton);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void EndLegendPopup()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[323])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsLegendEntryHovered(byte* labelId)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[324])((IntPtr)labelId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginDragDropTargetPlot()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[325])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginDragDropTargetAxis(ImAxis axis)
		{
			return ((delegate* unmanaged[Cdecl]<ImAxis, byte>)FuncTable[326])(axis);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginDragDropTargetLegend()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[327])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void EndDragDropTarget()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[328])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginDragDropSourcePlot(ImGuiDragDropFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiDragDropFlags, byte>)FuncTable[329])(flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginDragDropSourceAxis(ImAxis axis, ImGuiDragDropFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<ImAxis, ImGuiDragDropFlags, byte>)FuncTable[330])(axis, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginDragDropSourceItem(byte* labelId, ImGuiDragDropFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiDragDropFlags, byte>)FuncTable[331])((IntPtr)labelId, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void EndDragDropSource()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[332])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotStyle* GetStyle()
		{
			return (ImPlotStyle*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[333])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void StyleColorsAuto(ImPlotStyle* dst)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[334])((IntPtr)dst);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void StyleColorsClassic(ImPlotStyle* dst)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[335])((IntPtr)dst);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void StyleColorsDark(ImPlotStyle* dst)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[336])((IntPtr)dst);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void StyleColorsLight(ImPlotStyle* dst)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[337])((IntPtr)dst);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PushStyleColorU32(ImPlotCol idx, uint col)
		{
			((delegate* unmanaged[Cdecl]<ImPlotCol, uint, void>)FuncTable[338])(idx, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PushStyleColorVec4(ImPlotCol idx, Vector4 col)
		{
			((delegate* unmanaged[Cdecl]<ImPlotCol, Vector4, void>)FuncTable[339])(idx, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PopStyleColor(int count)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[340])(count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PushStyleVar(ImPlotStyleVar idx, float val)
		{
			((delegate* unmanaged[Cdecl]<ImPlotStyleVar, float, void>)FuncTable[341])(idx, val);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PushStyleVar(ImPlotStyleVar idx, int val)
		{
			((delegate* unmanaged[Cdecl]<ImPlotStyleVar, int, void>)FuncTable[342])(idx, val);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PushStyleVar(ImPlotStyleVar idx, Vector2 val)
		{
			((delegate* unmanaged[Cdecl]<ImPlotStyleVar, Vector2, void>)FuncTable[343])(idx, val);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PopStyleVar(int count)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[344])(count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetNextLineStyle(Vector4 col, float weight)
		{
			((delegate* unmanaged[Cdecl]<Vector4, float, void>)FuncTable[345])(col, weight);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetNextFillStyle(Vector4 col, float alphaMod)
		{
			((delegate* unmanaged[Cdecl]<Vector4, float, void>)FuncTable[346])(col, alphaMod);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetNextMarkerStyle(ImPlotMarker marker, float size, Vector4 fill, float weight, Vector4 outline)
		{
			((delegate* unmanaged[Cdecl]<ImPlotMarker, float, Vector4, float, Vector4, void>)FuncTable[347])(marker, size, fill, weight, outline);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetNextErrorBarStyle(Vector4 col, float size, float weight)
		{
			((delegate* unmanaged[Cdecl]<Vector4, float, float, void>)FuncTable[348])(col, size, weight);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GetLastItemColor(Vector4* pOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[349])((IntPtr)pOut);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* GetStyleColorName(ImPlotCol idx)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<ImPlotCol, IntPtr>)FuncTable[350])(idx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* GetMarkerName(ImPlotMarker idx)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<ImPlotMarker, IntPtr>)FuncTable[351])(idx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotColormap AddColormapVec4Ptr(byte* name, Vector4* cols, int size, byte qual)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, byte, ImPlotColormap>)FuncTable[352])((IntPtr)name, (IntPtr)cols, size, qual);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotColormap AddColormapU32Ptr(byte* name, uint* cols, int size, byte qual)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, byte, ImPlotColormap>)FuncTable[353])((IntPtr)name, (IntPtr)cols, size, qual);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int GetColormapCount()
		{
			return ((delegate* unmanaged[Cdecl]<int>)FuncTable[354])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* GetColormapName(ImPlotColormap cmap)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<ImPlotColormap, IntPtr>)FuncTable[355])(cmap);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotColormap GetColormapIndex(byte* name)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImPlotColormap>)FuncTable[356])((IntPtr)name);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PushColormapPlotColormap(ImPlotColormap cmap)
		{
			((delegate* unmanaged[Cdecl]<ImPlotColormap, void>)FuncTable[357])(cmap);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PushColormapStr(byte* name)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[358])((IntPtr)name);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PopColormap(int count)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[359])(count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void NextColormapColor(Vector4* pOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[360])((IntPtr)pOut);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int GetColormapSize(ImPlotColormap cmap)
		{
			return ((delegate* unmanaged[Cdecl]<ImPlotColormap, int>)FuncTable[361])(cmap);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GetColormapColor(Vector4* pOut, int idx, ImPlotColormap cmap)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, ImPlotColormap, void>)FuncTable[362])((IntPtr)pOut, idx, cmap);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SampleColormap(Vector4* pOut, float t, ImPlotColormap cmap)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, ImPlotColormap, void>)FuncTable[363])((IntPtr)pOut, t, cmap);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ColormapScale(byte* label, double scaleMin, double scaleMax, Vector2 size, byte* format, ImPlotColormapScaleFlags flags, ImPlotColormap cmap)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, double, double, Vector2, IntPtr, ImPlotColormapScaleFlags, ImPlotColormap, void>)FuncTable[364])((IntPtr)label, scaleMin, scaleMax, size, (IntPtr)format, flags, cmap);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ColormapSlider(byte* label, float* t, Vector4* @out, byte* format, ImPlotColormap cmap)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, ImPlotColormap, byte>)FuncTable[365])((IntPtr)label, (IntPtr)t, (IntPtr)@out, (IntPtr)format, cmap);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ColormapButton(byte* label, Vector2 size, ImPlotColormap cmap)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, Vector2, ImPlotColormap, byte>)FuncTable[366])((IntPtr)label, size, cmap);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void BustColorCache(byte* plotTitleId)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[367])((IntPtr)plotTitleId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotInputMap* GetInputMap()
		{
			return (ImPlotInputMap*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[368])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void MapInputDefault(ImPlotInputMap* dst)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[369])((IntPtr)dst);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void MapInputReverse(ImPlotInputMap* dst)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[370])((IntPtr)dst);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ItemIconVec4(Vector4 col)
		{
			((delegate* unmanaged[Cdecl]<Vector4, void>)FuncTable[371])(col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ItemIconU32(uint col)
		{
			((delegate* unmanaged[Cdecl]<uint, void>)FuncTable[372])(col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ColormapIcon(ImPlotColormap cmap)
		{
			((delegate* unmanaged[Cdecl]<ImPlotColormap, void>)FuncTable[373])(cmap);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImDrawList* GetPlotDrawList()
		{
			return (ImDrawList*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[374])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PushPlotClipRect(float expand)
		{
			((delegate* unmanaged[Cdecl]<float, void>)FuncTable[375])(expand);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PopPlotClipRect()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[376])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ShowStyleSelector(byte* label)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[377])((IntPtr)label);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ShowColormapSelector(byte* label)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[378])((IntPtr)label);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ShowInputMapSelector(byte* label)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[379])((IntPtr)label);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ShowStyleEditor(ImPlotStyle* @ref)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[380])((IntPtr)@ref);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ShowUserGuide()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[381])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ShowMetricsWindow(byte* pPopen)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[382])((IntPtr)pPopen);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ShowDemoWindow(byte* pOpen)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[383])((IntPtr)pOpen);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ImLog10Float(float x)
		{
			return ((delegate* unmanaged[Cdecl]<float, float>)FuncTable[384])(x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double ImLog10Double(double x)
		{
			return ((delegate* unmanaged[Cdecl]<double, double>)FuncTable[385])(x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ImSinhFloat(float x)
		{
			return ((delegate* unmanaged[Cdecl]<float, float>)FuncTable[386])(x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double ImSinhDouble(double x)
		{
			return ((delegate* unmanaged[Cdecl]<double, double>)FuncTable[387])(x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ImAsinhFloat(float x)
		{
			return ((delegate* unmanaged[Cdecl]<float, float>)FuncTable[388])(x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double ImAsinhDouble(double x)
		{
			return ((delegate* unmanaged[Cdecl]<double, double>)FuncTable[389])(x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ImRemapFloat(float x, float x0, float x1, float y0, float y1)
		{
			return ((delegate* unmanaged[Cdecl]<float, float, float, float, float, float>)FuncTable[390])(x, x0, x1, y0, y1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double ImRemapDouble(double x, double x0, double x1, double y0, double y1)
		{
			return ((delegate* unmanaged[Cdecl]<double, double, double, double, double, double>)FuncTable[391])(x, x0, x1, y0, y1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static sbyte ImRemapS8(sbyte x, sbyte x0, sbyte x1, sbyte y0, sbyte y1)
		{
			return ((delegate* unmanaged[Cdecl]<sbyte, sbyte, sbyte, sbyte, sbyte, sbyte>)FuncTable[392])(x, x0, x1, y0, y1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImRemapU8(byte x, byte x0, byte x1, byte y0, byte y1)
		{
			return ((delegate* unmanaged[Cdecl]<byte, byte, byte, byte, byte, byte>)FuncTable[393])(x, x0, x1, y0, y1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static short ImRemapS16(short x, short x0, short x1, short y0, short y1)
		{
			return ((delegate* unmanaged[Cdecl]<short, short, short, short, short, short>)FuncTable[394])(x, x0, x1, y0, y1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ushort ImRemapU16(ushort x, ushort x0, ushort x1, ushort y0, ushort y1)
		{
			return ((delegate* unmanaged[Cdecl]<ushort, ushort, ushort, ushort, ushort, ushort>)FuncTable[395])(x, x0, x1, y0, y1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ImRemapS32(int x, int x0, int x1, int y0, int y1)
		{
			return ((delegate* unmanaged[Cdecl]<int, int, int, int, int, int>)FuncTable[396])(x, x0, x1, y0, y1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ImRemapU32(uint x, uint x0, uint x1, uint y0, uint y1)
		{
			return ((delegate* unmanaged[Cdecl]<uint, uint, uint, uint, uint, uint>)FuncTable[397])(x, x0, x1, y0, y1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static long ImRemapS64(long x, long x0, long x1, long y0, long y1)
		{
			return ((delegate* unmanaged[Cdecl]<long, long, long, long, long, long>)FuncTable[398])(x, x0, x1, y0, y1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong ImRemapU64(ulong x, ulong x0, ulong x1, ulong y0, ulong y1)
		{
			return ((delegate* unmanaged[Cdecl]<ulong, ulong, ulong, ulong, ulong, ulong>)FuncTable[399])(x, x0, x1, y0, y1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ImRemap01Float(float x, float x0, float x1)
		{
			return ((delegate* unmanaged[Cdecl]<float, float, float, float>)FuncTable[400])(x, x0, x1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double ImRemap01Double(double x, double x0, double x1)
		{
			return ((delegate* unmanaged[Cdecl]<double, double, double, double>)FuncTable[401])(x, x0, x1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static sbyte ImRemap01S8(sbyte x, sbyte x0, sbyte x1)
		{
			return ((delegate* unmanaged[Cdecl]<sbyte, sbyte, sbyte, sbyte>)FuncTable[402])(x, x0, x1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImRemap01U8(byte x, byte x0, byte x1)
		{
			return ((delegate* unmanaged[Cdecl]<byte, byte, byte, byte>)FuncTable[403])(x, x0, x1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static short ImRemap01S16(short x, short x0, short x1)
		{
			return ((delegate* unmanaged[Cdecl]<short, short, short, short>)FuncTable[404])(x, x0, x1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ushort ImRemap01U16(ushort x, ushort x0, ushort x1)
		{
			return ((delegate* unmanaged[Cdecl]<ushort, ushort, ushort, ushort>)FuncTable[405])(x, x0, x1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ImRemap01S32(int x, int x0, int x1)
		{
			return ((delegate* unmanaged[Cdecl]<int, int, int, int>)FuncTable[406])(x, x0, x1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ImRemap01U32(uint x, uint x0, uint x1)
		{
			return ((delegate* unmanaged[Cdecl]<uint, uint, uint, uint>)FuncTable[407])(x, x0, x1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static long ImRemap01S64(long x, long x0, long x1)
		{
			return ((delegate* unmanaged[Cdecl]<long, long, long, long>)FuncTable[408])(x, x0, x1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong ImRemap01U64(ulong x, ulong x0, ulong x1)
		{
			return ((delegate* unmanaged[Cdecl]<ulong, ulong, ulong, ulong>)FuncTable[409])(x, x0, x1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ImPosMod(int l, int r)
		{
			return ((delegate* unmanaged[Cdecl]<int, int, int>)FuncTable[410])(l, r);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImNan(double val)
		{
			return ((delegate* unmanaged[Cdecl]<double, byte>)FuncTable[411])(val);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImNanOrInf(double val)
		{
			return ((delegate* unmanaged[Cdecl]<double, byte>)FuncTable[412])(val);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double ImConstrainNan(double val)
		{
			return ((delegate* unmanaged[Cdecl]<double, double>)FuncTable[413])(val);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double ImConstrainInf(double val)
		{
			return ((delegate* unmanaged[Cdecl]<double, double>)FuncTable[414])(val);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double ImConstrainLog(double val)
		{
			return ((delegate* unmanaged[Cdecl]<double, double>)FuncTable[415])(val);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double ImConstrainTime(double val)
		{
			return ((delegate* unmanaged[Cdecl]<double, double>)FuncTable[416])(val);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImAlmostEqual(double v1, double v2, int ulp)
		{
			return ((delegate* unmanaged[Cdecl]<double, double, int, byte>)FuncTable[417])(v1, v2, ulp);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ImMinArrayFloatPtr(float* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, float>)FuncTable[418])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double ImMinArrayDoublePtr(double* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, double>)FuncTable[419])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static sbyte ImMinArrayS8Ptr(sbyte* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, sbyte>)FuncTable[420])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImMinArrayU8Ptr(byte* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, byte>)FuncTable[421])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static short ImMinArrayS16Ptr(short* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, short>)FuncTable[422])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ushort ImMinArrayU16Ptr(ushort* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, ushort>)FuncTable[423])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ImMinArrayS32Ptr(int* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, int>)FuncTable[424])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ImMinArrayU32Ptr(uint* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, uint>)FuncTable[425])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static long ImMinArrayS64Ptr(long* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, long>)FuncTable[426])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong ImMinArrayU64Ptr(ulong* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, ulong>)FuncTable[427])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ImMaxArrayFloatPtr(float* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, float>)FuncTable[428])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double ImMaxArrayDoublePtr(double* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, double>)FuncTable[429])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static sbyte ImMaxArrayS8Ptr(sbyte* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, sbyte>)FuncTable[430])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImMaxArrayU8Ptr(byte* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, byte>)FuncTable[431])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static short ImMaxArrayS16Ptr(short* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, short>)FuncTable[432])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ushort ImMaxArrayU16Ptr(ushort* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, ushort>)FuncTable[433])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ImMaxArrayS32Ptr(int* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, int>)FuncTable[434])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ImMaxArrayU32Ptr(uint* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, uint>)FuncTable[435])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static long ImMaxArrayS64Ptr(long* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, long>)FuncTable[436])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong ImMaxArrayU64Ptr(ulong* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, ulong>)FuncTable[437])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImMinMaxArrayFloatPtr(float* values, int count, float* minOut, float* maxOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, void>)FuncTable[438])((IntPtr)values, count, (IntPtr)minOut, (IntPtr)maxOut);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImMinMaxArrayDoublePtr(double* values, int count, double* minOut, double* maxOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, void>)FuncTable[439])((IntPtr)values, count, (IntPtr)minOut, (IntPtr)maxOut);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImMinMaxArrayS8Ptr(sbyte* values, int count, sbyte* minOut, sbyte* maxOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, void>)FuncTable[440])((IntPtr)values, count, (IntPtr)minOut, (IntPtr)maxOut);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImMinMaxArrayU8Ptr(byte* values, int count, byte* minOut, byte* maxOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, void>)FuncTable[441])((IntPtr)values, count, (IntPtr)minOut, (IntPtr)maxOut);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImMinMaxArrayS16Ptr(short* values, int count, short* minOut, short* maxOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, void>)FuncTable[442])((IntPtr)values, count, (IntPtr)minOut, (IntPtr)maxOut);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImMinMaxArrayU16Ptr(ushort* values, int count, ushort* minOut, ushort* maxOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, void>)FuncTable[443])((IntPtr)values, count, (IntPtr)minOut, (IntPtr)maxOut);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImMinMaxArrayS32Ptr(int* values, int count, int* minOut, int* maxOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, void>)FuncTable[444])((IntPtr)values, count, (IntPtr)minOut, (IntPtr)maxOut);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImMinMaxArrayU32Ptr(uint* values, int count, uint* minOut, uint* maxOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, void>)FuncTable[445])((IntPtr)values, count, (IntPtr)minOut, (IntPtr)maxOut);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImMinMaxArrayS64Ptr(long* values, int count, long* minOut, long* maxOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, void>)FuncTable[446])((IntPtr)values, count, (IntPtr)minOut, (IntPtr)maxOut);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImMinMaxArrayU64Ptr(ulong* values, int count, ulong* minOut, ulong* maxOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, void>)FuncTable[447])((IntPtr)values, count, (IntPtr)minOut, (IntPtr)maxOut);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ImSumFloatPtr(float* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, float>)FuncTable[448])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double ImSumDoublePtr(double* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, double>)FuncTable[449])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static sbyte ImSumS8Ptr(sbyte* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, sbyte>)FuncTable[450])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImSumU8Ptr(byte* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, byte>)FuncTable[451])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static short ImSumS16Ptr(short* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, short>)FuncTable[452])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ushort ImSumU16Ptr(ushort* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, ushort>)FuncTable[453])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ImSumS32Ptr(int* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, int>)FuncTable[454])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ImSumU32Ptr(uint* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, uint>)FuncTable[455])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static long ImSumS64Ptr(long* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, long>)FuncTable[456])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong ImSumU64Ptr(ulong* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, ulong>)FuncTable[457])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double ImMeanFloatPtr(float* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, double>)FuncTable[458])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double ImMeanDoublePtr(double* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, double>)FuncTable[459])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double ImMeanS8Ptr(sbyte* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, double>)FuncTable[460])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double ImMeanU8Ptr(byte* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, double>)FuncTable[461])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double ImMeanS16Ptr(short* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, double>)FuncTable[462])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double ImMeanU16Ptr(ushort* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, double>)FuncTable[463])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double ImMeanS32Ptr(int* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, double>)FuncTable[464])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double ImMeanU32Ptr(uint* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, double>)FuncTable[465])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double ImMeanS64Ptr(long* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, double>)FuncTable[466])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double ImMeanU64Ptr(ulong* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, double>)FuncTable[467])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double ImStdDevFloatPtr(float* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, double>)FuncTable[468])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double ImStdDevDoublePtr(double* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, double>)FuncTable[469])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double ImStdDevS8Ptr(sbyte* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, double>)FuncTable[470])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double ImStdDevU8Ptr(byte* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, double>)FuncTable[471])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double ImStdDevS16Ptr(short* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, double>)FuncTable[472])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double ImStdDevU16Ptr(ushort* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, double>)FuncTable[473])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double ImStdDevS32Ptr(int* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, double>)FuncTable[474])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double ImStdDevU32Ptr(uint* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, double>)FuncTable[475])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double ImStdDevS64Ptr(long* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, double>)FuncTable[476])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double ImStdDevU64Ptr(ulong* values, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, double>)FuncTable[477])((IntPtr)values, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ImMixU32(uint a, uint b, uint s)
		{
			return ((delegate* unmanaged[Cdecl]<uint, uint, uint, uint>)FuncTable[478])(a, b, s);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ImLerpU32(uint* colors, int size, float t)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, float, uint>)FuncTable[479])((IntPtr)colors, size, t);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ImAlphaU32(uint col, float alpha)
		{
			return ((delegate* unmanaged[Cdecl]<uint, float, uint>)FuncTable[480])(col, alpha);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImOverlapsFloat(float minA, float maxA, float minB, float maxB)
		{
			return ((delegate* unmanaged[Cdecl]<float, float, float, float, byte>)FuncTable[481])(minA, maxA, minB, maxB);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImOverlapsDouble(double minA, double maxA, double minB, double maxB)
		{
			return ((delegate* unmanaged[Cdecl]<double, double, double, double, byte>)FuncTable[482])(minA, maxA, minB, maxB);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImOverlapsS8(sbyte minA, sbyte maxA, sbyte minB, sbyte maxB)
		{
			return ((delegate* unmanaged[Cdecl]<sbyte, sbyte, sbyte, sbyte, byte>)FuncTable[483])(minA, maxA, minB, maxB);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImOverlapsU8(byte minA, byte maxA, byte minB, byte maxB)
		{
			return ((delegate* unmanaged[Cdecl]<byte, byte, byte, byte, byte>)FuncTable[484])(minA, maxA, minB, maxB);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImOverlapsS16(short minA, short maxA, short minB, short maxB)
		{
			return ((delegate* unmanaged[Cdecl]<short, short, short, short, byte>)FuncTable[485])(minA, maxA, minB, maxB);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImOverlapsU16(ushort minA, ushort maxA, ushort minB, ushort maxB)
		{
			return ((delegate* unmanaged[Cdecl]<ushort, ushort, ushort, ushort, byte>)FuncTable[486])(minA, maxA, minB, maxB);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImOverlapsS32(int minA, int maxA, int minB, int maxB)
		{
			return ((delegate* unmanaged[Cdecl]<int, int, int, int, byte>)FuncTable[487])(minA, maxA, minB, maxB);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImOverlapsU32(uint minA, uint maxA, uint minB, uint maxB)
		{
			return ((delegate* unmanaged[Cdecl]<uint, uint, uint, uint, byte>)FuncTable[488])(minA, maxA, minB, maxB);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImOverlapsS64(long minA, long maxA, long minB, long maxB)
		{
			return ((delegate* unmanaged[Cdecl]<long, long, long, long, byte>)FuncTable[489])(minA, maxA, minB, maxB);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImOverlapsU64(ulong minA, ulong maxA, ulong minB, ulong maxB)
		{
			return ((delegate* unmanaged[Cdecl]<ulong, ulong, ulong, ulong, byte>)FuncTable[490])(minA, maxA, minB, maxB);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotDateTimeSpec* DateTimeSpecDateTimeSpecNil()
		{
			return (ImPlotDateTimeSpec*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[491])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DateTimeSpecDestroy(ImPlotDateTimeSpec* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[492])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotDateTimeSpec* DateTimeSpecDateTimeSpecPlotDateFmt(ImPlotDateFmt dateFmt, ImPlotTimeFmt timeFmt, byte use_24HrClk, byte useIso_8601)
		{
			return (ImPlotDateTimeSpec*)((delegate* unmanaged[Cdecl]<ImPlotDateFmt, ImPlotTimeFmt, byte, byte, IntPtr>)FuncTable[493])(dateFmt, timeFmt, use_24HrClk, useIso_8601);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotTime* TimeTimeNil()
		{
			return (ImPlotTime*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[494])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TimeDestroy(ImPlotTime* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[495])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotTime* TimeTimeTimeT(long s, int us)
		{
			return (ImPlotTime*)((delegate* unmanaged[Cdecl]<long, int, IntPtr>)FuncTable[496])(s, us);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TimeRollOver(ImPlotTime* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[497])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double TimeToDouble(ImPlotTime* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, double>)FuncTable[498])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TimeFromDouble(ImPlotTime* pOut, double t)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, double, void>)FuncTable[499])((IntPtr)pOut, t);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotColormapData* ColormapDataColormapData()
		{
			return (ImPlotColormapData*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[500])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ColormapDataDestroy(ImPlotColormapData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[501])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ColormapDataAppend(ImPlotColormapData* self, byte* name, uint* keys, int count, byte qual)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, byte, int>)FuncTable[502])((IntPtr)self, (IntPtr)name, (IntPtr)keys, count, qual);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ColormapDataAppendTable(ImPlotColormapData* self, ImPlotColormap cmap)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImPlotColormap, void>)FuncTable[503])((IntPtr)self, cmap);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ColormapDataRebuildTables(ImPlotColormapData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[504])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ColormapDataIsQual(ImPlotColormapData* self, ImPlotColormap cmap)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImPlotColormap, byte>)FuncTable[505])((IntPtr)self, cmap);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* ColormapDataGetName(ImPlotColormapData* self, ImPlotColormap cmap)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, ImPlotColormap, IntPtr>)FuncTable[506])((IntPtr)self, cmap);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotColormap ColormapDataGetIndex(ImPlotColormapData* self, byte* name)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImPlotColormap>)FuncTable[507])((IntPtr)self, (IntPtr)name);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint* ColormapDataGetKeys(ImPlotColormapData* self, ImPlotColormap cmap)
		{
			return (uint*)((delegate* unmanaged[Cdecl]<IntPtr, ImPlotColormap, IntPtr>)FuncTable[508])((IntPtr)self, cmap);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ColormapDataGetKeyCount(ImPlotColormapData* self, ImPlotColormap cmap)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImPlotColormap, int>)FuncTable[509])((IntPtr)self, cmap);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ColormapDataGetKeyColor(ImPlotColormapData* self, ImPlotColormap cmap, int idx)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImPlotColormap, int, uint>)FuncTable[510])((IntPtr)self, cmap, idx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ColormapDataSetKeyColor(ImPlotColormapData* self, ImPlotColormap cmap, int idx, uint value)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImPlotColormap, int, uint, void>)FuncTable[511])((IntPtr)self, cmap, idx, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint* ColormapDataGetTable(ImPlotColormapData* self, ImPlotColormap cmap)
		{
			return (uint*)((delegate* unmanaged[Cdecl]<IntPtr, ImPlotColormap, IntPtr>)FuncTable[512])((IntPtr)self, cmap);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ColormapDataGetTableSize(ImPlotColormapData* self, ImPlotColormap cmap)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImPlotColormap, int>)FuncTable[513])((IntPtr)self, cmap);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ColormapDataGetTableColor(ImPlotColormapData* self, ImPlotColormap cmap, int idx)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImPlotColormap, int, uint>)FuncTable[514])((IntPtr)self, cmap, idx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ColormapDataLerpTable(ImPlotColormapData* self, ImPlotColormap cmap, float t)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImPlotColormap, float, uint>)FuncTable[515])((IntPtr)self, cmap, t);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotPointError* PointErrorPointError(double x, double y, double neg, double pos)
		{
			return (ImPlotPointError*)((delegate* unmanaged[Cdecl]<double, double, double, double, IntPtr>)FuncTable[516])(x, y, neg, pos);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PointErrorDestroy(ImPlotPointError* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[517])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotAnnotation* AnnotationAnnotation()
		{
			return (ImPlotAnnotation*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[518])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AnnotationDestroy(ImPlotAnnotation* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[519])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotAnnotationCollection* AnnotationCollectionAnnotationCollection()
		{
			return (ImPlotAnnotationCollection*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[520])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AnnotationCollectionDestroy(ImPlotAnnotationCollection* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[521])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AnnotationCollectionAppend(ImPlotAnnotationCollection* self, Vector2 pos, Vector2 off, uint bg, uint fg, byte clamp, byte* fmt)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, uint, uint, byte, IntPtr, void>)FuncTable[522])((IntPtr)self, pos, off, bg, fg, clamp, (IntPtr)fmt);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* AnnotationCollectionGetText(ImPlotAnnotationCollection* self, int idx)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr>)FuncTable[523])((IntPtr)self, idx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AnnotationCollectionReset(ImPlotAnnotationCollection* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[524])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotTagCollection* TagCollectionTagCollection()
		{
			return (ImPlotTagCollection*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[525])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TagCollectionDestroy(ImPlotTagCollection* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[526])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TagCollectionAppend(ImPlotTagCollection* self, ImAxis axis, double value, uint bg, uint fg, byte* fmt)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImAxis, double, uint, uint, IntPtr, void>)FuncTable[527])((IntPtr)self, axis, value, bg, fg, (IntPtr)fmt);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* TagCollectionGetText(ImPlotTagCollection* self, int idx)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr>)FuncTable[528])((IntPtr)self, idx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TagCollectionReset(ImPlotTagCollection* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[529])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotTick* TickTick(double value, byte major, int level, byte showLabel)
		{
			return (ImPlotTick*)((delegate* unmanaged[Cdecl]<double, byte, int, byte, IntPtr>)FuncTable[530])(value, major, level, showLabel);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TickDestroy(ImPlotTick* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[531])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotTicker* TickerTicker()
		{
			return (ImPlotTicker*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[532])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TickerDestroy(ImPlotTicker* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[533])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotTick* TickerAddTickDoubleStr(ImPlotTicker* self, double value, byte major, int level, byte showLabel, byte* label)
		{
			return (ImPlotTick*)((delegate* unmanaged[Cdecl]<IntPtr, double, byte, int, byte, IntPtr, IntPtr>)FuncTable[534])((IntPtr)self, value, major, level, showLabel, (IntPtr)label);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotTick* TickerAddTickDoublePlotFormatter(ImPlotTicker* self, double value, byte major, int level, byte showLabel, IntPtr formatter, void* data)
		{
			return (ImPlotTick*)((delegate* unmanaged[Cdecl]<IntPtr, double, byte, int, byte, IntPtr, IntPtr, IntPtr>)FuncTable[535])((IntPtr)self, value, major, level, showLabel, formatter, (IntPtr)data);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotTick* TickerAddTickPlotTick(ImPlotTicker* self, ImPlotTick tick)
		{
			return (ImPlotTick*)((delegate* unmanaged[Cdecl]<IntPtr, ImPlotTick, IntPtr>)FuncTable[536])((IntPtr)self, tick);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* TickerGetTextInt(ImPlotTicker* self, int idx)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr>)FuncTable[537])((IntPtr)self, idx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* TickerGetTextPlotTick(ImPlotTicker* self, ImPlotTick tick)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, ImPlotTick, IntPtr>)FuncTable[538])((IntPtr)self, tick);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TickerOverrideSizeLate(ImPlotTicker* self, Vector2 size)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, void>)FuncTable[539])((IntPtr)self, size);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TickerReset(ImPlotTicker* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[540])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int TickerTickCount(ImPlotTicker* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int>)FuncTable[541])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotAxis* AxisAxis()
		{
			return (ImPlotAxis*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[542])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AxisDestroy(ImPlotAxis* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[543])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AxisReset(ImPlotAxis* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[544])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte AxisSetMin(ImPlotAxis* self, double min, byte force)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, double, byte, byte>)FuncTable[545])((IntPtr)self, min, force);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte AxisSetMax(ImPlotAxis* self, double max, byte force)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, double, byte, byte>)FuncTable[546])((IntPtr)self, max, force);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AxisSetRangeDouble(ImPlotAxis* self, double v1, double v2)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, double, double, void>)FuncTable[547])((IntPtr)self, v1, v2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AxisSetRangePlotRange(ImPlotAxis* self, ImPlotRange range)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImPlotRange, void>)FuncTable[548])((IntPtr)self, range);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AxisSetAspect(ImPlotAxis* self, double unitPerPix)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, double, void>)FuncTable[549])((IntPtr)self, unitPerPix);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float AxisPixelSize(ImPlotAxis* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, float>)FuncTable[550])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double AxisGetAspect(ImPlotAxis* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, double>)FuncTable[551])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AxisConstrain(ImPlotAxis* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[552])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AxisUpdateTransformCache(ImPlotAxis* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[553])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float AxisPlotToPixels(ImPlotAxis* self, double plt)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, double, float>)FuncTable[554])((IntPtr)self, plt);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double AxisPixelsToPlot(ImPlotAxis* self, float pix)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, float, double>)FuncTable[555])((IntPtr)self, pix);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AxisExtendFit(ImPlotAxis* self, double v)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, double, void>)FuncTable[556])((IntPtr)self, v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AxisExtendFitWith(ImPlotAxis* self, ImPlotAxis* alt, double v, double vAlt)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, double, void>)FuncTable[557])((IntPtr)self, (IntPtr)alt, v, vAlt);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AxisApplyFit(ImPlotAxis* self, float padding)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, void>)FuncTable[558])((IntPtr)self, padding);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte AxisHasLabel(ImPlotAxis* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[559])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte AxisHasGridLines(ImPlotAxis* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[560])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte AxisHasTickLabels(ImPlotAxis* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[561])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte AxisHasTickMarks(ImPlotAxis* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[562])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte AxisWillRender(ImPlotAxis* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[563])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte AxisIsOpposite(ImPlotAxis* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[564])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte AxisIsInverted(ImPlotAxis* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[565])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte AxisIsForeground(ImPlotAxis* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[566])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte AxisIsAutoFitting(ImPlotAxis* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[567])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte AxisCanInitFit(ImPlotAxis* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[568])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte AxisIsRangeLocked(ImPlotAxis* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[569])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte AxisIsLockedMin(ImPlotAxis* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[570])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte AxisIsLockedMax(ImPlotAxis* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[571])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte AxisIsLocked(ImPlotAxis* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[572])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte AxisIsInputLockedMin(ImPlotAxis* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[573])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte AxisIsInputLockedMax(ImPlotAxis* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[574])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte AxisIsInputLocked(ImPlotAxis* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[575])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte AxisHasMenus(ImPlotAxis* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[576])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte AxisIsPanLocked(ImPlotAxis* self, byte increasing)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte, byte>)FuncTable[577])((IntPtr)self, increasing);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AxisPushLinks(ImPlotAxis* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[578])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AxisPullLinks(ImPlotAxis* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[579])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotAlignmentData* AlignmentDataAlignmentData()
		{
			return (ImPlotAlignmentData*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[580])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AlignmentDataDestroy(ImPlotAlignmentData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[581])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AlignmentDataBegin(ImPlotAlignmentData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[582])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AlignmentDataUpdate(ImPlotAlignmentData* self, float* padA, float* padB, float* deltaA, float* deltaB)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, void>)FuncTable[583])((IntPtr)self, (IntPtr)padA, (IntPtr)padB, (IntPtr)deltaA, (IntPtr)deltaB);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AlignmentDataEnd(ImPlotAlignmentData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[584])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AlignmentDataReset(ImPlotAlignmentData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[585])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotItem* ItemItem()
		{
			return (ImPlotItem*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[586])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ItemDestroy(ImPlotItem* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[587])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotLegend* LegendLegend()
		{
			return (ImPlotLegend*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[588])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LegendDestroy(ImPlotLegend* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[589])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LegendReset(ImPlotLegend* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[590])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotItemGroup* ItemGroupItemGroup()
		{
			return (ImPlotItemGroup*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[591])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ItemGroupDestroy(ImPlotItemGroup* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[592])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ItemGroupGetItemCount(ImPlotItemGroup* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int>)FuncTable[593])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ItemGroupGetItemID(ImPlotItemGroup* self, byte* labelId)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, uint>)FuncTable[594])((IntPtr)self, (IntPtr)labelId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotItem* ItemGroupGetItemID(ImPlotItemGroup* self, uint id)
		{
			return (ImPlotItem*)((delegate* unmanaged[Cdecl]<IntPtr, uint, IntPtr>)FuncTable[595])((IntPtr)self, id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotItem* ItemGroupGetItemStr(ImPlotItemGroup* self, byte* labelId)
		{
			return (ImPlotItem*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr>)FuncTable[596])((IntPtr)self, (IntPtr)labelId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotItem* ItemGroupGetOrAddItem(ImPlotItemGroup* self, uint id)
		{
			return (ImPlotItem*)((delegate* unmanaged[Cdecl]<IntPtr, uint, IntPtr>)FuncTable[597])((IntPtr)self, id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotItem* ItemGroupGetItemByIndex(ImPlotItemGroup* self, int i)
		{
			return (ImPlotItem*)((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr>)FuncTable[598])((IntPtr)self, i);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ItemGroupGetItemIndex(ImPlotItemGroup* self, ImPlotItem* item)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int>)FuncTable[599])((IntPtr)self, (IntPtr)item);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ItemGroupGetLegendCount(ImPlotItemGroup* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int>)FuncTable[600])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotItem* ItemGroupGetLegendItem(ImPlotItemGroup* self, int i)
		{
			return (ImPlotItem*)((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr>)FuncTable[601])((IntPtr)self, i);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* ItemGroupGetLegendLabel(ImPlotItemGroup* self, int i)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr>)FuncTable[602])((IntPtr)self, i);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ItemGroupReset(ImPlotItemGroup* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[603])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotPlot* PlotPlot()
		{
			return (ImPlotPlot*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[604])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotDestroy(ImPlotPlot* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[605])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte PlotIsInputLocked(ImPlotPlot* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[606])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotClearTextBuffer(ImPlotPlot* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[607])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotSetTitle(ImPlotPlot* self, byte* title)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[608])((IntPtr)self, (IntPtr)title);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte PlotHasTitle(ImPlotPlot* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[609])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* PlotGetTitle(ImPlotPlot* self)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[610])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotAxis* PlotXAxisNil(ImPlotPlot* self, int i)
		{
			return (ImPlotAxis*)((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr>)FuncTable[611])((IntPtr)self, i);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotAxis* PlotXAxisConst(ImPlotPlot* self, int i)
		{
			return (ImPlotAxis*)((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr>)FuncTable[612])((IntPtr)self, i);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotAxis* PlotYAxisNil(ImPlotPlot* self, int i)
		{
			return (ImPlotAxis*)((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr>)FuncTable[613])((IntPtr)self, i);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotAxis* PlotYAxisConst(ImPlotPlot* self, int i)
		{
			return (ImPlotAxis*)((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr>)FuncTable[614])((IntPtr)self, i);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int PlotEnabledAxesX(ImPlotPlot* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int>)FuncTable[615])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int PlotEnabledAxesY(ImPlotPlot* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int>)FuncTable[616])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotSetAxisLabel(ImPlotPlot* self, ImPlotAxis* axis, byte* label)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, void>)FuncTable[617])((IntPtr)self, (IntPtr)axis, (IntPtr)label);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* PlotGetAxisLabel(ImPlotPlot* self, ImPlotAxis axis)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, ImPlotAxis, IntPtr>)FuncTable[618])((IntPtr)self, axis);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotSubplot* SubplotSubplot()
		{
			return (ImPlotSubplot*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[619])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SubplotDestroy(ImPlotSubplot* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[620])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotNextPlotData* NextPlotDataNextPlotData()
		{
			return (ImPlotNextPlotData*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[621])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void NextPlotDataDestroy(ImPlotNextPlotData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[622])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void NextPlotDataReset(ImPlotNextPlotData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[623])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotNextItemData* NextItemDataNextItemData()
		{
			return (ImPlotNextItemData*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[624])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void NextItemDataDestroy(ImPlotNextItemData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[625])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void NextItemDataReset(ImPlotNextItemData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[626])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Initialize(ImPlotContext* ctx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[627])((IntPtr)ctx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ResetCtxForNextPlot(ImPlotContext* ctx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[628])((IntPtr)ctx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ResetCtxForNextAlignedPlots(ImPlotContext* ctx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[629])((IntPtr)ctx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ResetCtxForNextSubplot(ImPlotContext* ctx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[630])((IntPtr)ctx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotPlot* GetPlot(byte* title)
		{
			return (ImPlotPlot*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[631])((IntPtr)title);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotPlot* GetCurrentPlot()
		{
			return (ImPlotPlot*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[632])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void BustPlotCache()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[633])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ShowPlotContextMenu(ImPlotPlot* plot)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[634])((IntPtr)plot);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetupLock()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[635])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SubplotNextCell()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[636])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ShowSubplotsContextMenu(ImPlotSubplot* subplot)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[637])((IntPtr)subplot);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginItem(byte* labelId, ImPlotItemFlags flags, ImPlotCol recolorFrom)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImPlotItemFlags, ImPlotCol, byte>)FuncTable[638])((IntPtr)labelId, flags, recolorFrom);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void EndItem()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[639])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotItem* RegisterOrGetItem(byte* labelId, ImPlotItemFlags flags, byte* justCreated)
		{
			return (ImPlotItem*)((delegate* unmanaged[Cdecl]<IntPtr, ImPlotItemFlags, IntPtr, IntPtr>)FuncTable[640])((IntPtr)labelId, flags, (IntPtr)justCreated);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotItem* GetItem(byte* labelId)
		{
			return (ImPlotItem*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[641])((IntPtr)labelId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotItem* GetCurrentItem()
		{
			return (ImPlotItem*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[642])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void BustItemCache()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[643])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte AnyAxesInputLocked(ImPlotAxis* axes, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, byte>)FuncTable[644])((IntPtr)axes, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte AllAxesInputLocked(ImPlotAxis* axes, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, byte>)FuncTable[645])((IntPtr)axes, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte AnyAxesHeld(ImPlotAxis* axes, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, byte>)FuncTable[646])((IntPtr)axes, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte AnyAxesHovered(ImPlotAxis* axes, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, byte>)FuncTable[647])((IntPtr)axes, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte FitThisFrame()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[648])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void FitPointX(double x)
		{
			((delegate* unmanaged[Cdecl]<double, void>)FuncTable[649])(x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void FitPointY(double y)
		{
			((delegate* unmanaged[Cdecl]<double, void>)FuncTable[650])(y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void FitPoint(ImPlotPoint p)
		{
			((delegate* unmanaged[Cdecl]<ImPlotPoint, void>)FuncTable[651])(p);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte RangesOverlap(ImPlotRange r1, ImPlotRange r2)
		{
			return ((delegate* unmanaged[Cdecl]<ImPlotRange, ImPlotRange, byte>)FuncTable[652])(r1, r2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ShowAxisContextMenu(ImPlotAxis* axis, ImPlotAxis* equalAxis, byte timeAllowed)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, byte, void>)FuncTable[653])((IntPtr)axis, (IntPtr)equalAxis, timeAllowed);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GetLocationPos(Vector2* pOut, ImRect outerRect, Vector2 innerSize, ImPlotLocation location, Vector2 pad)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImRect, Vector2, ImPlotLocation, Vector2, void>)FuncTable[654])((IntPtr)pOut, outerRect, innerSize, location, pad);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CalcLegendSize(Vector2* pOut, ImPlotItemGroup* items, Vector2 pad, Vector2 spacing, byte vertical)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, Vector2, Vector2, byte, void>)FuncTable[655])((IntPtr)pOut, (IntPtr)items, pad, spacing, vertical);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ClampLegendRect(ImRect* legendRect, ImRect outerRect, Vector2 pad)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImRect, Vector2, byte>)FuncTable[656])((IntPtr)legendRect, outerRect, pad);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ShowLegendEntries(ImPlotItemGroup* items, ImRect legendBb, byte interactable, Vector2 pad, Vector2 spacing, byte vertical, ImDrawList* drawList)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImRect, byte, Vector2, Vector2, byte, IntPtr, byte>)FuncTable[657])((IntPtr)items, legendBb, interactable, pad, spacing, vertical, (IntPtr)drawList);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ShowAltLegend(byte* titleId, byte vertical, Vector2 size, byte interactable)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, byte, Vector2, byte, void>)FuncTable[658])((IntPtr)titleId, vertical, size, interactable);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ShowLegendContextMenu(ImPlotLegend* legend, byte visible)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte, byte>)FuncTable[659])((IntPtr)legend, visible);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LabelAxisValue(ImPlotAxis axis, double value, byte* buff, int size, byte round)
		{
			((delegate* unmanaged[Cdecl]<ImPlotAxis, double, IntPtr, int, byte, void>)FuncTable[660])(axis, value, (IntPtr)buff, size, round);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlotNextItemData* GetItemData()
		{
			return (ImPlotNextItemData*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[661])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsColorAutoVec4(Vector4 col)
		{
			return ((delegate* unmanaged[Cdecl]<Vector4, byte>)FuncTable[662])(col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsColorAutoPlotCol(ImPlotCol idx)
		{
			return ((delegate* unmanaged[Cdecl]<ImPlotCol, byte>)FuncTable[663])(idx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GetAutoColor(Vector4* pOut, ImPlotCol idx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImPlotCol, void>)FuncTable[664])((IntPtr)pOut, idx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GetStyleColorVec4(Vector4* pOut, ImPlotCol idx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImPlotCol, void>)FuncTable[665])((IntPtr)pOut, idx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint GetStyleColorU32(ImPlotCol idx)
		{
			return ((delegate* unmanaged[Cdecl]<ImPlotCol, uint>)FuncTable[666])(idx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddTextVertical(ImDrawList* drawList, Vector2 pos, uint col, byte* textBegin, byte* textEnd)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, uint, IntPtr, IntPtr, void>)FuncTable[667])((IntPtr)drawList, pos, col, (IntPtr)textBegin, (IntPtr)textEnd);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddTextCentered(ImDrawList* drawList, Vector2 topCenter, uint col, byte* textBegin, byte* textEnd)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, uint, IntPtr, IntPtr, void>)FuncTable[668])((IntPtr)drawList, topCenter, col, (IntPtr)textBegin, (IntPtr)textEnd);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CalcTextSizeVertical(Vector2* pOut, byte* text)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[669])((IntPtr)pOut, (IntPtr)text);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint CalcTextColorVec4(Vector4 bg)
		{
			return ((delegate* unmanaged[Cdecl]<Vector4, uint>)FuncTable[670])(bg);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint CalcTextColorU32(uint bg)
		{
			return ((delegate* unmanaged[Cdecl]<uint, uint>)FuncTable[671])(bg);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint CalcHoverColor(uint col)
		{
			return ((delegate* unmanaged[Cdecl]<uint, uint>)FuncTable[672])(col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ClampLabelPos(Vector2* pOut, Vector2 pos, Vector2 size, Vector2 min, Vector2 max)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, Vector2, Vector2, void>)FuncTable[673])((IntPtr)pOut, pos, size, min, max);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint GetColormapColorU32(int idx, ImPlotColormap cmap)
		{
			return ((delegate* unmanaged[Cdecl]<int, ImPlotColormap, uint>)FuncTable[674])(idx, cmap);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint NextColormapColorU32()
		{
			return ((delegate* unmanaged[Cdecl]<uint>)FuncTable[675])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint SampleColormapU32(float t, ImPlotColormap cmap)
		{
			return ((delegate* unmanaged[Cdecl]<float, ImPlotColormap, uint>)FuncTable[676])(t, cmap);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RenderColorBar(uint* colors, int size, ImDrawList* drawList, ImRect bounds, byte vert, byte reversed, byte continuous)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, ImRect, byte, byte, byte, void>)FuncTable[677])((IntPtr)colors, size, (IntPtr)drawList, bounds, vert, reversed, continuous);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double NiceNum(double x, byte round)
		{
			return ((delegate* unmanaged[Cdecl]<double, byte, double>)FuncTable[678])(x, round);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int OrderOfMagnitude(double val)
		{
			return ((delegate* unmanaged[Cdecl]<double, int>)FuncTable[679])(val);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int OrderToPrecision(int order)
		{
			return ((delegate* unmanaged[Cdecl]<int, int>)FuncTable[680])(order);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Precision(double val)
		{
			return ((delegate* unmanaged[Cdecl]<double, int>)FuncTable[681])(val);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double RoundTo(double val, int prec)
		{
			return ((delegate* unmanaged[Cdecl]<double, int, double>)FuncTable[682])(val, prec);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Intersection(Vector2* pOut, Vector2 a1, Vector2 a2, Vector2 b1, Vector2 b2)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, Vector2, Vector2, void>)FuncTable[683])((IntPtr)pOut, a1, a2, b1, b2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void FillRangeVectorFloatPtr(ImVector<float>* buffer, int n, float vmin, float vmax)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, float, float, void>)FuncTable[684])((IntPtr)buffer, n, vmin, vmax);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void FillRangeVectorDoublePtr(ImVector<double>* buffer, int n, double vmin, double vmax)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, double, double, void>)FuncTable[685])((IntPtr)buffer, n, vmin, vmax);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void FillRangeVectorS8Ptr(ImVector<sbyte>* buffer, int n, sbyte vmin, sbyte vmax)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, sbyte, sbyte, void>)FuncTable[686])((IntPtr)buffer, n, vmin, vmax);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void FillRangeVectorU8Ptr(ImVector<byte>* buffer, int n, byte vmin, byte vmax)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, byte, byte, void>)FuncTable[687])((IntPtr)buffer, n, vmin, vmax);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void FillRangeVectorS16Ptr(ImVector<short>* buffer, int n, short vmin, short vmax)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, short, short, void>)FuncTable[688])((IntPtr)buffer, n, vmin, vmax);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void FillRangeVectorU16Ptr(ImVector<ushort>* buffer, int n, ushort vmin, ushort vmax)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, ushort, ushort, void>)FuncTable[689])((IntPtr)buffer, n, vmin, vmax);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void FillRangeVectorS32Ptr(ImVector<int>* buffer, int n, int vmin, int vmax)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, int, int, void>)FuncTable[690])((IntPtr)buffer, n, vmin, vmax);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void FillRangeVectorU32Ptr(ImVector<uint>* buffer, int n, uint vmin, uint vmax)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, uint, uint, void>)FuncTable[691])((IntPtr)buffer, n, vmin, vmax);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void FillRangeVectorS64Ptr(ImVector<long>* buffer, int n, long vmin, long vmax)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, long, long, void>)FuncTable[692])((IntPtr)buffer, n, vmin, vmax);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void FillRangeVectorU64Ptr(ImVector<ulong>* buffer, int n, ulong vmin, ulong vmax)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, ulong, ulong, void>)FuncTable[693])((IntPtr)buffer, n, vmin, vmax);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CalculateBinsFloatPtr(float* values, int count, ImPlotBin meth, ImPlotRange range, int* binsOut, double* widthOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, ImPlotBin, ImPlotRange, IntPtr, IntPtr, void>)FuncTable[694])((IntPtr)values, count, meth, range, (IntPtr)binsOut, (IntPtr)widthOut);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CalculateBinsDoublePtr(double* values, int count, ImPlotBin meth, ImPlotRange range, int* binsOut, double* widthOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, ImPlotBin, ImPlotRange, IntPtr, IntPtr, void>)FuncTable[695])((IntPtr)values, count, meth, range, (IntPtr)binsOut, (IntPtr)widthOut);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CalculateBinsS8Ptr(sbyte* values, int count, ImPlotBin meth, ImPlotRange range, int* binsOut, double* widthOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, ImPlotBin, ImPlotRange, IntPtr, IntPtr, void>)FuncTable[696])((IntPtr)values, count, meth, range, (IntPtr)binsOut, (IntPtr)widthOut);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CalculateBinsU8Ptr(byte* values, int count, ImPlotBin meth, ImPlotRange range, int* binsOut, double* widthOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, ImPlotBin, ImPlotRange, IntPtr, IntPtr, void>)FuncTable[697])((IntPtr)values, count, meth, range, (IntPtr)binsOut, (IntPtr)widthOut);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CalculateBinsS16Ptr(short* values, int count, ImPlotBin meth, ImPlotRange range, int* binsOut, double* widthOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, ImPlotBin, ImPlotRange, IntPtr, IntPtr, void>)FuncTable[698])((IntPtr)values, count, meth, range, (IntPtr)binsOut, (IntPtr)widthOut);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CalculateBinsU16Ptr(ushort* values, int count, ImPlotBin meth, ImPlotRange range, int* binsOut, double* widthOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, ImPlotBin, ImPlotRange, IntPtr, IntPtr, void>)FuncTable[699])((IntPtr)values, count, meth, range, (IntPtr)binsOut, (IntPtr)widthOut);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CalculateBinsS32Ptr(int* values, int count, ImPlotBin meth, ImPlotRange range, int* binsOut, double* widthOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, ImPlotBin, ImPlotRange, IntPtr, IntPtr, void>)FuncTable[700])((IntPtr)values, count, meth, range, (IntPtr)binsOut, (IntPtr)widthOut);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CalculateBinsU32Ptr(uint* values, int count, ImPlotBin meth, ImPlotRange range, int* binsOut, double* widthOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, ImPlotBin, ImPlotRange, IntPtr, IntPtr, void>)FuncTable[701])((IntPtr)values, count, meth, range, (IntPtr)binsOut, (IntPtr)widthOut);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CalculateBinsS64Ptr(long* values, int count, ImPlotBin meth, ImPlotRange range, int* binsOut, double* widthOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, ImPlotBin, ImPlotRange, IntPtr, IntPtr, void>)FuncTable[702])((IntPtr)values, count, meth, range, (IntPtr)binsOut, (IntPtr)widthOut);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CalculateBinsU64Ptr(ulong* values, int count, ImPlotBin meth, ImPlotRange range, int* binsOut, double* widthOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, ImPlotBin, ImPlotRange, IntPtr, IntPtr, void>)FuncTable[703])((IntPtr)values, count, meth, range, (IntPtr)binsOut, (IntPtr)widthOut);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsLeapYear(int year)
		{
			return ((delegate* unmanaged[Cdecl]<int, byte>)FuncTable[704])(year);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int GetDaysInMonth(int year, int month)
		{
			return ((delegate* unmanaged[Cdecl]<int, int, int>)FuncTable[705])(year, month);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void MkGmtTime(ImPlotTime* pOut, Tm* ptm)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[706])((IntPtr)pOut, (IntPtr)ptm);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Tm* GetGmtTime(ImPlotTime t, Tm* ptm)
		{
			return (Tm*)((delegate* unmanaged[Cdecl]<ImPlotTime, IntPtr, IntPtr>)FuncTable[707])(t, (IntPtr)ptm);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void MkLocTime(ImPlotTime* pOut, Tm* ptm)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[708])((IntPtr)pOut, (IntPtr)ptm);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Tm* GetLocTime(ImPlotTime t, Tm* ptm)
		{
			return (Tm*)((delegate* unmanaged[Cdecl]<ImPlotTime, IntPtr, IntPtr>)FuncTable[709])(t, (IntPtr)ptm);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void MkTime(ImPlotTime* pOut, Tm* ptm)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[710])((IntPtr)pOut, (IntPtr)ptm);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Tm* GetTime(ImPlotTime t, Tm* ptm)
		{
			return (Tm*)((delegate* unmanaged[Cdecl]<ImPlotTime, IntPtr, IntPtr>)FuncTable[711])(t, (IntPtr)ptm);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void MakeTime(ImPlotTime* pOut, int year, int month, int day, int hour, int min, int sec, int us)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, int, int, int, int, int, int, void>)FuncTable[712])((IntPtr)pOut, year, month, day, hour, min, sec, us);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int GetYear(ImPlotTime t)
		{
			return ((delegate* unmanaged[Cdecl]<ImPlotTime, int>)FuncTable[713])(t);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int GetMonth(ImPlotTime t)
		{
			return ((delegate* unmanaged[Cdecl]<ImPlotTime, int>)FuncTable[714])(t);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddTime(ImPlotTime* pOut, ImPlotTime t, ImPlotTimeUnit unit, int count)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImPlotTime, ImPlotTimeUnit, int, void>)FuncTable[715])((IntPtr)pOut, t, unit, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void FloorTime(ImPlotTime* pOut, ImPlotTime t, ImPlotTimeUnit unit)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImPlotTime, ImPlotTimeUnit, void>)FuncTable[716])((IntPtr)pOut, t, unit);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CeilTime(ImPlotTime* pOut, ImPlotTime t, ImPlotTimeUnit unit)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImPlotTime, ImPlotTimeUnit, void>)FuncTable[717])((IntPtr)pOut, t, unit);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RoundTime(ImPlotTime* pOut, ImPlotTime t, ImPlotTimeUnit unit)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImPlotTime, ImPlotTimeUnit, void>)FuncTable[718])((IntPtr)pOut, t, unit);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CombineDateTime(ImPlotTime* pOut, ImPlotTime datePart, ImPlotTime timePart)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImPlotTime, ImPlotTime, void>)FuncTable[719])((IntPtr)pOut, datePart, timePart);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Now(ImPlotTime* pOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[720])((IntPtr)pOut);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Today(ImPlotTime* pOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[721])((IntPtr)pOut);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int FormatTime(ImPlotTime t, byte* buffer, int size, ImPlotTimeFmt fmt, byte use_24HrClk)
		{
			return ((delegate* unmanaged[Cdecl]<ImPlotTime, IntPtr, int, ImPlotTimeFmt, byte, int>)FuncTable[722])(t, (IntPtr)buffer, size, fmt, use_24HrClk);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int FormatDate(ImPlotTime t, byte* buffer, int size, ImPlotDateFmt fmt, byte useIso_8601)
		{
			return ((delegate* unmanaged[Cdecl]<ImPlotTime, IntPtr, int, ImPlotDateFmt, byte, int>)FuncTable[723])(t, (IntPtr)buffer, size, fmt, useIso_8601);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int FormatDateTime(ImPlotTime t, byte* buffer, int size, ImPlotDateTimeSpec fmt)
		{
			return ((delegate* unmanaged[Cdecl]<ImPlotTime, IntPtr, int, ImPlotDateTimeSpec, int>)FuncTable[724])(t, (IntPtr)buffer, size, fmt);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ShowDatePicker(byte* id, int* level, ImPlotTime* t, ImPlotTime* t1, ImPlotTime* t2)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, byte>)FuncTable[725])((IntPtr)id, (IntPtr)level, (IntPtr)t, (IntPtr)t1, (IntPtr)t2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ShowTimePicker(byte* id, ImPlotTime* t)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, byte>)FuncTable[726])((IntPtr)id, (IntPtr)t);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double TransformForwardLog10(double v, void* noname1)
		{
			return ((delegate* unmanaged[Cdecl]<double, IntPtr, double>)FuncTable[727])(v, (IntPtr)noname1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double TransformInverseLog10(double v, void* noname1)
		{
			return ((delegate* unmanaged[Cdecl]<double, IntPtr, double>)FuncTable[728])(v, (IntPtr)noname1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double TransformForwardSymLog(double v, void* noname1)
		{
			return ((delegate* unmanaged[Cdecl]<double, IntPtr, double>)FuncTable[729])(v, (IntPtr)noname1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double TransformInverseSymLog(double v, void* noname1)
		{
			return ((delegate* unmanaged[Cdecl]<double, IntPtr, double>)FuncTable[730])(v, (IntPtr)noname1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double TransformForwardLogit(double v, void* noname1)
		{
			return ((delegate* unmanaged[Cdecl]<double, IntPtr, double>)FuncTable[731])(v, (IntPtr)noname1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double TransformInverseLogit(double v, void* noname1)
		{
			return ((delegate* unmanaged[Cdecl]<double, IntPtr, double>)FuncTable[732])(v, (IntPtr)noname1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int FormatterDefault(double value, byte* buff, int size, void* data)
		{
			return ((delegate* unmanaged[Cdecl]<double, IntPtr, int, IntPtr, int>)FuncTable[733])(value, (IntPtr)buff, size, (IntPtr)data);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int FormatterLogit(double value, byte* buff, int size, void* noname1)
		{
			return ((delegate* unmanaged[Cdecl]<double, IntPtr, int, IntPtr, int>)FuncTable[734])(value, (IntPtr)buff, size, (IntPtr)noname1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int FormatterTime(double noname1, byte* buff, int size, void* data)
		{
			return ((delegate* unmanaged[Cdecl]<double, IntPtr, int, IntPtr, int>)FuncTable[735])(noname1, (IntPtr)buff, size, (IntPtr)data);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LocatorDefault(ImPlotTicker* ticker, ImPlotRange range, float pixels, byte vertical, IntPtr formatter, void* formatterData)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImPlotRange, float, byte, IntPtr, IntPtr, void>)FuncTable[736])((IntPtr)ticker, range, pixels, vertical, formatter, (IntPtr)formatterData);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LocatorTime(ImPlotTicker* ticker, ImPlotRange range, float pixels, byte vertical, IntPtr formatter, void* formatterData)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImPlotRange, float, byte, IntPtr, IntPtr, void>)FuncTable[737])((IntPtr)ticker, range, pixels, vertical, formatter, (IntPtr)formatterData);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LocatorLog10(ImPlotTicker* ticker, ImPlotRange range, float pixels, byte vertical, IntPtr formatter, void* formatterData)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImPlotRange, float, byte, IntPtr, IntPtr, void>)FuncTable[738])((IntPtr)ticker, range, pixels, vertical, formatter, (IntPtr)formatterData);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LocatorSymLog(ImPlotTicker* ticker, ImPlotRange range, float pixels, byte vertical, IntPtr formatter, void* formatterData)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImPlotRange, float, byte, IntPtr, IntPtr, void>)FuncTable[739])((IntPtr)ticker, range, pixels, vertical, formatter, (IntPtr)formatterData);
		}

	}
}
