using System;
using System.Collections.Generic;
using System.Text;

namespace Graphics_editor
{
    class Square : Base
    {       
        public void Draw()
        {
            Console.ForegroundColor = Color;
            Console.SetCursorPosition(X, Y);
            for(int i = 0; i < Length; i++)
            {
                Console.Write(Symvol);
            }
            for(int i = 0; i < Length; i++)
            {
                Y++;
                Console.SetCursorPosition(X,Y);
                Console.Write(Symvol);
                Console.SetCursorPosition(X+Length,Y);
                Console.Write(Symvol);
            }
            Console.SetCursorPosition(X,Y);
            for (int i = 0; i < Length; i++)
            {
                Console.Write(Symvol);
            }           
        }
    }
}