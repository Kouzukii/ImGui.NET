using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace ImGuiNET
{
    public static unsafe partial class ImGuiNative
    {
        [LibraryImport("cimgui")]
        public static partial ImGuiPayload* igAcceptDragDropPayload(byte* type, ImGuiDragDropFlags flags);
        [LibraryImport("cimgui")]
        public static partial void igAlignTextToFramePadding();
        [LibraryImport("cimgui")]
        public static partial byte igArrowButton(byte* str_id, ImGuiDir dir);
        [LibraryImport("cimgui")]
        public static partial byte igBegin(byte* name, byte* p_open, ImGuiWindowFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igBeginChild_Str(byte* str_id, Vector2 size, byte border, ImGuiWindowFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igBeginChild_ID(uint id, Vector2 size, byte border, ImGuiWindowFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igBeginChildFrame(uint id, Vector2 size, ImGuiWindowFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igBeginCombo(byte* label, byte* preview_value, ImGuiComboFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igBeginDragDropSource(ImGuiDragDropFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igBeginDragDropTarget();
        [LibraryImport("cimgui")]
        public static partial void igBeginGroup();
        [LibraryImport("cimgui")]
        public static partial byte igBeginMainMenuBar();
        [LibraryImport("cimgui")]
        public static partial byte igBeginMenu(byte* label, byte enabled);
        [LibraryImport("cimgui")]
        public static partial byte igBeginMenuBar();
        [LibraryImport("cimgui")]
        public static partial byte igBeginPopup(byte* str_id, ImGuiWindowFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igBeginPopupContextItem(byte* str_id, ImGuiPopupFlags popup_flags);
        [LibraryImport("cimgui")]
        public static partial byte igBeginPopupContextVoid(byte* str_id, ImGuiPopupFlags popup_flags);
        [LibraryImport("cimgui")]
        public static partial byte igBeginPopupContextWindow(byte* str_id, ImGuiPopupFlags popup_flags);
        [LibraryImport("cimgui")]
        public static partial byte igBeginPopupModal(byte* name, byte* p_open, ImGuiWindowFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igBeginTabBar(byte* str_id, ImGuiTabBarFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igBeginTabItem(byte* label, byte* p_open, ImGuiTabItemFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igBeginTable(byte* str_id, int column, ImGuiTableFlags flags, Vector2 outer_size, float inner_width);
        [LibraryImport("cimgui")]
        public static partial void igBeginTooltip();
        [LibraryImport("cimgui")]
        public static partial void igBullet();
        [LibraryImport("cimgui")]
        public static partial void igBulletText(byte* fmt);
        [LibraryImport("cimgui")]
        public static partial byte igButton(byte* label, Vector2 size);
        [LibraryImport("cimgui")]
        public static partial float igCalcItemWidth();
        [LibraryImport("cimgui")]
        public static partial void igCalcListClipping(int items_count, float items_height, int* out_items_display_start, int* out_items_display_end);
        [LibraryImport("cimgui")]
        public static partial void igCalcTextSize(Vector2* pOut, byte* text, byte* text_end, byte hide_text_after_double_hash, float wrap_width);
        [LibraryImport("cimgui")]
        public static partial void igCaptureKeyboardFromApp(byte want_capture_keyboard_value);
        [LibraryImport("cimgui")]
        public static partial void igCaptureMouseFromApp(byte want_capture_mouse_value);
        [LibraryImport("cimgui")]
        public static partial byte igCheckbox(byte* label, byte* v);
        [LibraryImport("cimgui")]
        public static partial byte igCheckboxFlags_IntPtr(byte* label, int* flags, int flags_value);
        [LibraryImport("cimgui")]
        public static partial byte igCheckboxFlags_UintPtr(byte* label, uint* flags, uint flags_value);
        [LibraryImport("cimgui")]
        public static partial void igCloseCurrentPopup();
        [LibraryImport("cimgui")]
        public static partial byte igCollapsingHeader_TreeNodeFlags(byte* label, ImGuiTreeNodeFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igCollapsingHeader_BoolPtr(byte* label, byte* p_visible, ImGuiTreeNodeFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igColorButton(byte* desc_id, Vector4 col, ImGuiColorEditFlags flags, Vector2 size);
        [LibraryImport("cimgui")]
        public static partial uint igColorConvertFloat4ToU32(Vector4 @in);
        [LibraryImport("cimgui")]
        public static partial void igColorConvertHSVtoRGB(float h, float s, float v, float* out_r, float* out_g, float* out_b);
        [LibraryImport("cimgui")]
        public static partial void igColorConvertRGBtoHSV(float r, float g, float b, float* out_h, float* out_s, float* out_v);
        [LibraryImport("cimgui")]
        public static partial void igColorConvertU32ToFloat4(Vector4* pOut, uint @in);
        [LibraryImport("cimgui")]
        public static partial byte igColorEdit3(byte* label, Vector3* col, ImGuiColorEditFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igColorEdit4(byte* label, Vector4* col, ImGuiColorEditFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igColorPicker3(byte* label, Vector3* col, ImGuiColorEditFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igColorPicker4(byte* label, Vector4* col, ImGuiColorEditFlags flags, float* ref_col);
        [LibraryImport("cimgui")]
        public static partial void igColumns(int count, byte* id, byte border);
        [LibraryImport("cimgui")]
        public static partial byte igCombo_Str_arr(byte* label, int* current_item, byte** items, int items_count, int popup_max_height_in_items);
        [LibraryImport("cimgui")]
        public static partial byte igCombo_Str(byte* label, int* current_item, byte* items_separated_by_zeros, int popup_max_height_in_items);
        [LibraryImport("cimgui")]
        public static partial IntPtr igCreateContext(ImFontAtlas* shared_font_atlas);
        [LibraryImport("cimgui")]
        public static partial byte igDebugCheckVersionAndDataLayout(byte* version_str, uint sz_io, uint sz_style, uint sz_vec2, uint sz_vec4, uint sz_drawvert, uint sz_drawidx);
        [LibraryImport("cimgui")]
        public static partial void igDestroyContext(IntPtr ctx);
        [LibraryImport("cimgui")]
        public static partial byte igDragFloat(byte* label, float* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igDragFloat2(byte* label, Vector2* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igDragFloat3(byte* label, Vector3* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igDragFloat4(byte* label, Vector4* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igDragFloatRange2(byte* label, float* v_current_min, float* v_current_max, float v_speed, float v_min, float v_max, byte* format, byte* format_max, ImGuiSliderFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igDragInt(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igDragInt2(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igDragInt3(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igDragInt4(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igDragIntRange2(byte* label, int* v_current_min, int* v_current_max, float v_speed, int v_min, int v_max, byte* format, byte* format_max, ImGuiSliderFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igDragScalar(byte* label, ImGuiDataType data_type, void* p_data, float v_speed, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igDragScalarN(byte* label, ImGuiDataType data_type, void* p_data, int components, float v_speed, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
        [LibraryImport("cimgui")]
        public static partial void igDummy(Vector2 size);
        [LibraryImport("cimgui")]
        public static partial void igEnd();
        [LibraryImport("cimgui")]
        public static partial void igEndChild();
        [LibraryImport("cimgui")]
        public static partial void igEndChildFrame();
        [LibraryImport("cimgui")]
        public static partial void igEndCombo();
        [LibraryImport("cimgui")]
        public static partial void igEndDragDropSource();
        [LibraryImport("cimgui")]
        public static partial void igEndDragDropTarget();
        [LibraryImport("cimgui")]
        public static partial void igEndFrame();
        [LibraryImport("cimgui")]
        public static partial void igEndGroup();
        [LibraryImport("cimgui")]
        public static partial void igEndMainMenuBar();
        [LibraryImport("cimgui")]
        public static partial void igEndMenu();
        [LibraryImport("cimgui")]
        public static partial void igEndMenuBar();
        [LibraryImport("cimgui")]
        public static partial void igEndPopup();
        [LibraryImport("cimgui")]
        public static partial void igEndTabBar();
        [LibraryImport("cimgui")]
        public static partial void igEndTabItem();
        [LibraryImport("cimgui")]
        public static partial void igEndTable();
        [LibraryImport("cimgui")]
        public static partial void igEndTooltip();
        [LibraryImport("cimgui")]
        public static partial ImDrawList* igGetBackgroundDrawList();
        [LibraryImport("cimgui")]
        public static partial byte* igGetClipboardText();
        [LibraryImport("cimgui")]
        public static partial uint igGetColorU32_Col(ImGuiCol idx, float alpha_mul);
        [LibraryImport("cimgui")]
        public static partial uint igGetColorU32_Vec4(Vector4 col);
        [LibraryImport("cimgui")]
        public static partial uint igGetColorU32_U32(uint col);
        [LibraryImport("cimgui")]
        public static partial int igGetColumnIndex();
        [LibraryImport("cimgui")]
        public static partial float igGetColumnOffset(int column_index);
        [LibraryImport("cimgui")]
        public static partial int igGetColumnsCount();
        [LibraryImport("cimgui")]
        public static partial float igGetColumnWidth(int column_index);
        [LibraryImport("cimgui")]
        public static partial void igGetContentRegionAvail(Vector2* pOut);
        [LibraryImport("cimgui")]
        public static partial void igGetContentRegionMax(Vector2* pOut);
        [LibraryImport("cimgui")]
        public static partial IntPtr igGetCurrentContext();
        [LibraryImport("cimgui")]
        public static partial void igGetCursorPos(Vector2* pOut);
        [LibraryImport("cimgui")]
        public static partial float igGetCursorPosX();
        [LibraryImport("cimgui")]
        public static partial float igGetCursorPosY();
        [LibraryImport("cimgui")]
        public static partial void igGetCursorScreenPos(Vector2* pOut);
        [LibraryImport("cimgui")]
        public static partial void igGetCursorStartPos(Vector2* pOut);
        [LibraryImport("cimgui")]
        public static partial ImGuiPayload* igGetDragDropPayload();
        [LibraryImport("cimgui")]
        public static partial ImDrawData* igGetDrawData();
        [LibraryImport("cimgui")]
        public static partial IntPtr igGetDrawListSharedData();
        [LibraryImport("cimgui")]
        public static partial ImFont* igGetFont();
        [LibraryImport("cimgui")]
        public static partial float igGetFontSize();
        [LibraryImport("cimgui")]
        public static partial void igGetFontTexUvWhitePixel(Vector2* pOut);
        [LibraryImport("cimgui")]
        public static partial ImDrawList* igGetForegroundDrawList_Nil();
        [LibraryImport("cimgui")]
        public static partial int igGetFrameCount();
        [LibraryImport("cimgui")]
        public static partial float igGetFrameHeight();
        [LibraryImport("cimgui")]
        public static partial float igGetFrameHeightWithSpacing();
        [LibraryImport("cimgui")]
        public static partial uint igGetID_Str(byte* str_id);
        [LibraryImport("cimgui")]
        public static partial uint igGetID_StrStr(byte* str_id_begin, byte* str_id_end);
        [LibraryImport("cimgui")]
        public static partial uint igGetID_Ptr(void* ptr_id);
        [LibraryImport("cimgui")]
        public static partial ImGuiIO* igGetIO();
        [LibraryImport("cimgui")]
        public static partial void igGetItemRectMax(Vector2* pOut);
        [LibraryImport("cimgui")]
        public static partial void igGetItemRectMin(Vector2* pOut);
        [LibraryImport("cimgui")]
        public static partial void igGetItemRectSize(Vector2* pOut);
        [LibraryImport("cimgui")]
        public static partial int igGetKeyIndex(ImGuiKey imgui_key);
        [LibraryImport("cimgui")]
        public static partial int igGetKeyPressedAmount(int key_index, float repeat_delay, float rate);
        [LibraryImport("cimgui")]
        public static partial ImGuiMouseCursor igGetMouseCursor();
        [LibraryImport("cimgui")]
        public static partial void igGetMouseDragDelta(Vector2* pOut, ImGuiMouseButton button, float lock_threshold);
        [LibraryImport("cimgui")]
        public static partial void igGetMousePos(Vector2* pOut);
        [LibraryImport("cimgui")]
        public static partial void igGetMousePosOnOpeningCurrentPopup(Vector2* pOut);
        [LibraryImport("cimgui")]
        public static partial float igGetScrollMaxX();
        [LibraryImport("cimgui")]
        public static partial float igGetScrollMaxY();
        [LibraryImport("cimgui")]
        public static partial float igGetScrollX();
        [LibraryImport("cimgui")]
        public static partial float igGetScrollY();
        [LibraryImport("cimgui")]
        public static partial ImGuiStorage* igGetStateStorage();
        [LibraryImport("cimgui")]
        public static partial ImGuiStyle* igGetStyle();
        [LibraryImport("cimgui")]
        public static partial byte* igGetStyleColorName(ImGuiCol idx);
        [LibraryImport("cimgui")]
        public static partial Vector4* igGetStyleColorVec4(ImGuiCol idx);
        [LibraryImport("cimgui")]
        public static partial float igGetTextLineHeight();
        [LibraryImport("cimgui")]
        public static partial float igGetTextLineHeightWithSpacing();
        [LibraryImport("cimgui")]
        public static partial double igGetTime();
        [LibraryImport("cimgui")]
        public static partial float igGetTreeNodeToLabelSpacing();
        [LibraryImport("cimgui")]
        public static partial byte* igGetVersion();
        [LibraryImport("cimgui")]
        public static partial void igGetWindowContentRegionMax(Vector2* pOut);
        [LibraryImport("cimgui")]
        public static partial void igGetWindowContentRegionMin(Vector2* pOut);
        [LibraryImport("cimgui")]
        public static partial float igGetWindowContentRegionWidth();
        [LibraryImport("cimgui")]
        public static partial ImDrawList* igGetWindowDrawList();
        [LibraryImport("cimgui")]
        public static partial float igGetWindowHeight();
        [LibraryImport("cimgui")]
        public static partial void igGetWindowPos(Vector2* pOut);
        [LibraryImport("cimgui")]
        public static partial void igGetWindowSize(Vector2* pOut);
        [LibraryImport("cimgui")]
        public static partial float igGetWindowWidth();
        [LibraryImport("cimgui")]
        public static partial void igImage(IntPtr user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, Vector4 tint_col, Vector4 border_col);
        [LibraryImport("cimgui")]
        public static partial byte igImageButton(IntPtr user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, int frame_padding, Vector4 bg_col, Vector4 tint_col);
        [LibraryImport("cimgui")]
        public static partial void igIndent(float indent_w);
        [LibraryImport("cimgui")]
        public static partial byte igInputDouble(byte* label, double* v, double step, double step_fast, byte* format, ImGuiInputTextFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igInputFloat(byte* label, float* v, float step, float step_fast, byte* format, ImGuiInputTextFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igInputFloat2(byte* label, Vector2* v, byte* format, ImGuiInputTextFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igInputFloat3(byte* label, Vector3* v, byte* format, ImGuiInputTextFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igInputFloat4(byte* label, Vector4* v, byte* format, ImGuiInputTextFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igInputInt(byte* label, int* v, int step, int step_fast, ImGuiInputTextFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igInputInt2(byte* label, int* v, ImGuiInputTextFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igInputInt3(byte* label, int* v, ImGuiInputTextFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igInputInt4(byte* label, int* v, ImGuiInputTextFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igInputScalar(byte* label, ImGuiDataType data_type, void* p_data, void* p_step, void* p_step_fast, byte* format, ImGuiInputTextFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igInputScalarN(byte* label, ImGuiDataType data_type, void* p_data, int components, void* p_step, void* p_step_fast, byte* format, ImGuiInputTextFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igInputText(byte* label, byte* buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data);
        [LibraryImport("cimgui")]
        public static partial byte igInputTextMultiline(byte* label, byte* buf, uint buf_size, Vector2 size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data);
        [LibraryImport("cimgui")]
        public static partial byte igInputTextWithHint(byte* label, byte* hint, byte* buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data);
        [LibraryImport("cimgui")]
        public static partial byte igInvisibleButton(byte* str_id, Vector2 size, ImGuiButtonFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igIsAnyItemActive();
        [LibraryImport("cimgui")]
        public static partial byte igIsAnyItemFocused();
        [LibraryImport("cimgui")]
        public static partial byte igIsAnyItemHovered();
        [LibraryImport("cimgui")]
        public static partial byte igIsAnyMouseDown();
        [LibraryImport("cimgui")]
        public static partial byte igIsItemActivated();
        [LibraryImport("cimgui")]
        public static partial byte igIsItemActive();
        [LibraryImport("cimgui")]
        public static partial byte igIsItemClicked(ImGuiMouseButton mouse_button);
        [LibraryImport("cimgui")]
        public static partial byte igIsItemDeactivated();
        [LibraryImport("cimgui")]
        public static partial byte igIsItemDeactivatedAfterEdit();
        [LibraryImport("cimgui")]
        public static partial byte igIsItemEdited();
        [LibraryImport("cimgui")]
        public static partial byte igIsItemFocused();
        [LibraryImport("cimgui")]
        public static partial byte igIsItemHovered(ImGuiHoveredFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igIsItemToggledOpen();
        [LibraryImport("cimgui")]
        public static partial byte igIsItemVisible();
        [LibraryImport("cimgui")]
        public static partial byte igIsKeyDown(int user_key_index);
        [LibraryImport("cimgui")]
        public static partial byte igIsKeyPressed(int user_key_index, byte repeat);
        [LibraryImport("cimgui")]
        public static partial byte igIsKeyReleased(int user_key_index);
        [LibraryImport("cimgui")]
        public static partial byte igIsMouseClicked(ImGuiMouseButton button, byte repeat);
        [LibraryImport("cimgui")]
        public static partial byte igIsMouseDoubleClicked(ImGuiMouseButton button);
        [LibraryImport("cimgui")]
        public static partial byte igIsMouseDown(ImGuiMouseButton button);
        [LibraryImport("cimgui")]
        public static partial byte igIsMouseDragging(ImGuiMouseButton button, float lock_threshold);
        [LibraryImport("cimgui")]
        public static partial byte igIsMouseHoveringRect(Vector2 r_min, Vector2 r_max, byte clip);
        [LibraryImport("cimgui")]
        public static partial byte igIsMousePosValid(Vector2* mouse_pos);
        [LibraryImport("cimgui")]
        public static partial byte igIsMouseReleased(ImGuiMouseButton button);
        [LibraryImport("cimgui")]
        public static partial byte igIsPopupOpen_Str(byte* str_id, ImGuiPopupFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igIsRectVisible_Nil(Vector2 size);
        [LibraryImport("cimgui")]
        public static partial byte igIsRectVisible_Vec2(Vector2 rect_min, Vector2 rect_max);
        [LibraryImport("cimgui")]
        public static partial byte igIsWindowAppearing();
        [LibraryImport("cimgui")]
        public static partial byte igIsWindowCollapsed();
        [LibraryImport("cimgui")]
        public static partial byte igIsWindowFocused(ImGuiFocusedFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igIsWindowHovered(ImGuiHoveredFlags flags);
        [LibraryImport("cimgui")]
        public static partial void igLabelText(byte* label, byte* fmt);
        [LibraryImport("cimgui")]
        public static partial byte igListBox_Str_arr(byte* label, int* current_item, byte** items, int items_count, int height_in_items);
        [LibraryImport("cimgui")]
        public static partial void igListBoxFooter();
        [LibraryImport("cimgui")]
        public static partial byte igListBoxHeader_Vec2(byte* label, Vector2 size);
        [LibraryImport("cimgui")]
        public static partial byte igListBoxHeader_Int(byte* label, int items_count, int height_in_items);
        [LibraryImport("cimgui")]
        public static partial void igLoadIniSettingsFromDisk(byte* ini_filename);
        [LibraryImport("cimgui")]
        public static partial void igLoadIniSettingsFromMemory(byte* ini_data, uint ini_size);
        [LibraryImport("cimgui")]
        public static partial void igLogButtons();
        [LibraryImport("cimgui")]
        public static partial void igLogFinish();
        [LibraryImport("cimgui")]
        public static partial void igLogText(byte* fmt);
        [LibraryImport("cimgui")]
        public static partial void igLogToClipboard(int auto_open_depth);
        [LibraryImport("cimgui")]
        public static partial void igLogToFile(int auto_open_depth, byte* filename);
        [LibraryImport("cimgui")]
        public static partial void igLogToTTY(int auto_open_depth);
        [LibraryImport("cimgui")]
        public static partial void* igMemAlloc(uint size);
        [LibraryImport("cimgui")]
        public static partial void igMemFree(void* ptr);
        [LibraryImport("cimgui")]
        public static partial byte igMenuItem_Bool(byte* label, byte* shortcut, byte selected, byte enabled);
        [LibraryImport("cimgui")]
        public static partial byte igMenuItem_BoolPtr(byte* label, byte* shortcut, byte* p_selected, byte enabled);
        [LibraryImport("cimgui")]
        public static partial void igNewFrame();
        [LibraryImport("cimgui")]
        public static partial void igNewLine();
        [LibraryImport("cimgui")]
        public static partial void igNextColumn();
        [LibraryImport("cimgui")]
        public static partial void igOpenPopup(byte* str_id, ImGuiPopupFlags popup_flags);
        [LibraryImport("cimgui")]
        public static partial void igOpenPopupOnItemClick(byte* str_id, ImGuiPopupFlags popup_flags);
        [LibraryImport("cimgui")]
        public static partial void igPlotHistogram_FloatPtr(byte* label, float* values, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride);
        [LibraryImport("cimgui")]
        public static partial void igPlotLines_FloatPtr(byte* label, float* values, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride);
        [LibraryImport("cimgui")]
        public static partial void igPopAllowKeyboardFocus();
        [LibraryImport("cimgui")]
        public static partial void igPopButtonRepeat();
        [LibraryImport("cimgui")]
        public static partial void igPopClipRect();
        [LibraryImport("cimgui")]
        public static partial void igPopFont();
        [LibraryImport("cimgui")]
        public static partial void igPopID();
        [LibraryImport("cimgui")]
        public static partial void igPopItemWidth();
        [LibraryImport("cimgui")]
        public static partial void igPopStyleColor(int count);
        [LibraryImport("cimgui")]
        public static partial void igPopStyleVar(int count);
        [LibraryImport("cimgui")]
        public static partial void igPopTextWrapPos();
        [LibraryImport("cimgui")]
        public static partial void igProgressBar(float fraction, Vector2 size_arg, byte* overlay);
        [LibraryImport("cimgui")]
        public static partial void igPushAllowKeyboardFocus(byte allow_keyboard_focus);
        [LibraryImport("cimgui")]
        public static partial void igPushButtonRepeat(byte repeat);
        [LibraryImport("cimgui")]
        public static partial void igPushClipRect(Vector2 clip_rect_min, Vector2 clip_rect_max, byte intersect_with_current_clip_rect);
        [LibraryImport("cimgui")]
        public static partial void igPushFont(ImFont* font);
        [LibraryImport("cimgui")]
        public static partial void igPushID_Str(byte* str_id);
        [LibraryImport("cimgui")]
        public static partial void igPushID_StrStr(byte* str_id_begin, byte* str_id_end);
        [LibraryImport("cimgui")]
        public static partial void igPushID_Ptr(void* ptr_id);
        [LibraryImport("cimgui")]
        public static partial void igPushID_Int(int int_id);
        [LibraryImport("cimgui")]
        public static partial void igPushItemWidth(float item_width);
        [LibraryImport("cimgui")]
        public static partial void igPushStyleColor_U32(ImGuiCol idx, uint col);
        [LibraryImport("cimgui")]
        public static partial void igPushStyleColor_Vec4(ImGuiCol idx, Vector4 col);
        [LibraryImport("cimgui")]
        public static partial void igPushStyleVar_Float(ImGuiStyleVar idx, float val);
        [LibraryImport("cimgui")]
        public static partial void igPushStyleVar_Vec2(ImGuiStyleVar idx, Vector2 val);
        [LibraryImport("cimgui")]
        public static partial void igPushTextWrapPos(float wrap_local_pos_x);
        [LibraryImport("cimgui")]
        public static partial byte igRadioButton_Bool(byte* label, byte active);
        [LibraryImport("cimgui")]
        public static partial byte igRadioButton_IntPtr(byte* label, int* v, int v_button);
        [LibraryImport("cimgui")]
        public static partial void igRender();
        [LibraryImport("cimgui")]
        public static partial void igResetMouseDragDelta(ImGuiMouseButton button);
        [LibraryImport("cimgui")]
        public static partial void igSameLine(float offset_from_start_x, float spacing);
        [LibraryImport("cimgui")]
        public static partial void igSaveIniSettingsToDisk(byte* ini_filename);
        [LibraryImport("cimgui")]
        public static partial byte* igSaveIniSettingsToMemory(uint* out_ini_size);
        [LibraryImport("cimgui")]
        public static partial byte igSelectable_Bool(byte* label, byte selected, ImGuiSelectableFlags flags, Vector2 size);
        [LibraryImport("cimgui")]
        public static partial byte igSelectable_BoolPtr(byte* label, byte* p_selected, ImGuiSelectableFlags flags, Vector2 size);
        [LibraryImport("cimgui")]
        public static partial void igSeparator();
        [LibraryImport("cimgui")]
        public static partial void igSetAllocatorFunctions(IntPtr alloc_func, IntPtr free_func, void* user_data);
        [LibraryImport("cimgui")]
        public static partial void igSetClipboardText(byte* text);
        [LibraryImport("cimgui")]
        public static partial void igSetColorEditOptions(ImGuiColorEditFlags flags);
        [LibraryImport("cimgui")]
        public static partial void igSetColumnOffset(int column_index, float offset_x);
        [LibraryImport("cimgui")]
        public static partial void igSetColumnWidth(int column_index, float width);
        [LibraryImport("cimgui")]
        public static partial void igSetCurrentContext(IntPtr ctx);
        [LibraryImport("cimgui")]
        public static partial void igSetCursorPos(Vector2 local_pos);
        [LibraryImport("cimgui")]
        public static partial void igSetCursorPosX(float local_x);
        [LibraryImport("cimgui")]
        public static partial void igSetCursorPosY(float local_y);
        [LibraryImport("cimgui")]
        public static partial void igSetCursorScreenPos(Vector2 pos);
        [LibraryImport("cimgui")]
        public static partial byte igSetDragDropPayload(byte* type, void* data, uint sz, ImGuiCond cond);
        [LibraryImport("cimgui")]
        public static partial void igSetItemAllowOverlap();
        [LibraryImport("cimgui")]
        public static partial void igSetItemDefaultFocus();
        [LibraryImport("cimgui")]
        public static partial void igSetKeyboardFocusHere(int offset);
        [LibraryImport("cimgui")]
        public static partial void igSetMouseCursor(ImGuiMouseCursor cursor_type);
        [LibraryImport("cimgui")]
        public static partial void igSetNextItemOpen(byte is_open, ImGuiCond cond);
        [LibraryImport("cimgui")]
        public static partial void igSetNextItemWidth(float item_width);
        [LibraryImport("cimgui")]
        public static partial void igSetNextWindowBgAlpha(float alpha);
        [LibraryImport("cimgui")]
        public static partial void igSetNextWindowCollapsed(byte collapsed, ImGuiCond cond);
        [LibraryImport("cimgui")]
        public static partial void igSetNextWindowContentSize(Vector2 size);
        [LibraryImport("cimgui")]
        public static partial void igSetNextWindowFocus();
        [LibraryImport("cimgui")]
        public static partial void igSetNextWindowPos(Vector2 pos, ImGuiCond cond, Vector2 pivot);
        [LibraryImport("cimgui")]
        public static partial void igSetNextWindowSize(Vector2 size, ImGuiCond cond);
        [LibraryImport("cimgui")]
        public static partial void igSetNextWindowSizeConstraints(Vector2 size_min, Vector2 size_max, ImGuiSizeCallback custom_callback, void* custom_callback_data);
        [LibraryImport("cimgui")]
        public static partial void igSetScrollFromPosX_Float(float local_x, float center_x_ratio);
        [LibraryImport("cimgui")]
        public static partial void igSetScrollFromPosY_Float(float local_y, float center_y_ratio);
        [LibraryImport("cimgui")]
        public static partial void igSetScrollHereX(float center_x_ratio);
        [LibraryImport("cimgui")]
        public static partial void igSetScrollHereY(float center_y_ratio);
        [LibraryImport("cimgui")]
        public static partial void igSetScrollX_Float(float scroll_x);
        [LibraryImport("cimgui")]
        public static partial void igSetScrollY_Float(float scroll_y);
        [LibraryImport("cimgui")]
        public static partial void igSetStateStorage(ImGuiStorage* storage);
        [LibraryImport("cimgui")]
        public static partial void igSetTabItemClosed(byte* tab_or_docked_window_label);
        [LibraryImport("cimgui")]
        public static partial void igSetTooltip(byte* fmt);
        [LibraryImport("cimgui")]
        public static partial void igSetWindowCollapsed_Bool(byte collapsed, ImGuiCond cond);
        [LibraryImport("cimgui")]
        public static partial void igSetWindowCollapsed_Str(byte* name, byte collapsed, ImGuiCond cond);
        [LibraryImport("cimgui")]
        public static partial void igSetWindowFocus_Nil();
        [LibraryImport("cimgui")]
        public static partial void igSetWindowFocus_Str(byte* name);
        [LibraryImport("cimgui")]
        public static partial void igSetWindowFontScale(float scale);
        [LibraryImport("cimgui")]
        public static partial void igSetWindowPos_Vec2(Vector2 pos, ImGuiCond cond);
        [LibraryImport("cimgui")]
        public static partial void igSetWindowPos_Str(byte* name, Vector2 pos, ImGuiCond cond);
        [LibraryImport("cimgui")]
        public static partial void igSetWindowSize_Vec2(Vector2 size, ImGuiCond cond);
        [LibraryImport("cimgui")]
        public static partial void igSetWindowSize_Str(byte* name, Vector2 size, ImGuiCond cond);
        [LibraryImport("cimgui")]
        public static partial void igShowAboutWindow(byte* p_open);
        [LibraryImport("cimgui")]
        public static partial void igShowDemoWindow(byte* p_open);
        [LibraryImport("cimgui")]
        public static partial void igShowFontSelector(byte* label);
        [LibraryImport("cimgui")]
        public static partial void igShowMetricsWindow(byte* p_open);
        [LibraryImport("cimgui")]
        public static partial void igShowStyleEditor(ImGuiStyle* @ref);
        [LibraryImport("cimgui")]
        public static partial byte igShowStyleSelector(byte* label);
        [LibraryImport("cimgui")]
        public static partial void igShowUserGuide();
        [LibraryImport("cimgui")]
        public static partial byte igSliderAngle(byte* label, float* v_rad, float v_degrees_min, float v_degrees_max, byte* format, ImGuiSliderFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igSliderFloat(byte* label, float* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igSliderFloat2(byte* label, Vector2* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igSliderFloat3(byte* label, Vector3* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igSliderFloat4(byte* label, Vector4* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igSliderInt(byte* label, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igSliderInt2(byte* label, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igSliderInt3(byte* label, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igSliderInt4(byte* label, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igSliderScalar(byte* label, ImGuiDataType data_type, void* p_data, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igSliderScalarN(byte* label, ImGuiDataType data_type, void* p_data, int components, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igSmallButton(byte* label);
        [LibraryImport("cimgui")]
        public static partial void igSpacing();
        [LibraryImport("cimgui")]
        public static partial void igStyleColorsClassic(ImGuiStyle* dst);
        [LibraryImport("cimgui")]
        public static partial void igStyleColorsDark(ImGuiStyle* dst);
        [LibraryImport("cimgui")]
        public static partial void igStyleColorsLight(ImGuiStyle* dst);
        [LibraryImport("cimgui")]
        public static partial byte igTabItemButton(byte* label, ImGuiTabItemFlags flags);
        [LibraryImport("cimgui")]
        public static partial int igTableGetColumnCount();
        [LibraryImport("cimgui")]
        public static partial ImGuiTableColumnFlags igTableGetColumnFlags(int column_n);
        [LibraryImport("cimgui")]
        public static partial int igTableGetColumnIndex();
        [LibraryImport("cimgui")]
        public static partial byte* igTableGetColumnName_Int(int column_n);
        [LibraryImport("cimgui")]
        public static partial int igTableGetRowIndex();
        [LibraryImport("cimgui")]
        public static partial ImGuiTableSortSpecs* igTableGetSortSpecs();
        [LibraryImport("cimgui")]
        public static partial void igTableHeader(byte* label);
        [LibraryImport("cimgui")]
        public static partial void igTableHeadersRow();
        [LibraryImport("cimgui")]
        public static partial byte igTableNextColumn();
        [LibraryImport("cimgui")]
        public static partial void igTableNextRow(ImGuiTableRowFlags row_flags, float min_row_height);
        [LibraryImport("cimgui")]
        public static partial void igTableSetBgColor(ImGuiTableBgTarget target, uint color, int column_n);
        [LibraryImport("cimgui")]
        public static partial byte igTableSetColumnIndex(int column_n);
        [LibraryImport("cimgui")]
        public static partial void igTableSetupColumn(byte* label, ImGuiTableColumnFlags flags, float init_width_or_weight, uint user_id);
        [LibraryImport("cimgui")]
        public static partial void igTableSetupScrollFreeze(int cols, int rows);
        [LibraryImport("cimgui")]
        public static partial void igText(byte* fmt);
        [LibraryImport("cimgui")]
        public static partial void igTextColored(Vector4 col, byte* fmt);
        [LibraryImport("cimgui")]
        public static partial void igTextDisabled(byte* fmt);
        [LibraryImport("cimgui")]
        public static partial void igTextUnformatted(byte* text, byte* text_end);
        [LibraryImport("cimgui")]
        public static partial void igTextWrapped(byte* fmt);
        [LibraryImport("cimgui")]
        public static partial byte igTreeNode_Str(byte* label);
        [LibraryImport("cimgui")]
        public static partial byte igTreeNode_StrStr(byte* str_id, byte* fmt);
        [LibraryImport("cimgui")]
        public static partial byte igTreeNode_Ptr(void* ptr_id, byte* fmt);
        [LibraryImport("cimgui")]
        public static partial byte igTreeNodeEx_Str(byte* label, ImGuiTreeNodeFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igTreeNodeEx_StrStr(byte* str_id, ImGuiTreeNodeFlags flags, byte* fmt);
        [LibraryImport("cimgui")]
        public static partial byte igTreeNodeEx_Ptr(void* ptr_id, ImGuiTreeNodeFlags flags, byte* fmt);
        [LibraryImport("cimgui")]
        public static partial void igTreePop();
        [LibraryImport("cimgui")]
        public static partial void igTreePush_Str(byte* str_id);
        [LibraryImport("cimgui")]
        public static partial void igTreePush_Ptr(void* ptr_id);
        [LibraryImport("cimgui")]
        public static partial void igUnindent(float indent_w);
        [LibraryImport("cimgui")]
        public static partial void igValue_Bool(byte* prefix, byte b);
        [LibraryImport("cimgui")]
        public static partial void igValue_Int(byte* prefix, int v);
        [LibraryImport("cimgui")]
        public static partial void igValue_Uint(byte* prefix, uint v);
        [LibraryImport("cimgui")]
        public static partial void igValue_Float(byte* prefix, float v, byte* float_format);
        [LibraryImport("cimgui")]
        public static partial byte igVSliderFloat(byte* label, Vector2 size, float* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igVSliderInt(byte* label, Vector2 size, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [LibraryImport("cimgui")]
        public static partial byte igVSliderScalar(byte* label, Vector2 size, ImGuiDataType data_type, void* p_data, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
        [LibraryImport("cimgui")]
        public static partial void ImColor_destroy(ImColor* self);
        [LibraryImport("cimgui")]
        public static partial void ImColor_HSV(ImColor* pOut, float h, float s, float v, float a);
        [LibraryImport("cimgui")]
        public static partial ImColor* ImColor_ImColor_Nil();
        [LibraryImport("cimgui")]
        public static partial ImColor* ImColor_ImColor_Int(int r, int g, int b, int a);
        [LibraryImport("cimgui")]
        public static partial ImColor* ImColor_ImColor_U32(uint rgba);
        [LibraryImport("cimgui")]
        public static partial ImColor* ImColor_ImColor_Float(float r, float g, float b, float a);
        [LibraryImport("cimgui")]
        public static partial ImColor* ImColor_ImColor_Vec4(Vector4 col);
        [LibraryImport("cimgui")]
        public static partial void ImColor_SetHSV(ImColor* self, float h, float s, float v, float a);
        [LibraryImport("cimgui")]
        public static partial void ImDrawCmd_destroy(ImDrawCmd* self);
        [LibraryImport("cimgui")]
        public static partial ImDrawCmd* ImDrawCmd_ImDrawCmd();
        [LibraryImport("cimgui")]
        public static partial void ImDrawData_Clear(ImDrawData* self);
        [LibraryImport("cimgui")]
        public static partial void ImDrawData_DeIndexAllBuffers(ImDrawData* self);
        [LibraryImport("cimgui")]
        public static partial void ImDrawData_destroy(ImDrawData* self);
        [LibraryImport("cimgui")]
        public static partial ImDrawData* ImDrawData_ImDrawData();
        [LibraryImport("cimgui")]
        public static partial void ImDrawData_ScaleClipRects(ImDrawData* self, Vector2 fb_scale);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList__ClearFreeMemory(ImDrawList* self);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList__OnChangedClipRect(ImDrawList* self);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList__OnChangedTextureID(ImDrawList* self);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList__OnChangedVtxOffset(ImDrawList* self);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList__PopUnusedDrawCmd(ImDrawList* self);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList__ResetForNewFrame(ImDrawList* self);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_AddBezierCubic(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness, int num_segments);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_AddBezierQuadratic(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col, float thickness, int num_segments);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_AddCallback(ImDrawList* self, IntPtr callback, void* callback_data);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_AddCircle(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments, float thickness);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_AddCircleFilled(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_AddConvexPolyFilled(ImDrawList* self, Vector2* points, int num_points, uint col);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_AddDrawCmd(ImDrawList* self);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_AddImage(ImDrawList* self, IntPtr user_texture_id, Vector2 p_min, Vector2 p_max, Vector2 uv_min, Vector2 uv_max, uint col);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_AddImageQuad(ImDrawList* self, IntPtr user_texture_id, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 uv1, Vector2 uv2, Vector2 uv3, Vector2 uv4, uint col);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_AddImageRounded(ImDrawList* self, IntPtr user_texture_id, Vector2 p_min, Vector2 p_max, Vector2 uv_min, Vector2 uv_max, uint col, float rounding, ImDrawCornerFlags rounding_corners);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_AddLine(ImDrawList* self, Vector2 p1, Vector2 p2, uint col, float thickness);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_AddNgon(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments, float thickness);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_AddNgonFilled(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_AddPolyline(ImDrawList* self, Vector2* points, int num_points, uint col, byte closed, float thickness);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_AddQuad(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_AddQuadFilled(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_AddRect(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col, float rounding, ImDrawCornerFlags rounding_corners, float thickness);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_AddRectFilled(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col, float rounding, ImDrawCornerFlags rounding_corners);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_AddRectFilledMultiColor(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col_upr_left, uint col_upr_right, uint col_bot_right, uint col_bot_left);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_AddText_Vec2(ImDrawList* self, Vector2 pos, uint col, byte* text_begin, byte* text_end);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_AddText_FontPtr(ImDrawList* self, ImFont* font, float font_size, Vector2 pos, uint col, byte* text_begin, byte* text_end, float wrap_width, Vector4* cpu_fine_clip_rect);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_AddTriangle(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col, float thickness);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_AddTriangleFilled(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_ChannelsMerge(ImDrawList* self);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_ChannelsSetCurrent(ImDrawList* self, int n);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_ChannelsSplit(ImDrawList* self, int count);
        [LibraryImport("cimgui")]
        public static partial ImDrawList* ImDrawList_CloneOutput(ImDrawList* self);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_destroy(ImDrawList* self);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_GetClipRectMax(Vector2* pOut, ImDrawList* self);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_GetClipRectMin(Vector2* pOut, ImDrawList* self);
        [LibraryImport("cimgui")]
        public static partial ImDrawList* ImDrawList_ImDrawList(IntPtr shared_data);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_PathArcTo(ImDrawList* self, Vector2 center, float radius, float a_min, float a_max, int num_segments);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_PathArcToFast(ImDrawList* self, Vector2 center, float radius, int a_min_of_12, int a_max_of_12);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_PathBezierCubicCurveTo(ImDrawList* self, Vector2 p2, Vector2 p3, Vector2 p4, int num_segments);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_PathBezierQuadraticCurveTo(ImDrawList* self, Vector2 p2, Vector2 p3, int num_segments);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_PathClear(ImDrawList* self);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_PathFillConvex(ImDrawList* self, uint col);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_PathLineTo(ImDrawList* self, Vector2 pos);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_PathLineToMergeDuplicate(ImDrawList* self, Vector2 pos);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_PathRect(ImDrawList* self, Vector2 rect_min, Vector2 rect_max, float rounding, ImDrawCornerFlags rounding_corners);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_PathStroke(ImDrawList* self, uint col, byte closed, float thickness);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_PopClipRect(ImDrawList* self);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_PopTextureID(ImDrawList* self);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_PrimQuadUV(ImDrawList* self, Vector2 a, Vector2 b, Vector2 c, Vector2 d, Vector2 uv_a, Vector2 uv_b, Vector2 uv_c, Vector2 uv_d, uint col);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_PrimRect(ImDrawList* self, Vector2 a, Vector2 b, uint col);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_PrimRectUV(ImDrawList* self, Vector2 a, Vector2 b, Vector2 uv_a, Vector2 uv_b, uint col);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_PrimReserve(ImDrawList* self, int idx_count, int vtx_count);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_PrimUnreserve(ImDrawList* self, int idx_count, int vtx_count);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_PrimVtx(ImDrawList* self, Vector2 pos, Vector2 uv, uint col);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_PrimWriteIdx(ImDrawList* self, ushort idx);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_PrimWriteVtx(ImDrawList* self, Vector2 pos, Vector2 uv, uint col);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_PushClipRect(ImDrawList* self, Vector2 clip_rect_min, Vector2 clip_rect_max, byte intersect_with_current_clip_rect);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_PushClipRectFullScreen(ImDrawList* self);
        [LibraryImport("cimgui")]
        public static partial void ImDrawList_PushTextureID(ImDrawList* self, IntPtr texture_id);
        [LibraryImport("cimgui")]
        public static partial void ImDrawListSplitter_Clear(ImDrawListSplitter* self);
        [LibraryImport("cimgui")]
        public static partial void ImDrawListSplitter_ClearFreeMemory(ImDrawListSplitter* self);
        [LibraryImport("cimgui")]
        public static partial void ImDrawListSplitter_destroy(ImDrawListSplitter* self);
        [LibraryImport("cimgui")]
        public static partial ImDrawListSplitter* ImDrawListSplitter_ImDrawListSplitter();
        [LibraryImport("cimgui")]
        public static partial void ImDrawListSplitter_Merge(ImDrawListSplitter* self, ImDrawList* draw_list);
        [LibraryImport("cimgui")]
        public static partial void ImDrawListSplitter_SetCurrentChannel(ImDrawListSplitter* self, ImDrawList* draw_list, int channel_idx);
        [LibraryImport("cimgui")]
        public static partial void ImDrawListSplitter_Split(ImDrawListSplitter* self, ImDrawList* draw_list, int count);
        [LibraryImport("cimgui")]
        public static partial void ImFont_AddGlyph(ImFont* self, ImFontConfig* src_cfg, ushort c, float x0, float y0, float x1, float y1, float u0, float v0, float u1, float v1, float advance_x);
        [LibraryImport("cimgui")]
        public static partial void ImFont_AddRemapChar(ImFont* self, ushort dst, ushort src, byte overwrite_dst);
        [LibraryImport("cimgui")]
        public static partial void ImFont_BuildLookupTable(ImFont* self);
        [LibraryImport("cimgui")]
        public static partial void ImFont_CalcTextSizeA(Vector2* pOut, ImFont* self, float size, float max_width, float wrap_width, byte* text_begin, byte* text_end, byte** remaining);
        [LibraryImport("cimgui")]
        public static partial byte* ImFont_CalcWordWrapPositionA(ImFont* self, float scale, byte* text, byte* text_end, float wrap_width);
        [LibraryImport("cimgui")]
        public static partial void ImFont_ClearOutputData(ImFont* self);
        [LibraryImport("cimgui")]
        public static partial void ImFont_destroy(ImFont* self);
        [LibraryImport("cimgui")]
        public static partial ImFontGlyph* ImFont_FindGlyph(ImFont* self, ushort c);
        [LibraryImport("cimgui")]
        public static partial ImFontGlyph* ImFont_FindGlyphNoFallback(ImFont* self, ushort c);
        [LibraryImport("cimgui")]
        public static partial float ImFont_GetCharAdvance(ImFont* self, ushort c);
        [LibraryImport("cimgui")]
        public static partial byte* ImFont_GetDebugName(ImFont* self);
        [LibraryImport("cimgui")]
        public static partial void ImFont_GrowIndex(ImFont* self, int new_size);
        [LibraryImport("cimgui")]
        public static partial ImFont* ImFont_ImFont();
        [LibraryImport("cimgui")]
        public static partial byte ImFont_IsGlyphRangeUnused(ImFont* self, uint c_begin, uint c_last);
        [LibraryImport("cimgui")]
        public static partial byte ImFont_IsLoaded(ImFont* self);
        [LibraryImport("cimgui")]
        public static partial void ImFont_RenderChar(ImFont* self, ImDrawList* draw_list, float size, Vector2 pos, uint col, ushort c);
        [LibraryImport("cimgui")]
        public static partial void ImFont_RenderText(ImFont* self, ImDrawList* draw_list, float size, Vector2 pos, uint col, Vector4 clip_rect, byte* text_begin, byte* text_end, float wrap_width, byte cpu_fine_clip);
        [LibraryImport("cimgui")]
        public static partial void ImFont_SetFallbackChar(ImFont* self, ushort c);
        [LibraryImport("cimgui")]
        public static partial void ImFont_SetGlyphVisible(ImFont* self, ushort c, byte visible);
        [LibraryImport("cimgui")]
        public static partial int ImFontAtlas_AddCustomRectFontGlyph(ImFontAtlas* self, ImFont* font, ushort id, int width, int height, float advance_x, Vector2 offset);
        [LibraryImport("cimgui")]
        public static partial int ImFontAtlas_AddCustomRectRegular(ImFontAtlas* self, int width, int height);
        [LibraryImport("cimgui")]
        public static partial ImFont* ImFontAtlas_AddFont(ImFontAtlas* self, ImFontConfig* font_cfg);
        [LibraryImport("cimgui")]
        public static partial ImFont* ImFontAtlas_AddFontDefault(ImFontAtlas* self, ImFontConfig* font_cfg);
        [LibraryImport("cimgui")]
        public static partial ImFont* ImFontAtlas_AddFontFromFileTTF(ImFontAtlas* self, byte* filename, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);
        [LibraryImport("cimgui")]
        public static partial ImFont* ImFontAtlas_AddFontFromMemoryCompressedBase85TTF(ImFontAtlas* self, byte* compressed_font_data_base85, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);
        [LibraryImport("cimgui")]
        public static partial ImFont* ImFontAtlas_AddFontFromMemoryCompressedTTF(ImFontAtlas* self, void* compressed_font_data, int compressed_font_size, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);
        [LibraryImport("cimgui")]
        public static partial ImFont* ImFontAtlas_AddFontFromMemoryTTF(ImFontAtlas* self, void* font_data, int font_size, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);
        [LibraryImport("cimgui")]
        public static partial byte ImFontAtlas_Build(ImFontAtlas* self);
        [LibraryImport("cimgui")]
        public static partial void ImFontAtlas_CalcCustomRectUV(ImFontAtlas* self, ImFontAtlasCustomRect* rect, Vector2* out_uv_min, Vector2* out_uv_max);
        [LibraryImport("cimgui")]
        public static partial void ImFontAtlas_Clear(ImFontAtlas* self);
        [LibraryImport("cimgui")]
        public static partial void ImFontAtlas_ClearFonts(ImFontAtlas* self);
        [LibraryImport("cimgui")]
        public static partial void ImFontAtlas_ClearInputData(ImFontAtlas* self);
        [LibraryImport("cimgui")]
        public static partial void ImFontAtlas_ClearTexData(ImFontAtlas* self);
        [LibraryImport("cimgui")]
        public static partial void ImFontAtlas_destroy(ImFontAtlas* self);
        [LibraryImport("cimgui")]
        public static partial ImFontAtlasCustomRect* ImFontAtlas_GetCustomRectByIndex(ImFontAtlas* self, int index);
        [LibraryImport("cimgui")]
        public static partial ushort* ImFontAtlas_GetGlyphRangesChineseFull(ImFontAtlas* self);
        [LibraryImport("cimgui")]
        public static partial ushort* ImFontAtlas_GetGlyphRangesChineseSimplifiedCommon(ImFontAtlas* self);
        [LibraryImport("cimgui")]
        public static partial ushort* ImFontAtlas_GetGlyphRangesCyrillic(ImFontAtlas* self);
        [LibraryImport("cimgui")]
        public static partial ushort* ImFontAtlas_GetGlyphRangesDefault(ImFontAtlas* self);
        [LibraryImport("cimgui")]
        public static partial ushort* ImFontAtlas_GetGlyphRangesJapanese(ImFontAtlas* self);
        [LibraryImport("cimgui")]
        public static partial ushort* ImFontAtlas_GetGlyphRangesKorean(ImFontAtlas* self);
        [LibraryImport("cimgui")]
        public static partial ushort* ImFontAtlas_GetGlyphRangesThai(ImFontAtlas* self);
        [LibraryImport("cimgui")]
        public static partial ushort* ImFontAtlas_GetGlyphRangesVietnamese(ImFontAtlas* self);
        [LibraryImport("cimgui")]
        public static partial byte ImFontAtlas_GetMouseCursorTexData(ImFontAtlas* self, ImGuiMouseCursor cursor, Vector2* out_offset, Vector2* out_size, Vector2* out_uv_border, Vector2* out_uv_fill);
        [LibraryImport("cimgui")]
        public static partial void ImFontAtlas_GetTexDataAsAlpha8(ImFontAtlas* self, byte** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
        [LibraryImport("cimgui")]
        public static partial void ImFontAtlas_GetTexDataAsAlpha8(ImFontAtlas* self, IntPtr* out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
        [LibraryImport("cimgui")]
        public static partial void ImFontAtlas_GetTexDataAsRGBA32(ImFontAtlas* self, byte** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
        [LibraryImport("cimgui")]
        public static partial void ImFontAtlas_GetTexDataAsRGBA32(ImFontAtlas* self, IntPtr* out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
        [LibraryImport("cimgui")]
        public static partial ImFontAtlas* ImFontAtlas_ImFontAtlas();
        [LibraryImport("cimgui")]
        public static partial byte ImFontAtlas_IsBuilt(ImFontAtlas* self);
        [LibraryImport("cimgui")]
        public static partial void ImFontAtlas_SetTexID(ImFontAtlas* self, IntPtr id);
        [LibraryImport("cimgui")]
        public static partial void ImFontAtlasCustomRect_destroy(ImFontAtlasCustomRect* self);
        [LibraryImport("cimgui")]
        public static partial ImFontAtlasCustomRect* ImFontAtlasCustomRect_ImFontAtlasCustomRect();
        [LibraryImport("cimgui")]
        public static partial byte ImFontAtlasCustomRect_IsPacked(ImFontAtlasCustomRect* self);
        [LibraryImport("cimgui")]
        public static partial void ImFontConfig_destroy(ImFontConfig* self);
        [LibraryImport("cimgui")]
        public static partial ImFontConfig* ImFontConfig_ImFontConfig();
        [LibraryImport("cimgui")]
        public static partial void ImFontGlyphRangesBuilder_AddChar(ImFontGlyphRangesBuilder* self, ushort c);
        [LibraryImport("cimgui")]
        public static partial void ImFontGlyphRangesBuilder_AddRanges(ImFontGlyphRangesBuilder* self, ushort* ranges);
        [LibraryImport("cimgui")]
        public static partial void ImFontGlyphRangesBuilder_AddText(ImFontGlyphRangesBuilder* self, byte* text, byte* text_end);
        [LibraryImport("cimgui")]
        public static partial void ImFontGlyphRangesBuilder_BuildRanges(ImFontGlyphRangesBuilder* self, ImVector* out_ranges);
        [LibraryImport("cimgui")]
        public static partial void ImFontGlyphRangesBuilder_Clear(ImFontGlyphRangesBuilder* self);
        [LibraryImport("cimgui")]
        public static partial void ImFontGlyphRangesBuilder_destroy(ImFontGlyphRangesBuilder* self);
        [LibraryImport("cimgui")]
        public static partial byte ImFontGlyphRangesBuilder_GetBit(ImFontGlyphRangesBuilder* self, uint n);
        [LibraryImport("cimgui")]
        public static partial ImFontGlyphRangesBuilder* ImFontGlyphRangesBuilder_ImFontGlyphRangesBuilder();
        [LibraryImport("cimgui")]
        public static partial void ImFontGlyphRangesBuilder_SetBit(ImFontGlyphRangesBuilder* self, uint n);
        [LibraryImport("cimgui")]
        public static partial void ImGuiInputTextCallbackData_ClearSelection(ImGuiInputTextCallbackData* self);
        [LibraryImport("cimgui")]
        public static partial void ImGuiInputTextCallbackData_DeleteChars(ImGuiInputTextCallbackData* self, int pos, int bytes_count);
        [LibraryImport("cimgui")]
        public static partial void ImGuiInputTextCallbackData_destroy(ImGuiInputTextCallbackData* self);
        [LibraryImport("cimgui")]
        public static partial byte ImGuiInputTextCallbackData_HasSelection(ImGuiInputTextCallbackData* self);
        [LibraryImport("cimgui")]
        public static partial ImGuiInputTextCallbackData* ImGuiInputTextCallbackData_ImGuiInputTextCallbackData();
        [LibraryImport("cimgui")]
        public static partial void ImGuiInputTextCallbackData_InsertChars(ImGuiInputTextCallbackData* self, int pos, byte* text, byte* text_end);
        [LibraryImport("cimgui")]
        public static partial void ImGuiInputTextCallbackData_SelectAll(ImGuiInputTextCallbackData* self);
        [LibraryImport("cimgui")]
        public static partial void ImGuiIO_AddInputCharacter(ImGuiIO* self, uint c);
        [LibraryImport("cimgui")]
        public static partial void ImGuiIO_AddInputCharactersUTF8(ImGuiIO* self, byte* str);
        [LibraryImport("cimgui")]
        public static partial void ImGuiIO_AddInputCharacterUTF16(ImGuiIO* self, ushort c);
        [LibraryImport("cimgui")]
        public static partial void ImGuiIO_ClearInputCharacters(ImGuiIO* self);
        [LibraryImport("cimgui")]
        public static partial void ImGuiIO_destroy(ImGuiIO* self);
        [LibraryImport("cimgui")]
        public static partial ImGuiIO* ImGuiIO_ImGuiIO();
        [LibraryImport("cimgui")]
        public static partial void ImGuiListClipper_Begin(ImGuiListClipper* self, int items_count, float items_height);
        [LibraryImport("cimgui")]
        public static partial void ImGuiListClipper_destroy(ImGuiListClipper* self);
        [LibraryImport("cimgui")]
        public static partial void ImGuiListClipper_End(ImGuiListClipper* self);
        [LibraryImport("cimgui")]
        public static partial ImGuiListClipper* ImGuiListClipper_ImGuiListClipper();
        [LibraryImport("cimgui")]
        public static partial byte ImGuiListClipper_Step(ImGuiListClipper* self);
        [LibraryImport("cimgui")]
        public static partial void ImGuiOnceUponAFrame_destroy(ImGuiOnceUponAFrame* self);
        [LibraryImport("cimgui")]
        public static partial ImGuiOnceUponAFrame* ImGuiOnceUponAFrame_ImGuiOnceUponAFrame();
        [LibraryImport("cimgui")]
        public static partial void ImGuiPayload_Clear(ImGuiPayload* self);
        [LibraryImport("cimgui")]
        public static partial void ImGuiPayload_destroy(ImGuiPayload* self);
        [LibraryImport("cimgui")]
        public static partial ImGuiPayload* ImGuiPayload_ImGuiPayload();
        [LibraryImport("cimgui")]
        public static partial byte ImGuiPayload_IsDataType(ImGuiPayload* self, byte* type);
        [LibraryImport("cimgui")]
        public static partial byte ImGuiPayload_IsDelivery(ImGuiPayload* self);
        [LibraryImport("cimgui")]
        public static partial byte ImGuiPayload_IsPreview(ImGuiPayload* self);
        [LibraryImport("cimgui")]
        public static partial void ImGuiStorage_BuildSortByKey(ImGuiStorage* self);
        [LibraryImport("cimgui")]
        public static partial void ImGuiStorage_Clear(ImGuiStorage* self);
        [LibraryImport("cimgui")]
        public static partial byte ImGuiStorage_GetBool(ImGuiStorage* self, uint key, byte default_val);
        [LibraryImport("cimgui")]
        public static partial byte* ImGuiStorage_GetBoolRef(ImGuiStorage* self, uint key, byte default_val);
        [LibraryImport("cimgui")]
        public static partial float ImGuiStorage_GetFloat(ImGuiStorage* self, uint key, float default_val);
        [LibraryImport("cimgui")]
        public static partial float* ImGuiStorage_GetFloatRef(ImGuiStorage* self, uint key, float default_val);
        [LibraryImport("cimgui")]
        public static partial int ImGuiStorage_GetInt(ImGuiStorage* self, uint key, int default_val);
        [LibraryImport("cimgui")]
        public static partial int* ImGuiStorage_GetIntRef(ImGuiStorage* self, uint key, int default_val);
        [LibraryImport("cimgui")]
        public static partial void* ImGuiStorage_GetVoidPtr(ImGuiStorage* self, uint key);
        [LibraryImport("cimgui")]
        public static partial void** ImGuiStorage_GetVoidPtrRef(ImGuiStorage* self, uint key, void* default_val);
        [LibraryImport("cimgui")]
        public static partial void ImGuiStorage_SetAllInt(ImGuiStorage* self, int val);
        [LibraryImport("cimgui")]
        public static partial void ImGuiStorage_SetBool(ImGuiStorage* self, uint key, byte val);
        [LibraryImport("cimgui")]
        public static partial void ImGuiStorage_SetFloat(ImGuiStorage* self, uint key, float val);
        [LibraryImport("cimgui")]
        public static partial void ImGuiStorage_SetInt(ImGuiStorage* self, uint key, int val);
        [LibraryImport("cimgui")]
        public static partial void ImGuiStorage_SetVoidPtr(ImGuiStorage* self, uint key, void* val);
        [LibraryImport("cimgui")]
        public static partial void ImGuiStoragePair_destroy(ImGuiStoragePair* self);
        [LibraryImport("cimgui")]
        public static partial ImGuiStoragePair* ImGuiStoragePair_ImGuiStoragePair_Int(uint _key, int _val_i);
        [LibraryImport("cimgui")]
        public static partial ImGuiStoragePair* ImGuiStoragePair_ImGuiStoragePair_Float(uint _key, float _val_f);
        [LibraryImport("cimgui")]
        public static partial ImGuiStoragePair* ImGuiStoragePair_ImGuiStoragePair_Ptr(uint _key, void* _val_p);
        [LibraryImport("cimgui")]
        public static partial void ImGuiStyle_destroy(ImGuiStyle* self);
        [LibraryImport("cimgui")]
        public static partial ImGuiStyle* ImGuiStyle_ImGuiStyle();
        [LibraryImport("cimgui")]
        public static partial void ImGuiStyle_ScaleAllSizes(ImGuiStyle* self, float scale_factor);
        [LibraryImport("cimgui")]
        public static partial void ImGuiTableColumnSortSpecs_destroy(ImGuiTableColumnSortSpecs* self);
        [LibraryImport("cimgui")]
        public static partial ImGuiTableColumnSortSpecs* ImGuiTableColumnSortSpecs_ImGuiTableColumnSortSpecs();
        [LibraryImport("cimgui")]
        public static partial void ImGuiTableSortSpecs_destroy(ImGuiTableSortSpecs* self);
        [LibraryImport("cimgui")]
        public static partial ImGuiTableSortSpecs* ImGuiTableSortSpecs_ImGuiTableSortSpecs();
        [LibraryImport("cimgui")]
        public static partial void ImGuiTextBuffer_append(ImGuiTextBuffer* self, byte* str, byte* str_end);
        [LibraryImport("cimgui")]
        public static partial void ImGuiTextBuffer_appendf(ImGuiTextBuffer* self, byte* fmt);
        [LibraryImport("cimgui")]
        public static partial byte* ImGuiTextBuffer_begin(ImGuiTextBuffer* self);
        [LibraryImport("cimgui")]
        public static partial byte* ImGuiTextBuffer_c_str(ImGuiTextBuffer* self);
        [LibraryImport("cimgui")]
        public static partial void ImGuiTextBuffer_clear(ImGuiTextBuffer* self);
        [LibraryImport("cimgui")]
        public static partial void ImGuiTextBuffer_destroy(ImGuiTextBuffer* self);
        [LibraryImport("cimgui")]
        public static partial byte ImGuiTextBuffer_empty(ImGuiTextBuffer* self);
        [LibraryImport("cimgui")]
        public static partial byte* ImGuiTextBuffer_end(ImGuiTextBuffer* self);
        [LibraryImport("cimgui")]
        public static partial ImGuiTextBuffer* ImGuiTextBuffer_ImGuiTextBuffer();
        [LibraryImport("cimgui")]
        public static partial void ImGuiTextBuffer_reserve(ImGuiTextBuffer* self, int capacity);
        [LibraryImport("cimgui")]
        public static partial int ImGuiTextBuffer_size(ImGuiTextBuffer* self);
        [LibraryImport("cimgui")]
        public static partial void ImGuiTextFilter_Build(ImGuiTextFilter* self);
        [LibraryImport("cimgui")]
        public static partial void ImGuiTextFilter_Clear(ImGuiTextFilter* self);
        [LibraryImport("cimgui")]
        public static partial void ImGuiTextFilter_destroy(ImGuiTextFilter* self);
        [LibraryImport("cimgui")]
        public static partial byte ImGuiTextFilter_Draw(ImGuiTextFilter* self, byte* label, float width);
        [LibraryImport("cimgui")]
        public static partial ImGuiTextFilter* ImGuiTextFilter_ImGuiTextFilter(byte* default_filter);
        [LibraryImport("cimgui")]
        public static partial byte ImGuiTextFilter_IsActive(ImGuiTextFilter* self);
        [LibraryImport("cimgui")]
        public static partial byte ImGuiTextFilter_PassFilter(ImGuiTextFilter* self, byte* text, byte* text_end);
        [LibraryImport("cimgui")]
        public static partial void ImGuiTextRange_destroy(ImGuiTextRange* self);
        [LibraryImport("cimgui")]
        public static partial byte ImGuiTextRange_empty(ImGuiTextRange* self);
        [LibraryImport("cimgui")]
        public static partial ImGuiTextRange* ImGuiTextRange_ImGuiTextRange_Nil();
        [LibraryImport("cimgui")]
        public static partial ImGuiTextRange* ImGuiTextRange_ImGuiTextRange_Str(byte* _b, byte* _e);
        [LibraryImport("cimgui")]
        public static partial void ImGuiTextRange_split(ImGuiTextRange* self, byte separator, ImVector* @out);
        [LibraryImport("cimgui")]
        public static partial void ImVec2_destroy(Vector2* self);
        [LibraryImport("cimgui")]
        public static partial Vector2* ImVec2_ImVec2_Nil();
        [LibraryImport("cimgui")]
        public static partial Vector2* ImVec2_ImVec2_Float(float _x, float _y);
        [LibraryImport("cimgui")]
        public static partial void ImVec4_destroy(Vector4* self);
        [LibraryImport("cimgui")]
        public static partial Vector4* ImVec4_ImVec4_Nil();
        [LibraryImport("cimgui")]
        public static partial Vector4* ImVec4_ImVec4_Float(float _x, float _y, float _z, float _w);
    }
}
