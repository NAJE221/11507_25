public class Lq3
{
    public IEnumerable<string> GetValidString(IEnumerable<string> input)
    {
        return input.MyWhere(s => s.MyGroupBy().MyAll(g => g.MyCount() < 2));
    }
}