namespace HomeWork.Practice4.DataFiltering;

public class Process1
{
    public Process1()
    {
        Console.WriteLine("\n--- С зарплатой более 50,000 ---");
        Filters salaryFilter = new();
        salaryFilter.FilterEmployers(ListEmployee.List, salaryFilter.SalaryFilter);
        Console.WriteLine("\n--- Со стажем более 5 лет ---");
        salaryFilter.FilterEmployers(ListEmployee.List, salaryFilter.SeniorityFilter);
    }
}