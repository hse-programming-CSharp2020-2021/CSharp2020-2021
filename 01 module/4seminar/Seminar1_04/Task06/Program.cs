using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06
{
    class Program
    {
        public static double func1(double x)
        {
            double sum = 0, sumpred = 0;
            int fuct = 2;
            int i = 0, j = 2;
            int z = 1;

            do
            {
                sumpred = sum;
                sum += Math.Pow(2, j - 1) * Math.Pow(x, j) / fuct * z;
                j += 2;
                fuct *= j * (j - 1);
                z *= -1;
            } while (sum - sumpred > 0.1);

            return sum;
        }

        public static double func2(double x)
        {
            double sum = 0, sumpred = 0;
            int fuct = 1;
            int i = 0;

            do
            {
                sumpred = sum;
                sum += Math.Pow(x, i) / fuct;
                i++;
                fuct *= i;
            } while (sum - sumpred > 0.1);

            return sum;
        }

        static void Main(string[] args)
        {
            double x;
            do
            {
                do
                {
                    Console.Write("Введите x: ");
                } while (!double.TryParse(Console.ReadLine(), out x) || (x <= 0)); // Преобразуем строку в число 

                Console.WriteLine("func1 {0:f3}\t{1:f3}", x, func1(x));
                Console.WriteLine("func2 {0:f3}\t{1:f3}", x, func2(x));
                
                Console.WriteLine("Для выхода из программы нажмите ESC.");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
