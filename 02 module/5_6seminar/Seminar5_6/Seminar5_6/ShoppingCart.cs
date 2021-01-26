using System;

namespace Seminar5_6
{
    /// <summary>
    /// Представляет корзину покупок
    /// </summary>
    public class ShoppingCart
    {
        /// <summary>
        /// Количество предметов в корзине
        /// </summary>
        private int _itemCount;
        /// <summary>
        /// Цена всех предметов в корзине
        /// </summary>
        private double _totalPrice;
        /// <summary>
        /// Текущая вместимость корзины
        /// </summary>
        private int _capacity;
        /// <summary>
        /// Массив покупок
        /// </summary>
        Item[] _cart;

        /// <summary>
        /// Создаёт новый экземпляр корзины с вместимостью в 5 элементов
        /// </summary>
        public ShoppingCart()
        {
            _capacity = 5;
            _itemCount = 0;
            _totalPrice = 0.0;
            _cart = new Item[_capacity];
        }

        /// <summary>
        /// Свойства для вывода общей стоимости покупок
        /// </summary>
        public double TotalPrice
        {
            get
            {
                return _totalPrice;
            }
        }

        /// <summary>
        /// Добавляет предмет в корзину
        /// </summary>
        /// <param name="itemName">Название предмета</param>
        /// <param name="price">Цена предмета</param>
        /// <param name="quantity">Количество предметов</param>
        public void AddToCart(string itemName, double price, int quantity)
        {
            if (_itemCount >= _cart.Length)
                IncreaseSize();

            _cart[_itemCount++] = new Item(itemName, price, quantity);
            _totalPrice += price * quantity;
        }

        /// <summary>
        /// Увеличивает вместимость корзины на 3
        /// </summary>
        private void IncreaseSize()
        {
            Array.Resize<Item>(ref _cart, _cart.Length + 3);
        }

        /// <summary>
        /// Возвращает предметы в корзине с дополнительной информацией
        /// </summary>
        public override string ToString()
        {
            string contents = "\nShopping Cart\n";

            contents += "\nItem\t\tUnit Price\tQuantity\tTotal\n";

            for (int i = 0; i < _itemCount; i++)
                contents += _cart[i] + "\n";

            contents += $"\nTotal Price: {_totalPrice}\n";

            return contents;
        }
    }
}
