using System;

namespace Task
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            // описываем переменную максимально близко
            // к месту первого использовани в коде
            string inputStr = Console.ReadLine();
            Console.WriteLine("Ваш текст: " + inputStr);
            Console.WriteLine("Ваш текст: {0}", inputStr);
            Console.WriteLine($"Ваш текст: {inputStr}");
        }
    }
}
