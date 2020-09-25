using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите ваше имя:");
        // описываем переменную максимально близко
        // к месту первого использовани в коде
        string inputStr = Console.ReadLine();
        Console.WriteLine("Приветствую Вас, " + inputStr + "!");
        Console.WriteLine("Нажмите Enter для завершения!");
        Console.ReadKey();
    }
}

