namespace CW2;

public class Potion : ItemBase
{
    private int _healAmount;


    public Potion(string name, double weight, int price) : base(name, weight, price)
    {
        _healAmount = 75;
       
    }

public override bool Use(object target)
    {
        Console.WriteLine($"Вы восстановили: {_healAmount} здоровья");
        return true;
    }
}