using CoffeeMachine.Decorations;
using CoffeeMachine.Processes.MainProcess;
using static CoffeeMachine.Processes.ActionsWithProducts.Replenishment.ReplenishmentIngredients;
using static  CoffeeMachine.Processes.ActionsWithProducts.Add.AddIngredients;
using static CoffeeMachine.Processes.ActionsWithProducts.Add.AddCoffee;
using static CoffeeMachine.Processes.ActionsWithProducts.Remove.Remove;
using static CoffeeMachine.Processes.ClosingTheShift.ClosingTheShift;
namespace CoffeeMachine.Panels.AdminPanel;

public class CkeckValidationAdminPanel
{
    public static void Ckeck(int Validation)
    {
        switch (Validation)
        {
            case 1 :
                AddingCoffee();
                break;
            case 2 :
                RemoveCoffee();
                break;
            case 3 :
                AddingIngredients();
                break;
            case 4 :
                RemoveIngredients();
                break;
            case 5 :
                Replenishment();
                break;
            case 6 :
                Clossing();
                break;
            case 7 :
                AnimationShutdown();
                break;
        }
    }

    #region AnimationShutdown
    private static void AnimationShutdown()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.Clear();
            Animation.AnimationText("Выключение автомата...",50);
            Thread.Sleep(50);
        }
        Console.Clear();
        MainProcess.FlagRun = false;
    }
    #endregion
    
}