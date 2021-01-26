using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figures;

namespace Task2
{
    
    class Program
    {
        static Random random = new Random();
        public static Point[] FigArray()
        {
            Point[] mas = new Point[random.Next(0, 21)];
            for (int i = 0; i < mas.Length; i++)
            {
                if (random.Next(0, 11) <= 5)
                    mas[i] = new Circle(random.Next(10, 100) + random.NextDouble(),
                       random.Next(10, 100) + random.NextDouble(), random.Next(10, 100) + random.NextDouble());
                else 
                    mas[i] = new Square(random.Next(10, 100) + random.NextDouble(),
                       random.Next(10, 100) + random.NextDouble(), random.Next(10, 100) + random.NextDouble());
            }
            return mas;
        }
        static void Main(string[] args)
        {
            Point[] p = FigArray();

            double averageAreaCircle = 0, averageLenCirce = 0, averageSquareCircle = 0, averageLenSquare = 0;
            int circle = 0, square = 0;

            foreach (Point element in p)
            {
                if (element is Circle)
                {
                    circle++;
                    averageLenCirce += ((Circle)element).Len;
                    averageAreaCircle += element.Area;
                } else
                {
                    square++;
                    averageSquareCircle += ((Square)element).Len;
                    averageLenSquare += element.Area;
                }
            }
            Console.WriteLine(circle);
            Console.WriteLine(averageLenCirce);
            Console.WriteLine(averageAreaCircle);
            Console.WriteLine(square);
            Console.WriteLine(averageSquareCircle);
            Console.WriteLine(averageLenSquare);

            Array.Sort(p, (p1, p2) => p1.Area.CompareTo(p2.Area));
            foreach (Point element in p)
            {
                Console.WriteLine(element.Area);
            }
            Console.ReadKey();
        }
    }
}
