namespace CoffeeMachine.Processes.ClosingTheShift;
using System.Text.Json;
using Decorations;

public class ClosingTheShift
{
    private static string currentDir = Directory.GetCurrentDirectory();
    
    private static string _reportDir =  Path.Combine(currentDir, $"Reports");
    private static string _pathJson = Path.Combine(_reportDir, $"report{date.ToString("'_'yyyy'_'MM'_'dd")}.json");
    private static string _pathTxt = Path.Combine(currentDir, $"sales_history.txt");
    
    private static DateTime date = DateTime.Now;
    
    public static void Clossing()
    {
        var calculatingRevenue = CountingRevenue();
        if (!Directory.Exists(_reportDir))
            Directory.CreateDirectory(_reportDir);
        var finalReport = $"[{date.ToString("dd.MM.yyyy HH:mm:ss")}] revenue per shift: {calculatingRevenue} rub";
        var options = new JsonSerializerOptions()
        {
            WriteIndented = true
        };
        File.AppendAllText(_pathJson, JsonSerializer.Serialize(finalReport,options));
        Console.ForegroundColor = ConsoleColor.Green;
        Animation.AnimationText("Смена успешно закрыта!",3);
        Console.ResetColor();
        Thread.Sleep(2000);
    }

    private static decimal CountingRevenue()
    {
        decimal calculation = 0;
        string[] txtLines = File.ReadAllLines(_pathTxt);
        foreach (var line in txtLines)
        {
            if (string.IsNullOrEmpty(line)) continue;
            string[] tempArray = line.Split("|");
            var costOrder = tempArray[1].Replace("руб", "");
            calculation+=decimal.Parse(costOrder);
        }
        File.WriteAllText(_pathTxt, string.Empty);
        return calculation;
    }
}