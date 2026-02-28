using System.Numerics;



public interface IPriceStep<T> where T: INumber<T>
{
    public IFinalStep<T> WithPriceStep(T value);
}