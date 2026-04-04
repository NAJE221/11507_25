using CoffeeMachine.InputOutput;
using CoffeeMachine.ValidationOutput;
using CoffeeMachine.Processes.JsonProcess;
using CoffeeMachine.Products;
using static CoffeeMachine.Decorations.ColoringObject;
using static CoffeeMachine.Products.ProductDataBase;
namespace CoffeeMachine.Processes.ActionsWithProducts.Replenishment;

public class ReplenishmentIngredients
{

    private static short _selectedIngredient;
    private static bool IngredientsExist()
    {
        if (ListIngredients.Count == 0)
        {
            ColoringDelayed("Список с ингредиентами пуст!", ConsoleColor.Red, 2000);
            return false;
        }
        return true;
    }
    
    private static short SelectionIngredient()
    {
        return Validation.ValidationCommands(ListIngredients,Output.PrintList,
            null,
            "Выберите сырьё для пополнения: ");
    }

    private static int GettingQuantity()
    {
        _selectedIngredient = SelectionIngredient();
        Console.Clear();
        return Validation.ValidationNumber<int>($"Выбрано: {ListIngredients[_selectedIngredient-1]}", 
            ConsoleColor.Green,
            "Введите кол-во сырья для пополнения: ", true);
    }
    
    
    public static void Replenishment()
    {
        if (IngredientsExist())
        {
            var quantityIngredient = GettingQuantity();
            ListIngredients[_selectedIngredient-1].AmountIngredient += quantityIngredient;
            SerializeProcess.Serialize();
            ColoringDelayed($"Ингридиент: успешно пополнен.\n", ConsoleColor.Green, 3000);
        }
    }
}