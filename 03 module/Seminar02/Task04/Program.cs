using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib03;

namespace Task04
{
    class Program
    {
        static void Main()
        {
            double xMin;
            xMin = NumMeth.Optimum_1(x => Math.Cos(x), 3, 6, 0.001, 0.001);
            Console.WriteLine("Минимум для cos(x):");
            Console.WriteLine("xMin={0:F5};\tfMin= {1:f5}", xMin, Math.Cos(xMin));


            Console.WriteLine("Минимум для x*(x*x-2)-5:");
            xMin = NumMeth.Optimum_1(x => x * (x * x - 2) - 5, 0, 1, 1e-5, 1e-5);
            Console.WriteLine("xMin={0:F5};\tfMin= {1:f5}",
                                                xMin, xMin * (xMin * xMin - 2) - 5);


            Console.WriteLine("Минимум для -Sin(x)-Sin(3*x)/3:");
            xMin = NumMeth.Optimum_1
                (x => -Math.Sin(x) - Math.Sin(3 * x) / 3.0, 0, 1, 1e-8, 1e-14);
            Console.WriteLine("xMin={0:F5};\tfMin= {1:f5}", xMin,
                                       -Math.Sin(xMin) - Math.Sin(3 * xMin) / 3.0);
            
            Console.ReadLine();
        }

    }
}
