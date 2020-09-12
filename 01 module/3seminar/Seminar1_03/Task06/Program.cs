using System;

/*
Написать метод для расчета сложных процентов. 
Параметры: начальный капитал, годовая процентная ставка, число лет (вклада). 
Возвращаемое значение – итоговая сумма в конце срока вклада. 
static double Total(double k, double r, uint n)

В основной программе ввести начальный капитал (больший нуля), процентную ставку и 
число лет. Вывести таблицу значений итоговых сумм в конце каждого года вплоть 
до заданного числа лет.
*/

class Program
{
    public static double Total(double k, double r, uint n)
    {
        return k * Math.Pow(1 + r / 100, n);
    }
static void Main(string[] args)
    {
        double k, r, s, temp;
        uint n;

        do
        {
            do Console.Write("Введите начальный капитал: ");
            while (!double.TryParse(Console.ReadLine(), out k)
                               | k <= 0);   // Капитал не отрицателен
            do Console.Write("Введите годовую процентную ставку: ");
            while (!double.TryParse(Console.ReadLine(), out r)
                                 || (r > 100 && r <= 0)); // Процент не отрицателен
            do Console.Write("Введите число лет: ");
            while (!uint.TryParse(Console.ReadLine(), out n)
                                | n == 0);  // число лет не равно нулю

            for (uint i = 0; i <= n; i++)
            {
                s = Total(k, r, i);         // обращение к методу
                Console.WriteLine("Итоговая сумма в конце {0} года: {1:f3}", n, s);
            }

        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
}

