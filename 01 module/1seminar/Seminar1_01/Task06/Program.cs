using System;
class Program
{
    static void Main()
    {
        string top = "|*Выражение*|*Формат*|**** Изображение ****|";
        Console.WriteLine(top);
        string line = "|-----------|--------|---------------------|";
        Console.WriteLine(line);
        string str = "| (5.0/3.0) |  F     | " + (5.0 / 3.0).ToString("F");
        Console.WriteLine(str);
        str = "| (5.0/3.0) |  F4    | " + (5.0 / 3.0).ToString("F4");
        Console.WriteLine(str);
        str = "| (5.0/3.0) |  E     | " + (5.0 / 3.0).ToString("E");
        Console.WriteLine(str);
        str = "| (5.0/3.0) |  E5    | " + (5.0 / 3.0).ToString("E5");
        Console.WriteLine(str);
        str = "| (5.0/3.0) |  G     | " + (5.0 / 3.0).ToString("G");
        Console.WriteLine(str);
        str = "| (5.0/3.0) |  G3    | " + (5.0 / 3.0).ToString("G3");
        Console.WriteLine(str);
        str = "| (5.0/3e10)|  G3    | " + (5.0 / 3e10).ToString("G3");
        Console.WriteLine(str);
        str = "| (5.0/3e-10)|  G     | " + (5.0 / 3e-10).ToString("G");
        Console.WriteLine(str);
        str = "| (5.0/3e20)|  G     | " + (5.0 / 3e10).ToString("G");
        Console.WriteLine(str);
        line = "*-----------*--------*---------------------*";
        Console.WriteLine(line);
        Console.ReadKey();
    }
}
