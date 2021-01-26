using System;
class Program
{
    static void Main()
    {
        string[] lines = new string[] { "нуль", "один", "два",
                    "три", "четыре",
                                     "пять", "шесть", "семь", "восемь",                  "девять", "десять" };
        Console.WriteLine("\nИсходный массив:");
        foreach (string s in lines)
            Console.Write(s + " ");
        int len = lines.Length;
        int[] index = new int[len]; // Массив индексов
        for (int i = 0; i < len; i++)
            index[i] = i;

        // Сортировка массива индексов:
        for (int i = 0; i < len - 1; i++)
            for (int j = i + 1; j < len; j++)
                if (lines[index[i]].Length > lines[index[j]].Length)
                {
                    int temp = index[i];
                    index[i] = index[j];
                    index[j] = temp;
                }

        Console.WriteLine("Результат перебора:");
        foreach (int n in index)
            Console.Write(lines[n] + " ");
        Console.WriteLine("\nДля выхода нажмите любую клавишу.");
        Console.ReadKey(true);
    } // конец Main()
} // конец Program
