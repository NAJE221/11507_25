namespace HomeWork.Practice4.NotificationChain;

public class User
{
    public readonly string Login;
    public readonly string Email;
    public readonly string Password;

    public User()
    {
        Console.Clear();
        while (string.IsNullOrWhiteSpace(Login))
        {
            Console.Write("Введите логин: ");
            Login = Console.ReadLine()!;
        }
        
        while (string.IsNullOrWhiteSpace(Email))
        {
            Console.Write("Введите почту: ");
            Email = Console.ReadLine()!;
        }

        while (string.IsNullOrWhiteSpace(Password))
        {
            Console.Write("Введите пароль: "); 
            Password = Console.ReadLine()!;
        }
    }
}