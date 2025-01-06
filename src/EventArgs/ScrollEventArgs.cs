using System;

namespace Zene.Windowing
{
    public class ScrollEventArgs : EventArgs
    {
        public ScrollEventArgs(floatv scrollX, floatv scrollY)
        {
            DeltaX = scrollX;
            DeltaY = scrollY;
        }

        public floatv DeltaX { get; }

        public floatv DeltaY { get; }
    }
}
