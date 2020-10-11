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
            double a = 0; //центр окружности
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
            Console.Clear();

            string Title = "Программа вычисляет значение функции, заданной в виде графика.";
            int centerX = (Console.WindowWidth / 2) - (Title.Length / 2); //выравниваем заголовок по центру
            Console.SetCursorPosition(centerX, 0);
            Console.WriteLine(Title);

            Console.WriteLine("Введите параметр R.");
            double r;
            r = double.Parse(Console.ReadLine());


            for (double x = -5; x <= (9 +0.2); x += 0.2) //шаг 0.2
            {

                if (r >= 0) //проверка корректности ввода
                {
                    if (x < -5)
                    {
                        Console.WriteLine("Функция не определена.");
                    }

                    if ((-5 <= x) && (x < (-3 + 0.2)))
                    {
                        Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment1(x, r));
                    }

                    if ((-3 < x) && (x < (0 + 0.2)))
                    {

                        if (r < 3)
                        {

                            if (x < -r)
                            {
                                Console.WriteLine("y({0:0.00}) - функция не определена в этой точке", x);
                            }

                            else
                            {
                                 if (r == 0)
                                 {
                                     Console.WriteLine("y({0:0.00}) = {1:0.00}", 0, 0);
                                 }
                                else
                                { 
                                Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment2(x, r));
                                }
                              
                            }
                        }

                        else
                        {
                            Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment2(x, r));
                        }
                    }

                    if ((0 <= x) && (x <= 6))
                    {        
                     Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment3(x, r));
                    }

                    if ((6 <= x) && (x <= 9.2))
                    {
                        Console.WriteLine("y({0:0.00}) = {1:0.00}", x, segment4(x, r));
                    }
                }
            }

           if (r < 0)
           {
             Console.WriteLine("Некорректный ввод параметра R (R >= 0).");
           }
             
        Console.ReadKey();
        }
    }
}
