using System;

class Program
{
    static void Main()
    {
        int X, Y; // целочисленные переменные 
        Console.Write("Целое число Х: "); // ввод представления первого числа
        string InputStr = Console.ReadLine();// Чтение с клавиатуры строки
        X = int.Parse(InputStr); // Преобразование в тип int

        Console.Write("Целое число Y: "); // ввод представления второго числа
        InputStr = Console.ReadLine();
        int.TryParse(InputStr, out Y);


        Console.WriteLine("(Х - У) = ", X - Y);
        Console.WriteLine("(Х * У) = ", X * Y);
        Console.WriteLine("(Х / У) = ", X / Y);
        Console.WriteLine("(Х % У) = ", X % Y);
        Console.WriteLine("(Х << У) = ", X << Y);
        Console.WriteLine("(Х >> У) = ", X >> Y);

        Console.ReadKey();
    }
}
