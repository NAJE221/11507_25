using System;
using System.Linq;
namespace Dota2;
public class Process
{
    private static string path = @"C:\Users\Artem\Desktop\Dota2\Dota2\Dota2.txt";
    public static void Launch()
    {
        var input = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("------СОРТИРОВКА------");
            Console.WriteLine("1) Имя\n"+
                              "2) Сложность (Возрастание)\n"+
                              "3) Сложность (Убывание)\n"+
                              "4) Тип атрибут\n"+
                              "5) Тип атаки\n"+
                              "6) Здоровье (Возрастание)\n"+
                              "7) Здоровье (Убывание)\n"+
                              "8) Урон (Возрастание)\n"+
                              "9) Урон (Убывание)\n"+
                              "10) Броня (Возрастание)\n"+
                              "11) Броня (Убывание)\n"+
                              "12) Мана (Возрастание)\n"+
                              "13) Мана (Убывание)\n");
            Console.Write("Введите значение: ");
        }
        while(!int.TryParse(Console.ReadLine() , out input) || input < 1 || input > 12);
        CheckingTheInput(input);
    }

    public static void CheckingTheInput(int input)
    {
        switch (input)
        {
            case 1:
                Sorted.SortedName();
                break;
            case 2:
                Sorted.SortedComplexityIncreasing();
                break;
            case 3: 
                Sorted.SortedComplexityDescending();
                break;
            case 4:
                Sorted.SortedTypeAttribute();
                break;
            case 5:
                Sorted.SortedTypeAttack();
                break;
            case 6:
                Sorted.SortedHealthIncreasing();
                break;
            case 7:
                Sorted.SortedHealthDescending();
                break;
            case 8:
                Sorted.SortedDamageIncreasing();
                break;
            case 9:
                Sorted.SortedDamageDescending();
                break;
            case 10:
                Sorted.SortedArmorIncreasing();
                break;
            case 11:
                Sorted.SortedArmorDescending();
                break;
            case 12:
                Sorted.SortedManaIncreasing();
                break;
            case 13:
                Sorted.SortedManaDescending();
                break;
        }
    }
    
    public static IEnumerable<Hero> SpawnHero()
    {
        foreach (string line in File.ReadLines(path))
        {
            if (!string.IsNullOrWhiteSpace(line))
            {
                yield return Craft.CraftHero(line);
            }
        }
    }
}

public class Sorted
{
    public static void SortedName()
    {
        var sortedHeroes = Process.SpawnHero().OrderBy(h => h.Name);
        SortedPrint(sortedHeroes);
    }

    public static void SortedComplexityIncreasing()
    {
        var sortedHeroes = Process.SpawnHero().OrderBy(h => h.Complexity);
        SortedPrint(sortedHeroes);
    }
    public static void SortedComplexityDescending()
    {
        var sortedHeroes = Process.SpawnHero().OrderByDescending(h => h.Complexity);
        SortedPrint(sortedHeroes);
    }
    
    public static void SortedTypeAttribute()
    {
        var sortedHeroes = Process.SpawnHero().OrderBy(h => h.TypeAttribute);
        SortedPrint(sortedHeroes);
    }
    
    public static void SortedTypeAttack()
    {
        var sortedHeroes = Process.SpawnHero().OrderBy(h => h.TypeAttack);
        SortedPrint(sortedHeroes);
    }
    
    public static void SortedHealthIncreasing()
    {
        var sortedHeroes = Process.SpawnHero().OrderBy(h => h.Health);
        SortedPrint(sortedHeroes);
    }
    public static void SortedHealthDescending()
    {
        var sortedHeroes = Process.SpawnHero().OrderByDescending(h => h.Health);
        SortedPrint(sortedHeroes);
    }
    
    public static void SortedDamageIncreasing()
    {
        var sortedHeroes = Process.SpawnHero().OrderBy(h => h.Health);
        SortedPrint(sortedHeroes);
    }
    public static void SortedDamageDescending()
    {
        var sortedHeroes = Process.SpawnHero().OrderByDescending(h => h.Health);
        SortedPrint(sortedHeroes);
    }
    
    public static void SortedArmorIncreasing()
    {
        var sortedHeroes = Process.SpawnHero().OrderBy(h => h.Health);
        SortedPrint(sortedHeroes);
    }
    public static void SortedArmorDescending()
    {
        var sortedHeroes = Process.SpawnHero().OrderByDescending(h => h.Health);
        SortedPrint(sortedHeroes);
    }
    
    public static void SortedManaIncreasing()
    {
        var sortedHeroes = Process.SpawnHero().OrderBy(h => h.Health);
        SortedPrint(sortedHeroes);
    }
    public static void SortedManaDescending()
    {
        var sortedHeroes = Process.SpawnHero().OrderByDescending(h => h.Health);
        SortedPrint(sortedHeroes);
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
    
}