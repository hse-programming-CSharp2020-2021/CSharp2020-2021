using System;

namespace Task07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = { 6, 5, 4, 4, 3, 2, 4, 1, 2, 3, 4, 2, 4 };
            Array.Sort(ar,  // сортировка по убыванию:
                        (int x, int y) =>
                        {
                            if (x < y) return 1;  // нарушен порядок 
                            if (x == y) return 0;
                            return -1;
                        }
                      );
            foreach (int memb in ar)
                Console.Write("{0} ", memb);
            Console.WriteLine();
            Array.Sort(ar,  // сортировка по четности:
                        (x, y) =>   // явный тип параметров не обязателен
            {
                if (x % 2 != 0 & y % 2 == 0) return 1;
                if (x == y) return 0;
                return -1;  // верный порядок 
            }
                      );
            foreach (int memb in ar)
                Console.Write("{0} ", memb);

            Console.ReadKey();
        }
    }
}
