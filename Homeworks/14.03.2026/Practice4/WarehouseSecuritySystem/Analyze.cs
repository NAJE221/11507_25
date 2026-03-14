namespace HomeWork.Practice4.WarehouseSecuritySystem;

public class Analyze
{
    public static void AnalyzeLog<T>(IEnumerable<T> logs, Predicate<T> filter)
    {
        foreach (var log in logs)
        {
            if (filter(log))
            {
                Console.WriteLine(log);
            }
        }
    }
}