using System;

// Определить матрицу как двумерный массив, инициализировать ее элементы.
// Используя свойства и методы класса Array вывести ранг массива,
// общее число его элементов, число элементов по разным 
// измерениям, предельные значения всех индексов, признак 
// фиксированных размеров...
// Вывести элементы массива, используя цикл foreach...
// Вывести элементы массива по строкам (в виде таблицы)...


class Program
{
    static void Main(string[] args)
    {
        int[,] matr = new int[3, 4];

        Random rnd = new Random();
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = rnd.Next(-10, 10);
            }
        }

        Console.WriteLine("matr.GetType() = " + matr.GetType());
        Console.WriteLine("matr.IsFixedSize = " + matr.IsFixedSize);
        Console.WriteLine("matr.Rank = " + matr.Rank);
        Console.WriteLine("matr.Length = " + matr.Length);
        Console.WriteLine("matr.GetLength(1) = " + matr.GetLength(1));
        Console.WriteLine("matr.GetUpperBound(1) = " + matr.GetUpperBound(1));

        foreach (int memb in matr)
            Console.Write("{0,5}", memb);

        Console.WriteLine("\n");
        
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write("{0,3}", matr[i, j]);
            }
            Console.WriteLine();
        }

        Console.WriteLine("Для выхода из программы нажмите ENTER.");
        Console.ReadLine();
    }
}

