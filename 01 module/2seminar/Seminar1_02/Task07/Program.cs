using System;

//Вычисление значения логической функции !(X&Y|Z)

namespace Task07
{
    class Program
    {
        static void Main(string[] args)
        {
            int tmp;    //рабочая переменная
            bool x, y, z;   //аргументы логической функции
            string str;  //строка для приема данных
            do { 
                Console.Write("Введите значение x: ");
                str = Console.ReadLine();
                int.TryParse(str, out tmp);
                x = tmp > 0 ? true : false;

                Console.Write("Введите значение y: ");
                str = Console.ReadLine();
                int.TryParse(str, out tmp);
                y = tmp > 0 ? true : false;

                Console.Write("Введите значение z: ");
                str = Console.ReadLine();
                int.TryParse(str, out tmp);
                z = tmp > 0 ? true : false;
                // !а+b
                Console.WriteLine("!(X&&Y||Z) = " + !(x && y || z));
                 
                Console.WriteLine("Для выхода нажмите ENTER.");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
