using System;

// Определить массив массивов для представления треугольника Паскаля.
// 0-й элемент - массив из одного элемента со значением С(0,0)=1, 
// 1-й элемент - массив из 2-х элементов С(1,0)=С(1,1)=1.
// 2-й элемент - массив из 3-х элементов С(2,0)=С(2,2)=1, С(2,1)=2...
// n-й элемент - массив из n+1 элементов: С(n,0)=С(n,n)=1, 
//   С(n,k)=C(n-1,k-1)+C(n-1,k). 
// Вводя неотрицательные значение n, построить массив-массивов  
// со значениями биномиальных коэффициентов и вывести его на экран 
// с помощью циклов foreach, размещая значения элементов каждого
// массива нижнего уровня по на отдельной строке...


namespace Task05
{
    class Program
    {
        public static void FormPaskalMatrix(int[][] paskal)
        {
            for (int i = 0; i < paskal.Length; i++)
            {
                paskal[i] = new int[i + 1]; // объект - массив элементов типа int
                paskal[i][0] = paskal[i][i] = 1;
                for (int j = 1; j < i; j++)
                    paskal[i][j] = paskal[i - 1][j - 1] + paskal[i - 1][j];
            }
        }

        static void Main(string[] args)
        {
            int[][] paskal; // ссылка на массив ссылок на массив
            int n;
            do                  // цикл для повторения решения
            {
                do Console.Write("Введите n: ");
                while (!int.TryParse(Console.ReadLine(), out n) || n < 0);
                paskal = new int[n + 1][]; // объект - массив пустых ссылок

                FormPaskalMatrix(paskal);

                foreach (int[] ar in paskal)    // перебор ссылок типа int[] 
                {
                    foreach (int cnk in ar)     // перебор элементов типа int
                        Console.Write("{0,4}", cnk);
                    Console.WriteLine();
                }

                Console.WriteLine("Для выхода нажмите клавишу ESC");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            Console.WriteLine();
        }
    }
}
