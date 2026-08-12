namespace CW2;

public static class ItemExtensions
{
    public static int GetSellPrice(this IItem item)
    {
        return item.GetPrice() / 2;
    }
}