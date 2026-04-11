namespace CW1;

public class Machine
{
    public string Id { get; set; }
    public string Category { get; set; }
    public bool IsBroken { get; set; }
    public int DaysSinceLastService { get; set; }

    public Machine(string id, string category, bool isBroken, int daysSinceLastService)
    {
        Id = id;
        Category = category;
        IsBroken = isBroken;
        DaysSinceLastService = daysSinceLastService;
    }

    public override string ToString()
    {
        return $"{Id} - {Category} - {IsBroken} - {DaysSinceLastService}";
    }
}

public class Factory
{
    private List<Machine> _machines = new List<Machine>();

    public void AddMachine(Machine m)
    {
        _machines.Add(m);
    }

    public IEnumerable<Machine> GetServiceRequired()
    {
        foreach (var machine in _machines)
        {
            if (machine.IsBroken || machine.DaysSinceLastService > 30)
            {
                yield return machine;
            }
        }
    }

    public IEnumerable<Machine> GetMachinesByCategory(string category)
    {
        foreach (var machine in _machines)
        {
            if (machine.Category == category)
            {
                yield return machine;
            }
        }
    }
}