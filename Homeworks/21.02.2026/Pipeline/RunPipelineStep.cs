public class RunPipelineStep
{
    private WarehouseStep _warehouseStep1 = new();
    private PaymentStep _pymentStep1 = new();
    private LoggerStep _loggerStep = new();

    public RunPipelineStep()
    {
        var result = _warehouseStep1
            .Step(_pymentStep1)
            .Step(_loggerStep);

        Console.Write("Введите ID товара: ");
        int id;
        int.TryParse(Console.ReadLine(), out id);
        Console.WriteLine(result.Process(id)); 
    }
}