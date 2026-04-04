using CoffeeMachine.InputOutput;
using CoffeeMachine.Panels.AdminPanel;

namespace CoffeeMachine.AdminPanel;

using ValidationOutput;
public class ProcessPanel
{
    public static void Process()
    {
        var userValidation = Validation.ValidationCommands(CommandsAdminPanel.Commands, Output.PrintList,
            "---------- АдминПанель ----------",
            "Введите команду: ");
        CkeckValidationAdminPanel.Ckeck(userValidation);
    }
}