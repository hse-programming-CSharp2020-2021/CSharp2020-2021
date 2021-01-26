using System;

namespace tASK08
{
    class Plant
    {
        double growth;
        double photosensitivity;
        double frostresistance;

        public double Photosensitivity
        {
            get
            {
                return photosensitivity;
            }
            set
            {
                if (value < 0 || value > 100) throw new
                        ArgumentException("Светочувствительность должна принимать значения от 0 до 100");
                photosensitivity = value;
            }
        }

        public double Frostresistance
        {
            get
            {
                return frostresistance;
            }
            set
            {
                if (value < 0 || value > 100) throw new
                        ArgumentException("Морозоустойчивость должна принимать значения от 0 до 100");
                frostresistance = value;
            }
        }

        public double Growth
        {
            get
            {
                return growth;
            }
            set
            {
                if (value < 0) throw new
                        ArgumentException("Рост не может быть отрицательным");
                growth = value;
            }
        }

        public override string ToString()
        {
            return $"Growth = {growth}; frostresistance = {frostresistance}, " +
                $"photosensitivity = {photosensitivity}";
        }

        public Plant(double g, double p, double f)
        {
            Frostresistance = f;
            Photosensitivity = p;
            Growth = g;
        }
    }
    class Program
    {
        public static Random random = new Random();
        static void Main(string[] args)
        {
            int n;
            do Console.Write("Введите число: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);

            Plant[] arr = new Plant[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = new Plant(random.Next(25, 101), random.Next(0, 101), random.Next(0,101));
            }

            Array.ForEach(arr, p => Console.WriteLine(p.ToString()));
            Console.WriteLine("************************************");

            Array.Sort(arr, delegate (Plant p1, Plant p2)
            {
                if (p1.Growth < p2.Growth) return 1;
                if (p1.Growth == p2.Growth) return 0;
                return -1;
            });
            
            Array.ForEach(arr, p => Console.WriteLine(p.ToString()));
            Console.WriteLine("************************************");

            Array.Sort(arr, (Plant p1, Plant p2) =>
            {
                if (p1.Frostresistance > p2.Frostresistance) return 1;
                if (p1.Frostresistance == p2.Frostresistance) return 0;
                return -1;
            });

            Array.ForEach(arr, p => Console.WriteLine(p.ToString()));
            Console.WriteLine("************************************");

            Array.Sort(arr, PlantComp);

            Array.ForEach(arr, p => Console.WriteLine(p.ToString()));
            Console.WriteLine("************************************");


            Array.ConvertAll(arr, p1 => {
                if (p1.Frostresistance % 2 == 0) p1.Frostresistance /= 3;
                else p1.Frostresistance /= 2;
                return p1;
            });

            Array.ForEach(arr, p => Console.WriteLine(p.ToString()));
            Console.WriteLine("************************************");

            Console.ReadKey();
        }

        public static int PlantComp(Plant p1, Plant p2)
        {
            if (p1.Photosensitivity % 2 < p2.Photosensitivity % 2) return 1;
            if (p1.Photosensitivity % 2 == p2.Photosensitivity % 2) return 0;
            return -1;
        }
    }
}
