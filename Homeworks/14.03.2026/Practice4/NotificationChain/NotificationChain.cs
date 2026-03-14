namespace HomeWork.Practice4.NotificationChain;

public class NotificationChain : UserBase
{
    public void SendTheCode(User user)
    {
        try
        {
            Console.WriteLine($"Код отправлен на почту: {user.Email}");
            Console.Write("Введите код: (вообще че угодно) ");
            Console.ReadLine();
        }
        catch
        {
            Console.WriteLine("Неудалось отправить код");
        }
    }
    public void RecordData(User user)
    {
        try
        {
            Users.Add(counter, user);
            counter++;
            Console.WriteLine("Производиться запись данных в базу данных...");
            Thread.Sleep(3000);
        }
        catch
        {
            Console.WriteLine("Неудалось записать данные в базу данных");
            Thread.Sleep(3000);
        }
    }

    public void PrintUserCounter(User user)
    {
        Console.WriteLine($"Количество пользователей: {counter}");
        Thread.Sleep(5000);
    }
}