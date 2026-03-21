[Serializable]
public class Item
{
    public string Name { get; set; }
    public string Count { get; set; }
    public decimal Price { get; set; }
    
    public Item(string name, string count, decimal price)
    {
        Name = name;
        Count = count;
        Price = price;
    }
    
    public override string ToString()
    {
        return "{" + Name + ":" + Count + ":" + Price + "}";
    }
}