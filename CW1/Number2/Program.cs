using Number2;
class Program
{
    static void Main(string[] args)
    {
        Thermostat thermostat = new Thermostat();

        thermostat.SharpChangeDetected += OnSharpTemperatureChange;

        Console.WriteLine("Начальная температура: 20°C");
        thermostat.UpdateTemperature(22);
        thermostat.UpdateTemperature(28);
        
    }

   
    static void OnSharpTemperatureChange(object sender, TemperatureEventArgs e)
    {
        Console.WriteLine($"ВНИМАНИЕ! Резкий скачок: с {e.OldTemp} на {e.NewTemp} (разница: {e.Difference} град.)");
    }
}