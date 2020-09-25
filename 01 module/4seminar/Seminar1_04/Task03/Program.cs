using System;

/*
В основной программе ввести значения трех вещественных чисел. 
Если числа могут быть длинами сторон треугольника - вычислить его площадь по формуле Герона. 

Написать метод, вычисляющий площадь (s) и периметр (p) треугольника 
по заданным длинам его сторон. Метод должен возвращать значение false, 
если параметры заданы неверно и треугольник с такими длинами построить нельзя. 
При удачном задании длин сторон метод возвращает true. 

Заголовок метода: 
bool Triangle(double x, double y, double z, out double p, out double s)

Основная программа, используя метод, «общается» с пользователем.
*/

class Program
{
    public static bool Triangle(double x, double y, double z, out double p, out double s)
    {
        p = -1; s = -1;
        if (x < y + z && y < x + z && z < x + y)
        {
            p = x + y + z;
            s = Math.Sqrt(p / 2 * (p / 2 - x) * (p / 2 - y) * (p / 2 - z));
            return true;
        }
        return false;
    }
    static void Main(string[] args)
    {
        double a, b, c, p, s;
        do
        {
            do
            {
                Console.Write("Введите строну a: ");
            } while (!double.TryParse(Console.ReadLine(), out a) || (a <= 0)); // Преобразуем строку в число 

            do
            {
                Console.Write("Введите стооону b: ");
            } while (!double.TryParse(Console.ReadLine(), out b) || (b <= 0)); // Преобразуем строку в число 

            do
            {
                Console.Write("Введите сторону c: ");
            } while (!double.TryParse(Console.ReadLine(), out c) || (c <= 0)); // Преобразуем строку в число 

            if (Triangle(a, b, c, out p, out s))
            {
                Console.WriteLine("P = {0:f3}; S={1:f3}", p, s);
            }
            else
            {
                Console.WriteLine("Неверное значение");
            }
            Console.WriteLine("Для выхода из программы нажмите ESC.");
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
}
