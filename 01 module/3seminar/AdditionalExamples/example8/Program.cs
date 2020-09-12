using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }

            int j = 0;
            while (j <= 10)
            {
                Console.WriteLine(j);
                j++;
            }

            int k = 0;
            do
            {
                k++;
                Console.WriteLine(k);
            } while (k < 10);


            Console.ReadKey();
        }
    }
}

