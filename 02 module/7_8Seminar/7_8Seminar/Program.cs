using System;
//using Library1;

namespace _7_8Seminar
{
    class A
    {
        public virtual void getA()
        {
            Console.Write("A");
        }
    }
    class B : A
    {
        public override void getA()
        {
            Console.Write("B");
        }
    }

    public class Program
    {
        static Random random = new Random();
        public static void Main(string[] args)
        {
            A[] a = new A[10];
            for (int i = 0; i < a.Length; i++)
            {
                if (random.Next(0, 2) < 1)
                    a[i] = new A();
                else a[i] = new B();
            }

            foreach (A element in a)
            {
                element.getA();
            }
            Console.WriteLine();

            foreach (A element in a)
            {
                if (element is B)
                    element.getA();
            }
            Console.WriteLine();

            foreach (A element in a)
            {
                if (element is A)
                    element.getA();
            }

            Console.ReadKey();
        }
    }
}
