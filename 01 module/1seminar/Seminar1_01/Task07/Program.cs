using System;
class Program
{
    static void Main()
    {
        int firstInt, secondInt; // целочисленные переменные 
        Console.Write("Целое число: "); // ввод представления первого числа
        string InputStr = Console.ReadLine();// Чтение с клавиатуры строки
        firstInt = int.Parse(InputStr); // Преобразование в тип int

        Console.Write("Целое число: "); // ввод представления второго числа
        InputStr = Console.ReadLine();
        int.TryParse(InputStr, out secondInt);

        Console.WriteLine("Ваш текст: " + firstInt + secondInt); // вывод
        Console.ReadKey();
    }
}
