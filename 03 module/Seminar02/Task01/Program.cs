using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib01;

namespace Task01
{
    class Program
    {
        public static string RemoveDigits(string str)
        {
            if (str == string.Empty)
                throw new ArgumentOutOfRangeException();

            while (str.IndexOfAny("0123456789".ToCharArray()) > -1)
                str = str.Remove(str.IndexOfAny("0123456789".ToCharArray()), 1);

            return str;
        }

        public static string RemoveSpaces(string str)
        {
            if (str == string.Empty)
                throw new ArgumentOutOfRangeException();

            while (str.IndexOfAny(" ".ToCharArray()) > -1)
                str = str.Remove(str.IndexOfAny(" ".ToCharArray()), 1);

            return str;
        }
        static void Main(string[] args)
        {
            string[] testStrings = {"ab10 15dcd e4", "1234",
                "de21e", "10 15 abc", "abc", "d"};

            ConvertRule crMethod1 = RemoveDigits;
            Converter testConverter = new Converter();

            foreach (string str in testStrings)
                Console.WriteLine(testConverter.Convert(str, crMethod1));

            Console.WriteLine("****************************************");

            ConvertRule crMethod2 = RemoveSpaces;

            foreach (string str in testStrings)
                Console.WriteLine(testConverter.Convert(str, crMethod2));
            
            Console.WriteLine("****************************************");

            ConvertRule crMethod3 = crMethod1 + crMethod2;

            foreach (string str in testStrings)
                Console.WriteLine(testConverter.Convert(str, crMethod3));

            Console.ReadKey();
        }
    }
}
