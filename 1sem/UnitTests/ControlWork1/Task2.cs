namespace ControlWork1;

public class Task2
{
    public static int IsLower(string lower)
    {
        if (lower == null)
        {
            throw new ArgumentNullException(nameof(lower), "не должен принимать null");
        }

        if (lower.Length == 0)
        {
            throw new ArgumentException("не должен быть путым",nameof(lower));
        }
        int c = 0;
        for(int i = 0; i < lower.Length; i ++)
        {
            if (Char.IsLower(lower[i]))
            {
                c++;
            }
        }
        return c;
    }
}
