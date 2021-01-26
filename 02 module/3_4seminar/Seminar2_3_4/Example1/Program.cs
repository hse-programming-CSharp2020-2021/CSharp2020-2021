using System;

// пример взят с сайта https://metanit.com/sharp/tutorial/3.1.php

namespace HelloApp
{
    class Person
    {
        public string name;
        public int age;

        public Person() { name = "Неизвестно"; age = 18; }      // 1 конструктор

        public Person(string n) { name = n; age = 18; }         // 2 конструктор

        public Person(string n, int a) { name = n; age = a; }   // 3 конструктор

        public void GetInfo()
        {
            Console.WriteLine($"Имя: {name}  Возраст: {age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person();          // вызов 1-ого конструктора без параметров
            Person bob = new Person("Bob");     //вызов 2-ого конструктора с одним параметром
            Person sam = new Person("Sam", 25); // вызов 3-его конструктора с двумя параметрами


            bob.GetInfo();          // Имя: Bob  Возраст: 18
            tom.GetInfo();          // Имя: Неизвестно  Возраст: 18
            sam.GetInfo();          // Имя: Sam  Возраст: 25

            Console.ReadKey();
        }
    }
}