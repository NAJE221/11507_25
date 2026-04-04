using CoffeeMachine.Objects;
using static CoffeeMachine.Products.ProductDataBase;
using static CoffeeMachine.ValidationOutput.Output;
using static CoffeeMachine.InputOutput.Validation;
using static CoffeeMachine.Decorations.ColoringObject;
using static CoffeeMachine.Processes.JsonProcess.SerializeProcess;
namespace CoffeeMachine.Processes.ActionsWithProducts.Remove;
public class Remove
{
    public static void RemoveCoffee()
    {
        if (PositionExist(ListCoffees,"Кофе для удаления не найдено!"))
        {
            var selectionCoffee = ValidationCommands(ListCoffees, PrintList, $"Список кофе:", "Выберите позицию для удаления: ");
            ListCoffees.RemoveAt(selectionCoffee - 1);
            Serialize();
            ColoringDelayed($"Удаление прошло успешно!", 
                ConsoleColor.Red,
                4000);
        }
    }
    
    public static void RemoveIngredients()
    {
        if (PositionExist(ListIngredients,"Ингредиентов для удаления не найдено!"))
        {
            var selectionCoffee = ValidationCommands(ListIngredients, PrintList, $"Список ингредиентов:", "Выберите позицию для удаления: ");
            ListIngredients.RemoveAt(selectionCoffee - 1);
            Serialize();
            ColoringDelayed($"Удаление прошло успешно!", 
                ConsoleColor.Red,
                4000);
        }
    }
}