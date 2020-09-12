using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите язык (C#, VB или C++)");
            string myLanguage = Console.ReadLine();

            sw1(myLanguage);

            Console.ReadLine();
        }
        static void sw1(string s)
        {
            switch (s)
            {
                case "C#":
                    Console.WriteLine("Вы выбрали язык C#");
                    break;
                case "VB":
                    Console.WriteLine("Вы выбрали язык Visual Basic");
                    break;
                case "C++":
                    Console.WriteLine("Вы выбрали язык С++");
                    break;
                default:
                    Console.WriteLine("Такой язык я не знаю");
                    break;
            }
        }
    }
}