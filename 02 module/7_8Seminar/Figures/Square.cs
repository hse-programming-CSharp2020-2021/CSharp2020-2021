using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Square : Point
    {
        double _side;
        public double Side
        {
            get
            {
                return _side;
            }
            set
            {
                _side = value;
            }
        }
        public Square(double x, double y, double side)
        {
            X = x;
            Y = y;
            Side = side;
        }
        public override double Area => _side * _side;

        public double Len => 4 * _side;

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Len = {Len} Area = {Area}");
        }
    }
}
