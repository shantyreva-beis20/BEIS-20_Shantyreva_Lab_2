using System;

namespace lb1kurs2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Лабораторная работа №1. Задание 1";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            double pi = 3.14;
            double r, c, s;
            Console.WriteLine("\n Введите радиус окружности: ");
            r = Double.Parse(Console.ReadLine());
            if (r > 0)
            {
                c = 2 * pi * r;
                s = pi * Math.Pow(r, 2);
                Console.Write("\n Длина окружности: " + c);
                Console.Write("\n Площадь круга: " + s);
            }
            else
                Console.Write("\n Данные введены неверно! ");
            Console.ReadKey();
        }
    }
}



