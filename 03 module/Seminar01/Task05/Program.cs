using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    class Program
    {
        delegate double Proizv(int i);
        delegate double Sum();
        public static void Main()
        {
            const int Max = 5;
            double x;
            do
            {
                Console.Write("Введите x - ");
            } while (!double.TryParse(Console.ReadLine(), out x));
            Proizv prF = (i) => {
                double p = 1;
                for (int j = 1; j <= Max; j++)
                    p = p * i * x / j;
                return p;
            };
            Sum sumF = () => {
                double S = 0;
                for (int i = 1; i <= Max; i++)
                    S += prF(i);
                return S;
            };
            Console.WriteLine(sumF());
            Console.ReadKey();
        }

    }
}
