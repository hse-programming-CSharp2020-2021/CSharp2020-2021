using System;

/*
8.1. Написать метод формирования массива из N вещественных элементов, значения элементов массива 
вычисляются по формуле:
a_i = (i * (i + 1)) / 2 % N;  i = 0, 1, 2, 3, …, (N-1)
 
8.2. Написать метод нормировки элементов вещественного массива путем деления каждого элемента на 
значение максимального по модулю элемента.
 
8.3. Написать метод вывода на экран значений элементов вещественного массива с точностью до трёх 
знаков после запятой.
 
8.4. В основной программе получать от пользователя значение N, формировать и нормировать массив. 
Исходный и нормированный массивы выводить на экран. 
*/
class Program
{
    static void Main(string[] args)
    {
        uint N;
        do
        {
            Console.Write("Введите размер массива N: ");
        }
        while (!uint.TryParse(Console.ReadLine(), out N));

        double[] arr = FormArray(N);
        Console.WriteLine("До нормировки");
        PrintArray(arr);
        NormArray(ref arr);
        Console.WriteLine("После нормировки");
        PrintArray(arr);
        Console.ReadKey();
    }

    public static double[] FormArray(uint N)
    {
        double[] arr = new double[N];
        for (int i = 0; i < N; i++)
        {
            arr[i] = ((i * (i + 1)) / 2.0) % N;
        }
        return arr;
    }

    public static void NormArray(ref double[] arr)
    {
        if (arr.Length == 0)
        {
            Console.WriteLine("Массив пустой");
            return;
        }

        double max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
                max = arr[i];
        }

        if (Equals(max, 0)) // if max == 0
        {
            Console.WriteLine("Нормировка невозможна (деление на ноль)");
            return;
        }

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = arr[i] / max;
        }
    }

    public static void PrintArray(double[] arr)
    {
        foreach (double i in arr)
        {
            Console.Write($"{i:F3} ");
        }
        Console.WriteLine();
    }
}
