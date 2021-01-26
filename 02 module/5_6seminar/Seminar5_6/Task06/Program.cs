using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06
{
    class Program
    {
        public static Random random = new Random();

        public static string GenerateRandomName(int size)
        {
            string name = "";
            for (int i = 0; i < size; i++)
            {
                name += (char)(random.Next('a', 'z' + 1));
            }

            return name;
        }

        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                int n = random.Next(10, 21);
                int section = random.Next(5, 10);
                Library library = new Library(section);
                for (int i = 0; i < n; i++)
                {
                    library.AddBook(new Book(random.Next(1, 501), random.Next(0, section + 1)));
                }
                Console.WriteLine(library);

                Book[] less200 = library.CountBooksWithTheLessAmountOfPages(200);
                Console.WriteLine("**********");
                for (int i = 0; i < less200.Length; i++)
                {
                    Console.WriteLine(less200[i]);
                }

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
