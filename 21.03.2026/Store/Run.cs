
public class Run
{
    Process1 process = new Process1();

    public Run()
    {
        while (true)
        {
            process.WritingToList();
            Console.WriteLine("1) Добавление товара\n" +
                              "2) Удаление товара\n" +
                              "3) Вывести список продуктов\n");
            Console.Write("Введите команду: ");
            switch (Console.ReadLine())
            {
                case "1":
                    process.Add();
                    break;
                case "2":
                    process.Delete();
                    break;
                case "3":
                    process.PrintItem();
                    break;
                default:
                    Console.WriteLine("Такого индекса нету");
                    break;
            }
        }
    }
}