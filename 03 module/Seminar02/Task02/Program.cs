using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public class Car
    {
        public delegate void CarEngineHandler(string msgForCaller);
        private CarEngineHandler listOfHandlers;
        public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            listOfHandlers = methodToCall;
        }

        public void Accelerate(int delta)
        {
            // Если машина сломана, отправляем оповещение.
            if (carIsDead)
            {
                if (listOfHandlers != null)
                    listOfHandlers("К сожалению, машина сломана :( ...");
            }
            else
            {
                CurrentSpeed += delta;
                // Машина почти сломана?
                if (10 == (MaxSpeed - CurrentSpeed)
                && listOfHandlers != null)
                {
                    listOfHandlers("Предупреждение! Будь осторожнее");

                }
                if (CurrentSpeed >= MaxSpeed)
                    carIsDead = true;
                else
                    Console.WriteLine("Скорость = {0}", CurrentSpeed);
            }
        }

        // Информация о внутреннем состоянии
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string PetName { get; set; }
        // Машина работоспособна?
        private bool carIsDead;
        // Конструкторы
        public Car() { MaxSpeed = 100; }
        public Car(string name, int maxSp, int currSp)
        {
            CurrentSpeed = currSp;
            MaxSpeed = maxSp;
            PetName = name;
        }
    }

    class Program
    {

        // Это метод-обработчик оповещений от машины.
        public static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("\n***** Сообщение от объекта типа Car *****");
            Console.WriteLine("=> {0}", msg);
            Console.WriteLine("***********************************\n");

        }

        static void Main(string[] args)
        {
            Console.WriteLine("***** Использование делегатов для управления событиями *****\n");

            Car c1 = new Car("SlugBug", 100, 10);

            // Передаём в машину метод, который будет вызван при отправке оповещения.
            c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));
            // Разгоняем машину
            Console.WriteLine("***** Увеличиваем скорость *****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);
            Console.ReadLine();
        }
    }
}
