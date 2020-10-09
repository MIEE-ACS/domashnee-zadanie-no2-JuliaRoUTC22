using System;

namespace Console_homework_2
{
    class Program
    {

        static double segment1(double x, double r) //расчёт первого сегмента графика
        {
            double k = 1; //tan(45) = 1
            double b = 3; //y = k * x + b => 0 = 1 * (-3) + 3
            double y;
            y = k * x + b;
            return y;
        }

        static double segment2(double x, double r) //расчёт второго сегмента графика
        {
            double a = 0; //центр окружности в 
            double b = 0;
            double y;
            y = Math.Sqrt(r * r - (x - a) * (x - a)) - b;
            return y;
        }

        static double segment3(double x, double r) //расчёт третьего сегмента графика
        {
            double k = -0.5;
            double b = 3; //y = k * x + b => 0 = (-0.5) * (-3) + 3
            double y;
            y = k * x + b;
            return y;
        }

        static double segment4(double x, double r) //расчёт четвёртого сегмента графика
        {
            double k = 1; //tan(45) = 1
            double b = -6; //y = k * x + b => 0 = 1 * 6 + (-6)
            double y;
            y = k * x + b;
            return y;
        }


        static void Main(string[] args)
        {
            string Title = "Программа вычисляет значение функции, заданной в виде графика.";
            int centerX = (Console.WindowWidth / 2) - (Title.Length / 2); //выравниваем заголовок по центру
            Console.SetCursorPosition(centerX, 0);
            Console.WriteLine(Title);

            Console.WriteLine("Введите параметр R.");
            int r;
            r = int.Parse(Console.ReadLine());

            for (double x = -5; x <= 9; x += 0.3) //шаг 0.2
            {
                if (x < -5)
                {
                    Console.WriteLine("Функция не определена.");
                }
                else if (x < -3)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment1(x, r));
                }
                else if (x < 0)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment2(x, r));
                }
                else if (x < 6)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment3(x, r));
                }
                else if (x < 9)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment4(x, r));
                }
            }

            Console.ReadKey();
        }
    }
}
