using System.Numerics;

using System;
public class Order<T> where T : INumber<T>
{
    public int Id;
    public T? Price;
}