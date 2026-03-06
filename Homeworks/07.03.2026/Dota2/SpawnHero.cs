namespace Dota2;

public class Spawn
{
    public static List<Hero> HeroesList { get; set; } = new();
    private static string _path = @"C:\Users\Artem\Desktop\Dota2\Dota2\Dota2.txt";
    public static IEnumerable<Hero> SpawnHeroes()
    {
        foreach (string line in File.ReadLines(_path))
        {
            if (!string.IsNullOrWhiteSpace(line))
            {
                yield return Craft.CraftHero(line);
            }
        }
    }
    public static void SpawnHeroesImmediately()
    {
        foreach (string line in File.ReadLines(_path))
        {
            if (!string.IsNullOrWhiteSpace(line))
            {
                HeroesList.Add(Craft.CraftHero(line));
            }
        }
    }
}