using System;

/*
6.1.  Написать метод, реализующий операцию «сжатия массива»: если сумма двух соседних 
элементов A[i], A[i+1] начиная с первого делится на три, вычислить их произведение. 
Произведение присвоить элементу A[i]. Элемент A[i+1] удалить, элементы справа от i сдвигаются 
на одну позицию влево, размер массива уменьшается на 1. Далее обрабатываются элементы, начиная 
с  (i+1)-го и так до конца массива. 
 
6.2.  Написать метод, последовательно «запускающий» операцию (метод) сжатия массива и возвращающий
количество успешно проведенных операций до момента, когда сжать массив больше невозможно. 
В основной программе ввести размер N целочисленного массива, создать массив, присвоить его 
элементам случайные значения из диапазона [-10;10]. Выполнить сжатие массива.  
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

        Console.WriteLine("До сжатия");
        PrintArray(arr);
        Console.WriteLine("Number of compresses is " + SubsequentlyCompressArray(ref arr));
        Console.WriteLine("После сжатия");
        PrintArray(arr);
        Console.ReadKey();
    }

    public static int[] CompressArray(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] * arr[i + 1] % 3 == 0)
            {
                arr[i] *= arr[i + 1];
                for (int j = i + 1; j < arr.Length - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                Array.Resize(ref arr, arr.Length - 1);
            }
        }

        return arr;
    }

    public static int SubsequentlyCompressArray(ref int[] arr)
    {
        int[] tempArr;
        int count = 0;

        while (true)
        {
            tempArr = CompressArray(arr);
            //PrintArray(tempArr); // for debugging
            if (CheckIfArraysAreSimilar(arr, tempArr))
                break;
            count++;
            arr = tempArr;
        }

        return count;
    }

    public static bool CheckIfArraysAreSimilar(int[] a, int[] b)
    {
        if (a.Length != b.Length)
            return false;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != b[i])
                return false;
        }
        return true;
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