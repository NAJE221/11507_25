namespace CW2;

public abstract class ItemBase : IItem
{
    public string Name { get; }
    public double Weight;
    public int Price;

    protected ItemBase(string name, double weight, int price)
    {
        Name = name;
        Weight = weight;
        Price = price;
    }

    public abstract bool Use(object target);

    public double GetWeight() => Weight;
    public int GetPrice() => Price;
}