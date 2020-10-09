using System;
using System.Collections.Generic;
using System.Text;

namespace Graphics_editor
{
    class Rectangle : Square
    {
        public int Height;
        public new void Draw()
        {
            Console.ForegroundColor = Color;
            Console.SetCursorPosition(X, Y);
            for (int i = 0; i < Length+1; i++)
            {
                Console.Write(Symvol);
            }
            for (int i = 0; i < Height; i++)
            {
                Y++;
                Console.SetCursorPosition(X, Y);
                Console.Write(Symvol);
                Console.SetCursorPosition(X + Length, Y);
                Console.Write(Symvol);
            }
            Console.SetCursorPosition(X, Y);
            for (int i = 0; i < Length; i++)
            {
                Console.Write(Symvol);
            }
        }
    }
}
