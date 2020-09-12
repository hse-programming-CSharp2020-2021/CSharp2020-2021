using System;

/*
Написать метод Function() с двумя логическими параметрами, вычисляющий и возвращающий значение логического выражения (конкретное выражение в условии должно быть явно задано). 
Логическое выражение:
!(p & q) & !(p | !q)

В основной программе построить таблицу истинности логического выражения, заданного методом.

*/

class Program
{
    public static bool Function(bool x, bool y)
    {
        return !(x & y) & !(x | !y);
    }
    static void Main(string[] args)
    {
        bool p = true, q, res;
        Console.WriteLine("Таблица истинности !(p & q) & !(p | !q)");
        Console.WriteLine(" p \t q \t F");
        do
        {
            q = true;
            do
            {
                res = Function(p, q); // Вызов Function()
                Console.WriteLine("{0}\t{1}\t{2}", p, q, res);
                q = !q;
            } while (!q);
            p = !p;
        } while (!p);
        Console.WriteLine("Для выхода нажмите ENTER");
        Console.ReadLine();
    }
}
