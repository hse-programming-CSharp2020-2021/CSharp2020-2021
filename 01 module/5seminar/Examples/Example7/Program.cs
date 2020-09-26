using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example7
{
    class Program
    {
        static void DisplayArray(string[] arr) => Console.WriteLine(string.Join(" ", arr));

        static void ChangeArray(string[] arr) { Array.Reverse(arr); }
        static void ChangeArrayElements(string[] arr)
        {
            arr[0] = "Mon";
            arr[1] = "Wed";
            arr[2] = "Fri";
        }

        static void Main()
        {
            string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            DisplayArray(weekDays);
            Console.WriteLine();
            
            ChangeArray(weekDays);
            Console.WriteLine("Array weekDays after the call to ChangeArray:");
            DisplayArray(weekDays);
            Console.WriteLine();
            
            ChangeArrayElements(weekDays);
            Console.WriteLine("Array weekDays after the call to ChangeArrayElements:");
            DisplayArray(weekDays);

            Console.ReadKey();
        }
    }
}
