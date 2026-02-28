using System.Numerics;

public interface IFinalStep<T> where T : INumber<T>
{
    public Order<T> Build();
}