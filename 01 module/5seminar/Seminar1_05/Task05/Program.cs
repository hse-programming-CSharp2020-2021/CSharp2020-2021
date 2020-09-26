using System;

/*
В основной программе ввести размер N целочисленного массива, создать массив, 
присвоить его элементам случайные значения из диапазона [-10;10]. Выполнить сжатие 
массива, удалив из него элементы с четными значениями.  
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

        Random random = new Random(DateTime.Now.Millisecond);

        int[] arr = new int[N];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(-10, 11);
        }

        PrintArray(arr);
        CompressArray(ref arr);
        PrintArray(arr);
        Console.ReadKey();
    }

    public static void CompressArray(ref int[] arr)
    {
        // size of new array
        int curr = 0;
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] % 2 != 0)
                arr[curr++] = arr[i];
        if (curr > 0)
            Array.Resize(ref arr, curr);
    }

    public static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"[{i}] = {arr[i]}\t");
            // move to new line
            if ((i + 1) % 5 == 0)
                Console.WriteLine();
        }
        Console.WriteLine();
    }
}