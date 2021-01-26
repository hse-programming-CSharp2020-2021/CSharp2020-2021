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
        // конструкторы
        public ConsolePlate()
        {
            _plateChar = '+';
        }
        public ConsolePlate(char plateChar, ConsoleColor plateColor)
        {
            this.PlateChar = plateChar; // используем свойства 
            this.PlateColor = plateColor;
        }
        public char PlateChar
        {
            set
            {
                if (value > 31) // отбрасываем командные символы
                    _plateChar = value;
                else
                    _plateChar = '+';
            }
            get { return _plateChar; }
        }
        public ConsoleColor PlateColor
        {
            set { _plateColor = value; }
            get { return _plateColor; }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            ConsolePlate cp = new ConsolePlate();
            ConsolePlate[] somePlates =
                    {new ConsolePlate('*', ConsoleColor.Red), cp, new ConsolePlate((char)12, ConsoleColor.Green)};

            foreach (ConsolePlate conPl in somePlates)
            {
                Console.ForegroundColor = conPl.PlateColor;
                Console.Write(conPl.PlateChar);
            }
            Console.ReadKey();
        }
    }
}
