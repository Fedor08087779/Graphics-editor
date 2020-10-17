using System;
using System.Collections.Generic;
using System.Text;

namespace Graphics_editor
{
    class Square : Base
    {        
        public Square(int x, int y, int length, string symvol, ConsoleColor color):base(x,y,length,symvol,color)
        {
            X = x;
            Y = y;
            Length = length;
            Symvol = symvol;
            Color = color;
        }
        public void Draw()
        {
            int SquareX = X;
            int SquareY = Y;
            Console.ForegroundColor = Color;
            Console.SetCursorPosition(SquareX, SquareY);
            for(int i = 0; i < Length+1; i++)
            {
                Console.Write(Symvol);
            }
            for(int i = 0; i < Length; i++)
            {
                SquareY++;
                Console.SetCursorPosition(SquareX, SquareY);
                Console.Write(Symvol);
                Console.SetCursorPosition(SquareX + Length, SquareY);
                Console.Write(Symvol);
            }
            Console.SetCursorPosition(SquareX, SquareY);
            for (int i = 0; i < Length; i++)
            {
                Console.Write(Symvol);
            }           
        }
    }
}