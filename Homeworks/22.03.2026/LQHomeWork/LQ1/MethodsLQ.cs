public static class MethodsLQ
{
    public static IEnumerable<T> Skip<T>(this IEnumerable<T> source, int k)
    {
        foreach (var item in source)
        {
            if (k > 0)
            {
                k--;
                continue;
            }
            yield return item;
        }
    }

    public static IEnumerable<T> Take<T>(this IEnumerable<T> source, int k)
    {
        foreach (var item in source)
        {
            if (k != 0)
            {
                k--;
                yield return item;
            }
        }
    }
    public static int MyCount<T>(this IEnumerable<T> source)
    {
        int count = 0;
        foreach(var item in source)
        {
            count++;
        }
        return count;
    }
    
    public static IEnumerable<T> MyUnion<T>(this IEnumerable<T> source1, IEnumerable<T> source2)
    {
        foreach (var item in source1)
        {
            yield return item;
        }
        foreach (var item in source2)
        {
            yield return item;
        }
    }

    public static T[] ToArray<T>(this IEnumerable<T> source)
    {
        var index = 0;
        T[] newArray = new T[source.MyCount()];
        foreach (var item in source)
        {
            newArray[index++] = item;
        }
        return newArray;
    }
}