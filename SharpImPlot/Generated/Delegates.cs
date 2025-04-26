using SharpImGui;
using System;
using System.Numerics;
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

	public unsafe delegate byte* IgComboFnStrPtrGetter(void* userData, int idx);

	public unsafe delegate byte* IgListBoxFnStrPtrGetter(void* userData, int idx);

	public unsafe delegate float IgPlotLinesFnFloatPtrValuesGetter(void* data, int idx);

	public unsafe delegate float IgPlotHistogramFnFloatPtrValuesGetter(void* data, int idx);

	public unsafe delegate int IgImQsortCompareFunc(void* arg0, void* arg1);

	public unsafe delegate byte* IgTypingSelectFindMatchGetItemNameFunc(void* arg0, int arg1);

	public unsafe delegate byte* IgTypingSelectFindNextSingleCharMatchGetItemNameFunc(void* arg0, int arg1);

	public unsafe delegate byte* IgTypingSelectFindBestLeadingMatchGetItemNameFunc(void* arg0, int arg1);

	public unsafe delegate float IgPlotExValuesGetter(void* data, int idx);

	public unsafe delegate void ImGuiPlatformIOSetPlatformGetWindowPosUserCallback(ImGuiViewport* vp, Vector2* outPos);

	public unsafe delegate void ImGuiPlatformIOSetPlatformGetWindowSizeUserCallback(ImGuiViewport* vp, Vector2* outSize);
}
