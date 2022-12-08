using System;
using System.Runtime.InteropServices;
using System.Threading;
using Zene.Graphics;
using Zene.Graphics.Base;
using Zene.Structs;
using Zene.Windowing.Base;

namespace Zene.Windowing
{
    public unsafe class Window : IWindow, IDisposable
    {
        private Window(IntPtr window)
        {
            _window = window;
        }

        public Window(int width, int height, string title, WindowInitProperties properties = null)
            : this(width, height, title, 4.5, properties)
        {

        }
        public Window(int width, int height, string title, double version, WindowInitProperties properties = null)
            : this(width, height, title, version, false, properties)
        {
            
        }

        protected Window(int width, int height, string title, bool multithreading, WindowInitProperties properties = null)
            : this(width, height, title, 4.5, multithreading, properties)
        {

        }
        protected Window(int width, int height, string title, double version, bool multithreading, WindowInitProperties properties = null)
        {
            GLFW.WindowHint(GLFW.ClientApi, GLFW.OpenglApi);
            if (version < 3.2)
            {
                GLFW.WindowHint(GLFW.OpenglProfile, GLFW.OpenglAnyProfile);
            }
            else
            {
                GLFW.WindowHint(GLFW.OpenglProfile, GLFW.OpenglCoreProfile);
            }
            GLFW.WindowHint(GLFW.ContextVersionMajor, (int)Math.Floor(version));
            GLFW.WindowHint(GLFW.ContextVersionMinor, (int)Math.Floor(
                (version - (int)Math.Floor(version)) * 10));

            // Make sure there is no null refernace exception
            if (properties == null)
            {
                properties = WindowInitProperties.Default;
            }

            Core.SetInitProperties(properties);
            _size = new Vector2I(width, height);
            RefreshRate = properties.RefreshRate;
            _baseFramebuffer = new BaseFramebuffer();

            _window = GLFW.CreateWindow(width, height, title, properties.Monitor.Handle, properties.SharedWindow.Handle);

            if (_window == IntPtr.Zero)
            {
                _disposed = true;
                GLFW.Terminate();
                throw new InvalidOperationException("Failed to create window.");
            }

            GLFW.MakeContextCurrent(this);

            // Full screen required properties
            _normalWidth = Width;
            _normalHeight = Height;
            _normalLocation = Location;

            SetCallBacks();
            SetProps(properties);

            State.Init(GLFW.GetProcAddress, version);

            // Create graphics context
            GraphicsContext = new GraphicsContext(
                properties.Stereoscopic,
                properties.DoubleBuffered,
                width, height, version);
            State.CurrentContext = GraphicsContext;

            // Set framebuffer reference size
            _baseFramebuffer.Size(width, height);

            // Setup debug callback - error output/display
            // If supported in current opengl version
            if (((Action<GL.DebugProc, IntPtr>)GL.DebugMessageCallback).IsSupported())
            {
                OnDebugCallBack = (source, type, _, _, _, message, _) => GLError(type, message);

                GL.Enable(GLEnum.DebugOutput);
                GL.DebugMessageCallback(OnDebugCallBack, null);
            }

            Core.SetupErrorHandle();

            _title = title;

            SupportsMultithreading = multithreading;
        }

        private readonly GL.DebugProc OnDebugCallBack;
        protected virtual void GLError(uint type, string message)
        {
            if (type == GLEnum.DebugTypeError && message != null)
            {
                if (State.OutputDebugSynchronous && ReportStackTrace)
                {
                    Console.WriteLine(ErrorStackTrace());
                }
                Debugger.PushError($"GL Error: {message}");
            }
        }

        /// <summary>
        /// Determines whether the stack trace should be outputed before pushing OpenGL errors.
        /// </summary>
        /// <remarks>
        /// <see cref="State.OutputDebugSynchronous"/> needs to be True for the stack trace to be outputed.
        /// </remarks>
        public bool ReportStackTrace { get; set; } = false;

        private static string ErrorStackTrace()
        {
            string str = Environment.StackTrace;

            int i = str.IndexOf("Zene.Windowing.Window.<.ctor>b__2_0(UInt32 source, UInt32 type, UInt32 _, UInt32 _, Int32 _, String message, IntPtr _)");
            if (i < 0) { return str; }

            str = str.Remove(0, i);

            i = str.IndexOf("at");
            if (i < 0) { return str; }

            return str.Remove(0, i);
        }

        private readonly IntPtr _window;
        public IntPtr Handle => _window;

        public GraphicsContext GraphicsContext { get; }

        private bool _disposed = false;
        public void Dispose()
        {
            if (!_disposed)
            {
                Dispose(true);

                _disposed = true;

                GC.SuppressFinalize(this);
            }
        }

        protected virtual void Dispose(bool dispose)
        {
            if (dispose)
            {
                GLFW.DestroyWindow(_window);
            }
        }

        public void Close()
        {
            GLFW.SetWindowShouldClose(_window, 1);
        }

        public bool IsContext
        {
            get => GLFW.GetCurrentContext() == Handle;
            set => GLFW.MakeContextCurrent(value ? this : null);
        }

        private readonly BaseFramebuffer _baseFramebuffer;
        public virtual IFramebuffer Framebuffer => _baseFramebuffer;

        private int _normalWidth;
        private int _normalHeight;
        private Vector2I _normalLocation;

        private int _refreshRate;
        public int RefreshRate
        {
            get => _refreshRate;
            set
            {
                _refreshRate = value;

                // Resets window's monitor if none - thus changing refresh rate
                if (!_fullScreen)
                {
                    FullScreen = _fullScreen;
                }
            }
        }

        private bool _fullScreen = false;
        public bool FullScreen
        {
            get => _fullScreen;
            set
            {
                _fullScreen = value;

                if (value)
                {
                    _normalWidth = Width;
                    _normalHeight = Height;
                    _normalLocation = Location;

                    Monitor monitor = Monitor.Primary;
                    VideoMode videoMode = monitor.VideoMode;

                    GLFW.SetWindowMonitor(_window, monitor.Handle, 0, 0, videoMode.Width, videoMode.Height, videoMode.RefreshRate);
                }
                else
                {
                    GLFW.SetWindowMonitor(_window, IntPtr.Zero, _normalLocation.X, _normalLocation.Y, _normalWidth, _normalHeight, RefreshRate);
                }
            }
        }

        public int Width
        {
            get => Size.X;
            set => Size = new Vector2I(value, Height);
        }
        public int Height
        {
            get => Size.Y;
            set => Size = new Vector2I(Width, value);
        }
        private readonly object _sizeRef = new object();
        private Vector2I _size;
        public Vector2I Size
        {
            get => _size;
            set
            {
                GLFW.SetWindowSize(_window, value.X, value.Y);
                lock (_sizeRef)
                {
                    _size = value;
                }
            }
        }

        private readonly object _posRef = new object();
        private Vector2I _pos;
        public Vector2I Location
        {
            get => _pos;
            set
            {
                GLFW.SetWindowPos(_window, value.X, value.Y);
                lock (_posRef)
                {
                    _pos = value;
                }
            }
        }
        private readonly object _mousePosRef = new object();
        private Vector2 _mousePos;
        public Vector2 MouseLocation
        {
            get => _mousePos;
            set
            {
                GLFW.SetCursorPos(_window, value.X, value.Y);
                lock (_mousePosRef)
                {
                    _mousePos = value;
                }
            }
        }

        private Cursor _cursor;
        public Cursor CursorStyle
        {
            get => _cursor;
            set
            {
                _cursor = value;

                if (value == null)
                {
                    GLFW.SetCursor(_window, IntPtr.Zero);
                    return;
                }

                GLFW.SetCursor(_window, value.Handle);
            }
        }

        public CursorMode CursorMode
        {
            get => (CursorMode)GLFW.GetInputMode(_window, GLFW.Cursor);
            set => GLFW.SetInputMode(_window, GLFW.Cursor, (int)value);
        }

        private readonly object _focusedRef = new object();
        private bool _focused;
        public bool Focused
        {
            get => _focused;
            set
            {
                GLFW.SetWindowAttrib(_window, GLFW.Focused, value ? GLFW.True : GLFW.False);
                lock (_focusedRef)
                {
                    _focused = value;
                }
            }
        }

        private string _title;
        public string Title
        {
            get => _title;
            set
            {
                _title = value;

                GLFW.SetWindowTitle(Handle, value);
            }
        }

        private double _timeOffset = 0d;
        public double Timer
        {
            get => GLFW.GetTime() - _timeOffset;
            set => _timeOffset = GLFW.GetTime() - value;
        }

        public string ClipBoard
        {
            set => GLFW.SetClipboardString(_window, value);
            get => Marshal.PtrToStringUTF8(GLFW.GetClipboardString(_window));
        }

        /// <summary>
        /// Determines whether <paramref name="key"/> is currently being pressed.
        /// </summary>
        /// <param name="key">THe key to query</param>
        /// <returns></returns>
        public bool this[Keys key]
        {
            get => GLFW.GetKey(_window, (int)key) == GLFW.Press;
        }
        /// <summary>
        /// Determines whether <paramref name="mod"/> is currently active.
        /// </summary>
        /// <remarks>
        /// Throws <see cref="NotSupportedException"/> if <paramref name="mod"/> is <see cref="Mods.CapsLock"/> or <see cref="Mods.NumLock"/>.
        /// </remarks>
        /// <param name="mod">The modifier to query.</param>
        /// <exception cref="NotSupportedException"></exception>
        /// <returns></returns>
        public bool this[Mods mod]
        {
            get => mod switch
            {
                Mods.Shift => this[Keys.LeftShift] || this[Keys.RightShift],
                Mods.Control => this[Keys.LeftControl] || this[Keys.RightControl],
                Mods.Alt => this[Keys.LeftAlt] || this[Keys.RightAlt],
                Mods.Super => this[Keys.LeftSuper] || this[Keys.RightSuper],
                Mods.CapsLock => throw new NotSupportedException(),
                Mods.NumLock => throw new NotSupportedException(),
                _ => false
            };
        }

        private void SetProps(WindowInitProperties props)
        {
            _focused = props.Focused;

            GLFW.GetWindowPos(_window, out int x, out int y);
            _pos = new Vector2I(x, y);

            GLFW.GetCursorPos(_window, out double mx, out double my);
            _mousePos = new Vector2(mx, my);
        }

        protected ActionManager Actions => GraphicsContext.Actions;

        public bool SupportsMultithreading { get; }

        public bool Running { get; private set; } = false;

        public void Run()
        {
            OnSizePixelChange(new SizeChangeEventArgs(Size));

            GLFW.SwapInterval(-1);

            Running = true;

            OnStart(new EventArgs());

            while (GLFW.WindowShouldClose(_window) == GLFW.False)
            {
                GraphicsContext.Actions.Flush();

                OnUpdate(new EventArgs());

                GLFW.SwapBuffers(_window);
                GLFW.PollEvents();
            }

            Running = false;

            OnStop(new EventArgs());
        }
        public void RunMultithread()
        {
            if (!SupportsMultithreading)
            {
                throw new Exception("Window does not support asynchronous window management.");
            }

            Thread thread = new Thread(() =>
            {
                IsContext = true;

                GLFW.SwapInterval(-1);

                OnStart(new EventArgs());

                while (GLFW.WindowShouldClose(_window) == GLFW.False)
                {
                    Actions.Flush();

                    OnUpdate(new EventArgs());

                    GLFW.SwapBuffers(_window);
                }

                OnStop(new EventArgs());
            })
            {
                Priority = ThreadPriority.Highest
            };

            IsContext = false;

            thread.Start();

            while (thread.IsAlive)
            {
                GLFW.WaitEvents();
            }
        }

        private GLFW.FileDropHandler _onFileDropCallBack;
        private GLFW.CharHandler _onTextInput;
        private GLFW.KeyChangeHandler _onKeyCallBack;
        private GLFW.ScrollHandler _onScrollCallBack;
        private GLFW.MouseEnterHandler _onCursorEnterCallBack;
        private GLFW.MousePosHandler _onMouseMoveCalBack;
        private GLFW.MouseButtonHandler _onMouseButtonCallBack;
        private GLFW.WindowSizeHandler _onSizeCallBack;
        private GLFW.WindowMaximizeHandler _onMaximizedCallBack;
        private GLFW.WindowFocusHandler _onFocusCallBack;
        private GLFW.WindowRefreshHandler _onRefreshCallBack;
        private GLFW.WindowCloseHandler _onCloseCallBack;
        private GLFW.WindowPosHandler _onWindowMoveCallBack;
        private GLFW.FramebufferSizeHandler _onFrameBufferCallBack;

        public event FileDropEventHandler FileDrop;
        public event TextInputEventHandler TextInput;
        public event KeyEventHandler KeyDown;
        public event KeyEventHandler KeyUp;
        public event ScrolEventHandler Scroll;
        public event EventHandler MouseEnter;
        public event EventHandler MouseLeave;
        public event MouseEventHandler MouseMove;
        public event MouseEventHandler MouseDown;
        public event MouseEventHandler MouseUp;
        public event SizeChangeEventHandler SizeChange;
        public event EventHandler Maximized;
        public event FocusedEventHandler Focus;
        public event EventHandler Refresh;
        public event EventHandler Closing;
        public event PositionEventHandler WindowMove;
        public event SizeChangeEventHandler SizePixelChange;

        public event EventHandler Update;
        public event EventHandler Start;
        public event EventHandler Stop;

        private void SetCallBacks()
        {
            _onFileDropCallBack = (_, count, paths) => DropCallBack(count, paths);
            _onTextInput = (_, unicode) => OnTextInput(new TextInputEventArgs((char)unicode));
            _onKeyCallBack = (_, key, dumy, action, mods) => KeyCallBack(key, action, mods);
            _onScrollCallBack = (_, x, y) => OnScroll(new ScrollEventArgs(x, y));
            _onCursorEnterCallBack = (_, enter) => MouseOver(enter == 1);
            _onMouseMoveCalBack = (_, x, y) => OnMouseMove(new MouseEventArgs(x, y));
            _onMouseButtonCallBack = (_, button, action, mod) => MouseButon(button, action, mod);
            _onSizeCallBack = (_, width, height) => OnSizeChange(new SizeChangeEventArgs(width, height));
            _onMaximizedCallBack = (_, i) => OnMaximized(new EventArgs());
            _onFocusCallBack = (_, focus) => OnFocus(new FocusedEventArgs(focus == 1));
            _onRefreshCallBack = (_) => OnRefresh(new EventArgs());
            _onCloseCallBack = (_) => OnClosing(new EventArgs());
            _onWindowMoveCallBack = (_, x, y) => OnWindowMove(new PositionEventArgs(x, y));
            _onFrameBufferCallBack = (_, width, height) => OnSizePixelChange(new SizeChangeEventArgs(width, height));

            GLFW.SetDropCallback(_window, _onFileDropCallBack);
            GLFW.SetCharCallback(_window, _onTextInput);
            GLFW.SetKeyCallback(_window, _onKeyCallBack);
            GLFW.SetScrollCallback(_window, _onScrollCallBack);
            GLFW.SetCursorEnterCallback(_window, _onCursorEnterCallBack);
            GLFW.SetCursorPosCallback(_window, _onMouseMoveCalBack);
            GLFW.SetMouseButtonCallback(_window, _onMouseButtonCallBack);
            GLFW.SetWindowSizeCallback(_window, _onSizeCallBack);
            GLFW.SetWindowMaximizeCallback(_window, _onMaximizedCallBack);
            GLFW.SetWindowFocusCallback(_window, _onFocusCallBack);
            GLFW.SetWindowCloseCallback(_window, _onCloseCallBack);
            GLFW.SetWindowPosCallback(_window, _onWindowMoveCallBack);
            GLFW.SetFramebufferSizeCallback(_window, _onFrameBufferCallBack);
        }

        private void DropCallBack(int count, IntPtr paths)
        {
            string[] arrayOfPaths = new string[count];

            byte** data = (byte**)paths.ToPointer();

            for (int i = 0; i < count; i++)
            {
                arrayOfPaths[i] = Marshal.PtrToStringUTF8(new IntPtr(data[i]));
            }

            OnFileDrop(new FileDropEventArgs(arrayOfPaths));
        }
        private void KeyCallBack(int key, int action, int mods)
        {
            if (action == GLFW.Press || action == GLFW.Repeat)
            {
                OnKeyDown(new KeyEventArgs((Keys)key, (Mods)mods, (KeyAction)action));
            }
            else
            {
                OnKeyUp(new KeyEventArgs((Keys)key, (Mods)mods, (KeyAction)action));
            }
        }
        private void MouseOver(bool entered)
        {
            if (entered)
            {
                OnMouseEnter(new EventArgs());
            }
            else
            {
                OnMouseLeave(new EventArgs());
            }
        }
        private void MouseButon(int button, int action, int mods)
        {
            if (action == GLFW.Press)
            {
                OnMouseDown(new MouseEventArgs(MouseLocation, (MouseButton)button, (Mods)mods));
            }
            else
            {
                OnMouseUp(new MouseEventArgs(MouseLocation, (MouseButton)button, (Mods)mods));
            }
        }

        protected virtual void OnFileDrop(FileDropEventArgs e)
        {
            FileDrop?.Invoke(this, e);
        }
        protected virtual void OnTextInput(TextInputEventArgs e)
        {
            TextInput?.Invoke(this, e);
        }
        protected virtual void OnKeyDown(KeyEventArgs e)
        {
            KeyDown?.Invoke(this, e);
        }
        protected virtual void OnKeyUp(KeyEventArgs e)
        {
            KeyUp?.Invoke(this, e);
        }
        protected virtual void OnScroll(ScrollEventArgs e)
        {
            Scroll?.Invoke(this, e);
        }
        protected virtual void OnMouseEnter(EventArgs e)
        {
            MouseEnter?.Invoke(this, e);
        }
        protected virtual void OnMouseLeave(EventArgs e)
        {
            MouseLeave?.Invoke(this, e);
        }
        protected virtual void OnMouseMove(MouseEventArgs e)
        {
            lock (_mousePosRef)
            {
                _mousePos = e.Location;
            }
            MouseMove?.Invoke(this, e);
        }
        protected virtual void OnMouseDown(MouseEventArgs e)
        {
            MouseDown?.Invoke(this, e);
        }
        protected virtual void OnMouseUp(MouseEventArgs e)
        {
            MouseUp?.Invoke(this, e);
        }
        protected virtual void OnSizeChange(SizeChangeEventArgs e)
        {
            SizeChange?.Invoke(this, e);
        }
        protected virtual void OnMaximized(EventArgs e)
        {
            Maximized?.Invoke(this, e);
        }
        protected virtual void OnFocus(FocusedEventArgs e)
        {
            lock (_focusedRef)
            {
                _focused = true;
            }

            Focus?.Invoke(this, e);
        }
        protected virtual void OnRefresh(EventArgs e)
        {
            Refresh?.Invoke(this, e);
        }
        protected virtual void OnClosing(EventArgs e)
        {
            Closing?.Invoke(this, e);
        }
        protected virtual void OnWindowMove(PositionEventArgs e)
        {
            lock (_posRef)
            {
                _pos = e.Location;
            }
            WindowMove?.Invoke(this, e);
        }
        protected virtual void OnSizePixelChange(SizeChangeEventArgs e)
        {
            lock (_sizeRef)
            {
                _size = e.Size;
            }

            Actions.Push(() =>
            {
                _baseFramebuffer.Size(e.Width, e.Height);
                BaseFramebuffer.ViewSize = e.Size;
            });

            SizePixelChange?.Invoke(this, e);
        }

        protected virtual void OnUpdate(EventArgs e)
        {
            Update?.Invoke(this, e);
        }
        protected virtual void OnStart(EventArgs e)
        {
            Start?.Invoke(this, e);
        }
        protected virtual void OnStop(EventArgs e)
        {
            Stop?.Invoke(this, e);
        }

        public override bool Equals(object obj)
        {
            return obj is Window window &&
                   _window == window._window;
        }
        public override int GetHashCode() => HashCode.Combine(_window);

        public static bool operator ==(Window l, Window r)
        {
            if (l is null)
            {
                return r is null;
            }

            return l.Equals(r);
        }
        public static bool operator !=(Window l, Window r)
        {
            if (l is null)
            {
                return !(r is null);
            }

            return !l.Equals(r);
        }

        /// <summary>
        /// A null value window.
        /// </summary>
        public static Window None { get; } = new Window(IntPtr.Zero);
        /// <summary>
        /// Creates a window object from an already created GLFW window.
        /// </summary>
        /// <param name="handle">The GLFW pointer to a window object.</param>
        /// <returns></returns>
        public static Window FromHandle(IntPtr handle)
        {
            return new Window(handle);
        }
    }
}
