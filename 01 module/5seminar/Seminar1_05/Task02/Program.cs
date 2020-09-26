using System;

/*
Получить от пользователя число К - размер массива и определить массив символов из К элементов. 
Присвоить элементам массива случайные значения от 'A' до 'Z'. 
Вывести полученный массив, затем создать копию массива, 
отсортировать элементы копии в алфавитном порядке и вывести. 
Затем реверсировать (заменить порядок следования элементов на обратный) отсортированный массив и вывести на экран.
*/
class Program
{
    static void Main(string[] args)
    {
        char[] line; // массив символов
        int K;      // количество элементов в массиве line
        Random generator = new Random();

        do Console.Write("Введите размер массива: ");
        while (!int.TryParse(Console.ReadLine(), out K) || K <= 0);
        line = new char[K];

        for (int i = 0; i < K; i++)
        {
            line[i] = (char)generator.Next('A', 'Z' + 1);
            Console.Write("{0,2}", line[i]); 
        } //i
        Console.WriteLine();
        char[] newline = (char[])line.Clone();
        // упорядочение букв в массиве и вывод 
        Array.Sort(newline);
        foreach (char ch in newline)
            Console.Write("{0,2}", ch);
        Console.WriteLine();
        // инверсия порядка значений в массиве и вывод
        Array.Reverse(newline);
        foreach (char ch in newline)
            Console.Write("{0,2}", ch);
        Console.ReadKey();
    }
}
