public class Employee
{
    public readonly string Name;
    public readonly decimal Salary;
    public readonly int Experience;

    public Employee(string name, decimal salary, int experience)
    {
        Name = name;
        Salary = salary;
        Experience = experience;
    }
    
    public override string ToString()
    {
        return $"Имя: {Name}, Зарплата: {Salary}, Стаж: {Experience}";
    }
}