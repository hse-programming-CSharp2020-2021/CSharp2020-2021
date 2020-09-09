using System;

/* 
Выделение отдельных цифр натурального числа
Задача. 
Ввести трехзначное натуральное число и напечатать его цифры "столбиком".
*/
class Program
{
    static void Numerals(uint number, out uint f1, out uint f2, out uint f3)
    {
        f1 = number / 100;            // первая цифра
        uint temp = number - f1 * 100;
        f2 = temp / 10;             // вторая цифра
        f3 = temp - f2 * 10;        // третья цифра
    }
    static void Main()
    {
        uint numb = 759;
        do
        {
            do Console.Write("Введите целое от 100 до 999: ");
            while (!uint.TryParse(Console.ReadLine(), out numb) ||
                           numb < 100 ||
                                 numb > 999);
            uint a, b, c;
            Numerals(numb, out a, out b, out c);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
}

