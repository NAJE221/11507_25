using System.Text.Json;

namespace Number3;

public class Process
{
    string path = Path.Combine(Directory.GetCurrentDirectory(), "settings.ini");
    public Dictionary<string, string> DictionaryNew = new();
    
    public IEnumerable<Dictionary<string, string>> ReadKey()
    {
        using (var reader = new StreamReader(path))
        {
            string line;
            string[] arrayLines = new string[1];
            while ((line = reader.ReadLine()) != null)
            {
                arrayLines = line.Split("=");
                DictionaryNew[arrayLines[0]] = arrayLines[1];
                yield return DictionaryNew;
            }
        }
    }
    
}