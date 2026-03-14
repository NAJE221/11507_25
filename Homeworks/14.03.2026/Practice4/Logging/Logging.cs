namespace HomeWork.Practice4.Logging;

public class Logging
{
    public LogHandler _logHandler;
    
    public void Process()
    {
        _logHandler = PrintText;
        _logHandler += PrintCollorText;
        _logHandler("Заказ принят");
        _logHandler("Платёж прошёл");
    }

    public void PrintText(string mes)
    {
        Console.WriteLine(mes);
    }

    public void PrintCollorText(string mes)
    {
        Console.ForegroundColor = ConsoleColor.Green; 
        Console.WriteLine(mes);
        Console.ResetColor(); 
    }
    
    public delegate void LogHandler(string message); 
}