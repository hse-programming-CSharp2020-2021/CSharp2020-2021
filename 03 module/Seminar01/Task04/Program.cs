using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    delegate void Steps(); // делегат-тип
    class Robot
    {
        // класс для представления робота
        int x, y; // положение робота на плоскости 

        public void Right() { x++; }      // направо
        public void Left() { x--; }      // налево
        public void Forward() { y++; }  // вперед
        public void Backward() { y--; }  // назад

        public string Position()
        {  // сообщить координаты
            return String.Format("The Robot position: x={0}, y={1}", x, y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Robot rob = new Robot();    // конкретный робот 
            Steps delR = new Steps(rob.Right);      // направо
            Steps delL = new Steps(rob.Left);       // налево
            Steps delF = new Steps(rob.Forward);    // вперед
            Steps delB = new Steps(rob.Backward);   // назад
                                                    // шаги по диагоналям (многоадресные делегаты):
            Steps delRF = delR + delF;
            Steps delRB = delR + delB;
            Steps delLF = delL + delF;
            Steps delLB = delL + delB;
            delLB();
            Console.WriteLine(rob.Position());     // сообщить координаты
            delRB();
            Console.WriteLine(rob.Position());     // сообщить координаты
            Console.WriteLine("Для завершения нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
