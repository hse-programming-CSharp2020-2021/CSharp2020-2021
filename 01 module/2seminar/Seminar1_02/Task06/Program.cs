using System;

/* 
Задан круг с центром в начале координат и радиусом R=10.   
Ввести  координаты точки и вывести сообщение:   «Точка внутри круга!» или «Точка вне круга!».

Предусмотреть проверку входных данных и цикл повторения решений.  
*/


namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0, y = 0, r = 10;

            string str;    // Строка для приёма данных

            do
            {
                do
                {
                    Console.Write("Введите x: ");
                    str = Console.ReadLine();           // Читаем символьную строку 
                } while (!double.TryParse(str, out x)); // Преобразуем строку в число 

                do
                {
                    Console.Write("Введите y: ");
                    str = Console.ReadLine();           // Читаем символьную строку 
                } while (!double.TryParse(str, out y)); // Преобразуем строку в число 

                string report = "Точка ";
                report += x * x + y * y > r * r ? "вне круга!" : "внутри круга!";
                Console.WriteLine(report);

                Console.WriteLine("Для выхода из программы нажмите ESC.");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
