﻿using System;
using Zene.Structs;

namespace Zene.Windowing
{
    public class MouseEventArgs : EventArgs
    {
        public MouseEventArgs(Vector2 location, MouseButton button, Mods mods)
        {
            Location = location;
            Button = button;
            Modifier = mods;
        }

        public MouseEventArgs(MouseButton button, Mods mods)
        {
            Location = Vector2.Zero;
            Button = button;
            Modifier = mods;
        }

        public MouseEventArgs(Vector2 location)
        {
            Location = location;
            Button = MouseButton.None;
            Modifier = 0;
        }

        public MouseEventArgs(floatv x, floatv y)
        {
            Location = new Vector2(x, y);
            Button = MouseButton.None;
            Modifier = 0;
        }

        public MouseButton Button { get; }

        public Vector2 Location { get; }

        public floatv X => Location.X;
        public floatv Y => Location.Y;

        public Mods Modifier { get; }
    }
}
