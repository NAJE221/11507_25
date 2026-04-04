using CoffeeMachine.JsonProcess;
using CoffeeMachine.Menu;

namespace CoffeeMachine.Processes.MainProcess;

public class MainProcess
{
    public static bool FlagRun = true; 
    public static void Run()
    {
        DeserializeProcess.WritingToList();
        while (FlagRun)
        {
            ProcessMenu.Process();
        }
    }
}