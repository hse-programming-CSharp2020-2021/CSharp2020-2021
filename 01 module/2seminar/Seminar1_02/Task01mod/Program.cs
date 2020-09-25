using System;
class Program
{
    public static int Un(uint n)
    {
        double b = (1 + Math.Sqrt(5)) / 2;
        double un = (Math.Pow(b, n) - Math.Pow(-b, -n)) / (2 * b - 1);
        return (int)(un + 0.5);
    } // Конец определения метода Un()
    public static void Main()
    {
        do {                  // цикл для повторения решения

            uint n;            // Номер члена ряда   
            int res;           // Целочисленное значение члена 
            string line;    // Строка для приёма данных 
            do
            {
                Console.Write("Введите номер члена ряда: ");
                line = Console.ReadLine();
            } while (!uint.TryParse(line, out n));
            res = Un(n);        // Вызов метода
            Console.WriteLine("число Фибоначчи: " + res);
                Console.WriteLine("Для выхода нажмите клавишу ESC");
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    } //Конец определения метода Main()
} //Конец объявления класса Program
