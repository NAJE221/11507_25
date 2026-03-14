using OOPNewProject.Practice4.CustomForeach;

public class TestProcess
{
    public TestProcess()
    {
        List<string> names = new()
        {
            "Bob",
            "Jane",
            "Ibra",
            "Yota",
        };
        names.ForEachWithIndex((index, name) => Console.WriteLine($"{index} {name}"));
    }
}