using System;
/* Задача 4. 
Написать метод с целочисленным параметром, определяющий является ли значение аргумента 
кодом цифры, кодом буквы русского алфавита (прописной либо строчной), или ни тем и ни другим. 
В основной программе, вводя целые числа, выводить сообщения о них: «Это цифра!», «Это буква!», 
«Это ни буква, ни цифра!». Для выхода из программы – ESC, для повторения решения - 
любой символ. При анализе цифрового кода использовать тернарную операцию. Строку сообщения 
может возвращать метод, либо метод возвращает признак, а строку формирует основная программа.
*/


namespace Task04
{
    class Program
    {
        public static void definesYMBOL(char code)
        {
            string report = code <= '9' && code >= '0' ? "Это цифра: " + (char)code
                : code <= 'Я' && code >= 'А' ? "Это прописная буква: " + (char)code
                : code <= 'я' && code >= 'а' ? "Это строчная буква: " + (char)code
                : "Неизвестный символ!";
            Console.WriteLine(report);
        }
        public static void Main()
        {
            uint code;
            string str;             // Строка для приёма данных
            string report;          // Строка с заключением о коде
            uint code_A = (uint)'А',  // Числовое значение кода буквы А
                  code_a = (uint)'а',
                  code_Ya = (uint)'Я',
                  code_ya = (uint)'я',
                  code_0 = (uint)'0';   // Числовое значение кода цифры 0
            do
            {
                Console.WriteLine("Коды граничных символов:");
                Console.WriteLine("Код А = " + code_A + "; Код Я = " + code_Ya +
                            "; Код а = " + code_a + "; Код я = " + code_ya +
                            "; Код нуля = " + code_0);
                Console.Write("Введите значение code: ");
                str = Console.ReadLine();
                uint.TryParse(str, out code);
                definesYMBOL((char)code);
                Console.WriteLine("Для выхода из программы нажмите ESC.");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
