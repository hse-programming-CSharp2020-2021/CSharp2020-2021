using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example5
{
    class Program
    {
        static void MethodRef(ref int i)
        {
            i = i + 44;
        }

        static void MethodOut(out int i)
        {
            i = 44;
        }

        static void Main()
        {
            int valref = 1;
            MethodRef(ref valref);
            Console.WriteLine(valref);
            int valout;
            MethodOut(out valout);
            Console.WriteLine(valout);

        }
    }
}
