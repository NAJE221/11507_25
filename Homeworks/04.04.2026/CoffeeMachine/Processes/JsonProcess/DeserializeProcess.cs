using CoffeeMachine.Processes.JsonProcess;
using CoffeeMachine.Products;

namespace CoffeeMachine.JsonProcess;
using System.Text.Json;
using Objects;

public class DeserializeProcess
{
    public static void WritingToList()
    {
        var path = Path.Combine(Directory.GetCurrentDirectory(), "config.json");
        if (File.Exists(path))
        {
            try
            {
                string jsonContent = File.ReadAllText(path);
                var temp = JsonSerializer.Deserialize<ProductDataBase>(jsonContent);
                ProductDataBase.ListCoffees = temp!.TempCoffees;
                ProductDataBase.ListIngredients = temp.TempIngredients;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при копировании файла: " + ex.Message);
            }
        }
        else
        {
            SerializeProcess.Serialize();
        }
    }
}