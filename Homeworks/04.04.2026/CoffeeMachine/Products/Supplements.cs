namespace CoffeeMachine.Objects;

[Serializable]
public class Supplements
{
    public string NameSupplements { get; init; }
    public decimal CostSupplements{ get; init; }

    public Supplements(string nameSupplements, decimal costSupplements)
    {
        NameSupplements = nameSupplements;
        CostSupplements = costSupplements;
    }

    public override string ToString()
    {
        return $"{NameSupplements} : {CostSupplements} руб";
    }
} 