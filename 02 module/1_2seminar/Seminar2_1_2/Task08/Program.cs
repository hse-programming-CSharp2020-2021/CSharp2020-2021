using System;

namespace Task08
{
    class Program
    {
        public static int[,] CreateMatrix(int M, int N)
        {
            int[,] arr = new int[M, N];
            Random rnd = new Random();
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    arr[i, j] = rnd.Next(1, 11);
                }
            }
            return arr;
        }

        public static int[,] MatrixMult(int[,] a, int[,] b)
        {
            int sum = 0;
            if (a.GetLength(1) != b.GetLength(0))
                return null;
            int[,] arr = new int[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum = 0;
                    for (int r = 0; r < a.GetLength(1); r++)
                    {
                        sum += a[i, r] * b[r, j];
                    }
                    arr[i, j] = sum;
                }
            }
            return arr;
        }

        public static string MatrixToString(int[,] arr)
        {
            string str = "";

            for (int i = 0; i < arr.GetLength(0); i++, str += "\n")
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    str += arr[i, j] + " ";
                }
            }

            return str;
        }

        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int M);
            int.TryParse(Console.ReadLine(), out int N);

            int[,] a = CreateMatrix(M, N);
            Console.WriteLine(MatrixToString(a));
            int.TryParse(Console.ReadLine(), out int M2);
            int.TryParse(Console.ReadLine(), out int N2);

            int[,] b = CreateMatrix(M2, N2);
            Console.WriteLine(MatrixToString(b));
            int[,] c = MatrixMult(a, b);
            if (c != null)
                Console.WriteLine(MatrixToString(c));
            else
                Console.WriteLine("Перемножение невозможно");
            Console.ReadLine();
        }
    }
}
