using System;

/*
В основной программе ввести натуральное число и вычислить суммы его цифр, находящихся 
в чётных и на нечётных разрядах. Разряд единиц считать нулевым и чётным.

Для этого написать метод с натуральным параметром,  вычисляющий суммы цифр, находящихся 
на четных и на нечетных позициях в записи значения параметра.  

Заголовок метода: 
void Sums(uint number, out uint sumEven, out uint sumOdd)

Основная программа, используя метод, «общается» с пользователем.
*/


class Program
{

    public static void Sums(uint number, out uint sumEven, out uint sumOdd)
    {
        sumEven = 0;
        sumOdd = 0;
        for (int i = 0; number > 0; i++)
        {
            if (i % 2 == 0)
            {
                sumEven += number % 10;
            }
            else
            {
                sumOdd += number % 10;
            }
            number /= 10;
        }
    }
    static void Main(string[] args)
    {
        uint a, evenSum, oddSum;
        do
        {
            do
            {
                Console.Write("Введите a: ");
            } while (!uint.TryParse(Console.ReadLine(), out a) || (a <= 0)); // Преобразуем строку в число 

            Sums(a, out evenSum, out oddSum);

            Console.WriteLine("Четные: " + evenSum);
            Console.WriteLine("Нечетные: " + oddSum);

            Console.WriteLine("Для выхода из программы нажмите ESC.");
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
}
