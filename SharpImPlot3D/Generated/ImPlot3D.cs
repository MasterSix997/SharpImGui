using SharpImGui;
using System;
using UnityEngine;
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

		public static void DestroyContext()
		{
			// defining omitted parameters
			ImPlot3DContext* ctx = null;
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

		public static bool BeginPlot(ReadOnlySpan<byte> titleId, Vector2 size, ImPlot3DFlags flags)
		{
			fixed (byte* nativeTitleId = titleId)
			{
				var result = ImPlot3DNative.BeginPlot(nativeTitleId, size, flags);
				return result != 0;
			}
		}

		public static bool BeginPlot(ReadOnlySpan<char> titleId, Vector2 size, ImPlot3DFlags flags)
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

			var result = ImPlot3DNative.BeginPlot(nativeTitleId, size, flags);
			// Freeing titleId native string
			if (byteCountTitleId > Utils.MaxStackallocSize)
				Utils.Free(nativeTitleId);
			return result != 0;
		}

		public static bool BeginPlot(ReadOnlySpan<byte> titleId, Vector2 size)
		{
			// defining omitted parameters
			ImPlot3DFlags flags = ImPlot3DFlags.None;
			fixed (byte* nativeTitleId = titleId)
			{
				var result = ImPlot3DNative.BeginPlot(nativeTitleId, size, flags);
				return result != 0;
			}
		}

		public static bool BeginPlot(ReadOnlySpan<char> titleId, Vector2 size)
		{
			// defining omitted parameters
			ImPlot3DFlags flags = ImPlot3DFlags.None;
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

			var result = ImPlot3DNative.BeginPlot(nativeTitleId, size, flags);
			// Freeing titleId native string
			if (byteCountTitleId > Utils.MaxStackallocSize)
				Utils.Free(nativeTitleId);
			return result != 0;
		}

		public static bool BeginPlot(ReadOnlySpan<byte> titleId)
		{
			// defining omitted parameters
			ImPlot3DFlags flags = ImPlot3DFlags.None;
			Vector2 size = new Vector2(-1,0);
			fixed (byte* nativeTitleId = titleId)
			{
				var result = ImPlot3DNative.BeginPlot(nativeTitleId, size, flags);
				return result != 0;
			}
		}

		public static bool BeginPlot(ReadOnlySpan<char> titleId)
		{
			// defining omitted parameters
			ImPlot3DFlags flags = ImPlot3DFlags.None;
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

			var result = ImPlot3DNative.BeginPlot(nativeTitleId, size, flags);
			// Freeing titleId native string
			if (byteCountTitleId > Utils.MaxStackallocSize)
				Utils.Free(nativeTitleId);
			return result != 0;
		}

		/// <summary>
		/// Only call if BeginPlot() returns true!<br/>
		/// </summary>
		public static void EndPlot()
		{
			ImPlot3DNative.EndPlot();
		}

		public static void SetupAxis(ImAxis3D axis, ReadOnlySpan<byte> label, ImPlot3DAxisFlags flags)
		{
			fixed (byte* nativeLabel = label)
			{
				ImPlot3DNative.SetupAxis(axis, nativeLabel, flags);
			}
		}

		public static void SetupAxis(ImAxis3D axis, ReadOnlySpan<char> label, ImPlot3DAxisFlags flags)
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

			ImPlot3DNative.SetupAxis(axis, nativeLabel, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
		}

		public static void SetupAxis(ImAxis3D axis, ReadOnlySpan<byte> label)
		{
			// defining omitted parameters
			ImPlot3DAxisFlags flags = ImPlot3DAxisFlags.None;
			fixed (byte* nativeLabel = label)
			{
				ImPlot3DNative.SetupAxis(axis, nativeLabel, flags);
			}
		}

		public static void SetupAxis(ImAxis3D axis, ReadOnlySpan<char> label)
		{
			// defining omitted parameters
			ImPlot3DAxisFlags flags = ImPlot3DAxisFlags.None;
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

			ImPlot3DNative.SetupAxis(axis, nativeLabel, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
		}

		public static void SetupAxis(ImAxis3D axis)
		{
			// defining omitted parameters
			ImPlot3DAxisFlags flags = ImPlot3DAxisFlags.None;
			byte* label = null;
			ImPlot3DNative.SetupAxis(axis, label, flags);
		}

		public static void SetupAxisLimits(ImAxis3D axis, double vMin, double vMax, ImPlot3DCond cond)
		{
			ImPlot3DNative.SetupAxisLimits(axis, vMin, vMax, cond);
		}

		public static void SetupAxisLimits(ImAxis3D axis, double vMin, double vMax)
		{
			// defining omitted parameters
			ImPlot3DCond cond = ImPlot3DCond.Once;
			ImPlot3DNative.SetupAxisLimits(axis, vMin, vMax, cond);
		}

		public static void SetupAxisFormat(ImAxis3D idx, ImPlot3DFormatter formatter, IntPtr data)
		{
			ImPlot3DNative.SetupAxisFormat(idx, formatter, (void*)data);
		}

		public static void SetupAxisFormat(ImAxis3D idx, ImPlot3DFormatter formatter)
		{
			// defining omitted parameters
			void* data = null;
			ImPlot3DNative.SetupAxisFormat(idx, formatter, data);
		}

		public static void SetupAxisTicksDoublePtr(ImAxis3D axis, double[] values, int nTicks, ref byte* labels, bool keepDefault)
		{
			var native_keepDefault = keepDefault ? (byte)1 : (byte)0;
			fixed (double* nativeValues = values)
			fixed (byte** nativeLabels = &labels)
			{
				ImPlot3DNative.SetupAxisTicksDoublePtr(axis, nativeValues, nTicks, nativeLabels, native_keepDefault);
			}
		}

		public static void SetupAxisTicksDouble(ImAxis3D axis, double vMin, double vMax, int nTicks, ref byte* labels, bool keepDefault)
		{
			var native_keepDefault = keepDefault ? (byte)1 : (byte)0;
			fixed (byte** nativeLabels = &labels)
			{
				ImPlot3DNative.SetupAxisTicksDouble(axis, vMin, vMax, nTicks, nativeLabels, native_keepDefault);
			}
		}

		public static void SetupAxes(ReadOnlySpan<byte> xLabel, ReadOnlySpan<byte> yLabel, ReadOnlySpan<byte> zLabel, ImPlot3DAxisFlags xFlags, ImPlot3DAxisFlags yFlags, ImPlot3DAxisFlags zFlags)
		{
			fixed (byte* nativeXLabel = xLabel)
			fixed (byte* nativeYLabel = yLabel)
			fixed (byte* nativeZLabel = zLabel)
			{
				ImPlot3DNative.SetupAxes(nativeXLabel, nativeYLabel, nativeZLabel, xFlags, yFlags, zFlags);
			}
		}

		public static void SetupAxes(ReadOnlySpan<char> xLabel, ReadOnlySpan<char> yLabel, ReadOnlySpan<char> zLabel, ImPlot3DAxisFlags xFlags, ImPlot3DAxisFlags yFlags, ImPlot3DAxisFlags zFlags)
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

			// Marshaling zLabel to native string
			byte* nativeZLabel;
			var byteCountZLabel = 0;
			if (zLabel != null && !zLabel.IsEmpty)
			{
				byteCountZLabel = Encoding.UTF8.GetByteCount(zLabel);
				if(byteCountZLabel > Utils.MaxStackallocSize)
				{
					nativeZLabel = Utils.Alloc<byte>(byteCountZLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountZLabel + 1];
					nativeZLabel = stackallocBytes;
				}
				var offsetZLabel = Utils.EncodeStringUTF8(zLabel, nativeZLabel, byteCountZLabel);
				nativeZLabel[offsetZLabel] = 0;
			}
			else nativeZLabel = null;

			ImPlot3DNative.SetupAxes(nativeXLabel, nativeYLabel, nativeZLabel, xFlags, yFlags, zFlags);
			// Freeing xLabel native string
			if (byteCountXLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeXLabel);
			// Freeing yLabel native string
			if (byteCountYLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeYLabel);
			// Freeing zLabel native string
			if (byteCountZLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeZLabel);
		}

		public static void SetupAxes(ReadOnlySpan<byte> xLabel, ReadOnlySpan<byte> yLabel, ReadOnlySpan<byte> zLabel, ImPlot3DAxisFlags xFlags, ImPlot3DAxisFlags yFlags)
		{
			// defining omitted parameters
			ImPlot3DAxisFlags zFlags = ImPlot3DAxisFlags.None;
			fixed (byte* nativeXLabel = xLabel)
			fixed (byte* nativeYLabel = yLabel)
			fixed (byte* nativeZLabel = zLabel)
			{
				ImPlot3DNative.SetupAxes(nativeXLabel, nativeYLabel, nativeZLabel, xFlags, yFlags, zFlags);
			}
		}

		public static void SetupAxes(ReadOnlySpan<char> xLabel, ReadOnlySpan<char> yLabel, ReadOnlySpan<char> zLabel, ImPlot3DAxisFlags xFlags, ImPlot3DAxisFlags yFlags)
		{
			// defining omitted parameters
			ImPlot3DAxisFlags zFlags = ImPlot3DAxisFlags.None;
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

			// Marshaling zLabel to native string
			byte* nativeZLabel;
			var byteCountZLabel = 0;
			if (zLabel != null && !zLabel.IsEmpty)
			{
				byteCountZLabel = Encoding.UTF8.GetByteCount(zLabel);
				if(byteCountZLabel > Utils.MaxStackallocSize)
				{
					nativeZLabel = Utils.Alloc<byte>(byteCountZLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountZLabel + 1];
					nativeZLabel = stackallocBytes;
				}
				var offsetZLabel = Utils.EncodeStringUTF8(zLabel, nativeZLabel, byteCountZLabel);
				nativeZLabel[offsetZLabel] = 0;
			}
			else nativeZLabel = null;

			ImPlot3DNative.SetupAxes(nativeXLabel, nativeYLabel, nativeZLabel, xFlags, yFlags, zFlags);
			// Freeing xLabel native string
			if (byteCountXLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeXLabel);
			// Freeing yLabel native string
			if (byteCountYLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeYLabel);
			// Freeing zLabel native string
			if (byteCountZLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeZLabel);
		}

		public static void SetupAxes(ReadOnlySpan<byte> xLabel, ReadOnlySpan<byte> yLabel, ReadOnlySpan<byte> zLabel, ImPlot3DAxisFlags xFlags)
		{
			// defining omitted parameters
			ImPlot3DAxisFlags zFlags = ImPlot3DAxisFlags.None;
			ImPlot3DAxisFlags yFlags = ImPlot3DAxisFlags.None;
			fixed (byte* nativeXLabel = xLabel)
			fixed (byte* nativeYLabel = yLabel)
			fixed (byte* nativeZLabel = zLabel)
			{
				ImPlot3DNative.SetupAxes(nativeXLabel, nativeYLabel, nativeZLabel, xFlags, yFlags, zFlags);
			}
		}

		public static void SetupAxes(ReadOnlySpan<char> xLabel, ReadOnlySpan<char> yLabel, ReadOnlySpan<char> zLabel, ImPlot3DAxisFlags xFlags)
		{
			// defining omitted parameters
			ImPlot3DAxisFlags zFlags = ImPlot3DAxisFlags.None;
			ImPlot3DAxisFlags yFlags = ImPlot3DAxisFlags.None;
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

			// Marshaling zLabel to native string
			byte* nativeZLabel;
			var byteCountZLabel = 0;
			if (zLabel != null && !zLabel.IsEmpty)
			{
				byteCountZLabel = Encoding.UTF8.GetByteCount(zLabel);
				if(byteCountZLabel > Utils.MaxStackallocSize)
				{
					nativeZLabel = Utils.Alloc<byte>(byteCountZLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountZLabel + 1];
					nativeZLabel = stackallocBytes;
				}
				var offsetZLabel = Utils.EncodeStringUTF8(zLabel, nativeZLabel, byteCountZLabel);
				nativeZLabel[offsetZLabel] = 0;
			}
			else nativeZLabel = null;

			ImPlot3DNative.SetupAxes(nativeXLabel, nativeYLabel, nativeZLabel, xFlags, yFlags, zFlags);
			// Freeing xLabel native string
			if (byteCountXLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeXLabel);
			// Freeing yLabel native string
			if (byteCountYLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeYLabel);
			// Freeing zLabel native string
			if (byteCountZLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeZLabel);
		}

		public static void SetupAxes(ReadOnlySpan<byte> xLabel, ReadOnlySpan<byte> yLabel, ReadOnlySpan<byte> zLabel)
		{
			// defining omitted parameters
			ImPlot3DAxisFlags zFlags = ImPlot3DAxisFlags.None;
			ImPlot3DAxisFlags yFlags = ImPlot3DAxisFlags.None;
			ImPlot3DAxisFlags xFlags = ImPlot3DAxisFlags.None;
			fixed (byte* nativeXLabel = xLabel)
			fixed (byte* nativeYLabel = yLabel)
			fixed (byte* nativeZLabel = zLabel)
			{
				ImPlot3DNative.SetupAxes(nativeXLabel, nativeYLabel, nativeZLabel, xFlags, yFlags, zFlags);
			}
		}

		public static void SetupAxes(ReadOnlySpan<char> xLabel, ReadOnlySpan<char> yLabel, ReadOnlySpan<char> zLabel)
		{
			// defining omitted parameters
			ImPlot3DAxisFlags zFlags = ImPlot3DAxisFlags.None;
			ImPlot3DAxisFlags yFlags = ImPlot3DAxisFlags.None;
			ImPlot3DAxisFlags xFlags = ImPlot3DAxisFlags.None;
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

			// Marshaling zLabel to native string
			byte* nativeZLabel;
			var byteCountZLabel = 0;
			if (zLabel != null && !zLabel.IsEmpty)
			{
				byteCountZLabel = Encoding.UTF8.GetByteCount(zLabel);
				if(byteCountZLabel > Utils.MaxStackallocSize)
				{
					nativeZLabel = Utils.Alloc<byte>(byteCountZLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountZLabel + 1];
					nativeZLabel = stackallocBytes;
				}
				var offsetZLabel = Utils.EncodeStringUTF8(zLabel, nativeZLabel, byteCountZLabel);
				nativeZLabel[offsetZLabel] = 0;
			}
			else nativeZLabel = null;

			ImPlot3DNative.SetupAxes(nativeXLabel, nativeYLabel, nativeZLabel, xFlags, yFlags, zFlags);
			// Freeing xLabel native string
			if (byteCountXLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeXLabel);
			// Freeing yLabel native string
			if (byteCountYLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeYLabel);
			// Freeing zLabel native string
			if (byteCountZLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeZLabel);
		}

		public static void SetupAxesLimits(double xMin, double xMax, double yMin, double yMax, double zMin, double zMax, ImPlot3DCond cond)
		{
			ImPlot3DNative.SetupAxesLimits(xMin, xMax, yMin, yMax, zMin, zMax, cond);
		}

		public static void SetupAxesLimits(double xMin, double xMax, double yMin, double yMax, double zMin, double zMax)
		{
			// defining omitted parameters
			ImPlot3DCond cond = ImPlot3DCond.Once;
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

		public static void SetupLegend(ImPlot3DLocation location)
		{
			// defining omitted parameters
			ImPlot3DLegendFlags flags = ImPlot3DLegendFlags.None;
			ImPlot3DNative.SetupLegend(location, flags);
		}

		public static void PlotScatterFloatPtr(ReadOnlySpan<byte> labelId, float[] xs, float[] ys, float[] zs, int count, ImPlot3DScatterFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (float* nativeXs = xs)
			fixed (float* nativeYs = ys)
			fixed (float* nativeZs = zs)
			{
				ImPlot3DNative.PlotScatterFloatPtr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
			}
		}

		public static void PlotScatterFloatPtr(ReadOnlySpan<char> labelId, float[] xs, float[] ys, float[] zs, int count, ImPlot3DScatterFlags flags, int offset, int stride)
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
			fixed (float* nativeZs = zs)
			{
				ImPlot3DNative.PlotScatterFloatPtr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotScatterDoublePtr(ReadOnlySpan<byte> labelId, double[] xs, double[] ys, double[] zs, int count, ImPlot3DScatterFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (double* nativeXs = xs)
			fixed (double* nativeYs = ys)
			fixed (double* nativeZs = zs)
			{
				ImPlot3DNative.PlotScatterDoublePtr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
			}
		}

		public static void PlotScatterDoublePtr(ReadOnlySpan<char> labelId, double[] xs, double[] ys, double[] zs, int count, ImPlot3DScatterFlags flags, int offset, int stride)
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
			fixed (double* nativeZs = zs)
			{
				ImPlot3DNative.PlotScatterDoublePtr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotScatterS8Ptr(ReadOnlySpan<byte> labelId, sbyte[] xs, sbyte[] ys, sbyte[] zs, int count, ImPlot3DScatterFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (sbyte* nativeXs = xs)
			fixed (sbyte* nativeYs = ys)
			fixed (sbyte* nativeZs = zs)
			{
				ImPlot3DNative.PlotScatterS8Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
			}
		}

		public static void PlotScatterS8Ptr(ReadOnlySpan<char> labelId, sbyte[] xs, sbyte[] ys, sbyte[] zs, int count, ImPlot3DScatterFlags flags, int offset, int stride)
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
			fixed (sbyte* nativeZs = zs)
			{
				ImPlot3DNative.PlotScatterS8Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotScatterU8Ptr(ReadOnlySpan<byte> labelId, byte[] xs, byte[] ys, byte[] zs, int count, ImPlot3DScatterFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (byte* nativeXs = xs)
			fixed (byte* nativeYs = ys)
			fixed (byte* nativeZs = zs)
			{
				ImPlot3DNative.PlotScatterU8Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
			}
		}

		public static void PlotScatterU8Ptr(ReadOnlySpan<char> labelId, byte[] xs, byte[] ys, byte[] zs, int count, ImPlot3DScatterFlags flags, int offset, int stride)
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
			fixed (byte* nativeZs = zs)
			{
				ImPlot3DNative.PlotScatterU8Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotScatterS16Ptr(ReadOnlySpan<byte> labelId, short[] xs, short[] ys, short[] zs, int count, ImPlot3DScatterFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (short* nativeXs = xs)
			fixed (short* nativeYs = ys)
			fixed (short* nativeZs = zs)
			{
				ImPlot3DNative.PlotScatterS16Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
			}
		}

		public static void PlotScatterS16Ptr(ReadOnlySpan<char> labelId, short[] xs, short[] ys, short[] zs, int count, ImPlot3DScatterFlags flags, int offset, int stride)
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
			fixed (short* nativeZs = zs)
			{
				ImPlot3DNative.PlotScatterS16Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotScatterU16Ptr(ReadOnlySpan<byte> labelId, ushort[] xs, ushort[] ys, ushort[] zs, int count, ImPlot3DScatterFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ushort* nativeXs = xs)
			fixed (ushort* nativeYs = ys)
			fixed (ushort* nativeZs = zs)
			{
				ImPlot3DNative.PlotScatterU16Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
			}
		}

		public static void PlotScatterU16Ptr(ReadOnlySpan<char> labelId, ushort[] xs, ushort[] ys, ushort[] zs, int count, ImPlot3DScatterFlags flags, int offset, int stride)
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
			fixed (ushort* nativeZs = zs)
			{
				ImPlot3DNative.PlotScatterU16Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotScatterS32Ptr(ReadOnlySpan<byte> labelId, int[] xs, int[] ys, int[] zs, int count, ImPlot3DScatterFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (int* nativeXs = xs)
			fixed (int* nativeYs = ys)
			fixed (int* nativeZs = zs)
			{
				ImPlot3DNative.PlotScatterS32Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
			}
		}

		public static void PlotScatterS32Ptr(ReadOnlySpan<char> labelId, int[] xs, int[] ys, int[] zs, int count, ImPlot3DScatterFlags flags, int offset, int stride)
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
			fixed (int* nativeZs = zs)
			{
				ImPlot3DNative.PlotScatterS32Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotScatterU32Ptr(ReadOnlySpan<byte> labelId, uint[] xs, uint[] ys, uint[] zs, int count, ImPlot3DScatterFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (uint* nativeXs = xs)
			fixed (uint* nativeYs = ys)
			fixed (uint* nativeZs = zs)
			{
				ImPlot3DNative.PlotScatterU32Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
			}
		}

		public static void PlotScatterU32Ptr(ReadOnlySpan<char> labelId, uint[] xs, uint[] ys, uint[] zs, int count, ImPlot3DScatterFlags flags, int offset, int stride)
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
			fixed (uint* nativeZs = zs)
			{
				ImPlot3DNative.PlotScatterU32Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotScatterS64Ptr(ReadOnlySpan<byte> labelId, long[] xs, long[] ys, long[] zs, int count, ImPlot3DScatterFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (long* nativeXs = xs)
			fixed (long* nativeYs = ys)
			fixed (long* nativeZs = zs)
			{
				ImPlot3DNative.PlotScatterS64Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
			}
		}

		public static void PlotScatterS64Ptr(ReadOnlySpan<char> labelId, long[] xs, long[] ys, long[] zs, int count, ImPlot3DScatterFlags flags, int offset, int stride)
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
			fixed (long* nativeZs = zs)
			{
				ImPlot3DNative.PlotScatterS64Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotScatterU64Ptr(ReadOnlySpan<byte> labelId, ulong[] xs, ulong[] ys, ulong[] zs, int count, ImPlot3DScatterFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ulong* nativeXs = xs)
			fixed (ulong* nativeYs = ys)
			fixed (ulong* nativeZs = zs)
			{
				ImPlot3DNative.PlotScatterU64Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
			}
		}

		public static void PlotScatterU64Ptr(ReadOnlySpan<char> labelId, ulong[] xs, ulong[] ys, ulong[] zs, int count, ImPlot3DScatterFlags flags, int offset, int stride)
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
			fixed (ulong* nativeZs = zs)
			{
				ImPlot3DNative.PlotScatterU64Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotLineFloatPtr(ReadOnlySpan<byte> labelId, float[] xs, float[] ys, float[] zs, int count, ImPlot3DLineFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (float* nativeXs = xs)
			fixed (float* nativeYs = ys)
			fixed (float* nativeZs = zs)
			{
				ImPlot3DNative.PlotLineFloatPtr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
			}
		}

		public static void PlotLineFloatPtr(ReadOnlySpan<char> labelId, float[] xs, float[] ys, float[] zs, int count, ImPlot3DLineFlags flags, int offset, int stride)
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
			fixed (float* nativeZs = zs)
			{
				ImPlot3DNative.PlotLineFloatPtr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotLineDoublePtr(ReadOnlySpan<byte> labelId, double[] xs, double[] ys, double[] zs, int count, ImPlot3DLineFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (double* nativeXs = xs)
			fixed (double* nativeYs = ys)
			fixed (double* nativeZs = zs)
			{
				ImPlot3DNative.PlotLineDoublePtr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
			}
		}

		public static void PlotLineDoublePtr(ReadOnlySpan<char> labelId, double[] xs, double[] ys, double[] zs, int count, ImPlot3DLineFlags flags, int offset, int stride)
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
			fixed (double* nativeZs = zs)
			{
				ImPlot3DNative.PlotLineDoublePtr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotLineS8Ptr(ReadOnlySpan<byte> labelId, sbyte[] xs, sbyte[] ys, sbyte[] zs, int count, ImPlot3DLineFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (sbyte* nativeXs = xs)
			fixed (sbyte* nativeYs = ys)
			fixed (sbyte* nativeZs = zs)
			{
				ImPlot3DNative.PlotLineS8Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
			}
		}

		public static void PlotLineS8Ptr(ReadOnlySpan<char> labelId, sbyte[] xs, sbyte[] ys, sbyte[] zs, int count, ImPlot3DLineFlags flags, int offset, int stride)
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
			fixed (sbyte* nativeZs = zs)
			{
				ImPlot3DNative.PlotLineS8Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotLineU8Ptr(ReadOnlySpan<byte> labelId, byte[] xs, byte[] ys, byte[] zs, int count, ImPlot3DLineFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (byte* nativeXs = xs)
			fixed (byte* nativeYs = ys)
			fixed (byte* nativeZs = zs)
			{
				ImPlot3DNative.PlotLineU8Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
			}
		}

		public static void PlotLineU8Ptr(ReadOnlySpan<char> labelId, byte[] xs, byte[] ys, byte[] zs, int count, ImPlot3DLineFlags flags, int offset, int stride)
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
			fixed (byte* nativeZs = zs)
			{
				ImPlot3DNative.PlotLineU8Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotLineS16Ptr(ReadOnlySpan<byte> labelId, short[] xs, short[] ys, short[] zs, int count, ImPlot3DLineFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (short* nativeXs = xs)
			fixed (short* nativeYs = ys)
			fixed (short* nativeZs = zs)
			{
				ImPlot3DNative.PlotLineS16Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
			}
		}

		public static void PlotLineS16Ptr(ReadOnlySpan<char> labelId, short[] xs, short[] ys, short[] zs, int count, ImPlot3DLineFlags flags, int offset, int stride)
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
			fixed (short* nativeZs = zs)
			{
				ImPlot3DNative.PlotLineS16Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotLineU16Ptr(ReadOnlySpan<byte> labelId, ushort[] xs, ushort[] ys, ushort[] zs, int count, ImPlot3DLineFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ushort* nativeXs = xs)
			fixed (ushort* nativeYs = ys)
			fixed (ushort* nativeZs = zs)
			{
				ImPlot3DNative.PlotLineU16Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
			}
		}

		public static void PlotLineU16Ptr(ReadOnlySpan<char> labelId, ushort[] xs, ushort[] ys, ushort[] zs, int count, ImPlot3DLineFlags flags, int offset, int stride)
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
			fixed (ushort* nativeZs = zs)
			{
				ImPlot3DNative.PlotLineU16Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotLineS32Ptr(ReadOnlySpan<byte> labelId, int[] xs, int[] ys, int[] zs, int count, ImPlot3DLineFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (int* nativeXs = xs)
			fixed (int* nativeYs = ys)
			fixed (int* nativeZs = zs)
			{
				ImPlot3DNative.PlotLineS32Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
			}
		}

		public static void PlotLineS32Ptr(ReadOnlySpan<char> labelId, int[] xs, int[] ys, int[] zs, int count, ImPlot3DLineFlags flags, int offset, int stride)
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
			fixed (int* nativeZs = zs)
			{
				ImPlot3DNative.PlotLineS32Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotLineU32Ptr(ReadOnlySpan<byte> labelId, uint[] xs, uint[] ys, uint[] zs, int count, ImPlot3DLineFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (uint* nativeXs = xs)
			fixed (uint* nativeYs = ys)
			fixed (uint* nativeZs = zs)
			{
				ImPlot3DNative.PlotLineU32Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
			}
		}

		public static void PlotLineU32Ptr(ReadOnlySpan<char> labelId, uint[] xs, uint[] ys, uint[] zs, int count, ImPlot3DLineFlags flags, int offset, int stride)
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
			fixed (uint* nativeZs = zs)
			{
				ImPlot3DNative.PlotLineU32Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotLineS64Ptr(ReadOnlySpan<byte> labelId, long[] xs, long[] ys, long[] zs, int count, ImPlot3DLineFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (long* nativeXs = xs)
			fixed (long* nativeYs = ys)
			fixed (long* nativeZs = zs)
			{
				ImPlot3DNative.PlotLineS64Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
			}
		}

		public static void PlotLineS64Ptr(ReadOnlySpan<char> labelId, long[] xs, long[] ys, long[] zs, int count, ImPlot3DLineFlags flags, int offset, int stride)
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
			fixed (long* nativeZs = zs)
			{
				ImPlot3DNative.PlotLineS64Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotLineU64Ptr(ReadOnlySpan<byte> labelId, ulong[] xs, ulong[] ys, ulong[] zs, int count, ImPlot3DLineFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ulong* nativeXs = xs)
			fixed (ulong* nativeYs = ys)
			fixed (ulong* nativeZs = zs)
			{
				ImPlot3DNative.PlotLineU64Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
			}
		}

		public static void PlotLineU64Ptr(ReadOnlySpan<char> labelId, ulong[] xs, ulong[] ys, ulong[] zs, int count, ImPlot3DLineFlags flags, int offset, int stride)
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
			fixed (ulong* nativeZs = zs)
			{
				ImPlot3DNative.PlotLineU64Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotTriangleFloatPtr(ReadOnlySpan<byte> labelId, float[] xs, float[] ys, float[] zs, int count, ImPlot3DTriangleFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (float* nativeXs = xs)
			fixed (float* nativeYs = ys)
			fixed (float* nativeZs = zs)
			{
				ImPlot3DNative.PlotTriangleFloatPtr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
			}
		}

		public static void PlotTriangleFloatPtr(ReadOnlySpan<char> labelId, float[] xs, float[] ys, float[] zs, int count, ImPlot3DTriangleFlags flags, int offset, int stride)
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
			fixed (float* nativeZs = zs)
			{
				ImPlot3DNative.PlotTriangleFloatPtr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotTriangleDoublePtr(ReadOnlySpan<byte> labelId, double[] xs, double[] ys, double[] zs, int count, ImPlot3DTriangleFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (double* nativeXs = xs)
			fixed (double* nativeYs = ys)
			fixed (double* nativeZs = zs)
			{
				ImPlot3DNative.PlotTriangleDoublePtr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
			}
		}

		public static void PlotTriangleDoublePtr(ReadOnlySpan<char> labelId, double[] xs, double[] ys, double[] zs, int count, ImPlot3DTriangleFlags flags, int offset, int stride)
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
			fixed (double* nativeZs = zs)
			{
				ImPlot3DNative.PlotTriangleDoublePtr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotTriangleS8Ptr(ReadOnlySpan<byte> labelId, sbyte[] xs, sbyte[] ys, sbyte[] zs, int count, ImPlot3DTriangleFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (sbyte* nativeXs = xs)
			fixed (sbyte* nativeYs = ys)
			fixed (sbyte* nativeZs = zs)
			{
				ImPlot3DNative.PlotTriangleS8Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
			}
		}

		public static void PlotTriangleS8Ptr(ReadOnlySpan<char> labelId, sbyte[] xs, sbyte[] ys, sbyte[] zs, int count, ImPlot3DTriangleFlags flags, int offset, int stride)
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
			fixed (sbyte* nativeZs = zs)
			{
				ImPlot3DNative.PlotTriangleS8Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotTriangleU8Ptr(ReadOnlySpan<byte> labelId, byte[] xs, byte[] ys, byte[] zs, int count, ImPlot3DTriangleFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (byte* nativeXs = xs)
			fixed (byte* nativeYs = ys)
			fixed (byte* nativeZs = zs)
			{
				ImPlot3DNative.PlotTriangleU8Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
			}
		}

		public static void PlotTriangleU8Ptr(ReadOnlySpan<char> labelId, byte[] xs, byte[] ys, byte[] zs, int count, ImPlot3DTriangleFlags flags, int offset, int stride)
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
			fixed (byte* nativeZs = zs)
			{
				ImPlot3DNative.PlotTriangleU8Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotTriangleS16Ptr(ReadOnlySpan<byte> labelId, short[] xs, short[] ys, short[] zs, int count, ImPlot3DTriangleFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (short* nativeXs = xs)
			fixed (short* nativeYs = ys)
			fixed (short* nativeZs = zs)
			{
				ImPlot3DNative.PlotTriangleS16Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
			}
		}

		public static void PlotTriangleS16Ptr(ReadOnlySpan<char> labelId, short[] xs, short[] ys, short[] zs, int count, ImPlot3DTriangleFlags flags, int offset, int stride)
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
			fixed (short* nativeZs = zs)
			{
				ImPlot3DNative.PlotTriangleS16Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotTriangleU16Ptr(ReadOnlySpan<byte> labelId, ushort[] xs, ushort[] ys, ushort[] zs, int count, ImPlot3DTriangleFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ushort* nativeXs = xs)
			fixed (ushort* nativeYs = ys)
			fixed (ushort* nativeZs = zs)
			{
				ImPlot3DNative.PlotTriangleU16Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
			}
		}

		public static void PlotTriangleU16Ptr(ReadOnlySpan<char> labelId, ushort[] xs, ushort[] ys, ushort[] zs, int count, ImPlot3DTriangleFlags flags, int offset, int stride)
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
			fixed (ushort* nativeZs = zs)
			{
				ImPlot3DNative.PlotTriangleU16Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotTriangleS32Ptr(ReadOnlySpan<byte> labelId, int[] xs, int[] ys, int[] zs, int count, ImPlot3DTriangleFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (int* nativeXs = xs)
			fixed (int* nativeYs = ys)
			fixed (int* nativeZs = zs)
			{
				ImPlot3DNative.PlotTriangleS32Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
			}
		}

		public static void PlotTriangleS32Ptr(ReadOnlySpan<char> labelId, int[] xs, int[] ys, int[] zs, int count, ImPlot3DTriangleFlags flags, int offset, int stride)
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
			fixed (int* nativeZs = zs)
			{
				ImPlot3DNative.PlotTriangleS32Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotTriangleU32Ptr(ReadOnlySpan<byte> labelId, uint[] xs, uint[] ys, uint[] zs, int count, ImPlot3DTriangleFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (uint* nativeXs = xs)
			fixed (uint* nativeYs = ys)
			fixed (uint* nativeZs = zs)
			{
				ImPlot3DNative.PlotTriangleU32Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
			}
		}

		public static void PlotTriangleU32Ptr(ReadOnlySpan<char> labelId, uint[] xs, uint[] ys, uint[] zs, int count, ImPlot3DTriangleFlags flags, int offset, int stride)
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
			fixed (uint* nativeZs = zs)
			{
				ImPlot3DNative.PlotTriangleU32Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotTriangleS64Ptr(ReadOnlySpan<byte> labelId, long[] xs, long[] ys, long[] zs, int count, ImPlot3DTriangleFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (long* nativeXs = xs)
			fixed (long* nativeYs = ys)
			fixed (long* nativeZs = zs)
			{
				ImPlot3DNative.PlotTriangleS64Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
			}
		}

		public static void PlotTriangleS64Ptr(ReadOnlySpan<char> labelId, long[] xs, long[] ys, long[] zs, int count, ImPlot3DTriangleFlags flags, int offset, int stride)
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
			fixed (long* nativeZs = zs)
			{
				ImPlot3DNative.PlotTriangleS64Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotTriangleU64Ptr(ReadOnlySpan<byte> labelId, ulong[] xs, ulong[] ys, ulong[] zs, int count, ImPlot3DTriangleFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ulong* nativeXs = xs)
			fixed (ulong* nativeYs = ys)
			fixed (ulong* nativeZs = zs)
			{
				ImPlot3DNative.PlotTriangleU64Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
			}
		}

		public static void PlotTriangleU64Ptr(ReadOnlySpan<char> labelId, ulong[] xs, ulong[] ys, ulong[] zs, int count, ImPlot3DTriangleFlags flags, int offset, int stride)
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
			fixed (ulong* nativeZs = zs)
			{
				ImPlot3DNative.PlotTriangleU64Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotQuadFloatPtr(ReadOnlySpan<byte> labelId, float[] xs, float[] ys, float[] zs, int count, ImPlot3DQuadFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (float* nativeXs = xs)
			fixed (float* nativeYs = ys)
			fixed (float* nativeZs = zs)
			{
				ImPlot3DNative.PlotQuadFloatPtr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
			}
		}

		public static void PlotQuadFloatPtr(ReadOnlySpan<char> labelId, float[] xs, float[] ys, float[] zs, int count, ImPlot3DQuadFlags flags, int offset, int stride)
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
			fixed (float* nativeZs = zs)
			{
				ImPlot3DNative.PlotQuadFloatPtr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotQuadDoublePtr(ReadOnlySpan<byte> labelId, double[] xs, double[] ys, double[] zs, int count, ImPlot3DQuadFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (double* nativeXs = xs)
			fixed (double* nativeYs = ys)
			fixed (double* nativeZs = zs)
			{
				ImPlot3DNative.PlotQuadDoublePtr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
			}
		}

		public static void PlotQuadDoublePtr(ReadOnlySpan<char> labelId, double[] xs, double[] ys, double[] zs, int count, ImPlot3DQuadFlags flags, int offset, int stride)
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
			fixed (double* nativeZs = zs)
			{
				ImPlot3DNative.PlotQuadDoublePtr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotQuadS8Ptr(ReadOnlySpan<byte> labelId, sbyte[] xs, sbyte[] ys, sbyte[] zs, int count, ImPlot3DQuadFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (sbyte* nativeXs = xs)
			fixed (sbyte* nativeYs = ys)
			fixed (sbyte* nativeZs = zs)
			{
				ImPlot3DNative.PlotQuadS8Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
			}
		}

		public static void PlotQuadS8Ptr(ReadOnlySpan<char> labelId, sbyte[] xs, sbyte[] ys, sbyte[] zs, int count, ImPlot3DQuadFlags flags, int offset, int stride)
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
			fixed (sbyte* nativeZs = zs)
			{
				ImPlot3DNative.PlotQuadS8Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotQuadU8Ptr(ReadOnlySpan<byte> labelId, byte[] xs, byte[] ys, byte[] zs, int count, ImPlot3DQuadFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (byte* nativeXs = xs)
			fixed (byte* nativeYs = ys)
			fixed (byte* nativeZs = zs)
			{
				ImPlot3DNative.PlotQuadU8Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
			}
		}

		public static void PlotQuadU8Ptr(ReadOnlySpan<char> labelId, byte[] xs, byte[] ys, byte[] zs, int count, ImPlot3DQuadFlags flags, int offset, int stride)
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
			fixed (byte* nativeZs = zs)
			{
				ImPlot3DNative.PlotQuadU8Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotQuadS16Ptr(ReadOnlySpan<byte> labelId, short[] xs, short[] ys, short[] zs, int count, ImPlot3DQuadFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (short* nativeXs = xs)
			fixed (short* nativeYs = ys)
			fixed (short* nativeZs = zs)
			{
				ImPlot3DNative.PlotQuadS16Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
			}
		}

		public static void PlotQuadS16Ptr(ReadOnlySpan<char> labelId, short[] xs, short[] ys, short[] zs, int count, ImPlot3DQuadFlags flags, int offset, int stride)
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
			fixed (short* nativeZs = zs)
			{
				ImPlot3DNative.PlotQuadS16Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotQuadU16Ptr(ReadOnlySpan<byte> labelId, ushort[] xs, ushort[] ys, ushort[] zs, int count, ImPlot3DQuadFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ushort* nativeXs = xs)
			fixed (ushort* nativeYs = ys)
			fixed (ushort* nativeZs = zs)
			{
				ImPlot3DNative.PlotQuadU16Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
			}
		}

		public static void PlotQuadU16Ptr(ReadOnlySpan<char> labelId, ushort[] xs, ushort[] ys, ushort[] zs, int count, ImPlot3DQuadFlags flags, int offset, int stride)
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
			fixed (ushort* nativeZs = zs)
			{
				ImPlot3DNative.PlotQuadU16Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotQuadS32Ptr(ReadOnlySpan<byte> labelId, int[] xs, int[] ys, int[] zs, int count, ImPlot3DQuadFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (int* nativeXs = xs)
			fixed (int* nativeYs = ys)
			fixed (int* nativeZs = zs)
			{
				ImPlot3DNative.PlotQuadS32Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
			}
		}

		public static void PlotQuadS32Ptr(ReadOnlySpan<char> labelId, int[] xs, int[] ys, int[] zs, int count, ImPlot3DQuadFlags flags, int offset, int stride)
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
			fixed (int* nativeZs = zs)
			{
				ImPlot3DNative.PlotQuadS32Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotQuadU32Ptr(ReadOnlySpan<byte> labelId, uint[] xs, uint[] ys, uint[] zs, int count, ImPlot3DQuadFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (uint* nativeXs = xs)
			fixed (uint* nativeYs = ys)
			fixed (uint* nativeZs = zs)
			{
				ImPlot3DNative.PlotQuadU32Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
			}
		}

		public static void PlotQuadU32Ptr(ReadOnlySpan<char> labelId, uint[] xs, uint[] ys, uint[] zs, int count, ImPlot3DQuadFlags flags, int offset, int stride)
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
			fixed (uint* nativeZs = zs)
			{
				ImPlot3DNative.PlotQuadU32Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotQuadS64Ptr(ReadOnlySpan<byte> labelId, long[] xs, long[] ys, long[] zs, int count, ImPlot3DQuadFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (long* nativeXs = xs)
			fixed (long* nativeYs = ys)
			fixed (long* nativeZs = zs)
			{
				ImPlot3DNative.PlotQuadS64Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
			}
		}

		public static void PlotQuadS64Ptr(ReadOnlySpan<char> labelId, long[] xs, long[] ys, long[] zs, int count, ImPlot3DQuadFlags flags, int offset, int stride)
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
			fixed (long* nativeZs = zs)
			{
				ImPlot3DNative.PlotQuadS64Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotQuadU64Ptr(ReadOnlySpan<byte> labelId, ulong[] xs, ulong[] ys, ulong[] zs, int count, ImPlot3DQuadFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ulong* nativeXs = xs)
			fixed (ulong* nativeYs = ys)
			fixed (ulong* nativeZs = zs)
			{
				ImPlot3DNative.PlotQuadU64Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
			}
		}

		public static void PlotQuadU64Ptr(ReadOnlySpan<char> labelId, ulong[] xs, ulong[] ys, ulong[] zs, int count, ImPlot3DQuadFlags flags, int offset, int stride)
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
			fixed (ulong* nativeZs = zs)
			{
				ImPlot3DNative.PlotQuadU64Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, count, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotSurfaceFloatPtr(ReadOnlySpan<byte> labelId, float[] xs, float[] ys, float[] zs, int xCount, int yCount, double scaleMin, double scaleMax, ImPlot3DSurfaceFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (float* nativeXs = xs)
			fixed (float* nativeYs = ys)
			fixed (float* nativeZs = zs)
			{
				ImPlot3DNative.PlotSurfaceFloatPtr(nativeLabelId, nativeXs, nativeYs, nativeZs, xCount, yCount, scaleMin, scaleMax, flags, offset, stride);
			}
		}

		public static void PlotSurfaceFloatPtr(ReadOnlySpan<char> labelId, float[] xs, float[] ys, float[] zs, int xCount, int yCount, double scaleMin, double scaleMax, ImPlot3DSurfaceFlags flags, int offset, int stride)
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
			fixed (float* nativeZs = zs)
			{
				ImPlot3DNative.PlotSurfaceFloatPtr(nativeLabelId, nativeXs, nativeYs, nativeZs, xCount, yCount, scaleMin, scaleMax, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotSurfaceDoublePtr(ReadOnlySpan<byte> labelId, double[] xs, double[] ys, double[] zs, int xCount, int yCount, double scaleMin, double scaleMax, ImPlot3DSurfaceFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (double* nativeXs = xs)
			fixed (double* nativeYs = ys)
			fixed (double* nativeZs = zs)
			{
				ImPlot3DNative.PlotSurfaceDoublePtr(nativeLabelId, nativeXs, nativeYs, nativeZs, xCount, yCount, scaleMin, scaleMax, flags, offset, stride);
			}
		}

		public static void PlotSurfaceDoublePtr(ReadOnlySpan<char> labelId, double[] xs, double[] ys, double[] zs, int xCount, int yCount, double scaleMin, double scaleMax, ImPlot3DSurfaceFlags flags, int offset, int stride)
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
			fixed (double* nativeZs = zs)
			{
				ImPlot3DNative.PlotSurfaceDoublePtr(nativeLabelId, nativeXs, nativeYs, nativeZs, xCount, yCount, scaleMin, scaleMax, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotSurfaceS8Ptr(ReadOnlySpan<byte> labelId, sbyte[] xs, sbyte[] ys, sbyte[] zs, int xCount, int yCount, double scaleMin, double scaleMax, ImPlot3DSurfaceFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (sbyte* nativeXs = xs)
			fixed (sbyte* nativeYs = ys)
			fixed (sbyte* nativeZs = zs)
			{
				ImPlot3DNative.PlotSurfaceS8Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, xCount, yCount, scaleMin, scaleMax, flags, offset, stride);
			}
		}

		public static void PlotSurfaceS8Ptr(ReadOnlySpan<char> labelId, sbyte[] xs, sbyte[] ys, sbyte[] zs, int xCount, int yCount, double scaleMin, double scaleMax, ImPlot3DSurfaceFlags flags, int offset, int stride)
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
			fixed (sbyte* nativeZs = zs)
			{
				ImPlot3DNative.PlotSurfaceS8Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, xCount, yCount, scaleMin, scaleMax, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotSurfaceU8Ptr(ReadOnlySpan<byte> labelId, byte[] xs, byte[] ys, byte[] zs, int xCount, int yCount, double scaleMin, double scaleMax, ImPlot3DSurfaceFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (byte* nativeXs = xs)
			fixed (byte* nativeYs = ys)
			fixed (byte* nativeZs = zs)
			{
				ImPlot3DNative.PlotSurfaceU8Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, xCount, yCount, scaleMin, scaleMax, flags, offset, stride);
			}
		}

		public static void PlotSurfaceU8Ptr(ReadOnlySpan<char> labelId, byte[] xs, byte[] ys, byte[] zs, int xCount, int yCount, double scaleMin, double scaleMax, ImPlot3DSurfaceFlags flags, int offset, int stride)
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
			fixed (byte* nativeZs = zs)
			{
				ImPlot3DNative.PlotSurfaceU8Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, xCount, yCount, scaleMin, scaleMax, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotSurfaceS16Ptr(ReadOnlySpan<byte> labelId, short[] xs, short[] ys, short[] zs, int xCount, int yCount, double scaleMin, double scaleMax, ImPlot3DSurfaceFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (short* nativeXs = xs)
			fixed (short* nativeYs = ys)
			fixed (short* nativeZs = zs)
			{
				ImPlot3DNative.PlotSurfaceS16Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, xCount, yCount, scaleMin, scaleMax, flags, offset, stride);
			}
		}

		public static void PlotSurfaceS16Ptr(ReadOnlySpan<char> labelId, short[] xs, short[] ys, short[] zs, int xCount, int yCount, double scaleMin, double scaleMax, ImPlot3DSurfaceFlags flags, int offset, int stride)
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
			fixed (short* nativeZs = zs)
			{
				ImPlot3DNative.PlotSurfaceS16Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, xCount, yCount, scaleMin, scaleMax, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotSurfaceU16Ptr(ReadOnlySpan<byte> labelId, ushort[] xs, ushort[] ys, ushort[] zs, int xCount, int yCount, double scaleMin, double scaleMax, ImPlot3DSurfaceFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ushort* nativeXs = xs)
			fixed (ushort* nativeYs = ys)
			fixed (ushort* nativeZs = zs)
			{
				ImPlot3DNative.PlotSurfaceU16Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, xCount, yCount, scaleMin, scaleMax, flags, offset, stride);
			}
		}

		public static void PlotSurfaceU16Ptr(ReadOnlySpan<char> labelId, ushort[] xs, ushort[] ys, ushort[] zs, int xCount, int yCount, double scaleMin, double scaleMax, ImPlot3DSurfaceFlags flags, int offset, int stride)
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
			fixed (ushort* nativeZs = zs)
			{
				ImPlot3DNative.PlotSurfaceU16Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, xCount, yCount, scaleMin, scaleMax, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotSurfaceS32Ptr(ReadOnlySpan<byte> labelId, int[] xs, int[] ys, int[] zs, int xCount, int yCount, double scaleMin, double scaleMax, ImPlot3DSurfaceFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (int* nativeXs = xs)
			fixed (int* nativeYs = ys)
			fixed (int* nativeZs = zs)
			{
				ImPlot3DNative.PlotSurfaceS32Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, xCount, yCount, scaleMin, scaleMax, flags, offset, stride);
			}
		}

		public static void PlotSurfaceS32Ptr(ReadOnlySpan<char> labelId, int[] xs, int[] ys, int[] zs, int xCount, int yCount, double scaleMin, double scaleMax, ImPlot3DSurfaceFlags flags, int offset, int stride)
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
			fixed (int* nativeZs = zs)
			{
				ImPlot3DNative.PlotSurfaceS32Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, xCount, yCount, scaleMin, scaleMax, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotSurfaceU32Ptr(ReadOnlySpan<byte> labelId, uint[] xs, uint[] ys, uint[] zs, int xCount, int yCount, double scaleMin, double scaleMax, ImPlot3DSurfaceFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (uint* nativeXs = xs)
			fixed (uint* nativeYs = ys)
			fixed (uint* nativeZs = zs)
			{
				ImPlot3DNative.PlotSurfaceU32Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, xCount, yCount, scaleMin, scaleMax, flags, offset, stride);
			}
		}

		public static void PlotSurfaceU32Ptr(ReadOnlySpan<char> labelId, uint[] xs, uint[] ys, uint[] zs, int xCount, int yCount, double scaleMin, double scaleMax, ImPlot3DSurfaceFlags flags, int offset, int stride)
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
			fixed (uint* nativeZs = zs)
			{
				ImPlot3DNative.PlotSurfaceU32Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, xCount, yCount, scaleMin, scaleMax, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotSurfaceS64Ptr(ReadOnlySpan<byte> labelId, long[] xs, long[] ys, long[] zs, int xCount, int yCount, double scaleMin, double scaleMax, ImPlot3DSurfaceFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (long* nativeXs = xs)
			fixed (long* nativeYs = ys)
			fixed (long* nativeZs = zs)
			{
				ImPlot3DNative.PlotSurfaceS64Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, xCount, yCount, scaleMin, scaleMax, flags, offset, stride);
			}
		}

		public static void PlotSurfaceS64Ptr(ReadOnlySpan<char> labelId, long[] xs, long[] ys, long[] zs, int xCount, int yCount, double scaleMin, double scaleMax, ImPlot3DSurfaceFlags flags, int offset, int stride)
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
			fixed (long* nativeZs = zs)
			{
				ImPlot3DNative.PlotSurfaceS64Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, xCount, yCount, scaleMin, scaleMax, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotSurfaceU64Ptr(ReadOnlySpan<byte> labelId, ulong[] xs, ulong[] ys, ulong[] zs, int xCount, int yCount, double scaleMin, double scaleMax, ImPlot3DSurfaceFlags flags, int offset, int stride)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (ulong* nativeXs = xs)
			fixed (ulong* nativeYs = ys)
			fixed (ulong* nativeZs = zs)
			{
				ImPlot3DNative.PlotSurfaceU64Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, xCount, yCount, scaleMin, scaleMax, flags, offset, stride);
			}
		}

		public static void PlotSurfaceU64Ptr(ReadOnlySpan<char> labelId, ulong[] xs, ulong[] ys, ulong[] zs, int xCount, int yCount, double scaleMin, double scaleMax, ImPlot3DSurfaceFlags flags, int offset, int stride)
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
			fixed (ulong* nativeZs = zs)
			{
				ImPlot3DNative.PlotSurfaceU64Ptr(nativeLabelId, nativeXs, nativeYs, nativeZs, xCount, yCount, scaleMin, scaleMax, flags, offset, stride);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotMesh(ReadOnlySpan<byte> labelId, ImPlot3DPointPtr vtx, uint[] idx, int vtxCount, int idxCount, ImPlot3DMeshFlags flags)
		{
			fixed (byte* nativeLabelId = labelId)
			fixed (uint* nativeIdx = idx)
			{
				ImPlot3DNative.PlotMesh(nativeLabelId, vtx, nativeIdx, vtxCount, idxCount, flags);
			}
		}

		public static void PlotMesh(ReadOnlySpan<char> labelId, ImPlot3DPointPtr vtx, uint[] idx, int vtxCount, int idxCount, ImPlot3DMeshFlags flags)
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

			fixed (uint* nativeIdx = idx)
			{
				ImPlot3DNative.PlotMesh(nativeLabelId, vtx, nativeIdx, vtxCount, idxCount, flags);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotMesh(ReadOnlySpan<byte> labelId, ImPlot3DPointPtr vtx, uint[] idx, int vtxCount, int idxCount)
		{
			// defining omitted parameters
			ImPlot3DMeshFlags flags = ImPlot3DMeshFlags.None;
			fixed (byte* nativeLabelId = labelId)
			fixed (uint* nativeIdx = idx)
			{
				ImPlot3DNative.PlotMesh(nativeLabelId, vtx, nativeIdx, vtxCount, idxCount, flags);
			}
		}

		public static void PlotMesh(ReadOnlySpan<char> labelId, ImPlot3DPointPtr vtx, uint[] idx, int vtxCount, int idxCount)
		{
			// defining omitted parameters
			ImPlot3DMeshFlags flags = ImPlot3DMeshFlags.None;
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

			fixed (uint* nativeIdx = idx)
			{
				ImPlot3DNative.PlotMesh(nativeLabelId, vtx, nativeIdx, vtxCount, idxCount, flags);
				// Freeing labelId native string
				if (byteCountLabelId > Utils.MaxStackallocSize)
					Utils.Free(nativeLabelId);
			}
		}

		public static void PlotText(ReadOnlySpan<byte> text, float x, float y, float z, float angle, Vector2 pixOffset)
		{
			fixed (byte* nativeText = text)
			{
				ImPlot3DNative.PlotText(nativeText, x, y, z, angle, pixOffset);
			}
		}

		public static void PlotText(ReadOnlySpan<char> text, float x, float y, float z, float angle, Vector2 pixOffset)
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

			ImPlot3DNative.PlotText(nativeText, x, y, z, angle, pixOffset);
			// Freeing text native string
			if (byteCountText > Utils.MaxStackallocSize)
				Utils.Free(nativeText);
		}

		public static void PlotText(ReadOnlySpan<byte> text, float x, float y, float z, float angle)
		{
			// defining omitted parameters
			Vector2 pixOffset = new Vector2(0,0);
			fixed (byte* nativeText = text)
			{
				ImPlot3DNative.PlotText(nativeText, x, y, z, angle, pixOffset);
			}
		}

		public static void PlotText(ReadOnlySpan<char> text, float x, float y, float z, float angle)
		{
			// defining omitted parameters
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

			ImPlot3DNative.PlotText(nativeText, x, y, z, angle, pixOffset);
			// Freeing text native string
			if (byteCountText > Utils.MaxStackallocSize)
				Utils.Free(nativeText);
		}

		public static void PlotText(ReadOnlySpan<byte> text, float x, float y, float z)
		{
			// defining omitted parameters
			float angle = 0.0f;
			Vector2 pixOffset = new Vector2(0,0);
			fixed (byte* nativeText = text)
			{
				ImPlot3DNative.PlotText(nativeText, x, y, z, angle, pixOffset);
			}
		}

		public static void PlotText(ReadOnlySpan<char> text, float x, float y, float z)
		{
			// defining omitted parameters
			float angle = 0.0f;
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

			ImPlot3DNative.PlotText(nativeText, x, y, z, angle, pixOffset);
			// Freeing text native string
			if (byteCountText > Utils.MaxStackallocSize)
				Utils.Free(nativeText);
		}

		public static void PlotToPixelsPlot3DPoInt(out Vector2 pOut, ImPlot3DPoint point)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImPlot3DNative.PlotToPixelsPlot3DPoInt(nativePOut, point);
			}
		}

		public static void PlotToPixelsDouble(out Vector2 pOut, double x, double y, double z)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImPlot3DNative.PlotToPixelsDouble(nativePOut, x, y, z);
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
		public static void GetPlotPos(out Vector2 pOut)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImPlot3DNative.GetPlotPos(nativePOut);
			}
		}

		/// <summary>
		/// Get the current plot size in pixels<br/>
		/// </summary>
		public static void GetPlotSize(out Vector2 pOut)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImPlot3DNative.GetPlotSize(nativePOut);
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
		/// Set colors with ImGui style<br/>
		/// </summary>
		public static void StyleColorsAuto()
		{
			// defining omitted parameters
			ImPlot3DStyle* dst = null;
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
		/// Set colors with dark style<br/>
		/// </summary>
		public static void StyleColorsDark()
		{
			// defining omitted parameters
			ImPlot3DStyle* dst = null;
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
		/// Set colors with light style<br/>
		/// </summary>
		public static void StyleColorsLight()
		{
			// defining omitted parameters
			ImPlot3DStyle* dst = null;
			ImPlot3DNative.StyleColorsLight(dst);
		}

		/// <summary>
		/// Set colors with classic style<br/>
		/// </summary>
		public static void StyleColorsClassic(ImPlot3DStylePtr dst)
		{
			ImPlot3DNative.StyleColorsClassic(dst);
		}

		/// <summary>
		/// Set colors with classic style<br/>
		/// </summary>
		public static void StyleColorsClassic()
		{
			// defining omitted parameters
			ImPlot3DStyle* dst = null;
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

		public static void PopStyleColor()
		{
			// defining omitted parameters
			int count = 1;
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

		public static void PopStyleVar()
		{
			// defining omitted parameters
			int count = 1;
			ImPlot3DNative.PopStyleVar(count);
		}

		public static void SetNextLineStyle(Vector4 col, float weight)
		{
			ImPlot3DNative.SetNextLineStyle(col, weight);
		}

		public static void SetNextLineStyle(Vector4 col)
		{
			// defining omitted parameters
			float weight = -1;
			ImPlot3DNative.SetNextLineStyle(col, weight);
		}

		public static void SetNextLineStyle()
		{
			// defining omitted parameters
			float weight = -1;
			Vector4 col = new Vector4(0,0,0,-1);
			ImPlot3DNative.SetNextLineStyle(col, weight);
		}

		public static void SetNextFillStyle(Vector4 col, float alphaMod)
		{
			ImPlot3DNative.SetNextFillStyle(col, alphaMod);
		}

		public static void SetNextFillStyle(Vector4 col)
		{
			// defining omitted parameters
			float alphaMod = -1;
			ImPlot3DNative.SetNextFillStyle(col, alphaMod);
		}

		public static void SetNextFillStyle()
		{
			// defining omitted parameters
			float alphaMod = -1;
			Vector4 col = new Vector4(0,0,0,-1);
			ImPlot3DNative.SetNextFillStyle(col, alphaMod);
		}

		public static void SetNextMarkerStyle(ImPlot3DMarker marker, float size, Vector4 fill, float weight, Vector4 outline)
		{
			ImPlot3DNative.SetNextMarkerStyle(marker, size, fill, weight, outline);
		}

		public static void SetNextMarkerStyle(ImPlot3DMarker marker, float size, Vector4 fill, float weight)
		{
			// defining omitted parameters
			Vector4 outline = new Vector4(0,0,0,-1);
			ImPlot3DNative.SetNextMarkerStyle(marker, size, fill, weight, outline);
		}

		public static void SetNextMarkerStyle(ImPlot3DMarker marker, float size, Vector4 fill)
		{
			// defining omitted parameters
			float weight = -1;
			Vector4 outline = new Vector4(0,0,0,-1);
			ImPlot3DNative.SetNextMarkerStyle(marker, size, fill, weight, outline);
		}

		public static void SetNextMarkerStyle(ImPlot3DMarker marker, float size)
		{
			// defining omitted parameters
			float weight = -1;
			Vector4 outline = new Vector4(0,0,0,-1);
			Vector4 fill = new Vector4(0,0,0,-1);
			ImPlot3DNative.SetNextMarkerStyle(marker, size, fill, weight, outline);
		}

		public static void SetNextMarkerStyle(ImPlot3DMarker marker)
		{
			// defining omitted parameters
			float weight = -1;
			float size = -1;
			Vector4 outline = new Vector4(0,0,0,-1);
			Vector4 fill = new Vector4(0,0,0,-1);
			ImPlot3DNative.SetNextMarkerStyle(marker, size, fill, weight, outline);
		}

		public static void SetNextMarkerStyle()
		{
			// defining omitted parameters
			float weight = -1;
			float size = -1;
			Vector4 outline = new Vector4(0,0,0,-1);
			Vector4 fill = new Vector4(0,0,0,-1);
			ImPlot3DMarker marker = ImPlot3DMarker.None;
			ImPlot3DNative.SetNextMarkerStyle(marker, size, fill, weight, outline);
		}

		public static void GetStyleColorVec4(out Vector4 pOut, ImPlot3DCol idx)
		{
			fixed (Vector4* nativePOut = &pOut)
			{
				ImPlot3DNative.GetStyleColorVec4(nativePOut, idx);
			}
		}

		public static uint GetStyleColorU32(ImPlot3DCol idx)
		{
			return ImPlot3DNative.GetStyleColorU32(idx);
		}

		public static ImPlot3DColormap AddColormapVec4Ptr(ReadOnlySpan<byte> name, Vector4[] cols, int size, bool qual)
		{
			var native_qual = qual ? (byte)1 : (byte)0;
			fixed (byte* nativeName = name)
			fixed (Vector4* nativeCols = cols)
			{
				return ImPlot3DNative.AddColormapVec4Ptr(nativeName, nativeCols, size, native_qual);
			}
		}

		public static ImPlot3DColormap AddColormapVec4Ptr(ReadOnlySpan<char> name, Vector4[] cols, int size, bool qual)
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
				var result = ImPlot3DNative.AddColormapVec4Ptr(nativeName, nativeCols, size, native_qual);
				// Freeing name native string
				if (byteCountName > Utils.MaxStackallocSize)
					Utils.Free(nativeName);
				return result;
			}
		}

		public static ImPlot3DColormap AddColormapU32Ptr(ReadOnlySpan<byte> name, uint[] cols, int size, bool qual)
		{
			var native_qual = qual ? (byte)1 : (byte)0;
			fixed (byte* nativeName = name)
			fixed (uint* nativeCols = cols)
			{
				return ImPlot3DNative.AddColormapU32Ptr(nativeName, nativeCols, size, native_qual);
			}
		}

		public static ImPlot3DColormap AddColormapU32Ptr(ReadOnlySpan<char> name, uint[] cols, int size, bool qual)
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
				var result = ImPlot3DNative.AddColormapU32Ptr(nativeName, nativeCols, size, native_qual);
				// Freeing name native string
				if (byteCountName > Utils.MaxStackallocSize)
					Utils.Free(nativeName);
				return result;
			}
		}

		public static int GetColormapCount()
		{
			return ImPlot3DNative.GetColormapCount();
		}

		public static string GetColormapName(ImPlot3DColormap cmap)
		{
			var result = ImPlot3DNative.GetColormapName(cmap);
			return Utils.DecodeStringUTF8(result);
		}

		public static ImPlot3DColormap GetColormapIndex(ReadOnlySpan<byte> name)
		{
			fixed (byte* nativeName = name)
			{
				return ImPlot3DNative.GetColormapIndex(nativeName);
			}
		}

		public static ImPlot3DColormap GetColormapIndex(ReadOnlySpan<char> name)
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

			var result = ImPlot3DNative.GetColormapIndex(nativeName);
			// Freeing name native string
			if (byteCountName > Utils.MaxStackallocSize)
				Utils.Free(nativeName);
			return result;
		}

		public static void PushColormapPlot3DColormap(ImPlot3DColormap cmap)
		{
			ImPlot3DNative.PushColormapPlot3DColormap(cmap);
		}

		public static void PushColormapStr(ReadOnlySpan<byte> name)
		{
			fixed (byte* nativeName = name)
			{
				ImPlot3DNative.PushColormapStr(nativeName);
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

			ImPlot3DNative.PushColormapStr(nativeName);
			// Freeing name native string
			if (byteCountName > Utils.MaxStackallocSize)
				Utils.Free(nativeName);
		}

		public static void PopColormap(int count)
		{
			ImPlot3DNative.PopColormap(count);
		}

		public static void PopColormap()
		{
			// defining omitted parameters
			int count = 1;
			ImPlot3DNative.PopColormap(count);
		}

		public static void NextColormapColor(out Vector4 pOut)
		{
			fixed (Vector4* nativePOut = &pOut)
			{
				ImPlot3DNative.NextColormapColor(nativePOut);
			}
		}

		public static int GetColormapSize(ImPlot3DColormap cmap)
		{
			return ImPlot3DNative.GetColormapSize(cmap);
		}

		public static int GetColormapSize()
		{
			// defining omitted parameters
			ImPlot3DColormap cmap = (ImPlot3DColormap)0;
			return ImPlot3DNative.GetColormapSize(cmap);
		}

		public static void GetColormapColor(out Vector4 pOut, int idx, ImPlot3DColormap cmap)
		{
			fixed (Vector4* nativePOut = &pOut)
			{
				ImPlot3DNative.GetColormapColor(nativePOut, idx, cmap);
			}
		}

		public static void GetColormapColor(out Vector4 pOut, int idx)
		{
			// defining omitted parameters
			ImPlot3DColormap cmap = (ImPlot3DColormap)0;
			fixed (Vector4* nativePOut = &pOut)
			{
				ImPlot3DNative.GetColormapColor(nativePOut, idx, cmap);
			}
		}

		public static void SampleColormap(out Vector4 pOut, float t, ImPlot3DColormap cmap)
		{
			fixed (Vector4* nativePOut = &pOut)
			{
				ImPlot3DNative.SampleColormap(nativePOut, t, cmap);
			}
		}

		public static void SampleColormap(out Vector4 pOut, float t)
		{
			// defining omitted parameters
			ImPlot3DColormap cmap = (ImPlot3DColormap)0;
			fixed (Vector4* nativePOut = &pOut)
			{
				ImPlot3DNative.SampleColormap(nativePOut, t, cmap);
			}
		}

		public static void ShowDemoWindow(ref bool pOpen)
		{
			var nativePOpenVal = pOpen ? (byte)1 : (byte)0;
			var nativePOpen = &nativePOpenVal;
			ImPlot3DNative.ShowDemoWindow(nativePOpen);
			pOpen = nativePOpenVal != 0;
		}

		public static void ShowDemoWindow()
		{
			// defining omitted parameters
			byte* pOpen = null;
			ImPlot3DNative.ShowDemoWindow(pOpen);
		}

		public static void ShowStyleEditor(ImPlot3DStylePtr _ref)
		{
			ImPlot3DNative.ShowStyleEditor(_ref);
		}

		public static void ShowStyleEditor()
		{
			// defining omitted parameters
			ImPlot3DStyle* _ref = null;
			ImPlot3DNative.ShowStyleEditor(_ref);
		}

	}
}
