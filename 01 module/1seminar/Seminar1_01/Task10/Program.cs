using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое слово: ");
        string word1 = Console.ReadLine();

        Console.Write("Введите второе слово: ");
        string word2 = Console.ReadLine();

        Console.Write("Введите третье слово: ");
        string word3 = Console.ReadLine();

        Console.WriteLine(word1 + "!" + word2 + "!" + word3 + "!");
        Console.WriteLine("Нажмите Enter для завершения!");

        Console.ReadKey();
    }
}

