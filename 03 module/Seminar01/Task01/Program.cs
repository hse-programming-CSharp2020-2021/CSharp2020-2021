using System;

namespace Task01
{
    class Program
    {
        public delegate int Cast(double p);

        public static int ForMyDelegate(double value) 
        {
            return (int)value;
        }


        static void Main(string[] args)
        {
            /* examples
            Cast cast = ForMyDelegate;
            Console.WriteLine(cast(10.5));

            Cast cast2 = delegate (double p) {
                return (int)p;
            };
            Console.WriteLine(cast2(11.5));

            Cast cast3 = p => (int)p;
            Console.WriteLine(cast3(12.5));

            Console.ReadKey();*/

            Cast obj1 = delegate (double par)
            {
                return (int)Math.Round((par) / 2 * 2);
            };

            Cast obj2 = M;
            obj2 -= M;
            Console.WriteLine("cast1(test)={0}, cast2(test)= {1}",
                obj1(15.68), obj2?.Invoke(15.68));
            Console.WriteLine("cast1(4.46)={0}, cast2(4.46)= {1}",
                obj1(4.46), obj2(4.46));
            Console.ReadKey();
        }
        public static int M(double par)
        {
            return (int)Math.Log10(par) + 1;
        }
    }

}
