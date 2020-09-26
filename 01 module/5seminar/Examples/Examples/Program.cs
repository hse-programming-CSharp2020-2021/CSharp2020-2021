using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int[] test_array_int = new int[n];
            Console.WriteLine("Case 1. Value types");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"test_array[i] = {test_array_int[i]}");
            }

            Console.WriteLine("\nCase 2. Value types");
            float[] test_array_float = new float[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"test_array[i] = {test_array_float[i]}");
            }

            Console.WriteLine("\nCase 3. Reference types");
            object[] test_array_object = new object[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"test_array[i] = {test_array_object[i]}");
            }
           
            Console.WriteLine("\nCase 4. Reference types");
            object[] test_array_object2 = new object[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"test_array[i] = {test_array_object2[i].ToString()}");
            }
            
            Console.ReadKey();
        }
    }
}
