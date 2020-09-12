using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example6
{
    class Program
    {
        static void Main(string[] args)
        {
            string myStr;
            Console.WriteLine("Введите строку: ");

            myStr = Console.ReadLine();

            if (myStr.Length < 5)
                Console.WriteLine("\nВ данной строке меньше 5 символов");
            else if ((myStr.Length >= 5) && (myStr.Length <= 12))
                Console.WriteLine("\nВ данной строке {0} символов", myStr.Length);
            else Console.WriteLine("\nВ данной строке больше 12 символов");

            Console.ReadLine();
        }
    }
}