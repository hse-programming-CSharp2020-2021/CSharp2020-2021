using System;

/*
4.1. Написать метод для формирования массива, целочисленные неотрицательные элементы которого 
вычисляются по следующему рекуррентному соотношению: ai+1 = ai%2==0 ? ai/2 :(3*ai+1). 
Процесс вычисления завершается, когда ai+1 станет равным 1. 
Параметр метода задает значение a0. Количество элементов массива заранее не известно, так как 
определяется значением a0.
  
4.2. Написать метод вывода элементов массива в виде [индекс] = значение, размещая в строке по 5 элементов.
4.3 В основной программе, вводя значения a0, формировать массив и выводить его элементы на экран.
*/
class Program
{
    static void Main(string[] args)
    {
        uint a;
        do
        {
            Console.Write("Введите a: ");
        }
        while (!uint.TryParse(Console.ReadLine(), out a));

        PrintArray(FormArray(a));
        Console.ReadKey();
    }

    public static uint[] FormArray(uint a)
    {
        uint[] arr = new uint[1];
        arr[0] = a;

        int count = 0;
        // while last element in array is not equal to 1
        while (arr[count] != 1)
        {
            // check if we need to double size of array
            if (arr.Length == count + 1)
            {
                ChangeArraySize(ref arr, arr.Length * 2, arr.Length);
            }
            arr[count + 1] = arr[count] % 2 == 0 ? arr[count] / 2 :
                                                   3 * arr[count] + 1;
            count++;
        }

        // check if we need to remove zeros from the tail of the array
        if (arr.Length > ++count)
        {
            Array.Resize(ref arr, count);
        }

        return arr;
    }

    public static void ChangeArraySize(ref uint[] array,
                                       int newArraySize,
                                       int numberOfElementsToCopy)
    {
        uint[] tempArr = new uint[newArraySize];
        Array.Copy(array, tempArr, numberOfElementsToCopy);
        array = tempArr;

    }

    public static void PrintArray(uint[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"[{i}] = {arr[i]}\t");
            // move to new line
            if ((i + 1) % 5 == 0)
                Console.WriteLine();
        }
    }
}