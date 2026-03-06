namespace Dota2;
using static Print;
using static Spawn;

public class Sorted
{
    public static void SortedComplexity()
    {
        int input;
        do
        {
            PrintComplexity();
        }
        while(!int.TryParse(Console.ReadLine() , out input) || input < 1 || input > 3);
        if (input == 1)
        {
            foreach (Hero hero in SpawnHeroes())
            {
                if (hero.Complexity == "1")
                {
                    Console.WriteLine(hero);
                    Thread.Sleep(5);
                }
            }
        }
        else if (input == 2)
        {
            foreach (Hero hero in SpawnHeroes())
            {
                if (hero.Complexity == "2")
                {
                    Console.WriteLine(hero);
                    Thread.Sleep(5);
                }
            }
        }
        else
        {
            foreach (Hero hero in SpawnHeroes())
            {
                if (hero.Complexity == "3")
                {
                    Console.WriteLine(hero);
                    Thread.Sleep(5);
                }
            }
        }
    }

    public static void SortedTypeAttribute()
    {
        int input;
        do
        {
            PrintTypeAttribute();
        }
        while(!int.TryParse(Console.ReadLine() , out input) || input < 1 || input > 3);
        if (input == 1)
        {
            foreach (Hero hero in SpawnHeroes())
            {
                if (hero.TypeAttribute == "Strength")
                {
                    Console.WriteLine(hero);
                    Thread.Sleep(5);
                }
            }
        }
        else if (input == 2)
        {
            foreach (Hero hero in SpawnHeroes())
            {
                if (hero.TypeAttribute == "Agility")
                {
                    Console.WriteLine(hero);
                    Thread.Sleep(5);
                }
            }
        }
        else
        {
            foreach (Hero hero in SpawnHeroes())
            {
                if (hero.TypeAttribute == "Intelligence")
                {
                    Console.WriteLine(hero);
                    Thread.Sleep(5);
                }
            }
        }
    }
    
    public static void SortedTypeAttack()
    {
        int input;
        do
        {
            PrintTypeAttack();
        }
        while(!int.TryParse(Console.ReadLine() , out input) || input < 1 || input > 2);
        if (input == 1)
        {
            foreach (Hero hero in SpawnHeroes())
            {
                if (hero.TypeAttack == "Melee")
                {
                    Console.WriteLine(hero);
                    Thread.Sleep(5);
                }
            }
        }
        else
        {
            foreach (Hero hero in SpawnHeroes())
            {
                if (hero.TypeAttack == "Ranged")
                {
                    Console.WriteLine(hero);
                    Thread.Sleep(5);
                }
            }
        }
    }
    
    public static void SortedHealth()
    {
        SpawnHeroesImmediately();
        for (int i = 0; i < HeroesList.Count; i++)
        {
            for (int j = 0; j < HeroesList.Count; j++)
            {
                if (HeroesList[i].Health < HeroesList[j].Health)
                {
                    (HeroesList[i], HeroesList[j]) = (HeroesList[j], HeroesList[i]);
                }
            }
        }
        PrintList(HeroesList);
    }
}