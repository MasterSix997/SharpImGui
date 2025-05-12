using SharpImGui;
using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImPlot
{
	public unsafe delegate int ImPlotFormatter(double value, byte* buff, int size, void* userData);

	public unsafe delegate ImPlotPoint ImPlotGetter(int idx, void* userData);

	public unsafe delegate double ImPlotTransform(double value, void* userData);

	public unsafe delegate void ImPlotLocator(ImPlotTicker* ticker, ImPlotRange range, float pixels, byte vertical, ImPlotFormatter formatter, void* formatterData);

	public unsafe delegate void* ImPlotPointGetter(void* data, int idx, ImPlotPoint* point);
}
