using System;
using Zene.Graphics;

namespace Zene.Windowing
{
    public class FrameEventArgs : EventArgs
    {
        public FrameEventArgs(IDrawingContext dm, double dt = 0)
        {
            Context = dm;
            DeltaTime = dt;
        }

        public IDrawingContext Context { get; }
        public double DeltaTime { get; }
    }
}
