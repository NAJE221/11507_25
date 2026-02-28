public class Receipt
{
    public readonly string FullName;
    public readonly decimal FinelPrice;
    public readonly DateTime Date;
    public Receipt(string fullName, decimal finelPrice)
    {
        FullName = fullName;
        FinelPrice = finelPrice;
        Date =  DateTime.Now;
    }
}