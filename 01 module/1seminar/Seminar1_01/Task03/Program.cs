using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите вашу фамилию: ");
        string surname = Console.ReadLine();

        Console.Write("Введите ваше имя: ");
        string name = Console.ReadLine();
       
        Console.Write("Введите ваше отчество: ");
        string patronymic = Console.ReadLine();

        Console.WriteLine("Имя: " + name);
        Console.WriteLine("Отчество: " + patronymic);
        Console.WriteLine("Фамилия: " + surname);

        Console.WriteLine("Нажмите Enter для завершения!");
        Console.ReadKey();
    }
}

