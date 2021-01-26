using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    public class ConsolePlate
    {
        char _plateChar; // символ
        ConsoleColor _plateColor = ConsoleColor.White; // цвет символа

        public ConsolePlate()
        {
            _plateChar = '+';
        }

        public ConsolePlate(char ch, ConsoleColor color)
        {
            _plateChar = ch;
            _plateColor = color;
        }

        public char PlateChar
        {
            get
            {
                return _plateChar;
            }
            set
            {
                _plateChar = value > 31 ? value : '+';
            }
        }

        public ConsoleColor PlateColor
        {
            get
            {
                return _plateColor;
            }
            set
            {
                _plateColor = value;
            }
        }
    }
    
    class Program
    {
        public static Random Random = new Random();
        public static ConsoleColor[] ConsolePlates = new ConsoleColor[] {
            ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Green};

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            ConsolePlate[] arr = new ConsolePlate[n];

            int min = 0; int max = 100;

            for (int i = 0; i < arr.GetLength(0); i++)
                arr[i] = new ConsolePlate((char)Random.Next(min, max),
                    ConsolePlates[Random.Next(0, ConsolePlates.Length)]);

            foreach (ConsolePlate a in arr)
            {
                Console.BackgroundColor = a.PlateColor;
                Console.WriteLine(a.PlateChar);
            }

            Console.ReadKey();
        }
    }
}
