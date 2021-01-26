using System;

namespace Task07
{
    class Point
    {
        int _x;
        int _y;
        int _z;

        public Point()
        {
            _x = 0; _y = 0; _z = 0;
        }

        public Point(int x, int y, int z)
        {
            _x = x; _y = y; _z = z;
        }

        public int X
        {
            get { return _x;  }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public int Z
        {
            get { return _z; }
            set { _z = value; }
        }

        public double GetDistance(Point point)
        {
            return Math.Sqrt(Math.Pow(point.X - X, 2) + Math.Pow(point.Y - Y, 2) + Math.Pow(point.Z - Z, 2));
        }

    }
}
