namespace CW2;

public class ParallelProcessor
{
    public List<object> list = new();
    public void CustomProcess(List<object> objects)
    {
        int chunkSize = 250;
        AttributeFilter filter = new AttributeFilter();

        Parallel.For(0, 4, i =>
        {
            int start = i * chunkSize;
            List<object> chunk = objects.GetRange(start, chunkSize);

            int threadId = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine($"Thread {threadId} обработал {chunk.Count} объектов");

            List<object> validObjects = filter.GetValidObjects(chunk);

            foreach (object obj in validObjects)
            {
                Console.WriteLine($"Thread {threadId}: {obj.GetType().Name}");
            }
        });
    }

    public void GenerateDate()
    {
        for (int i = 0; i < 1000; i++)
        {
            list.Add("ab");
        }
    }
    
}


















