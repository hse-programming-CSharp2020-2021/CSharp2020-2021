using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 3 };
            int[] b = { 1, 2, 3 };
            int[] c = new int[3];
            c[0] = 1;
            c[1] = 2;
            c[2] = 3;
            int[] d = c;
            c[2] = 5;

            for (int i = 0; i < a.GetLength(0); i++)
                Console.Write($"{a[i]}  ");
            Console.WriteLine();

            for (int i = 0; i < b.GetLength(0); i++)
                Console.Write($"{b[i]}  ");
            Console.WriteLine();

            for (int i = 0; i < c.GetLength(0); i++)
                Console.Write($"{c[i]}  ");
            Console.WriteLine();

            for (int i = 0; i < d.GetLength(0); i++)
                Console.Write($"{d[i]}  ");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
