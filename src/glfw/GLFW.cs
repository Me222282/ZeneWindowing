using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Zene.Graphics;

#nullable disable
#pragma warning disable CA1401

namespace Zene.Windowing.Base
{
	public static partial class GLFW
	{
#if WINDOWS
		private const string LinkLibrary = "glfw/win64/glfw3";
#elif UNIX
        private const string LinkLibrary = "GLFW";//"glfw/os64/libglfw";
#endif

		public const int VersionMajor = 3;
		public const int VersionMinor = 3;
		public const int VersionRevision = 0;
		public const int True = 1;
		public const int False = 0;
		public const int Release = 0;
		public const int Press = 1;
		public const int Repeat = 2;
		public const int HatCentered = 0;
		public const int HatUp = 1;
		public const int HatRight = 2;
		public const int HatDown = 4;
		public const int HatLeft = 8;
		public const int KeyUnknown = -1;
		public const int KeySpace = 32;
		public const int Key0 = 48;
		public const int Key1 = 49;
		public const int Key2 = 50;
		public const int Key3 = 51;
		public const int Key4 = 52;
		public const int Key5 = 53;
		public const int Key6 = 54;
		public const int Key7 = 55;
		public const int Key8 = 56;
		public const int Key9 = 57;
		public const int KeyA = 65;
		public const int KeyB = 66;
		public const int KeyC = 67;
		public const int KeyD = 68;
		public const int KeyE = 69;
		public const int KeyF = 70;
		public const int KeyG = 71;
		public const int KeyH = 72;
		public const int KeyI = 73;
		public const int KeyJ = 74;
		public const int KeyK = 75;
		public const int KeyL = 76;
		public const int KeyM = 77;
		public const int KeyN = 78;
		public const int KeyO = 79;
		public const int KeyP = 80;
		public const int KeyQ = 81;
		public const int KeyR = 82;
		public const int KeyS = 83;
		public const int KeyT = 84;
		public const int KeyU = 85;
		public const int KeyV = 86;
		public const int KeyW = 87;
		public const int KeyX = 88;
		public const int KeyY = 89;
		public const int KeyZ = 90;
		public const int KeyEscape = 256;
		public const int KeyEnter = 257;
		public const int KeyTab = 258;
		public const int KeyBackspace = 259;
		public const int KeyInsert = 260;
		public const int KeyDelete = 261;
		public const int KeyRight = 262;
		public const int KeyLeft = 263;
		public const int KeyDown = 264;
		public const int KeyUp = 265;
		public const int KeyPageUp = 266;
		public const int KeyPageDown = 267;
		public const int KeyHome = 268;
		public const int KeyEnd = 269;
		public const int KeyCapsLock = 280;
		public const int KeyScrollLock = 281;
		public const int KeyNumLock = 282;
		public const int KeyPrintScreen = 283;
		public const int KeyPause = 284;
		public const int KeyF1 = 290;
		public const int KeyF2 = 291;
		public const int KeyF3 = 292;
		public const int KeyF4 = 293;
		public const int KeyF5 = 294;
		public const int KeyF6 = 295;
		public const int KeyF7 = 296;
		public const int KeyF8 = 297;
		public const int KeyF9 = 298;
		public const int KeyF10 = 299;
		public const int KeyF11 = 300;
		public const int KeyF12 = 301;
		public const int KeyF13 = 302;
		public const int KeyF14 = 303;
		public const int KeyF15 = 304;
		public const int KeyF16 = 305;
		public const int KeyF17 = 306;
		public const int KeyF18 = 307;
		public const int KeyF19 = 308;
		public const int KeyF20 = 309;
		public const int KeyF21 = 310;
		public const int KeyF22 = 311;
		public const int KeyF23 = 312;
		public const int KeyF24 = 313;
		public const int KeyF25 = 314;
		public const int KeyKp0 = 320;
		public const int KeyKp1 = 321;
		public const int KeyKp2 = 322;
		public const int KeyKp3 = 323;
		public const int KeyKp4 = 324;
		public const int KeyKp5 = 325;
		public const int KeyKp6 = 326;
		public const int KeyKp7 = 327;
		public const int KeyKp8 = 328;
		public const int KeyKp9 = 329;
		public const int KeyKpDecimal = 330;
		public const int KeyKpDivide = 331;
		public const int KeyKpMultiply = 332;
		public const int KeyKpSubtract = 333;
		public const int KeyKpAdd = 334;
		public const int KeyKpEnter = 335;
		public const int KeyKpEqual = 336;
		public const int KeyLeftShift = 340;
		public const int KeyLeftControl = 341;
		public const int KeyLeftAlt = 342;
		public const int KeyLeftSuper = 343;
		public const int KeyRightShift = 344;
		public const int KeyRightControl = 345;
		public const int KeyRightAlt = 346;
		public const int KeyRightSuper = 347;
		public const int KeyMenu = 348;
		public const int KeyLast = KeyMenu;
		public const int ModShift = 0x0001;
		public const int ModControl = 0x0002;
		public const int ModAlt = 0x0004;
		public const int ModSuper = 0x0008;
		public const int ModCapsLock = 0x0010;
		public const int ModNumLock = 0x0020;
		public const int MouseButton1 = 0;
		public const int MouseButton2 = 1;
		public const int MouseButton3 = 2;
		public const int MouseButton4 = 3;
		public const int MouseButton5 = 4;
		public const int MouseButton6 = 5;
		public const int MouseButton7 = 6;
		public const int MouseButton8 = 7;
		public const int MouseButtonLast = MouseButton8;
		public const int MouseButtonLeft = MouseButton1;
		public const int MouseButtonRight = MouseButton2;
		public const int MouseButtonMiddle = MouseButton3;
		public const int Joystick1 = 0;
		public const int Joystick2 = 1;
		public const int Joystick3 = 2;
		public const int Joystick4 = 3;
		public const int Joystick5 = 4;
		public const int Joystick6 = 5;
		public const int Joystick7 = 6;
		public const int Joystick8 = 7;
		public const int Joystick9 = 8;
		public const int Joystick10 = 9;
		public const int Joystick11 = 10;
		public const int Joystick12 = 11;
		public const int Joystick13 = 12;
		public const int Joystick14 = 13;
		public const int Joystick15 = 14;
		public const int Joystick16 = 15;
		public const int JoystickLast = Joystick16;
		public const int GamepadButtonA = 0;
		public const int GamepadButtonB = 1;
		public const int GamepadButtonX = 2;
		public const int GamepadButtonY = 3;
		public const int GamepadButtonLeftBumper = 4;
		public const int GamepadButtonRightBumper = 5;
		public const int GamepadButtonBack = 6;
		public const int GamepadButtonStart = 7;
		public const int GamepadButtonGuide = 8;
		public const int GamepadButtonLeftThumb = 9;
		public const int GamepadButtonRightThumb = 10;
		public const int GamepadButtonDpadUp = 11;
		public const int GamepadButtonDpadRight = 12;
		public const int GamepadButtonDpadDown = 13;
		public const int GamepadButtonDpadLeft = 14;
		public const int GamepadButtonLast = GamepadButtonDpadLeft;
		public const int GamepadButtonCross = GamepadButtonA;
		public const int GamepadButtonCircle = GamepadButtonB;
		public const int GamepadButtonSquare = GamepadButtonX;
		public const int GamepadButtonTriangle = GamepadButtonY;
		public const int GamepadAxisLeftX = 0;
		public const int GamepadAxisLeftY = 1;
		public const int GamepadAxisRightX = 2;
		public const int GamepadAxisRightY = 3;
		public const int GamepadAxisLeftTrigger = 4;
		public const int GamepadAxisRightTrigger = 5;
		public const int GamepadAxisLast = GamepadAxisRightTrigger;
		public const int NoError = 0;
		public const int NotInitialized = 0x00010001;
		public const int NoCurrentContext = 0x00010002;
		public const int InvalidEnum = 0x00010003;
		public const int InvalidValue = 0x00010004;
		public const int OutOfMemory = 0x00010005;
		public const int ApiUnavailable = 0x00010006;
		public const int VersionUnavailable = 0x00010007;
		public const int PlatformError = 0x00010008;
		public const int FormatUnavailable = 0x00010009;
		public const int NoWindowContext = 0x0001000a;
		public const int Focused = 0x00020001;
		public const int Iconified = 0x00020002;
		public const int Resizable = 0x00020003;
		public const int Visible = 0x00020004;
		public const int Decorated = 0x00020005;
		public const int AutoIconify = 0x00020006;
		public const int Floating = 0x00020007;
		public const int Maximized = 0x00020008;
		public const int CenterCursor = 0x00020009;
		public const int TransparentFramebuffer = 0x0002000a;
		public const int Hovered = 0x0002000b;
		public const int FocusOnShow = 0x0002000c;
		public const int RedBits = 0x00021001;
		public const int GreenBits = 0x00021002;
		public const int BlueBits = 0x00021003;
		public const int AlphaBits = 0x00021004;
		public const int DepthBits = 0x00021005;
		public const int StencilBits = 0x00021006;
		public const int AccumRedBits = 0x00021007;
		public const int AccumGreenBits = 0x00021008;
		public const int AccumBlueBits = 0x00021009;
		public const int AccumAlphaBits = 0x0002100a;
		public const int AuxBuffers = 0x0002100b;
		public const int Stereo = 0x0002100c;
		public const int Samples = 0x0002100d;
		public const int SrgbCapable = 0x0002100e;
		public const int RefreshRate = 0x0002100f;
		public const int Doublebuffer = 0x00021010;
		public const int ClientApi = 0x00022001;
		public const int ContextVersionMajor = 0x00022002;
		public const int ContextVersionMinor = 0x00022003;
		public const int ContextRevision = 0x00022004;
		public const int ContextRobustness = 0x00022005;
		public const int OpenglForwardCompat = 0x00022006;
		public const int OpenglDebugContext = 0x00022007;
		public const int OpenglProfile = 0x00022008;
		public const int ContextReleaseBehavior = 0x00022009;
		public const int ContextNoError = 0x0002200a;
		public const int ContextCreationApi = 0x0002200b;
		public const int ScaleToMonitor = 0x0002200c;
		public const int CocoaRetinaFramebuffer = 0x00023001;
		public const int CocoaFrameName = 0x00023002;
		public const int CocoaGraphicsSwitching = 0x00023003;
		public const int X11ClassName = 0x00024001;
		public const int X11InstanceName = 0x00024002;
		public const int NoApi = 0;
		public const int OpenglApi = 0x00030001;
		public const int OpenglEsApi = 0x00030002;
		public const int NoRobustness = 0;
		public const int NoResetNotification = 0x00031001;
		public const int LoseContextOnReset = 0x00031002;
		public const int OpenglAnyProfile = 0;
		public const int OpenglCoreProfile = 0x00032001;
		public const int OpenglCompatProfile = 0x00032002;
		public const int Cursor = 0x00033001;
		public const int StickyKeys = 0x00033002;
		public const int StickyMouseButtons = 0x00033003;
		public const int LockKeyMods = 0x00033004;
		public const int RawMouseMotion = 0x00033005;
		public const int CursorNormal = 0x00034001;
		public const int CursorHidden = 0x00034002;
		public const int CursorDisabled = 0x00034003;
		public const int AnyReleaseBehavior = 0;
		public const int ReleaseBehaviorFlush = 0x00035001;
		public const int ReleaseBehaviorNone = 0x00035002;
		public const int NativeContextApi = 0x00036001;
		public const int EglContextApi = 0x00036002;
		public const int OsmesaContextApi = 0x00036003;
		public const int ArrowCursor = 0x00036001;
		public const int IbeamCursor = 0x00036002;
		public const int CrosshairCursor = 0x00036003;
		public const int HandCursor = 0x00036004;
		public const int HresizeCursor = 0x00036005;
		public const int VresizeCursor = 0x00036006;
		public const int NWSEresizeCursor = 0x00036007;
		public const int NESWresizeCursor = 0x00036008;
		public const int ResizeAllCursor = 0x00036009;
		public const int NotAllowedCursor = 0x0003600A;
		public const int Connected = 0x00040001;
		public const int Disconnected = 0x00040002;
		public const int JoystickHatButtons = 0x00050001;
		public const int CocoaChdirResources = 0x00051001;
		public const int CocoaMenubar = 0x00051002;
		public const int DontCare = -1;

		public struct Image
		{
			public int Width { get; set; }
			public int Height { get; set; }
			public IntPtr Pixels { get; set; }
		}
		public struct GamePadState
		{
			public IntPtr Buttons { get; set; }
			public float Axes { get; set; }
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void ErrorHandler(int error,
			[MarshalAs(UnmanagedType.LPUTF8Str)]
			string description);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void WindowPosHandler(IntPtr window, int xpos, int ypos);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void WindowSizeHandler(IntPtr window, int width, int height);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void WindowCloseHandler(IntPtr window);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void WindowRefreshHandler(IntPtr window);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void WindowFocusHandler(IntPtr window, int focused);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void WindowIconifyHandler(IntPtr window, int iconified);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void WindowMaximizeHandler(IntPtr window, int iconified);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void FramebufferSizeHandler(IntPtr window, int width, int height);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void WindowContentScaleHandler(IntPtr window, float xscale, float yscale);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void MouseButtonHandler(IntPtr window, int button, int action, int mods);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void MousePosHandler(IntPtr window, double xpos, double ypos);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void MouseEnterHandler(IntPtr window, int entered);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void ScrollHandler(IntPtr window, double xoffset, double yoffset);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void KeyChangeHandler(IntPtr window, int key, int scancode, int action, int mods);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void CharHandler(IntPtr window, uint codepoint);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void CharModsHandler(IntPtr window, uint codepoint, int mods);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void FileDropHandler(IntPtr window, int count, IntPtr paths);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void MonitorHandler(IntPtr monitor, int @event);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
		public delegate void JoystickHandler(int jid, int @event);

#if UNIX
		internal static IntPtr ResolveRelativeDependencies(string libraryName, Assembly assembly, DllImportSearchPath? searchPath)
		{
			if (libraryName == "GLFW")
			{
                string exeFolder = AppDomain.CurrentDomain.BaseDirectory;
                return NativeLibrary.Load(Path.Combine(exeFolder, "glfw/os64/libglfw.so"), assembly, searchPath);
            }
			
			// Use default in all other cases
            return IntPtr.Zero;
        }
#endif

		/// <summary>
		/// Initializes the GLFW library.
		/// </summary>
		/// <remarks>
		/// This function initializes the GLFW library.  Before most GLFW functions can
		/// be used, GLFW must be initialized, and before an application terminates GLFW
		/// should be terminated in order to free any resources allocated during or
		/// after initialization.
		/// </remarks>
		/// <returns>
		/// `GLFW_TRUE` if successful, or `GLFW_FALSE` if an
		/// [error](@ref error_handling) occurred.
		/// </returns>
		[LibraryImport(LinkLibrary, EntryPoint = "glfwInit")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static partial int Init();

		/// <summary>
		/// Terminates the GLFW library.
		/// </summary>
		/// <remarks>
		/// This function destroys all remaining windows and cursors, restores any
		/// modified gamma ramps and frees any other allocated resources.  Once this
		/// function is called, you must again call @ref Init successfully before
		/// you will be able to use most GLFW functions.
		/// </remarks>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwTerminate")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static partial void Terminate();

		/// <summary>
		/// Sets the specified init hint to the desired value.
		/// </summary>
		/// <remarks>
		/// This function sets hints for the next initialization of GLFW.
		/// </remarks>
		/// <param name="hint">
		/// The [init hint](@ref init_hints) to set.
		/// </param>
		/// <param name="value">
		/// The new value of the init hint.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwInitHint")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static partial void InitHint(int hint, int value);

		/// <summary>
		/// Retrieves the version of the GLFW library.
		/// </summary>
		/// <remarks>
		/// This function retrieves the major, minor and revision numbers of the GLFW
		/// library.  It is intended for when you are using GLFW as a shared library and
		/// want to ensure that you are using the minimum required version.
		/// </remarks>
		/// <param name="major">
		/// Where to store the major version number, or `NULL`.
		/// </param>
		/// <param name="minor">
		/// Where to store the minor version number, or `NULL`.
		/// </param>
		/// <param name="rev">
		/// Where to store the revision number, or `NULL`.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetVersion")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static partial void GetVersion(out int major, out int minor, out int rev);

        /// <summary>
        /// Returns a string describing the compile-time configuration.
        /// </summary>
        /// <remarks>
        /// This function returns the compile-time generated
        /// [version string](@ref intro_version_string) of the GLFW library binary.  It
        /// describes the version, platform, compiler and any platform-specific
        /// compile-time options.  It should not be confused with the OpenGL or OpenGL
        /// ES version string, queried with `glGetString`.
        /// </remarks>
        /// <returns>
        /// The ASCII encoded GLFW version string.
        /// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetVersionString", StringMarshalling = StringMarshalling.Utf8)]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        public static partial string GetVersionString();

		/// <summary>
		/// Returns and clears the last error for the calling thread.
		/// </summary>
		/// <remarks>
		/// This function returns and clears the [error code](@ref errors) of the last
		/// error that occurred on the calling thread, and optionally a UTF-8 encoded
		/// human-readable description of it.  If no error has occurred since the last
		/// call, it returns @ref GLFW_NO_ERROR (zero) and the description pointer is
		/// set to `NULL`.
		/// </remarks>
		/// <param name="description">
		/// Where to store the error description pointer, or `NULL`.
		/// </param>
		/// <returns>
		/// The last error code for the calling thread, or @ref GLFW_NO_ERROR
		/// (zero).
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetError")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial int GetError(IntPtr description);

		/// <summary>
		/// Sets the error callback.
		/// </summary>
		/// <remarks>
		/// This function sets the error callback, which is called with an error code
		/// and a human-readable description each time a GLFW error occurs.
		/// </remarks>
		/// <param name="cbfun">
		/// The new callback, or `NULL` to remove the currently set
		/// callback.
		/// </param>
		/// <returns>
		/// The previously set callback, or `NULL` if no callback was set.
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwSetErrorCallback")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial ErrorHandler SetErrorCallback(ErrorHandler cbfun);

        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetMonitors")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		private static partial IntPtr _glfwGetMonitors(out int count);

		/// <summary>
		/// Returns the primary monitor.
		/// </summary>
		/// <remarks>
		/// This function returns the primary monitor.  This is usually the monitor
		/// where elements like the task bar or global menu bar are located.
		/// </remarks>
		/// <returns>
		/// The primary monitor, or `NULL` if no monitors were found or if an
		/// [error](@ref error_handling) occurred.
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetPrimaryMonitor")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial IntPtr GetPrimaryMonitor();

		/// <summary>
		/// Returns the position of the monitor's viewport on the virtual screen.
		/// </summary>
		/// <remarks>
		/// This function returns the position, in screen coordinates, of the upper-left
		/// corner of the specified monitor.
		/// </remarks>
		/// <param name="monitor">
		/// The monitor to query.
		/// </param>
		/// <param name="xpos">
		/// Where to store the monitor x-coordinate, or `NULL`.
		/// </param>
		/// <param name="ypos">
		/// Where to store the monitor y-coordinate, or `NULL`.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetMonitorPos")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void GetMonitorPos(IntPtr monitor, out int xpos, out int ypos);

		/// <summary>
		/// Retrives the work area of the monitor.
		/// </summary>
		/// <remarks>
		/// This function returns the position, in screen coordinates, of the upper-left
		/// corner of the work area of the specified monitor along with the work area
		/// size in screen coordinates. The work area is defined as the area of the
		/// monitor not occluded by the operating system task bar where present. If no
		/// task bar exists then the work area is the monitor resolution in screen
		/// coordinates.
		/// </remarks>
		/// <param name="monitor">
		/// The monitor to query.
		/// </param>
		/// <param name="xpos">
		/// Where to store the monitor x-coordinate, or `NULL`.
		/// </param>
		/// <param name="ypos">
		/// Where to store the monitor y-coordinate, or `NULL`.
		/// </param>
		/// <param name="width">
		/// Where to store the monitor width, or `NULL`.
		/// </param>
		/// <param name="height">
		/// Where to store the monitor height, or `NULL`.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetMonitorWorkarea")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void GetMonitorWorkarea(IntPtr monitor, out int xpos, out int ypos, out int width, out int height);

		/// <summary>
		/// Returns the physical size of the monitor.
		/// </summary>
		/// <remarks>
		/// This function returns the size, in millimetres, of the display area of the
		/// specified monitor.
		/// </remarks>
		/// <param name="monitor">
		/// The monitor to query.
		/// </param>
		/// <param name="widthMM">
		/// Where to store the width, in millimetres, of the
		/// monitor's display area, or `NULL`.
		/// </param>
		/// <param name="heightMM">
		/// Where to store the height, in millimetres, of the
		/// monitor's display area, or `NULL`.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetMonitorPhysicalSize")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void GetMonitorPhysicalSize(IntPtr monitor, out int widthMM, out int heightMM);

		/// <summary>
		/// Retrieves the content scale for the specified monitor.
		/// </summary>
		/// <remarks>
		/// This function retrieves the content scale for the specified monitor.  The
		/// content scale is the ratio between the current DPI and the platform's
		/// default DPI.  This is especially important for text and any UI elements.  If
		/// the pixel dimensions of your UI scaled by this look appropriate on your
		/// machine then it should appear at a reasonable size on other machines
		/// regardless of their DPI and scaling settings.  This relies on the system DPI
		/// and scaling settings being somewhat correct.
		/// </remarks>
		/// <param name="monitor">
		/// The monitor to query.
		/// </param>
		/// <param name="xscale">
		/// Where to store the x-axis content scale, or `NULL`.
		/// </param>
		/// <param name="yscale">
		/// Where to store the y-axis content scale, or `NULL`.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetMonitorContentScale")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void GetMonitorContentScale(IntPtr monitor, out IntPtr xscale, out IntPtr yscale);

		/// <summary>
		/// Returns the name of the specified monitor.
		/// </summary>
		/// <remarks>
		/// This function returns a human-readable name, encoded as UTF-8, of the
		/// specified monitor.  The name typically reflects the make and model of the
		/// monitor and is not guaranteed to be unique among the connected monitors.
		/// </remarks>
		/// <param name="monitor">
		/// The monitor to query.
		/// </param>
		/// <returns>
		/// The UTF-8 encoded name of the monitor, or `NULL` if an
		/// [error](@ref error_handling) occurred.
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetMonitorName")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial IntPtr GetMonitorName(IntPtr monitor);

		/// <summary>
		/// Sets the user pointer of the specified monitor.
		/// </summary>
		/// <remarks>
		/// This function sets the user-defined pointer of the specified monitor.  The
		/// current value is retained until the monitor is disconnected.  The initial
		/// value is `NULL`.
		/// </remarks>
		/// <param name="monitor">
		/// The monitor whose pointer to set.
		/// </param>
		/// <param name="pointer">
		/// The new value.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwSetMonitorUserPointer")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void SetMonitorUserPointer(IntPtr monitor, IntPtr pointer);

		/// <summary>
		/// Returns the user pointer of the specified monitor.
		/// </summary>
		/// <remarks>
		/// This function returns the current value of the user-defined pointer of the
		/// specified monitor.  The initial value is `NULL`.
		/// </remarks>
		/// <param name="monitor">
		/// The monitor whose pointer to return.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetMonitorUserPointer")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial IntPtr GetMonitorUserPointer(IntPtr monitor);

		/// <summary>
		/// Sets the monitor configuration callback.
		/// </summary>
		/// <remarks>
		/// This function sets the monitor configuration callback, or removes the
		/// currently set callback.  This is called when a monitor is connected to or
		/// disconnected from the system.
		/// </remarks>
		/// <param name="cbfun">
		/// The new callback, or `NULL` to remove the currently set
		/// callback.
		/// </param>
		/// <returns>
		/// The previously set callback, or `NULL` if no callback was set or the
		/// library had not been [initialized](@ref intro_init).
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwSetMonitorCallback")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial MonitorHandler SetMonitorCallback(MonitorHandler cbfun);

		/// <summary>
		/// Returns the available video modes for the specified monitor.
		/// </summary>
		/// <remarks>
		/// This function returns an array of all video modes supported by the specified
		/// monitor.  The returned array is sorted in ascending order, first by colour
		/// bit depth (the sum of all channel depths) and then by resolution area (the
		/// product of width and height).
		/// </remarks>
		/// <param name="monitor">
		/// The monitor to query.
		/// </param>
		/// <param name="count">
		/// Where to store the number of video modes in the returned
		/// array.  This is set to zero if an error occurred.
		/// </param>
		/// <returns>
		/// An array of video modes, or `NULL` if an
		/// [error](@ref error_handling) occurred.
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetVideoModes")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial IntPtr GetVideoModes(IntPtr monitor, out int count);

        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetVideoMode")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		private static partial IntPtr _glfwGetVideoMode(IntPtr monitor);

		/// <summary>
		/// Generates a gamma ramp and sets it for the specified monitor.
		/// </summary>
		/// <remarks>
		/// This function generates an appropriately sized gamma ramp from the specified
		/// exponent and then calls @ref SetGammaRamp with it.  The value must be
		/// a finite number greater than zero.
		/// </remarks>
		/// <param name="monitor">
		/// The monitor whose gamma ramp to set.
		/// </param>
		/// <param name="gamma">
		/// The desired exponent.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwSetGamma")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void SetGamma(IntPtr monitor, float gamma);

        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetGammaRamp")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		private static partial IntPtr _glfwGetGammaRamp(IntPtr monitor);

		/// <summary>
		/// Sets the current gamma ramp for the specified monitor.
		/// </summary>
		/// <remarks>
		/// This function sets the current gamma ramp for the specified monitor.  The
		/// original gamma ramp for that monitor is saved by GLFW the first time this
		/// function is called and is restored by @ref Terminate.
		/// </remarks>
		/// <param name="monitor">
		/// The monitor whose gamma ramp to set.
		/// </param>
		/// <param name="ramp">
		/// The gamma ramp to use.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwSetGammaRamp")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void SetGammaRamp(IntPtr monitor, IntPtr ramp);

		/// <summary>
		/// Resets all window hints to their default values.
		/// </summary>
		/// <remarks>
		/// This function resets all window hints to their
		/// [default values](@ref window_hints_values).
		/// </remarks>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwDefaultWindowHints")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void DefaultWindowHints();

		/// <summary>
		/// Sets the specified window hint to the desired value.
		/// </summary>
		/// <remarks>
		/// This function sets hints for the next call to @ref CreateWindow.  The
		/// hints, once set, retain their values until changed by a call to this
		/// function or @ref DefaultWindowHints, or until the library is terminated.
		/// </remarks>
		/// <param name="hint">
		/// The [window hint](@ref window_hints) to set.
		/// </param>
		/// <param name="value">
		/// The new value of the window hint.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwWindowHint")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void WindowHint(int hint, int value);

		/// <summary>
		/// Sets the specified window hint to the desired value.
		/// </summary>
		/// <remarks>
		/// This function sets hints for the next call to @ref CreateWindow.  The
		/// hints, once set, retain their values until changed by a call to this
		/// function or @ref DefaultWindowHints, or until the library is terminated.
		/// </remarks>
		/// <param name="hint">
		/// The [window hint](@ref window_hints) to set.
		/// </param>
		/// <param name="value">
		/// The new value of the window hint.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwWindowHintString", StringMarshalling = StringMarshalling.Utf8)]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void WindowHintString(int hint, string value);

        [LibraryImport(LinkLibrary, EntryPoint = "glfwCreateWindow", StringMarshalling = StringMarshalling.Utf8)]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		private static partial IntPtr _glfwCreateWindow(int width, int height, string title, IntPtr monitor, IntPtr share);

        [LibraryImport(LinkLibrary, EntryPoint = "glfwDestroyWindow")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		private static partial void _glfwDestroyWindow(IntPtr window);

		/// <summary>
		/// Checks the close flag of the specified window.
		/// </summary>
		/// <remarks>
		/// This function returns the value of the close flag of the specified window.
		/// </remarks>
		/// <param name="window">
		/// The window to query.
		/// </param>
		/// <returns>
		/// The value of the close flag.
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwWindowShouldClose")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial int WindowShouldClose(IntPtr window);

		/// <summary>
		/// Sets the close flag of the specified window.
		/// </summary>
		/// <remarks>
		/// This function sets the value of the close flag of the specified window.
		/// This can be used to override the user's attempt to close the window, or
		/// to signal that it should be closed.
		/// </remarks>
		/// <param name="window">
		/// The window whose flag to change.
		/// </param>
		/// <param name="value">
		/// The new value.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwSetWindowShouldClose")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void SetWindowShouldClose(IntPtr window, int value);

		/// <summary>
		/// Sets the title of the specified window.
		/// </summary>
		/// <remarks>
		/// This function sets the window title, encoded as UTF-8, of the specified
		/// window.
		/// </remarks>
		/// <param name="window">
		/// The window whose title to change.
		/// </param>
		/// <param name="title">
		/// The UTF-8 encoded window title.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwSetWindowTitle", StringMarshalling = StringMarshalling.Utf8)]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void SetWindowTitle(IntPtr window, string title);

		/// <summary>
		/// Sets the icon for the specified window.
		/// </summary>
		/// <remarks>
		/// This function sets the icon of the specified window.  If passed an array of
		/// candidate images, those of or closest to the sizes desired by the system are
		/// selected.  If no images are specified, the window reverts to its default
		/// icon.
		/// </remarks>
		/// <param name="window">
		/// The window whose icon to set.
		/// </param>
		/// <param name="count">
		/// The number of images in the specified array, or zero to
		/// revert to the default window icon.
		/// </param>
		/// <param name="images">
		/// The images to create the icon from.  This is ignored if
		/// count is zero.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwSetWindowIcon")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void SetWindowIcon(IntPtr window, int count, IntPtr images);

		/// <summary>
		/// Retrieves the position of the content area of the specified window.
		/// </summary>
		/// <remarks>
		/// This function retrieves the position, in screen coordinates, of the
		/// upper-left corner of the content area of the specified window.
		/// </remarks>
		/// <param name="window">
		/// The window to query.
		/// </param>
		/// <param name="xpos">
		/// Where to store the x-coordinate of the upper-left corner of
		/// the content area, or `NULL`.
		/// </param>
		/// <param name="ypos">
		/// Where to store the y-coordinate of the upper-left corner of
		/// the content area, or `NULL`.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetWindowPos")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void GetWindowPos(IntPtr window, out int xpos, out int ypos);

		/// <summary>
		/// Sets the position of the content area of the specified window.
		/// </summary>
		/// <remarks>
		/// This function sets the position, in screen coordinates, of the upper-left
		/// corner of the content area of the specified windowed mode window.  If the
		/// window is a full screen window, this function does nothing.
		/// </remarks>
		/// <param name="window">
		/// The window to query.
		/// </param>
		/// <param name="xpos">
		/// The x-coordinate of the upper-left corner of the content area.
		/// </param>
		/// <param name="ypos">
		/// The y-coordinate of the upper-left corner of the content area.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwSetWindowPos")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void SetWindowPos(IntPtr window, int xpos, int ypos);

		/// <summary>
		/// Retrieves the size of the content area of the specified window.
		/// </summary>
		/// <remarks>
		/// This function retrieves the size, in screen coordinates, of the content area
		/// of the specified window.  If you wish to retrieve the size of the
		/// framebuffer of the window in pixels, see @ref GetFramebufferSize.
		/// </remarks>
		/// <param name="window">
		/// The window whose size to retrieve.
		/// </param>
		/// <param name="width">
		/// Where to store the width, in screen coordinates, of the
		/// content area, or `NULL`.
		/// </param>
		/// <param name="height">
		/// Where to store the height, in screen coordinates, of the
		/// content area, or `NULL`.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetWindowSize")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void GetWindowSize(IntPtr window, out int width, out int height);

		/// <summary>
		/// Sets the size limits of the specified window.
		/// </summary>
		/// <remarks>
		/// This function sets the size limits of the content area of the specified
		/// window.  If the window is full screen, the size limits only take effect
		/// once it is made windowed.  If the window is not resizable, this function
		/// does nothing.
		/// </remarks>
		/// <param name="window">
		/// The window to set limits for.
		/// </param>
		/// <param name="minwidth">
		/// The minimum width, in screen coordinates, of the content
		/// area, or `GLFW_DONT_CARE`.
		/// </param>
		/// <param name="minheight">
		/// The minimum height, in screen coordinates, of the
		/// content area, or `GLFW_DONT_CARE`.
		/// </param>
		/// <param name="maxwidth">
		/// The maximum width, in screen coordinates, of the content
		/// area, or `GLFW_DONT_CARE`.
		/// </param>
		/// <param name="maxheight">
		/// The maximum height, in screen coordinates, of the
		/// content area, or `GLFW_DONT_CARE`.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwSetWindowSizeLimits")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void SetWindowSizeLimits(IntPtr window, int minwidth, int minheight, int maxwidth, int maxheight);

		/// <summary>
		/// Sets the aspect ratio of the specified window.
		/// </summary>
		/// <remarks>
		/// This function sets the required aspect ratio of the content area of the
		/// specified window.  If the window is full screen, the aspect ratio only takes
		/// effect once it is made windowed.  If the window is not resizable, this
		/// function does nothing.
		/// </remarks>
		/// <param name="window">
		/// The window to set limits for.
		/// </param>
		/// <param name="numer">
		/// The numerator of the desired aspect ratio, or
		/// `GLFW_DONT_CARE`.
		/// </param>
		/// <param name="denom">
		/// The denominator of the desired aspect ratio, or
		/// `GLFW_DONT_CARE`.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwSetWindowAspectRatio")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void SetWindowAspectRatio(IntPtr window, int numer, int denom);

		/// <summary>
		/// Sets the size of the content area of the specified window.
		/// </summary>
		/// <remarks>
		/// This function sets the size, in screen coordinates, of the content area of
		/// the specified window.
		/// </remarks>
		/// <param name="window">
		/// The window to resize.
		/// </param>
		/// <param name="width">
		/// The desired width, in screen coordinates, of the window
		/// content area.
		/// </param>
		/// <param name="height">
		/// The desired height, in screen coordinates, of the window
		/// content area.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwSetWindowSize")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void SetWindowSize(IntPtr window, int width, int height);

		/// <summary>
		/// Retrieves the size of the framebuffer of the specified window.
		/// </summary>
		/// <remarks>
		/// This function retrieves the size, in pixels, of the framebuffer of the
		/// specified window.  If you wish to retrieve the size of the window in screen
		/// coordinates, see @ref GetWindowSize.
		/// </remarks>
		/// <param name="window">
		/// The window whose framebuffer to query.
		/// </param>
		/// <param name="width">
		/// Where to store the width, in pixels, of the framebuffer,
		/// or `NULL`.
		/// </param>
		/// <param name="height">
		/// Where to store the height, in pixels, of the framebuffer,
		/// or `NULL`.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetFramebufferSize")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void GetFramebufferSize(IntPtr window, out int width, out int height);

		/// <summary>
		/// Retrieves the size of the frame of the window.
		/// </summary>
		/// <remarks>
		/// This function retrieves the size, in screen coordinates, of each edge of the
		/// frame of the specified window.  This size includes the title bar, if the
		/// window has one.  The size of the frame may vary depending on the
		/// [window-related hints](@ref window_hints_wnd) used to create it.
		/// </remarks>
		/// <param name="window">
		/// The window whose frame size to query.
		/// </param>
		/// <param name="left">
		/// Where to store the size, in screen coordinates, of the left
		/// edge of the window frame, or `NULL`.
		/// </param>
		/// <param name="top">
		/// Where to store the size, in screen coordinates, of the top
		/// edge of the window frame, or `NULL`.
		/// </param>
		/// <param name="right">
		/// Where to store the size, in screen coordinates, of the
		/// right edge of the window frame, or `NULL`.
		/// </param>
		/// <param name="bottom">
		/// Where to store the size, in screen coordinates, of the
		/// bottom edge of the window frame, or `NULL`.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetWindowFrameSize")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void GetWindowFrameSize(IntPtr window, out int left, out int top, out int right, out int bottom);

		/// <summary>
		/// Retrieves the content scale for the specified window.
		/// </summary>
		/// <remarks>
		/// This function retrieves the content scale for the specified window.  The
		/// content scale is the ratio between the current DPI and the platform's
		/// default DPI.  This is especially important for text and any UI elements.  If
		/// the pixel dimensions of your UI scaled by this look appropriate on your
		/// machine then it should appear at a reasonable size on other machines
		/// regardless of their DPI and scaling settings.  This relies on the system DPI
		/// and scaling settings being somewhat correct.
		/// </remarks>
		/// <param name="window">
		/// The window to query.
		/// </param>
		/// <param name="xscale">
		/// Where to store the x-axis content scale, or `NULL`.
		/// </param>
		/// <param name="yscale">
		/// Where to store the y-axis content scale, or `NULL`.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetWindowContentScale")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void GetWindowContentScale(IntPtr window, out IntPtr xscale, out IntPtr yscale);

		/// <summary>
		/// Returns the opacity of the whole window.
		/// </summary>
		/// <remarks>
		/// This function returns the opacity of the window, including any decorations.
		/// </remarks>
		/// <param name="window">
		/// The window to query.
		/// </param>
		/// <returns>
		/// The opacity value of the specified window.
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetWindowOpacity")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial float GetWindowOpacity(IntPtr window);

		/// <summary>
		/// Sets the opacity of the whole window.
		/// </summary>
		/// <remarks>
		/// This function sets the opacity of the window, including any decorations.
		/// </remarks>
		/// <param name="window">
		/// The window to set the opacity for.
		/// </param>
		/// <param name="opacity">
		/// The desired opacity of the specified window.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwSetWindowOpacity")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void SetWindowOpacity(IntPtr window, float opacity);

		/// <summary>
		/// Iconifies the specified window.
		/// </summary>
		/// <remarks>
		/// This function iconifies (minimizes) the specified window if it was
		/// previously restored.  If the window is already iconified, this function does
		/// nothing.
		/// </remarks>
		/// <param name="window">
		/// The window to iconify.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwIconifyWindow")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void IconifyWindow(IntPtr window);

		/// <summary>
		/// Restores the specified window.
		/// </summary>
		/// <remarks>
		/// This function restores the specified window if it was previously iconified
		/// (minimized) or maximized.  If the window is already restored, this function
		/// does nothing.
		/// </remarks>
		/// <param name="window">
		/// The window to restore.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwRestoreWindow")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void RestoreWindow(IntPtr window);

		/// <summary>
		/// Maximizes the specified window.
		/// </summary>
		/// <remarks>
		/// This function maximizes the specified window if it was previously not
		/// maximized.  If the window is already maximized, this function does nothing.
		/// </remarks>
		/// <param name="window">
		/// The window to maximize.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwMaximizeWindow")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void MaximizeWindow(IntPtr window);

		/// <summary>
		/// Makes the specified window visible.
		/// </summary>
		/// <remarks>
		/// This function makes the specified window visible if it was previously
		/// hidden.  If the window is already visible or is in full screen mode, this
		/// function does nothing.
		/// </remarks>
		/// <param name="window">
		/// The window to make visible.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwShowWindow")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void ShowWindow(IntPtr window);

		/// <summary>
		/// Hides the specified window.
		/// </summary>
		/// <remarks>
		/// This function hides the specified window if it was previously visible.  If
		/// the window is already hidden or is in full screen mode, this function does
		/// nothing.
		/// </remarks>
		/// <param name="window">
		/// The window to hide.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwHideWindow")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void HideWindow(IntPtr window);

		/// <summary>
		/// Brings the specified window to front and sets input focus.
		/// </summary>
		/// <remarks>
		/// This function brings the specified window to front and sets input focus.
		/// The window should already be visible and not iconified.
		/// </remarks>
		/// <param name="window">
		/// The window to give input focus.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwFocusWindow")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void FocusWindow(IntPtr window);

		/// <summary>
		/// Requests user attention to the specified window.
		/// </summary>
		/// <remarks>
		/// This function requests user attention to the specified window.  On
		/// platforms where this is not supported, attention is requested to the
		/// application as a whole.
		/// </remarks>
		/// <param name="window">
		/// The window to request attention to.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwRequestWindowAttention")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void RequestWindowAttention(IntPtr window);

		/// <summary>
		/// Returns the monitor that the window uses for full screen mode.
		/// </summary>
		/// <remarks>
		/// This function returns the handle of the monitor that the specified window is
		/// in full screen on.
		/// </remarks>
		/// <param name="window">
		/// The window to query.
		/// </param>
		/// <returns>
		/// The monitor, or `NULL` if the window is in windowed mode or an
		/// [error](@ref error_handling) occurred.
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetWindowMonitor")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial IntPtr GetWindowMonitor(IntPtr window);

		/// <summary>
		/// Sets the mode, monitor, video mode and placement of a window.
		/// </summary>
		/// <remarks>
		/// This function sets the monitor that the window uses for full screen mode or,
		/// if the monitor is `NULL`, makes it windowed mode.
		/// </remarks>
		/// <param name="window">
		/// The window whose monitor, size or video mode to set.
		/// </param>
		/// <param name="monitor">
		/// The desired monitor, or `NULL` to set windowed mode.
		/// </param>
		/// <param name="xpos">
		/// The desired x-coordinate of the upper-left corner of the
		/// content area.
		/// </param>
		/// <param name="ypos">
		/// The desired y-coordinate of the upper-left corner of the
		/// content area.
		/// </param>
		/// <param name="width">
		/// The desired with, in screen coordinates, of the content
		/// area or video mode.
		/// </param>
		/// <param name="height">
		/// The desired height, in screen coordinates, of the content
		/// area or video mode.
		/// </param>
		/// <param name="refreshRate">
		/// The desired refresh rate, in Hz, of the video mode,
		/// or `GLFW_DONT_CARE`.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwSetWindowMonitor")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void SetWindowMonitor(IntPtr window, IntPtr monitor, int xpos, int ypos, int width, int height, int refreshRate);

		/// <summary>
		/// Returns an attribute of the specified window.
		/// </summary>
		/// <remarks>
		/// This function returns the value of an attribute of the specified window or
		/// its OpenGL or OpenGL ES context.
		/// </remarks>
		/// <param name="window">
		/// The window to query.
		/// </param>
		/// <param name="attrib">
		/// The [window attribute](@ref window_attribs) whose value to
		/// return.
		/// </param>
		/// <returns>
		/// The value of the attribute, or zero if an
		/// [error](@ref error_handling) occurred.
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetWindowAttrib")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial int GetWindowAttrib(IntPtr window, int attrib);

		/// <summary>
		/// Sets an attribute of the specified window.
		/// </summary>
		/// <remarks>
		/// This function sets the value of an attribute of the specified window.
		/// </remarks>
		/// <param name="window">
		/// The window to set the attribute for.
		/// </param>
		/// <param name="attrib">
		/// A supported window attribute.
		/// </param>
		/// <param name="value">
		/// `GLFW_TRUE` or `GLFW_FALSE`.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwSetWindowAttrib")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void SetWindowAttrib(IntPtr window, int attrib, int value);

		/// <summary>
		/// Sets the user pointer of the specified window.
		/// </summary>
		/// <remarks>
		/// This function sets the user-defined pointer of the specified window.  The
		/// current value is retained until the window is destroyed.  The initial value
		/// is `NULL`.
		/// </remarks>
		/// <param name="window">
		/// The window whose pointer to set.
		/// </param>
		/// <param name="pointer">
		/// The new value.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwSetWindowUserPointer")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void SetWindowUserPointer(IntPtr window, IntPtr pointer);

		/// <summary>
		/// Returns the user pointer of the specified window.
		/// </summary>
		/// <remarks>
		/// This function returns the current value of the user-defined pointer of the
		/// specified window.  The initial value is `NULL`.
		/// </remarks>
		/// <param name="window">
		/// The window whose pointer to return.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetWindowUserPointer")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial IntPtr GetWindowUserPointer(IntPtr window);

		/// <summary>
		/// Sets the position callback for the specified window.
		/// </summary>
		/// <remarks>
		/// This function sets the position callback of the specified window, which is
		/// called when the window is moved.  The callback is provided with the
		/// position, in screen coordinates, of the upper-left corner of the content
		/// area of the window.
		/// </remarks>
		/// <param name="window">
		/// The window whose callback to set.
		/// </param>
		/// <param name="cbfun">
		/// The new callback, or `NULL` to remove the currently set
		/// callback.
		/// </param>
		/// <returns>
		/// The previously set callback, or `NULL` if no callback was set or the
		/// library had not been [initialized](@ref intro_init).
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwSetWindowPosCallback")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial WindowPosHandler SetWindowPosCallback(IntPtr window, WindowPosHandler cbfun);

		/// <summary>
		/// Sets the size callback for the specified window.
		/// </summary>
		/// <remarks>
		/// This function sets the size callback of the specified window, which is
		/// called when the window is resized.  The callback is provided with the size,
		/// in screen coordinates, of the content area of the window.
		/// </remarks>
		/// <param name="window">
		/// The window whose callback to set.
		/// </param>
		/// <param name="cbfun">
		/// The new callback, or `NULL` to remove the currently set
		/// callback.
		/// </param>
		/// <returns>
		/// The previously set callback, or `NULL` if no callback was set or the
		/// library had not been [initialized](@ref intro_init).
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwSetWindowSizeCallback")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial WindowSizeHandler SetWindowSizeCallback(IntPtr window, WindowSizeHandler cbfun);

		/// <summary>
		/// Sets the close callback for the specified window.
		/// </summary>
		/// <remarks>
		/// This function sets the close callback of the specified window, which is
		/// called when the user attempts to close the window, for example by clicking
		/// the close widget in the title bar.
		/// </remarks>
		/// <param name="window">
		/// The window whose callback to set.
		/// </param>
		/// <param name="cbfun">
		/// The new callback, or `NULL` to remove the currently set
		/// callback.
		/// </param>
		/// <returns>
		/// The previously set callback, or `NULL` if no callback was set or the
		/// library had not been [initialized](@ref intro_init).
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwSetWindowCloseCallback")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial WindowCloseHandler SetWindowCloseCallback(IntPtr window, WindowCloseHandler cbfun);

		/// <summary>
		/// Sets the refresh callback for the specified window.
		/// </summary>
		/// <remarks>
		/// This function sets the refresh callback of the specified window, which is
		/// called when the content area of the window needs to be redrawn, for example
		/// if the window has been exposed after having been covered by another window.
		/// </remarks>
		/// <param name="window">
		/// The window whose callback to set.
		/// </param>
		/// <param name="cbfun">
		/// The new callback, or `NULL` to remove the currently set
		/// callback.
		/// </param>
		/// <returns>
		/// The previously set callback, or `NULL` if no callback was set or the
		/// library had not been [initialized](@ref intro_init).
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwSetWindowRefreshCallback")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial WindowRefreshHandler SetWindowRefreshCallback(IntPtr window, WindowRefreshHandler cbfun);

		/// <summary>
		/// Sets the focus callback for the specified window.
		/// </summary>
		/// <remarks>
		/// This function sets the focus callback of the specified window, which is
		/// called when the window gains or loses input focus.
		/// </remarks>
		/// <param name="window">
		/// The window whose callback to set.
		/// </param>
		/// <param name="cbfun">
		/// The new callback, or `NULL` to remove the currently set
		/// callback.
		/// </param>
		/// <returns>
		/// The previously set callback, or `NULL` if no callback was set or the
		/// library had not been [initialized](@ref intro_init).
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwSetWindowFocusCallback")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial WindowFocusHandler SetWindowFocusCallback(IntPtr window, WindowFocusHandler cbfun);

		/// <summary>
		/// Sets the iconify callback for the specified window.
		/// </summary>
		/// <remarks>
		/// This function sets the iconification callback of the specified window, which
		/// is called when the window is iconified or restored.
		/// </remarks>
		/// <param name="window">
		/// The window whose callback to set.
		/// </param>
		/// <param name="cbfun">
		/// The new callback, or `NULL` to remove the currently set
		/// callback.
		/// </param>
		/// <returns>
		/// The previously set callback, or `NULL` if no callback was set or the
		/// library had not been [initialized](@ref intro_init).
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwSetWindowIconifyCallback")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial WindowIconifyHandler SetWindowIconifyCallback(IntPtr window, WindowIconifyHandler cbfun);

		/// <summary>
		/// Sets the maximize callback for the specified window.
		/// </summary>
		/// <remarks>
		/// This function sets the maximization callback of the specified window, which
		/// is called when the window is maximized or restored.
		/// </remarks>
		/// <param name="window">
		/// The window whose callback to set.
		/// </param>
		/// <param name="cbfun">
		/// The new callback, or `NULL` to remove the currently set
		/// callback.
		/// </param>
		/// <returns>
		/// The previously set callback, or `NULL` if no callback was set or the
		/// library had not been [initialized](@ref intro_init).
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwSetWindowMaximizeCallback")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial WindowMaximizeHandler SetWindowMaximizeCallback(IntPtr window, WindowMaximizeHandler cbfun);

		/// <summary>
		/// Sets the framebuffer resize callback for the specified window.
		/// </summary>
		/// <remarks>
		/// This function sets the framebuffer resize callback of the specified window,
		/// which is called when the framebuffer of the specified window is resized.
		/// </remarks>
		/// <param name="window">
		/// The window whose callback to set.
		/// </param>
		/// <param name="cbfun">
		/// The new callback, or `NULL` to remove the currently set
		/// callback.
		/// </param>
		/// <returns>
		/// The previously set callback, or `NULL` if no callback was set or the
		/// library had not been [initialized](@ref intro_init).
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwSetFramebufferSizeCallback")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial FramebufferSizeHandler SetFramebufferSizeCallback(IntPtr window, FramebufferSizeHandler cbfun);

		/// <summary>
		/// Sets the window content scale callback for the specified window.
		/// </summary>
		/// <remarks>
		/// This function sets the window content scale callback of the specified window,
		/// which is called when the content scale of the specified window changes.
		/// </remarks>
		/// <param name="window">
		/// The window whose callback to set.
		/// </param>
		/// <param name="cbfun">
		/// The new callback, or `NULL` to remove the currently set
		/// callback.
		/// </param>
		/// <returns>
		/// The previously set callback, or `NULL` if no callback was set or the
		/// library had not been [initialized](@ref intro_init).
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwSetWindowContentScaleCallback")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial WindowContentScaleHandler SetWindowContentScaleCallback(IntPtr window, WindowContentScaleHandler cbfun);

		/// <summary>
		/// Processes all pending events.
		/// </summary>
		/// <remarks>
		/// This function processes only those events that are already in the event
		/// queue and then returns immediately.  Processing events will cause the window
		/// and input callbacks associated with those events to be called.
		/// </remarks>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwPollEvents")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void PollEvents();

		/// <summary>
		/// Waits until events are queued and processes them.
		/// </summary>
		/// <remarks>
		/// This function puts the calling thread to sleep until at least one event is
		/// available in the event queue.  Once one or more events are available,
		/// it behaves exactly like @ref PollEvents, i.e. the events in the queue
		/// are processed and the function then returns immediately.  Processing events
		/// will cause the window and input callbacks associated with those events to be
		/// called.
		/// </remarks>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwWaitEvents")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void WaitEvents();

		/// <summary>
		/// Waits with timeout until events are queued and processes them.
		/// </summary>
		/// <remarks>
		/// This function puts the calling thread to sleep until at least one event is
		/// available in the event queue, or until the specified timeout is reached.  If
		/// one or more events are available, it behaves exactly like @ref
		/// PollEvents, i.e. the events in the queue are processed and the function
		/// then returns immediately.  Processing events will cause the window and input
		/// callbacks associated with those events to be called.
		/// </remarks>
		/// <param name="timeout">
		/// The maximum amount of time, in seconds, to wait.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwWaitEventsTimeout")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void WaitEventsTimeout(double timeout);

		/// <summary>
		/// Posts an empty event to the event queue.
		/// </summary>
		/// <remarks>
		/// This function posts an empty event from the current thread to the event
		/// queue, causing @ref WaitEvents or @ref WaitEventsTimeout to return.
		/// </remarks>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwPostEmptyEvent")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void PostEmptyEvent();

		/// <summary>
		/// Returns the value of an input option for the specified window.
		/// </summary>
		/// <remarks>
		/// This function returns the value of an input option for the specified window.
		/// The mode must be one of @ref GLFW_CURSOR, @ref GLFW_STICKY_KEYS,
		/// </remarks>
		/// <param name="window">
		/// The window to query.
		/// </param>
		/// <param name="mode">
		/// One of `GLFW_CURSOR`, `GLFW_STICKY_KEYS`,
		/// `GLFW_STICKY_MOUSE_BUTTONS`, `GLFW_LOCK_KEY_MODS` or
		/// `GLFW_RAW_MOUSE_MOTION`.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetInputMode")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial int GetInputMode(IntPtr window, int mode);

		/// <summary>
		/// Sets an input option for the specified window.
		/// </summary>
		/// <remarks>
		/// This function sets an input mode option for the specified window.  The mode
		/// must be one of @ref GLFW_CURSOR, @ref GLFW_STICKY_KEYS,
		/// </remarks>
		/// <param name="window">
		/// The window whose input mode to set.
		/// </param>
		/// <param name="mode">
		/// One of `GLFW_CURSOR`, `GLFW_STICKY_KEYS`,
		/// `GLFW_STICKY_MOUSE_BUTTONS`, `GLFW_LOCK_KEY_MODS` or
		/// `GLFW_RAW_MOUSE_MOTION`.
		/// </param>
		/// <param name="value">
		/// The new value of the specified input mode.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwSetInputMode")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void SetInputMode(IntPtr window, int mode, int value);

		/// <summary>
		/// Returns whether raw mouse motion is supported.
		/// </summary>
		/// <remarks>
		/// This function returns whether raw mouse motion is supported on the current
		/// system.  This status does not change after GLFW has been initialized so you
		/// only need to check this once.  If you attempt to enable raw motion on
		/// a system that does not support it, @ref GLFW_PLATFORM_ERROR will be emitted.
		/// </remarks>
		/// <returns>
		/// `GLFW_TRUE` if raw mouse motion is supported on the current machine,
		/// or `GLFW_FALSE` otherwise.
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwRawMouseMotionSupported")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial int RawMouseMotionSupported();

		/// <summary>
		/// Returns the layout-specific name of the specified printable key.
		/// </summary>
		/// <remarks>
		/// This function returns the name of the specified printable key, encoded as
		/// UTF-8.  This is typically the character that key would produce without any
		/// modifier keys, intended for displaying key bindings to the user.  For dead
		/// keys, it is typically the diacritic it would add to a character.
		/// </remarks>
		/// <param name="key">
		/// The key to query, or `GLFW_KEY_UNKNOWN`.
		/// </param>
		/// <param name="scancode">
		/// The scancode of the key to query.
		/// </param>
		/// <returns>
		/// The UTF-8 encoded, layout-specific name of the key, or `NULL`.
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetKeyName")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial IntPtr GetKeyName(int key, int scancode);

		/// <summary>
		/// Returns the platform-specific scancode of the specified key.
		/// </summary>
		/// <remarks>
		/// This function returns the platform-specific scancode of the specified key.
		/// </remarks>
		/// <param name="key">
		/// Any [named key](@ref keys).
		/// </param>
		/// <returns>
		/// The platform-specific scancode for the key, or `-1` if an
		/// [error](@ref error_handling) occurred.
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetKeyScancode")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial int GetKeyScancode(int key);

		/// <summary>
		/// Returns the last reported state of a keyboard key for the specified
		/// window.
		/// </summary>
		/// <remarks>
		/// This function returns the last state reported for the specified key to the
		/// specified window.  The returned state is one of `GLFW_PRESS` or
		/// `GLFW_RELEASE`.  The higher-level action `GLFW_REPEAT` is only reported to
		/// the key callback.
		/// </remarks>
		/// <param name="window">
		/// The desired window.
		/// </param>
		/// <param name="key">
		/// The desired [keyboard key](@ref keys).  `GLFW_KEY_UNKNOWN` is
		/// not a valid key for this function.
		/// </param>
		/// <returns>
		/// One of `GLFW_PRESS` or `GLFW_RELEASE`.
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetKey")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial int GetKey(IntPtr window, int key);

		/// <summary>
		/// Returns the last reported state of a mouse button for the specified
		/// window.
		/// </summary>
		/// <remarks>
		/// This function returns the last state reported for the specified mouse button
		/// to the specified window.  The returned state is one of `GLFW_PRESS` or
		/// `GLFW_RELEASE`.
		/// </remarks>
		/// <param name="window">
		/// The desired window.
		/// </param>
		/// <param name="button">
		/// The desired [mouse button](@ref buttons).
		/// </param>
		/// <returns>
		/// One of `GLFW_PRESS` or `GLFW_RELEASE`.
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetMouseButton")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial int GetMouseButton(IntPtr window, int button);

		/// <summary>
		/// Retrieves the position of the cursor relative to the content area of
		/// the window.
		/// </summary>
		/// <remarks>
		/// This function returns the position of the cursor, in screen coordinates,
		/// relative to the upper-left corner of the content area of the specified
		/// window.
		/// </remarks>
		/// <param name="window">
		/// The desired window.
		/// </param>
		/// <param name="xpos">
		/// Where to store the cursor x-coordinate, relative to the
		/// left edge of the content area, or `NULL`.
		/// </param>
		/// <param name="ypos">
		/// Where to store the cursor y-coordinate, relative to the to
		/// top edge of the content area, or `NULL`.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetCursorPos")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void GetCursorPos(IntPtr window, out double xpos, out double ypos);

		/// <summary>
		/// Sets the position of the cursor, relative to the content area of the
		/// window.
		/// </summary>
		/// <remarks>
		/// This function sets the position, in screen coordinates, of the cursor
		/// relative to the upper-left corner of the content area of the specified
		/// window.  The window must have input focus.  If the window does not have
		/// input focus when this function is called, it fails silently.
		/// </remarks>
		/// <param name="window">
		/// The desired window.
		/// </param>
		/// <param name="xpos">
		/// The desired x-coordinate, relative to the left edge of the
		/// content area.
		/// </param>
		/// <param name="ypos">
		/// The desired y-coordinate, relative to the top edge of the
		/// content area.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwSetCursorPos")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void SetCursorPos(IntPtr window, double xpos, double ypos);

		/// <summary>
		/// Creates a custom cursor.
		/// </summary>
		/// <remarks>
		/// Creates a new custom cursor image that can be set for a window with @ref
		/// SetCursor.  The cursor can be destroyed with @ref DestroyCursor.
		/// Any remaining cursors are destroyed by @ref Terminate.
		/// </remarks>
		/// <param name="image">
		/// The desired cursor image.
		/// </param>
		/// <param name="xhot">
		/// The desired x-coordinate, in pixels, of the cursor hotspot.
		/// </param>
		/// <param name="yhot">
		/// The desired y-coordinate, in pixels, of the cursor hotspot.
		/// </param>
		/// <returns>
		/// The handle of the created cursor, or `NULL` if an
		/// [error](@ref error_handling) occurred.
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwCreateCursor")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial IntPtr CreateCursor(IntPtr image, int xhot, int yhot);

		/// <summary>
		/// Creates a cursor with a standard shape.
		/// </summary>
		/// <remarks>
		/// Returns a cursor with a [standard shape](@ref shapes), that can be set for
		/// a window with @ref SetCursor.
		/// </remarks>
		/// <param name="shape">
		/// One of the [standard shapes](@ref shapes).
		/// </param>
		/// <returns>
		/// A new cursor ready to use or `NULL` if an
		/// [error](@ref error_handling) occurred.
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwCreateStandardCursor")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial IntPtr CreateStandardCursor(int shape);

		/// <summary>
		/// Destroys a cursor.
		/// </summary>
		/// <remarks>
		/// This function destroys a cursor previously created with @ref
		/// CreateCursor.  Any remaining cursors will be destroyed by @ref
		/// Terminate.
		/// </remarks>
		/// <param name="cursor">
		/// The cursor object to destroy.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwDestroyCursor")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void DestroyCursor(IntPtr cursor);

        [LibraryImport(LinkLibrary, EntryPoint = "glfwSetCursor")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		private static partial void _glfwSetCursor(IntPtr window, IntPtr cursor);

		/// <summary>
		/// Sets the key callback.
		/// </summary>
		/// <remarks>
		/// This function sets the key callback of the specified window, which is called
		/// when a key is pressed, repeated or released.
		/// </remarks>
		/// <param name="window">
		/// The window whose callback to set.
		/// </param>
		/// <param name="cbfun">
		/// The new key callback, or `NULL` to remove the currently
		/// set callback.
		/// </param>
		/// <returns>
		/// The previously set callback, or `NULL` if no callback was set or the
		/// library had not been [initialized](@ref intro_init).
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwSetKeyCallback")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial KeyChangeHandler SetKeyCallback(IntPtr window, KeyChangeHandler cbfun);

		/// <summary>
		/// Sets the Unicode character callback.
		/// </summary>
		/// <remarks>
		/// This function sets the character callback of the specified window, which is
		/// called when a Unicode character is input.
		/// </remarks>
		/// <param name="window">
		/// The window whose callback to set.
		/// </param>
		/// <param name="cbfun">
		/// The new callback, or `NULL` to remove the currently set
		/// callback.
		/// </param>
		/// <returns>
		/// The previously set callback, or `NULL` if no callback was set or the
		/// library had not been [initialized](@ref intro_init).
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwSetCharCallback")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial CharHandler SetCharCallback(IntPtr window, CharHandler cbfun);

		/// <summary>
		/// Sets the Unicode character with modifiers callback.
		/// </summary>
		/// <remarks>
		/// This function sets the character with modifiers callback of the specified
		/// window, which is called when a Unicode character is input regardless of what
		/// modifier keys are used.
		/// </remarks>
		/// <param name="window">
		/// The window whose callback to set.
		/// </param>
		/// <param name="cbfun">
		/// The new callback, or `NULL` to remove the currently set
		/// callback.
		/// </param>
		/// <returns>
		/// The previously set callback, or `NULL` if no callback was set or an
		/// [error](@ref error_handling) occurred.
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwSetCharModsCallback")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial CharModsHandler SetCharModsCallback(IntPtr window, CharModsHandler cbfun);

		/// <summary>
		/// Sets the mouse button callback.
		/// </summary>
		/// <remarks>
		/// This function sets the mouse button callback of the specified window, which
		/// is called when a mouse button is pressed or released.
		/// </remarks>
		/// <param name="window">
		/// The window whose callback to set.
		/// </param>
		/// <param name="cbfun">
		/// The new callback, or `NULL` to remove the currently set
		/// callback.
		/// </param>
		/// <returns>
		/// The previously set callback, or `NULL` if no callback was set or the
		/// library had not been [initialized](@ref intro_init).
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwSetMouseButtonCallback")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial MouseButtonHandler SetMouseButtonCallback(IntPtr window, MouseButtonHandler cbfun);

		/// <summary>
		/// Sets the cursor position callback.
		/// </summary>
		/// <remarks>
		/// This function sets the cursor position callback of the specified window,
		/// which is called when the cursor is moved.  The callback is provided with the
		/// position, in screen coordinates, relative to the upper-left corner of the
		/// content area of the window.
		/// </remarks>
		/// <param name="window">
		/// The window whose callback to set.
		/// </param>
		/// <param name="cbfun">
		/// The new callback, or `NULL` to remove the currently set
		/// callback.
		/// </param>
		/// <returns>
		/// The previously set callback, or `NULL` if no callback was set or the
		/// library had not been [initialized](@ref intro_init).
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwSetCursorPosCallback")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial MousePosHandler SetCursorPosCallback(IntPtr window, MousePosHandler cbfun);

		/// <summary>
		/// Sets the cursor enter/exit callback.
		/// </summary>
		/// <remarks>
		/// This function sets the cursor boundary crossing callback of the specified
		/// window, which is called when the cursor enters or leaves the content area of
		/// the window.
		/// </remarks>
		/// <param name="window">
		/// The window whose callback to set.
		/// </param>
		/// <param name="cbfun">
		/// The new callback, or `NULL` to remove the currently set
		/// callback.
		/// </param>
		/// <returns>
		/// The previously set callback, or `NULL` if no callback was set or the
		/// library had not been [initialized](@ref intro_init).
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwSetCursorEnterCallback")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial MouseEnterHandler SetCursorEnterCallback(IntPtr window, MouseEnterHandler cbfun);

		/// <summary>
		/// Sets the scroll callback.
		/// </summary>
		/// <remarks>
		/// This function sets the scroll callback of the specified window, which is
		/// called when a scrolling device is used, such as a mouse wheel or scrolling
		/// area of a touchpad.
		/// </remarks>
		/// <param name="window">
		/// The window whose callback to set.
		/// </param>
		/// <param name="cbfun">
		/// The new scroll callback, or `NULL` to remove the currently
		/// set callback.
		/// </param>
		/// <returns>
		/// The previously set callback, or `NULL` if no callback was set or the
		/// library had not been [initialized](@ref intro_init).
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwSetScrollCallback")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial ScrollHandler SetScrollCallback(IntPtr window, ScrollHandler cbfun);

		/// <summary>
		/// Sets the file drop callback.
		/// </summary>
		/// <remarks>
		/// This function sets the file drop callback of the specified window, which is
		/// called when one or more dragged files are dropped on the window.
		/// </remarks>
		/// <param name="window">
		/// The window whose callback to set.
		/// </param>
		/// <param name="cbfun">
		/// The new file drop callback, or `NULL` to remove the
		/// currently set callback.
		/// </param>
		/// <returns>
		/// The previously set callback, or `NULL` if no callback was set or the
		/// library had not been [initialized](@ref intro_init).
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwSetDropCallback")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial FileDropHandler SetDropCallback(IntPtr window, FileDropHandler cbfun);

		/// <summary>
		/// Returns whether the specified joystick is present.
		/// </summary>
		/// <remarks>
		/// This function returns whether the specified joystick is present.
		/// </remarks>
		/// <param name="jid">
		/// The [joystick](@ref joysticks) to query.
		/// </param>
		/// <returns>
		/// `GLFW_TRUE` if the joystick is present, or `GLFW_FALSE` otherwise.
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwJoystickPresent")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial int JoystickPresent(int jid);

        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetJoystickAxes")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		private static partial IntPtr _glfwGetJoystickAxes(int jid, out int count);

        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetJoystickButtons")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		private static partial IntPtr _glfwGetJoystickButtons(int jid, out int count);

		/// <summary>
		/// Returns the state of all hats of the specified joystick.
		/// </summary>
		/// <remarks>
		/// This function returns the state of all hats of the specified joystick.
		/// Each element in the array is one of the following values:
		/// </remarks>
		/// <param name="jid">
		/// The [joystick](@ref joysticks) to query.
		/// </param>
		/// <param name="count">
		/// Where to store the number of hat states in the returned
		/// array.  This is set to zero if the joystick is not present or an error
		/// occurred.
		/// </param>
		/// <returns>
		/// An array of hat states, or `NULL` if the joystick is not present
		/// or an [error](@ref error_handling) occurred.
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetJoystickHats")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial IntPtr GetJoystickHats(int jid, out int count);

		/// <summary>
		/// Returns the name of the specified joystick.
		/// </summary>
		/// <remarks>
		/// This function returns the name, encoded as UTF-8, of the specified joystick.
		/// The returned string is allocated and freed by GLFW.  You should not free it
		/// yourself.
		/// </remarks>
		/// <param name="jid">
		/// The [joystick](@ref joysticks) to query.
		/// </param>
		/// <returns>
		/// The UTF-8 encoded name of the joystick, or `NULL` if the joystick
		/// is not present or an [error](@ref error_handling) occurred.
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetJoystickName", StringMarshalling = StringMarshalling.Utf8)]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial string GetJoystickName(int jid);

		/// <summary>
		/// Returns the SDL comaptible GUID of the specified joystick.
		/// </summary>
		/// <remarks>
		/// This function returns the SDL compatible GUID, as a UTF-8 encoded
		/// hexadecimal string, of the specified joystick.  The returned string is
		/// allocated and freed by GLFW.  You should not free it yourself.
		/// </remarks>
		/// <param name="jid">
		/// The [joystick](@ref joysticks) to query.
		/// </param>
		/// <returns>
		/// The UTF-8 encoded GUID of the joystick, or `NULL` if the joystick
		/// is not present or an [error](@ref error_handling) occurred.
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetJoystickGUID", StringMarshalling = StringMarshalling.Utf8)]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial string GetJoystickGUID(int jid);

		/// <summary>
		/// Sets the user pointer of the specified joystick.
		/// </summary>
		/// <remarks>
		/// This function sets the user-defined pointer of the specified joystick.  The
		/// current value is retained until the joystick is disconnected.  The initial
		/// value is `NULL`.
		/// </remarks>
		/// <param name="jid">
		/// The joystick whose pointer to set.
		/// </param>
		/// <param name="pointer">
		/// The new value.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwSetJoystickUserPointer")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void SetJoystickUserPointer(int jid, IntPtr pointer);

		/// <summary>
		/// Returns the user pointer of the specified joystick.
		/// </summary>
		/// <remarks>
		/// This function returns the current value of the user-defined pointer of the
		/// specified joystick.  The initial value is `NULL`.
		/// </remarks>
		/// <param name="jid">
		/// The joystick whose pointer to return.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetJoystickUserPointer")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial IntPtr GetJoystickUserPointer(int jid);

		/// <summary>
		/// Returns whether the specified joystick has a gamepad mapping.
		/// </summary>
		/// <remarks>
		/// This function returns whether the specified joystick is both present and has
		/// a gamepad mapping.
		/// </remarks>
		/// <param name="jid">
		/// The [joystick](@ref joysticks) to query.
		/// </param>
		/// <returns>
		/// `GLFW_TRUE` if a joystick is both present and has a gamepad mapping,
		/// or `GLFW_FALSE` otherwise.
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwJoystickIsGamepad")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial int JoystickIsGamepad(int jid);

		/// <summary>
		/// Sets the joystick configuration callback.
		/// </summary>
		/// <remarks>
		/// This function sets the joystick configuration callback, or removes the
		/// currently set callback.  This is called when a joystick is connected to or
		/// disconnected from the system.
		/// </remarks>
		/// <param name="cbfun">
		/// The new callback, or `NULL` to remove the currently set
		/// callback.
		/// </param>
		/// <returns>
		/// The previously set callback, or `NULL` if no callback was set or the
		/// library had not been [initialized](@ref intro_init).
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwSetJoystickCallback")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial JoystickHandler SetJoystickCallback(JoystickHandler cbfun);

		/// <summary>
		/// Adds the specified SDL_GameControllerDB gamepad mappings.
		/// </summary>
		/// <remarks>
		/// This function parses the specified ASCII encoded string and updates the
		/// internal list with any gamepad mappings it finds.  This string may
		/// contain either a single gamepad mapping or many mappings separated by
		/// newlines.  The parser supports the full format of the `gamecontrollerdb.txt`
		/// source file including empty lines and comments.
		/// </remarks>
		/// <param name="string">
		/// The string containing the gamepad mappings.
		/// </param>
		/// <returns>
		/// `GLFW_TRUE` if successful, or `GLFW_FALSE` if an
		/// [error](@ref error_handling) occurred.
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwUpdateGamepadMappings", StringMarshalling = StringMarshalling.Utf8)]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial int UpdateGamepadMappings(string @string);

		/// <summary>
		/// Returns the human-readable gamepad name for the specified joystick.
		/// </summary>
		/// <remarks>
		/// This function returns the human-readable name of the gamepad from the
		/// gamepad mapping assigned to the specified joystick.
		/// </remarks>
		/// <param name="jid">
		/// The [joystick](@ref joysticks) to query.
		/// </param>
		/// <returns>
		/// The UTF-8 encoded name of the gamepad, or `NULL` if the
		/// joystick is not present, does not have a mapping or an
		/// [error](@ref error_handling) occurred.
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetGamepadName")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial IntPtr GetGamepadName(int jid);

		/// <summary>
		/// Retrieves the state of the specified joystick remapped as a gamepad.
		/// </summary>
		/// <remarks>
		/// This function retrives the state of the specified joystick remapped to
		/// an Xbox-like gamepad.
		/// </remarks>
		/// <param name="jid">
		/// The [joystick](@ref joysticks) to query.
		/// </param>
		/// <param name="state">
		/// The gamepad input state of the joystick.
		/// </param>
		/// <returns>
		/// `GLFW_TRUE` if successful, or `GLFW_FALSE` if no joystick is
		/// connected, it has no gamepad mapping or an [error](@ref error_handling)
		/// occurred.
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetGamepadState")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial int GetGamepadState(int jid, out IntPtr state);

		/// <summary>
		/// Sets the clipboard to the specified string.
		/// </summary>
		/// <remarks>
		/// This function sets the system clipboard to the specified, UTF-8 encoded
		/// string.
		/// </remarks>
		/// <param name="window">
		/// Deprecated.  Any valid window or `NULL`.
		/// </param>
		/// <param name="string">
		/// A UTF-8 encoded string.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwSetClipboardString", StringMarshalling = StringMarshalling.Utf8)]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void SetClipboardString(IntPtr window, string @string);

		/// <summary>
		/// Returns the contents of the clipboard as a string.
		/// </summary>
		/// <remarks>
		/// This function returns the contents of the system clipboard, if it contains
		/// or is convertible to a UTF-8 encoded string.  If the clipboard is empty or
		/// if its contents cannot be converted, `NULL` is returned and a @ref
		/// GLFW_FORMAT_UNAVAILABLE error is generated.
		/// </remarks>
		/// <param name="window">
		/// Deprecated.  Any valid window or `NULL`.
		/// </param>
		/// <returns>
		/// The contents of the clipboard as a UTF-8 encoded string, or `NULL`
		/// if an [error](@ref error_handling) occurred.
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetClipboardString", StringMarshalling = StringMarshalling.Utf8)]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial string GetClipboardString(IntPtr window);

		/// <summary>
		/// Returns the value of the GLFW timer.
		/// </summary>
		/// <remarks>
		/// This function returns the value of the GLFW timer.  Unless the timer has
		/// been set using @ref SetTime, the timer measures time elapsed since GLFW
		/// was initialized.
		/// </remarks>
		/// <returns>
		/// The current value, in seconds, or zero if an
		/// [error](@ref error_handling) occurred.
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetTime")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial double GetTime();

		/// <summary>
		/// Sets the GLFW timer.
		/// </summary>
		/// <remarks>
		/// This function sets the value of the GLFW timer.  It then continues to count
		/// up from that value.  The value must be a positive finite number less than
		/// or equal to 18446744073.0, which is approximately 584.5 years.
		/// </remarks>
		/// <param name="time">
		/// The new value, in seconds.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwSetTime")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void SetTime(double time);

		/// <summary>
		/// Returns the current value of the raw timer.
		/// </summary>
		/// <remarks>
		/// This function returns the current value of the raw timer, measured in
		/// 1&nbsp;/&nbsp;frequency seconds.  To get the frequency, call @ref
		/// GetTimerFrequency.
		/// </remarks>
		/// <returns>
		/// The value of the timer, or zero if an
		/// [error](@ref error_handling) occurred.
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetTimerValue")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial ulong GetTimerValue();

		/// <summary>
		/// Returns the frequency, in Hz, of the raw timer.
		/// </summary>
		/// <remarks>
		/// This function returns the frequency, in Hz, of the raw timer.
		/// </remarks>
		/// <returns>
		/// The frequency of the timer, in Hz, or zero if an
		/// [error](@ref error_handling) occurred.
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetTimerFrequency")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial ulong GetTimerFrequency();

        [LibraryImport(LinkLibrary, EntryPoint = "glfwMakeContextCurrent")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		private static partial void _glfwMakeContextCurrent(IntPtr window);

		/// <summary>
		/// Returns the window whose context is current on the calling thread.
		/// </summary>
		/// <remarks>
		/// This function returns the window whose OpenGL or OpenGL ES context is
		/// current on the calling thread.
		/// </remarks>
		/// <returns>
		/// The window whose context is current, or `NULL` if no window's
		/// context is current.
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetCurrentContext")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial IntPtr GetCurrentContext();

		/// <summary>
		/// Swaps the front and back buffers of the specified window.
		/// </summary>
		/// <remarks>
		/// This function swaps the front and back buffers of the specified window when
		/// rendering with OpenGL or OpenGL ES.  If the swap interval is greater than
		/// zero, the GPU driver waits the specified number of screen updates before
		/// swapping the buffers.
		/// </remarks>
		/// <param name="window">
		/// The window whose buffers to swap.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwSwapBuffers")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void SwapBuffers(IntPtr window);

		/// <summary>
		/// Sets the swap interval for the current context.
		/// </summary>
		/// <remarks>
		/// This function sets the swap interval for the current OpenGL or OpenGL ES
		/// context, i.e. the number of screen updates to wait from the time @ref
		/// SwapBuffers was called before swapping the buffers and returning.  This
		/// is sometimes called _vertical synchronization_, _vertical retrace
		/// synchronization_ or just _vsync_.
		/// </remarks>
		/// <param name="interval">
		/// The minimum number of screen updates to wait for
		/// until the buffers are swapped by @ref SwapBuffers.
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwSwapInterval")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial void SwapInterval(int interval);

		/// <summary>
		/// Returns whether the specified extension is available.
		/// </summary>
		/// <remarks>
		/// This function returns whether the specified
		/// [API extension](@ref context_glext) is supported by the current OpenGL or
		/// OpenGL ES context.  It searches both for client API extension and context
		/// creation API extensions.
		/// </remarks>
		/// <param name="extension">
		/// The ASCII encoded name of the extension.
		/// </param>
		/// <returns>
		/// `GLFW_TRUE` if the extension is available, or `GLFW_FALSE`
		/// otherwise.
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwExtensionSupported", StringMarshalling = StringMarshalling.Utf8)]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial int ExtensionSupported(string extension);

		/// <summary>
		/// Returns the address of the specified function for the current
		/// context.
		/// </summary>
		/// <remarks>
		/// This function returns the address of the specified OpenGL or OpenGL ES
		/// [core or extension function](@ref context_glext), if it is supported
		/// by the current context.
		/// </remarks>
		/// <param name="procname">
		/// The ASCII encoded name of the function.
		/// </param>
		/// <returns>
		/// The address of the function, or `NULL` if an
		/// [error](@ref error_handling) occurred.
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetProcAddress", StringMarshalling = StringMarshalling.Utf8)]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial IntPtr GetProcAddress(string procname);

		/// <summary>
		/// Returns whether the Vulkan loader and an ICD have been found.
		/// </summary>
		/// <remarks>
		/// This function returns whether the Vulkan loader and any minimally functional
		/// ICD have been found.
		/// </remarks>
		/// <returns>
		/// `GLFW_TRUE` if Vulkan is minimally available, or `GLFW_FALSE`
		/// otherwise.
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwVulkanSupported")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial int VulkanSupported();

        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetRequiredInstanceExtensions")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		private static partial IntPtr _glfwGetRequiredInstanceExtensions(out uint count);

		/// <summary>
		/// Returns the address of the specified Vulkan instance function.
		/// </summary>
		/// <remarks>
		/// This function returns the address of the specified Vulkan core or extension
		/// function for the specified instance.  If instance is set to `NULL` it can
		/// return any function exported from the Vulkan loader, including at least the
		/// following functions:
		/// </remarks>
		/// <param name="instance">
		/// The Vulkan instance to query, or `NULL` to retrieve
		/// functions related to instance creation.
		/// </param>
		/// <param name="procname">
		/// The ASCII encoded name of the function.
		/// </param>
		/// <returns>
		/// The address of the function, or `NULL` if an
		/// [error](@ref error_handling) occurred.
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetInstanceProcAddress", StringMarshalling = StringMarshalling.Utf8)]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial IntPtr GetInstanceProcAddress(IntPtr instance, string procname);

		/// <summary>
		/// Returns whether the specified queue family can present images.
		/// </summary>
		/// <remarks>
		/// This function returns whether the specified queue family of the specified
		/// physical device supports presentation to the platform GLFW was built for.
		/// </remarks>
		/// <param name="instance">
		/// The instance that the physical device belongs to.
		/// </param>
		/// <param name="device">
		/// The physical device that the queue family belongs to.
		/// </param>
		/// <param name="queuefamily">
		/// The index of the queue family to query.
		/// </param>
		/// <returns>
		/// `GLFW_TRUE` if the queue family supports presentation, or
		/// `GLFW_FALSE` otherwise.
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetPhysicalDevicePresentationSupport")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial int GetPhysicalDevicePresentationSupport(IntPtr instance, IntPtr device, uint queuefamily);

		/// <summary>
		/// Creates a Vulkan surface for the specified window.
		/// </summary>
		/// <remarks>
		/// This function creates a Vulkan surface for the specified window.
		/// </remarks>
		/// <param name="instance">
		/// The Vulkan instance to create the surface in.
		/// </param>
		/// <param name="window">
		/// The window to create the surface for.
		/// </param>
		/// <param name="allocator">
		/// The allocator to use, or `NULL` to use the default
		/// allocator.
		/// </param>
		/// <param name="surface">
		/// Where to store the handle of the surface.  This is set
		/// to `VK_NULL_HANDLE` if an error occurred.
		/// </param>
		/// <returns>
		/// `VK_SUCCESS` if successful, or a Vulkan error code if an
		/// [error](@ref error_handling) occurred.
		/// </returns>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwCreateWindowSurface")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial int CreateWindowSurface(IntPtr instance, IntPtr window, IntPtr allocator, out IntPtr surface);

		/// <summary>
		/// 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <param name="window">
		/// 
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetWin32Window")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial IntPtr GetWin32Window(IntPtr window);

		/// <summary>
		/// 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <param name="window">
		/// 
		/// </param>
        [LibraryImport(LinkLibrary, EntryPoint = "glfwGetX11Window")]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		public static partial IntPtr GetX11Window(IntPtr window);

        //[LibraryImport(LinkLibrary, EntryPoint = "glfwGetCocoaWindow")]
        //[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
		//public static partial IntPtr _glfwGetCocoaWindow(IntPtr window);

		///// <summary>
		///// Returns a string describing the compile-time configuration.
		///// </summary>
		///// <remarks>
		///// This function returns the compile-time generated
		///// [version string](@ref intro_version_string) of the GLFW library binary.  It
		///// describes the version, platform, compiler and any platform-specific
		///// compile-time options.  It should not be confused with the OpenGL or OpenGL
		///// ES version string, queried with `glGetString`.
		///// </remarks>
		///// <returns>
		///// The ASCII encoded GLFW version string.
		///// </returns>
		//public static string GetVersionString()
		//{
		//	var versionStringPtr = _glfwGetVersionString();
		//	return Marshal.PtrToStringAnsi(versionStringPtr);
		//}

		/// <summary>
		/// Returns the currently connected monitors.
		/// </summary>
		/// <remarks>
		/// This function returns an array of handles for all currently connected
		/// monitors.  The primary monitor is always first in the returned array.  If no
		/// monitors were found, this function returns `NULL`.
		/// </remarks>
		/// <param name="count">
		/// Where to store the number of monitors in the returned
		/// array.  This is set to zero if an error occurred.
		/// </param>
		/// <returns>
		/// An array of monitor handles, or `NULL` if no monitors were found or
		/// if an [error](@ref error_handling) occurred.
		/// </returns>
		public static IntPtr[] GetMonitors()
		{
			var arrayPtr = _glfwGetMonitors(out int count);

			if (arrayPtr == IntPtr.Zero)
				return null;

			var result = new IntPtr[count];

			for (int i = 0; i < count; i++)
			{
				var ptr = Marshal.ReadIntPtr(arrayPtr, i * IntPtr.Size);
				result[i] = ptr;
			}

			return result;
		}

		internal static IntPtr GetMonitors(out int count)
        {
			return _glfwGetMonitors(out count);
		}

		/// <summary>
		/// Returns the current mode of the specified monitor.
		/// </summary>
		/// <remarks>
		/// This function returns the current video mode of the specified monitor.  If
		/// you have created a full screen window for that monitor, the return value
		/// will depend on whether that window is iconified.
		/// </remarks>
		/// <param name="monitor">
		/// The monitor to query.
		/// </param>
		/// <returns>
		/// The current mode of the monitor, or `NULL` if an
		/// [error](@ref error_handling) occurred.
		/// </returns>
		public static VideoMode GetVideoMode(IntPtr monitor)
		{
			var ptr = _glfwGetVideoMode(monitor);
			return Marshal.PtrToStructure<VideoMode>(ptr);
		}

		/// <summary>
		/// Returns the current gamma ramp for the specified monitor.
		/// </summary>
		/// <remarks>
		/// This function returns the current gamma ramp of the specified monitor.
		/// </remarks>
		/// <param name="monitor">
		/// The monitor to query.
		/// </param>
		/// <returns>
		/// The current gamma ramp, or `NULL` if an
		/// [error](@ref error_handling) occurred.
		/// </returns>
		public static GammaRamp GetGammaRamp(IntPtr monitor)
		{
			var structPtr = _glfwGetGammaRamp(monitor);

			var redArrayPtr = Marshal.ReadIntPtr(structPtr);
			var blueArrayPtr = Marshal.ReadIntPtr(IntPtr.Add(structPtr, IntPtr.Size));
			var greenArrayPtr = Marshal.ReadIntPtr(IntPtr.Add(structPtr, IntPtr.Size * 2));
			var size = (uint)Marshal.ReadInt32(IntPtr.Add(structPtr, IntPtr.Size * 3));

			var result = new GammaRamp()
			{
				Size = size,
				Red = new ushort[size],
				Green = new ushort[size],
				Blue = new ushort[size],
			};

			int uintSize = Marshal.SizeOf(typeof(uint));

			for (int i = 0; i < size; i++)
			{
				result.Red[i] = (ushort)Marshal.ReadInt16(IntPtr.Add(redArrayPtr, uintSize * i));
				result.Blue[i] = (ushort)Marshal.ReadInt16(IntPtr.Add(blueArrayPtr, uintSize * i));
				result.Green[i] = (ushort)Marshal.ReadInt16(IntPtr.Add(greenArrayPtr, uintSize * i));
			}

			return result;
		}

		/// <summary>
		/// Creates a window and its associated context.
		/// </summary>
		/// <remarks>
		/// This function creates a window and its associated OpenGL or OpenGL ES
		/// context.  Most of the options controlling how the window and its context
		/// should be created are specified with [window hints](@ref window_hints).
		/// </remarks>
		/// <param name="width">
		/// The desired width, in screen coordinates, of the window.
		/// This must be greater than zero.
		/// </param>
		/// <param name="height">
		/// The desired height, in screen coordinates, of the window.
		/// This must be greater than zero.
		/// </param>
		/// <param name="title">
		/// The initial, UTF-8 encoded window title.
		/// </param>
		/// <param name="monitor">
		/// The monitor to use for full screen mode, or `NULL` for
		/// windowed mode.
		/// </param>
		/// <param name="share">
		/// The window whose context to share resources with, or `NULL`
		/// to not share resources.
		/// </param>
		/// <returns>
		/// The handle of the created window, or `NULL` if an
		/// [error](@ref error_handling) occurred.
		/// </returns>
		public static IntPtr CreateWindow(int width, int height, string title, IntPtr monitor, IntPtr share)
		{
			IntPtr window = _glfwCreateWindow(width, height, title, monitor, share);

			_cursors.Add(window, IntPtr.Zero);

			return window;
		}

		/// <summary>
		/// Destroys the specified window and its context.
		/// </summary>
		/// <remarks>
		/// This function destroys the specified window and its context.  On calling
		/// this function, no further callbacks will be called for that window.
		/// </remarks>
		/// <param name="window">
		/// The window to destroy.
		/// </param>
		public static void DestroyWindow(IntPtr window)
		{
			_glfwDestroyWindow(window);

			_cursors.Remove(window);
		}

		/// <summary>
		/// Sets the cursor for the window.
		/// </summary>
		/// <remarks>
		/// This function sets the cursor image to be used when the cursor is over the
		/// content area of the specified window.  The set cursor will only be visible
		/// when the [cursor mode](@ref cursor_mode) of the window is
		/// `GLFW_CURSOR_NORMAL`.
		/// </remarks>
		/// <param name="window">
		/// The window to set the cursor for.
		/// </param>
		/// <param name="cursor">
		/// The cursor to set, or `NULL` to switch back to the default
		/// arrow cursor.
		/// </param>
		public static void SetCursor(IntPtr window, IntPtr cursor)
		{
			_glfwSetCursor(window, cursor);

			try
            {
				_cursors[window] = cursor;
			}
			catch { }
		}

		private static readonly Dictionary<IntPtr, IntPtr> _cursors = new Dictionary<IntPtr, IntPtr>();

		/// <summary>
		/// Gets the cursor for the window.
		/// </summary>
		/// <param name="window">
		/// The window to get the cursor from.
		/// </param>
		/// <returns>
		/// The cursor that is set for the specified window.
		/// </returns>
		public static IntPtr GetCursor(IntPtr window)
		{
			try
            {
				return _cursors[window];
			}
			catch
            {
				throw new Exception($"{nameof(window)} doesn't exist.");
            }
		}

		/// <summary>
		/// Returns the values of all axes of the specified joystick.
		/// </summary>
		/// <remarks>
		/// This function returns the values of all axes of the specified joystick.
		/// Each element in the array is a value between -1.0 and 1.0.
		/// </remarks>
		/// <param name="jid">
		/// The [joystick](@ref joysticks) to query.
		/// </param>
		/// <param name="count">
		/// Where to store the number of axis values in the returned
		/// array.  This is set to zero if the joystick is not present or an error
		/// occurred.
		/// </param>
		/// <returns>
		/// An array of axis values, or `NULL` if the joystick is not present or
		/// an [error](@ref error_handling) occurred.
		/// </returns>
		public static float[] GetJoystickAxes(int joy)
		{
			var arrayPtr = _glfwGetJoystickAxes(joy, out int count);

			if (arrayPtr == IntPtr.Zero)
				return null;

			var result = new float[count];
			Marshal.Copy(arrayPtr, result, 0, count);

			return result;
		}

		/// <summary>
		/// Returns the state of all buttons of the specified joystick.
		/// </summary>
		/// <remarks>
		/// This function returns the state of all buttons of the specified joystick.
		/// Each element in the array is either `GLFW_PRESS` or `GLFW_RELEASE`.
		/// </remarks>
		/// <param name="jid">
		/// The [joystick](@ref joysticks) to query.
		/// </param>
		/// <param name="count">
		/// Where to store the number of button states in the returned
		/// array.  This is set to zero if the joystick is not present or an error
		/// occurred.
		/// </param>
		/// <returns>
		/// An array of button states, or `NULL` if the joystick is not present
		/// or an [error](@ref error_handling) occurred.
		/// </returns>
		public static byte[] GetJoystickButtons(int joy)
		{
			var arrayPtr = _glfwGetJoystickButtons(joy, out int count);

			var result = new byte[count];
			Marshal.Copy(arrayPtr, result, 0, count);

			return result;
		}

		[ThreadStatic]
		internal static IWindow context;

		/// <summary>
		/// Makes the context of the specified window current for the calling
		/// thread.
		/// </summary>
		/// <remarks>
		/// This function makes the OpenGL or OpenGL ES context of the specified window
		/// current on the calling thread.  A context must only be made current on
		/// a single thread at a time and each thread can have only a single current
		/// context at a time.
		/// </remarks>
		/// <param name="window">
		/// The window whose context to make current, or `NULL` to
		/// detach the current context.
		/// </param>
		public static void MakeContextCurrent(IWindow window)
		{
			context = window;

			if (window == null)
            {
				State.CurrentContext = GraphicsContext.None;
				_glfwMakeContextCurrent(IntPtr.Zero);
				return;
			}

			State.CurrentContext = window.GraphicsContext;
			window.GraphicsContext?.ThreadChange();
			_glfwMakeContextCurrent(window.Handle);
		}

		/// <summary>
		/// Returns the Vulkan instance extensions required by GLFW.
		/// </summary>
		/// <remarks>
		/// This function returns an array of names of Vulkan instance extensions required
		/// by GLFW for creating Vulkan surfaces for GLFW windows.  If successful, the
		/// list will always contains `VK_KHR_surface`, so if you don't require any
		/// additional extensions you can pass this list directly to the
		/// `VkInstanceCreateInfo` struct.
		/// </remarks>
		/// <param name="count">
		/// Where to store the number of extensions in the returned
		/// array.  This is set to zero if an error occurred.
		/// </param>
		/// <returns>
		/// An array of ASCII encoded extension names, or `NULL` if an
		/// [error](@ref error_handling) occurred.
		/// </returns>
		public static string[] GetRequiredInstanceExtensions()
		{
			var arrayPtr = _glfwGetRequiredInstanceExtensions(out uint count);

			if (arrayPtr == IntPtr.Zero)
				return null;

			var result = new string[count];

			for (int i = 0; i < count; i++)
			{
				IntPtr stringPtr = Marshal.ReadIntPtr(arrayPtr, i * IntPtr.Size);
				result[i] = Marshal.PtrToStringAnsi(stringPtr);
			}

			return result;
		}

		public static IntPtr GetNativeWindow(IntPtr window)
		{
			if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
			{
				return GetWin32Window(window);
			}
			else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
			{
				return GetX11Window(window);
			}

			throw new NotImplementedException("Unsupported platform.");
		}
	}
}
