using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            double oldresult = 1, result = 0;
            
            for (int i = 1; oldresult - result != 0.0; i++) {
                oldresult = result;
                result += 1 / ((float)i*(i+1)*(i+2));
            }

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
