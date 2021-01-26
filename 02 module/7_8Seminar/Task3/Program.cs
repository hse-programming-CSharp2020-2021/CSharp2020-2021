using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library3;

namespace Task3
{
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[10];
            for (int i = 0; i < employees.Length; i++)
            {
                if (random.Next(0, 11) < 5)
                    employees[i] = new SalesEmployee("name", random.Next(10, 1000), random.Next(10, 1000));
                else
                    employees[i] = new PartTimeEmployee("name", random.Next(10, 1000), random.Next(10, 40));
            }
            Array.Sort(employees, (e1, e2) => e2.CalculatePay().CompareTo(e1.CalculatePay()));

            foreach (Employee employee in employees)
            {
                if (employee is SalesEmployee)
                {
                    Console.WriteLine(employee.CalculatePay());
                }
            }
            Console.WriteLine("***");
            foreach (Employee employee in employees)
            {
                if (employee is PartTimeEmployee)
                {
                    Console.WriteLine(employee.CalculatePay());
                }
            }
            Console.ReadKey();
        }
    }
}
