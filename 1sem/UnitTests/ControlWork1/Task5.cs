namespace ControlWork1;

public class Task5
{
    public static int[] RunningSum(int[] nums)
    {
        if (nums == null)
        {
            throw new ArgumentNullException(nameof(nums), "массив не должно принимать значение null");
        }
        if (nums.Length == 0)
        {
            throw new ArgumentException("массив не должен быть пустым", nameof(nums));
        }
        int[] result = new int[nums.Length];
        int sum = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            for( int j = 0; j < i; j ++)
            {
                result[i] += nums[j];
            }
            Console.WriteLine(result[i]);
        }
        return result;    
    }
}

