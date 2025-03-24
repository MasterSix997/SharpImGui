using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiStyle
	{
		/// <summary>
		/// // Global alpha applies to everything in Dear ImGui.
		/// </summary>
		public float Alpha;
		/// <summary>
		/// // Additional alpha multiplier applied by BeginDisabled(). Multiply over current value of Alpha.
		/// </summary>
		public float DisabledAlpha;
		/// <summary>
		/// // Padding within a window.
		/// </summary>
		public Vector2 WindowPadding;
		/// <summary>
		/// // Radius of window corners rounding. Set to 0.0f to have rectangular windows. Large values tend to lead to variety of artifacts and are not recommended.
		/// </summary>
		public float WindowRounding;
		/// <summary>
		/// // Thickness of border around windows. Generally set to 0.0f or 1.0f. (Other values are not well tested and more CPU/GPU costly).
		/// </summary>
		public float WindowBorderSize;
		/// <summary>
		/// // Minimum window size. This is a global setting. If you want to constrain individual windows, use SetNextWindowSizeConstraints().
		/// </summary>
		public Vector2 WindowMinSize;
		/// <summary>
		/// // Alignment for title bar text. Defaults to (0.0f,0.5f) for left-aligned,vertically centered.
		/// </summary>
		public Vector2 WindowTitleAlign;
		/// <summary>
		/// // Side of the collapsing/docking button in the title bar (None/Left/Right). Defaults to ImGuiDir_Left.
		/// </summary>
		public ImGuiDir WindowMenuButtonPosition;
		/// <summary>
		/// // Radius of child window corners rounding. Set to 0.0f to have rectangular windows.
		/// </summary>
		public float ChildRounding;
		/// <summary>
		/// // Thickness of border around child windows. Generally set to 0.0f or 1.0f. (Other values are not well tested and more CPU/GPU costly).
		/// </summary>
		public float ChildBorderSize;
		/// <summary>
		/// // Radius of popup window corners rounding. (Note that tooltip windows use WindowRounding)
		/// </summary>
		public float PopupRounding;
		/// <summary>
		/// // Thickness of border around popup/tooltip windows. Generally set to 0.0f or 1.0f. (Other values are not well tested and more CPU/GPU costly).
		/// </summary>
		public float PopupBorderSize;
		/// <summary>
		/// // Padding within a framed rectangle (used by most widgets).
		/// </summary>
		public Vector2 FramePadding;
		/// <summary>
		/// // Radius of frame corners rounding. Set to 0.0f to have rectangular frame (used by most widgets).
		/// </summary>
		public float FrameRounding;
		/// <summary>
		/// // Thickness of border around frames. Generally set to 0.0f or 1.0f. (Other values are not well tested and more CPU/GPU costly).
		/// </summary>
		public float FrameBorderSize;
		/// <summary>
		/// // Horizontal and vertical spacing between widgets/lines.
		/// </summary>
		public Vector2 ItemSpacing;
		/// <summary>
		/// // Horizontal and vertical spacing between within elements of a composed widget (e.g. a slider and its label).
		/// </summary>
		public Vector2 ItemInnerSpacing;
		/// <summary>
		/// // Padding within a table cell. Cellpadding.x is locked for entire table. CellPadding.y may be altered between different rows.
		/// </summary>
		public Vector2 CellPadding;
		/// <summary>
		/// // Expand reactive bounding box for touch-based system where touch position is not accurate enough. Unfortunately we don't sort widgets so priority on overlap will always be given to the first widget. So don't grow this too much!
		/// </summary>
		public Vector2 TouchExtraPadding;
		/// <summary>
		/// // Horizontal indentation when e.g. entering a tree node. Generally == (FontSize + FramePadding.x*2).
		/// </summary>
		public float IndentSpacing;
		/// <summary>
		/// // Minimum horizontal spacing between two columns. Preferably > (FramePadding.x + 1).
		/// </summary>
		public float ColumnsMinSpacing;
		/// <summary>
		/// // Width of the vertical scrollbar, Height of the horizontal scrollbar.
		/// </summary>
		public float ScrollbarSize;
		/// <summary>
		/// // Radius of grab corners for scrollbar.
		/// </summary>
		public float ScrollbarRounding;
		/// <summary>
		/// // Minimum width/height of a grab box for slider/scrollbar.
		/// </summary>
		public float GrabMinSize;
		/// <summary>
		/// // Radius of grabs corners rounding. Set to 0.0f to have rectangular slider grabs.
		/// </summary>
		public float GrabRounding;
		/// <summary>
		/// // The size in pixels of the dead-zone around zero on logarithmic sliders that cross zero.
		/// </summary>
		public float LogSliderDeadzone;
		/// <summary>
		/// // Radius of upper corners of a tab. Set to 0.0f to have rectangular tabs.
		/// </summary>
		public float TabRounding;
		/// <summary>
		/// // Thickness of border around tabs.
		/// </summary>
		public float TabBorderSize;
		/// <summary>
		/// // Minimum width for close button to appear on an unselected tab when hovered. Set to 0.0f to always show when hovering, set to FLT_MAX to never show close button unless selected.
		/// </summary>
		public float TabMinWidthForCloseButton;
		/// <summary>
		/// // Thickness of tab-bar separator, which takes on the tab active color to denote focus.
		/// </summary>
		public float TabBarBorderSize;
		/// <summary>
		/// // Thickness of tab-bar overline, which highlights the selected tab-bar.
		/// </summary>
		public float TabBarOverlineSize;
		/// <summary>
		/// // Angle of angled headers (supported values range from -50.0f degrees to +50.0f degrees).
		/// </summary>
		public float TableAngledHeadersAngle;
		/// <summary>
		/// // Alignment of angled headers within the cell
		/// </summary>
		public Vector2 TableAngledHeadersTextAlign;
		/// <summary>
		/// // Side of the color button in the ColorEdit4 widget (left/right). Defaults to ImGuiDir_Right.
		/// </summary>
		public ImGuiDir ColorButtonPosition;
		/// <summary>
		/// // Alignment of button text when button is larger than text. Defaults to (0.5f, 0.5f) (centered).
		/// </summary>
		public Vector2 ButtonTextAlign;
		/// <summary>
		/// // Alignment of selectable text. Defaults to (0.0f, 0.0f) (top-left aligned). It's generally important to keep this left-aligned if you want to lay multiple items on a same line.
		/// </summary>
		public Vector2 SelectableTextAlign;
		/// <summary>
		/// // Thickness of border in SeparatorText()
		/// </summary>
		public float SeparatorTextBorderSize;
		/// <summary>
		/// // Alignment of text within the separator. Defaults to (0.0f, 0.5f) (left aligned, center).
		/// </summary>
		public Vector2 SeparatorTextAlign;
		/// <summary>
		/// // Horizontal offset of text from each edge of the separator + spacing on other axis. Generally small values. .y is recommended to be == FramePadding.y.
		/// </summary>
		public Vector2 SeparatorTextPadding;
		/// <summary>
		/// // Apply to regular windows: amount which we enforce to keep visible when moving near edges of your screen.
		/// </summary>
		public Vector2 DisplayWindowPadding;
		/// <summary>
		/// // Apply to every windows, menus, popups, tooltips: amount where we avoid displaying contents. Adjust if you cannot see the edges of your screen (e.g. on a TV where scaling has not been configured).
		/// </summary>
		public Vector2 DisplaySafeAreaPadding;
		/// <summary>
		/// // Thickness of resizing border between docked windows
		/// </summary>
		public float DockingSeparatorSize;
		/// <summary>
		/// // Scale software rendered mouse cursor (when io.MouseDrawCursor is enabled). We apply per-monitor DPI scaling over this scale. May be removed later.
		/// </summary>
		public float MouseCursorScale;
		/// <summary>
		/// // Enable anti-aliased lines/borders. Disable if you are really tight on CPU/GPU. Latched at the beginning of the frame (copied to ImDrawList).
		/// </summary>
		public byte AntiAliasedLines;
		/// <summary>
		/// // Enable anti-aliased lines/borders using textures where possible. Require backend to render with bilinear filtering (NOT point/nearest filtering). Latched at the beginning of the frame (copied to ImDrawList).
		/// </summary>
		public byte AntiAliasedLinesUseTex;
		/// <summary>
		/// // Enable anti-aliased edges around filled shapes (rounded rectangles, circles, etc.). Disable if you are really tight on CPU/GPU. Latched at the beginning of the frame (copied to ImDrawList).
		/// </summary>
		public byte AntiAliasedFill;
		/// <summary>
		/// // Tessellation tolerance when using PathBezierCurveTo() without a specific number of segments. Decrease for highly tessellated curves (higher quality, more polygons), increase to reduce quality.
		/// </summary>
		public float CurveTessellationTol;
		/// <summary>
		/// // Maximum error (in pixels) allowed when using AddCircle()/AddCircleFilled() or drawing rounded corner rectangles with no explicit segment count specified. Decrease for higher quality but more geometry.
		/// </summary>
		public float CircleTessellationMaxError;
		public Vector4 Colors_0;
		public Vector4 Colors_1;
		public Vector4 Colors_2;
		public Vector4 Colors_3;
		public Vector4 Colors_4;
		public Vector4 Colors_5;
		public Vector4 Colors_6;
		public Vector4 Colors_7;
		public Vector4 Colors_8;
		public Vector4 Colors_9;
		public Vector4 Colors_10;
		public Vector4 Colors_11;
		public Vector4 Colors_12;
		public Vector4 Colors_13;
		public Vector4 Colors_14;
		public Vector4 Colors_15;
		public Vector4 Colors_16;
		public Vector4 Colors_17;
		public Vector4 Colors_18;
		public Vector4 Colors_19;
		public Vector4 Colors_20;
		public Vector4 Colors_21;
		public Vector4 Colors_22;
		public Vector4 Colors_23;
		public Vector4 Colors_24;
		public Vector4 Colors_25;
		public Vector4 Colors_26;
		public Vector4 Colors_27;
		public Vector4 Colors_28;
		public Vector4 Colors_29;
		public Vector4 Colors_30;
		public Vector4 Colors_31;
		public Vector4 Colors_32;
		public Vector4 Colors_33;
		public Vector4 Colors_34;
		public Vector4 Colors_35;
		public Vector4 Colors_36;
		public Vector4 Colors_37;
		public Vector4 Colors_38;
		public Vector4 Colors_39;
		public Vector4 Colors_40;
		public Vector4 Colors_41;
		public Vector4 Colors_42;
		public Vector4 Colors_43;
		public Vector4 Colors_44;
		public Vector4 Colors_45;
		public Vector4 Colors_46;
		public Vector4 Colors_47;
		public Vector4 Colors_48;
		public Vector4 Colors_49;
		public Vector4 Colors_50;
		public Vector4 Colors_51;
		public Vector4 Colors_52;
		public Vector4 Colors_53;
		public Vector4 Colors_54;
		public Vector4 Colors_55;
		public Vector4 Colors_56;
		public Vector4 Colors_57;
		/// <summary>
		///     // Behaviors
		///     // (It is possible to modify those fields mid-frame if specific behavior need it, unlike e.g. configuration fields in ImGuiIO)
		/// // Delay for IsItemHovered(ImGuiHoveredFlags_Stationary). Time required to consider mouse stationary.
		/// </summary>
		public float HoverStationaryDelay;
		/// <summary>
		/// // Delay for IsItemHovered(ImGuiHoveredFlags_DelayShort). Usually used along with HoverStationaryDelay.
		/// </summary>
		public float HoverDelayShort;
		/// <summary>
		/// // Delay for IsItemHovered(ImGuiHoveredFlags_DelayNormal). "
		/// </summary>
		public float HoverDelayNormal;
		/// <summary>
		/// // Default flags when using IsItemHovered(ImGuiHoveredFlags_ForTooltip) or BeginItemTooltip()/SetItemTooltip() while using mouse.
		/// </summary>
		public ImGuiHoveredFlags HoverFlagsForTooltipMouse;
		/// <summary>
		/// // Default flags when using IsItemHovered(ImGuiHoveredFlags_ForTooltip) or BeginItemTooltip()/SetItemTooltip() while using keyboard/gamepad.
		/// </summary>
		public ImGuiHoveredFlags HoverFlagsForTooltipNav;
	}
}
