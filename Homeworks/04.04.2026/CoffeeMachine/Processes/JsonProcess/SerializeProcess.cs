using System.Text.Json;
using CoffeeMachine.Objects;
using CoffeeMachine.Products;

namespace CoffeeMachine.Processes.JsonProcess;

public class SerializeProcess
{
    public static void Serialize()
    {
        ProductDataBase productDataBase = new();
        productDataBase.TempCoffees = ProductDataBase.ListCoffees;
        productDataBase.TempIngredients = ProductDataBase.ListIngredients;
        var currentDir = Directory.GetCurrentDirectory();
        var filePath = Path.Combine(currentDir, "config.json");
        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };
        File.WriteAllText(filePath, JsonSerializer.Serialize(productDataBase, options));
    }
}