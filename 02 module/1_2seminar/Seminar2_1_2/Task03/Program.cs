using System;

// Определить массив из трех элементов – ссылок на массивы разной длины.
//    1-й элемент - массив из 3-х элементов – ссылок на массивы, 
// соответственно, из 2-х, 3-х и 4-х элементов типа char. 
//    2-й элемент - массив из 2-х элементов ссылок на массивы, 
// соответственно, из 2-х и 3-х элементов типа char. 
//    3-й элемент - массив из ОДНОГО элемента – ссылки на массив из 4-х 
// элементов типа char. 
// Используя свойства и методы класса Array вывести ранг массива,
// общее число его элементов, число элементов по разным 
// измерениям, предельные значения всех индексов. 
// Вывести элементы массива с помощью циклов foreach,  размещая 
// значения элементов каждого массива нижнего уровня по строкам...


namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {

            char[][][] c =
            {
                new char[][] {
                    new char[] { 'a', 'b'},
                    new char[] { 'c', 'd', 'e'},
                    new char[] { 'f', 'g', 'h'},
                },
                new char[][] {
                    new char[] { 'j', 'k'},
                    new char[] { 'l', 'm'},
                },
                new char[][] {
                    new char[] { 'n', 'o', 'p'},
                }

            };

            foreach (char[][] a in c)
            {
                foreach (char[] b in a)
                {
                    foreach (char s in b)
                    {
                        Console.Write(s + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            

            Console.WriteLine("ch.Rank = " + c.Rank);
            Console.WriteLine("ch[0].Rank = " + c[0].Rank);
            Console.WriteLine("ch[0][0].Rank = " + c[0][0].Rank);
            Console.WriteLine("ch.GetType() = " + c.GetType());
            Console.WriteLine("ch[1][1][2] = " + c[1][1][1]);
            Console.WriteLine("ch.Length = " + c.Length);
            Console.WriteLine("ch.GetLength(0) = " + c.GetLength(0));
            Console.WriteLine("ch[1].GetLength(0) = " + c[1].GetLength(0));
            
            Console.ReadKey();
        }
    }
}
