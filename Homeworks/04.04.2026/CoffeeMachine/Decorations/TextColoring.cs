
namespace CoffeeMachine.Decorations;
public class ColoringObject
{
    public static void Coloring<T>(T userObject, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(userObject);
        Console.ResetColor();
    }

    public static void ColoringDelayed(string text, ConsoleColor color, int delayTime)
    {
        Console.Clear();
        Coloring(text, color);
        Thread.Sleep(delayTime);
    }
}