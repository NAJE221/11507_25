using System.Text.Json;
public class CreatingList
{
    public static List<Item> itemList = new();
}

public class Process1
{
    public void WritingToList()
    {
        var path = Path.Combine(Directory.GetCurrentDirectory(), "Store.json");
        if (File.Exists(path))
        {
            try
            {
                string jsonContent = File.ReadAllText(path);
                CreatingList.itemList = JsonSerializer.Deserialize<List<Item>>(jsonContent);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при копировании файла: " + ex.Message);
            }
        }
        else
        {
            Record();
        }
        
    }

    public void Record()
    {
        var currentDir = Directory.GetCurrentDirectory();
        var filePath = Path.Combine(currentDir, "Store.json");
        var options = new JsonSerializerOptions()
        {
            WriteIndented = true
        };
        File.WriteAllText(filePath, JsonSerializer.Serialize(CreatingList.itemList, options));
    }

    public void Add()
    {
        Console.Write("Введите название товара: ");
        var name = Console.ReadLine();
        Console.Write("Введите кол-во товара: ");
        var age = Console.ReadLine();
        decimal price;
        do
        {
            Console.Write("Введите цену товара: ");
        } while (!decimal.TryParse(Console.ReadLine(), out price));

        CreatingList.itemList.Add(new Item(name, age, price));
        Record();
    }

    public void Delete()
    {
        Console.Write("Введите название товара который хотите удалить: ");
        var name = Console.ReadLine();
        for (int i = 0; i < CreatingList.itemList.Count; i++)
        {
            if (CreatingList.itemList[i].Name == name)
            {
                CreatingList.itemList.RemoveAt(i);
                Record();
                return;
            }
        }
        Console.WriteLine("Товар не найден!");
        Console.Clear();
    }

    public void PrintItem()
    {
        if (CreatingList.itemList.Count == 0)
        {
            Console.WriteLine("Список пуст!");
        }

        for (int i = 1; i <= CreatingList.itemList.Count; i++)
        {
            Console.WriteLine(i + ". " + CreatingList.itemList[i - 1]);
        }
    }
}