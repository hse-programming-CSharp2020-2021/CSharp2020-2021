using System;

namespace Task07
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a1 = new Point(10, 20, 30);
            Point a2 = new Point(20, 20, 20);
            Point a3 = new Point(-10, 20, 15);

            Console.WriteLine(a1.GetDistance(new Point(0, 0, 0)));
            Console.WriteLine(a2.GetDistance(new Point(0, 0, 0)));
            Console.WriteLine(a3.GetDistance(new Point(0, 0, 0)));

            Console.ReadKey();
        }
    }
}
