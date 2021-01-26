using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines("..\\..\\magicData.txt");    // читаем все строки файла в массив
            int lineIndex = 0;  // на какой строке файла находимся
            int count = 0; // считаем, на каком мы сейчас квадрате
            while (lines.Length > lineIndex)
            {
                int size;   // размер квадрата
                if (!int.TryParse(lines[lineIndex], out size))
                {
                    Console.WriteLine($"Ошибка при чтении размера квадрата: {lines[lineIndex]} - не число (строка {lineIndex + 1})");
                    return;
                }
                if (size == -1)    // в конце файла ожидается -1
                    break;
                lineIndex++;
                Square a = new Square(size);
                a.ReadSquare(lines, lineIndex);
                lineIndex += size;

                Console.WriteLine($"\n******** Квадрат номер {++count} ********");
                a.PrintSquare();
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine(a.SumRow(i));
                }
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine(a.SumCol(i));
                }
                Console.WriteLine(a.SumMainDiag());
                Console.WriteLine(a.SumOtherDiag());
                Console.WriteLine(a.Magic());
            }
            Console.ReadKey();
        }
    }
}
