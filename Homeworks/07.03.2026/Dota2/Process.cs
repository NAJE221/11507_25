using System;
using System.Linq;
namespace Dota2;
using static Print;
using static Sorted;
public class Process
{
    public static void Launch()
    {
        int input;
        do
        {
            PrintMenu();
        }
        while(!int.TryParse(Console.ReadLine() , out input) || input < 1 || input > 12);
        CheckingTheInput(input);
    }

    public static void CheckingTheInput(int input)
    {
        switch (input)
        {
            case 1:
                SortedComplexity();
                break;
            case 2:
                SortedTypeAttribute();
                break;
            case 3:
                SortedTypeAttack();
                break;
            case 4:
                SortedHealth();
                break;
        }
    }
}