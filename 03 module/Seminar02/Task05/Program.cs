using System;

namespace Task05
{
    class Series
    {
        public delegate bool predicate(int a, int b);
        int[] ar;
        private static Random rand = new Random();

        public Series(int n, int xn, int xk)
        {
            ar = new int[n];
            for (int i = 0; i < ar.Length; i++)
                ar[i] = rand.Next(xn, xk);
        }

        public void Order(predicate pr)
        {
            int temp;
            for (int i = 0; i < ar.Length - 1; i++)
                for (int j = i + 1; j < ar.Length; j++)
                    if (pr(ar[i], ar[j]))
                    {
                        temp = ar[i];
                        ar[i] = ar[j]; ar[j] = temp;
                    }
        }


        public void Display()
        {
            for (int i = 0; i < ar.Length; i++)
                Console.Write("{0}\t", ar[i]);
        }
    }
    class Program
    {
        // по возрастанию значений
        static bool pred1(int x, int y) { return x > y; }
        // в начале поместить четные
        static bool pred2(int a, int b)
        {
            if (a % 2 != 0 && b % 2 == 0) return true;
            else return false;
        }
        static void Main()
        {
            Series row = new Series(8, 0, 21);
            row.Display();
            Console.WriteLine();
            row.Order(pred1);
            row.Display();
            Console.WriteLine();
            row.Order(pred2);
            row.Display();
            Console.WriteLine("\nДля выхода нажмите ENTER");
            Console.ReadLine();
        }

    }
}
