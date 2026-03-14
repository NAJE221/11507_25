namespace HomeWork.Practice4.DataFiltering;
public class Filters
{
    public void FilterEmployers(List<Employee> employees, Predicate<Employee>  predicate)
    {
        foreach (var emp in employees)
        {
            if (predicate(emp))
            {
                Console.WriteLine(emp);
            }
        }
    }
    
    public bool SalaryFilter(Employee employe)
    {
        if (employe.Salary > 50000m)
        {
            return true;
        }
        return false;
    }

    public bool SeniorityFilter(Employee employee)
    {
        if (employee.Experience > 5)
        {
            return true;
        }
        return false;
    }
}