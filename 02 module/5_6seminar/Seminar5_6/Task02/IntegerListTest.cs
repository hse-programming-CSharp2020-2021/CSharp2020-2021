using System;

/// <summary>
/// Создаёт список и выполняет пользовательские операции, пока пользователь не захочет выйти
/// </summary>
public class IntegerListTest
{
    private static IntegerList _list = new IntegerList(10);
    
    /// <summary>
    /// Создаёт список и выполняет пользовательские операции,
    /// пока пользователь не захочет выйти
    /// </summary>
    public static void Main()
    {
        PrintMenu();

        int choice = int.Parse(Console.ReadLine());

        while (choice != 0)
        {
            Dispatch(choice);
            PrintMenu();

            choice = int.Parse(Console.ReadLine());
        }
    }
    
    /// <summary>
    /// Выполняет действия меню
    /// </summary>
    /// <param name="choice">Выбранный пункт меню</param>
    public static void Dispatch(int choice)
    {
        switch (choice)
        {
            case 0:
                Console.WriteLine("Пока!");
                break;
            case 1:
                Console.WriteLine("Какой размер будет у списка?");
                int size = int.Parse(Console.ReadLine());
                _list = new IntegerList(size);
                _list.Randomize();
                _list.Print();
                break;
            case 2:
                _list.Print();
                break;
            case 3:
                _list.AddElement(100);
                break;
            case 4:
                _list.RemoveFirst(100);
                break;
            case 5:
                _list.RemoveAll(100);
                break;
            default:
                Console.WriteLine("Извините, вы выбрали что-то не то");
                break;
        }
    }

    /// <summary>
    /// Выводит варианты пользователю
    /// </summary>
    public static void PrintMenu()
    {
        Console.WriteLine("\n Меню ");
        Console.WriteLine(" ====");
        Console.WriteLine("0: Выйти");
        Console.WriteLine("1: Создать новый список (** сделайте это с самого начала!! **)");
        Console.WriteLine("2: Напечатать список");
        Console.WriteLine("3: Добавить элемент");
        Console.WriteLine("4: Удалить элемент");
        Console.WriteLine("5: Удалить все элементы");
        Console.Write("\nВведите ваш выбор: ");
    }
}
