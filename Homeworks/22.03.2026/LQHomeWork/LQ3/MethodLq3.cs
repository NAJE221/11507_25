using System;
public static class MethodLq3
{

    public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> source, Func<T, bool> valid)
    {
        foreach (var item in source)
        {
            if (valid(item))
            {
                yield return item;
            }
        }
    }
    
    public static List<List<T>> MyGroupBy<T>(this IEnumerable<T> input)
    {
        List<List<T>> list = new();
        Dictionary<T, List<T>> temp = new();
        foreach (var item in input)
        {
            if (!temp.ContainsKey(item))
            {
                temp[item] = new List<T>();
            }
            temp[item].Add(item);
        }
        foreach (var item in temp.Values)
        {
            list.Add(item);
        }
        return list;
    }

    public static bool MyAll<T>(this IEnumerable<List<T>> listChar, Func<List<T>, bool> valid)
    {
        foreach (var item in listChar)
        {
            if (!valid(item))
            {
                return false;
            }
        }
        return true;
    }
}