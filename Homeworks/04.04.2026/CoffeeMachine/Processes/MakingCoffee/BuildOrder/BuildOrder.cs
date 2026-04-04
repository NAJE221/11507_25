using CoffeeMachine.InputOutput;
using CoffeeMachine.Products;
using CoffeeMachine.ValidationOutput;

namespace CoffeeMachine.Processes.MakingCoffee.BuildOrder;
using static Output;
using static ProductDataBase;
using static SecondaryMethods.SecondaryMethods;
using static Decorations.Animation;
using static Decorations.ColoringObject;
using static Validation;

public class BuildOrder
{
    protected static int selectedCoffee;
    protected static List<int> selectedSupplements = new();
    protected static List<Coffee> userCoffeeList = new();
    private static void SelectionCoffee()
    {
        Console.Clear();
        PrintList(userCoffeeList);
        selectedCoffee = ValidationCommands(userCoffeeList, PrintList, 
            "---------- ВыборКофе ----------",
            "Выберите позицию: ");
    }
    
    private static void SelectionSupplements()
    {
        bool selected = true;
        while (selected)
        {
            
            Console.Clear();
            Coloring($"Выбранная позиция: {userCoffeeList[selectedCoffee-1]}", ConsoleColor.Green);
            selectedSupplements.Add(ValidationCommands(ListSupplements, PrintList, 
                "---------- ВыборДобавок ----------",
                "Выберите добавку: "));

            if (Equals(ListSupplements[selectedSupplements[0] - 1].NameSupplements, "Без добавок")) break;
            
            byte userSelection;
            List<string> continueOrStop = new()
            {
                "Да",
                "Нет"
            };
            userSelection = (byte)ValidationCommands(continueOrStop, PrintList, 
                "Доп.Допинг", 
                "Введите значение (1-2): ");
            
            if (userSelection == 1)
            {
                if (Equals(ListSupplements[0].NameSupplements, "Без добавок"))
                {
                    ListSupplements.RemoveAt(0);
                    for (int i = 0; i < selectedSupplements.Count; i++)
                    {
                        selectedSupplements[i]-=1;
                    }
                }
            }
            else 
            {
                ListSupplements.Insert(0, new("Без добавок", 0));
                for (int i = 0; i < selectedSupplements.Count; i++)
                {
                    selectedSupplements[i]+=1;
                }
                selected = false;
            }
        }
    }
    private static void PaymentOrder()
    {
        decimal parsed;
        
        var finalPrice = userCoffeeList[selectedCoffee-1].CostCoffee
                         + CalculatingPriceSupplements();
        bool isParsed;
        do
        {
            Console.Clear();
            Console.WriteLine("---------- Оплата ----------");
            Coloring($"Выбранная позиция: ", ConsoleColor.Yellow);
            Console.WriteLine($"{userCoffeeList[selectedCoffee - 1]}");
            
            Coloring($"Выбранная добавка (-и):", ConsoleColor.Yellow);
            PrintSupplements();
            
            Coloring($"К оплате: {finalPrice}", ConsoleColor.Green);
            AnimationText("Внесите оплату: ",2);
            isParsed = decimal.TryParse(Console.ReadLine(), out parsed);
            if (!isParsed)
            {
                ColoringDelayed("Здесь должно быть число!", ConsoleColor.Red, 2000);
            }
            else if (parsed < finalPrice)
            {
                ColoringDelayed("Недостаточно средств!", ConsoleColor.Red, 2000);
            }
            else if (parsed > finalPrice)
            {
                Console.Clear();
                AnimationText($"Сдача: {parsed - finalPrice} руб", 3);
                Thread.Sleep(2000);
            }
        } while (!isParsed || parsed < finalPrice);
    }
    private static void Order()
    {
        Console.Clear();
        Console.WriteLine("---------- В Процессе ----------");
        WritingOffIngredients();
        Loading();
        Console.Clear();
        Console.WriteLine("---------- Успех! ----------");
        Console.ForegroundColor = ConsoleColor.Green;
        AnimationText("Ваш кофе готов! Хорошего дня",3);
        Console.ResetColor();
        Thread.Sleep(1500);
        Logger.Logging($"Продано: {userCoffeeList[selectedCoffee-1]}");
    }

    public static void RunBuilder()
    {
        CheckingIngredientShortages(ListCoffees.Count()-1);
        if (PositionExist(userCoffeeList,"Напитков нет в наличии!") && 
            PositionExist(ListIngredients,"В автомате нет ингредиентов!"))
        {
            SelectionCoffee();
            SelectionSupplements();
            PaymentOrder();
            Order();
        }
        userCoffeeList = null;
    }
}