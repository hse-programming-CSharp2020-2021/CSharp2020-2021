using System;

namespace Task08
{
    class Triangle
    {
        Point _x1;
        Point _x2;
        Point _x3;

        public Triangle() { }

        public Triangle(int a1, int a2, int b1, int b2, int c1, int c2)
        {
            X1 = new Point(a1, a2);
            X2 = new Point(b1, b2);
            X3 = new Point(c1, c2);
        }

        public Triangle(Point point1, Point point2, Point point3)
        {
            X1 = new Point(point1);
            X2 = new Point(point2);
            X3 = new Point(point3);
        }

        public Point X1
        {
            get { return _x1; }
            set { _x1 = value; }
        }

        public Point X2
        {
            get { return _x2; }
            set { _x2 = value; }
        }

        public Point X3
        {
            get { return _x3; }
            set { _x3 = value; }
        }

        public double Perimetr
        {
            get
            {
                return _x1.GetDistance(_x2) + _x1.GetDistance(_x3) + _x2.GetDistance(_x3);
            }
        }

        public double Area
        {
            get
            {
                double a = _x1.GetDistance(_x2);
                double b = _x1.GetDistance(_x3);
                double c = _x2.GetDistance(_x3);
                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }

        public override string ToString()
        {
            string str = "";
            str += X1.ToString() + "\n";
            str += X2.ToString() + "\n";
            str += X3.ToString() + "\n";
            str += $"Area = {Area.ToString("f3")}\nPerimetr = {Perimetr.ToString("f3")}\n";
            return str;
        }
    }
}
