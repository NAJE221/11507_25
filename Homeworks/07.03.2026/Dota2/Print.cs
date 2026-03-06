namespace Dota2;

public class Print
{

    public static void PrintMenu()
    {
        Console.Clear();
        Console.WriteLine("------СОРТИРОВКА------");
        Console.WriteLine("1) Сложность\n"+
                          "2) Тип атрибут\n"+
                          "3) Тип атаки\n"+
                          "4) ХП (по возратсанию)");
        Console.Write("Введите значение: ");
    }

    public static void PrintComplexity()
    {
        Console.Clear();
        Console.WriteLine("------СЛОЖНОСТЬ------");
        Console.Write("Введите значение (1 - 3) : ");
    }

    public static void PrintTypeAttribute()
    {
        Console.Clear();
        Console.WriteLine("------АТРИБУТ------");
        Console.WriteLine("1) Сила\n"+
                          "2) Ловкость\n"+
                          "3) Интелект\n");
        Console.Write("Введите значение: ");
    }
    
    public static void PrintTypeAttack()
    {
        Console.Clear();
        Console.WriteLine("------СТИЛЬ БОЯ------");
        Console.WriteLine("1) Ближний бой\n" +
                          "2) Дальний бой\n");
        Console.Write("Введите значение: ");
    }

    public static void PrintList<T>(List<T> list)
    {
        Console.Clear();
        foreach (T itrm in list)
        {
            Console.WriteLine(itrm);
            Thread.Sleep(5);
        }
    }
    
}