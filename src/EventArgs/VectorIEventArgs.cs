using System;
using Zene.Structs;

namespace Zene.Windowing
{
    public class VectorIEventArgs : EventArgs
    {
        public VectorIEventArgs(int x, int y)
        {
            Value = new Vector2I(x, y);
        }

        public VectorIEventArgs(Vector2I vector)
        {
            Value = vector;
        }

        public int X => Value.X;
        public int Y => Value.Y;
        public Vector2I Value { get; }

        public static explicit operator VectorEventArgs(VectorIEventArgs vie) => new VectorEventArgs(vie.Value);
    }
}
