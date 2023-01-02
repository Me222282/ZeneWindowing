using System;
using Zene.Graphics;

namespace Zene.Windowing
{
    public class FrameEventArgs : EventArgs
    {
        public FrameEventArgs(IDrawingContext dm)
        {
            Context = dm;
        }

        public IDrawingContext Context { get; }
    }
}
