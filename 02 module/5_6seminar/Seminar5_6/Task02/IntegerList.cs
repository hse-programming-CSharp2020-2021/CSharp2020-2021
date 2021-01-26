using System;

/// <summary>
/// Определяет список целых чисел с возможностью его создания и заполнения
/// </summary>
public class IntegerList
{
    /// <summary>
    /// Объект для генерации случайных чисел
    /// </summary>
    private static readonly Random Random = new Random();
    /// <summary>
    /// Поле для отслеживания количества записанных в массив элементов
    /// </summary>
    int _size;
    /// <summary>
    /// Список (массив) значений
    /// </summary>
    private int[] _list;

    /// <summary>
    /// Создаёт список указанного размера
    /// </summary>
    /// <param name="size">Расмер списка</param>
    public IntegerList(int size)
    {
        _list = new int[size];
        _size = 0;
    }

    /// <summary>
    /// Метод для увеличения размера листа
    /// </summary>
    public void IncreaseSize()
    {
        Array.Resize<int>(ref _list, _size * 2);
    }

    /// <summary>
    /// Данный метод добавляет новый элемент в список
    /// </summary>
    /// <param name="newVal">Новый элемент для добавления</param>
    public void AddElement(int newVal)
    {
        if (_size + 1 >= _list.Length) this.IncreaseSize();
        _list[_size++] = newVal;
    }

    /// <summary>
    /// Данный метод удаляет первое вхождение элемента из списка.
    /// </summary>
    /// <param name="val">Элемент для удаления</param>
    public void RemoveFirst(int val)
    {
        for (int i = 0; i < _list.Length; i++)
        {
            if (_list[i] == val)
            {
                for(int j = i; j < _list.Length - 1; j++)
                {
                    _list[j] = _list[j + 1];
                }
                _list[_list.Length - 1] = 0;
                _size--;
                break;
            }
        }
    }

    /// <summary>
    /// Данный метод удаляет все вхождения элемента из списка.
    /// </summary>
    /// <param name="val">Элемент для удаления</param>
    public void RemoveAll(int val)
    {
        for (int i = 0; i < _list.Length; i++)
        {
            if (_list[i] == val)
            {
                for (int j = i; j < _list.Length - 1; j++)
                {
                    _list[j] = _list[j + 1];
                }
                _list[_size] = 0;
                _size--;
                i--;
            }
        }
    }
    /// <summary>
    /// Заполняет список числами между 1 и 100 включительно
    /// </summary>
    public void Randomize()
    {
        for (int i = 0; i < _list.Length; i++)
            _list[i] = Random.Next(101);
        _size = _list.Length;
    }

    /// <summary>
    /// Печатает элементы списка с их индексами
    /// </summary>
    public void Print()
    {
        for (int i = 0; i < _list.Length; i++)
            Console.WriteLine(i + ":\t" + _list[i]);
    }
}
