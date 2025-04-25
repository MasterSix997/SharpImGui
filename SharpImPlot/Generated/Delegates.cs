using System;
using System.Numerics;
using System.Runtime.InteropServices;
using SharpImGui;

namespace SharpImPlot
{
	public unsafe delegate int ImPlotFormatterDelegate(double value, byte* buff, int size, void* user_data);

	public unsafe delegate ImPlotPoint ImPlotGetterDelegate(int idx, void* user_data);

	public unsafe delegate double ImPlotTransformDelegate(double value, void* user_data);

	public unsafe delegate void ImPlotLocatorDelegate(ImPlotTicker* ticker, ImPlotRange range, float pixels, byte vertical, IntPtr formatter, void* formatter_data);

	public unsafe delegate void* ImPlotPoint_getterDelegate(void* data, int idx, ImPlotPoint* point);

	public unsafe delegate byte* igCombo_getterDelegate(void* user_data, int idx);

	public unsafe delegate byte* igListBox_FnStrPtr_getterDelegate(void* user_data, int idx);

	public unsafe delegate float igPlotLines_values_getterDelegate(void* data, int idx);

	public unsafe delegate float igPlotHistogram_values_getterDelegate(void* data, int idx);

	public unsafe delegate int igImQsort_compare_funcDelegate(void* arg0, void* arg1);

	public unsafe delegate byte* igTypingSelectFindMatch_get_item_name_funcDelegate(void* arg0, int arg1);

	public unsafe delegate byte* igTypingSelectFindNextSingleCharMatch_get_item_name_funcDelegate(void* arg0, int arg1);

	public unsafe delegate byte* igTypingSelectFindBestLeadingMatch_get_item_name_funcDelegate(void* arg0, int arg1);

	public unsafe delegate float igPlotEx_values_getterDelegate(void* data, int idx);

	public unsafe delegate void ImGuiPlatformIO_Set_Platform_GetWindowPos_user_callbackDelegate(ImGuiViewport* vp, Vector2* out_pos);

	public unsafe delegate void ImGuiPlatformIO_Set_Platform_GetWindowSize_user_callbackDelegate(ImGuiViewport* vp, Vector2* out_size);
}
