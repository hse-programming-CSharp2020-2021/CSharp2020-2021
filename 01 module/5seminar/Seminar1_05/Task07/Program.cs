using System;

/*
 Написать метод для формирования массива символов, представляющих отдельные цифры целого числа N, 
 переданного в параметре 
 В основной программе, вводя значения целого N > 0, формировать символьный массив его цифр и 
 выводить его элементы на экран.
*/
class Program
{
    static void Main(string[] args)
    {
        int number;
        do
        {
            Console.Write("Введите целое положительное число: ");
        }
        while (!int.TryParse(Console.ReadLine(), out number) || number <= 0);

        char[] ciphers = GetDigits(number);

        Console.Write("Цифры числа: ");
        foreach (char ch in ciphers)
            Console.Write(" " + ch);
        Console.WriteLine();
        Console.ReadKey();
    }

    public static char[] GetDigits(int number)
    {
        // количество цифр числа
        int len = (int)Math.Log10(number) + 1;
        // массив для хранения цифр
        char[] digits = new char[len];
        int figure, i = len - 1;
        do
        {
            // выделяем цифры числа и помещаем в массив
            figure = number % 10;
            number = number / 10;
            digits[i--] = (char)(figure + '0');
        }
        while (number != 0);

        return digits;
    }

}