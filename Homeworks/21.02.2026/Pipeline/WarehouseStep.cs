public class WarehouseStep : PipelineStep<int, Product>
{
    private Dictionary<int, Product> productsBase = new()
    {
        {1, new Product("Молоко", 250)},
        {2, new Product("Шоколадка", 100)}
    };

    public override Product Process(int idProduct)
    {
        if (!productsBase.ContainsKey(idProduct))
        {
            throw new KeyNotFoundException($"id: {idProduct} не найден");
        }
        return productsBase[idProduct];
    }
}