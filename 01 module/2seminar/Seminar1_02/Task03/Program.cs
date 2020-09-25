using System;

/* Задача на применение тернарной операции. 
(Не применять оператор if.)
Написать метод, так обменивающий значения трех переменных x, y, z, 
чтобы выполнилось требование: x <= y <= z. 

В основной программе, вводить значения трех переменных и упорядочивать 
их с помощью обращения к написанному методу. 

Для выхода из программы вводите ESC, для повторения решения – любую другую клавишу. 
*/


namespace Task03
{
    class Program
    {
        public static void ValuesSort(ref int x, ref int y, ref int z)
        {
            // Вспомогательные переменные
            int a1 = 0, a2 = 0, a3 = 0;
            a1 = x < y ? (z < x ? z : x) : (y < z ? y : z);
            a3 = x > y ? (z > x ? z : x) : (y > z ? y : z);
            a2 = x + y + z - a1 - a3;
            x = a1; y = a2; z = a3;
        }
        static void Main(string[] args)
        {
            int x = 0, y = 0, z = 0;

            string str;    // Строка для приёма данных

            do
            {
                do
                {
                    Console.Write("Введите x: ");
                    str = Console.ReadLine();           // Читаем символьную строку 
                } while (!int.TryParse(str, out x)); // Преобразуем строку в число 

                do
                {
                    Console.Write("Введите y: ");
                    str = Console.ReadLine();           // Читаем символьную строку 
                } while (!int.TryParse(str, out y)); // Преобразуем строку в число 

                do
                {
                    Console.Write("Введите z: ");
                    str = Console.ReadLine();           // Читаем символьную строку 
                } while (!int.TryParse(str, out z)); // Преобразуем строку в число 

                ValuesSort(ref x, ref y, ref z);

                Console.WriteLine("x = " + x);
                Console.WriteLine("y = " + y);
                Console.WriteLine("z = " + z);
                Console.WriteLine("Для выхода из программы нажмите ESC.");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
