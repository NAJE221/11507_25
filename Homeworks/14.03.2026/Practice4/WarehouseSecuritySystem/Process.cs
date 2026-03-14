using System.Collections.ObjectModel;

namespace HomeWork.Practice4.WarehouseSecuritySystem;
using static Analyze;
public class Process
{
    public void Run()
    {
        ObservableCollection<string> testLogger = new()
        {
            "КРИТИЧНО: Разряд аккумуляторов электропогрузчиков",
            "Конфликт маршрутов",
            "КРИТИЧНО: Сломался конвейер",
            "ИНФО: Разрыв ленты",
        };
        Sensor sensor = new();
        sensor.Trigger();
        Console.Clear();
        AnalyzeLog(testLogger, filter => filter.Contains("КРИТИЧНО"));
    }
}