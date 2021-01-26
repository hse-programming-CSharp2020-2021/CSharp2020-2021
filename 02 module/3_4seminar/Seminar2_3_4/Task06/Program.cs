using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06
{
    class myClassmate
    { // Одноклассник
        readonly string name = "Неизвестный"; // Фамилия
        readonly int birthYear = 1998; // год рождения
        const int apprenticeship = 4; // срок обучения (лет)
        static int entranceYear = 2016; // год поступления
        static myClassmate()
        {
            entranceYear = 2015;
        }
        public myClassmate() { } // Конструктор умолчания
        public myClassmate(string name, int by)
        {//Конструктор общего вида
            this.name = name;
            birthYear = by;
        }
        public string Information()
        { // Метод объекта 
            return "Фамилия: " + name + "; возраст: " +
                (entranceYear - birthYear) +
                " лет; год окончания: " +
                (entranceYear + apprenticeship);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            myClassmate Nan = new myClassmate();
            Console.WriteLine(Nan.Information());
            myClassmate Bob = new myClassmate("Смирнов", 1997);
            Console.WriteLine(Bob.Information());
            Console.ReadKey();
        }
    }
}
