namespace CW2;

public class InventoryManager
{
    private double _maxWeight;
    private double _currentWeight;
    private List<IItem> _items;

    public InventoryManager(double maxWeight)
    {
        _maxWeight = maxWeight;
        _currentWeight = 0;
        _items = new List<IItem>();
    }
    
    
    public bool TryAddItem(IItem item)
    {
        if (item == null) return false;

        double newItemWeight = item.GetWeight();
        if (_currentWeight + newItemWeight > _maxWeight)
        {
            Console.WriteLine("Инвентарь перегружен! Невозможно добавить предмет.");
            return false;
        }
        _items.Add(item);
        _currentWeight += newItemWeight;
        Console.WriteLine($"Предмет: {item.Name} получен в инвентарь");
        return true;
        
    }

    public void UseItem(int index, object target)
    {
        if (index < 0 || index >= _items.Count)
        {
            Console.WriteLine("Прдмет в инвенторе не найден.");
        }
        var item = _items[index];
        item.Use(target);
    }
}