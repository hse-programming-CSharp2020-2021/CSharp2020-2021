using System;

class Birthday
{
    string name; // закрытое поле - фамилия
    DateTime _Date;
    public Birthday()
    { // Конструктор
        _Date = new DateTime(1970, 1, 1);
    }
    public Birthday(string name, int y, int m, int d)
    { // Конструктор
        this.name = name;
        _Date = new DateTime(y, m, d);
    }
    DateTime Date
    { // закрытое свойство - дата рождения
        get { return _Date; }
    }
    public string Information
    {   // свойство - сведения о человеке
        get
        {
            return name + _Date.ToString("F");
        }
    }

    public string DateInfoDDMonthYYYY
    {   // свойство - сведения о человеке
        get
        {
            return _Date.ToString("F");
        }
    }

    public string DateInfoDDMMYYYY
    {   // свойство - сведения о человеке
        get
        {
            return _Date.ToString("dd.MM.yyyy");
        }
    }


    public int HowManyDays
    { // свойство - сколько дней до дня рождения
        get
        {
            // номер сего дня от начала года:
            int nowDOY = DateTime.Now.DayOfYear;
            //  номер дня рождения от начала года: 
            int myDOY = Date.DayOfYear;
            int period = myDOY >= nowDOY ? myDOY - nowDOY :
                                           365 - nowDOY + myDOY;
            return period;
        }

    }


    class Program
    {
        static void Main()
        {
            Birthday md = new Birthday("Чапаев", 1887, 2, 9);
            Console.WriteLine(md.Information);
            Console.WriteLine("До следующего дня рождения дней осталось: ");
            Console.WriteLine(md.HowManyDays);

            Birthday km = new Birthday("Маркс Карл", 1818, 5, 4);
            Console.WriteLine(km.Information);
            Console.WriteLine("До следующего дня рождения дней осталось: ");
            Console.WriteLine(km.HowManyDays);
            Console.ReadKey();
        }
    }
}
