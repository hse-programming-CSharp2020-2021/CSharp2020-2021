using System;

namespace Task04
{
    class Program
    {
        public static Random random = new Random();
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                int n = random.Next(5, 16);
                ArithmeticSequence[] arr = new ArithmeticSequence[n];
                ArithmeticSequence b = new ArithmeticSequence(random.Next(0, 1000) + random.NextDouble(),
                        random.Next(1, 10) + random.NextDouble());

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new ArithmeticSequence(random.Next(0, 1000) + random.NextDouble(),
                        random.Next(1, 10) + random.NextDouble());
                }
                Console.WriteLine("*****************");
                int step = random.Next(3, 15);
                Console.WriteLine(b);
                Console.WriteLine("\t" + b.GetSum(step).ToString("f3"));
                Console.WriteLine("*****************");
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i][step] > b[step])
                    {
                        Console.WriteLine(arr[i]);
                        Console.WriteLine("\t" + arr[i][step].ToString("f3"));
                        Console.WriteLine("\t" + b[step].ToString("f3"));
                    }
                }

                Console.WriteLine("*****************");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                    Console.WriteLine("\t" + arr[i].GetSum(step).ToString("f3"));
                }

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
