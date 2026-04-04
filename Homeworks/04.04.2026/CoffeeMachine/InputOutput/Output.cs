namespace CoffeeMachine.ValidationOutput;
public class Output
{
    public static void PrintList<T>(List<T> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine($"{i+1}) {list[i]}");
        }
    }
}
