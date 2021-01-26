using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Circle : Point
    {
        double _rad;
        public double Rad
        {
            get
            {
                return _rad;
            }
            set
            {
                _rad = value;
            }
        }

        public Circle(double x, double y, double rad)
        {
            X = x;
            Y = y;
            Rad = rad;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Len = {Len} Area = {Area}");
        }

        public override double Area => Math.PI * Rad * Rad;

        public double Len
        {
            get
            {
                return 2 * Math.PI * Rad;
            }
        }
    }
}
