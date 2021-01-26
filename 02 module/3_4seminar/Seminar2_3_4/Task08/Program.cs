using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task08
{
    class Schedule
    {// Начало занятий в разные дни недели
        public string this[string day]
        {
            get
            {
                switch (day)
                {
                    case "понедельник": return days[0] == null 
                            ? "Нет занятий" : days[0];
                    case "вторник": return days[1] == null 
                            ? "Нет занятий" : days[1];
                    case "среда": return days[2] == null 
                            ? "Нет занятий" : days[2];
                    case "четверг": return days[3] == null 
                            ? "Нет занятий" : days[3];
                    case "пятница": return days[4] == null 
                            ? "Нет занятий" : days[4];
                    case "суббота": return days[5] == null 
                            ? "Нет занятий" : days[5];
                    case "воскресенье": return days[6] == null 
                            ? "Нет занятий" : days[6];
                    default: return "Ошибка в обращении!";
                }
            }
        }

        string[] days = new string[7]; // все null по умолчанию

        public Schedule(params string[] d)
        {
            for (int i = 0; i < d.Length; i++)
                days[i] = d[i];
        }
    } // Schedule


    class Program
    {
        static void Main()
        {
            Schedule Module_2 = new Schedule("9_00", "10_30", null, "15_00", "13_40");

            Console.WriteLine("Начало занятий в модуле 2:");
            Console.WriteLine("понедельник: \t" + Module_2["понедельник"]);
            Console.WriteLine("вторник: \t" + Module_2["вторник"]);
            Console.WriteLine("среда:    \t" + Module_2["среда"]);
            Console.WriteLine("четверг: \t" + Module_2["четверг"]);
            Console.WriteLine("пятница: \t" + Module_2["пятница"]);
            Console.WriteLine("суббота: \t" + Module_2["суббота"]);
            Console.WriteLine("воскресенье: \t" + Module_2["воскресенье"]);
            Console.ReadKey();
        }
    }
}

