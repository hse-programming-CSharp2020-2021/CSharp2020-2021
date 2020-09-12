using System;

/*
Вычислить площадь под графиком функции X^2 на отрезке [0;A]
при помощи метода трапеций, вещественная точка A и шаг интегрирования delta задаются с клавиатуры.
Чтобы организовать проверку корректности введённых данных, определите ограничения на значения А и delta.
Как вычисляется значение, добавляемое к интегральной сумме на каждом шаге.
Определите условие выхода из цикла формирования интегральной суммы.
*/

class Program
{
    public static double function(double x)
    {
        return x * x;
    }

    static void Main(string[] args)
    {
        double a, delta;
        do
        {
            do
            {
                Console.Write("Введите A: ");
            } while (!double.TryParse(Console.ReadLine(), out a) || (a <= 0)); // Преобразуем строку в число 

            do
            {
                Console.Write("Введите delta: ");
            } while (!double.TryParse(Console.ReadLine(), out delta) || (delta <= 0) || (delta >= a)); // Преобразуем строку в число 

            int n = (int)(a / delta);
            double result = 0;
            for (int i = 0; i < n; i++)
            {
                result += delta * (function(i*delta) + function((i + 1)*delta)) / 2;
            }

            Console.WriteLine(result);
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
}
