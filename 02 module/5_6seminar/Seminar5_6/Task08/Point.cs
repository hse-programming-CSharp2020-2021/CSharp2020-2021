using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task08
{
    class Point
    {
        int _x;
        int _y;

        public Point()
        {
            X = 0; Y = 0;
        }

        public Point(int x, int y)
        {
            X = x; Y = y;
        }

        public Point(Point point)
        {
            X = point.X; Y = point.Y;
        }

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public double GetDistance(Point point)
        {
            return Math.Sqrt(Math.Pow(point.X - X, 2) + Math.Pow(point.Y - Y, 2));
        }

        public override string ToString()
        {
            return $"x = {X}, y = {Y}";
        }
    }
}
