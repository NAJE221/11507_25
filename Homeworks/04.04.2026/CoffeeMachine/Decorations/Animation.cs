namespace CoffeeMachine.Decorations;

public class Animation
{
    public static void Loading()
    {
        Console.Write("|");
        for (short i = 0; i < 30; i++)
        {
            Console.Write("=");
            Thread.Sleep(400);
        }
        Console.WriteLine("|");
        Thread.Sleep(1000);
    }

    public static void AnimationText(string text, int speed)
    {
        for (short i = 0; i < text.Length; i++)
        {
            Console.Write(text[i]);
            Thread.Sleep(speed);
        }
    }
}