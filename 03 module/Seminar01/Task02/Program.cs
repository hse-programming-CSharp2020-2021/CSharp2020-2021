using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibTask02;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1.Row delRow; // Ссылка на делегат
            Print delPrint; // Ссылка на делегат

            delRow = new Class1.Row(Class1.GetDigits); // Экземпляр делегата
            delPrint = Class1.Display; // Экземпляр делегата

            int[] myAr = delRow(13579); // Вызов метода через делегат 
            delPrint(myAr); // Вызов метода через делегат 
            int[] newAr = { 11, 22, 33, 44, 55, 66 };
            delPrint(newAr); // Вызов метода через делегат
            Class1.Display(myAr); // Явное обращение к методу
            Console.WriteLine("delRow casts {0}.", delRow.Method);
            Console.WriteLine("delPrint casts {0}.", delPrint.Method);
            Console.WriteLine("delRow.Target: {0}.", delRow.Target);
            Console.WriteLine("delPrint.Target: {0}.", delPrint.Target);
            Console.ReadKey();
        }
    }
}
