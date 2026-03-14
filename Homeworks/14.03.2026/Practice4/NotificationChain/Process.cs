namespace HomeWork.Practice4.NotificationChain;

public class Process2
{
    private Chain chain;
    private NotificationChain _notificationChain = new();
    public Process2()
    {
        chain += _notificationChain.SendTheCode;
        chain += _notificationChain.RecordData;
        chain += _notificationChain.PrintUserCounter;
        while (true)
        {
            User user = new();
            chain?.Invoke(user);
            char input;
            do
            {
                Console.Clear();
                Console.Write("1) Продолжить" +
                              "\n2) Выйти" +
                              "\nВведите значение: ");
                input = Console.ReadKey().KeyChar;
            }
            while (input != '1' && input != '2');
            if (input == '1')
            {
                continue;
            }
            break;
        }
    }
    private delegate void Chain(User user);
}

