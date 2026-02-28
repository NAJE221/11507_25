using System.Numerics;

public class Process
{ 
    public void ProcessStep<T>()  where T : INumber<T>
    {
        OrderBuilder<T> orderBuilderDecimal = new();
        Order<T> orderDecimal = orderBuilderDecimal
            .WithSetId(InputId())
            .WithPriceStep(InputPrice<T>())
            .Build();
        
        DiscountHandler<T> discountDecimal = new(Discount<T>());
        TaxHandler<T>  taxDecimal = new(Tax<T>());
        ValidationHandler<T> validationDecimal = new();
        discountDecimal.SetNext(taxDecimal);
        taxDecimal.SetNext(validationDecimal);
        
        discountDecimal.Handle(orderDecimal);
    }
    
    private int InputId()
    {
        int id;
        do
        {
            Console.Clear();
            Console.Write("Введите Id товара: ");
        }
        while (!int.TryParse(Console.ReadLine(), out id) || id < 0);
        return id;
    }

    private T InputPrice<T>() where T : INumber<T>, IParsable<T>
    {
        T? price;
        do
        {
            Console.Clear();
            Console.Write("Введите цену на товар: ");
        }
        while (!T.TryParse(Console.ReadLine(), null, out price!) || price < T.Zero);
        return price;
    }
    private T Discount<T>() where T : INumber<T>, IParsable<T>
    {
        T? discount;
        do
        {
            Console.Clear();
            Console.Write("Введите скидку на товар: ");
        }
        while (!T.TryParse(Console.ReadLine(), null, out discount!) || discount < T.Zero);
        return discount;
    }
    
    private T Tax<T>() where T : INumber<T>, IParsable<T>
    {
        T tax;
        do
        {
            Console.Clear();
            Console.Write("Введите налог: ");
        } while (!T.TryParse(Console.ReadLine(), null, out tax!) || tax < T.Zero);
        return tax;
    }
}
