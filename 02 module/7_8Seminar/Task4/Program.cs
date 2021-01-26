using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library4;

namespace Task4
{
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            int N1 = random.Next(3, 5);
            int N2 = random.Next(3, 5);
            int N3 = random.Next(3, 5);
            Shape[] sh = new Shape[N1 + N2 + N3];

            for (int i = 0; i < N1; i++)
            {
                sh[i] = new Circle(random.Next(1, 10));
            }
            for (int i = N1; i < N1 + N2; i++)
            {
                sh[i] = new Sphere(random.Next(1, 10));
            }
            for (int i = N1+N2; i < N1 + N2 + N3; i++)
            {
                sh[i] = new Cylinder(random.Next(1, 10), random.Next(1, 10));
            }

            foreach (Shape shape in sh)
            {
                if (shape is Circle) Console.Write("Circle: ");
                if (shape is Sphere) Console.Write("Sphere: ");
                if (shape is Cylinder) Console.Write("Cylinder: ");
                Console.WriteLine(shape.Area());
            }

            Console.ReadKey();
        }
    }
}
