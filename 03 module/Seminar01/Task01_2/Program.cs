using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01_2
{
    class Program
    {
        public delegate int Cast(double p);
        static void Main(string[] args)
        {
            Cast obj1 = (par) =>
            {
                Console.WriteLine("DEL 1");
                return (int)Math.Ceiling(par);
            };
            obj1 += (double par) =>
            {
                Console.WriteLine("DEL 2");
                return (int)Math.Log10(par) + 1;
            };
            Console.WriteLine(obj1(15.68));
            Console.WriteLine(obj1(4.46));
            Console.ReadKey();
        }
    }
}
