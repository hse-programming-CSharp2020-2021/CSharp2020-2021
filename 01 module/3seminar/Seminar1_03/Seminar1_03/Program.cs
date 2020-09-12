using System;

/*
Написать метод, переводящий оценку в баллах десятибалльной шкалы в аттестационную 
(четырех балльную) шкалу: 
 * 1, 2, 3 балла – неудовлетворительно;
 * 4,5 – удовлетворительно;
 * 6,7 – хорошо;
 * 8, 9, 10 – отлично. 
Используйте переключатель.
В основной программе в получайте от пользователя оценки (целые числа из диапазона 
1..10 и выводите значение в четырёх балльной шкале.
*/

class Program
{
    static void Main(string[] args)
    {
        do
        {
            int mark;
            do
            {
                Console.Write("Введите оценку: ");
            } while (!int.TryParse(Console.ReadLine(), out mark) || (mark < 1) || (mark > 10)); // Преобразуем строку в число 

            switch (mark)
            {
                case int n when (n >= 1 && n <= 3):
                    Console.WriteLine("неудовлетворительно");
                    break;
                case int n when (n >= 4 && n <= 5):
                    Console.WriteLine("удовлетворительно");
                    break;
                case int n when (n >= 6 && n <= 7):
                    Console.WriteLine("хорошо");
                    break;
                case int n when (n >= 8 && n <= 10):
                    Console.WriteLine("отлично");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
}
