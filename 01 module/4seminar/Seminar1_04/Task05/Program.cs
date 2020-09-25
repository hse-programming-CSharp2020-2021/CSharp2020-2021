using System;

/*
Написать программу, выводящую на экран таблицу значений суммы ряда из n элементов 
для n = 1,…, K. Значение K – целое неотрицательное вводится с клавиатуры пользователем.
*/


class Program
{
    public static double function(int x)
    {
        double sum = 0;
        for (int i = 1; i <= x; i++)
        {
            sum += (i + 0.3) / (3 * i * i + 5);
        }
        return sum;
    }
    static void Main(string[] args)
    {
        uint k;
        do
        {
            do
            {
                Console.Write("Введите k: ");
            } while (!uint.TryParse(Console.ReadLine(), out k) || (k <= 0)); // Преобразуем строку в число 

            for (int i = 1; i <= k; i++)
            {
                Console.WriteLine("{0}\t{1:f3}", i, function(i));
            }

            Console.WriteLine("Для выхода из программы нажмите ESC.");
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
}
