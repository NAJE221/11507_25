using System.Reflection;

namespace CW2;

public class AttributeFilter
{
    public List<object> GetValidObjects(List<object> objects)
    {
        List<object> validationDate = new();
        foreach(var obj in objects)
        {
            PropertyInfo[] properties = obj.GetType().GetProperties();
            foreach (var prop in properties)
            {
                object[] attrs = prop.GetCustomAttributes(typeof(Sensitive),false);
                if (attrs.Length > 0)
                {
                    validationDate.Add(obj);
                    break;
                }
            }
        }
        return validationDate;
    }
}