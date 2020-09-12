using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example4
{
    class Program
    {
        static void SwapByRef(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        static void Main()
        {
            int i = 2, j = 3;
            System.Console.WriteLine("i = {0}  j = {1}", i, j);

            SwapByRef(ref i, ref j);

            System.Console.WriteLine("i = {0}  j = {1}", i, j);

            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
