namespace ControlWork1;


public class Task6
{
    public static bool TryParse1(string str, out int number)
    {
        if (str == null)
        {
            throw new ArgumentNullException(nameof(str),"str не должно принимать значение null");
        }

        if (str.Length == 0)
        {
            throw new ArgumentException("не должно быть пустым",nameof(str));
        }
        
        number = 0;
        bool istTrueOrFalse = true;
        for(int i = 0; i < str.Length; i++)
        {
            if (str[0] == '-') continue;
            if(Char.IsDigit(str[i]) == false)
            {
                istTrueOrFalse = false;
                break;
            }
        }
        if(istTrueOrFalse == true)
        {
            number = int.Parse(str);
        }
        return istTrueOrFalse;
    }
}

