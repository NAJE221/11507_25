namespace CoffeeMachine;

public class Logger
{
    public static void Logging(string text)
    {
        DateTime date = DateTime.Now;
        var currentDir = Directory.GetCurrentDirectory();
        var folderPath = Path.Combine(currentDir, "sales_history.txt");
        File.AppendAllText(folderPath,"\n" + $"[{date.ToString("dd.MM.yyyy HH:mm:ss")}] " + text);
    }
}