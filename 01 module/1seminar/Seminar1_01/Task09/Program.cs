using System;

class Program
{
    static void Main()
    {
        double X, Y; 
        Console.Write("X: ");
        string InputStr = Console.ReadLine();
        double.TryParse(InputStr, out X);

        Console.Write("Y: ");
        InputStr = Console.ReadLine();
        double.TryParse(InputStr, out Y);

        double sum = X - (int)X + Y - (int)Y;

        Console.WriteLine(sum);

        Console.ReadKey();
    }
}
