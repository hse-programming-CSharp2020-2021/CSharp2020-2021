using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            int[,] arr = new int[n, n];

            int temp = 1;
            for (int i = 0; i < n; i++)
            {
                temp = i + 1;
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = temp++;

                    if (temp > n) temp = 1;

                }
            }

            for (int i = 0; i < n; i++, Console.WriteLine())
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
            }

            Console.ReadKey();
        }
    }
}
