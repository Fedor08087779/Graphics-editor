using System;
using System.Collections.Generic;
using System.Text;

namespace Graphics_editor
{
    class Triangle : Base
    {       
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
            Console.SetCursorPosition(X, TriangleY);
            for (int i = 0; i < Length*2; i++)
            {
                Console.SetCursorPosition(X + i, TriangleY);
                Console.Write(Symvol);
            }
            /*for (int i = 0; i < Length; i++)
            {
                Console.SetCursorPosition(TriangleX - i, TriangleY);
                Console.Write(Symvol);
            }*/
        }
    }
}