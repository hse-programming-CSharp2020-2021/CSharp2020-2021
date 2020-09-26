using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10, n2 = 5, n3 = 2;
            int[] a1 = new int[n1];
            int[,] a2 = new int[n1, n2];
            int[,,] a3 = new int[n1, n2, n3];

            for (int i = 0; i < n1; i++)
            {
                a1[i] = i + 1;
                Console.Write($"{a1[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < n2; j++)
                {
                    a2[i, j] = i + j + 1;
                    Console.Write($"{a2[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < n2; j++)
                {
                    for (int k = 0; k < n3; k++)
                    {
                        a3[i, j, k] = i + j + k + 1;
                        Console.Write($"{a3[i, j, k]} ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
