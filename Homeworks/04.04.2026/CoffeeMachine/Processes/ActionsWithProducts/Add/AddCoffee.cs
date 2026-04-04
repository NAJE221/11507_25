using CoffeeMachine.Processes.JsonProcess;
using CoffeeMachine.Products;
using static CoffeeMachine.InputOutput.Validation;
using static CoffeeMachine.Products.ProductDataBase;
using static CoffeeMachine.ValidationOutput.Output;
using static CoffeeMachine.Decorations.ColoringObject;
using static CoffeeMachine.Decorations.Animation;
using static CoffeeMachine.InputOutput.Validation;
namespace CoffeeMachine.Processes.ActionsWithProducts.Add;

public class AddCoffee
{
    private static string AddName()
    {
        return ValidationString("Введите название: ");
    }
    private static decimal AddCost()
    {
        return ValidationNumber<decimal>(null, default, "Введите цену: ", true);
    }
    private static int AddVolume()
    {
        return ValidationNumber<int>(null, default, "Введите объём (мл): ", true);
    }
    private static Dictionary<string, int> AddIngredients()
    {
        List<string> continueOrStop = new()
        {
            "Да",
            "Нет"
        };
        byte userChoiceToContinueOrEnd;
        Dictionary<string, int> ingredientsForCooking = new();

        while (true)
        {
            var userChoice = ValidationCommands(ListIngredients, PrintList, "Доступные ингредиенты:", "Введите значение: ");
            var nameChoiceIngredient = ListIngredients[userChoice - 1].NameIngredient;
            var valueChoiceIngredient = ValidationNumber<int>(null,default,"Введите кол-во ингредиента: ",true);
            if (ingredientsForCooking.ContainsKey(ListIngredients[userChoice - 1].NameIngredient))
            {
                ingredientsForCooking[nameChoiceIngredient] += valueChoiceIngredient;
            }
            else
            {
                ingredientsForCooking[nameChoiceIngredient] = valueChoiceIngredient;
            }
            userChoiceToContinueOrEnd = (byte)ValidationCommands(continueOrStop, PrintList, "Добавить еще ингредиент?", "Введите значение: ");
            if (userChoiceToContinueOrEnd == 2) break;
        }
        return ingredientsForCooking;
    }
    
    public static void AddingCoffee()
    {
        if (PositionExist(ListIngredients,"В автомате нет ингредиентов"))
        {
            var nameCoffee = AddName();
            var costCoffee = AddCost();
            var volumeCoffee = AddVolume();
            var ingredients = AddIngredients();
            string nameIngredients = string.Join("; ", ingredients.Keys);
            ListCoffees.Add(new Coffee(nameCoffee, costCoffee, volumeCoffee, ingredients));
            SerializeProcess.Serialize();
            Console.Clear();
            Coloring($"Кофе успешно добавлен!", ConsoleColor.Green);
            Coloring($"Добавленный кофе: {ListCoffees[ListCoffees.Count() - 1]}", ConsoleColor.Yellow);
            AnimationText($"Ингредиенты для приготовления {ListCoffees[ListCoffees.Count()-1].NameCoffee}: " +
                          $"{nameIngredients}",1);
            Thread.Sleep(3000);
        }
    }    
}