using System;

// Ввести положительные значения N и M. Построить двумерный 
// целочисленный массив (матрицу) с размерами N на M, элементы 
// которого a[i, j] = (i+1)*(2*j+1), для i от 0 до (N-1), 
// j от 0 до (M-1). 
// Вывести матрицу в виде таблицы, а также значения свойств 
// Rank и Length. 

namespace Task04
{
    class Program
    {
        public static void MatrixForm(out int[,] ar, uint N, uint M)
        {
            ar = new int[N, M];
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    ar[i, j] = (i + 1) * (2 * j + 1);
        }

        public static void SquareMatrixForming(ref int[,] ar, uint N, uint M)
        {
            if (N != M) return;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (i + j > N - 1)
                    {
                        ar[i, j] = 0;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            uint N, M;    
            int[,] ar;   
            do
            {
                do Console.Write("Введите число строк (N>0): ");
                while (!uint.TryParse(Console.ReadLine(), out N) || N == 0);

                do Console.Write("Введите число столбцов (M>0): ");
                while (!uint.TryParse(Console.ReadLine(), out M) || M == 0);

                MatrixForm(out ar, N, M);
                SquareMatrixForming(ref ar, N, M);

                Console.WriteLine("ar.Length:  " + ar.Length);
                Console.WriteLine("ar.Rank:  " + ar.Rank);

                Console.WriteLine("Элементы массива:");
                for (int i = 0; i < N; i++, Console.WriteLine())
                    for (int j = 0; j < M; j++)
                        Console.Write("{0,3}\t", ar[i, j]);

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}

