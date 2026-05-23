using CW2;
List<object> testList = new();
// Тест первого номера//
ParallelProcessor process1 =  new ();
process1.GenerateDate();
process1.CustomProcess(process1.list);

// Тест второго номера //
Generate();
AttributeFilter newAtribute = new();
var result = newAtribute.GetValidObjects(testList);
Console.WriteLine(result.Count);
foreach (var res in result)
{
    Console.WriteLine(res);
}
void Generate()
{
    for (int i = 0; i < 10; i++)
    {
        testList.Add(new Object1());
        testList.Add(new Object2());
    }
}
public class Object1
{
    [Sensitive]
    public string Name { get; set; }
}

public class Object2
{
    public string Name { get; set; }
}

