namespace CoffeeMachine.Objects;

[Serializable]
public class Ingredient
{
    public string NameIngredient { get; init; }
    public int AmountIngredient { get; set; }
    public Ingredient(string nameIngredients, int remainderIngredient)
    {
        NameIngredient = nameIngredients;
        AmountIngredient = remainderIngredient;
    }

    public Ingredient()
    {
        
    }
    public override string ToString()
    {
        return $"{NameIngredient} : {AmountIngredient}";
    }
}


