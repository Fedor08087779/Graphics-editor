using System;
using System.Collections.Generic;
using System.Text;

namespace Graphics_editor
{
    class Base
    {
        public Base(int x, int y, int length, string symvol, ConsoleColor color)
        {
            X = x;
            Y = y;
            Length = length;
            Symvol = symvol;
            Color = color;
        }
        public int X;
        public int Y;
        public int Length;
        public string Symvol;
        public ConsoleColor Color;

    }
}
