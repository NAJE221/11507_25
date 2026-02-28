using System.Numerics;

public class DiscountHandler<T> : Handler<Order<T>> where T : INumber<T>
{
    private readonly T _discount;
    public DiscountHandler(T discount)
    {
        _discount = discount;
    }
    public override Order<T> Handle(Order<T> input)
    {
        Console.Clear();
        Console.WriteLine($"-----------------------------\n" +
                          $"Начальная цена: {input.Price} руб");
        input.Price -= _discount;
        Console.WriteLine("Скидка: " + _discount + "руб");
        return base.Handle(input);
    }
}