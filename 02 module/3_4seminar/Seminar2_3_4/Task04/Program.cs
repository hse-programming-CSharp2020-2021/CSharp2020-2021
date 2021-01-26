using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    public class HexNumber
    {   // представление неотрицательных целых
        uint number;            // целое неотрицательное число 
        char[] hexView;     // Шестнадцатеричное представление
        public HexNumber(uint n)
        { // конструктор общего вида
            number = n;
            hexView = series(n);
        }
        public HexNumber() : this(0) { }    // конструктор умолчания

        public uint Number
        {   // Свойство: десятичное целое
            get { return number; }
            set
            {
                number = value;
                hexView = series(value);
            }
        }
        public char[] HexView
        {   // Свойство: массив символов-цифр
            get { return hexView; }
        }
        public string Record
        {   // Свойство: строковое представление (шестнадцатеричное) числа
            get
            {
                string str = new String(hexView);
                return "0x" + str;
            }
        }
        char[] series(uint num)
        {
            int arLen = num == 0 ? 1 : (int)Math.Log(num, 16) + 1;
            char[] res = new char[arLen];
            for (int i = arLen - 1; i >= 0; i--)
            {
                uint temp = (uint)(num % 16);
                if (temp >= 0 & temp <= 9) res[i] = (char)('0' + temp);
                else res[i] = (char)('A' + temp % 10);
                num /= 16;
            }
            return res;
        }   // series


    }

    class Program
    {
        static void Main(string[] args)
        {
            HexNumber hex;      // ссылка с типом класса
            hex = new HexNumber(0); // объект класса
            uint number;
            while (true)
            { // цикл для ввода разных значений числа 
                do Console.Write("Введите целое неотрицательное число:  ");
                while (!uint.TryParse(Console.ReadLine(), out number));

                hex.Number = number;     // Изменяем объект через свойство
                Console.WriteLine("Свойство Number: " + hex.Number);
                Console.Write("Шестнадцатеричные цифры числа: ");

                foreach (char h in hex.HexView) Console.Write("{0} ", h);

                Console.WriteLine("\nШестнадцатеричная запись: " + hex.Record);
                Console.WriteLine("Для выхода нажмите клавишу ESC");

                if (Console.ReadKey(true).Key == ConsoleKey.Escape) break;
            }    // while

        }
    }
}
