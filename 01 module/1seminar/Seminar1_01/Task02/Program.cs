using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your name:");
        // описываем переменную максимально близко
        // к месту первого использовани в коде
        string inputStr = Console.ReadLine();
        Console.WriteLine("Hi, " + inputStr + "!");
        Console.ReadKey();
    }
}

