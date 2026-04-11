namespace Number2;

public class TemperatureEventArgs : EventArgs
{
    public int OldTemp { get; set; }
    public int NewTemp { get; set; }
    public int Difference { get; set; }
}

public class Thermostat
{
    private int _lastTemp = 20;
    public event EventHandler<TemperatureEventArgs> SharpChangeDetected;
    public void UpdateTemperature(int newTemp)
    {
        int difference = Math.Abs(newTemp - _lastTemp);

        if (difference >= 5)
        {
            SharpChangeDetected?.Invoke(this, new TemperatureEventArgs
            {
                OldTemp = _lastTemp,
                NewTemp = newTemp,
                Difference = difference
            });
        }

        _lastTemp = newTemp;
    }
}



