using CoffeeMachine.Objects;
using CoffeeMachine.Products;

namespace CoffeeMachine.Processes.MakingCoffee.SecondaryMethods;
using static ProductDataBase;
using static CoffeeMachine.InputOutput.Validation;

public class SecondaryMethods : BuildOrder.BuildOrder
{
    #region CalculatingPrice
    public static decimal CalculatingPriceSupplements()
    {
        decimal priceSupplements = 0;
        for (int i = 0; i < selectedSupplements.Count; i++)
        {
            priceSupplements += ListSupplements[selectedSupplements[i] - 1].CostSupplements;
        }

        return priceSupplements;
    }
    #endregion
   
    #region PrintSupplements
    public static void PrintSupplements()
    {
        for (int i = 0; i < selectedSupplements.Count; i++)
        {
            Console.WriteLine($"{i+1}. {ListSupplements[selectedSupplements[i]-1]}");
        }
    }
    #endregion
    
    public static void CheckingIngredientShortages(int indexCoffee)
    {
        if (indexCoffee < 0)
        {
            return;
        }
        var currentCoffee = ListCoffees[indexCoffee];

        bool unsuitableCoffee = false;
        foreach (var ingredient in ListIngredients)
        {
            if (unsuitableCoffee)
            {
                break;
            }
            foreach (var ingredientCoffee in currentCoffee.IngredientsForCooking)
            {
                if (!Equals(ingredient.NameIngredient, ingredientCoffee.Key))
                {
                    continue;
                }
                if (ingredient.AmountIngredient < ingredientCoffee.Value)
                {
                    unsuitableCoffee = true;
                    break;
                }
            }
        }
        if (unsuitableCoffee == false)
        {
            userCoffeeList.Add(currentCoffee);
        }
        --indexCoffee;
        CheckingIngredientShortages(indexCoffee);
    }
    
    #region WritingOffIngredients
    public static void WritingOffIngredients()
    {
        var ingredientsCoffee = ListCoffees[selectedCoffee - 1].IngredientsForCooking;
        foreach (var ingredientCoffee in ingredientsCoffee)
        {
            foreach (var ingredient in ListIngredients)
            {
                if(Equals(ingredientCoffee.Key,ingredient.NameIngredient))
                {
                    ingredient.AmountIngredient -= ingredient.AmountIngredient / ingredientCoffee.Value;
                }
            }
        }
    }
    #endregion
}