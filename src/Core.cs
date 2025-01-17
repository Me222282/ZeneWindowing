﻿#pragma warning disable CS8981
global using floatv =
#if DOUBLE
    System.Double;
#else
    System.Single;
#endif

global using Maths =
#if DOUBLE
    System.Math;
#else
    System.MathF;
#endif
#pragma warning restore CS8981

using System;
using Zene.Graphics;
using Zene.Windowing.Base;

namespace Zene.Windowing
{
    public static class Core
    {
#if AutoInit
        static Core() { Init(); }
#endif

        private static bool _initialised = false;
        public static void Init()
        {
            if (_initialised) { return; }

            if (GLFW.Init() == GLFW.False)
            {
                throw new InvalidOperationException("Failed to initialize GLFW.");
            }

            _initialised = true;
        }

        private static bool _errorHandling = false;
        internal static void SetupErrorHandle()
        {
            if (_errorHandling) { return; }

            _errorHandler = (error, description) => GLFWError(error, description);
            GLFW.SetErrorCallback(_errorHandler);

            _errorHandling = true;
        }

        private static GLFW.ErrorHandler _errorHandler;
        private static void GLFWError(int type, string message)
        {
            Debugger.PushError($"GLFW Error: {message}");
        }

        public static void Terminate()
        {
            if (!_initialised) { return; }

            GLFW.Terminate();
            _initialised = false;
        }

        public static void SetInitProperties(WindowInitProperties properties)
        {
            if (properties == null)
            {
                properties = WindowInitProperties.Default;
            }

            GLFW.WindowHint(GLFW.Resizable, properties.Resizable ? GLFW.True : GLFW.False);
            GLFW.WindowHint(GLFW.Visible, properties.Visible ? GLFW.True : GLFW.False);
            GLFW.WindowHint(GLFW.Decorated, properties.Decorated ? GLFW.True : GLFW.False);
            GLFW.WindowHint(GLFW.Focused, properties.Focused ? GLFW.True : GLFW.False);
            GLFW.WindowHint(GLFW.AutoIconify, properties.AutoIconify ? GLFW.True : GLFW.False);
            GLFW.WindowHint(GLFW.Floating, properties.AlwaysOnTop ? GLFW.True : GLFW.False);
            GLFW.WindowHint(GLFW.Maximized, properties.Maximized ? GLFW.True : GLFW.False);
            GLFW.WindowHint(GLFW.CenterCursor, properties.CentreCursor ? GLFW.True : GLFW.False);
            GLFW.WindowHint(GLFW.TransparentFramebuffer, properties.TransparentFramebuffer ? GLFW.True : GLFW.False);
            GLFW.WindowHint(GLFW.FocusOnShow, properties.FocusOnShow ? GLFW.True : GLFW.False);
            GLFW.WindowHint(GLFW.ScaleToMonitor, properties.ScaleToMonitor ? GLFW.True : GLFW.False);
            GLFW.WindowHint(GLFW.RedBits, properties.RedBits);
            GLFW.WindowHint(GLFW.GreenBits, properties.GreenBits);
            GLFW.WindowHint(GLFW.BlueBits, properties.BlueBits);
            GLFW.WindowHint(GLFW.AlphaBits, properties.AlphaBits);
            GLFW.WindowHint(GLFW.DepthBits, properties.DepthBits);
            GLFW.WindowHint(GLFW.StencilBits, properties.StencilBits);
            GLFW.WindowHint(GLFW.Samples, properties.Samples);
            GLFW.WindowHint(GLFW.Stereo, properties.Stereoscopic ? GLFW.True : GLFW.False);
            GLFW.WindowHint(GLFW.SrgbCapable, properties.SRGBSupported ? GLFW.True : GLFW.False);
            GLFW.WindowHint(GLFW.Doublebuffer, properties.DoubleBuffered ? GLFW.True : GLFW.False);

            GLFW.WindowHint(GLFW.RefreshRate, properties.RefreshRate);
        }

        public static IWindow Context
        {
            get => GLFW.context;
            set => GLFW.MakeContextCurrent(value);
        }

        public static double Time => GLFW.GetTime();
    }
}
