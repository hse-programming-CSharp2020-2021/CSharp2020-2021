using System;

namespace LibTask02
{
    public delegate void Print(int[] arr);
    public class Class1
    {
        public delegate int[] Row(int num);
        static public int[] GetDigits(int num)
        {
            int arLen = (int)Math.Log10(num) + 1;
            int[] res = new int[arLen];
            for (int i = arLen - 1; i >= 0; i--)
            {
                res[i] = num % 10;
                num /= 10;
            }
            return res;
        }

        static public void Display(int[] ar)
        {
            for (int i = 0; i < ar.Length; i++)
                Console.Write("{0}\t", ar[i]);
            Console.WriteLine();
        }

    }
}
