using CoffeeMachine.Objects;

namespace CoffeeMachine.Products;

public class ProductDataBase
{
    public static List<Coffee> ListCoffees = new();
    
    public static List<Ingredient> ListIngredients = new();
    
    public static List<Supplements> ListSupplements = new()
    {
        new Supplements("Без добавок", 0),
        new Supplements("Шоколад", 25),
        new Supplements("Карамель", 30),
        new Supplements("Ваниль", 20)
    };
    public List<Coffee> TempCoffees { get; set; }
    public List<Ingredient> TempIngredients { get; set; }

    public static List<string> CoffeeBasicsSheet = new()
    {
        "Молоко",
        "Сливки"
    };
}