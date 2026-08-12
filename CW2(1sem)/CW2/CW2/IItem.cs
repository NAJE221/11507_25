namespace CW2;

public interface IItem
{
    public string Name { get; }
    bool Use(object target);
    double GetWeight();
    int GetPrice();
}