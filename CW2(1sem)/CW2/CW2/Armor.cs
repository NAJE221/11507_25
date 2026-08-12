namespace CW2;

public class Armor : ItemBase
{
    private int _defense;
    private int _strengthRequirement;

    public Armor(string name, double weight, int price, int defense, int strengthRequirement)
        : base(name,weight, price)
    {
        _defense = defense;
        _strengthRequirement = strengthRequirement;
    }

    public override bool Use(object target)
    {
        if (target is int hereStrange && hereStrange >= _strengthRequirement)
        {
            Console.WriteLine("Вы экипировали броню");
            return false;
        }
        Console.WriteLine("Недостаточно силы для данной брони");
        return false;
    }
}