namespace Dota2;

public class Craft
{
    public static Hero CraftHero(string line)
    {
        var dividedLine = line.Split(';');
        return new Hero(
            dividedLine[0],
            dividedLine[1],
            dividedLine[2],
            dividedLine[3],
            int.Parse(dividedLine[4]),
            int.Parse(dividedLine[5]),
            int.Parse(dividedLine[6]),
            int.Parse(dividedLine[7]));
    }
}