using CoffeeMachine.InputOutput;
using CoffeeMachine.Objects;
using CoffeeMachine.Processes.JsonProcess;
using CoffeeMachine.Products;
using static CoffeeMachine.Decorations.ColoringObject;
namespace CoffeeMachine.Processes.ActionsWithProducts.Add;

public class AddIngredients
{
    private static string AddName()
    {
        return Validation.ValidationString("Введите название: ");
    }

    private static int AddQuantity()
    {
        return Validation.ValidationNumber<int>(null, default, "Введите количество: ", true);
    }

    public static void AddingIngredients()
    {
        var nameIngredients = AddName();
        var quantityIngredients = AddQuantity();
        ProductDataBase.ListIngredients.Add(new Ingredient(nameIngredients,quantityIngredients));
        SerializeProcess.Serialize();
        ColoringDelayed($"Ингредиент {nameIngredients} успешно добавлен в количестве: {quantityIngredients}!", ConsoleColor.Green,4000);
    }
}