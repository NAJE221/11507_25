namespace OOPNewProject.Practice4.CustomForeach;

public static class CustomForeach
{
    public static void ForEachWithIndex<T>(this IEnumerable<T> collection, Action<int, T> writeLine)
    {
        var index = 0;
        foreach (var item in collection)
        {
            writeLine(index,item);
            index++;
        }
    }
}


