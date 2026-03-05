namespace Dota2;

public class Print
{

    public static void PrintMenu()
    {
        Console.Clear();
        Console.WriteLine("------СОРТИРОВКА------");
        Console.WriteLine("1) Имя (Алфавитный порядок)\n"+
                          "2) Сложность\n"+
                          "3) Тип атрибут\n"+
                          "4) Тип атаки\n"+
                          "5) Здоровье (Возрастание)\n"+
                          "6) Здоровье (Убывание)\n"+
                          "7) Урон (Возрастание)\n"+
                          "8) Урон (Убывание)\n"+
                          "9) Броня (Возрастание)\n"+
                          "10) Броня (Убывание)\n"+
                          "11) Мана (Возрастание)\n"+
                          "12) Мана (Убывание)\n");
        Console.Write("Введите значение: ");
    }
    
    public static void SortedPrint(IOrderedEnumerable<Hero> sortedHeroes) 
    {
        Console.Clear();
        foreach (var hero in sortedHeroes)
        {
            Console.WriteLine(hero); 
            Thread.Sleep(5);
        }
    }

    public static void FilterPrint(IEnumerable<Hero> sortedHeroes)
    {
        Console.Clear();
        foreach (var hero in sortedHeroes)
        {
            Console.WriteLine(hero); 
            Thread.Sleep(5);
        }
    }
}