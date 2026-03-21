public class LQ1<T>
{
    public T[] result;
    public LQ1(T[] array, int k)
    {
        k %= array.Length;
        result = array.Skip(k).MyUnion(array.Take(k)).ToArray();
    }
}