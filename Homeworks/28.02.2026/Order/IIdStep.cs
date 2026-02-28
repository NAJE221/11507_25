using System.Numerics;


public interface IIdStep<T> where T : INumber<T>
{
    public IPriceStep<T> WithSetId(int id);
}