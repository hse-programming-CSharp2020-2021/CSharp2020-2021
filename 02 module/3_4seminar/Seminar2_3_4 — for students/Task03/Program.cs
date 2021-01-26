using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    public class Polygon
    {

        public uint N
        {
            get; set;
        }

        public double R
        {
            get; set;
        }


        public Polygon(uint number = 3, double radius = 10)
        {
            N = number;
            R = radius;
        }

        public double Perimetr
        {
            get
            {
                double a = 2 * R / Math.Tan(Math.PI / N);
                return a * N;
            }
        }

        public double Area
        {
            get
            {
                return Perimetr / 2 * R;
            }
        }

        public string PolygonData()
        {
            return $"N = {N}, R = {R}, P = {Perimetr}, S = {Area}";
        }
    }  

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Polygon[] polygon = new Polygon[n];
            double min = double.MaxValue;
            double max = 0;
            for (int i = 0; i < polygon.GetLength(0); i++)
            {
                Console.WriteLine($"Object {i}");
                polygon[i] = new Polygon(uint.Parse(Console.ReadLine()),
                                         double.Parse(Console.ReadLine()));
                Console.WriteLine(polygon[i].PolygonData());
                if (polygon[i].Area < min) min = polygon[i].Area;
                if (polygon[i].Area > max) max = polygon[i].Area;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(min);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(max);

            Console.ReadKey();
        }
    }
}
