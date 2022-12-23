using System;
using Zene.Structs;

namespace Zene.Windowing
{
    public class VectorEventArgs : EventArgs
    {
        public VectorEventArgs(double x, double y)
        {
            Value = new Vector2(x, y);
        }

        public VectorEventArgs(Vector2 vector)
        {
            Value = vector;
        }

        public double X => Value.X;
        public double Y => Value.Y;
        public Vector2 Value { get; }

        public static explicit operator VectorIEventArgs(VectorEventArgs vie) => new VectorIEventArgs((Vector2I)vie.Value);
    }
}
