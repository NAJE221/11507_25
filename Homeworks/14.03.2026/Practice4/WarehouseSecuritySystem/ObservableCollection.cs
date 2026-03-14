using System.Collections.ObjectModel;
using System.Collections.Specialized;
namespace HomeWork.Practice4.WarehouseSecuritySystem;

public class Logger
{
    public ObservableCollection<string> LoggerObservable;
    public Logger()
    {
        LoggerObservable = new();
        LoggerObservable!.CollectionChanged += LoggerObservable_CollectionChanged!;
    }
    void LoggerObservable_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
    {
        switch (e.Action)
        {
            case NotifyCollectionChangedAction.Add:
                if (e.NewItems?[0] is string message)
                {
                    Console.WriteLine($"Ошибка: {e.NewItems[0]} добавлена в логи");
                }
                break;
        }
    }
}