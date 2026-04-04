using CoffeeMachine.AdminPanel;
using CoffeeMachine.Processes.MakingCoffee;
using CoffeeMachine.Processes.MakingCoffee.BuildOrder;

namespace CoffeeMachine.Menu;

public class CkeckValidationMenu
{
    public static void Ckeck(int Validation)
    {
        switch (Validation)
        {
            case 1 :
                BuildOrder.RunBuilder();
                break;
            case 2 :
                ProcessPanel.Process();
                break;
        }
    }
}