using System.Numerics;



public class OrderBuilder<T> : 
    Order<T>, 
    IIdStep<T>, 
    IFinalStep<T>,
    IPriceStep<T>
    where T : INumber<T>
{
    public IPriceStep<T> WithSetId(int value)
    {
        Id = value;
        return this;
    }
    public IFinalStep<T> WithPriceStep(T value)
    {
        Price = value;
        return this;
    }
    public Order<T> Build()
    {
        return this;
    }
}
