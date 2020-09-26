using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] a = new int[3][];
            a[0] = new int[10];
            a[1] = new int[5];
            a[2] = new int[20];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a[i].GetLength(0); j++)
                {
                    a[i][j] = i + j;
                    Console.Write($"{a[i][j]}   ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
