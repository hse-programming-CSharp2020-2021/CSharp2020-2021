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

        Console.WriteLine("-" + word1 + "-");
        Console.WriteLine("-" + word2 + "-");
        Console.WriteLine("-" + word3 + "-");
        Console.WriteLine("Нажмите Enter для завершения!");

        Console.ReadKey();
    }
}
