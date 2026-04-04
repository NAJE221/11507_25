namespace CoffeeMachine.Products;

[Serializable]
public class Coffee
{
    public string NameCoffee { get; init; }
    public decimal CostCoffee { get; init; }
    public int VolumeCoffee { get; init; }
    
    public Dictionary<string,int> IngredientsForCooking { get; set; }
    public Coffee(string nameCoffee, decimal costCoffee, int volumeCoffee , Dictionary<string,int> ingredientsForCooking)
    {
        NameCoffee = nameCoffee;
        CostCoffee = costCoffee;
        VolumeCoffee = volumeCoffee;
        IngredientsForCooking = ingredientsForCooking;
    }
        
    public override string ToString()
    {
        return $"{NameCoffee} : {VolumeCoffee} мл | {CostCoffee} руб";
    }
}
