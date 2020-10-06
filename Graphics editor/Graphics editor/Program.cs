using System;

namespace Graphics_editor
{
    class Program
    {
        static void Main(string[] args)
        {           
            bool cucle = true;
            InputFigure inputFigures = new InputFigure();
            while (cucle)
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("                                                                                                                                                                                                                                       ");
                Console.SetCursorPosition(0, 0);
                Console.Write("Введите 1-вывести фигуру, 2-очистить экран, 3-закрыть прогу:");                
                string input = Console.ReadLine();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("                                                               ");
                Console.SetCursorPosition(0, 0);
                switch (input)
                {
                    case "1":                      
                        Console.Write("1-квадрат, 2-прямоугольник, 3-треугольник:");
                        string inputFigure = Console.ReadLine();
                        switch(inputFigure)
                        {
                            
                            case"1":
                                inputFigures.MenySquare();
                                break;
                            case "2":
                                inputFigures.MenyRectangle();
                                break;
                            case "3":
                                inputFigures.MenyTriangle();
                                break;
                            default:
                                Console.Write("1-квадрат, 2-прямоугольник, 3-треугольник!:");
                                inputFigure = Console.ReadLine();
                                break;
                        }
                        break;
                    case "2":
                        Console.Clear();
                        break;
                    case "3":
                        cucle = false;
                        break;
                    default:
                        Console.Write("Введите 1-вывести фигуру, 2-очистить экран, 3-закрыть прогу!:");
                        input = Console.ReadLine();
                        break;
                }                        
            }
            Console.SetCursorPosition(0, 100);
        }
    }
}
