namespace ControlWork1;

public class Task4
{
    public static bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }
        
        
        if (x.ToString().Length == 1)
        {
            return true;
        }
        
        string strX = x.ToString();
        for(int i = 0; i < strX.Length/2; i++)
        {
               
            if (strX[i] != strX[strX.Length - 1 - i])
            {
                return false;
            }
        }
        return true;      
    }
}
    


