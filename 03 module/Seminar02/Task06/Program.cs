using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[5];
            double maxEl = 0;

            Converter<double, double> convertFuncDbl = p => {
                double res;
                do Console.Write("Введите число: ");
                while (!double.TryParse(Console.ReadLine(), out res));
                if (res > maxEl) maxEl = res;
                return res;
            };

            array = Array.ConvertAll(array, convertFuncDbl);
            Console.WriteLine("maxEl = {0}", maxEl);

            Converter<double, string> convertFuncStr =
                        s => (s /= maxEl).ToString("0.00") + "  ";

            string[] line = Array.ConvertAll(array, convertFuncStr);

            Array.ForEach(line, Console.Write);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
