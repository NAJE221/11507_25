using System.Numerics;

namespace CoffeeMachine.InputOutput;
using static Decorations.ColoringObject;

public class Validation
{
    public static string ValidationString(string Validation)
    {
        string userValidation;
        do
        {
            Console.Clear();
            Console.Write(Validation);
            userValidation = Console.ReadLine();
            if (userValidation.Length < 3)
            {
                ColoringDelayed("Длина названия должна быть больше 3!", ConsoleColor.Red, 3000);
            }
        } while (userValidation.Length < 3);
        return userValidation;
    }
    
    public static T ValidationNumber<T>(string title,ConsoleColor color, string text, bool cleanerCondition) where T : IParsable<T>, INumber<T>
    {
        T parsed;
        bool isParsed;
        do
        {
            if (cleanerCondition)
            {
                Console.Clear();
            }
            if (title != null)
            {
                Coloring(title, color);
            }
            Console.Write(text);
            isParsed = T.TryParse(Console.ReadLine(), null, out parsed);
            if (!isParsed)
            {
                ColoringDelayed("Не должно быть букв!", ConsoleColor.Red, 2000);
            }
            else if (parsed < T.Zero)
            {
                ColoringDelayed("Число не должно быть отрицательным!", ConsoleColor.Red, 2000);
            }
        } while (!isParsed || parsed < T.Zero);
        return parsed;
    }
    
    public static short ValidationCommands<T>(List<T> list, Action<List<T>> printMethod , string title, string Validation)
    {
        short parseNumber;
        bool isParsed;
        do
        {
            Console.Clear();
            if (title != null)
            {
                Console.WriteLine(title);
            }
            printMethod(list);
            Console.Write(Validation);
            isParsed = short.TryParse(Console.ReadLine(), out parseNumber);
            
            if (!isParsed)
            {
                ColoringDelayed("Не должно быть букв!", ConsoleColor.Red, 2000);
            }
            else if (parseNumber < 1)
            {
                ColoringDelayed("Число не должно быть меньше 1!", ConsoleColor.Red, 2000);
            }
            else if (parseNumber > list.Count)
            {
                ColoringDelayed("Число не должно быть больше длинны списка команд!", ConsoleColor.Red, 3000);
            }
        } while (!isParsed || parseNumber < 1 || parseNumber > list.Count);
        return parseNumber;
    }

    public static bool PositionExist<T>(List<T> listPositions, string textError)
    {
        if (!(listPositions == null || listPositions.Count == 0))
        {
            return true;
        }
        ColoringDelayed(textError, ConsoleColor.Red, 2000);
        return false;
    }

    public static bool IsNull<T>(List<T> list) => list == null;
}
