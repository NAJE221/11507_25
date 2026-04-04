using CoffeeMachine.InputOutput;

namespace CoffeeMachine.Menu;

using ValidationOutput;

public class ProcessMenu
{
    public static void Process()
    {
        var userValidation = Validation.ValidationCommands(CommandsMenu.Commands, Output.PrintList,
            "----------- КОФЕМАШИНА -----------", 
            "Введите команду: ");
        CkeckValidationMenu.Ckeck(userValidation);
    }
}
