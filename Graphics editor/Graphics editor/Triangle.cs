using System;
using System.Collections.Generic;
using System.Text;

namespace Graphics_editor
{
    class Triangle : Base
    {
        public Triangle(int x, int y, int length, string symvol, ConsoleColor color) : base(x, y, length, symvol, color)
        {
            X = x;
            Y = y;
            Length = length;
            Symvol = symvol;
            Color = color;
        }
        public void Draw()
        {
            int TriangleX = X;
            int TriangleY = Y;
            Console.ForegroundColor = Color;
            Console.SetCursorPosition(TriangleX, TriangleY / 2 - 1);
            for (int i = 0; i < Length; i++)
            {
                TriangleY++;
                Console.SetCursorPosition(TriangleX - i, TriangleY);
                Console.Write(Symvol);

                Console.SetCursorPosition(TriangleX + i, TriangleY);
                Console.Write(Symvol);
                
            }
            TriangleX = TriangleX - (Length-1);
            Console.SetCursorPosition(TriangleX, TriangleY);
            for (int i = 0; i < Length*2-1; i++)
            {
                Console.SetCursorPosition(TriangleX, TriangleY);
                Console.Write(Symvol);
                TriangleX++;
            }
        }
    }
}