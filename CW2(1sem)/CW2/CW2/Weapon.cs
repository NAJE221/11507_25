namespace CW2;

public class Weapon : ItemBase
{
    private int _damage;

    
    public Weapon(string name, double weight, int price) : base(name, weight, price)
    {
        _damage = 35;
    }
        
    
    public override bool Use(object target)
    {
        Console.WriteLine($"Вы нанесли {_damage} урона");
        return false;
    }
}