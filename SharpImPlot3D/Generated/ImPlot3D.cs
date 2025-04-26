using SharpImGui;
using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImPlot3D
{
	public static unsafe partial class ImPlot3D
	{
		public static ImPlot3DContextPtr CreateContext()
		{
			return ImPlot3DNative.CreateContext();
		}

		public static void DestroyContext(ImPlot3DContextPtr ctx)
		{
			ImPlot3DNative.DestroyContext(ctx);
		}

		public static ImPlot3DContextPtr GetCurrentContext()
		{
			return ImPlot3DNative.GetCurrentContext();
		}

		public static void SetCurrentContext(ImPlot3DContextPtr ctx)
		{
			ImPlot3DNative.SetCurrentContext(ctx);
		}

		public static byte BeginPlot(ReadOnlySpan<char> titleId, Vector2 size, ImPlot3DFlags flags)
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

			return ImPlot3DNative.BeginPlot(native_titleId, size, flags);
			// Freeing titleId native string
			if (byteCount_titleId > Utils.MaxStackallocSize)
				Utils.Free(native_titleId);
		}

		/// <summary>
		/// Only call if BeginPlot() returns true!<br/>
		/// </summary>
		public static void EndPlot()
		{
			ImPlot3DNative.EndPlot();
		}

		public static void SetupAxis(ImAxis3D axis, ReadOnlySpan<char> label, ImPlot3DAxisFlags flags)
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

			ImPlot3DNative.SetupAxis(axis, native_label, flags);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
		}

		public static void SetupAxisLimits(ImAxis3D axis, double vMin, double vMax, ImPlot3DCond cond)
		{
			ImPlot3DNative.SetupAxisLimits(axis, vMin, vMax, cond);
		}

		public static void SetupAxisFormat(ImAxis3D idx, ImPlot3DFormatter formatter, IntPtr data)
		{
			ImPlot3DNative.SetupAxisFormat(idx, formatter, (void*)data);
		}

		public static void SetupAxisTicksDoublePtr(ImAxis3D axis, ref double values, int nTicks, ref byte* labels, bool keepDefault)
		{
			var native_keepDefault = keepDefault ? (byte)1 : (byte)0;
			fixed (double* native_values = &values)
			fixed (byte** native_labels = &labels)
			{
				ImPlot3DNative.SetupAxisTicksDoublePtr(axis, native_values, nTicks, native_labels, native_keepDefault);
			}
		}

		public static void SetupAxisTicksDouble(ImAxis3D axis, double vMin, double vMax, int nTicks, ref byte* labels, bool keepDefault)
		{
			var native_keepDefault = keepDefault ? (byte)1 : (byte)0;
			fixed (byte** native_labels = &labels)
			{
				ImPlot3DNative.SetupAxisTicksDouble(axis, vMin, vMax, nTicks, native_labels, native_keepDefault);
			}
		}

		public static void SetupAxes(ReadOnlySpan<char> xLabel, ReadOnlySpan<char> yLabel, ReadOnlySpan<char> zLabel, ImPlot3DAxisFlags xFlags, ImPlot3DAxisFlags yFlags, ImPlot3DAxisFlags zFlags)
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

			// Marshaling zLabel to native string
			byte* native_zLabel;
			var byteCount_zLabel = 0;
			if (zLabel != null)
			{
				byteCount_zLabel = Encoding.UTF8.GetByteCount(zLabel);
				if(byteCount_zLabel > Utils.MaxStackallocSize)
				{
					native_zLabel = Utils.Alloc<byte>(byteCount_zLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_zLabel + 1];
					native_zLabel = stackallocBytes;
				}
				var zLabel_offset = Utils.EncodeStringUTF8(zLabel, native_zLabel, byteCount_zLabel);
				native_zLabel[zLabel_offset] = 0;
			}
			else native_zLabel = null;

			ImPlot3DNative.SetupAxes(native_xLabel, native_yLabel, native_zLabel, xFlags, yFlags, zFlags);
			// Freeing xLabel native string
			if (byteCount_xLabel > Utils.MaxStackallocSize)
				Utils.Free(native_xLabel);
			// Freeing yLabel native string
			if (byteCount_yLabel > Utils.MaxStackallocSize)
				Utils.Free(native_yLabel);
			// Freeing zLabel native string
			if (byteCount_zLabel > Utils.MaxStackallocSize)
				Utils.Free(native_zLabel);
		}

		public static void SetupAxesLimits(double xMin, double xMax, double yMin, double yMax, double zMin, double zMax, ImPlot3DCond cond)
		{
			ImPlot3DNative.SetupAxesLimits(xMin, xMax, yMin, yMax, zMin, zMax, cond);
		}

		public static void SetupBoxRotationFloat(float elevation, float azimuth, bool animate, ImPlot3DCond cond)
		{
			var native_animate = animate ? (byte)1 : (byte)0;
			ImPlot3DNative.SetupBoxRotationFloat(elevation, azimuth, native_animate, cond);
		}

		public static void SetupBoxRotationPlot3DQuat(ImPlot3DQuat rotation, bool animate, ImPlot3DCond cond)
		{
			var native_animate = animate ? (byte)1 : (byte)0;
			ImPlot3DNative.SetupBoxRotationPlot3DQuat(rotation, native_animate, cond);
		}

		public static void SetupBoxInitialRotationFloat(float elevation, float azimuth)
		{
			ImPlot3DNative.SetupBoxInitialRotationFloat(elevation, azimuth);
		}

		public static void SetupBoxInitialRotationPlot3DQuat(ImPlot3DQuat rotation)
		{
			ImPlot3DNative.SetupBoxInitialRotationPlot3DQuat(rotation);
		}

		public static void SetupBoxScale(float x, float y, float z)
		{
			ImPlot3DNative.SetupBoxScale(x, y, z);
		}

		public static void SetupLegend(ImPlot3DLocation location, ImPlot3DLegendFlags flags)
		{
			ImPlot3DNative.SetupLegend(location, flags);
		}

		public static void PlotScatterFloatPtr(ReadOnlySpan<char> labelId, ref float xs, ref float ys, ref float zs, int count, ImPlot3DScatterFlags flags, int offset, int stride)
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
			fixed (float* native_zs = &zs)
			{
				ImPlot3DNative.PlotScatterFloatPtr(native_labelId, native_xs, native_ys, native_zs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotScatterDoublePtr(ReadOnlySpan<char> labelId, ref double xs, ref double ys, ref double zs, int count, ImPlot3DScatterFlags flags, int offset, int stride)
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
			fixed (double* native_zs = &zs)
			{
				ImPlot3DNative.PlotScatterDoublePtr(native_labelId, native_xs, native_ys, native_zs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotScatterS8Ptr(ReadOnlySpan<char> labelId, ref sbyte xs, ref sbyte ys, ref sbyte zs, int count, ImPlot3DScatterFlags flags, int offset, int stride)
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
			fixed (sbyte* native_zs = &zs)
			{
				ImPlot3DNative.PlotScatterS8Ptr(native_labelId, native_xs, native_ys, native_zs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotScatterU8Ptr(ReadOnlySpan<char> labelId, ReadOnlySpan<char> xs, ReadOnlySpan<char> ys, ReadOnlySpan<char> zs, int count, ImPlot3DScatterFlags flags, int offset, int stride)
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

			// Marshaling zs to native string
			byte* native_zs;
			var byteCount_zs = 0;
			if (zs != null)
			{
				byteCount_zs = Encoding.UTF8.GetByteCount(zs);
				if(byteCount_zs > Utils.MaxStackallocSize)
				{
					native_zs = Utils.Alloc<byte>(byteCount_zs + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_zs + 1];
					native_zs = stackallocBytes;
				}
				var zs_offset = Utils.EncodeStringUTF8(zs, native_zs, byteCount_zs);
				native_zs[zs_offset] = 0;
			}
			else native_zs = null;

			ImPlot3DNative.PlotScatterU8Ptr(native_labelId, native_xs, native_ys, native_zs, count, flags, offset, stride);
			// Freeing labelId native string
			if (byteCount_labelId > Utils.MaxStackallocSize)
				Utils.Free(native_labelId);
			// Freeing xs native string
			if (byteCount_xs > Utils.MaxStackallocSize)
				Utils.Free(native_xs);
			// Freeing ys native string
			if (byteCount_ys > Utils.MaxStackallocSize)
				Utils.Free(native_ys);
			// Freeing zs native string
			if (byteCount_zs > Utils.MaxStackallocSize)
				Utils.Free(native_zs);
		}

		public static void PlotScatterS16Ptr(ReadOnlySpan<char> labelId, ref short xs, ref short ys, ref short zs, int count, ImPlot3DScatterFlags flags, int offset, int stride)
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
			fixed (short* native_zs = &zs)
			{
				ImPlot3DNative.PlotScatterS16Ptr(native_labelId, native_xs, native_ys, native_zs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotScatterU16Ptr(ReadOnlySpan<char> labelId, ref ushort xs, ref ushort ys, ref ushort zs, int count, ImPlot3DScatterFlags flags, int offset, int stride)
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
			fixed (ushort* native_zs = &zs)
			{
				ImPlot3DNative.PlotScatterU16Ptr(native_labelId, native_xs, native_ys, native_zs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotScatterS32Ptr(ReadOnlySpan<char> labelId, ref int xs, ref int ys, ref int zs, int count, ImPlot3DScatterFlags flags, int offset, int stride)
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
			fixed (int* native_zs = &zs)
			{
				ImPlot3DNative.PlotScatterS32Ptr(native_labelId, native_xs, native_ys, native_zs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotScatterU32Ptr(ReadOnlySpan<char> labelId, ref uint xs, ref uint ys, ref uint zs, int count, ImPlot3DScatterFlags flags, int offset, int stride)
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
			fixed (uint* native_zs = &zs)
			{
				ImPlot3DNative.PlotScatterU32Ptr(native_labelId, native_xs, native_ys, native_zs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotScatterS64Ptr(ReadOnlySpan<char> labelId, ref long xs, ref long ys, ref long zs, int count, ImPlot3DScatterFlags flags, int offset, int stride)
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
			fixed (long* native_zs = &zs)
			{
				ImPlot3DNative.PlotScatterS64Ptr(native_labelId, native_xs, native_ys, native_zs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotScatterU64Ptr(ReadOnlySpan<char> labelId, ref ulong xs, ref ulong ys, ref ulong zs, int count, ImPlot3DScatterFlags flags, int offset, int stride)
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
			fixed (ulong* native_zs = &zs)
			{
				ImPlot3DNative.PlotScatterU64Ptr(native_labelId, native_xs, native_ys, native_zs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotLineFloatPtr(ReadOnlySpan<char> labelId, ref float xs, ref float ys, ref float zs, int count, ImPlot3DLineFlags flags, int offset, int stride)
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
			fixed (float* native_zs = &zs)
			{
				ImPlot3DNative.PlotLineFloatPtr(native_labelId, native_xs, native_ys, native_zs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotLineDoublePtr(ReadOnlySpan<char> labelId, ref double xs, ref double ys, ref double zs, int count, ImPlot3DLineFlags flags, int offset, int stride)
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
			fixed (double* native_zs = &zs)
			{
				ImPlot3DNative.PlotLineDoublePtr(native_labelId, native_xs, native_ys, native_zs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotLineS8Ptr(ReadOnlySpan<char> labelId, ref sbyte xs, ref sbyte ys, ref sbyte zs, int count, ImPlot3DLineFlags flags, int offset, int stride)
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
			fixed (sbyte* native_zs = &zs)
			{
				ImPlot3DNative.PlotLineS8Ptr(native_labelId, native_xs, native_ys, native_zs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotLineU8Ptr(ReadOnlySpan<char> labelId, ReadOnlySpan<char> xs, ReadOnlySpan<char> ys, ReadOnlySpan<char> zs, int count, ImPlot3DLineFlags flags, int offset, int stride)
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

			// Marshaling zs to native string
			byte* native_zs;
			var byteCount_zs = 0;
			if (zs != null)
			{
				byteCount_zs = Encoding.UTF8.GetByteCount(zs);
				if(byteCount_zs > Utils.MaxStackallocSize)
				{
					native_zs = Utils.Alloc<byte>(byteCount_zs + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_zs + 1];
					native_zs = stackallocBytes;
				}
				var zs_offset = Utils.EncodeStringUTF8(zs, native_zs, byteCount_zs);
				native_zs[zs_offset] = 0;
			}
			else native_zs = null;

			ImPlot3DNative.PlotLineU8Ptr(native_labelId, native_xs, native_ys, native_zs, count, flags, offset, stride);
			// Freeing labelId native string
			if (byteCount_labelId > Utils.MaxStackallocSize)
				Utils.Free(native_labelId);
			// Freeing xs native string
			if (byteCount_xs > Utils.MaxStackallocSize)
				Utils.Free(native_xs);
			// Freeing ys native string
			if (byteCount_ys > Utils.MaxStackallocSize)
				Utils.Free(native_ys);
			// Freeing zs native string
			if (byteCount_zs > Utils.MaxStackallocSize)
				Utils.Free(native_zs);
		}

		public static void PlotLineS16Ptr(ReadOnlySpan<char> labelId, ref short xs, ref short ys, ref short zs, int count, ImPlot3DLineFlags flags, int offset, int stride)
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
			fixed (short* native_zs = &zs)
			{
				ImPlot3DNative.PlotLineS16Ptr(native_labelId, native_xs, native_ys, native_zs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotLineU16Ptr(ReadOnlySpan<char> labelId, ref ushort xs, ref ushort ys, ref ushort zs, int count, ImPlot3DLineFlags flags, int offset, int stride)
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
			fixed (ushort* native_zs = &zs)
			{
				ImPlot3DNative.PlotLineU16Ptr(native_labelId, native_xs, native_ys, native_zs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotLineS32Ptr(ReadOnlySpan<char> labelId, ref int xs, ref int ys, ref int zs, int count, ImPlot3DLineFlags flags, int offset, int stride)
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
			fixed (int* native_zs = &zs)
			{
				ImPlot3DNative.PlotLineS32Ptr(native_labelId, native_xs, native_ys, native_zs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotLineU32Ptr(ReadOnlySpan<char> labelId, ref uint xs, ref uint ys, ref uint zs, int count, ImPlot3DLineFlags flags, int offset, int stride)
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
			fixed (uint* native_zs = &zs)
			{
				ImPlot3DNative.PlotLineU32Ptr(native_labelId, native_xs, native_ys, native_zs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotLineS64Ptr(ReadOnlySpan<char> labelId, ref long xs, ref long ys, ref long zs, int count, ImPlot3DLineFlags flags, int offset, int stride)
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
			fixed (long* native_zs = &zs)
			{
				ImPlot3DNative.PlotLineS64Ptr(native_labelId, native_xs, native_ys, native_zs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotLineU64Ptr(ReadOnlySpan<char> labelId, ref ulong xs, ref ulong ys, ref ulong zs, int count, ImPlot3DLineFlags flags, int offset, int stride)
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
			fixed (ulong* native_zs = &zs)
			{
				ImPlot3DNative.PlotLineU64Ptr(native_labelId, native_xs, native_ys, native_zs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotTriangleFloatPtr(ReadOnlySpan<char> labelId, ref float xs, ref float ys, ref float zs, int count, ImPlot3DTriangleFlags flags, int offset, int stride)
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
			fixed (float* native_zs = &zs)
			{
				ImPlot3DNative.PlotTriangleFloatPtr(native_labelId, native_xs, native_ys, native_zs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotTriangleDoublePtr(ReadOnlySpan<char> labelId, ref double xs, ref double ys, ref double zs, int count, ImPlot3DTriangleFlags flags, int offset, int stride)
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
			fixed (double* native_zs = &zs)
			{
				ImPlot3DNative.PlotTriangleDoublePtr(native_labelId, native_xs, native_ys, native_zs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotTriangleS8Ptr(ReadOnlySpan<char> labelId, ref sbyte xs, ref sbyte ys, ref sbyte zs, int count, ImPlot3DTriangleFlags flags, int offset, int stride)
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
			fixed (sbyte* native_zs = &zs)
			{
				ImPlot3DNative.PlotTriangleS8Ptr(native_labelId, native_xs, native_ys, native_zs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotTriangleU8Ptr(ReadOnlySpan<char> labelId, ReadOnlySpan<char> xs, ReadOnlySpan<char> ys, ReadOnlySpan<char> zs, int count, ImPlot3DTriangleFlags flags, int offset, int stride)
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

			// Marshaling zs to native string
			byte* native_zs;
			var byteCount_zs = 0;
			if (zs != null)
			{
				byteCount_zs = Encoding.UTF8.GetByteCount(zs);
				if(byteCount_zs > Utils.MaxStackallocSize)
				{
					native_zs = Utils.Alloc<byte>(byteCount_zs + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_zs + 1];
					native_zs = stackallocBytes;
				}
				var zs_offset = Utils.EncodeStringUTF8(zs, native_zs, byteCount_zs);
				native_zs[zs_offset] = 0;
			}
			else native_zs = null;

			ImPlot3DNative.PlotTriangleU8Ptr(native_labelId, native_xs, native_ys, native_zs, count, flags, offset, stride);
			// Freeing labelId native string
			if (byteCount_labelId > Utils.MaxStackallocSize)
				Utils.Free(native_labelId);
			// Freeing xs native string
			if (byteCount_xs > Utils.MaxStackallocSize)
				Utils.Free(native_xs);
			// Freeing ys native string
			if (byteCount_ys > Utils.MaxStackallocSize)
				Utils.Free(native_ys);
			// Freeing zs native string
			if (byteCount_zs > Utils.MaxStackallocSize)
				Utils.Free(native_zs);
		}

		public static void PlotTriangleS16Ptr(ReadOnlySpan<char> labelId, ref short xs, ref short ys, ref short zs, int count, ImPlot3DTriangleFlags flags, int offset, int stride)
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
			fixed (short* native_zs = &zs)
			{
				ImPlot3DNative.PlotTriangleS16Ptr(native_labelId, native_xs, native_ys, native_zs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotTriangleU16Ptr(ReadOnlySpan<char> labelId, ref ushort xs, ref ushort ys, ref ushort zs, int count, ImPlot3DTriangleFlags flags, int offset, int stride)
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
			fixed (ushort* native_zs = &zs)
			{
				ImPlot3DNative.PlotTriangleU16Ptr(native_labelId, native_xs, native_ys, native_zs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotTriangleS32Ptr(ReadOnlySpan<char> labelId, ref int xs, ref int ys, ref int zs, int count, ImPlot3DTriangleFlags flags, int offset, int stride)
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
			fixed (int* native_zs = &zs)
			{
				ImPlot3DNative.PlotTriangleS32Ptr(native_labelId, native_xs, native_ys, native_zs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotTriangleU32Ptr(ReadOnlySpan<char> labelId, ref uint xs, ref uint ys, ref uint zs, int count, ImPlot3DTriangleFlags flags, int offset, int stride)
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
			fixed (uint* native_zs = &zs)
			{
				ImPlot3DNative.PlotTriangleU32Ptr(native_labelId, native_xs, native_ys, native_zs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotTriangleS64Ptr(ReadOnlySpan<char> labelId, ref long xs, ref long ys, ref long zs, int count, ImPlot3DTriangleFlags flags, int offset, int stride)
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
			fixed (long* native_zs = &zs)
			{
				ImPlot3DNative.PlotTriangleS64Ptr(native_labelId, native_xs, native_ys, native_zs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotTriangleU64Ptr(ReadOnlySpan<char> labelId, ref ulong xs, ref ulong ys, ref ulong zs, int count, ImPlot3DTriangleFlags flags, int offset, int stride)
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
			fixed (ulong* native_zs = &zs)
			{
				ImPlot3DNative.PlotTriangleU64Ptr(native_labelId, native_xs, native_ys, native_zs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotQuadFloatPtr(ReadOnlySpan<char> labelId, ref float xs, ref float ys, ref float zs, int count, ImPlot3DQuadFlags flags, int offset, int stride)
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
			fixed (float* native_zs = &zs)
			{
				ImPlot3DNative.PlotQuadFloatPtr(native_labelId, native_xs, native_ys, native_zs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotQuadDoublePtr(ReadOnlySpan<char> labelId, ref double xs, ref double ys, ref double zs, int count, ImPlot3DQuadFlags flags, int offset, int stride)
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
			fixed (double* native_zs = &zs)
			{
				ImPlot3DNative.PlotQuadDoublePtr(native_labelId, native_xs, native_ys, native_zs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotQuadS8Ptr(ReadOnlySpan<char> labelId, ref sbyte xs, ref sbyte ys, ref sbyte zs, int count, ImPlot3DQuadFlags flags, int offset, int stride)
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
			fixed (sbyte* native_zs = &zs)
			{
				ImPlot3DNative.PlotQuadS8Ptr(native_labelId, native_xs, native_ys, native_zs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotQuadU8Ptr(ReadOnlySpan<char> labelId, ReadOnlySpan<char> xs, ReadOnlySpan<char> ys, ReadOnlySpan<char> zs, int count, ImPlot3DQuadFlags flags, int offset, int stride)
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

			// Marshaling zs to native string
			byte* native_zs;
			var byteCount_zs = 0;
			if (zs != null)
			{
				byteCount_zs = Encoding.UTF8.GetByteCount(zs);
				if(byteCount_zs > Utils.MaxStackallocSize)
				{
					native_zs = Utils.Alloc<byte>(byteCount_zs + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_zs + 1];
					native_zs = stackallocBytes;
				}
				var zs_offset = Utils.EncodeStringUTF8(zs, native_zs, byteCount_zs);
				native_zs[zs_offset] = 0;
			}
			else native_zs = null;

			ImPlot3DNative.PlotQuadU8Ptr(native_labelId, native_xs, native_ys, native_zs, count, flags, offset, stride);
			// Freeing labelId native string
			if (byteCount_labelId > Utils.MaxStackallocSize)
				Utils.Free(native_labelId);
			// Freeing xs native string
			if (byteCount_xs > Utils.MaxStackallocSize)
				Utils.Free(native_xs);
			// Freeing ys native string
			if (byteCount_ys > Utils.MaxStackallocSize)
				Utils.Free(native_ys);
			// Freeing zs native string
			if (byteCount_zs > Utils.MaxStackallocSize)
				Utils.Free(native_zs);
		}

		public static void PlotQuadS16Ptr(ReadOnlySpan<char> labelId, ref short xs, ref short ys, ref short zs, int count, ImPlot3DQuadFlags flags, int offset, int stride)
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
			fixed (short* native_zs = &zs)
			{
				ImPlot3DNative.PlotQuadS16Ptr(native_labelId, native_xs, native_ys, native_zs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotQuadU16Ptr(ReadOnlySpan<char> labelId, ref ushort xs, ref ushort ys, ref ushort zs, int count, ImPlot3DQuadFlags flags, int offset, int stride)
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
			fixed (ushort* native_zs = &zs)
			{
				ImPlot3DNative.PlotQuadU16Ptr(native_labelId, native_xs, native_ys, native_zs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotQuadS32Ptr(ReadOnlySpan<char> labelId, ref int xs, ref int ys, ref int zs, int count, ImPlot3DQuadFlags flags, int offset, int stride)
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
			fixed (int* native_zs = &zs)
			{
				ImPlot3DNative.PlotQuadS32Ptr(native_labelId, native_xs, native_ys, native_zs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotQuadU32Ptr(ReadOnlySpan<char> labelId, ref uint xs, ref uint ys, ref uint zs, int count, ImPlot3DQuadFlags flags, int offset, int stride)
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
			fixed (uint* native_zs = &zs)
			{
				ImPlot3DNative.PlotQuadU32Ptr(native_labelId, native_xs, native_ys, native_zs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotQuadS64Ptr(ReadOnlySpan<char> labelId, ref long xs, ref long ys, ref long zs, int count, ImPlot3DQuadFlags flags, int offset, int stride)
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
			fixed (long* native_zs = &zs)
			{
				ImPlot3DNative.PlotQuadS64Ptr(native_labelId, native_xs, native_ys, native_zs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotQuadU64Ptr(ReadOnlySpan<char> labelId, ref ulong xs, ref ulong ys, ref ulong zs, int count, ImPlot3DQuadFlags flags, int offset, int stride)
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
			fixed (ulong* native_zs = &zs)
			{
				ImPlot3DNative.PlotQuadU64Ptr(native_labelId, native_xs, native_ys, native_zs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotSurfaceFloatPtr(ReadOnlySpan<char> labelId, ref float xs, ref float ys, ref float zs, int xCount, int yCount, double scaleMin, double scaleMax, ImPlot3DSurfaceFlags flags, int offset, int stride)
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
			fixed (float* native_zs = &zs)
			{
				ImPlot3DNative.PlotSurfaceFloatPtr(native_labelId, native_xs, native_ys, native_zs, xCount, yCount, scaleMin, scaleMax, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotSurfaceDoublePtr(ReadOnlySpan<char> labelId, ref double xs, ref double ys, ref double zs, int xCount, int yCount, double scaleMin, double scaleMax, ImPlot3DSurfaceFlags flags, int offset, int stride)
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
			fixed (double* native_zs = &zs)
			{
				ImPlot3DNative.PlotSurfaceDoublePtr(native_labelId, native_xs, native_ys, native_zs, xCount, yCount, scaleMin, scaleMax, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotSurfaceS8Ptr(ReadOnlySpan<char> labelId, ref sbyte xs, ref sbyte ys, ref sbyte zs, int xCount, int yCount, double scaleMin, double scaleMax, ImPlot3DSurfaceFlags flags, int offset, int stride)
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
			fixed (sbyte* native_zs = &zs)
			{
				ImPlot3DNative.PlotSurfaceS8Ptr(native_labelId, native_xs, native_ys, native_zs, xCount, yCount, scaleMin, scaleMax, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotSurfaceU8Ptr(ReadOnlySpan<char> labelId, ReadOnlySpan<char> xs, ReadOnlySpan<char> ys, ReadOnlySpan<char> zs, int xCount, int yCount, double scaleMin, double scaleMax, ImPlot3DSurfaceFlags flags, int offset, int stride)
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

			// Marshaling zs to native string
			byte* native_zs;
			var byteCount_zs = 0;
			if (zs != null)
			{
				byteCount_zs = Encoding.UTF8.GetByteCount(zs);
				if(byteCount_zs > Utils.MaxStackallocSize)
				{
					native_zs = Utils.Alloc<byte>(byteCount_zs + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_zs + 1];
					native_zs = stackallocBytes;
				}
				var zs_offset = Utils.EncodeStringUTF8(zs, native_zs, byteCount_zs);
				native_zs[zs_offset] = 0;
			}
			else native_zs = null;

			ImPlot3DNative.PlotSurfaceU8Ptr(native_labelId, native_xs, native_ys, native_zs, xCount, yCount, scaleMin, scaleMax, flags, offset, stride);
			// Freeing labelId native string
			if (byteCount_labelId > Utils.MaxStackallocSize)
				Utils.Free(native_labelId);
			// Freeing xs native string
			if (byteCount_xs > Utils.MaxStackallocSize)
				Utils.Free(native_xs);
			// Freeing ys native string
			if (byteCount_ys > Utils.MaxStackallocSize)
				Utils.Free(native_ys);
			// Freeing zs native string
			if (byteCount_zs > Utils.MaxStackallocSize)
				Utils.Free(native_zs);
		}

		public static void PlotSurfaceS16Ptr(ReadOnlySpan<char> labelId, ref short xs, ref short ys, ref short zs, int xCount, int yCount, double scaleMin, double scaleMax, ImPlot3DSurfaceFlags flags, int offset, int stride)
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
			fixed (short* native_zs = &zs)
			{
				ImPlot3DNative.PlotSurfaceS16Ptr(native_labelId, native_xs, native_ys, native_zs, xCount, yCount, scaleMin, scaleMax, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotSurfaceU16Ptr(ReadOnlySpan<char> labelId, ref ushort xs, ref ushort ys, ref ushort zs, int xCount, int yCount, double scaleMin, double scaleMax, ImPlot3DSurfaceFlags flags, int offset, int stride)
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
			fixed (ushort* native_zs = &zs)
			{
				ImPlot3DNative.PlotSurfaceU16Ptr(native_labelId, native_xs, native_ys, native_zs, xCount, yCount, scaleMin, scaleMax, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotSurfaceS32Ptr(ReadOnlySpan<char> labelId, ref int xs, ref int ys, ref int zs, int xCount, int yCount, double scaleMin, double scaleMax, ImPlot3DSurfaceFlags flags, int offset, int stride)
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
			fixed (int* native_zs = &zs)
			{
				ImPlot3DNative.PlotSurfaceS32Ptr(native_labelId, native_xs, native_ys, native_zs, xCount, yCount, scaleMin, scaleMax, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotSurfaceU32Ptr(ReadOnlySpan<char> labelId, ref uint xs, ref uint ys, ref uint zs, int xCount, int yCount, double scaleMin, double scaleMax, ImPlot3DSurfaceFlags flags, int offset, int stride)
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
			fixed (uint* native_zs = &zs)
			{
				ImPlot3DNative.PlotSurfaceU32Ptr(native_labelId, native_xs, native_ys, native_zs, xCount, yCount, scaleMin, scaleMax, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotSurfaceS64Ptr(ReadOnlySpan<char> labelId, ref long xs, ref long ys, ref long zs, int xCount, int yCount, double scaleMin, double scaleMax, ImPlot3DSurfaceFlags flags, int offset, int stride)
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
			fixed (long* native_zs = &zs)
			{
				ImPlot3DNative.PlotSurfaceS64Ptr(native_labelId, native_xs, native_ys, native_zs, xCount, yCount, scaleMin, scaleMax, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotSurfaceU64Ptr(ReadOnlySpan<char> labelId, ref ulong xs, ref ulong ys, ref ulong zs, int xCount, int yCount, double scaleMin, double scaleMax, ImPlot3DSurfaceFlags flags, int offset, int stride)
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
			fixed (ulong* native_zs = &zs)
			{
				ImPlot3DNative.PlotSurfaceU64Ptr(native_labelId, native_xs, native_ys, native_zs, xCount, yCount, scaleMin, scaleMax, flags, offset, stride);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotMesh(ReadOnlySpan<char> labelId, ImPlot3DPointPtr vtx, ref uint idx, int vtxCount, int idxCount, ImPlot3DMeshFlags flags)
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

			fixed (uint* native_idx = &idx)
			{
				ImPlot3DNative.PlotMesh(native_labelId, vtx, native_idx, vtxCount, idxCount, flags);
				// Freeing labelId native string
				if (byteCount_labelId > Utils.MaxStackallocSize)
					Utils.Free(native_labelId);
			}
		}

		public static void PlotText(ReadOnlySpan<char> text, float x, float y, float z, float angle, Vector2 pixOffset)
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

			ImPlot3DNative.PlotText(native_text, x, y, z, angle, pixOffset);
			// Freeing text native string
			if (byteCount_text > Utils.MaxStackallocSize)
				Utils.Free(native_text);
		}

		public static void PlotToPixelsPlot3DPoInt(ref Vector2 pOut, ImPlot3DPoint point)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImPlot3DNative.PlotToPixelsPlot3DPoInt(native_pOut, point);
			}
		}

		public static void PlotToPixelsDouble(ref Vector2 pOut, double x, double y, double z)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImPlot3DNative.PlotToPixelsDouble(native_pOut, x, y, z);
			}
		}

		public static ImPlot3DRay PixelsToPlotRayVec2(Vector2 pix)
		{
			return ImPlot3DNative.PixelsToPlotRayVec2(pix);
		}

		public static ImPlot3DRay PixelsToPlotRayDouble(double x, double y)
		{
			return ImPlot3DNative.PixelsToPlotRayDouble(x, y);
		}

		public static void PixelsToPlotPlaneVec2(ImPlot3DPointPtr pOut, Vector2 pix, ImPlane3D plane, bool mask)
		{
			var native_mask = mask ? (byte)1 : (byte)0;
			ImPlot3DNative.PixelsToPlotPlaneVec2(pOut, pix, plane, native_mask);
		}

		public static void PixelsToPlotPlaneDouble(ImPlot3DPointPtr pOut, double x, double y, ImPlane3D plane, bool mask)
		{
			var native_mask = mask ? (byte)1 : (byte)0;
			ImPlot3DNative.PixelsToPlotPlaneDouble(pOut, x, y, plane, native_mask);
		}

		/// <summary>
		/// Get the current plot position (top-left) in pixels<br/>
		/// </summary>
		public static void GetPlotPos(ref Vector2 pOut)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImPlot3DNative.GetPlotPos(native_pOut);
			}
		}

		/// <summary>
		/// Get the current plot size in pixels<br/>
		/// </summary>
		public static void GetPlotSize(ref Vector2 pOut)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImPlot3DNative.GetPlotSize(native_pOut);
			}
		}

		public static ImDrawListPtr GetPlotDrawList()
		{
			return ImPlot3DNative.GetPlotDrawList();
		}

		public static ImPlot3DStylePtr GetStyle()
		{
			return ImPlot3DNative.GetStyle();
		}

		/// <summary>
		/// Set colors with ImGui style<br/>
		/// </summary>
		public static void StyleColorsAuto(ImPlot3DStylePtr dst)
		{
			ImPlot3DNative.StyleColorsAuto(dst);
		}

		/// <summary>
		/// Set colors with dark style<br/>
		/// </summary>
		public static void StyleColorsDark(ImPlot3DStylePtr dst)
		{
			ImPlot3DNative.StyleColorsDark(dst);
		}

		/// <summary>
		/// Set colors with light style<br/>
		/// </summary>
		public static void StyleColorsLight(ImPlot3DStylePtr dst)
		{
			ImPlot3DNative.StyleColorsLight(dst);
		}

		/// <summary>
		/// Set colors with classic style<br/>
		/// </summary>
		public static void StyleColorsClassic(ImPlot3DStylePtr dst)
		{
			ImPlot3DNative.StyleColorsClassic(dst);
		}

		public static void PushStyleColorU32(ImPlot3DCol idx, uint col)
		{
			ImPlot3DNative.PushStyleColorU32(idx, col);
		}

		public static void PushStyleColorVec4(ImPlot3DCol idx, Vector4 col)
		{
			ImPlot3DNative.PushStyleColorVec4(idx, col);
		}

		public static void PopStyleColor(int count)
		{
			ImPlot3DNative.PopStyleColor(count);
		}

		public static void PushStyleVarFloat(ImPlot3DStyleVar idx, float val)
		{
			ImPlot3DNative.PushStyleVarFloat(idx, val);
		}

		public static void PushStyleVarInt(ImPlot3DStyleVar idx, int val)
		{
			ImPlot3DNative.PushStyleVarInt(idx, val);
		}

		public static void PushStyleVarVec2(ImPlot3DStyleVar idx, Vector2 val)
		{
			ImPlot3DNative.PushStyleVarVec2(idx, val);
		}

		public static void PopStyleVar(int count)
		{
			ImPlot3DNative.PopStyleVar(count);
		}

		public static void SetNextLineStyle(Vector4 col, float weight)
		{
			ImPlot3DNative.SetNextLineStyle(col, weight);
		}

		public static void SetNextFillStyle(Vector4 col, float alphaMod)
		{
			ImPlot3DNative.SetNextFillStyle(col, alphaMod);
		}

		public static void SetNextMarkerStyle(ImPlot3DMarker marker, float size, Vector4 fill, float weight, Vector4 outline)
		{
			ImPlot3DNative.SetNextMarkerStyle(marker, size, fill, weight, outline);
		}

		public static void GetStyleColorVec4(ref Vector4 pOut, ImPlot3DCol idx)
		{
			fixed (Vector4* native_pOut = &pOut)
			{
				ImPlot3DNative.GetStyleColorVec4(native_pOut, idx);
			}
		}

		public static uint GetStyleColorU32(ImPlot3DCol idx)
		{
			return ImPlot3DNative.GetStyleColorU32(idx);
		}

		public static ImPlot3DColormap AddColormapVec4Ptr(ReadOnlySpan<char> name, ref Vector4 cols, int size, bool qual)
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
				var result = ImPlot3DNative.AddColormapVec4Ptr(native_name, native_cols, size, native_qual);
				// Freeing name native string
				if (byteCount_name > Utils.MaxStackallocSize)
					Utils.Free(native_name);
				return result;
			}
		}

		public static ImPlot3DColormap AddColormapU32Ptr(ReadOnlySpan<char> name, ref uint cols, int size, bool qual)
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
				var result = ImPlot3DNative.AddColormapU32Ptr(native_name, native_cols, size, native_qual);
				// Freeing name native string
				if (byteCount_name > Utils.MaxStackallocSize)
					Utils.Free(native_name);
				return result;
			}
		}

		public static int GetColormapCount()
		{
			return ImPlot3DNative.GetColormapCount();
		}

		public static ref byte GetColormapName(ImPlot3DColormap cmap)
		{
			var nativeResult = ImPlot3DNative.GetColormapName(cmap);
			return ref *(byte*)&nativeResult;
		}

		public static ImPlot3DColormap GetColormapIndex(ReadOnlySpan<char> name)
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

			return ImPlot3DNative.GetColormapIndex(native_name);
			// Freeing name native string
			if (byteCount_name > Utils.MaxStackallocSize)
				Utils.Free(native_name);
		}

		public static void PushColormapPlot3DColormap(ImPlot3DColormap cmap)
		{
			ImPlot3DNative.PushColormapPlot3DColormap(cmap);
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

			ImPlot3DNative.PushColormapStr(native_name);
			// Freeing name native string
			if (byteCount_name > Utils.MaxStackallocSize)
				Utils.Free(native_name);
		}

		public static void PopColormap(int count)
		{
			ImPlot3DNative.PopColormap(count);
		}

		public static void NextColormapColor(ref Vector4 pOut)
		{
			fixed (Vector4* native_pOut = &pOut)
			{
				ImPlot3DNative.NextColormapColor(native_pOut);
			}
		}

		public static int GetColormapSize(ImPlot3DColormap cmap)
		{
			return ImPlot3DNative.GetColormapSize(cmap);
		}

		public static void GetColormapColor(ref Vector4 pOut, int idx, ImPlot3DColormap cmap)
		{
			fixed (Vector4* native_pOut = &pOut)
			{
				ImPlot3DNative.GetColormapColor(native_pOut, idx, cmap);
			}
		}

		public static void SampleColormap(ref Vector4 pOut, float t, ImPlot3DColormap cmap)
		{
			fixed (Vector4* native_pOut = &pOut)
			{
				ImPlot3DNative.SampleColormap(native_pOut, t, cmap);
			}
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

			ImPlot3DNative.ShowDemoWindow(native_pOpen);
			// Freeing pOpen native string
			if (byteCount_pOpen > Utils.MaxStackallocSize)
				Utils.Free(native_pOpen);
		}

		public static void ShowStyleEditor(ImPlot3DStylePtr _ref)
		{
			ImPlot3DNative.ShowStyleEditor(_ref);
		}

	}
}
