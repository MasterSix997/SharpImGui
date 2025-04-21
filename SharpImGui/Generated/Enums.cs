using System;

namespace SharpImGui
{
	[Flags]
	public enum ImGuiWindowFlags
	{
		None = 0,
		NoTitleBar = 1,
		NoResize = 2,
		NoMove = 4,
		NoScrollbar = 8,
		NoScrollWithMouse = 16,
		NoCollapse = 32,
		AlwaysAutoResize = 64,
		NoBackground = 128,
		NoSavedSettings = 256,
		NoMouseInputs = 512,
		MenuBar = 1024,
		HorizontalScrollbar = 2048,
		NoFocusOnAppearing = 4096,
		NoBringToFrontOnFocus = 8192,
		AlwaysVerticalScrollbar = 16384,
		AlwaysHorizontalScrollbar = 32768,
		NoNavInputs = 65536,
		NoNavFocus = 131072,
		UnsavedDocument = 262144,
		NoDocking = 524288,
		NoNav = 196608,
		NoDecoration = 43,
		NoInputs = 197120,
		DockNodeHost = 8388608,
		ChildWindow = 16777216,
		Tooltip = 33554432,
		Popup = 67108864,
		Modal = 134217728,
		ChildMenu = 268435456,
	}

	[Flags]
	public enum ImGuiChildFlags
	{
		None = 0,
		Borders = 1,
		AlwaysUseWindowPadding = 2,
		ResizeX = 4,
		ResizeY = 8,
		AutoResizeX = 16,
		AutoResizeY = 32,
		AlwaysAutoResize = 64,
		FrameStyle = 128,
		NavFlattened = 256,
	}

	[Flags]
	public enum ImGuiItemFlags
	{
		None = 0,
		NoTabStop = 1,
		NoNav = 2,
		NoNavDefaultFocus = 4,
		ButtonRepeat = 8,
		AutoClosePopups = 16,
		AllowDuplicateId = 32,
	}

	[Flags]
	public enum ImGuiInputTextFlags
	{
		None = 0,
		CharsDecimal = 1,
		CharsHexadecimal = 2,
		CharsScientific = 4,
		CharsUppercase = 8,
		CharsNoBlank = 16,
		AllowTabInput = 32,
		EnterReturnsTrue = 64,
		EscapeClearsAll = 128,
		CtrlEnterForNewLine = 256,
		ReadOnly = 512,
		Password = 1024,
		AlwaysOverwrite = 2048,
		AutoSelectAll = 4096,
		ParseEmptyRefVal = 8192,
		DisplayEmptyRefVal = 16384,
		NoHorizontalScroll = 32768,
		NoUndoRedo = 65536,
		ElideLeft = 131072,
		CallbackCompletion = 262144,
		CallbackHistory = 524288,
		CallbackAlways = 1048576,
		CallbackCharFilter = 2097152,
		CallbackResize = 4194304,
		CallbackEdit = 8388608,
	}

	[Flags]
	public enum ImGuiTreeNodeFlags
	{
		None = 0,
		Selected = 1,
		Framed = 2,
		AllowOverlap = 4,
		NoTreePushOnOpen = 8,
		NoAutoOpenOnLog = 16,
		DefaultOpen = 32,
		OpenOnDoubleClick = 64,
		OpenOnArrow = 128,
		Leaf = 256,
		Bullet = 512,
		FramePadding = 1024,
		SpanAvailWidth = 2048,
		SpanFullWidth = 4096,
		SpanLabelWidth = 8192,
		SpanAllColumns = 16384,
		LabelSpanAllColumns = 32768,
		NavLeftJumpsBackHere = 131072,
		CollapsingHeader = 26,
	}

	[Flags]
	public enum ImGuiPopupFlags
	{
		None = 0,
		MouseButtonLeft = 0,
		MouseButtonRight = 1,
		MouseButtonMiddle = 2,
		MouseButtonMask = 31,
		MouseButtonDefault = 1,
		NoReopen = 32,
		NoOpenOverExistingPopup = 128,
		NoOpenOverItems = 256,
		AnyPopupId = 1024,
		AnyPopupLevel = 2048,
		AnyPopup = 3072,
	}

	[Flags]
	public enum ImGuiSelectableFlags
	{
		None = 0,
		NoAutoClosePopups = 1,
		SpanAllColumns = 2,
		AllowDoubleClick = 4,
		Disabled = 8,
		AllowOverlap = 16,
		Highlight = 32,
	}

	[Flags]
	public enum ImGuiComboFlags
	{
		None = 0,
		PopupAlignLeft = 1,
		HeightSmall = 2,
		HeightRegular = 4,
		HeightLarge = 8,
		HeightLargest = 16,
		NoArrowButton = 32,
		NoPreview = 64,
		WidthFitPreview = 128,
		HeightMask = 30,
	}

	[Flags]
	public enum ImGuiTabBarFlags
	{
		None = 0,
		Reorderable = 1,
		AutoSelectNewTabs = 2,
		TabListPopupButton = 4,
		NoCloseWithMiddleMouseButton = 8,
		NoTabListScrollingButtons = 16,
		NoTooltip = 32,
		DrawSelectedOverline = 64,
		FittingPolicyResizeDown = 128,
		FittingPolicyScroll = 256,
		FittingPolicyMask = 384,
		FittingPolicyDefault = 128,
	}

	[Flags]
	public enum ImGuiTabItemFlags
	{
		None = 0,
		UnsavedDocument = 1,
		SetSelected = 2,
		NoCloseWithMiddleMouseButton = 4,
		NoPushId = 8,
		NoTooltip = 16,
		NoReorder = 32,
		Leading = 64,
		Trailing = 128,
		NoAssumedClosure = 256,
	}

	[Flags]
	public enum ImGuiFocusedFlags
	{
		None = 0,
		ChildWindows = 1,
		RootWindow = 2,
		AnyWindow = 4,
		NoPopupHierarchy = 8,
		DockHierarchy = 16,
		RootAndChildWindows = 3,
	}

	[Flags]
	public enum ImGuiHoveredFlags
	{
		None = 0,
		ChildWindows = 1,
		RootWindow = 2,
		AnyWindow = 4,
		NoPopupHierarchy = 8,
		DockHierarchy = 16,
		AllowWhenBlockedByPopup = 32,
		AllowWhenBlockedByActiveItem = 128,
		AllowWhenOverlappedByItem = 256,
		AllowWhenOverlappedByWindow = 512,
		AllowWhenDisabled = 1024,
		NoNavOverride = 2048,
		AllowWhenOverlapped = 768,
		RectOnly = 928,
		RootAndChildWindows = 3,
		ForTooltip = 4096,
		Stationary = 8192,
		DelayNone = 16384,
		DelayShort = 32768,
		DelayNormal = 65536,
		NoSharedDelay = 131072,
	}

	[Flags]
	public enum ImGuiDockNodeFlags
	{
		None = 0,
		KeepAliveOnly = 1,
		NoDockingOverCentralNode = 4,
		PassthruCentralNode = 8,
		NoDockingSplit = 16,
		NoResize = 32,
		AutoHideTabBar = 64,
		NoUndocking = 128,
	}

	[Flags]
	public enum ImGuiDragDropFlags
	{
		None = 0,
		SourceNoPreviewTooltip = 1,
		SourceNoDisableHover = 2,
		SourceNoHoldToOpenOthers = 4,
		SourceAllowNullID = 8,
		SourceExtern = 16,
		PayloadAutoExpire = 32,
		PayloadNoCrossContext = 64,
		PayloadNoCrossProcess = 128,
		AcceptBeforeDelivery = 1024,
		AcceptNoDrawDefaultRect = 2048,
		AcceptNoPreviewTooltip = 4096,
		AcceptPeekOnly = 3072,
	}

	public enum ImGuiDataType
	{
		S8 = 0,
		U8 = 1,
		S16 = 2,
		U16 = 3,
		S32 = 4,
		U32 = 5,
		S64 = 6,
		U64 = 7,
		Float = 8,
		Double = 9,
		Bool = 10,
		String = 11,
		COUNT = 12,
	}

	public enum ImGuiDir
	{
		None = -1,
		Left = 0,
		Right = 1,
		Up = 2,
		Down = 3,
		COUNT = 4,
	}

	public enum ImGuiSortDirection
	{
		None = 0,
		Ascending = 1,
		Descending = 2,
	}

	public enum ImGuiKey
	{
		None = 0,
		NamedKey_BEGIN = 512,
		Tab = 512,
		LeftArrow = 513,
		RightArrow = 514,
		UpArrow = 515,
		DownArrow = 516,
		PageUp = 517,
		PageDown = 518,
		Home = 519,
		End = 520,
		Insert = 521,
		Delete = 522,
		Backspace = 523,
		Space = 524,
		Enter = 525,
		Escape = 526,
		LeftCtrl = 527,
		LeftShift = 528,
		LeftAlt = 529,
		LeftSuper = 530,
		RightCtrl = 531,
		RightShift = 532,
		RightAlt = 533,
		RightSuper = 534,
		Menu = 535,
		_0 = 536,
		_1 = 537,
		_2 = 538,
		_3 = 539,
		_4 = 540,
		_5 = 541,
		_6 = 542,
		_7 = 543,
		_8 = 544,
		_9 = 545,
		A = 546,
		B = 547,
		C = 548,
		D = 549,
		E = 550,
		F = 551,
		G = 552,
		H = 553,
		I = 554,
		J = 555,
		K = 556,
		L = 557,
		M = 558,
		N = 559,
		O = 560,
		P = 561,
		Q = 562,
		R = 563,
		S = 564,
		T = 565,
		U = 566,
		V = 567,
		W = 568,
		X = 569,
		Y = 570,
		Z = 571,
		F1 = 572,
		F2 = 573,
		F3 = 574,
		F4 = 575,
		F5 = 576,
		F6 = 577,
		F7 = 578,
		F8 = 579,
		F9 = 580,
		F10 = 581,
		F11 = 582,
		F12 = 583,
		F13 = 584,
		F14 = 585,
		F15 = 586,
		F16 = 587,
		F17 = 588,
		F18 = 589,
		F19 = 590,
		F20 = 591,
		F21 = 592,
		F22 = 593,
		F23 = 594,
		F24 = 595,
		Apostrophe = 596,
		Comma = 597,
		Minus = 598,
		Period = 599,
		Slash = 600,
		Semicolon = 601,
		Equal = 602,
		LeftBracket = 603,
		Backslash = 604,
		RightBracket = 605,
		GraveAccent = 606,
		CapsLock = 607,
		ScrollLock = 608,
		NumLock = 609,
		PrintScreen = 610,
		Pause = 611,
		Keypad0 = 612,
		Keypad1 = 613,
		Keypad2 = 614,
		Keypad3 = 615,
		Keypad4 = 616,
		Keypad5 = 617,
		Keypad6 = 618,
		Keypad7 = 619,
		Keypad8 = 620,
		Keypad9 = 621,
		KeypadDecimal = 622,
		KeypadDivide = 623,
		KeypadMultiply = 624,
		KeypadSubtract = 625,
		KeypadAdd = 626,
		KeypadEnter = 627,
		KeypadEqual = 628,
		AppBack = 629,
		AppForward = 630,
		Oem102 = 631,
		GamepadStart = 632,
		GamepadBack = 633,
		GamepadFaceLeft = 634,
		GamepadFaceRight = 635,
		GamepadFaceUp = 636,
		GamepadFaceDown = 637,
		GamepadDpadLeft = 638,
		GamepadDpadRight = 639,
		GamepadDpadUp = 640,
		GamepadDpadDown = 641,
		GamepadL1 = 642,
		GamepadR1 = 643,
		GamepadL2 = 644,
		GamepadR2 = 645,
		GamepadL3 = 646,
		GamepadR3 = 647,
		GamepadLStickLeft = 648,
		GamepadLStickRight = 649,
		GamepadLStickUp = 650,
		GamepadLStickDown = 651,
		GamepadRStickLeft = 652,
		GamepadRStickRight = 653,
		GamepadRStickUp = 654,
		GamepadRStickDown = 655,
		MouseLeft = 656,
		MouseRight = 657,
		MouseMiddle = 658,
		MouseX1 = 659,
		MouseX2 = 660,
		MouseWheelX = 661,
		MouseWheelY = 662,
		ReservedForModCtrl = 663,
		ReservedForModShift = 664,
		ReservedForModAlt = 665,
		ReservedForModSuper = 666,
		NamedKey_END = 667,
		ImGuiMod_None = 0,
		ImGuiMod_Ctrl = 4096,
		ImGuiMod_Shift = 8192,
		ImGuiMod_Alt = 16384,
		ImGuiMod_Super = 32768,
		ImGuiMod_Mask = 61440,
		NamedKey_COUNT = 155,
	}

	[Flags]
	public enum ImGuiInputFlags
	{
		None = 0,
		Repeat = 1,
		RouteActive = 1024,
		RouteFocused = 2048,
		RouteGlobal = 4096,
		RouteAlways = 8192,
		RouteOverFocused = 16384,
		RouteOverActive = 32768,
		RouteUnlessBgFocused = 65536,
		RouteFromRootWindow = 131072,
		Tooltip = 262144,
	}

	[Flags]
	public enum ImGuiConfigFlags
	{
		None = 0,
		NavEnableKeyboard = 1,
		NavEnableGamepad = 2,
		NoMouse = 16,
		NoMouseCursorChange = 32,
		NoKeyboard = 64,
		DockingEnable = 128,
		ViewportsEnable = 1024,
		DpiEnableScaleViewports = 16384,
		DpiEnableScaleFonts = 32768,
		IsSRGB = 1048576,
		IsTouchScreen = 2097152,
	}

	[Flags]
	public enum ImGuiBackendFlags
	{
		None = 0,
		HasGamepad = 1,
		HasMouseCursors = 2,
		HasSetMousePos = 4,
		RendererHasVtxOffset = 8,
		PlatformHasViewports = 1024,
		HasMouseHoveredViewport = 2048,
		RendererHasViewports = 4096,
	}

	public enum ImGuiCol
	{
		Text = 0,
		TextDisabled = 1,
		WindowBg = 2,
		ChildBg = 3,
		PopupBg = 4,
		Border = 5,
		BorderShadow = 6,
		FrameBg = 7,
		FrameBgHovered = 8,
		FrameBgActive = 9,
		TitleBg = 10,
		TitleBgActive = 11,
		TitleBgCollapsed = 12,
		MenuBarBg = 13,
		ScrollbarBg = 14,
		ScrollbarGrab = 15,
		ScrollbarGrabHovered = 16,
		ScrollbarGrabActive = 17,
		CheckMark = 18,
		SliderGrab = 19,
		SliderGrabActive = 20,
		Button = 21,
		ButtonHovered = 22,
		ButtonActive = 23,
		Header = 24,
		HeaderHovered = 25,
		HeaderActive = 26,
		Separator = 27,
		SeparatorHovered = 28,
		SeparatorActive = 29,
		ResizeGrip = 30,
		ResizeGripHovered = 31,
		ResizeGripActive = 32,
		TabHovered = 33,
		Tab = 34,
		TabSelected = 35,
		TabSelectedOverline = 36,
		TabDimmed = 37,
		TabDimmedSelected = 38,
		TabDimmedSelectedOverline = 39,
		DockingPreview = 40,
		DockingEmptyBg = 41,
		PlotLines = 42,
		PlotLinesHovered = 43,
		PlotHistogram = 44,
		PlotHistogramHovered = 45,
		TableHeaderBg = 46,
		TableBorderStrong = 47,
		TableBorderLight = 48,
		TableRowBg = 49,
		TableRowBgAlt = 50,
		TextLink = 51,
		TextSelectedBg = 52,
		DragDropTarget = 53,
		NavCursor = 54,
		NavWindowingHighlight = 55,
		NavWindowingDimBg = 56,
		ModalWindowDimBg = 57,
		COUNT = 58,
	}

	public enum ImGuiStyleVar
	{
		Alpha = 0,
		DisabledAlpha = 1,
		WindowPadding = 2,
		WindowRounding = 3,
		WindowBorderSize = 4,
		WindowMinSize = 5,
		WindowTitleAlign = 6,
		ChildRounding = 7,
		ChildBorderSize = 8,
		PopupRounding = 9,
		PopupBorderSize = 10,
		FramePadding = 11,
		FrameRounding = 12,
		FrameBorderSize = 13,
		ItemSpacing = 14,
		ItemInnerSpacing = 15,
		IndentSpacing = 16,
		CellPadding = 17,
		ScrollbarSize = 18,
		ScrollbarRounding = 19,
		GrabMinSize = 20,
		GrabRounding = 21,
		ImageBorderSize = 22,
		TabRounding = 23,
		TabBorderSize = 24,
		TabBarBorderSize = 25,
		TabBarOverlineSize = 26,
		TableAngledHeadersAngle = 27,
		TableAngledHeadersTextAlign = 28,
		ButtonTextAlign = 29,
		SelectableTextAlign = 30,
		SeparatorTextBorderSize = 31,
		SeparatorTextAlign = 32,
		SeparatorTextPadding = 33,
		DockingSeparatorSize = 34,
		COUNT = 35,
	}

	[Flags]
	public enum ImGuiButtonFlags
	{
		None = 0,
		MouseButtonLeft = 1,
		MouseButtonRight = 2,
		MouseButtonMiddle = 4,
		MouseButtonMask = 7,
		EnableNav = 8,
	}

	[Flags]
	public enum ImGuiColorEditFlags
	{
		None = 0,
		NoAlpha = 2,
		NoPicker = 4,
		NoOptions = 8,
		NoSmallPreview = 16,
		NoInputs = 32,
		NoTooltip = 64,
		NoLabel = 128,
		NoSidePreview = 256,
		NoDragDrop = 512,
		NoBorder = 1024,
		AlphaOpaque = 2048,
		AlphaNoBg = 4096,
		AlphaPreviewHalf = 8192,
		AlphaBar = 65536,
		HDR = 524288,
		DisplayRGB = 1048576,
		DisplayHSV = 2097152,
		DisplayHex = 4194304,
		Uint8 = 8388608,
		Float = 16777216,
		PickerHueBar = 33554432,
		PickerHueWheel = 67108864,
		InputRGB = 134217728,
		InputHSV = 268435456,
		DefaultOptions = 177209344,
		AlphaMask = 14338,
		DisplayMask = 7340032,
		DataTypeMask = 25165824,
		PickerMask = 100663296,
		InputMask = 402653184,
	}

	[Flags]
	public enum ImGuiSliderFlags
	{
		None = 0,
		Logarithmic = 32,
		NoRoundToFormat = 64,
		NoInput = 128,
		WrapAround = 256,
		ClampOnInput = 512,
		ClampZeroRange = 1024,
		NoSpeedTweaks = 2048,
		AlwaysClamp = 1536,
		InvalidMask = 1879048207,
	}

	public enum ImGuiMouseButton
	{
		Left = 0,
		Right = 1,
		Middle = 2,
		COUNT = 5,
	}

	public enum ImGuiMouseCursor
	{
		None = -1,
		Arrow = 0,
		TextInput = 1,
		ResizeAll = 2,
		ResizeNS = 3,
		ResizeEW = 4,
		ResizeNESW = 5,
		ResizeNWSE = 6,
		Hand = 7,
		Wait = 8,
		Progress = 9,
		NotAllowed = 10,
		COUNT = 11,
	}

	public enum ImGuiMouseSource
	{
		Mouse = 0,
		TouchScreen = 1,
		Pen = 2,
		COUNT = 3,
	}

	public enum ImGuiCond
	{
		None = 0,
		Always = 1,
		Once = 2,
		FirstUseEver = 4,
		Appearing = 8,
	}

	[Flags]
	public enum ImGuiTableFlags
	{
		None = 0,
		Resizable = 1,
		Reorderable = 2,
		Hideable = 4,
		Sortable = 8,
		NoSavedSettings = 16,
		ContextMenuInBody = 32,
		RowBg = 64,
		BordersInnerH = 128,
		BordersOuterH = 256,
		BordersInnerV = 512,
		BordersOuterV = 1024,
		BordersH = 384,
		BordersV = 1536,
		BordersInner = 640,
		BordersOuter = 1280,
		Borders = 1920,
		NoBordersInBody = 2048,
		NoBordersInBodyUntilResize = 4096,
		SizingFixedFit = 8192,
		SizingFixedSame = 16384,
		SizingStretchProp = 24576,
		SizingStretchSame = 32768,
		NoHostExtendX = 65536,
		NoHostExtendY = 131072,
		NoKeepColumnsVisible = 262144,
		PreciseWidths = 524288,
		NoClip = 1048576,
		PadOuterX = 2097152,
		NoPadOuterX = 4194304,
		NoPadInnerX = 8388608,
		ScrollX = 16777216,
		ScrollY = 33554432,
		SortMulti = 67108864,
		SortTristate = 134217728,
		HighlightHoveredColumn = 268435456,
		SizingMask = 57344,
	}

	[Flags]
	public enum ImGuiTableColumnFlags
	{
		None = 0,
		Disabled = 1,
		DefaultHide = 2,
		DefaultSort = 4,
		WidthStretch = 8,
		WidthFixed = 16,
		NoResize = 32,
		NoReorder = 64,
		NoHide = 128,
		NoClip = 256,
		NoSort = 512,
		NoSortAscending = 1024,
		NoSortDescending = 2048,
		NoHeaderLabel = 4096,
		NoHeaderWidth = 8192,
		PreferSortAscending = 16384,
		PreferSortDescending = 32768,
		IndentEnable = 65536,
		IndentDisable = 131072,
		AngledHeader = 262144,
		IsEnabled = 16777216,
		IsVisible = 33554432,
		IsSorted = 67108864,
		IsHovered = 134217728,
		WidthMask = 24,
		IndentMask = 196608,
		StatusMask = 251658240,
		NoDirectResize = 1073741824,
	}

	[Flags]
	public enum ImGuiTableRowFlags
	{
		None = 0,
		Headers = 1,
	}

	public enum ImGuiTableBgTarget
	{
		None = 0,
		RowBg0 = 1,
		RowBg1 = 2,
		CellBg = 3,
	}

	[Flags]
	public enum ImGuiMultiSelectFlags
	{
		None = 0,
		SingleSelect = 1,
		NoSelectAll = 2,
		NoRangeSelect = 4,
		NoAutoSelect = 8,
		NoAutoClear = 16,
		NoAutoClearOnReselect = 32,
		BoxSelect1d = 64,
		BoxSelect2d = 128,
		BoxSelectNoScroll = 256,
		ClearOnEscape = 512,
		ClearOnClickVoid = 1024,
		ScopeWindow = 2048,
		ScopeRect = 4096,
		SelectOnClick = 8192,
		SelectOnClickRelease = 16384,
		NavWrapX = 65536,
	}

	public enum ImGuiSelectionRequestType
	{
		None = 0,
		SetAll = 1,
		SetRange = 2,
	}

	[Flags]
	public enum ImDrawFlags
	{
		None = 0,
		Closed = 1,
		RoundCornersTopLeft = 16,
		RoundCornersTopRight = 32,
		RoundCornersBottomLeft = 64,
		RoundCornersBottomRight = 128,
		RoundCornersNone = 256,
		RoundCornersTop = 48,
		RoundCornersBottom = 192,
		RoundCornersLeft = 80,
		RoundCornersRight = 160,
		RoundCornersAll = 240,
		RoundCornersDefault = 240,
		RoundCornersMask = 496,
	}

	[Flags]
	public enum ImDrawListFlags
	{
		None = 0,
		AntiAliasedLines = 1,
		AntiAliasedLinesUseTex = 2,
		AntiAliasedFill = 4,
		AllowVtxOffset = 8,
	}

	[Flags]
	public enum ImFontAtlasFlags
	{
		None = 0,
		NoPowerOfTwoHeight = 1,
		NoMouseCursors = 2,
		NoBakedLines = 4,
	}

	[Flags]
	public enum ImGuiViewportFlags
	{
		None = 0,
		IsPlatformWindow = 1,
		IsPlatformMonitor = 2,
		OwnedByApp = 4,
		NoDecoration = 8,
		NoTaskBarIcon = 16,
		NoFocusOnAppearing = 32,
		NoFocusOnClick = 64,
		NoInputs = 128,
		NoRendererClear = 256,
		NoAutoMerge = 512,
		TopMost = 1024,
		CanHostOtherWindows = 2048,
		IsMinimized = 4096,
		IsFocused = 8192,
	}

	public enum ImGuiDataTypePrivate
	{
		Pointer = 12,
		ID = 13,
	}

	[Flags]
	public enum ImGuiItemFlagsPrivate
	{
		Disabled = 1024,
		ReadOnly = 2048,
		MixedValue = 4096,
		NoWindowHoverableCheck = 8192,
		AllowOverlap = 16384,
		NoNavDisableMouseHover = 32768,
		NoMarkEdited = 65536,
		Inputable = 1048576,
		HasSelectionUserData = 2097152,
		IsMultiSelect = 4194304,
		Default = 16,
	}

	[Flags]
	public enum ImGuiItemStatusFlags
	{
		None = 0,
		HoveredRect = 1,
		HasDisplayRect = 2,
		Edited = 4,
		ToggledSelection = 8,
		ToggledOpen = 16,
		HasDeactivated = 32,
		Deactivated = 64,
		HoveredWindow = 128,
		Visible = 256,
		HasClipRect = 512,
		HasShortcut = 1024,
	}

	[Flags]
	public enum ImGuiHoveredFlagsPrivate
	{
		DelayMask = 245760,
		AllowedMaskForIsWindowHovered = 12479,
		AllowedMaskForIsItemHovered = 262048,
	}

	[Flags]
	public enum ImGuiInputTextFlagsPrivate
	{
		Multiline = 67108864,
		MergedItem = 134217728,
		LocalizeDecimalPoint = 268435456,
	}

	[Flags]
	public enum ImGuiButtonFlagsPrivate
	{
		PressedOnClick = 16,
		PressedOnClickRelease = 32,
		PressedOnClickReleaseAnywhere = 64,
		PressedOnRelease = 128,
		PressedOnDoubleClick = 256,
		PressedOnDragDropHold = 512,
		FlattenChildren = 2048,
		AllowOverlap = 4096,
		AlignTextBaseLine = 32768,
		NoKeyModsAllowed = 65536,
		NoHoldingActiveId = 131072,
		NoNavFocus = 262144,
		NoHoveredOnFocus = 524288,
		NoSetKeyOwner = 1048576,
		NoTestKeyOwner = 2097152,
		PressedOnMask = 1008,
		PressedOnDefault = 32,
	}

	[Flags]
	public enum ImGuiComboFlagsPrivate
	{
		CustomPreview = 1048576,
	}

	[Flags]
	public enum ImGuiSliderFlagsPrivate
	{
		Vertical = 1048576,
		ReadOnly = 2097152,
	}

	[Flags]
	public enum ImGuiSelectableFlagsPrivate
	{
		NoHoldingActiveID = 1048576,
		SelectOnNav = 2097152,
		SelectOnClick = 4194304,
		SelectOnRelease = 8388608,
		SpanAvailWidth = 16777216,
		SetNavIdOnHover = 33554432,
		NoPadWithHalfSpacing = 67108864,
		NoSetKeyOwner = 134217728,
	}

	[Flags]
	public enum ImGuiTreeNodeFlagsPrivate
	{
		ClipLabelForTrailingButton = 268435456,
		UpsideDownArrow = 536870912,
		OpenOnMask = 192,
	}

	[Flags]
	public enum ImGuiSeparatorFlags
	{
		None = 0,
		Horizontal = 1,
		Vertical = 2,
		SpanAllColumns = 4,
	}

	[Flags]
	public enum ImGuiFocusRequestFlags
	{
		None = 0,
		RestoreFocusedChild = 1,
		UnlessBelowModal = 2,
	}

	[Flags]
	public enum ImGuiTextFlags
	{
		None = 0,
		NoWidthForLargeClippedText = 1,
	}

	[Flags]
	public enum ImGuiTooltipFlags
	{
		None = 0,
		OverridePrevious = 2,
	}

	public enum ImGuiLayoutType
	{
		Horizontal = 0,
		Vertical = 1,
	}

	[Flags]
	public enum ImGuiLogFlags
	{
		None = 0,
		OutputTTY = 1,
		OutputFile = 2,
		OutputBuffer = 4,
		OutputClipboard = 8,
		OutputMask = 15,
	}

	public enum ImGuiAxis
	{
		None = -1,
		X = 0,
		Y = 1,
	}

	public enum ImGuiPlotType
	{
		Lines = 0,
		Histogram = 1,
	}

	[Flags]
	public enum ImGuiWindowRefreshFlags
	{
		None = 0,
		TryToAvoidRefresh = 1,
		RefreshOnHover = 2,
		RefreshOnFocus = 4,
	}

	[Flags]
	public enum ImGuiNextWindowDataFlags
	{
		None = 0,
		HasPos = 1,
		HasSize = 2,
		HasContentSize = 4,
		HasCollapsed = 8,
		HasSizeConstraint = 16,
		HasFocus = 32,
		HasBgAlpha = 64,
		HasScroll = 128,
		HasWindowFlags = 256,
		HasChildFlags = 512,
		HasRefreshPolicy = 1024,
		HasViewport = 2048,
		HasDock = 4096,
		HasWindowClass = 8192,
	}

	[Flags]
	public enum ImGuiNextItemDataFlags
	{
		None = 0,
		HasWidth = 1,
		HasOpen = 2,
		HasShortcut = 4,
		HasRefVal = 8,
		HasStorageID = 16,
	}

	public enum ImGuiPopupPositionPolicy
	{
		Default = 0,
		ComboBox = 1,
		Tooltip = 2,
	}

	public enum ImGuiInputEventType
	{
		None = 0,
		MousePos = 1,
		MouseWheel = 2,
		MouseButton = 3,
		MouseViewport = 4,
		Key = 5,
		Text = 6,
		Focus = 7,
		COUNT = 8,
	}

	public enum ImGuiInputSource
	{
		None = 0,
		Mouse = 1,
		Keyboard = 2,
		Gamepad = 3,
		COUNT = 4,
	}

	[Flags]
	public enum ImGuiInputFlagsPrivate
	{
		RepeatRateDefault = 2,
		RepeatRateNavMove = 4,
		RepeatRateNavTweak = 8,
		RepeatUntilRelease = 16,
		RepeatUntilKeyModsChange = 32,
		RepeatUntilKeyModsChangeFromNone = 64,
		RepeatUntilOtherKeyPress = 128,
		LockThisFrame = 1048576,
		LockUntilRelease = 2097152,
		CondHovered = 4194304,
		CondActive = 8388608,
		CondDefault = 12582912,
		RepeatRateMask = 14,
		RepeatUntilMask = 240,
		RepeatMask = 255,
		CondMask = 12582912,
		RouteTypeMask = 15360,
		RouteOptionsMask = 245760,
		SupportedByIsKeyPressed = 255,
		SupportedByIsMouseClicked = 1,
		SupportedByShortcut = 261375,
		SupportedBySetNextItemShortcut = 523519,
		SupportedBySetKeyOwner = 3145728,
		SupportedBySetItemKeyOwner = 15728640,
	}

	[Flags]
	public enum ImGuiActivateFlags
	{
		None = 0,
		PreferInput = 1,
		PreferTweak = 2,
		TryToPreserveState = 4,
		FromTabbing = 8,
		FromShortcut = 16,
	}

	[Flags]
	public enum ImGuiScrollFlags
	{
		None = 0,
		KeepVisibleEdgeX = 1,
		KeepVisibleEdgeY = 2,
		KeepVisibleCenterX = 4,
		KeepVisibleCenterY = 8,
		AlwaysCenterX = 16,
		AlwaysCenterY = 32,
		NoScrollParent = 64,
		MaskX = 21,
		MaskY = 42,
	}

	[Flags]
	public enum ImGuiNavRenderCursorFlags
	{
		None = 0,
		Compact = 2,
		AlwaysDraw = 4,
		NoRounding = 8,
	}

	[Flags]
	public enum ImGuiNavMoveFlags
	{
		None = 0,
		LoopX = 1,
		LoopY = 2,
		WrapX = 4,
		WrapY = 8,
		WrapMask = 15,
		AllowCurrentNavId = 16,
		AlsoScoreVisibleSet = 32,
		ScrollToEdgeY = 64,
		Forwarded = 128,
		DebugNoResult = 256,
		FocusApi = 512,
		IsTabbing = 1024,
		IsPageMove = 2048,
		Activate = 4096,
		NoSelect = 8192,
		NoSetNavCursorVisible = 16384,
		NoClearActiveId = 32768,
	}

	public enum ImGuiNavLayer
	{
		Main = 0,
		Menu = 1,
		COUNT = 2,
	}

	[Flags]
	public enum ImGuiTypingSelectFlags
	{
		None = 0,
		AllowBackspace = 1,
		AllowSingleCharMode = 2,
	}

	[Flags]
	public enum ImGuiOldColumnFlags
	{
		None = 0,
		NoBorder = 1,
		NoResize = 2,
		NoPreserveWidths = 4,
		NoForceWithinWindow = 8,
		GrowParentContentsSize = 16,
	}

	[Flags]
	public enum ImGuiDockNodeFlagsPrivate
	{
		DockSpace = 1024,
		CentralNode = 2048,
		NoTabBar = 4096,
		HiddenTabBar = 8192,
		NoWindowMenuButton = 16384,
		NoCloseButton = 32768,
		NoResizeX = 65536,
		NoResizeY = 131072,
		DockedWindowsInFocusRoute = 262144,
		NoDockingSplitOther = 524288,
		NoDockingOverMe = 1048576,
		NoDockingOverOther = 2097152,
		NoDockingOverEmpty = 4194304,
		NoDocking = 7864336,
		SharedFlagsInheritMask = -1,
		NoResizeFlagsMask = 196640,
		LocalFlagsTransferMask = 260208,
		SavedFlagsMask = 261152,
	}

	public enum ImGuiDataAuthority
	{
		Auto = 0,
		DockNode = 1,
		Window = 2,
	}

	public enum ImGuiDockNodeState
	{
		Unknown = 0,
		HostWindowHiddenBecauseSingleWindow = 1,
		HostWindowHiddenBecauseWindowsAreResizing = 2,
		HostWindowVisible = 3,
	}

	public enum ImGuiWindowDockStyleCol
	{
		Text = 0,
		TabHovered = 1,
		TabFocused = 2,
		TabSelected = 3,
		TabSelectedOverline = 4,
		TabDimmed = 5,
		TabDimmedSelected = 6,
		TabDimmedSelectedOverline = 7,
		COUNT = 8,
	}

	public enum ImGuiLocKey
	{
		VersionStr = 0,
		TableSizeOne = 1,
		TableSizeAllFit = 2,
		TableSizeAllDefault = 3,
		TableResetOrder = 4,
		WindowingMainMenuBar = 5,
		WindowingPopup = 6,
		WindowingUntitled = 7,
		OpenLink_s = 8,
		CopyLink = 9,
		DockingHideTabBar = 10,
		DockingHoldShiftToDock = 11,
		DockingDragToUndockOrMoveNode = 12,
		COUNT = 13,
	}

	[Flags]
	public enum ImGuiDebugLogFlags
	{
		None = 0,
		EventError = 1,
		EventActiveId = 2,
		EventFocus = 4,
		EventPopup = 8,
		EventNav = 16,
		EventClipper = 32,
		EventSelection = 64,
		EventIO = 128,
		EventFont = 256,
		EventInputRouting = 512,
		EventDocking = 1024,
		EventViewport = 2048,
		EventMask = 4095,
		OutputToTTY = 1048576,
		OutputToTestEngine = 2097152,
	}

	public enum ImGuiContextHookType
	{
		NewFramePre = 0,
		NewFramePost = 1,
		EndFramePre = 2,
		EndFramePost = 3,
		RenderPre = 4,
		RenderPost = 5,
		Shutdown = 6,
		PendingRemoval = 7,
	}

	[Flags]
	public enum ImGuiTabBarFlagsPrivate
	{
		DockNode = 1048576,
		IsFocused = 2097152,
		SaveSettings = 4194304,
	}

	[Flags]
	public enum ImGuiTabItemFlagsPrivate
	{
		SectionMask = 192,
		NoCloseButton = 1048576,
		Button = 2097152,
		Invisible = 4194304,
		Unsorted = 8388608,
	}
}
