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

            for (int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(X, Y + i);
                for (int l = 0; l < Length; l++)
                {
                    Console.Write(Symvol);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < Height - 2; i++)
            {
                Console.SetCursorPosition(X + 1, Y + i + 1);
                for (int l = 0; l < Length - 2; l++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
