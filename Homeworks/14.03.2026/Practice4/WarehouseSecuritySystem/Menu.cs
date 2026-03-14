namespace HomeWork.Practice4.WarehouseSecuritySystem;
using static ErrorList;

public class Menu
{
    private Menu()
    {
    }
    public static void PrintMenu()
    {
        short cnt = 0;
        foreach (var error in errorList)
        {
            cnt++;
            Console.WriteLine($"{cnt}) {error}");
        }
        Console.Write("Выберите тип происшествия (1 - 5): ");
    }
    public static short GetMenuInput()
    {
        short input;
        do
        {
            PrintMenu();
        }
        while(!short.TryParse(Console.ReadLine(), out input) 
              || (input < 0 || input > 5));
        return input;
    }
    
    public static string HandlerInput()
    {
        var input = GetMenuInput();
        switch (input)
        {
            case 1:
                return "КРИТИЧНО: Сломался конвейер";
            case 2:
                return "ИНФО: Разрыв ленты";
            case 3:
                return "КРИТИЧНО: Разряд аккумуляторов электропогрузчиков";
            case 4:
                return "Конфликт маршрутов";
            case 5:
                return "Массовый отказ сканеров штрих-кодов";
        }
        return "";
    }
}


