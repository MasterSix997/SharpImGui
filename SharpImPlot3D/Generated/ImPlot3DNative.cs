using SharpImGui;
using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImPlot3D
{
	public unsafe partial class ImPlot3DNative
	{
		static ImPlot3DNative()
		{
			InitApi(new NativeLibraryContext(LibraryLoader.LoadLibrary(GetLibraryName, null)));
		}

		public static string GetLibraryName()
		{
			return "cimplot3d";
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlot3DContext* CreateContext()
		{
			return (ImPlot3DContext*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[0])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DestroyContext(ImPlot3DContext* ctx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1])((IntPtr)ctx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlot3DContext* GetCurrentContext()
		{
			return (ImPlot3DContext*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[2])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCurrentContext(ImPlot3DContext* ctx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[3])((IntPtr)ctx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginPlot(byte* titleId, Vector2 size, ImPlot3DFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, Vector2, ImPlot3DFlags, byte>)FuncTable[4])((IntPtr)titleId, size, flags);
		}

		/// <summary>
		/// Only call if BeginPlot() returns true!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void EndPlot()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[5])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetupAxis(ImAxis3D axis, byte* label, ImPlot3DAxisFlags flags)
		{
			((delegate* unmanaged[Cdecl]<ImAxis3D, IntPtr, ImPlot3DAxisFlags, void>)FuncTable[6])(axis, (IntPtr)label, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetupAxisLimits(ImAxis3D axis, double vMin, double vMax, ImPlot3DCond cond)
		{
			((delegate* unmanaged[Cdecl]<ImAxis3D, double, double, ImPlot3DCond, void>)FuncTable[7])(axis, vMin, vMax, cond);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetupAxisFormat(ImAxis3D idx, ImPlot3DFormatter formatter, void* data)
		{
			((delegate* unmanaged[Cdecl]<ImAxis3D, ImPlot3DFormatter, IntPtr, void>)FuncTable[8])(idx, formatter, (IntPtr)data);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetupAxisTicksDoublePtr(ImAxis3D axis, double* values, int nTicks, byte** labels, byte keepDefault)
		{
			((delegate* unmanaged[Cdecl]<ImAxis3D, IntPtr, int, IntPtr, byte, void>)FuncTable[9])(axis, (IntPtr)values, nTicks, (IntPtr)labels, keepDefault);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetupAxisTicksDouble(ImAxis3D axis, double vMin, double vMax, int nTicks, byte** labels, byte keepDefault)
		{
			((delegate* unmanaged[Cdecl]<ImAxis3D, double, double, int, IntPtr, byte, void>)FuncTable[10])(axis, vMin, vMax, nTicks, (IntPtr)labels, keepDefault);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetupAxes(byte* xLabel, byte* yLabel, byte* zLabel, ImPlot3DAxisFlags xFlags, ImPlot3DAxisFlags yFlags, ImPlot3DAxisFlags zFlags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, ImPlot3DAxisFlags, ImPlot3DAxisFlags, ImPlot3DAxisFlags, void>)FuncTable[11])((IntPtr)xLabel, (IntPtr)yLabel, (IntPtr)zLabel, xFlags, yFlags, zFlags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetupAxesLimits(double xMin, double xMax, double yMin, double yMax, double zMin, double zMax, ImPlot3DCond cond)
		{
			((delegate* unmanaged[Cdecl]<double, double, double, double, double, double, ImPlot3DCond, void>)FuncTable[12])(xMin, xMax, yMin, yMax, zMin, zMax, cond);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetupBoxRotationFloat(float elevation, float azimuth, byte animate, ImPlot3DCond cond)
		{
			((delegate* unmanaged[Cdecl]<float, float, byte, ImPlot3DCond, void>)FuncTable[13])(elevation, azimuth, animate, cond);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetupBoxRotationPlot3DQuat(ImPlot3DQuat rotation, byte animate, ImPlot3DCond cond)
		{
			((delegate* unmanaged[Cdecl]<ImPlot3DQuat, byte, ImPlot3DCond, void>)FuncTable[14])(rotation, animate, cond);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetupBoxInitialRotationFloat(float elevation, float azimuth)
		{
			((delegate* unmanaged[Cdecl]<float, float, void>)FuncTable[15])(elevation, azimuth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetupBoxInitialRotationPlot3DQuat(ImPlot3DQuat rotation)
		{
			((delegate* unmanaged[Cdecl]<ImPlot3DQuat, void>)FuncTable[16])(rotation);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetupBoxScale(float x, float y, float z)
		{
			((delegate* unmanaged[Cdecl]<float, float, float, void>)FuncTable[17])(x, y, z);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetupLegend(ImPlot3DLocation location, ImPlot3DLegendFlags flags)
		{
			((delegate* unmanaged[Cdecl]<ImPlot3DLocation, ImPlot3DLegendFlags, void>)FuncTable[18])(location, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotScatterFloatPtr(byte* labelId, float* xs, float* ys, float* zs, int count, ImPlot3DScatterFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlot3DScatterFlags, int, int, void>)FuncTable[19])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotScatterDoublePtr(byte* labelId, double* xs, double* ys, double* zs, int count, ImPlot3DScatterFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlot3DScatterFlags, int, int, void>)FuncTable[20])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotScatterS8Ptr(byte* labelId, sbyte* xs, sbyte* ys, sbyte* zs, int count, ImPlot3DScatterFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlot3DScatterFlags, int, int, void>)FuncTable[21])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotScatterU8Ptr(byte* labelId, byte* xs, byte* ys, byte* zs, int count, ImPlot3DScatterFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlot3DScatterFlags, int, int, void>)FuncTable[22])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotScatterS16Ptr(byte* labelId, short* xs, short* ys, short* zs, int count, ImPlot3DScatterFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlot3DScatterFlags, int, int, void>)FuncTable[23])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotScatterU16Ptr(byte* labelId, ushort* xs, ushort* ys, ushort* zs, int count, ImPlot3DScatterFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlot3DScatterFlags, int, int, void>)FuncTable[24])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotScatterS32Ptr(byte* labelId, int* xs, int* ys, int* zs, int count, ImPlot3DScatterFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlot3DScatterFlags, int, int, void>)FuncTable[25])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotScatterU32Ptr(byte* labelId, uint* xs, uint* ys, uint* zs, int count, ImPlot3DScatterFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlot3DScatterFlags, int, int, void>)FuncTable[26])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotScatterS64Ptr(byte* labelId, long* xs, long* ys, long* zs, int count, ImPlot3DScatterFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlot3DScatterFlags, int, int, void>)FuncTable[27])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotScatterU64Ptr(byte* labelId, ulong* xs, ulong* ys, ulong* zs, int count, ImPlot3DScatterFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlot3DScatterFlags, int, int, void>)FuncTable[28])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotLineFloatPtr(byte* labelId, float* xs, float* ys, float* zs, int count, ImPlot3DLineFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlot3DLineFlags, int, int, void>)FuncTable[29])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotLineDoublePtr(byte* labelId, double* xs, double* ys, double* zs, int count, ImPlot3DLineFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlot3DLineFlags, int, int, void>)FuncTable[30])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotLineS8Ptr(byte* labelId, sbyte* xs, sbyte* ys, sbyte* zs, int count, ImPlot3DLineFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlot3DLineFlags, int, int, void>)FuncTable[31])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotLineU8Ptr(byte* labelId, byte* xs, byte* ys, byte* zs, int count, ImPlot3DLineFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlot3DLineFlags, int, int, void>)FuncTable[32])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotLineS16Ptr(byte* labelId, short* xs, short* ys, short* zs, int count, ImPlot3DLineFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlot3DLineFlags, int, int, void>)FuncTable[33])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotLineU16Ptr(byte* labelId, ushort* xs, ushort* ys, ushort* zs, int count, ImPlot3DLineFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlot3DLineFlags, int, int, void>)FuncTable[34])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotLineS32Ptr(byte* labelId, int* xs, int* ys, int* zs, int count, ImPlot3DLineFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlot3DLineFlags, int, int, void>)FuncTable[35])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotLineU32Ptr(byte* labelId, uint* xs, uint* ys, uint* zs, int count, ImPlot3DLineFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlot3DLineFlags, int, int, void>)FuncTable[36])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotLineS64Ptr(byte* labelId, long* xs, long* ys, long* zs, int count, ImPlot3DLineFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlot3DLineFlags, int, int, void>)FuncTable[37])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotLineU64Ptr(byte* labelId, ulong* xs, ulong* ys, ulong* zs, int count, ImPlot3DLineFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlot3DLineFlags, int, int, void>)FuncTable[38])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotTriangleFloatPtr(byte* labelId, float* xs, float* ys, float* zs, int count, ImPlot3DTriangleFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlot3DTriangleFlags, int, int, void>)FuncTable[39])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotTriangleDoublePtr(byte* labelId, double* xs, double* ys, double* zs, int count, ImPlot3DTriangleFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlot3DTriangleFlags, int, int, void>)FuncTable[40])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotTriangleS8Ptr(byte* labelId, sbyte* xs, sbyte* ys, sbyte* zs, int count, ImPlot3DTriangleFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlot3DTriangleFlags, int, int, void>)FuncTable[41])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotTriangleU8Ptr(byte* labelId, byte* xs, byte* ys, byte* zs, int count, ImPlot3DTriangleFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlot3DTriangleFlags, int, int, void>)FuncTable[42])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotTriangleS16Ptr(byte* labelId, short* xs, short* ys, short* zs, int count, ImPlot3DTriangleFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlot3DTriangleFlags, int, int, void>)FuncTable[43])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotTriangleU16Ptr(byte* labelId, ushort* xs, ushort* ys, ushort* zs, int count, ImPlot3DTriangleFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlot3DTriangleFlags, int, int, void>)FuncTable[44])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotTriangleS32Ptr(byte* labelId, int* xs, int* ys, int* zs, int count, ImPlot3DTriangleFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlot3DTriangleFlags, int, int, void>)FuncTable[45])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotTriangleU32Ptr(byte* labelId, uint* xs, uint* ys, uint* zs, int count, ImPlot3DTriangleFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlot3DTriangleFlags, int, int, void>)FuncTable[46])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotTriangleS64Ptr(byte* labelId, long* xs, long* ys, long* zs, int count, ImPlot3DTriangleFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlot3DTriangleFlags, int, int, void>)FuncTable[47])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotTriangleU64Ptr(byte* labelId, ulong* xs, ulong* ys, ulong* zs, int count, ImPlot3DTriangleFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlot3DTriangleFlags, int, int, void>)FuncTable[48])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotQuadFloatPtr(byte* labelId, float* xs, float* ys, float* zs, int count, ImPlot3DQuadFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlot3DQuadFlags, int, int, void>)FuncTable[49])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotQuadDoublePtr(byte* labelId, double* xs, double* ys, double* zs, int count, ImPlot3DQuadFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlot3DQuadFlags, int, int, void>)FuncTable[50])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotQuadS8Ptr(byte* labelId, sbyte* xs, sbyte* ys, sbyte* zs, int count, ImPlot3DQuadFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlot3DQuadFlags, int, int, void>)FuncTable[51])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotQuadU8Ptr(byte* labelId, byte* xs, byte* ys, byte* zs, int count, ImPlot3DQuadFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlot3DQuadFlags, int, int, void>)FuncTable[52])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotQuadS16Ptr(byte* labelId, short* xs, short* ys, short* zs, int count, ImPlot3DQuadFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlot3DQuadFlags, int, int, void>)FuncTable[53])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotQuadU16Ptr(byte* labelId, ushort* xs, ushort* ys, ushort* zs, int count, ImPlot3DQuadFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlot3DQuadFlags, int, int, void>)FuncTable[54])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotQuadS32Ptr(byte* labelId, int* xs, int* ys, int* zs, int count, ImPlot3DQuadFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlot3DQuadFlags, int, int, void>)FuncTable[55])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotQuadU32Ptr(byte* labelId, uint* xs, uint* ys, uint* zs, int count, ImPlot3DQuadFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlot3DQuadFlags, int, int, void>)FuncTable[56])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotQuadS64Ptr(byte* labelId, long* xs, long* ys, long* zs, int count, ImPlot3DQuadFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlot3DQuadFlags, int, int, void>)FuncTable[57])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotQuadU64Ptr(byte* labelId, ulong* xs, ulong* ys, ulong* zs, int count, ImPlot3DQuadFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, ImPlot3DQuadFlags, int, int, void>)FuncTable[58])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, count, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotSurfaceFloatPtr(byte* labelId, float* xs, float* ys, float* zs, int xCount, int yCount, double scaleMin, double scaleMax, ImPlot3DSurfaceFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, int, double, double, ImPlot3DSurfaceFlags, int, int, void>)FuncTable[59])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, xCount, yCount, scaleMin, scaleMax, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotSurfaceDoublePtr(byte* labelId, double* xs, double* ys, double* zs, int xCount, int yCount, double scaleMin, double scaleMax, ImPlot3DSurfaceFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, int, double, double, ImPlot3DSurfaceFlags, int, int, void>)FuncTable[60])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, xCount, yCount, scaleMin, scaleMax, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotSurfaceS8Ptr(byte* labelId, sbyte* xs, sbyte* ys, sbyte* zs, int xCount, int yCount, double scaleMin, double scaleMax, ImPlot3DSurfaceFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, int, double, double, ImPlot3DSurfaceFlags, int, int, void>)FuncTable[61])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, xCount, yCount, scaleMin, scaleMax, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotSurfaceU8Ptr(byte* labelId, byte* xs, byte* ys, byte* zs, int xCount, int yCount, double scaleMin, double scaleMax, ImPlot3DSurfaceFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, int, double, double, ImPlot3DSurfaceFlags, int, int, void>)FuncTable[62])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, xCount, yCount, scaleMin, scaleMax, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotSurfaceS16Ptr(byte* labelId, short* xs, short* ys, short* zs, int xCount, int yCount, double scaleMin, double scaleMax, ImPlot3DSurfaceFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, int, double, double, ImPlot3DSurfaceFlags, int, int, void>)FuncTable[63])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, xCount, yCount, scaleMin, scaleMax, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotSurfaceU16Ptr(byte* labelId, ushort* xs, ushort* ys, ushort* zs, int xCount, int yCount, double scaleMin, double scaleMax, ImPlot3DSurfaceFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, int, double, double, ImPlot3DSurfaceFlags, int, int, void>)FuncTable[64])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, xCount, yCount, scaleMin, scaleMax, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotSurfaceS32Ptr(byte* labelId, int* xs, int* ys, int* zs, int xCount, int yCount, double scaleMin, double scaleMax, ImPlot3DSurfaceFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, int, double, double, ImPlot3DSurfaceFlags, int, int, void>)FuncTable[65])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, xCount, yCount, scaleMin, scaleMax, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotSurfaceU32Ptr(byte* labelId, uint* xs, uint* ys, uint* zs, int xCount, int yCount, double scaleMin, double scaleMax, ImPlot3DSurfaceFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, int, double, double, ImPlot3DSurfaceFlags, int, int, void>)FuncTable[66])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, xCount, yCount, scaleMin, scaleMax, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotSurfaceS64Ptr(byte* labelId, long* xs, long* ys, long* zs, int xCount, int yCount, double scaleMin, double scaleMax, ImPlot3DSurfaceFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, int, double, double, ImPlot3DSurfaceFlags, int, int, void>)FuncTable[67])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, xCount, yCount, scaleMin, scaleMax, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotSurfaceU64Ptr(byte* labelId, ulong* xs, ulong* ys, ulong* zs, int xCount, int yCount, double scaleMin, double scaleMax, ImPlot3DSurfaceFlags flags, int offset, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, int, double, double, ImPlot3DSurfaceFlags, int, int, void>)FuncTable[68])((IntPtr)labelId, (IntPtr)xs, (IntPtr)ys, (IntPtr)zs, xCount, yCount, scaleMin, scaleMax, flags, offset, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotMesh(byte* labelId, ImPlot3DPoint* vtx, uint* idx, int vtxCount, int idxCount, ImPlot3DMeshFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, int, ImPlot3DMeshFlags, void>)FuncTable[69])((IntPtr)labelId, (IntPtr)vtx, (IntPtr)idx, vtxCount, idxCount, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotText(byte* text, float x, float y, float z, float angle, Vector2 pixOffset)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, float, Vector2, void>)FuncTable[70])((IntPtr)text, x, y, z, angle, pixOffset);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotToPixelsPlot3DPoInt(Vector2* pOut, ImPlot3DPoint point)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImPlot3DPoint, void>)FuncTable[71])((IntPtr)pOut, point);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotToPixelsDouble(Vector2* pOut, double x, double y, double z)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, double, double, double, void>)FuncTable[72])((IntPtr)pOut, x, y, z);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlot3DRay PixelsToPlotRayVec2(Vector2 pix)
		{
			return ((delegate* unmanaged[Cdecl]<Vector2, ImPlot3DRay>)FuncTable[73])(pix);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlot3DRay PixelsToPlotRayDouble(double x, double y)
		{
			return ((delegate* unmanaged[Cdecl]<double, double, ImPlot3DRay>)FuncTable[74])(x, y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PixelsToPlotPlaneVec2(ImPlot3DPoint* pOut, Vector2 pix, ImPlane3D plane, byte mask)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, ImPlane3D, byte, void>)FuncTable[75])((IntPtr)pOut, pix, plane, mask);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PixelsToPlotPlaneDouble(ImPlot3DPoint* pOut, double x, double y, ImPlane3D plane, byte mask)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, double, double, ImPlane3D, byte, void>)FuncTable[76])((IntPtr)pOut, x, y, plane, mask);
		}

		/// <summary>
		/// Get the current plot position (top-left) in pixels<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GetPlotPos(Vector2* pOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[77])((IntPtr)pOut);
		}

		/// <summary>
		/// Get the current plot size in pixels<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GetPlotSize(Vector2* pOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[78])((IntPtr)pOut);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImDrawList* GetPlotDrawList()
		{
			return (ImDrawList*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[79])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlot3DStyle* GetStyle()
		{
			return (ImPlot3DStyle*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[80])();
		}

		/// <summary>
		/// Set colors with ImGui style<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void StyleColorsAuto(ImPlot3DStyle* dst)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[81])((IntPtr)dst);
		}

		/// <summary>
		/// Set colors with dark style<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void StyleColorsDark(ImPlot3DStyle* dst)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[82])((IntPtr)dst);
		}

		/// <summary>
		/// Set colors with light style<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void StyleColorsLight(ImPlot3DStyle* dst)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[83])((IntPtr)dst);
		}

		/// <summary>
		/// Set colors with classic style<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void StyleColorsClassic(ImPlot3DStyle* dst)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[84])((IntPtr)dst);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PushStyleColorU32(ImPlot3DCol idx, uint col)
		{
			((delegate* unmanaged[Cdecl]<ImPlot3DCol, uint, void>)FuncTable[85])(idx, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PushStyleColorVec4(ImPlot3DCol idx, Vector4 col)
		{
			((delegate* unmanaged[Cdecl]<ImPlot3DCol, Vector4, void>)FuncTable[86])(idx, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PopStyleColor(int count)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[87])(count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PushStyleVarFloat(ImPlot3DStyleVar idx, float val)
		{
			((delegate* unmanaged[Cdecl]<ImPlot3DStyleVar, float, void>)FuncTable[88])(idx, val);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PushStyleVarInt(ImPlot3DStyleVar idx, int val)
		{
			((delegate* unmanaged[Cdecl]<ImPlot3DStyleVar, int, void>)FuncTable[89])(idx, val);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PushStyleVarVec2(ImPlot3DStyleVar idx, Vector2 val)
		{
			((delegate* unmanaged[Cdecl]<ImPlot3DStyleVar, Vector2, void>)FuncTable[90])(idx, val);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PopStyleVar(int count)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[91])(count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetNextLineStyle(Vector4 col, float weight)
		{
			((delegate* unmanaged[Cdecl]<Vector4, float, void>)FuncTable[92])(col, weight);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetNextFillStyle(Vector4 col, float alphaMod)
		{
			((delegate* unmanaged[Cdecl]<Vector4, float, void>)FuncTable[93])(col, alphaMod);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetNextMarkerStyle(ImPlot3DMarker marker, float size, Vector4 fill, float weight, Vector4 outline)
		{
			((delegate* unmanaged[Cdecl]<ImPlot3DMarker, float, Vector4, float, Vector4, void>)FuncTable[94])(marker, size, fill, weight, outline);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GetStyleColorVec4(Vector4* pOut, ImPlot3DCol idx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImPlot3DCol, void>)FuncTable[95])((IntPtr)pOut, idx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint GetStyleColorU32(ImPlot3DCol idx)
		{
			return ((delegate* unmanaged[Cdecl]<ImPlot3DCol, uint>)FuncTable[96])(idx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlot3DColormap AddColormapVec4Ptr(byte* name, Vector4* cols, int size, byte qual)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, byte, ImPlot3DColormap>)FuncTable[97])((IntPtr)name, (IntPtr)cols, size, qual);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlot3DColormap AddColormapU32Ptr(byte* name, uint* cols, int size, byte qual)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, byte, ImPlot3DColormap>)FuncTable[98])((IntPtr)name, (IntPtr)cols, size, qual);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int GetColormapCount()
		{
			return ((delegate* unmanaged[Cdecl]<int>)FuncTable[99])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* GetColormapName(ImPlot3DColormap cmap)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<ImPlot3DColormap, IntPtr>)FuncTable[100])(cmap);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlot3DColormap GetColormapIndex(byte* name)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImPlot3DColormap>)FuncTable[101])((IntPtr)name);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PushColormapPlot3DColormap(ImPlot3DColormap cmap)
		{
			((delegate* unmanaged[Cdecl]<ImPlot3DColormap, void>)FuncTable[102])(cmap);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PushColormapStr(byte* name)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[103])((IntPtr)name);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PopColormap(int count)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[104])(count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void NextColormapColor(Vector4* pOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[105])((IntPtr)pOut);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int GetColormapSize(ImPlot3DColormap cmap)
		{
			return ((delegate* unmanaged[Cdecl]<ImPlot3DColormap, int>)FuncTable[106])(cmap);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GetColormapColor(Vector4* pOut, int idx, ImPlot3DColormap cmap)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, ImPlot3DColormap, void>)FuncTable[107])((IntPtr)pOut, idx, cmap);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SampleColormap(Vector4* pOut, float t, ImPlot3DColormap cmap)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, ImPlot3DColormap, void>)FuncTable[108])((IntPtr)pOut, t, cmap);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ShowDemoWindow(byte* pOpen)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[109])((IntPtr)pOpen);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ShowStyleEditor(ImPlot3DStyle* _ref)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[110])((IntPtr)_ref);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlot3DPoint* PointPointNil()
		{
			return (ImPlot3DPoint*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[111])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PointDestroy(ImPlot3DPoint* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[112])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlot3DPoint* PointPointFloat(float x, float y, float z)
		{
			return (ImPlot3DPoint*)((delegate* unmanaged[Cdecl]<float, float, float, IntPtr>)FuncTable[113])(x, y, z);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float PointDot(ImPlot3DPoint* self, ImPlot3DPoint rhs)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImPlot3DPoint, float>)FuncTable[114])((IntPtr)self, rhs);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PointCross(ImPlot3DPoint* pOut, ImPlot3DPoint* self, ImPlot3DPoint rhs)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImPlot3DPoint, void>)FuncTable[115])((IntPtr)pOut, (IntPtr)self, rhs);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float PointLength(ImPlot3DPoint* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, float>)FuncTable[116])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float PointLengthSquared(ImPlot3DPoint* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, float>)FuncTable[117])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PointNormalize(ImPlot3DPoint* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[118])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PointNormalized(ImPlot3DPoint* pOut, ImPlot3DPoint* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[119])((IntPtr)pOut, (IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte PointIsNaN(ImPlot3DPoint* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[120])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlot3DBox* BoxBoxNil()
		{
			return (ImPlot3DBox*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[121])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void BoxDestroy(ImPlot3DBox* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[122])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlot3DBox* BoxBoxPlot3DPoInt(ImPlot3DPoint min, ImPlot3DPoint max)
		{
			return (ImPlot3DBox*)((delegate* unmanaged[Cdecl]<ImPlot3DPoint, ImPlot3DPoint, IntPtr>)FuncTable[123])(min, max);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void BoxExpand(ImPlot3DBox* self, ImPlot3DPoint point)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImPlot3DPoint, void>)FuncTable[124])((IntPtr)self, point);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BoxContains(ImPlot3DBox* self, ImPlot3DPoint point)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImPlot3DPoint, byte>)FuncTable[125])((IntPtr)self, point);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BoxClipLineSegment(ImPlot3DBox* self, ImPlot3DPoint p0, ImPlot3DPoint p1, ImPlot3DPoint* p0Clipped, ImPlot3DPoint* p1Clipped)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImPlot3DPoint, ImPlot3DPoint, IntPtr, IntPtr, byte>)FuncTable[126])((IntPtr)self, p0, p1, (IntPtr)p0Clipped, (IntPtr)p1Clipped);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlot3DRange* RangeRangeNil()
		{
			return (ImPlot3DRange*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[127])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RangeDestroy(ImPlot3DRange* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[128])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlot3DRange* RangeRangeFloat(float min, float max)
		{
			return (ImPlot3DRange*)((delegate* unmanaged[Cdecl]<float, float, IntPtr>)FuncTable[129])(min, max);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RangeExpand(ImPlot3DRange* self, float value)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, void>)FuncTable[130])((IntPtr)self, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte RangeContains(ImPlot3DRange* self, float value)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, float, byte>)FuncTable[131])((IntPtr)self, value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float RangeSize(ImPlot3DRange* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, float>)FuncTable[132])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlot3DQuat* QuatQuatNil()
		{
			return (ImPlot3DQuat*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[133])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void QuatDestroy(ImPlot3DQuat* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[134])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlot3DQuat* QuatQuatFloatFloat(float x, float y, float z, float w)
		{
			return (ImPlot3DQuat*)((delegate* unmanaged[Cdecl]<float, float, float, float, IntPtr>)FuncTable[135])(x, y, z, w);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlot3DQuat* QuatQuatFloatPlot3DPoInt(float angle, ImPlot3DPoint axis)
		{
			return (ImPlot3DQuat*)((delegate* unmanaged[Cdecl]<float, ImPlot3DPoint, IntPtr>)FuncTable[136])(angle, axis);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void QuatFromTwoVectors(ImPlot3DQuat* pOut, ImPlot3DPoint v0, ImPlot3DPoint v1)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImPlot3DPoint, ImPlot3DPoint, void>)FuncTable[137])((IntPtr)pOut, v0, v1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void QuatFromElAz(ImPlot3DQuat* pOut, float elevation, float azimuth)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, float, void>)FuncTable[138])((IntPtr)pOut, elevation, azimuth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float QuatLength(ImPlot3DQuat* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, float>)FuncTable[139])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void QuatNormalized(ImPlot3DQuat* pOut, ImPlot3DQuat* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[140])((IntPtr)pOut, (IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void QuatConjugate(ImPlot3DQuat* pOut, ImPlot3DQuat* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[141])((IntPtr)pOut, (IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void QuatInverse(ImPlot3DQuat* pOut, ImPlot3DQuat* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[142])((IntPtr)pOut, (IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlot3DQuat* QuatNormalize(ImPlot3DQuat* self)
		{
			return (ImPlot3DQuat*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[143])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void QuatSlerp(ImPlot3DQuat* pOut, ImPlot3DQuat q1, ImPlot3DQuat q2, float t)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImPlot3DQuat, ImPlot3DQuat, float, void>)FuncTable[144])((IntPtr)pOut, q1, q2, t);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float QuatDot(ImPlot3DQuat* self, ImPlot3DQuat rhs)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImPlot3DQuat, float>)FuncTable[145])((IntPtr)self, rhs);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImPlot3DStyle* StyleStyle()
		{
			return (ImPlot3DStyle*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[146])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void StyleDestroy(ImPlot3DStyle* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[147])((IntPtr)self);
		}

	}
}
