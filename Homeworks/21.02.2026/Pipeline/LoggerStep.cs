public class LoggerStep : PipelineStep <Receipt , string>
{
    public override string Process(Receipt input)
    {
        var result = "===================== ЧЕК =====================\n" +
                     $"Товар: {input.FullName}: {input.FinelPrice} руб\n" +
                     $"Дата покупки: {input.Date}\n" +
                     $"Оплата успешно прошла!\n"+
                     $"================ До свидания:) ================";
        return result;
    }
}