using System;

/*
В основной программе ввести символ, и если это символ латинской строчной буквы -  
сдвинуть его циклически в алфавите на 4 позиции. 

Для этого написать метод, изменяющий значение символьного параметра (сдвинуть его 
циклически в алфавите на 4 позиции, влево или вправо по вашему усмотрению).
Метод должен возвращать значение false, если параметр задан неверно. При удачном 
преобразовании метод возвращает true. 

Заголовок метода: 
bool Shift(ref char ch)

Основная программа, используя метод, «общается» с пользователем.

*/

class Program
{
    public static bool Shift(ref char ch)
    {
        if (ch >= 'a' && ch <= 'z')
        {
            ch = (char)(((ch + 4) < 'z' ? (ch + 4) : (ch + 4) - ('z'-'a'+1)));
            return true;
        }
        return false;
    }
    static void Main(string[] args)
    {
        int a = 'a', z = 'z';
        char sym;
        do
        {
            do
            {
                Console.Write("Введите символ: ");
            } while (!char.TryParse(Console.ReadLine(), out sym)); // Преобразуем строку в число 

            if (Shift(ref sym))
            {
                Console.WriteLine(sym);
            } else
            {
                Console.WriteLine("Неверное значение");
            }
            Console.WriteLine("Для выхода из программы нажмите ESC.");
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
}

