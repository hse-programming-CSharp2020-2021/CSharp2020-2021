using System;

// пример взят с сайта https://metanit.com/sharp/tutorial/3.1.php

namespace HelloApp
{
    class Person
    {
        public string Name
        {
            get; 
        }
        public int Age
        {
            get; set;
        }

        public static int Year
        {
            get; set;
        }

        public Person(string n, int a) : this(n)
        {
            Age = a;
        }

        public Person(string n) : this()
        {
            Name = n;
        }

        public Person()
        {
            Name = "NoName";
            Age = 18;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Имя: {Name}  Возраст: {Age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person tom3 = new Person("Tom3", 18); // конструктор
            Console.WriteLine(tom3.Name);
            Console.WriteLine(tom3.Age);
            Console.WriteLine(Person.Year);
            Person.Year++;
            Console.WriteLine("**************");
            tom3 = new Person("Tom3", 18); // конструктор
            Console.WriteLine(tom3.Name);
            Console.WriteLine(tom3.Age);
            Console.WriteLine(Person.Year);
            Person.Year++;
            tom3.Age++;
            Console.ReadKey();
        }
    }
}