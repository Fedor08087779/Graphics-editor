using System;
using System.Collections.Generic;
using System.Text;

namespace Graphics_editor
{
    class Rectangle : Square
    {
        public Rectangle(int x, int y, int length, string symvol, ConsoleColor color, int height) : base(x, y, length, symvol, color)
        {
            X = x;
            Y = y;
            Length = length;
            Symvol = symvol;
            Color = color;
            Height = height;
        }
        public int Height;
        public new void Draw()
        {
            int RectangleX = X;
            int RectangleY = Y;
            Console.ForegroundColor = Color;
            Console.SetCursorPosition(RectangleX, RectangleY);
            for (int i = 0; i < Length+1; i++)
            {
                Console.Write(Symvol);
            }
            for (int i = 0; i < Height; i++)
            {
                RectangleY++;
                Console.SetCursorPosition(RectangleX, RectangleY);
                Console.Write(Symvol);
                Console.SetCursorPosition(RectangleX + Length, RectangleY);
                Console.Write(Symvol);
            }
            Console.SetCursorPosition(RectangleX, RectangleY);
            for (int i = 0; i < Length; i++)
            {
                Console.Write(Symvol);
            }
        }
    }
}
