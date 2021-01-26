using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figures;

namespace Figures
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        
        virtual public void Display()
        {
            Console.WriteLine($"X = {X}, Y = {Y}");
        }

        public virtual double Area
        {
            get
            {
                return 0;
            }
        }

    }
}
