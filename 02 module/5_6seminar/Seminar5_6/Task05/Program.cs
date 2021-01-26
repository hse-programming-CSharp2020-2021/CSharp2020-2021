using System;

namespace Task05
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
                int n = random.Next(5, 16);
                VideoFile[] arr = new VideoFile[n];
                VideoFile b = new VideoFile(GenerateRandomName(random.Next(2, 10)), random.Next(60, 361), 
                    random.Next(100, 1001));

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new VideoFile(GenerateRandomName(random.Next(2, 10)), random.Next(60, 361),
                    random.Next(100, 1001));
                }
                Console.WriteLine("*****************");
                int step = random.Next(3, 15);
                Console.WriteLine(b);
                Console.WriteLine("*****************");
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Size > b.Size)
                    {
                        Console.WriteLine(arr[i]);
                    }
                }

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
