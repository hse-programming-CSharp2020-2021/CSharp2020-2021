using Lib03;
using System;

namespace Task03
{
    // Использование  метода bisec() с параметром-делегатом
    class Program
    {  // Объявление вспомогательного метода:
        static double fun1(double x)
        {
            return Math.Sin(x) + 0.5;
        }

        static void Main()
        {
            // Библиотечная функция в качестве аргумента:
            double root = NumMeth.bisec(0, 2, 0.001, 0.001, Math.Cos);
            Console.WriteLine("Cos({0:f5})={1:F5}", root, Math.Cos(root));

            // Используем в качестве аргумента явно определенный метод:
            root = NumMeth.bisec(3, 5, 0.001, 0.001, fun1);
            Console.WriteLine("sin({0:f5})+0.5={1:F5}", root, fun1(root));

            // Объявление анонимного метода:
            function funA = delegate (double x) { return x * x - 1; };
            // Применение анонимного метода:
            root = NumMeth.bisec(0, 2, 0.001, 0.001, funA);
            Console.WriteLine("x = {0:f5}; x*x-1={1:F5}", root, funA(root));

            // Применение лямбда-выражения (заменяем параметр-делегат):
            root = NumMeth.bisec(0, 2, 0.001, 0.001, x => Math.Cos(x));
            Console.WriteLine("Cos({0:f5})={1:F5}", root, Math.Cos(root));

            Console.ReadLine();
        }
    }
}
