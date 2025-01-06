using System;
using Zene.Structs;

namespace Zene.Windowing
{
    public class VectorEventArgs : EventArgs
    {
        public VectorEventArgs(floatv x, floatv y)
        {
            Value = new Vector2(x, y);
        }

        public VectorEventArgs(Vector2 vector)
        {
            Value = vector;
        }

        public floatv X => Value.X;
        public floatv Y => Value.Y;
        public Vector2 Value { get; }

        public static explicit operator VectorIEventArgs(VectorEventArgs vie) => new VectorIEventArgs((Vector2I)vie.Value);
    }
}
