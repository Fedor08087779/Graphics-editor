


   using System;
using System.Collections.Generic;
using System.Text;

namespace Graphics_editor
{
    class InputFigure
    {
        public void MenySquare()
        {
           
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("                                                                        ");
            Console.SetCursorPosition(0, 0);
            Console.Write("Введите X квадрата: ");
            int.TryParse(Console.ReadLine(), out int inputX);
            while (inputX <= 0 || inputX >= 100)
            {
                Console.Write("Введите X квадрата не больше 100 и не меньше 0: ");
                int.TryParse(Console.ReadLine(), out inputX);
            }
            //============================================================
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("                                                                        ");
            Console.SetCursorPosition(0, 0);
            Console.Write("Введите Y квадрата: ");
            int.TryParse(Console.ReadLine(), out int inputY);
            while (inputY <= 0 || inputY >= 100)
            {
                Console.Write("Введите Y квадрата не больше 100 и не меньше 0: ");
                int.TryParse(Console.ReadLine(), out inputY);
            }
            //============================================================
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("                                                                        ");
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Введите длину квадрата: ");
            Console.SetCursorPosition(23, 0);
            int.TryParse(Console.ReadLine(), out int inputLenght);
            while (inputLenght <= 0 || inputLenght >= 20)
            {
                Console.Write("Введите длину квадрата не больше 20 и не меньше 0: ");
                int.TryParse(Console.ReadLine(), out inputLenght);
            }
            //============================================================
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("                                                                        ");
            Console.SetCursorPosition(0, 0);
            Console.Write("Введите символ: ");           
            string inputSumvol = Console.ReadLine();
            int l = inputSumvol.Length;
            while (l <= 0 || l >= 2)
            {
                Console.Write("Введите символ не длинее одного символа и не менее одного: ");
                inputSumvol = Console.ReadLine();
                l = inputSumvol.Length;
            }
            //============================================================
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("                                                                        ");
            Console.WriteLine("                                                                        ");
            Console.SetCursorPosition(0, 0);
            Console.Write("(Black=0,DarkBlue=1,DarkGreen=2,DarkCyan=3,DarkRed=4,DarkMagenta=5,DarkYellow=6,Gray=7,DarkGray=8,Blue=9,Green=10,Cyan=11,Red=12,Magenta=13,Yellow=14,White=15) ");
            Console.Write("Введите номер цвета:");
            int.TryParse(Console.ReadLine(), out int inputColor);
            while (inputColor < 0 || inputColor > 15)
            {
                Console.Write("Введите номер цвета не меньше 0 и не больше 15:");
                int.TryParse(Console.ReadLine(), out inputColor);
            }
            ConsoleColor color = (ConsoleColor)inputColor;
            
            Console.SetCursorPosition(0, 0);
            Square square = new Square(inputX, inputY, inputLenght, inputSumvol, color);
            square.Draw();
            //============================================================
        }
        public void MenyRectangle()
        {
            
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("                                                                        ");
            Console.SetCursorPosition(0, 0);
            Console.Write("Введите X прямоугольника: ");
            int.TryParse(Console.ReadLine(), out int inputRectangleX);
            while (inputRectangleX <= 0 || inputRectangleX >= 100)
            {
                Console.Write("Введите X прямоугольника не больше 100 и не меньше 0: ");
                int.TryParse(Console.ReadLine(), out inputRectangleX);
            }
            //============================================================
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("                                                                        ");
            Console.SetCursorPosition(0, 0);
            Console.Write("Введите Y прямоугольника: ");
            int.TryParse(Console.ReadLine(), out int inputRectangleY);
            while (inputRectangleY <= 0 || inputRectangleY >= 100)
            {
                Console.Write("Введите Y прямоугольника не больше 100 и не меньше 0: ");
                int.TryParse(Console.ReadLine(), out inputRectangleY);
            }
            //============================================================
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("                                                                        ");
            Console.SetCursorPosition(0, 0);
            Console.Write("Введите длину прямоугольника: ");
            int.TryParse(Console.ReadLine(), out int inputRectangleLenght);
            while (inputRectangleLenght <= 0 || inputRectangleLenght >= 20)
            {
                Console.Write("Введите длину прямоугольника не больше 20 и не меньше 0: ");
                int.TryParse(Console.ReadLine(), out inputRectangleLenght);
            }
            //============================================================
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("                                                                        ");
            Console.SetCursorPosition(0, 0);
            Console.Write("Введите высоту прямоугольника: ");
            int.TryParse(Console.ReadLine(), out int inputRectangleHeight);
            while (inputRectangleHeight <= 0 || inputRectangleHeight >= 20)
            {
                Console.Write("Введите высоту прямоугольника не больше 20 и не меньше 0: ");
                int.TryParse(Console.ReadLine(), out inputRectangleHeight);
            }
            //============================================================
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("                                                                        ");
            Console.WriteLine("                                                                        ");
            Console.SetCursorPosition(0, 0);
            Console.Write("Введите символ: ");
            string inputRectangleSumvol = Console.ReadLine();
            int symvolRectangle = inputRectangleSumvol.Length;
            while (symvolRectangle <= 0 || symvolRectangle >= 2)
            {
                Console.Write("Введите символ не длинее одного символа и не менее одного: ");
                inputRectangleSumvol = Console.ReadLine();
                symvolRectangle = inputRectangleSumvol.Length;
            }
            //============================================================
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("                                                                        ");
            Console.WriteLine("                                                                        ");
            Console.SetCursorPosition(0, 0);
            Console.Write("(Black=0,DarkBlue=1,DarkGreen=2,DarkCyan=3,DarkRed=4,DarkMagenta=5,DarkYellow=6,Gray=7,DarkGray=8,Blue=9,Green=10,Cyan=11,Red=12,Magenta=13,Yellow=14,White=15) ");
            Console.Write("Введите номер цвета:");
            int.TryParse(Console.ReadLine(), out int inputRectangleColor);
            while (inputRectangleColor < 0 || inputRectangleColor > 15)
            {
                Console.Write("Введите номер цвета не меньше 0 и не больше 15:");
                int.TryParse(Console.ReadLine(), out inputRectangleColor);
            }
            ConsoleColor colorRectangle = (ConsoleColor)inputRectangleColor;
            Console.SetCursorPosition(0, 0);
            Rectangle rectangle = new Rectangle(inputRectangleX, inputRectangleY, inputRectangleLenght, inputRectangleSumvol, colorRectangle, inputRectangleHeight);
            rectangle.Draw();
            //============================================================
        }
        public void MenyTriangle()
        {
            
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("                                                                        ");
            Console.SetCursorPosition(0, 0);
            Console.Write("Введите X треугольника: ");
            int.TryParse(Console.ReadLine(), out int inputTriangleleX);
            while (inputTriangleleX <= 0 || inputTriangleleX >= 100)
            {
                Console.Write("Введите X треугольника не больше 100 и не меньше 0: ");
                int.TryParse(Console.ReadLine(), out inputTriangleleX);
            }
            //============================================================
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("                                                                        ");
            Console.SetCursorPosition(0, 0);
            Console.Write("Введите Y треугольника: ");
            int.TryParse(Console.ReadLine(), out int inputTriangleY);
            while (inputTriangleY <= 0 || inputTriangleY >= 100)
            {
                Console.Write("Введите Y квадрата не больше 100 и не меньше 0: ");
                int.TryParse(Console.ReadLine(), out inputTriangleY);
            }
            //============================================================
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("                                                                        ");
            Console.SetCursorPosition(0, 0);
            Console.Write("Введите длину треугольника: ");
            int.TryParse(Console.ReadLine(), out int inputTriangleLenght);
            while (inputTriangleLenght <= 0 || inputTriangleLenght >= 20 || inputTriangleLenght > inputTriangleleX)
            {
                Console.Write("Введите длину треугольника не больше 20 и/или не меньше 0 и/или больше X треугольника: ");
                int.TryParse(Console.ReadLine(), out inputTriangleLenght);
            }
            //============================================================
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("                                                                        ");
            Console.SetCursorPosition(0, 0);
            Console.Write("Введите символ: ");
            string inputTriangleSumvol = Console.ReadLine();
            int symvolTriangle = inputTriangleSumvol.Length;
            while (symvolTriangle <= 0 || symvolTriangle >= 2)
            {
                Console.Write("Введите символ не длинее одного символа и не менее одного: ");
                inputTriangleSumvol = Console.ReadLine();
                symvolTriangle = inputTriangleSumvol.Length;
            }
            //============================================================
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("                                                                        ");
            Console.WriteLine("                                                                        ");
            Console.SetCursorPosition(0, 0);
            Console.Write("(Black=0,DarkBlue=1,DarkGreen=2,DarkCyan=3,DarkRed=4,DarkMagenta=5,DarkYellow=6,Gray=7,DarkGray=8,Blue=9,Green=10,Cyan=11,Red=12,Magenta=13,Yellow=14,White=15) ");
            Console.Write("Введите номер цвета:");
            int.TryParse(Console.ReadLine(), out int inputTriangleColor);
            while (inputTriangleColor < 0 || inputTriangleColor > 15)
            {
                Console.Write("Введите номер цвета не меньше 0 и не больше 15:");
                int.TryParse(Console.ReadLine(), out inputTriangleColor);
            }
            ConsoleColor colorTriangle = (ConsoleColor)inputTriangleColor;
            Console.SetCursorPosition(0, 0);
            Triangle triangle = new Triangle(inputTriangleleX, inputTriangleY, inputTriangleLenght, inputTriangleSumvol, colorTriangle);
            triangle.Draw();
            //============================================================
        }
    }
}