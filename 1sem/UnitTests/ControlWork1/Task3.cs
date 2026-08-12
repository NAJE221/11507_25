using System.ComponentModel.DataAnnotations;

namespace ControlWork1;
public class Task3
{
    public static char Position(string s)
    {
        
        if (s == null)
        {
            throw new ArgumentNullException(nameof(s),"не должно принимать null");
        }

        if (s.Length == 0)
        {
            throw new ArgumentException("строка не должна быть пустая", nameof(s));
        }
        
            if (s.Length < 3)
            {
                throw new ArgumentException("Строка должна содержать не меньше 3 символов");
            }
        char positionElement = s[^3];
        return positionElement;
    }
}
