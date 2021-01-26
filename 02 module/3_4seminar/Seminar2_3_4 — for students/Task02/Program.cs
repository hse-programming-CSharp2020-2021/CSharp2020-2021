using System;

class Program
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Ro
        {
            get
            {
                //#TODO1: реализовать свойство
            }
        }
        public double Fi
        {
            get
            {
                //#TODO2: реализовать свойство
            }
        }

        public Point(double x, double y) { X = x; Y = y; }
        public Point() : this(0, 0) { } // конструктор умолчания
                                        
        public string PointData
        {
            get
            {
                string maket = "X = {0:F2}; Y = {1:F2}; Ro = {2:F2}; Fi = {3:F2} ";
                return string.Format(maket, X, Y, Ro, Fi);
            }
        }
    }
    static void Main()
    {
        Point a, b, c;
        a = new Point(3, 4); Console.WriteLine(a.PointData);
        b = new Point(0, 3); Console.WriteLine(b.PointData); c = new Point();
        double x = 0, y = 0;
        do
        {
            Console.Write("x = ");
            double.TryParse(Console.ReadLine(), out x);
            Console.Write("y = ");
            double.TryParse(Console.ReadLine(), out y);
            c.X = x; c.Y = y;
            // #TODO3: следующий слайд
        } while (x != 0 | y != 0);
    }
}