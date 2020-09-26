using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples8
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new[] { 1, 10, 100, 1000 }; // int[]
            var b = new[] { "hello", null, "world" }; // string[]

            // single-dimension jagged array
            var c = new[]
            {
                new[]{1,2,3,4,5,6},
                new[]{5,6,7,8}
            };

            // jagged array of strings
            var d = new[]
            {
                new[]{"Luca", "Mads", "Luke", "Dinesh"},
                new[]{"Karen", "Suma", "Frances"}
            };
        }
    }
}
