using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task08
{
    class Program
    {
        public static Random random = new Random();
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                int n = random.Next(5, 15);
                Triangle[] arr = new Triangle[n];
                for (int i = 0; i < n; i++)
                {
                    arr[i] = new Triangle(random.Next(-10, 11), random.Next(-10, 11), 
                        random.Next(-10, 11), random.Next(-10, 11),
                        random.Next(-10, 11), random.Next(-10, 11));
                    Console.WriteLine(arr[i]);
                }
                
                Console.WriteLine("**********");
                Triangle temp;

                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (arr[i].Area < arr[j].Area)
                        {
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }

                for (int i = 0; i < n; i++)
                { 
                    Console.WriteLine($"Triangle {i}: \n{arr[i]}");
                }

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
