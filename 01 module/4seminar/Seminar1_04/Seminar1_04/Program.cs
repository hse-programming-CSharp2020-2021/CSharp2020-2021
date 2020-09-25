using System;

/*
В основной программе ввести трехзначное натуральное число и преобразовать его в число, 
где его цифры упорядочены по убыванию.

Для этого написать метод, так преобразующий значение целочисленного трехзначного параметра, 
чтобы его  цифры стали упорядочены по убыванию. Метод должен возвращать значение false, 
если параметр задан неверно. При удачном преобразовании метод возвращает true. 

Заголовок метода: 
bool Transform(ref uint numb)

Основная программа, используя метод, «общается» с пользователем.
*/

class Program
{
    public static bool Transform(ref uint numb)
    {
        
        if (numb >=100 && numb < 1000)
        {
            uint x, y, z;
            x = numb / 100;
            y = (numb % 100) / 10;
            z = numb % 10;
            uint a1 = 0, a2 = 0, a3 = 0;
            a1 = x < y ? (z < x ? z : x) : (y < z ? y : z);
            a3 = x > y ? (z > x ? z : x) : (y > z ? y : z);
            a2 = x + y + z - a1 - a3;
            x = a1; y = a2; z = a3;
            numb = 100 * z + 10 * y + x;
            return true;
        }
        return false;
    }
    static void Main(string[] args)
    {
        uint numb = 759;
        do
        {
            do Console.Write("Введите целое от 100 до 999: ");
            while (!uint.TryParse(Console.ReadLine(), out numb) ||
                           numb < 100 ||
                                 numb > 999);

            if (Transform(ref numb))
            {
                Console.WriteLine(numb);
            } else
            {
                Console.WriteLine("Число неккоректно");
            }

        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
}
