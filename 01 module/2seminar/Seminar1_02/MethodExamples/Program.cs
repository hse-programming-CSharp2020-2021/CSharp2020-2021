using System;

namespace MethodExamples
{
    class Program
    {
        public static int Sum(ref int k, int l)
        {
            k = 20;
            Console.WriteLine("method a" + k);
            int sum = k + l;
            Console.WriteLine("method sum" + sum);
            return sum;
        }
        static void Main(string[] args)
        {
            int a = 5;
            int b = 15;
            int c = Sum(ref a, b);
            Console.WriteLine("main a" + a);
            Console.WriteLine("main sum" + c);
            Console.ReadKey();
        }
    }
}
