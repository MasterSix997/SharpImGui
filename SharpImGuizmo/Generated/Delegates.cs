using System;
using System.Numerics;
using System.Runtime.InteropServices;
using SharpImGui;

namespace SharpImGuizmo
{
	public unsafe delegate byte* igCombo_FnStrPtr_getterDelegate(void* user_data, int idx);

	public unsafe delegate byte* igListBox_FnStrPtr_getterDelegate(void* user_data, int idx);

	public unsafe delegate float igPlotLines_FnFloatPtr_values_getterDelegate(void* data, int idx);

	public unsafe delegate float igPlotHistogram_FnFloatPtr_values_getterDelegate(void* data, int idx);

	public unsafe delegate int igImQsort_compare_funcDelegate(void* arg0, void* arg1);

	public unsafe delegate byte* igTypingSelectFindMatch_get_item_name_funcDelegate(void* arg0, int arg1);

	public unsafe delegate byte* igTypingSelectFindNextSingleCharMatch_get_item_name_funcDelegate(void* arg0, int arg1);

	public unsafe delegate byte* igTypingSelectFindBestLeadingMatch_get_item_name_funcDelegate(void* arg0, int arg1);

	public unsafe delegate float igPlotEx_values_getterDelegate(void* data, int idx);

	public unsafe delegate void ImGuiPlatformIO_Set_Platform_GetWindowPos_user_callbackDelegate(ImGuiViewport* vp, Vector2* out_pos);

	public unsafe delegate void ImGuiPlatformIO_Set_Platform_GetWindowSize_user_callbackDelegate(ImGuiViewport* vp, Vector2* out_size);
}
