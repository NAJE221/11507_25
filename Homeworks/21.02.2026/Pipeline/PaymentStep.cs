public class PaymentStep : PipelineStep<Product, Receipt>
{
    public decimal balance = 1000;

    public override Receipt Process(Product product)
    {
        if (balance < product.Price)
        {
            Console.WriteLine("У вас мало денег");
        }
        
        return new Receipt(product.Name, product.Price);
    }
} 