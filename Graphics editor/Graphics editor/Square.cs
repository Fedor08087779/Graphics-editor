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
                Console.SetCursorPosition(X, Y+i);
                for (int l = 0; l < Length; l++)
                {
                    Console.Write(Symvol);         
                }
                Console.WriteLine();
            }
            for (int m = 0; m < Length-2; m++)
            {
                Console.SetCursorPosition(X+1, Y + m+1);
                for (int n = 0; n < Length-2; n++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
