using System;

/*
Класс Item, моделирует одну покупку. У покупок есть название, цена и количество. 
Класс ShoppingCart реализует корзину покупок в виде массива элементов.

Дополните класс, реализующий корзину покупок в виде массива элементов. 
Дополните ShoppingCart:
Объявите переменную ­_cart и инициализируйте её массивом размера ­capacity в конструкторе
Дополните метод IncreaseSize () кодом. Размер массива дожен увеливаться на 3 элемента.
Дополните метод AddToCart() кодом. Этот метод должен добавлять элемент в корзину и обновлять 
переменную _totalPrice.

Напишите программу, имитирующую покупки. Программа должна содержать цикл, который 
повторяется до тех пор, пока пользователь хочет что-нибудь купить. 
Каждую итерацию цикла считывайте название, цену и количество вещей, которые хочет приобрести 
пользователь и добавляйте их в корзину. После добавления элемента в корзину выводите 
содержимое корзины. После выхода из цикла напишите “Пожалуйста, заплатите …”, подставив 
вместо троеточия сумму покупок.
*/

namespace Seminar5_6
{
    class Program
    {
        /// <summary>
        /// Метод для считывания целого числа
        /// </summary>
        /// <param name="message">сообщение в консоль</param>
        /// <returns>считанное число</returns>
        static int ReadInt(string message)
        {
            bool isCorrect = false;
            int result;
            do
            {
                Console.Write(message);

                if (int.TryParse(Console.ReadLine(), out result) && result >= 0)
                    isCorrect = true;
                else
                    Console.WriteLine("Неправильный формат числа!");
            } while (!isCorrect);

            return result;
        }

        /// <summary>
        /// Метод для считывания вещественного числа
        /// </summary>
        /// <param name="message">сообщение в консоль</param>
        /// <returns>считанное число</returns>
        static double ReadDouble(string message)
        {
            bool isCorrect = false;
            double result;
            do
            {
                Console.Write(message);

                if (double.TryParse(Console.ReadLine(), out result) && result >= 0)
                    isCorrect = true;
                else
                    Console.WriteLine("Неправильный формат числа!");
            } while (!isCorrect);

            return result;
        }

        static void Main(string[] args)
        {
            string name;
            int number;
            double price;
            ShoppingCart cart = new ShoppingCart();

            do
            {
                do
                {
                    Console.WriteLine("Введите название предмета: ");
                    name = Console.ReadLine();
                    price = ReadDouble("Введите цену товара: ");
                    number = ReadInt("Введите количество товара: ");
                    cart.AddToCart(name, price, number);
                    Console.WriteLine(cart);
                    Console.WriteLine("Введите y, если хотите ввести еще что-то, " +
                        "n если хотите завершить программу");
                    if (Console.ReadLine().Equals("n")) break;
                } while(true);
                Console.WriteLine("Пожалуйста, заплатите {0}", cart.TotalPrice);
                Console.WriteLine("Для выхода нажмите клавишу ESC");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
