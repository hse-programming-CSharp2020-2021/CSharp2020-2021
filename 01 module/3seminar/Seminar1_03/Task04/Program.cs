using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static bool Newton(double x, out double sq, out double eps)
        {
            double r1, r2 = x;
            sq = eps = 0.0;
            if (x <= 0.0)
            {
                Console.WriteLine("Ошибка в данных!");
                return false;
            }
            do
            {
                r1 = r2;
                eps = x / r1 / 2 - r1 / 2;
                r2 = r1 + eps;
            } while (r1 != r2);  // пока приближения «различимы» для ЭВМ
            sq = r2;
            return true;
        }

        static void Main(string[] args)
        {
            double x, result = 0, eps = 0;
            Console.Title = "Формула Ньютона";

            do
            {
                do
                {
                    Console.Clear();       // очистка консольного окна
                    Console.Write("x=");
                } while (!double.TryParse(Console.ReadLine(), out x));
                
                if (!Newton(x, out result, out eps))
                {
                    Console.WriteLine("Error!"); return;
                }
                Console.WriteLine("root({0}) = {1,8:f4}, eps = {2,8:e4}", x, result, eps);

                Console.WriteLine("Для выхода нажмите клавишу ESC");

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
