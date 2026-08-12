using System;
using NUnit.Framework;
using ControlWork1;
// Тесты для 1 теста
namespace ControlWork1.Tests;

[TestFixture]
public class Task1Tests
{
    [Test]
    public void CheckingForNull()
    {
        int[] nums = null;
        Assert.Throws<ArgumentNullException>(() => Task1.Sort(nums));
    }

    [Test]
    public void CheckingForAnEmptyString()
    {
        int[] nums = new int[0];
        Assert.Throws<ArgumentException>(() => Task1.Sort(nums));
    }

    [Test]
    public void SortingCheck1()
    {
        int[] nums = { 1, 4, 5, 2 };
        Task1.Sort(nums);
        Assert.AreEqual(new int[] {1,2,4,5},nums);
    }

    [Test]
    public void SortingCheck2()
    {
        int[] nums = { 1, 6, 8, 9 };
        Task1.Sort(nums);
        Assert.AreEqual(new int[] {1,6,8,9}, nums);
    }

    [Test]
    public void SortingCheck3()
    {
        int[] nums = { 1 };
        Task1.Sort(nums);
        Assert.AreEqual(new int[]{1},nums);
    }

    [Test]
    public void CheckingSortingOnNegativeNumbers()
    {
        int[] nums = { -1, -3, -2 };
        Task1.Sort(nums);
        Assert.AreEqual(new int[] {-3,-2,-1}, nums);
    }
}


// Тесты для 2 тест
[TestFixture] 
public class Task2Tests
{
    [Test]
    public void CheckingForNull()
    {
        string lower = null;
        Assert.Throws<ArgumentNullException>(() => Task2.IsLower(lower));
    }

    [Test]
    public void CheckingForAnEmptyString()
    {
        string lower = string.Empty;
        Assert.Throws<ArgumentException>(() => Task2.IsLower(lower));
    }

    [Test]
    public void CheckingForTheNumberOfSmallLetters1()
    {
        string lower = "a";
        Assert.AreEqual(1, Task2.IsLower(lower));
    }

    [Test]
    public void CheckingForTheNumberOfSmallLetters2()
    {
        string lower = "A";
        Assert.AreEqual(0, Task2.IsLower(lower));
    }

    [Test]
    public void CheckingForTheNumberOfSmallLetters3()
    {
        string lower = "abcABC";
        Assert.AreEqual(3, Task2.IsLower(lower));
    }

    [Test]
    public void CheckingForTheNumberOfSmallLetters4()
    {
        string lower = "abcABCadafafgatqetrqfadsgsughndagiosdmhidsb1o1";
        Assert.AreEqual(41, Task2.IsLower(lower));
    }
}

// Тесты для 3 задания
[TestFixture]
public class Task3Tests
{
    [Test]
    public void CheckingForNull()
    {
        string s = null;
        Assert.Throws<ArgumentNullException>(() => Task3.Position(s));
    }

    [Test]
    public void CheckingForAnEmptyString()
    {
        string s = string.Empty;
        Assert.Throws<ArgumentException>(() => Task3.Position(s));
    }

    [Test]
    public void CheckingForLineBreaks()
    {
        string s = "AB";
        Assert.Throws<ArgumentException>(() => Task3.Position(s));
    }

    [Test]
    public void CheckingForThe3rdElementFromTheEnd1()
    {
        string s = "ABC";
        Assert.AreEqual('A', Task3.Position(s));
    }

    [Test]
    public void CheckingForThe3rdElementFromTheEnd2()
    {
        string s = "ABCDDDD!@#$123";
        Assert.AreEqual('1', Task3.Position(s));
    }
}


// Тесты для 4 задания
[TestFixture]
public class Task4Tests
{
    [Test]
    public void CheckingThatTheArgumentIsAPalindrome1()
    {
        int result = 121;
        Assert.IsTrue(Task4.IsPalindrome(result));
    }
    
    [Test]
    public void CheckingThatTheArgumentIsAPalindrome2()
    {
        int result = 1001;
        Assert.IsTrue(Task4.IsPalindrome(result));
    }

    [Test]
    public void CheckingThatTheArgumentIsNotAPalindrome1()
    {
        int result = 122;
        Assert.IsFalse(Task4.IsPalindrome(result));
    }
    
    [Test]
    public void CheckingThatTheArgumentIsNotAPalindrome2()
    {
        int result = 1000;
        Assert.IsFalse(Task4.IsPalindrome(result));
    }

    [Test]
    public static void CheckingЕoSeeIfASingleDigitReturnsTrue()
    {
        int result = 4;
        Assert.IsTrue(Task4.IsPalindrome(result));
    }
    
    [Test]
    public static void TheTestIsThatTheNumberIsNegative()
    {
        int result = -4;
        Assert.IsFalse(Task4.IsPalindrome(result));
    }
    
    // Нет, отрицательные числа не могут быть палиндромами. 
}

// Тесты для задания 5
[TestFixture]
public class Task5Tests
{
    [Test]
    public void CheckingWhetherAStringIsNull()
    {
        int[] nums = null;
        Assert.Throws<ArgumentNullException>(() => Task5.RunningSum(nums));
    }

    [Test]
    public void CheckingThatTheString()
    {
        int[] nums = new int [0];
        Assert.Throws<ArgumentException>(() => Task5.RunningSum(nums));
    }
    
    [Test]
    public void CheckingHowTheRunningSumMethodWorks1()
    {
        int[] nums = {0,3,14,8,2,94};
        Assert.AreEqual(new int[] {0,0,3,17,25,27}, Task5.RunningSum(nums));
    }
    [Test]
    public void CheckingHowTheRunningSumMethodWorks2()
    {
        int[] nums = { 1, 2, 3, 6 };
        Assert.AreEqual(new int[] {0,1,3,6}, Task5.RunningSum(nums));
    }
    [Test]
    public void TestingTheRunningSumMethodWithASingleArgument()
    {
        int[] nums = {1};
        Assert.AreEqual(new int[] {0}, Task5.RunningSum(nums));
    }
    
    [Test]
    public void TheSumWithNegativeNumbers()
    {
        int[] nums = {-1, -3, -5, -6};
        Assert.AreEqual(new int[] {0 ,-1 ,-4 ,-9}, Task5.RunningSum(nums));
    }
}

// Тесты для 6 задания
[TestFixture]
public class UnitTest6
{
    [Test]
    public void CheckingThatTheStringIsNull()
    {
        int number;
        string str = null;
        Assert.Throws<ArgumentNullException>(()=>Task6.TryParse1(str,out number));
    }

    [Test]
    public void CheckingForAnEmptyString()
    {
        int number;
        string str = string.Empty;
        Assert.Throws<ArgumentException>(() => Task6.TryParse1(str, out number));
    }

    [Test]
    public void CheckingThatTheInputIsNotANumber1()
    {
        int number;
        string str = "abc";
        Assert.IsFalse(Task6.TryParse1(str, out number));
        Assert.AreEqual(0, number);
    }
    
    [Test]
    public void CheckingThatTheInputIsNotANumber2()
    {
        int number;
        string str = "Hello World";
        Assert.IsFalse(Task6.TryParse1(str, out number));
        Assert.AreEqual(0, number);
    }
    
    [Test]
    public void CheckingThatTheInputIsNotANumber3()
    {
        int number;
        string str = "123 123";
        Assert.IsFalse(Task6.TryParse1(str, out number));
        Assert.AreEqual(0, number);
    }

    [Test]
    public void CheckingThatANumberIsBeingSupplied1()
    {
        int number;
        string str = "123";
        Assert.IsTrue(Task6.TryParse1(str, out number));
        Assert.AreEqual(123, number);
    }
    
    [Test]
    public void CheckingThatANumberIsBeingSupplied2()
    {
        int number;
        string str = "-12309764";
        Assert.IsTrue(Task6.TryParse1(str, out number));
        Assert.AreEqual(-12309764, number);
    }
}

