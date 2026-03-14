namespace HomeWork.Practice4.WarehouseSecuritySystem;
using static Menu;
using System;

public class Sensor
{
    public event Action<string, DateTime> OnAlert;

    private DateTime _dateNow = DateTime.Now;
    
    public void Trigger()
    {
        OnAlert = Siren;
        OnAlert += LoggerData;
        var message = HandlerInput();
        OnAlert(message, _dateNow);
        Thread.Sleep(5000);
    }
    public void Siren(string message, DateTime dateNow)
    {
        Console.WriteLine($"ВКЛЮЧЕНА СИРЕНА: {message} Дата: {dateNow}");
    }

    public void LoggerData(string message, DateTime dateNow)
    {
        Logger newLogger = new Logger();
        newLogger.LoggerObservable.Add($"{message} Дата: {dateNow}");
    }
}