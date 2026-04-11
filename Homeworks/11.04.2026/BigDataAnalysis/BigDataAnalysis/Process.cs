using System.Diagnostics;
namespace BigDataAnalysis;

public class Process
{
    private static string _path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "bigdata.txt");
    public static void Writing()
    {
        Stopwatch writing = new Stopwatch();
        writing.Start();
        using (var writeFile = new StreamWriter(_path))
        {
            for (int i = 0; i < 50_000_000; i++)
            {
                writeFile.WriteLine("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789");
            }
        }
        writing.Stop();
        Console.WriteLine($"Запись в файл прошла за: {writing.Elapsed}");
    }

    public static void Reading()
    {
        Stopwatch reading = new Stopwatch();
        reading.Start();
        using (var readFile = new FileStream(_path, FileMode.Open, FileAccess.Read))
        {
            var buffer = new byte[65536];
            long counterA = 0;
            int bytesRead;
            while ((bytesRead = readFile.Read(buffer, 0, buffer.Length)) > 0)
            {
                for (int i = 0; i < bytesRead; i++)
                {
                    if (buffer[i] == 65)
                    {
                        counterA++;
                    }
                }
            }
            Console.WriteLine($"Кол-во A : {counterA}" );
        }
        reading.Stop();
        Console.WriteLine($"Файл был прочитан за : {reading.Elapsed}");
    }
}