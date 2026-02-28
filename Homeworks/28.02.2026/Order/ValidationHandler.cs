using System.Numerics;



public class ValidationHandler<T> : Handler<Order<T>> where T : INumber<T>
{
    public override Order<T> Handle(Order<T> input)
    {
        if (input.Price < T.Zero)
        {
            throw new ArgumentException("Цена не должна быть отриццатльной");
        }
        
        Console.WriteLine($"Итоговая цена: {input.Price}\n" +
                          "-----------------------------");
    return input;
    }
}