using System.Numerics;



public class TaxHandler<T> : Handler<Order<T>> where T : INumber<T>
{
    private readonly T _tax;
    public TaxHandler(T tax)
    {
        _tax = T.CreateChecked(tax);
    }
    public override Order<T> Handle(Order<T> input)
    {
        input.Price *= _tax;
        Console.WriteLine("Цена с учетом налога: " + input.Price + " руб");
        return base.Handle(input);
    }
}