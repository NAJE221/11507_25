using System;
using System.Linq;
namespace Dota2;
using static Print;
using static Sorted;
public class Process
{
    private static string path = @"C:\Users\Artem\Desktop\Dota2\Dota2\Dota2.txt";
    public static void Launch()
    {
        int input;
        do
        {
            PrintMenu();
        }
        while(!int.TryParse(Console.ReadLine() , out input) || input < 1 || input > 12);
        CheckingTheInput(input);
    }

    public static void CheckingTheInput(int input)
    {
        switch (input)
        {
            case 1:
                SortedName();
                break;
            case 2:
                SortedComplexity();
                break;
            case 3:
                SortedTypeAttribute();
                break;
            case 4:
                SortedTypeAttack();
                break;
            case 5:
                SortedHealthIncreasing();
                break;
            case 6:
                SortedHealthDescending();
                break;
            case 7:
                SortedDamageIncreasing();
                break;
            case 8:
                SortedDamageDescending();
                break;
            case 9:
                SortedArmorIncreasing();
                break;
            case 10:
                SortedArmorDescending();
                break;
            case 11:
                SortedManaIncreasing();
                break;
            case 12:
                SortedManaDescending();
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

    public static void SortedComplexity()
    {
        int input;
        do
        {
            Console.Clear();
            Console.Write("Введите значение (1-3): ");
        }
        while(!int.TryParse(Console.ReadLine() , out input) || input < 1 || input > 3);
        
        switch (input)
        {
            case 1:
                var filterComplexity1 = Process.SpawnHero().Where(h => h.Complexity == "1");
                FilterPrint(filterComplexity1);
                break;
            case 2:
                var filterComplexity2 = Process.SpawnHero().Where(h => h.Complexity == "2");
                FilterPrint(filterComplexity2);
                break;
            case 3:
                var filterComplexity3 = Process.SpawnHero().Where(h => h.Complexity == "3");
                FilterPrint(filterComplexity3);
                break;
        }
    }
    public static void SortedTypeAttribute()
    {
        int input;
        do
        {
            Console.Clear();
            Console.WriteLine("1) Сила\n2) Ловкость\n3) Интелект");
            Console.Write("\nВведите значение: ");
        }
        while(!int.TryParse(Console.ReadLine() , out input) || input < 1 || input > 3);
        
        switch (input)
        {
            case 1:
                var filterStrength = Process.SpawnHero().Where(h => h.TypeAttribute == "Strength");
                FilterPrint(filterStrength);
                break;
            case 2:
                var filterAgility = Process.SpawnHero().Where(h => h.TypeAttribute == "Agility");
                FilterPrint(filterAgility);
                break;
            case 3:
                var filterIntelligence = Process.SpawnHero().Where(h => h.TypeAttribute == "Agility");
                FilterPrint(filterIntelligence);
                break;
        }
    }
    
    public static void SortedTypeAttack()
    {
        int input;
        do
        {
            Console.Clear();
            Console.WriteLine("1) Ближной бой\n2) Дальний бой");
            Console.Write("\nВведите значение: ");
        }
        while(!int.TryParse(Console.ReadLine() , out input) || input < 1 || input > 2);
        
        switch (input)
        {
            case 1:
                var filterStrength = Process.SpawnHero().Where(h => h.TypeAttack == "Melee");
                FilterPrint(filterStrength);
                break;
            case 2:
                var filterAgility = Process.SpawnHero().Where(h => h.TypeAttack == "Ranged");
                FilterPrint(filterAgility);
                break;
        }
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
}